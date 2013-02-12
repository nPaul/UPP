﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class НастройкиРасчетаЦеныНоменклатуры:СправочникМенеджер
	{
		
		public static СправочникиВыборка.НастройкиРасчетаЦеныНоменклатуры Выбрать()
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
					,_IsMetadata [Предопределенный]
					,_Description [Наименование]
					,_Fld2835 [ФормироватьДокументыАвтоматически]
					,_Fld2836 [РегламентноеЗадание]
					,_Fld2837 [НастройкиКомпоновщика]
					,_Fld2838RRef [ТипЦен]
					,_Fld2839RRef [ВидОтраженияВУчете]
					,_Fld2840 [ПорядокФормированияЦены]
					,_Fld2841 [Комментарий]
					,_Fld2842RRef [НастройкаРасчетаСебестоимости]
					,_Fld2843 [СоздаватьНовыйДокумент]
							From _Reference156(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиРасчетаЦеныНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1?true:false;
							Ссылка.РегламентноеЗадание = Читалка.GetString(6);
							//Ссылка.ТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(8));
							Ссылка.ВидОтраженияВУчете = V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ПорядокФормированияЦены = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							//Ссылка.НастройкаРасчетаСебестоимости = new V82.СправочникиСсылка.НастройкиРасчетаСебестоимости((byte[])Читалка.GetValue(12));
							Ссылка.СоздаватьНовыйДокумент = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиРасчетаЦеныНоменклатуры ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_IsMetadata [Предопределенный]
					,_Description [Наименование]
					,_Fld2835 [ФормироватьДокументыАвтоматически]
					,_Fld2836 [РегламентноеЗадание]
					,_Fld2837 [НастройкиКомпоновщика]
					,_Fld2838RRef [ТипЦен]
					,_Fld2839RRef [ВидОтраженияВУчете]
					,_Fld2840 [ПорядокФормированияЦены]
					,_Fld2841 [Комментарий]
					,_Fld2842RRef [НастройкаРасчетаСебестоимости]
					,_Fld2843 [СоздаватьНовыйДокумент]
							From _Reference156(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиРасчетаЦеныНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1?true:false;
							Ссылка.РегламентноеЗадание = Читалка.GetString(6);
							//Ссылка.ТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(8));
							Ссылка.ВидОтраженияВУчете = V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ПорядокФормированияЦены = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							//Ссылка.НастройкаРасчетаСебестоимости = new V82.СправочникиСсылка.НастройкиРасчетаСебестоимости((byte[])Читалка.GetValue(12));
							Ссылка.СоздаватьНовыйДокумент = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиРасчетаЦеныНоменклатуры ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_IsMetadata [Предопределенный]
					,_Description [Наименование]
					,_Fld2835 [ФормироватьДокументыАвтоматически]
					,_Fld2836 [РегламентноеЗадание]
					,_Fld2837 [НастройкиКомпоновщика]
					,_Fld2838RRef [ТипЦен]
					,_Fld2839RRef [ВидОтраженияВУчете]
					,_Fld2840 [ПорядокФормированияЦены]
					,_Fld2841 [Комментарий]
					,_Fld2842RRef [НастройкаРасчетаСебестоимости]
					,_Fld2843 [СоздаватьНовыйДокумент]
							From _Reference156(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиРасчетаЦеныНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1?true:false;
							Ссылка.РегламентноеЗадание = Читалка.GetString(6);
							//Ссылка.ТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(8));
							Ссылка.ВидОтраженияВУчете = V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ПорядокФормированияЦены = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							//Ссылка.НастройкаРасчетаСебестоимости = new V82.СправочникиСсылка.НастройкиРасчетаСебестоимости((byte[])Читалка.GetValue(12));
							Ссылка.СоздаватьНовыйДокумент = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НастройкиРасчетаЦеныНоменклатуры СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиРасчетаЦеныНоменклатуры();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.РегламентноеЗадание = "";
			Объект.Комментарий = "";
			Объект.ТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
			Объект.ВидОтраженияВУчете = V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете.ПустаяСсылка;
			Объект.НастройкаРасчетаСебестоимости = new V82.СправочникиСсылка.НастройкиРасчетаСебестоимости();
			return Объект;
		}
	}
}