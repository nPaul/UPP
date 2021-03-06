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
	public partial class ВыпускПродукции:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ВыпускПродукции НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld24112RRef [Организация]
					,_Fld24113RRef [Подразделение]
					,_Fld24114 [ОтражатьВУправленческомУчете]
					,_Fld24115 [ОтражатьВБухгалтерскомУчете]
					,_Fld24116 [ОтражатьВНалоговомУчете]
					,_Fld24117RRef [Склад]
					,_Fld24118RRef [ПодразделениеОрганизации]
					,_Fld24119RRef [СчетЗатрат]
					,_Fld24120RRef [СчетЗатратНУ]
					,_Fld24121 [Комментарий]
					,_Fld24122RRef [Ответственный]
					From _Document23142(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВыпускПродукции();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(12);
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
		
		public static ДокументыСсылка.ВыпускПродукции НайтиПоНомеру(string Номер)
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
					,_Fld24112RRef [Организация]
					,_Fld24113RRef [Подразделение]
					,_Fld24114 [ОтражатьВУправленческомУчете]
					,_Fld24115 [ОтражатьВБухгалтерскомУчете]
					,_Fld24116 [ОтражатьВНалоговомУчете]
					,_Fld24117RRef [Склад]
					,_Fld24118RRef [ПодразделениеОрганизации]
					,_Fld24119RRef [СчетЗатрат]
					,_Fld24120RRef [СчетЗатратНУ]
					,_Fld24121 [Комментарий]
					,_Fld24122RRef [Ответственный]
					From _Document23142(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВыпускПродукции();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(12);
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
		
		public static ДокументыВыборка.ВыпускПродукции Выбрать()
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
					,_Fld24112RRef [Организация]
					,_Fld24113RRef [Подразделение]
					,_Fld24114 [ОтражатьВУправленческомУчете]
					,_Fld24115 [ОтражатьВБухгалтерскомУчете]
					,_Fld24116 [ОтражатьВНалоговомУчете]
					,_Fld24117RRef [Склад]
					,_Fld24118RRef [ПодразделениеОрганизации]
					,_Fld24119RRef [СчетЗатрат]
					,_Fld24120RRef [СчетЗатратНУ]
					,_Fld24121 [Комментарий]
					,_Fld24122RRef [Ответственный]
					From _Document23142(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ВыпускПродукции();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВыпускПродукции();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВыпускПродукции ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld24112RRef [Организация]
					,_Fld24113RRef [Подразделение]
					,_Fld24114 [ОтражатьВУправленческомУчете]
					,_Fld24115 [ОтражатьВБухгалтерскомУчете]
					,_Fld24116 [ОтражатьВНалоговомУчете]
					,_Fld24117RRef [Склад]
					,_Fld24118RRef [ПодразделениеОрганизации]
					,_Fld24119RRef [СчетЗатрат]
					,_Fld24120RRef [СчетЗатратНУ]
					,_Fld24121 [Комментарий]
					,_Fld24122RRef [Ответственный]
					From _Document23142(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ВыпускПродукции();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВыпускПродукции();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВыпускПродукции ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld24112RRef [Организация]
					,_Fld24113RRef [Подразделение]
					,_Fld24114 [ОтражатьВУправленческомУчете]
					,_Fld24115 [ОтражатьВБухгалтерскомУчете]
					,_Fld24116 [ОтражатьВНалоговомУчете]
					,_Fld24117RRef [Склад]
					,_Fld24118RRef [ПодразделениеОрганизации]
					,_Fld24119RRef [СчетЗатрат]
					,_Fld24120RRef [СчетЗатратНУ]
					,_Fld24121 [Комментарий]
					,_Fld24122RRef [Ответственный]
					From _Document23142(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ВыпускПродукции();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВыпускПродукции();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВыпускПродукции СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld24112RRef [Организация]
					,_Fld24113RRef [Подразделение]
					,_Fld24114 [ОтражатьВУправленческомУчете]
					,_Fld24115 [ОтражатьВБухгалтерскомУчете]
					,_Fld24116 [ОтражатьВНалоговомУчете]
					,_Fld24117RRef [Склад]
					,_Fld24118RRef [ПодразделениеОрганизации]
					,_Fld24119RRef [СчетЗатрат]
					,_Fld24120RRef [СчетЗатратНУ]
					,_Fld24121 [Комментарий]
					,_Fld24122RRef [Ответственный]
					From _Document23142(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ВыпускПродукции();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВыпускПродукции();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВыпускПродукции СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld24112RRef [Организация]
					,_Fld24113RRef [Подразделение]
					,_Fld24114 [ОтражатьВУправленческомУчете]
					,_Fld24115 [ОтражатьВБухгалтерскомУчете]
					,_Fld24116 [ОтражатьВНалоговомУчете]
					,_Fld24117RRef [Склад]
					,_Fld24118RRef [ПодразделениеОрганизации]
					,_Fld24119RRef [СчетЗатрат]
					,_Fld24120RRef [СчетЗатратНУ]
					,_Fld24121 [Комментарий]
					,_Fld24122RRef [Ответственный]
					From _Document23142(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ВыпускПродукции();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВыпускПродукции();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(12);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ВыпускПродукции СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ВыпускПродукции();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			return Объект;
		}
	}
}