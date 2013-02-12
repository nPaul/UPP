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
	///<summary>
	///(Регл)
	///</summary>
	public partial class ДоходыНДФЛ:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ДоходыНДФЛ НайтиПоКоду(string Код)
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
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2297RRef [СтавкаНалогообложенияРезидента]
					,_Fld2298 [КодДляОтчетности]
					,_Fld2299 [НеОблагаетсяУНалоговогоАгента]
					,_Fld2300 [НеОтражаетсяВОтчетности2010]
					,_Fld2301 [УчитыватьПоПериодуДействия]
					From _Reference95(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ДоходыНДФЛ();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.КодДляОтчетности = Читалка.GetString(7);
							Ссылка.НеОблагаетсяУНалоговогоАгента = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.УчитыватьПоПериодуДействия = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
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
		
		public static СправочникиВыборка.ДоходыНДФЛ Выбрать()
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2297RRef [СтавкаНалогообложенияРезидента]
					,_Fld2298 [КодДляОтчетности]
					,_Fld2299 [НеОблагаетсяУНалоговогоАгента]
					,_Fld2300 [НеОтражаетсяВОтчетности2010]
					,_Fld2301 [УчитыватьПоПериодуДействия]
							From _Reference95(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ДоходыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ДоходыНДФЛ();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.КодДляОтчетности = Читалка.GetString(7);
							Ссылка.НеОблагаетсяУНалоговогоАгента = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.УчитыватьПоПериодуДействия = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ДоходыНДФЛ ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2297RRef [СтавкаНалогообложенияРезидента]
					,_Fld2298 [КодДляОтчетности]
					,_Fld2299 [НеОблагаетсяУНалоговогоАгента]
					,_Fld2300 [НеОтражаетсяВОтчетности2010]
					,_Fld2301 [УчитыватьПоПериодуДействия]
							From _Reference95(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ДоходыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ДоходыНДФЛ();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.КодДляОтчетности = Читалка.GetString(7);
							Ссылка.НеОблагаетсяУНалоговогоАгента = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.УчитыватьПоПериодуДействия = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ДоходыНДФЛ ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2297RRef [СтавкаНалогообложенияРезидента]
					,_Fld2298 [КодДляОтчетности]
					,_Fld2299 [НеОблагаетсяУНалоговогоАгента]
					,_Fld2300 [НеОтражаетсяВОтчетности2010]
					,_Fld2301 [УчитыватьПоПериодуДействия]
							From _Reference95(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ДоходыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ДоходыНДФЛ();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.КодДляОтчетности = Читалка.GetString(7);
							Ссылка.НеОблагаетсяУНалоговогоАгента = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.УчитыватьПоПериодуДействия = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ДоходыНДФЛ ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2297RRef [СтавкаНалогообложенияРезидента]
					,_Fld2298 [КодДляОтчетности]
					,_Fld2299 [НеОблагаетсяУНалоговогоАгента]
					,_Fld2300 [НеОтражаетсяВОтчетности2010]
					,_Fld2301 [УчитыватьПоПериодуДействия]
							From _Reference95(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ДоходыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ДоходыНДФЛ();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.КодДляОтчетности = Читалка.GetString(7);
							Ссылка.НеОблагаетсяУНалоговогоАгента = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.УчитыватьПоПериодуДействия = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ДоходыНДФЛ СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ДоходыНДФЛ();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.КодДляОтчетности = "";
			Объект.СтавкаНалогообложенияРезидента = V82.Перечисления/*Ссылка*/.НДФЛСтавкиНалогообложенияРезидента.ПустаяСсылка;
			return Объект;
		}
	}
}