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
	///(Упр)
	///</summary>
	public partial class СтрокиФинансовогоРасчета:СправочникМенеджер
	{
		
		public static СправочникиСсылка.СтрокиФинансовогоРасчета НайтиПоКоду(string Код)
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
					,_Fld3852RRef [ВидСтроки]
					,_Fld3853_TYPE [Измерение_Тип],_Fld3853_RRRef [Измерение],_Fld3853_RTRef [Измерение_Вид]
					,_Fld3854 [Формула]
					From _Reference253(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтрокиФинансовогоРасчета();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВидСтроки = V82.Перечисления/*Ссылка*/.ВидыСтрокФинансовогоРасчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Формула = Читалка.GetString(10);
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
		
		public static СправочникиВыборка.СтрокиФинансовогоРасчета Выбрать()
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
					,_Fld3852RRef [ВидСтроки]
					,_Fld3853_TYPE [Измерение_Тип],_Fld3853_RRRef [Измерение],_Fld3853_RTRef [Измерение_Вид]
					,_Fld3854 [Формула]
							From _Reference253(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СтрокиФинансовогоРасчета();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтрокиФинансовогоРасчета();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВидСтроки = V82.Перечисления/*Ссылка*/.ВидыСтрокФинансовогоРасчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Формула = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СтрокиФинансовогоРасчета ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld3852RRef [ВидСтроки]
					,_Fld3853_TYPE [Измерение_Тип],_Fld3853_RRRef [Измерение],_Fld3853_RTRef [Измерение_Вид]
					,_Fld3854 [Формула]
							From _Reference253(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СтрокиФинансовогоРасчета();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтрокиФинансовогоРасчета();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВидСтроки = V82.Перечисления/*Ссылка*/.ВидыСтрокФинансовогоРасчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Формула = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СтрокиФинансовогоРасчета ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld3852RRef [ВидСтроки]
					,_Fld3853_TYPE [Измерение_Тип],_Fld3853_RRRef [Измерение],_Fld3853_RTRef [Измерение_Вид]
					,_Fld3854 [Формула]
							From _Reference253(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СтрокиФинансовогоРасчета();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтрокиФинансовогоРасчета();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВидСтроки = V82.Перечисления/*Ссылка*/.ВидыСтрокФинансовогоРасчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Формула = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СтрокиФинансовогоРасчета ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld3852RRef [ВидСтроки]
					,_Fld3853_TYPE [Измерение_Тип],_Fld3853_RRRef [Измерение],_Fld3853_RTRef [Измерение_Вид]
					,_Fld3854 [Формула]
							From _Reference253(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СтрокиФинансовогоРасчета();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтрокиФинансовогоРасчета();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВидСтроки = V82.Перечисления/*Ссылка*/.ВидыСтрокФинансовогоРасчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.Формула = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.СтрокиФинансовогоРасчета СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.СтрокиФинансовогоРасчета();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Формула = "";
			Объект.ВидСтроки = V82.Перечисления/*Ссылка*/.ВидыСтрокФинансовогоРасчета.ПустаяСсылка;
			return Объект;
		}
	}
}