﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.ДокументыСсылка;
using V82.Документы;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Документы//Менеджер
{
	///<summary>
	///(общ)
	///</summary>
	public partial class КомплектацияНоменклатуры:ДокументМенеджер
	{
		
		public static ДокументыСсылка.КомплектацияНоменклатуры НайтиПоСсылке(Guid _Ссылка)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld8690RRef [ВидКомплектации]
					,_Fld8691RRef [ВидОперации]
					,_Fld8692RRef [ЕдиницаИзмерения]
					,_Fld8693_TYPE [ЗаказВыпуска_Тип],_Fld8693_RRRef [ЗаказВыпуска],_Fld8693_RTRef [ЗаказВыпуска_Вид]
					,_Fld8694_TYPE [ЗаказРезерв_Тип],_Fld8694_RRRef [ЗаказРезерв],_Fld8694_RTRef [ЗаказРезерв_Вид]
					,_Fld8695 [Количество]
					,_Fld8696 [Комментарий]
					,_Fld8697 [Коэффициент]
					,_Fld8698RRef [НДСвСтоимостиТоваров]
					,_Fld8699RRef [Номенклатура]
					,_Fld8700RRef [НоменклатурнаяГруппа]
					,_Fld8701RRef [Организация]
					,_Fld8702RRef [Ответственный]
					,_Fld8703 [ОтражатьВБухгалтерскомУчете]
					,_Fld8704 [ОтражатьВНалоговомУчете]
					,_Fld8705 [ОтражатьВУправленческомУчете]
					,_Fld8706RRef [Подразделение]
					,_Fld8707RRef [ПодразделениеОрганизации]
					,_Fld8708RRef [СерияНоменклатуры]
					,_Fld8709RRef [Склад]
					,_Fld8710RRef [Спецификация]
					,_Fld8711RRef [СпособСписанияОстаткаТоваров]
					,_Fld8712RRef [СтатусПартии]
					,_Fld8713RRef [СтатьяЗатратСписанияНДС]
					,_Fld8714RRef [СчетУчетаБУ]
					,_Fld8715RRef [СчетУчетаНУ]
					,_Fld8716RRef [СчетСписанияНДС]
					,_Fld8717RRef [СубконтоСписанияНДС1]
					,_Fld8718RRef [СубконтоСписанияНДС2]
					,_Fld8719RRef [СубконтоСписанияНДС3]
					,_Fld8720RRef [СчетСписанияНДСНУ]
					,_Fld8721RRef [СубконтоСписанияНДСНУ1]
					,_Fld8722RRef [СубконтоСписанияНДСНУ2]
					,_Fld8723RRef [СубконтоСписанияНДСНУ3]
					,_Fld8724RRef [ХарактеристикаНоменклатуры]
					,_Fld8725RRef [Контрагент]
					,_Fld8726RRef [ДоговорКонтрагента]
					,_Fld8727RRef [СчетЗатрат]
					,_Fld8728RRef [СчетЗатратНУ]
					,_Fld8729RRef [СтатьяЗатрат]
					,_Fld8730_TYPE [Заказ_Тип],_Fld8730_RRRef [Заказ],_Fld8730_RTRef [Заказ_Вид]
					,_Fld8731 [ЦенаПередачи]
					,_Fld8732 [СуммаПередачи]
					From _Document415(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.КомплектацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидКомплектации = V82.Перечисления/*Ссылка*/.ВидыКомплектации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийКомплектацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Количество = Читалка.GetDecimal(12);
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Ссылка.НДСвСтоимостиТоваров = V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(20))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(21))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СпособСписанияОстаткаТоваров = V82.Перечисления/*Ссылка*/.СпособыСписанияОстаткаТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.СтатусПартии = V82.Перечисления/*Ссылка*/.СтатусыПартийТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Ссылка.ЦенаПередачи = Читалка.GetDecimal(50);
							Ссылка.СуммаПередачи = Читалка.GetDecimal(51);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static ДокументыСсылка.КомплектацияНоменклатуры НайтиПоНомеру(string Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld8690RRef [ВидКомплектации]
					,_Fld8691RRef [ВидОперации]
					,_Fld8692RRef [ЕдиницаИзмерения]
					,_Fld8693_TYPE [ЗаказВыпуска_Тип],_Fld8693_RRRef [ЗаказВыпуска],_Fld8693_RTRef [ЗаказВыпуска_Вид]
					,_Fld8694_TYPE [ЗаказРезерв_Тип],_Fld8694_RRRef [ЗаказРезерв],_Fld8694_RTRef [ЗаказРезерв_Вид]
					,_Fld8695 [Количество]
					,_Fld8696 [Комментарий]
					,_Fld8697 [Коэффициент]
					,_Fld8698RRef [НДСвСтоимостиТоваров]
					,_Fld8699RRef [Номенклатура]
					,_Fld8700RRef [НоменклатурнаяГруппа]
					,_Fld8701RRef [Организация]
					,_Fld8702RRef [Ответственный]
					,_Fld8703 [ОтражатьВБухгалтерскомУчете]
					,_Fld8704 [ОтражатьВНалоговомУчете]
					,_Fld8705 [ОтражатьВУправленческомУчете]
					,_Fld8706RRef [Подразделение]
					,_Fld8707RRef [ПодразделениеОрганизации]
					,_Fld8708RRef [СерияНоменклатуры]
					,_Fld8709RRef [Склад]
					,_Fld8710RRef [Спецификация]
					,_Fld8711RRef [СпособСписанияОстаткаТоваров]
					,_Fld8712RRef [СтатусПартии]
					,_Fld8713RRef [СтатьяЗатратСписанияНДС]
					,_Fld8714RRef [СчетУчетаБУ]
					,_Fld8715RRef [СчетУчетаНУ]
					,_Fld8716RRef [СчетСписанияНДС]
					,_Fld8717RRef [СубконтоСписанияНДС1]
					,_Fld8718RRef [СубконтоСписанияНДС2]
					,_Fld8719RRef [СубконтоСписанияНДС3]
					,_Fld8720RRef [СчетСписанияНДСНУ]
					,_Fld8721RRef [СубконтоСписанияНДСНУ1]
					,_Fld8722RRef [СубконтоСписанияНДСНУ2]
					,_Fld8723RRef [СубконтоСписанияНДСНУ3]
					,_Fld8724RRef [ХарактеристикаНоменклатуры]
					,_Fld8725RRef [Контрагент]
					,_Fld8726RRef [ДоговорКонтрагента]
					,_Fld8727RRef [СчетЗатрат]
					,_Fld8728RRef [СчетЗатратНУ]
					,_Fld8729RRef [СтатьяЗатрат]
					,_Fld8730_TYPE [Заказ_Тип],_Fld8730_RRRef [Заказ],_Fld8730_RTRef [Заказ_Вид]
					,_Fld8731 [ЦенаПередачи]
					,_Fld8732 [СуммаПередачи]
					From _Document415(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.КомплектацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидКомплектации = V82.Перечисления/*Ссылка*/.ВидыКомплектации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийКомплектацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Количество = Читалка.GetDecimal(12);
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Ссылка.НДСвСтоимостиТоваров = V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(20))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(21))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СпособСписанияОстаткаТоваров = V82.Перечисления/*Ссылка*/.СпособыСписанияОстаткаТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.СтатусПартии = V82.Перечисления/*Ссылка*/.СтатусыПартийТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Ссылка.ЦенаПередачи = Читалка.GetDecimal(50);
							Ссылка.СуммаПередачи = Читалка.GetDecimal(51);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static ДокументыВыборка.КомплектацияНоменклатуры Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld8690RRef [ВидКомплектации]
					,_Fld8691RRef [ВидОперации]
					,_Fld8692RRef [ЕдиницаИзмерения]
					,_Fld8693_TYPE [ЗаказВыпуска_Тип],_Fld8693_RRRef [ЗаказВыпуска],_Fld8693_RTRef [ЗаказВыпуска_Вид]
					,_Fld8694_TYPE [ЗаказРезерв_Тип],_Fld8694_RRRef [ЗаказРезерв],_Fld8694_RTRef [ЗаказРезерв_Вид]
					,_Fld8695 [Количество]
					,_Fld8696 [Комментарий]
					,_Fld8697 [Коэффициент]
					,_Fld8698RRef [НДСвСтоимостиТоваров]
					,_Fld8699RRef [Номенклатура]
					,_Fld8700RRef [НоменклатурнаяГруппа]
					,_Fld8701RRef [Организация]
					,_Fld8702RRef [Ответственный]
					,_Fld8703 [ОтражатьВБухгалтерскомУчете]
					,_Fld8704 [ОтражатьВНалоговомУчете]
					,_Fld8705 [ОтражатьВУправленческомУчете]
					,_Fld8706RRef [Подразделение]
					,_Fld8707RRef [ПодразделениеОрганизации]
					,_Fld8708RRef [СерияНоменклатуры]
					,_Fld8709RRef [Склад]
					,_Fld8710RRef [Спецификация]
					,_Fld8711RRef [СпособСписанияОстаткаТоваров]
					,_Fld8712RRef [СтатусПартии]
					,_Fld8713RRef [СтатьяЗатратСписанияНДС]
					,_Fld8714RRef [СчетУчетаБУ]
					,_Fld8715RRef [СчетУчетаНУ]
					,_Fld8716RRef [СчетСписанияНДС]
					,_Fld8717RRef [СубконтоСписанияНДС1]
					,_Fld8718RRef [СубконтоСписанияНДС2]
					,_Fld8719RRef [СубконтоСписанияНДС3]
					,_Fld8720RRef [СчетСписанияНДСНУ]
					,_Fld8721RRef [СубконтоСписанияНДСНУ1]
					,_Fld8722RRef [СубконтоСписанияНДСНУ2]
					,_Fld8723RRef [СубконтоСписанияНДСНУ3]
					,_Fld8724RRef [ХарактеристикаНоменклатуры]
					,_Fld8725RRef [Контрагент]
					,_Fld8726RRef [ДоговорКонтрагента]
					,_Fld8727RRef [СчетЗатрат]
					,_Fld8728RRef [СчетЗатратНУ]
					,_Fld8729RRef [СтатьяЗатрат]
					,_Fld8730_TYPE [Заказ_Тип],_Fld8730_RRRef [Заказ],_Fld8730_RTRef [Заказ_Вид]
					,_Fld8731 [ЦенаПередачи]
					,_Fld8732 [СуммаПередачи]
					From _Document415(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.КомплектацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.КомплектацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидКомплектации = V82.Перечисления/*Ссылка*/.ВидыКомплектации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийКомплектацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Количество = Читалка.GetDecimal(12);
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Ссылка.НДСвСтоимостиТоваров = V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(20))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(21))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СпособСписанияОстаткаТоваров = V82.Перечисления/*Ссылка*/.СпособыСписанияОстаткаТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.СтатусПартии = V82.Перечисления/*Ссылка*/.СтатусыПартийТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Ссылка.ЦенаПередачи = Читалка.GetDecimal(50);
							Ссылка.СуммаПередачи = Читалка.GetDecimal(51);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.КомплектацияНоменклатуры ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld8690RRef [ВидКомплектации]
					,_Fld8691RRef [ВидОперации]
					,_Fld8692RRef [ЕдиницаИзмерения]
					,_Fld8693_TYPE [ЗаказВыпуска_Тип],_Fld8693_RRRef [ЗаказВыпуска],_Fld8693_RTRef [ЗаказВыпуска_Вид]
					,_Fld8694_TYPE [ЗаказРезерв_Тип],_Fld8694_RRRef [ЗаказРезерв],_Fld8694_RTRef [ЗаказРезерв_Вид]
					,_Fld8695 [Количество]
					,_Fld8696 [Комментарий]
					,_Fld8697 [Коэффициент]
					,_Fld8698RRef [НДСвСтоимостиТоваров]
					,_Fld8699RRef [Номенклатура]
					,_Fld8700RRef [НоменклатурнаяГруппа]
					,_Fld8701RRef [Организация]
					,_Fld8702RRef [Ответственный]
					,_Fld8703 [ОтражатьВБухгалтерскомУчете]
					,_Fld8704 [ОтражатьВНалоговомУчете]
					,_Fld8705 [ОтражатьВУправленческомУчете]
					,_Fld8706RRef [Подразделение]
					,_Fld8707RRef [ПодразделениеОрганизации]
					,_Fld8708RRef [СерияНоменклатуры]
					,_Fld8709RRef [Склад]
					,_Fld8710RRef [Спецификация]
					,_Fld8711RRef [СпособСписанияОстаткаТоваров]
					,_Fld8712RRef [СтатусПартии]
					,_Fld8713RRef [СтатьяЗатратСписанияНДС]
					,_Fld8714RRef [СчетУчетаБУ]
					,_Fld8715RRef [СчетУчетаНУ]
					,_Fld8716RRef [СчетСписанияНДС]
					,_Fld8717RRef [СубконтоСписанияНДС1]
					,_Fld8718RRef [СубконтоСписанияНДС2]
					,_Fld8719RRef [СубконтоСписанияНДС3]
					,_Fld8720RRef [СчетСписанияНДСНУ]
					,_Fld8721RRef [СубконтоСписанияНДСНУ1]
					,_Fld8722RRef [СубконтоСписанияНДСНУ2]
					,_Fld8723RRef [СубконтоСписанияНДСНУ3]
					,_Fld8724RRef [ХарактеристикаНоменклатуры]
					,_Fld8725RRef [Контрагент]
					,_Fld8726RRef [ДоговорКонтрагента]
					,_Fld8727RRef [СчетЗатрат]
					,_Fld8728RRef [СчетЗатратНУ]
					,_Fld8729RRef [СтатьяЗатрат]
					,_Fld8730_TYPE [Заказ_Тип],_Fld8730_RRRef [Заказ],_Fld8730_RTRef [Заказ_Вид]
					,_Fld8731 [ЦенаПередачи]
					,_Fld8732 [СуммаПередачи]
					From _Document415(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.КомплектацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.КомплектацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидКомплектации = V82.Перечисления/*Ссылка*/.ВидыКомплектации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийКомплектацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Количество = Читалка.GetDecimal(12);
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Ссылка.НДСвСтоимостиТоваров = V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(20))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(21))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СпособСписанияОстаткаТоваров = V82.Перечисления/*Ссылка*/.СпособыСписанияОстаткаТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.СтатусПартии = V82.Перечисления/*Ссылка*/.СтатусыПартийТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Ссылка.ЦенаПередачи = Читалка.GetDecimal(50);
							Ссылка.СуммаПередачи = Читалка.GetDecimal(51);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.КомплектацияНоменклатуры ВыбратьПоНомеру(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld8690RRef [ВидКомплектации]
					,_Fld8691RRef [ВидОперации]
					,_Fld8692RRef [ЕдиницаИзмерения]
					,_Fld8693_TYPE [ЗаказВыпуска_Тип],_Fld8693_RRRef [ЗаказВыпуска],_Fld8693_RTRef [ЗаказВыпуска_Вид]
					,_Fld8694_TYPE [ЗаказРезерв_Тип],_Fld8694_RRRef [ЗаказРезерв],_Fld8694_RTRef [ЗаказРезерв_Вид]
					,_Fld8695 [Количество]
					,_Fld8696 [Комментарий]
					,_Fld8697 [Коэффициент]
					,_Fld8698RRef [НДСвСтоимостиТоваров]
					,_Fld8699RRef [Номенклатура]
					,_Fld8700RRef [НоменклатурнаяГруппа]
					,_Fld8701RRef [Организация]
					,_Fld8702RRef [Ответственный]
					,_Fld8703 [ОтражатьВБухгалтерскомУчете]
					,_Fld8704 [ОтражатьВНалоговомУчете]
					,_Fld8705 [ОтражатьВУправленческомУчете]
					,_Fld8706RRef [Подразделение]
					,_Fld8707RRef [ПодразделениеОрганизации]
					,_Fld8708RRef [СерияНоменклатуры]
					,_Fld8709RRef [Склад]
					,_Fld8710RRef [Спецификация]
					,_Fld8711RRef [СпособСписанияОстаткаТоваров]
					,_Fld8712RRef [СтатусПартии]
					,_Fld8713RRef [СтатьяЗатратСписанияНДС]
					,_Fld8714RRef [СчетУчетаБУ]
					,_Fld8715RRef [СчетУчетаНУ]
					,_Fld8716RRef [СчетСписанияНДС]
					,_Fld8717RRef [СубконтоСписанияНДС1]
					,_Fld8718RRef [СубконтоСписанияНДС2]
					,_Fld8719RRef [СубконтоСписанияНДС3]
					,_Fld8720RRef [СчетСписанияНДСНУ]
					,_Fld8721RRef [СубконтоСписанияНДСНУ1]
					,_Fld8722RRef [СубконтоСписанияНДСНУ2]
					,_Fld8723RRef [СубконтоСписанияНДСНУ3]
					,_Fld8724RRef [ХарактеристикаНоменклатуры]
					,_Fld8725RRef [Контрагент]
					,_Fld8726RRef [ДоговорКонтрагента]
					,_Fld8727RRef [СчетЗатрат]
					,_Fld8728RRef [СчетЗатратНУ]
					,_Fld8729RRef [СтатьяЗатрат]
					,_Fld8730_TYPE [Заказ_Тип],_Fld8730_RRRef [Заказ],_Fld8730_RTRef [Заказ_Вид]
					,_Fld8731 [ЦенаПередачи]
					,_Fld8732 [СуммаПередачи]
					From _Document415(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.КомплектацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.КомплектацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидКомплектации = V82.Перечисления/*Ссылка*/.ВидыКомплектации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийКомплектацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Количество = Читалка.GetDecimal(12);
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Ссылка.НДСвСтоимостиТоваров = V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(20))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(21))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СпособСписанияОстаткаТоваров = V82.Перечисления/*Ссылка*/.СпособыСписанияОстаткаТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.СтатусПартии = V82.Перечисления/*Ссылка*/.СтатусыПартийТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Ссылка.ЦенаПередачи = Читалка.GetDecimal(50);
							Ссылка.СуммаПередачи = Читалка.GetDecimal(51);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.КомплектацияНоменклатуры СтраницаПоСсылке(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld8690RRef [ВидКомплектации]
					,_Fld8691RRef [ВидОперации]
					,_Fld8692RRef [ЕдиницаИзмерения]
					,_Fld8693_TYPE [ЗаказВыпуска_Тип],_Fld8693_RRRef [ЗаказВыпуска],_Fld8693_RTRef [ЗаказВыпуска_Вид]
					,_Fld8694_TYPE [ЗаказРезерв_Тип],_Fld8694_RRRef [ЗаказРезерв],_Fld8694_RTRef [ЗаказРезерв_Вид]
					,_Fld8695 [Количество]
					,_Fld8696 [Комментарий]
					,_Fld8697 [Коэффициент]
					,_Fld8698RRef [НДСвСтоимостиТоваров]
					,_Fld8699RRef [Номенклатура]
					,_Fld8700RRef [НоменклатурнаяГруппа]
					,_Fld8701RRef [Организация]
					,_Fld8702RRef [Ответственный]
					,_Fld8703 [ОтражатьВБухгалтерскомУчете]
					,_Fld8704 [ОтражатьВНалоговомУчете]
					,_Fld8705 [ОтражатьВУправленческомУчете]
					,_Fld8706RRef [Подразделение]
					,_Fld8707RRef [ПодразделениеОрганизации]
					,_Fld8708RRef [СерияНоменклатуры]
					,_Fld8709RRef [Склад]
					,_Fld8710RRef [Спецификация]
					,_Fld8711RRef [СпособСписанияОстаткаТоваров]
					,_Fld8712RRef [СтатусПартии]
					,_Fld8713RRef [СтатьяЗатратСписанияНДС]
					,_Fld8714RRef [СчетУчетаБУ]
					,_Fld8715RRef [СчетУчетаНУ]
					,_Fld8716RRef [СчетСписанияНДС]
					,_Fld8717RRef [СубконтоСписанияНДС1]
					,_Fld8718RRef [СубконтоСписанияНДС2]
					,_Fld8719RRef [СубконтоСписанияНДС3]
					,_Fld8720RRef [СчетСписанияНДСНУ]
					,_Fld8721RRef [СубконтоСписанияНДСНУ1]
					,_Fld8722RRef [СубконтоСписанияНДСНУ2]
					,_Fld8723RRef [СубконтоСписанияНДСНУ3]
					,_Fld8724RRef [ХарактеристикаНоменклатуры]
					,_Fld8725RRef [Контрагент]
					,_Fld8726RRef [ДоговорКонтрагента]
					,_Fld8727RRef [СчетЗатрат]
					,_Fld8728RRef [СчетЗатратНУ]
					,_Fld8729RRef [СтатьяЗатрат]
					,_Fld8730_TYPE [Заказ_Тип],_Fld8730_RRRef [Заказ],_Fld8730_RTRef [Заказ_Вид]
					,_Fld8731 [ЦенаПередачи]
					,_Fld8732 [СуммаПередачи]
					From _Document415(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.КомплектацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.КомплектацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидКомплектации = V82.Перечисления/*Ссылка*/.ВидыКомплектации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийКомплектацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Количество = Читалка.GetDecimal(12);
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Ссылка.НДСвСтоимостиТоваров = V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(20))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(21))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СпособСписанияОстаткаТоваров = V82.Перечисления/*Ссылка*/.СпособыСписанияОстаткаТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.СтатусПартии = V82.Перечисления/*Ссылка*/.СтатусыПартийТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Ссылка.ЦенаПередачи = Читалка.GetDecimal(50);
							Ссылка.СуммаПередачи = Читалка.GetDecimal(51);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.КомплектацияНоменклатуры СтраницаПоНомеру(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld8690RRef [ВидКомплектации]
					,_Fld8691RRef [ВидОперации]
					,_Fld8692RRef [ЕдиницаИзмерения]
					,_Fld8693_TYPE [ЗаказВыпуска_Тип],_Fld8693_RRRef [ЗаказВыпуска],_Fld8693_RTRef [ЗаказВыпуска_Вид]
					,_Fld8694_TYPE [ЗаказРезерв_Тип],_Fld8694_RRRef [ЗаказРезерв],_Fld8694_RTRef [ЗаказРезерв_Вид]
					,_Fld8695 [Количество]
					,_Fld8696 [Комментарий]
					,_Fld8697 [Коэффициент]
					,_Fld8698RRef [НДСвСтоимостиТоваров]
					,_Fld8699RRef [Номенклатура]
					,_Fld8700RRef [НоменклатурнаяГруппа]
					,_Fld8701RRef [Организация]
					,_Fld8702RRef [Ответственный]
					,_Fld8703 [ОтражатьВБухгалтерскомУчете]
					,_Fld8704 [ОтражатьВНалоговомУчете]
					,_Fld8705 [ОтражатьВУправленческомУчете]
					,_Fld8706RRef [Подразделение]
					,_Fld8707RRef [ПодразделениеОрганизации]
					,_Fld8708RRef [СерияНоменклатуры]
					,_Fld8709RRef [Склад]
					,_Fld8710RRef [Спецификация]
					,_Fld8711RRef [СпособСписанияОстаткаТоваров]
					,_Fld8712RRef [СтатусПартии]
					,_Fld8713RRef [СтатьяЗатратСписанияНДС]
					,_Fld8714RRef [СчетУчетаБУ]
					,_Fld8715RRef [СчетУчетаНУ]
					,_Fld8716RRef [СчетСписанияНДС]
					,_Fld8717RRef [СубконтоСписанияНДС1]
					,_Fld8718RRef [СубконтоСписанияНДС2]
					,_Fld8719RRef [СубконтоСписанияНДС3]
					,_Fld8720RRef [СчетСписанияНДСНУ]
					,_Fld8721RRef [СубконтоСписанияНДСНУ1]
					,_Fld8722RRef [СубконтоСписанияНДСНУ2]
					,_Fld8723RRef [СубконтоСписанияНДСНУ3]
					,_Fld8724RRef [ХарактеристикаНоменклатуры]
					,_Fld8725RRef [Контрагент]
					,_Fld8726RRef [ДоговорКонтрагента]
					,_Fld8727RRef [СчетЗатрат]
					,_Fld8728RRef [СчетЗатратНУ]
					,_Fld8729RRef [СтатьяЗатрат]
					,_Fld8730_TYPE [Заказ_Тип],_Fld8730_RRRef [Заказ],_Fld8730_RTRef [Заказ_Вид]
					,_Fld8731 [ЦенаПередачи]
					,_Fld8732 [СуммаПередачи]
					From _Document415(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.КомплектацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.КомплектацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидКомплектации = V82.Перечисления/*Ссылка*/.ВидыКомплектации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийКомплектацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.Количество = Читалка.GetDecimal(12);
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.Коэффициент = Читалка.GetDecimal(14);
							Ссылка.НДСвСтоимостиТоваров = V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(20))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(21))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(22))[0]==1;
							Ссылка.СпособСписанияОстаткаТоваров = V82.Перечисления/*Ссылка*/.СпособыСписанияОстаткаТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.СтатусПартии = V82.Перечисления/*Ссылка*/.СтатусыПартийТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Ссылка.ЦенаПередачи = Читалка.GetDecimal(50);
							Ссылка.СуммаПередачи = Читалка.GetDecimal(51);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.КомплектацияНоменклатуры СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.КомплектацияНоменклатуры();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ВидКомплектации = V82.Перечисления/*Ссылка*/.ВидыКомплектации.ПустаяСсылка;
			Объект.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийКомплектацияНоменклатуры.ПустаяСсылка;
			Объект.НДСвСтоимостиТоваров = V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров.ПустаяСсылка;
			Объект.СпособСписанияОстаткаТоваров = V82.Перечисления/*Ссылка*/.СпособыСписанияОстаткаТоваров.ПустаяСсылка;
			Объект.СтатусПартии = V82.Перечисления/*Ссылка*/.СтатусыПартийТоваров.ПустаяСсылка;
			return Объект;
		}
	}
}