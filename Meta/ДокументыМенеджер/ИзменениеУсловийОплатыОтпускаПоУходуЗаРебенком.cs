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
	///(Регл)
	///</summary>
	public partial class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld21445RRef [Сотрудник]
					,_Fld18669RRef [Физлицо]
					,_Fld18666RRef [Организация]
					,_Fld18667 [Комментарий]
					,_Fld18668RRef [Ответственный]
					,_Fld18670RRef [УдалитьПриказ]
					,_Fld18671 [ДатаОкончанияПособияДоПолутораЛет]
					,_Fld18672 [ДатаОкончанияПособияДоТрехЛет]
					,_Fld18673 [ДатаИзменения]
					,_Fld18674 [КоличествоДетей]
					,_Fld18675 [КоличествоПервыхДетей]
					,_Fld18676RRef [ДокументОснование]
					,_Fld18677RRef [Действие]
					,_Fld18678 [ВыплачиватьПособиеДоПолутораЛет]
					,_Fld18679 [ВыплачиватьПособиеДоТрехЛет]
					,_Fld22995 [ОсвобождатьСтавку]
					,_Fld26773 [ДанныеПрошлойВерсии]
					,_Fld26774RRef [ИсправляемыйДокумент]
					,_Fld26775 [ДвиженияИсправляемогоДокумента]
					From _Document18662(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.УдалитьПриказ = V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ДатаОкончанияПособияДоПолутораЛет = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПособияДоТрехЛет = Читалка.GetDateTime(10);
							Ссылка.ДатаИзменения = Читалка.GetDateTime(11);
							Ссылка.КоличествоДетей = Читалка.GetDecimal(12);
							Ссылка.КоличествоПервыхДетей = Читалка.GetDecimal(13);
							Ссылка.ДокументОснование = V82.ДокументыСсылка.ОтпускПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(14));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ВыплачиватьПособиеДоПолутораЛет = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ВыплачиватьПособиеДоТрехЛет = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсвобождатьСтавку = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ИсправляемыйДокумент = V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(20));
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
		
		public static ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком НайтиПоНомеру(string Номер)
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
					,_Fld21445RRef [Сотрудник]
					,_Fld18669RRef [Физлицо]
					,_Fld18666RRef [Организация]
					,_Fld18667 [Комментарий]
					,_Fld18668RRef [Ответственный]
					,_Fld18670RRef [УдалитьПриказ]
					,_Fld18671 [ДатаОкончанияПособияДоПолутораЛет]
					,_Fld18672 [ДатаОкончанияПособияДоТрехЛет]
					,_Fld18673 [ДатаИзменения]
					,_Fld18674 [КоличествоДетей]
					,_Fld18675 [КоличествоПервыхДетей]
					,_Fld18676RRef [ДокументОснование]
					,_Fld18677RRef [Действие]
					,_Fld18678 [ВыплачиватьПособиеДоПолутораЛет]
					,_Fld18679 [ВыплачиватьПособиеДоТрехЛет]
					,_Fld22995 [ОсвобождатьСтавку]
					,_Fld26773 [ДанныеПрошлойВерсии]
					,_Fld26774RRef [ИсправляемыйДокумент]
					,_Fld26775 [ДвиженияИсправляемогоДокумента]
					From _Document18662(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.УдалитьПриказ = V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ДатаОкончанияПособияДоПолутораЛет = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПособияДоТрехЛет = Читалка.GetDateTime(10);
							Ссылка.ДатаИзменения = Читалка.GetDateTime(11);
							Ссылка.КоличествоДетей = Читалка.GetDecimal(12);
							Ссылка.КоличествоПервыхДетей = Читалка.GetDecimal(13);
							Ссылка.ДокументОснование = V82.ДокументыСсылка.ОтпускПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(14));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ВыплачиватьПособиеДоПолутораЛет = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ВыплачиватьПособиеДоТрехЛет = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсвобождатьСтавку = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ИсправляемыйДокумент = V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(20));
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
		
		public static ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком Выбрать()
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
					,_Fld21445RRef [Сотрудник]
					,_Fld18669RRef [Физлицо]
					,_Fld18666RRef [Организация]
					,_Fld18667 [Комментарий]
					,_Fld18668RRef [Ответственный]
					,_Fld18670RRef [УдалитьПриказ]
					,_Fld18671 [ДатаОкончанияПособияДоПолутораЛет]
					,_Fld18672 [ДатаОкончанияПособияДоТрехЛет]
					,_Fld18673 [ДатаИзменения]
					,_Fld18674 [КоличествоДетей]
					,_Fld18675 [КоличествоПервыхДетей]
					,_Fld18676RRef [ДокументОснование]
					,_Fld18677RRef [Действие]
					,_Fld18678 [ВыплачиватьПособиеДоПолутораЛет]
					,_Fld18679 [ВыплачиватьПособиеДоТрехЛет]
					,_Fld22995 [ОсвобождатьСтавку]
					,_Fld26773 [ДанныеПрошлойВерсии]
					,_Fld26774RRef [ИсправляемыйДокумент]
					,_Fld26775 [ДвиженияИсправляемогоДокумента]
					From _Document18662(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.УдалитьПриказ = V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ДатаОкончанияПособияДоПолутораЛет = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПособияДоТрехЛет = Читалка.GetDateTime(10);
							Ссылка.ДатаИзменения = Читалка.GetDateTime(11);
							Ссылка.КоличествоДетей = Читалка.GetDecimal(12);
							Ссылка.КоличествоПервыхДетей = Читалка.GetDecimal(13);
							Ссылка.ДокументОснование = V82.ДокументыСсылка.ОтпускПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(14));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ВыплачиватьПособиеДоПолутораЛет = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ВыплачиватьПособиеДоТрехЛет = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсвобождатьСтавку = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ИсправляемыйДокумент = V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld21445RRef [Сотрудник]
					,_Fld18669RRef [Физлицо]
					,_Fld18666RRef [Организация]
					,_Fld18667 [Комментарий]
					,_Fld18668RRef [Ответственный]
					,_Fld18670RRef [УдалитьПриказ]
					,_Fld18671 [ДатаОкончанияПособияДоПолутораЛет]
					,_Fld18672 [ДатаОкончанияПособияДоТрехЛет]
					,_Fld18673 [ДатаИзменения]
					,_Fld18674 [КоличествоДетей]
					,_Fld18675 [КоличествоПервыхДетей]
					,_Fld18676RRef [ДокументОснование]
					,_Fld18677RRef [Действие]
					,_Fld18678 [ВыплачиватьПособиеДоПолутораЛет]
					,_Fld18679 [ВыплачиватьПособиеДоТрехЛет]
					,_Fld22995 [ОсвобождатьСтавку]
					,_Fld26773 [ДанныеПрошлойВерсии]
					,_Fld26774RRef [ИсправляемыйДокумент]
					,_Fld26775 [ДвиженияИсправляемогоДокумента]
					From _Document18662(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.УдалитьПриказ = V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ДатаОкончанияПособияДоПолутораЛет = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПособияДоТрехЛет = Читалка.GetDateTime(10);
							Ссылка.ДатаИзменения = Читалка.GetDateTime(11);
							Ссылка.КоличествоДетей = Читалка.GetDecimal(12);
							Ссылка.КоличествоПервыхДетей = Читалка.GetDecimal(13);
							Ссылка.ДокументОснование = V82.ДокументыСсылка.ОтпускПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(14));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ВыплачиватьПособиеДоПолутораЛет = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ВыплачиватьПособиеДоТрехЛет = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсвобождатьСтавку = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ИсправляемыйДокумент = V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld21445RRef [Сотрудник]
					,_Fld18669RRef [Физлицо]
					,_Fld18666RRef [Организация]
					,_Fld18667 [Комментарий]
					,_Fld18668RRef [Ответственный]
					,_Fld18670RRef [УдалитьПриказ]
					,_Fld18671 [ДатаОкончанияПособияДоПолутораЛет]
					,_Fld18672 [ДатаОкончанияПособияДоТрехЛет]
					,_Fld18673 [ДатаИзменения]
					,_Fld18674 [КоличествоДетей]
					,_Fld18675 [КоличествоПервыхДетей]
					,_Fld18676RRef [ДокументОснование]
					,_Fld18677RRef [Действие]
					,_Fld18678 [ВыплачиватьПособиеДоПолутораЛет]
					,_Fld18679 [ВыплачиватьПособиеДоТрехЛет]
					,_Fld22995 [ОсвобождатьСтавку]
					,_Fld26773 [ДанныеПрошлойВерсии]
					,_Fld26774RRef [ИсправляемыйДокумент]
					,_Fld26775 [ДвиженияИсправляемогоДокумента]
					From _Document18662(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.УдалитьПриказ = V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ДатаОкончанияПособияДоПолутораЛет = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПособияДоТрехЛет = Читалка.GetDateTime(10);
							Ссылка.ДатаИзменения = Читалка.GetDateTime(11);
							Ссылка.КоличествоДетей = Читалка.GetDecimal(12);
							Ссылка.КоличествоПервыхДетей = Читалка.GetDecimal(13);
							Ссылка.ДокументОснование = V82.ДокументыСсылка.ОтпускПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(14));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ВыплачиватьПособиеДоПолутораЛет = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ВыплачиватьПособиеДоТрехЛет = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсвобождатьСтавку = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ИсправляемыйДокумент = V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld21445RRef [Сотрудник]
					,_Fld18669RRef [Физлицо]
					,_Fld18666RRef [Организация]
					,_Fld18667 [Комментарий]
					,_Fld18668RRef [Ответственный]
					,_Fld18670RRef [УдалитьПриказ]
					,_Fld18671 [ДатаОкончанияПособияДоПолутораЛет]
					,_Fld18672 [ДатаОкончанияПособияДоТрехЛет]
					,_Fld18673 [ДатаИзменения]
					,_Fld18674 [КоличествоДетей]
					,_Fld18675 [КоличествоПервыхДетей]
					,_Fld18676RRef [ДокументОснование]
					,_Fld18677RRef [Действие]
					,_Fld18678 [ВыплачиватьПособиеДоПолутораЛет]
					,_Fld18679 [ВыплачиватьПособиеДоТрехЛет]
					,_Fld22995 [ОсвобождатьСтавку]
					,_Fld26773 [ДанныеПрошлойВерсии]
					,_Fld26774RRef [ИсправляемыйДокумент]
					,_Fld26775 [ДвиженияИсправляемогоДокумента]
					From _Document18662(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.УдалитьПриказ = V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ДатаОкончанияПособияДоПолутораЛет = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПособияДоТрехЛет = Читалка.GetDateTime(10);
							Ссылка.ДатаИзменения = Читалка.GetDateTime(11);
							Ссылка.КоличествоДетей = Читалка.GetDecimal(12);
							Ссылка.КоличествоПервыхДетей = Читалка.GetDecimal(13);
							Ссылка.ДокументОснование = V82.ДокументыСсылка.ОтпускПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(14));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ВыплачиватьПособиеДоПолутораЛет = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ВыплачиватьПособиеДоТрехЛет = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсвобождатьСтавку = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ИсправляемыйДокумент = V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld21445RRef [Сотрудник]
					,_Fld18669RRef [Физлицо]
					,_Fld18666RRef [Организация]
					,_Fld18667 [Комментарий]
					,_Fld18668RRef [Ответственный]
					,_Fld18670RRef [УдалитьПриказ]
					,_Fld18671 [ДатаОкончанияПособияДоПолутораЛет]
					,_Fld18672 [ДатаОкончанияПособияДоТрехЛет]
					,_Fld18673 [ДатаИзменения]
					,_Fld18674 [КоличествоДетей]
					,_Fld18675 [КоличествоПервыхДетей]
					,_Fld18676RRef [ДокументОснование]
					,_Fld18677RRef [Действие]
					,_Fld18678 [ВыплачиватьПособиеДоПолутораЛет]
					,_Fld18679 [ВыплачиватьПособиеДоТрехЛет]
					,_Fld22995 [ОсвобождатьСтавку]
					,_Fld26773 [ДанныеПрошлойВерсии]
					,_Fld26774RRef [ИсправляемыйДокумент]
					,_Fld26775 [ДвиженияИсправляемогоДокумента]
					From _Document18662(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.УдалитьПриказ = V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию.ВзятьИзКэша((byte[])Читалка.GetValue(8));
							Ссылка.ДатаОкончанияПособияДоПолутораЛет = Читалка.GetDateTime(9);
							Ссылка.ДатаОкончанияПособияДоТрехЛет = Читалка.GetDateTime(10);
							Ссылка.ДатаИзменения = Читалка.GetDateTime(11);
							Ссылка.КоличествоДетей = Читалка.GetDecimal(12);
							Ссылка.КоличествоПервыхДетей = Читалка.GetDecimal(13);
							Ссылка.ДокументОснование = V82.ДокументыСсылка.ОтпускПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(14));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ВыплачиватьПособиеДоПолутораЛет = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ВыплачиватьПособиеДоТрехЛет = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОсвобождатьСтавку = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(19))[0]==1;
							Ссылка.ИсправляемыйДокумент = V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.ВзятьИзКэша((byte[])Читалка.GetValue(20));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.УдалитьПриказ = new V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию();
			Объект.ДокументОснование = new V82.ДокументыСсылка.ОтпускПоУходуЗаРебенком();
			Объект.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка;
			Объект.ИсправляемыйДокумент = new V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком();
			return Объект;
		}
	}
}