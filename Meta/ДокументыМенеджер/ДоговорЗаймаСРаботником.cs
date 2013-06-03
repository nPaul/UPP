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
	public partial class ДоговорЗаймаСРаботником:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ДоговорЗаймаСРаботником НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld6824RRef [ФизЛицо]
					,_Fld6825 [СуммаЗайма]
					,_Fld6826RRef [ВалютаДокумента]
					,_Fld6827 [КурсДокумента]
					,_Fld6828 [КратностьДокумента]
					,_Fld6829 [ПроцентЗаПользованиеЗаймом]
					,_Fld6830RRef [ПорядокПогашенияЗайма]
					,_Fld6831 [СрокПогашения]
					,_Fld6832 [НачалоПогашения]
					,_Fld6833 [ОтражатьВУправленческомУчете]
					,_Fld6834 [ОтражатьВБухгалтерскомУчете]
					,_Fld6835RRef [Организация]
					,_Fld6836 [НачислятьМатериальнуюВыгоду]
					,_Fld6837RRef [СтавкаНалогообложенияРезидента]
					,_Fld6838RRef [СчетУчетаПроцентовПоЗайму]
					,_Fld6839 [Комментарий]
					,_Fld6840RRef [Ответственный]
					,_Fld6841RRef [Субконто1]
					,_Fld6842RRef [Субконто2]
					,_Fld6843RRef [Субконто3]
					,_Fld6844 [ДанныеПрошлойВерсии]
					From _Document356(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорЗаймаСРаботником();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗайма = Читалка.GetDecimal(4);
							Ссылка.КурсДокумента = Читалка.GetDecimal(6);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(7);
							Ссылка.ПроцентЗаПользованиеЗаймом = Читалка.GetDecimal(8);
							Ссылка.ПорядокПогашенияЗайма = V82.Перечисления/*Ссылка*/.ПорядокПогашенияЗаймаПроцентов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.СрокПогашения = Читалка.GetDecimal(10);
							Ссылка.НачалоПогашения = Читалка.GetDateTime(11);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.НачислятьМатериальнуюВыгоду = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
							Ссылка.Комментарий = Читалка.GetString(18);
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(23))[0]==1;
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
		
		public static ДокументыСсылка.ДоговорЗаймаСРаботником НайтиПоНомеру(string Номер)
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
					,_Fld6824RRef [ФизЛицо]
					,_Fld6825 [СуммаЗайма]
					,_Fld6826RRef [ВалютаДокумента]
					,_Fld6827 [КурсДокумента]
					,_Fld6828 [КратностьДокумента]
					,_Fld6829 [ПроцентЗаПользованиеЗаймом]
					,_Fld6830RRef [ПорядокПогашенияЗайма]
					,_Fld6831 [СрокПогашения]
					,_Fld6832 [НачалоПогашения]
					,_Fld6833 [ОтражатьВУправленческомУчете]
					,_Fld6834 [ОтражатьВБухгалтерскомУчете]
					,_Fld6835RRef [Организация]
					,_Fld6836 [НачислятьМатериальнуюВыгоду]
					,_Fld6837RRef [СтавкаНалогообложенияРезидента]
					,_Fld6838RRef [СчетУчетаПроцентовПоЗайму]
					,_Fld6839 [Комментарий]
					,_Fld6840RRef [Ответственный]
					,_Fld6841RRef [Субконто1]
					,_Fld6842RRef [Субконто2]
					,_Fld6843RRef [Субконто3]
					,_Fld6844 [ДанныеПрошлойВерсии]
					From _Document356(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорЗаймаСРаботником();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗайма = Читалка.GetDecimal(4);
							Ссылка.КурсДокумента = Читалка.GetDecimal(6);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(7);
							Ссылка.ПроцентЗаПользованиеЗаймом = Читалка.GetDecimal(8);
							Ссылка.ПорядокПогашенияЗайма = V82.Перечисления/*Ссылка*/.ПорядокПогашенияЗаймаПроцентов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.СрокПогашения = Читалка.GetDecimal(10);
							Ссылка.НачалоПогашения = Читалка.GetDateTime(11);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.НачислятьМатериальнуюВыгоду = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
							Ссылка.Комментарий = Читалка.GetString(18);
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(23))[0]==1;
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
		
		public static ДокументыВыборка.ДоговорЗаймаСРаботником Выбрать()
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
					,_Fld6824RRef [ФизЛицо]
					,_Fld6825 [СуммаЗайма]
					,_Fld6826RRef [ВалютаДокумента]
					,_Fld6827 [КурсДокумента]
					,_Fld6828 [КратностьДокумента]
					,_Fld6829 [ПроцентЗаПользованиеЗаймом]
					,_Fld6830RRef [ПорядокПогашенияЗайма]
					,_Fld6831 [СрокПогашения]
					,_Fld6832 [НачалоПогашения]
					,_Fld6833 [ОтражатьВУправленческомУчете]
					,_Fld6834 [ОтражатьВБухгалтерскомУчете]
					,_Fld6835RRef [Организация]
					,_Fld6836 [НачислятьМатериальнуюВыгоду]
					,_Fld6837RRef [СтавкаНалогообложенияРезидента]
					,_Fld6838RRef [СчетУчетаПроцентовПоЗайму]
					,_Fld6839 [Комментарий]
					,_Fld6840RRef [Ответственный]
					,_Fld6841RRef [Субконто1]
					,_Fld6842RRef [Субконто2]
					,_Fld6843RRef [Субконто3]
					,_Fld6844 [ДанныеПрошлойВерсии]
					From _Document356(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ДоговорЗаймаСРаботником();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорЗаймаСРаботником();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗайма = Читалка.GetDecimal(4);
							Ссылка.КурсДокумента = Читалка.GetDecimal(6);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(7);
							Ссылка.ПроцентЗаПользованиеЗаймом = Читалка.GetDecimal(8);
							Ссылка.ПорядокПогашенияЗайма = V82.Перечисления/*Ссылка*/.ПорядокПогашенияЗаймаПроцентов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.СрокПогашения = Читалка.GetDecimal(10);
							Ссылка.НачалоПогашения = Читалка.GetDateTime(11);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.НачислятьМатериальнуюВыгоду = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
							Ссылка.Комментарий = Читалка.GetString(18);
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(23))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДоговорЗаймаСРаботником ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld6824RRef [ФизЛицо]
					,_Fld6825 [СуммаЗайма]
					,_Fld6826RRef [ВалютаДокумента]
					,_Fld6827 [КурсДокумента]
					,_Fld6828 [КратностьДокумента]
					,_Fld6829 [ПроцентЗаПользованиеЗаймом]
					,_Fld6830RRef [ПорядокПогашенияЗайма]
					,_Fld6831 [СрокПогашения]
					,_Fld6832 [НачалоПогашения]
					,_Fld6833 [ОтражатьВУправленческомУчете]
					,_Fld6834 [ОтражатьВБухгалтерскомУчете]
					,_Fld6835RRef [Организация]
					,_Fld6836 [НачислятьМатериальнуюВыгоду]
					,_Fld6837RRef [СтавкаНалогообложенияРезидента]
					,_Fld6838RRef [СчетУчетаПроцентовПоЗайму]
					,_Fld6839 [Комментарий]
					,_Fld6840RRef [Ответственный]
					,_Fld6841RRef [Субконто1]
					,_Fld6842RRef [Субконто2]
					,_Fld6843RRef [Субконто3]
					,_Fld6844 [ДанныеПрошлойВерсии]
					From _Document356(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ДоговорЗаймаСРаботником();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорЗаймаСРаботником();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗайма = Читалка.GetDecimal(4);
							Ссылка.КурсДокумента = Читалка.GetDecimal(6);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(7);
							Ссылка.ПроцентЗаПользованиеЗаймом = Читалка.GetDecimal(8);
							Ссылка.ПорядокПогашенияЗайма = V82.Перечисления/*Ссылка*/.ПорядокПогашенияЗаймаПроцентов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.СрокПогашения = Читалка.GetDecimal(10);
							Ссылка.НачалоПогашения = Читалка.GetDateTime(11);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.НачислятьМатериальнуюВыгоду = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
							Ссылка.Комментарий = Читалка.GetString(18);
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(23))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДоговорЗаймаСРаботником ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld6824RRef [ФизЛицо]
					,_Fld6825 [СуммаЗайма]
					,_Fld6826RRef [ВалютаДокумента]
					,_Fld6827 [КурсДокумента]
					,_Fld6828 [КратностьДокумента]
					,_Fld6829 [ПроцентЗаПользованиеЗаймом]
					,_Fld6830RRef [ПорядокПогашенияЗайма]
					,_Fld6831 [СрокПогашения]
					,_Fld6832 [НачалоПогашения]
					,_Fld6833 [ОтражатьВУправленческомУчете]
					,_Fld6834 [ОтражатьВБухгалтерскомУчете]
					,_Fld6835RRef [Организация]
					,_Fld6836 [НачислятьМатериальнуюВыгоду]
					,_Fld6837RRef [СтавкаНалогообложенияРезидента]
					,_Fld6838RRef [СчетУчетаПроцентовПоЗайму]
					,_Fld6839 [Комментарий]
					,_Fld6840RRef [Ответственный]
					,_Fld6841RRef [Субконто1]
					,_Fld6842RRef [Субконто2]
					,_Fld6843RRef [Субконто3]
					,_Fld6844 [ДанныеПрошлойВерсии]
					From _Document356(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ДоговорЗаймаСРаботником();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорЗаймаСРаботником();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗайма = Читалка.GetDecimal(4);
							Ссылка.КурсДокумента = Читалка.GetDecimal(6);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(7);
							Ссылка.ПроцентЗаПользованиеЗаймом = Читалка.GetDecimal(8);
							Ссылка.ПорядокПогашенияЗайма = V82.Перечисления/*Ссылка*/.ПорядокПогашенияЗаймаПроцентов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.СрокПогашения = Читалка.GetDecimal(10);
							Ссылка.НачалоПогашения = Читалка.GetDateTime(11);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.НачислятьМатериальнуюВыгоду = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
							Ссылка.Комментарий = Читалка.GetString(18);
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(23))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДоговорЗаймаСРаботником СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld6824RRef [ФизЛицо]
					,_Fld6825 [СуммаЗайма]
					,_Fld6826RRef [ВалютаДокумента]
					,_Fld6827 [КурсДокумента]
					,_Fld6828 [КратностьДокумента]
					,_Fld6829 [ПроцентЗаПользованиеЗаймом]
					,_Fld6830RRef [ПорядокПогашенияЗайма]
					,_Fld6831 [СрокПогашения]
					,_Fld6832 [НачалоПогашения]
					,_Fld6833 [ОтражатьВУправленческомУчете]
					,_Fld6834 [ОтражатьВБухгалтерскомУчете]
					,_Fld6835RRef [Организация]
					,_Fld6836 [НачислятьМатериальнуюВыгоду]
					,_Fld6837RRef [СтавкаНалогообложенияРезидента]
					,_Fld6838RRef [СчетУчетаПроцентовПоЗайму]
					,_Fld6839 [Комментарий]
					,_Fld6840RRef [Ответственный]
					,_Fld6841RRef [Субконто1]
					,_Fld6842RRef [Субконто2]
					,_Fld6843RRef [Субконто3]
					,_Fld6844 [ДанныеПрошлойВерсии]
					From _Document356(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ДоговорЗаймаСРаботником();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорЗаймаСРаботником();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗайма = Читалка.GetDecimal(4);
							Ссылка.КурсДокумента = Читалка.GetDecimal(6);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(7);
							Ссылка.ПроцентЗаПользованиеЗаймом = Читалка.GetDecimal(8);
							Ссылка.ПорядокПогашенияЗайма = V82.Перечисления/*Ссылка*/.ПорядокПогашенияЗаймаПроцентов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.СрокПогашения = Читалка.GetDecimal(10);
							Ссылка.НачалоПогашения = Читалка.GetDateTime(11);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.НачислятьМатериальнуюВыгоду = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
							Ссылка.Комментарий = Читалка.GetString(18);
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(23))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДоговорЗаймаСРаботником СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld6824RRef [ФизЛицо]
					,_Fld6825 [СуммаЗайма]
					,_Fld6826RRef [ВалютаДокумента]
					,_Fld6827 [КурсДокумента]
					,_Fld6828 [КратностьДокумента]
					,_Fld6829 [ПроцентЗаПользованиеЗаймом]
					,_Fld6830RRef [ПорядокПогашенияЗайма]
					,_Fld6831 [СрокПогашения]
					,_Fld6832 [НачалоПогашения]
					,_Fld6833 [ОтражатьВУправленческомУчете]
					,_Fld6834 [ОтражатьВБухгалтерскомУчете]
					,_Fld6835RRef [Организация]
					,_Fld6836 [НачислятьМатериальнуюВыгоду]
					,_Fld6837RRef [СтавкаНалогообложенияРезидента]
					,_Fld6838RRef [СчетУчетаПроцентовПоЗайму]
					,_Fld6839 [Комментарий]
					,_Fld6840RRef [Ответственный]
					,_Fld6841RRef [Субконто1]
					,_Fld6842RRef [Субконто2]
					,_Fld6843RRef [Субконто3]
					,_Fld6844 [ДанныеПрошлойВерсии]
					From _Document356(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ДоговорЗаймаСРаботником();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорЗаймаСРаботником();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗайма = Читалка.GetDecimal(4);
							Ссылка.КурсДокумента = Читалка.GetDecimal(6);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(7);
							Ссылка.ПроцентЗаПользованиеЗаймом = Читалка.GetDecimal(8);
							Ссылка.ПорядокПогашенияЗайма = V82.Перечисления/*Ссылка*/.ПорядокПогашенияЗаймаПроцентов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.СрокПогашения = Читалка.GetDecimal(10);
							Ссылка.НачалоПогашения = Читалка.GetDateTime(11);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.НачислятьМатериальнуюВыгоду = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
							Ссылка.Комментарий = Читалка.GetString(18);
							Ссылка.ДанныеПрошлойВерсии = ((byte[])Читалка.GetValue(23))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ДоговорЗаймаСРаботником СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ДоговорЗаймаСРаботником();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ПорядокПогашенияЗайма = V82.Перечисления/*Ссылка*/.ПорядокПогашенияЗаймаПроцентов.ПустаяСсылка;
			Объект.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка;
			return Объект;
		}
	}
}