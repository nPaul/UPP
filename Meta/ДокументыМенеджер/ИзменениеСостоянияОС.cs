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
	public partial class ИзменениеСостоянияОС:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ИзменениеСостоянияОС НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld7989RRef [Ответственный]
					,_Fld7990 [ВремяНапоминания]
					,_Fld7991 [ВлияетНаНачислениеАмортизации]
					,_Fld7992 [НапомнитьОСобытии]
					,_Fld7993 [Комментарий]
					,_Fld7994 [НачислятьАмортизациюВТекущемМесяце]
					,_Fld7995RRef [Организация]
					,_Fld7996 [ОтражатьВБухгалтерскомУчете]
					,_Fld7997 [ОтражатьВНалоговомУчете]
					,_Fld7998 [НачислятьАмортизацию]
					,_Fld7999 [ОтражатьВУправленческомУчете]
					,_Fld8000RRef [Событие]
					,_Fld8001RRef [СобытиеРегл]
					From _Document395(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеСостоянияОС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВремяНапоминания = Читалка.GetDateTime(4);
							Ссылка.ВлияетНаНачислениеАмортизации = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.НапомнитьОСобытии = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.НачислятьАмортизациюВТекущемМесяце = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.НачислятьАмортизацию = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
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
		
		public static ДокументыСсылка.ИзменениеСостоянияОС НайтиПоНомеру(string Номер)
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
					,_Fld7989RRef [Ответственный]
					,_Fld7990 [ВремяНапоминания]
					,_Fld7991 [ВлияетНаНачислениеАмортизации]
					,_Fld7992 [НапомнитьОСобытии]
					,_Fld7993 [Комментарий]
					,_Fld7994 [НачислятьАмортизациюВТекущемМесяце]
					,_Fld7995RRef [Организация]
					,_Fld7996 [ОтражатьВБухгалтерскомУчете]
					,_Fld7997 [ОтражатьВНалоговомУчете]
					,_Fld7998 [НачислятьАмортизацию]
					,_Fld7999 [ОтражатьВУправленческомУчете]
					,_Fld8000RRef [Событие]
					,_Fld8001RRef [СобытиеРегл]
					From _Document395(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеСостоянияОС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВремяНапоминания = Читалка.GetDateTime(4);
							Ссылка.ВлияетНаНачислениеАмортизации = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.НапомнитьОСобытии = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.НачислятьАмортизациюВТекущемМесяце = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.НачислятьАмортизацию = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
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
		
		public static ДокументыВыборка.ИзменениеСостоянияОС Выбрать()
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
					,_Fld7989RRef [Ответственный]
					,_Fld7990 [ВремяНапоминания]
					,_Fld7991 [ВлияетНаНачислениеАмортизации]
					,_Fld7992 [НапомнитьОСобытии]
					,_Fld7993 [Комментарий]
					,_Fld7994 [НачислятьАмортизациюВТекущемМесяце]
					,_Fld7995RRef [Организация]
					,_Fld7996 [ОтражатьВБухгалтерскомУчете]
					,_Fld7997 [ОтражатьВНалоговомУчете]
					,_Fld7998 [НачислятьАмортизацию]
					,_Fld7999 [ОтражатьВУправленческомУчете]
					,_Fld8000RRef [Событие]
					,_Fld8001RRef [СобытиеРегл]
					From _Document395(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИзменениеСостоянияОС();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеСостоянияОС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВремяНапоминания = Читалка.GetDateTime(4);
							Ссылка.ВлияетНаНачислениеАмортизации = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.НапомнитьОСобытии = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.НачислятьАмортизациюВТекущемМесяце = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.НачислятьАмортизацию = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеСостоянияОС ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld7989RRef [Ответственный]
					,_Fld7990 [ВремяНапоминания]
					,_Fld7991 [ВлияетНаНачислениеАмортизации]
					,_Fld7992 [НапомнитьОСобытии]
					,_Fld7993 [Комментарий]
					,_Fld7994 [НачислятьАмортизациюВТекущемМесяце]
					,_Fld7995RRef [Организация]
					,_Fld7996 [ОтражатьВБухгалтерскомУчете]
					,_Fld7997 [ОтражатьВНалоговомУчете]
					,_Fld7998 [НачислятьАмортизацию]
					,_Fld7999 [ОтражатьВУправленческомУчете]
					,_Fld8000RRef [Событие]
					,_Fld8001RRef [СобытиеРегл]
					From _Document395(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ИзменениеСостоянияОС();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеСостоянияОС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВремяНапоминания = Читалка.GetDateTime(4);
							Ссылка.ВлияетНаНачислениеАмортизации = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.НапомнитьОСобытии = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.НачислятьАмортизациюВТекущемМесяце = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.НачислятьАмортизацию = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеСостоянияОС ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld7989RRef [Ответственный]
					,_Fld7990 [ВремяНапоминания]
					,_Fld7991 [ВлияетНаНачислениеАмортизации]
					,_Fld7992 [НапомнитьОСобытии]
					,_Fld7993 [Комментарий]
					,_Fld7994 [НачислятьАмортизациюВТекущемМесяце]
					,_Fld7995RRef [Организация]
					,_Fld7996 [ОтражатьВБухгалтерскомУчете]
					,_Fld7997 [ОтражатьВНалоговомУчете]
					,_Fld7998 [НачислятьАмортизацию]
					,_Fld7999 [ОтражатьВУправленческомУчете]
					,_Fld8000RRef [Событие]
					,_Fld8001RRef [СобытиеРегл]
					From _Document395(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ИзменениеСостоянияОС();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеСостоянияОС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВремяНапоминания = Читалка.GetDateTime(4);
							Ссылка.ВлияетНаНачислениеАмортизации = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.НапомнитьОСобытии = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.НачислятьАмортизациюВТекущемМесяце = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.НачислятьАмортизацию = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеСостоянияОС СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld7989RRef [Ответственный]
					,_Fld7990 [ВремяНапоминания]
					,_Fld7991 [ВлияетНаНачислениеАмортизации]
					,_Fld7992 [НапомнитьОСобытии]
					,_Fld7993 [Комментарий]
					,_Fld7994 [НачислятьАмортизациюВТекущемМесяце]
					,_Fld7995RRef [Организация]
					,_Fld7996 [ОтражатьВБухгалтерскомУчете]
					,_Fld7997 [ОтражатьВНалоговомУчете]
					,_Fld7998 [НачислятьАмортизацию]
					,_Fld7999 [ОтражатьВУправленческомУчете]
					,_Fld8000RRef [Событие]
					,_Fld8001RRef [СобытиеРегл]
					From _Document395(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИзменениеСостоянияОС();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеСостоянияОС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВремяНапоминания = Читалка.GetDateTime(4);
							Ссылка.ВлияетНаНачислениеАмортизации = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.НапомнитьОСобытии = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.НачислятьАмортизациюВТекущемМесяце = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.НачислятьАмортизацию = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеСостоянияОС СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld7989RRef [Ответственный]
					,_Fld7990 [ВремяНапоминания]
					,_Fld7991 [ВлияетНаНачислениеАмортизации]
					,_Fld7992 [НапомнитьОСобытии]
					,_Fld7993 [Комментарий]
					,_Fld7994 [НачислятьАмортизациюВТекущемМесяце]
					,_Fld7995RRef [Организация]
					,_Fld7996 [ОтражатьВБухгалтерскомУчете]
					,_Fld7997 [ОтражатьВНалоговомУчете]
					,_Fld7998 [НачислятьАмортизацию]
					,_Fld7999 [ОтражатьВУправленческомУчете]
					,_Fld8000RRef [Событие]
					,_Fld8001RRef [СобытиеРегл]
					From _Document395(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИзменениеСостоянияОС();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеСостоянияОС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВремяНапоминания = Читалка.GetDateTime(4);
							Ссылка.ВлияетНаНачислениеАмортизации = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.НапомнитьОСобытии = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(7);
							Ссылка.НачислятьАмортизациюВТекущемМесяце = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.НачислятьАмортизацию = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(13))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ИзменениеСостоянияОС СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ИзменениеСостоянияОС();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			return Объект;
		}
	}
}