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
	public partial class СправкаДругогоСтрахователяОЗаработке:ДокументМенеджер
	{
		
		public static ДокументыСсылка.СправкаДругогоСтрахователяОЗаработке НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld25403RRef [Организация]
					,_Fld25404RRef [Сотрудник]
					,_Fld25405RRef [ФизЛицо]
					,_Fld25406RRef [Страхователь]
					,_Fld25407 [ПериодРаботыС]
					,_Fld25408 [ПериодРаботыПо]
					,_Fld25409 [Комментарий]
					,_Fld25410RRef [Ответственный]
					From _Document23172(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СправкаДругогоСтрахователяОЗаработке();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРаботыС = Читалка.GetDateTime(7);
							Ссылка.ПериодРаботыПо = Читалка.GetDateTime(8);
							Ссылка.Комментарий = Читалка.GetString(9);
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
		
		public static ДокументыСсылка.СправкаДругогоСтрахователяОЗаработке НайтиПоНомеру(string Номер)
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
					,_Fld25403RRef [Организация]
					,_Fld25404RRef [Сотрудник]
					,_Fld25405RRef [ФизЛицо]
					,_Fld25406RRef [Страхователь]
					,_Fld25407 [ПериодРаботыС]
					,_Fld25408 [ПериодРаботыПо]
					,_Fld25409 [Комментарий]
					,_Fld25410RRef [Ответственный]
					From _Document23172(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СправкаДругогоСтрахователяОЗаработке();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРаботыС = Читалка.GetDateTime(7);
							Ссылка.ПериодРаботыПо = Читалка.GetDateTime(8);
							Ссылка.Комментарий = Читалка.GetString(9);
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
		
		public static ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке Выбрать()
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
					,_Fld25403RRef [Организация]
					,_Fld25404RRef [Сотрудник]
					,_Fld25405RRef [ФизЛицо]
					,_Fld25406RRef [Страхователь]
					,_Fld25407 [ПериодРаботыС]
					,_Fld25408 [ПериодРаботыПо]
					,_Fld25409 [Комментарий]
					,_Fld25410RRef [Ответственный]
					From _Document23172(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СправкаДругогоСтрахователяОЗаработке();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРаботыС = Читалка.GetDateTime(7);
							Ссылка.ПериодРаботыПо = Читалка.GetDateTime(8);
							Ссылка.Комментарий = Читалка.GetString(9);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld25403RRef [Организация]
					,_Fld25404RRef [Сотрудник]
					,_Fld25405RRef [ФизЛицо]
					,_Fld25406RRef [Страхователь]
					,_Fld25407 [ПериодРаботыС]
					,_Fld25408 [ПериодРаботыПо]
					,_Fld25409 [Комментарий]
					,_Fld25410RRef [Ответственный]
					From _Document23172(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СправкаДругогоСтрахователяОЗаработке();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРаботыС = Читалка.GetDateTime(7);
							Ссылка.ПериодРаботыПо = Читалка.GetDateTime(8);
							Ссылка.Комментарий = Читалка.GetString(9);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld25403RRef [Организация]
					,_Fld25404RRef [Сотрудник]
					,_Fld25405RRef [ФизЛицо]
					,_Fld25406RRef [Страхователь]
					,_Fld25407 [ПериодРаботыС]
					,_Fld25408 [ПериодРаботыПо]
					,_Fld25409 [Комментарий]
					,_Fld25410RRef [Ответственный]
					From _Document23172(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СправкаДругогоСтрахователяОЗаработке();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРаботыС = Читалка.GetDateTime(7);
							Ссылка.ПериодРаботыПо = Читалка.GetDateTime(8);
							Ссылка.Комментарий = Читалка.GetString(9);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld25403RRef [Организация]
					,_Fld25404RRef [Сотрудник]
					,_Fld25405RRef [ФизЛицо]
					,_Fld25406RRef [Страхователь]
					,_Fld25407 [ПериодРаботыС]
					,_Fld25408 [ПериодРаботыПо]
					,_Fld25409 [Комментарий]
					,_Fld25410RRef [Ответственный]
					From _Document23172(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СправкаДругогоСтрахователяОЗаработке();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРаботыС = Читалка.GetDateTime(7);
							Ссылка.ПериодРаботыПо = Читалка.GetDateTime(8);
							Ссылка.Комментарий = Читалка.GetString(9);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld25403RRef [Организация]
					,_Fld25404RRef [Сотрудник]
					,_Fld25405RRef [ФизЛицо]
					,_Fld25406RRef [Страхователь]
					,_Fld25407 [ПериодРаботыС]
					,_Fld25408 [ПериодРаботыПо]
					,_Fld25409 [Комментарий]
					,_Fld25410RRef [Ответственный]
					From _Document23172(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.СправкаДругогоСтрахователяОЗаработке();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СправкаДругогоСтрахователяОЗаработке();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ПериодРаботыС = Читалка.GetDateTime(7);
							Ссылка.ПериодРаботыПо = Читалка.GetDateTime(8);
							Ссылка.Комментарий = Читалка.GetString(9);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.СправкаДругогоСтрахователяОЗаработке СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.СправкаДругогоСтрахователяОЗаработке();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			return Объект;
		}
	}
}