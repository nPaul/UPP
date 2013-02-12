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
	public partial class СерверыДокументооборота:СправочникМенеджер
	{
		
		public static СправочникиСсылка.СерверыДокументооборота НайтиПоКоду(string Код)
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
					,_Fld3392 [АдресЭлектроннойПочтыФНС]
					,_Fld3393 [ДлительностьОжиданияСервера]
					,_Fld3394 [Сертификат]
					,_Fld3395 [АдресЭлектроннойПочтыПФР]
					,_Fld3396 [АдресЭлектроннойПочтыФСГС]
					From _Reference225(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СерверыДокументооборота();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.АдресЭлектроннойПочтыФНС = Читалка.GetString(6);
							Ссылка.ДлительностьОжиданияСервера = Читалка.GetDecimal(7);
							Ссылка.Сертификат = Читалка.GetString(8);
							Ссылка.АдресЭлектроннойПочтыПФР = Читалка.GetString(9);
							Ссылка.АдресЭлектроннойПочтыФСГС = Читалка.GetString(10);
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
		
		public static СправочникиВыборка.СерверыДокументооборота Выбрать()
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
					,_Fld3392 [АдресЭлектроннойПочтыФНС]
					,_Fld3393 [ДлительностьОжиданияСервера]
					,_Fld3394 [Сертификат]
					,_Fld3395 [АдресЭлектроннойПочтыПФР]
					,_Fld3396 [АдресЭлектроннойПочтыФСГС]
							From _Reference225(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СерверыДокументооборота();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СерверыДокументооборота();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.АдресЭлектроннойПочтыФНС = Читалка.GetString(6);
							Ссылка.ДлительностьОжиданияСервера = Читалка.GetDecimal(7);
							Ссылка.Сертификат = Читалка.GetString(8);
							Ссылка.АдресЭлектроннойПочтыПФР = Читалка.GetString(9);
							Ссылка.АдресЭлектроннойПочтыФСГС = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СерверыДокументооборота ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld3392 [АдресЭлектроннойПочтыФНС]
					,_Fld3393 [ДлительностьОжиданияСервера]
					,_Fld3394 [Сертификат]
					,_Fld3395 [АдресЭлектроннойПочтыПФР]
					,_Fld3396 [АдресЭлектроннойПочтыФСГС]
							From _Reference225(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СерверыДокументооборота();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СерверыДокументооборота();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.АдресЭлектроннойПочтыФНС = Читалка.GetString(6);
							Ссылка.ДлительностьОжиданияСервера = Читалка.GetDecimal(7);
							Ссылка.Сертификат = Читалка.GetString(8);
							Ссылка.АдресЭлектроннойПочтыПФР = Читалка.GetString(9);
							Ссылка.АдресЭлектроннойПочтыФСГС = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СерверыДокументооборота ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld3392 [АдресЭлектроннойПочтыФНС]
					,_Fld3393 [ДлительностьОжиданияСервера]
					,_Fld3394 [Сертификат]
					,_Fld3395 [АдресЭлектроннойПочтыПФР]
					,_Fld3396 [АдресЭлектроннойПочтыФСГС]
							From _Reference225(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СерверыДокументооборота();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СерверыДокументооборота();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.АдресЭлектроннойПочтыФНС = Читалка.GetString(6);
							Ссылка.ДлительностьОжиданияСервера = Читалка.GetDecimal(7);
							Ссылка.Сертификат = Читалка.GetString(8);
							Ссылка.АдресЭлектроннойПочтыПФР = Читалка.GetString(9);
							Ссылка.АдресЭлектроннойПочтыФСГС = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СерверыДокументооборота ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld3392 [АдресЭлектроннойПочтыФНС]
					,_Fld3393 [ДлительностьОжиданияСервера]
					,_Fld3394 [Сертификат]
					,_Fld3395 [АдресЭлектроннойПочтыПФР]
					,_Fld3396 [АдресЭлектроннойПочтыФСГС]
							From _Reference225(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СерверыДокументооборота();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СерверыДокументооборота();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.АдресЭлектроннойПочтыФНС = Читалка.GetString(6);
							Ссылка.ДлительностьОжиданияСервера = Читалка.GetDecimal(7);
							Ссылка.Сертификат = Читалка.GetString(8);
							Ссылка.АдресЭлектроннойПочтыПФР = Читалка.GetString(9);
							Ссылка.АдресЭлектроннойПочтыФСГС = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.СерверыДокументооборота СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.СерверыДокументооборота();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.АдресЭлектроннойПочтыФНС = "";
			Объект.Сертификат = "";
			Объект.АдресЭлектроннойПочтыПФР = "";
			Объект.АдресЭлектроннойПочтыФСГС = "";
			return Объект;
		}
	}
}