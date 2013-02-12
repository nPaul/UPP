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
	public partial class СохраненныеНастройки:СправочникМенеджер
	{
		
		public static СправочникиВыборка.СохраненныеНастройки Выбрать()
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
					,_Fld3564RRef [ТипНастройки]
					,_Fld3565_TYPE [НастраиваемыйОбъект_Тип],_Fld3565_RRRef [НастраиваемыйОбъект],_Fld3565_RTRef [НастраиваемыйОбъект_Вид]
					,_Fld3566 [СохранятьАвтоматически]
					,_Fld3567 [ИспользоватьПриОткрытии]
					,_Fld3568 [СохранятьПериод]
					,_Fld3569 [ОткрыватьПриЗапуске]
					,_Fld3570 [ХранилищеНастроек]
					,_Fld3571 [Описание]
					,_Fld3572 [КраткийСоставНастройки]
							From _Reference238(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СохраненныеНастройки();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СохраненныеНастройки();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ТипНастройки = V82.Перечисления/*Ссылка*/.ТипыНастроек.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.СохранятьАвтоматически = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИспользоватьПриОткрытии = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.СохранятьПериод = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.ОткрыватьПриЗапуске = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Описание = Читалка.GetString(14);
							Ссылка.КраткийСоставНастройки = Читалка.GetString(15);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СохраненныеНастройки ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld3564RRef [ТипНастройки]
					,_Fld3565_TYPE [НастраиваемыйОбъект_Тип],_Fld3565_RRRef [НастраиваемыйОбъект],_Fld3565_RTRef [НастраиваемыйОбъект_Вид]
					,_Fld3566 [СохранятьАвтоматически]
					,_Fld3567 [ИспользоватьПриОткрытии]
					,_Fld3568 [СохранятьПериод]
					,_Fld3569 [ОткрыватьПриЗапуске]
					,_Fld3570 [ХранилищеНастроек]
					,_Fld3571 [Описание]
					,_Fld3572 [КраткийСоставНастройки]
							From _Reference238(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СохраненныеНастройки();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СохраненныеНастройки();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ТипНастройки = V82.Перечисления/*Ссылка*/.ТипыНастроек.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.СохранятьАвтоматически = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИспользоватьПриОткрытии = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.СохранятьПериод = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.ОткрыватьПриЗапуске = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Описание = Читалка.GetString(14);
							Ссылка.КраткийСоставНастройки = Читалка.GetString(15);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СохраненныеНастройки ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld3564RRef [ТипНастройки]
					,_Fld3565_TYPE [НастраиваемыйОбъект_Тип],_Fld3565_RRRef [НастраиваемыйОбъект],_Fld3565_RTRef [НастраиваемыйОбъект_Вид]
					,_Fld3566 [СохранятьАвтоматически]
					,_Fld3567 [ИспользоватьПриОткрытии]
					,_Fld3568 [СохранятьПериод]
					,_Fld3569 [ОткрыватьПриЗапуске]
					,_Fld3570 [ХранилищеНастроек]
					,_Fld3571 [Описание]
					,_Fld3572 [КраткийСоставНастройки]
							From _Reference238(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СохраненныеНастройки();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СохраненныеНастройки();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ТипНастройки = V82.Перечисления/*Ссылка*/.ТипыНастроек.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.СохранятьАвтоматически = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Ссылка.ИспользоватьПриОткрытии = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.СохранятьПериод = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.ОткрыватьПриЗапуске = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Описание = Читалка.GetString(14);
							Ссылка.КраткийСоставНастройки = Читалка.GetString(15);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.СохраненныеНастройки СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.СохраненныеНастройки();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Описание = "";
			Объект.КраткийСоставНастройки = "";
			Объект.ТипНастройки = V82.Перечисления/*Ссылка*/.ТипыНастроек.ПустаяСсылка;
			return Объект;
		}
	}
}