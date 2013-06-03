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
	///(Общ)
	///</summary>
	public partial class ИнвентаризацияНЗП:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ИнвентаризацияНЗП НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld8176RRef [Подразделение]
					,_Fld8177RRef [Организация]
					,_Fld8178 [Комментарий]
					,_Fld8179RRef [Ответственный]
					,_Fld8180 [ОтражатьВУправленческомУчете]
					,_Fld8181 [ОтражатьВБухгалтерскомУчете]
					,_Fld8182 [ОтражатьВНалоговомУчете]
					,_Fld8183_TYPE [Заказ_Тип],_Fld8183_RRRef [Заказ],_Fld8183_RTRef [Заказ_Вид]
					,_Fld8184RRef [СтатьяЗатрат]
					,_Fld8185 [ВводитьЗаказыПоСтрокам]
					,_Fld8186RRef [НоменклатурнаяГруппа]
					,_Fld8187 [ВводитьНоменклатурныеГруппыПоСтрокам]
					,_Fld8188RRef [ПодразделениеОрганизации]
					From _Document403(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИнвентаризацияНЗП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ВводитьЗаказыПоСтрокам = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ВводитьНоменклатурныеГруппыПоСтрокам = ((byte[])Читалка.GetValue(16))[0]==1;
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
		
		public static ДокументыСсылка.ИнвентаризацияНЗП НайтиПоНомеру(string Номер)
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
					,_Fld8176RRef [Подразделение]
					,_Fld8177RRef [Организация]
					,_Fld8178 [Комментарий]
					,_Fld8179RRef [Ответственный]
					,_Fld8180 [ОтражатьВУправленческомУчете]
					,_Fld8181 [ОтражатьВБухгалтерскомУчете]
					,_Fld8182 [ОтражатьВНалоговомУчете]
					,_Fld8183_TYPE [Заказ_Тип],_Fld8183_RRRef [Заказ],_Fld8183_RTRef [Заказ_Вид]
					,_Fld8184RRef [СтатьяЗатрат]
					,_Fld8185 [ВводитьЗаказыПоСтрокам]
					,_Fld8186RRef [НоменклатурнаяГруппа]
					,_Fld8187 [ВводитьНоменклатурныеГруппыПоСтрокам]
					,_Fld8188RRef [ПодразделениеОрганизации]
					From _Document403(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИнвентаризацияНЗП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ВводитьЗаказыПоСтрокам = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ВводитьНоменклатурныеГруппыПоСтрокам = ((byte[])Читалка.GetValue(16))[0]==1;
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
		
		public static ДокументыВыборка.ИнвентаризацияНЗП Выбрать()
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
					,_Fld8176RRef [Подразделение]
					,_Fld8177RRef [Организация]
					,_Fld8178 [Комментарий]
					,_Fld8179RRef [Ответственный]
					,_Fld8180 [ОтражатьВУправленческомУчете]
					,_Fld8181 [ОтражатьВБухгалтерскомУчете]
					,_Fld8182 [ОтражатьВНалоговомУчете]
					,_Fld8183_TYPE [Заказ_Тип],_Fld8183_RRRef [Заказ],_Fld8183_RTRef [Заказ_Вид]
					,_Fld8184RRef [СтатьяЗатрат]
					,_Fld8185 [ВводитьЗаказыПоСтрокам]
					,_Fld8186RRef [НоменклатурнаяГруппа]
					,_Fld8187 [ВводитьНоменклатурныеГруппыПоСтрокам]
					,_Fld8188RRef [ПодразделениеОрганизации]
					From _Document403(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИнвентаризацияНЗП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИнвентаризацияНЗП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ВводитьЗаказыПоСтрокам = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ВводитьНоменклатурныеГруппыПоСтрокам = ((byte[])Читалка.GetValue(16))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИнвентаризацияНЗП ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld8176RRef [Подразделение]
					,_Fld8177RRef [Организация]
					,_Fld8178 [Комментарий]
					,_Fld8179RRef [Ответственный]
					,_Fld8180 [ОтражатьВУправленческомУчете]
					,_Fld8181 [ОтражатьВБухгалтерскомУчете]
					,_Fld8182 [ОтражатьВНалоговомУчете]
					,_Fld8183_TYPE [Заказ_Тип],_Fld8183_RRRef [Заказ],_Fld8183_RTRef [Заказ_Вид]
					,_Fld8184RRef [СтатьяЗатрат]
					,_Fld8185 [ВводитьЗаказыПоСтрокам]
					,_Fld8186RRef [НоменклатурнаяГруппа]
					,_Fld8187 [ВводитьНоменклатурныеГруппыПоСтрокам]
					,_Fld8188RRef [ПодразделениеОрганизации]
					From _Document403(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ИнвентаризацияНЗП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИнвентаризацияНЗП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ВводитьЗаказыПоСтрокам = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ВводитьНоменклатурныеГруппыПоСтрокам = ((byte[])Читалка.GetValue(16))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИнвентаризацияНЗП ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld8176RRef [Подразделение]
					,_Fld8177RRef [Организация]
					,_Fld8178 [Комментарий]
					,_Fld8179RRef [Ответственный]
					,_Fld8180 [ОтражатьВУправленческомУчете]
					,_Fld8181 [ОтражатьВБухгалтерскомУчете]
					,_Fld8182 [ОтражатьВНалоговомУчете]
					,_Fld8183_TYPE [Заказ_Тип],_Fld8183_RRRef [Заказ],_Fld8183_RTRef [Заказ_Вид]
					,_Fld8184RRef [СтатьяЗатрат]
					,_Fld8185 [ВводитьЗаказыПоСтрокам]
					,_Fld8186RRef [НоменклатурнаяГруппа]
					,_Fld8187 [ВводитьНоменклатурныеГруппыПоСтрокам]
					,_Fld8188RRef [ПодразделениеОрганизации]
					From _Document403(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ИнвентаризацияНЗП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИнвентаризацияНЗП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ВводитьЗаказыПоСтрокам = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ВводитьНоменклатурныеГруппыПоСтрокам = ((byte[])Читалка.GetValue(16))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИнвентаризацияНЗП СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld8176RRef [Подразделение]
					,_Fld8177RRef [Организация]
					,_Fld8178 [Комментарий]
					,_Fld8179RRef [Ответственный]
					,_Fld8180 [ОтражатьВУправленческомУчете]
					,_Fld8181 [ОтражатьВБухгалтерскомУчете]
					,_Fld8182 [ОтражатьВНалоговомУчете]
					,_Fld8183_TYPE [Заказ_Тип],_Fld8183_RRRef [Заказ],_Fld8183_RTRef [Заказ_Вид]
					,_Fld8184RRef [СтатьяЗатрат]
					,_Fld8185 [ВводитьЗаказыПоСтрокам]
					,_Fld8186RRef [НоменклатурнаяГруппа]
					,_Fld8187 [ВводитьНоменклатурныеГруппыПоСтрокам]
					,_Fld8188RRef [ПодразделениеОрганизации]
					From _Document403(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИнвентаризацияНЗП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИнвентаризацияНЗП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ВводитьЗаказыПоСтрокам = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ВводитьНоменклатурныеГруппыПоСтрокам = ((byte[])Читалка.GetValue(16))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИнвентаризацияНЗП СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld8176RRef [Подразделение]
					,_Fld8177RRef [Организация]
					,_Fld8178 [Комментарий]
					,_Fld8179RRef [Ответственный]
					,_Fld8180 [ОтражатьВУправленческомУчете]
					,_Fld8181 [ОтражатьВБухгалтерскомУчете]
					,_Fld8182 [ОтражатьВНалоговомУчете]
					,_Fld8183_TYPE [Заказ_Тип],_Fld8183_RRRef [Заказ],_Fld8183_RTRef [Заказ_Вид]
					,_Fld8184RRef [СтатьяЗатрат]
					,_Fld8185 [ВводитьЗаказыПоСтрокам]
					,_Fld8186RRef [НоменклатурнаяГруппа]
					,_Fld8187 [ВводитьНоменклатурныеГруппыПоСтрокам]
					,_Fld8188RRef [ПодразделениеОрганизации]
					From _Document403(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИнвентаризацияНЗП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИнвентаризацияНЗП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ВводитьЗаказыПоСтрокам = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ВводитьНоменклатурныеГруппыПоСтрокам = ((byte[])Читалка.GetValue(16))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ИнвентаризацияНЗП СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ИнвентаризацияНЗП();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			return Объект;
		}
	}
}