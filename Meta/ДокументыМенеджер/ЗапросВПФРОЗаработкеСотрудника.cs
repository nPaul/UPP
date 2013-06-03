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
	public partial class ЗапросВПФРОЗаработкеСотрудника:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ЗапросВПФРОЗаработкеСотрудника НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld7349RRef [Организация]
					,_Fld7350RRef [Сотрудник]
					,_Fld7351RRef [ФизЛицо]
					,_Fld7352RRef [Страхователь]
					,_Fld7353 [ГодС]
					,_Fld7354 [ГодПо]
					,_Fld7355RRef [Руководитель]
					,_Fld7356RRef [ДолжностьРуководителя]
					,_Fld7357 [НаименованиеТерриториальногоОрганаПФР]
					,_Fld7358 [АдресОрганизации]
					,_Fld7359 [ТелефонОрганизации]
					,_Fld7360 [СтраховойНомерПФР]
					,_Fld7361 [ДатаРождения]
					,_Fld7362 [Фамилия]
					,_Fld7363 [Имя]
					,_Fld7364 [Отчество]
					,_Fld7365 [Адрес]
					,_Fld7366RRef [ВидДокумента]
					,_Fld7367 [СерияДокумента]
					,_Fld7368 [НомерДокумента]
					,_Fld7369 [ДатаВыдачиДокумента]
					,_Fld7370 [КемВыданДокумент]
					,_Fld7371 [Комментарий]
					,_Fld7372RRef [Ответственный]
					From _Document373(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗапросВПФРОЗаработкеСотрудника();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ГодС = Читалка.GetDecimal(7);
							Ссылка.ГодПо = Читалка.GetDecimal(8);
							Ссылка.НаименованиеТерриториальногоОрганаПФР = Читалка.GetString(11);
							Ссылка.АдресОрганизации = Читалка.GetString(12);
							Ссылка.ТелефонОрганизации = Читалка.GetString(13);
							Ссылка.СтраховойНомерПФР = Читалка.GetString(14);
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.Фамилия = Читалка.GetString(16);
							Ссылка.Имя = Читалка.GetString(17);
							Ссылка.Отчество = Читалка.GetString(18);
							Ссылка.Адрес = Читалка.GetString(19);
							Ссылка.СерияДокумента = Читалка.GetString(21);
							Ссылка.НомерДокумента = Читалка.GetString(22);
							Ссылка.ДатаВыдачиДокумента = Читалка.GetDateTime(23);
							Ссылка.КемВыданДокумент = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
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
		
		public static ДокументыСсылка.ЗапросВПФРОЗаработкеСотрудника НайтиПоНомеру(string Номер)
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
					,_Fld7349RRef [Организация]
					,_Fld7350RRef [Сотрудник]
					,_Fld7351RRef [ФизЛицо]
					,_Fld7352RRef [Страхователь]
					,_Fld7353 [ГодС]
					,_Fld7354 [ГодПо]
					,_Fld7355RRef [Руководитель]
					,_Fld7356RRef [ДолжностьРуководителя]
					,_Fld7357 [НаименованиеТерриториальногоОрганаПФР]
					,_Fld7358 [АдресОрганизации]
					,_Fld7359 [ТелефонОрганизации]
					,_Fld7360 [СтраховойНомерПФР]
					,_Fld7361 [ДатаРождения]
					,_Fld7362 [Фамилия]
					,_Fld7363 [Имя]
					,_Fld7364 [Отчество]
					,_Fld7365 [Адрес]
					,_Fld7366RRef [ВидДокумента]
					,_Fld7367 [СерияДокумента]
					,_Fld7368 [НомерДокумента]
					,_Fld7369 [ДатаВыдачиДокумента]
					,_Fld7370 [КемВыданДокумент]
					,_Fld7371 [Комментарий]
					,_Fld7372RRef [Ответственный]
					From _Document373(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗапросВПФРОЗаработкеСотрудника();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ГодС = Читалка.GetDecimal(7);
							Ссылка.ГодПо = Читалка.GetDecimal(8);
							Ссылка.НаименованиеТерриториальногоОрганаПФР = Читалка.GetString(11);
							Ссылка.АдресОрганизации = Читалка.GetString(12);
							Ссылка.ТелефонОрганизации = Читалка.GetString(13);
							Ссылка.СтраховойНомерПФР = Читалка.GetString(14);
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.Фамилия = Читалка.GetString(16);
							Ссылка.Имя = Читалка.GetString(17);
							Ссылка.Отчество = Читалка.GetString(18);
							Ссылка.Адрес = Читалка.GetString(19);
							Ссылка.СерияДокумента = Читалка.GetString(21);
							Ссылка.НомерДокумента = Читалка.GetString(22);
							Ссылка.ДатаВыдачиДокумента = Читалка.GetDateTime(23);
							Ссылка.КемВыданДокумент = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
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
		
		public static ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника Выбрать()
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
					,_Fld7349RRef [Организация]
					,_Fld7350RRef [Сотрудник]
					,_Fld7351RRef [ФизЛицо]
					,_Fld7352RRef [Страхователь]
					,_Fld7353 [ГодС]
					,_Fld7354 [ГодПо]
					,_Fld7355RRef [Руководитель]
					,_Fld7356RRef [ДолжностьРуководителя]
					,_Fld7357 [НаименованиеТерриториальногоОрганаПФР]
					,_Fld7358 [АдресОрганизации]
					,_Fld7359 [ТелефонОрганизации]
					,_Fld7360 [СтраховойНомерПФР]
					,_Fld7361 [ДатаРождения]
					,_Fld7362 [Фамилия]
					,_Fld7363 [Имя]
					,_Fld7364 [Отчество]
					,_Fld7365 [Адрес]
					,_Fld7366RRef [ВидДокумента]
					,_Fld7367 [СерияДокумента]
					,_Fld7368 [НомерДокумента]
					,_Fld7369 [ДатаВыдачиДокумента]
					,_Fld7370 [КемВыданДокумент]
					,_Fld7371 [Комментарий]
					,_Fld7372RRef [Ответственный]
					From _Document373(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗапросВПФРОЗаработкеСотрудника();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ГодС = Читалка.GetDecimal(7);
							Ссылка.ГодПо = Читалка.GetDecimal(8);
							Ссылка.НаименованиеТерриториальногоОрганаПФР = Читалка.GetString(11);
							Ссылка.АдресОрганизации = Читалка.GetString(12);
							Ссылка.ТелефонОрганизации = Читалка.GetString(13);
							Ссылка.СтраховойНомерПФР = Читалка.GetString(14);
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.Фамилия = Читалка.GetString(16);
							Ссылка.Имя = Читалка.GetString(17);
							Ссылка.Отчество = Читалка.GetString(18);
							Ссылка.Адрес = Читалка.GetString(19);
							Ссылка.СерияДокумента = Читалка.GetString(21);
							Ссылка.НомерДокумента = Читалка.GetString(22);
							Ссылка.ДатаВыдачиДокумента = Читалка.GetDateTime(23);
							Ссылка.КемВыданДокумент = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld7349RRef [Организация]
					,_Fld7350RRef [Сотрудник]
					,_Fld7351RRef [ФизЛицо]
					,_Fld7352RRef [Страхователь]
					,_Fld7353 [ГодС]
					,_Fld7354 [ГодПо]
					,_Fld7355RRef [Руководитель]
					,_Fld7356RRef [ДолжностьРуководителя]
					,_Fld7357 [НаименованиеТерриториальногоОрганаПФР]
					,_Fld7358 [АдресОрганизации]
					,_Fld7359 [ТелефонОрганизации]
					,_Fld7360 [СтраховойНомерПФР]
					,_Fld7361 [ДатаРождения]
					,_Fld7362 [Фамилия]
					,_Fld7363 [Имя]
					,_Fld7364 [Отчество]
					,_Fld7365 [Адрес]
					,_Fld7366RRef [ВидДокумента]
					,_Fld7367 [СерияДокумента]
					,_Fld7368 [НомерДокумента]
					,_Fld7369 [ДатаВыдачиДокумента]
					,_Fld7370 [КемВыданДокумент]
					,_Fld7371 [Комментарий]
					,_Fld7372RRef [Ответственный]
					From _Document373(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗапросВПФРОЗаработкеСотрудника();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ГодС = Читалка.GetDecimal(7);
							Ссылка.ГодПо = Читалка.GetDecimal(8);
							Ссылка.НаименованиеТерриториальногоОрганаПФР = Читалка.GetString(11);
							Ссылка.АдресОрганизации = Читалка.GetString(12);
							Ссылка.ТелефонОрганизации = Читалка.GetString(13);
							Ссылка.СтраховойНомерПФР = Читалка.GetString(14);
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.Фамилия = Читалка.GetString(16);
							Ссылка.Имя = Читалка.GetString(17);
							Ссылка.Отчество = Читалка.GetString(18);
							Ссылка.Адрес = Читалка.GetString(19);
							Ссылка.СерияДокумента = Читалка.GetString(21);
							Ссылка.НомерДокумента = Читалка.GetString(22);
							Ссылка.ДатаВыдачиДокумента = Читалка.GetDateTime(23);
							Ссылка.КемВыданДокумент = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld7349RRef [Организация]
					,_Fld7350RRef [Сотрудник]
					,_Fld7351RRef [ФизЛицо]
					,_Fld7352RRef [Страхователь]
					,_Fld7353 [ГодС]
					,_Fld7354 [ГодПо]
					,_Fld7355RRef [Руководитель]
					,_Fld7356RRef [ДолжностьРуководителя]
					,_Fld7357 [НаименованиеТерриториальногоОрганаПФР]
					,_Fld7358 [АдресОрганизации]
					,_Fld7359 [ТелефонОрганизации]
					,_Fld7360 [СтраховойНомерПФР]
					,_Fld7361 [ДатаРождения]
					,_Fld7362 [Фамилия]
					,_Fld7363 [Имя]
					,_Fld7364 [Отчество]
					,_Fld7365 [Адрес]
					,_Fld7366RRef [ВидДокумента]
					,_Fld7367 [СерияДокумента]
					,_Fld7368 [НомерДокумента]
					,_Fld7369 [ДатаВыдачиДокумента]
					,_Fld7370 [КемВыданДокумент]
					,_Fld7371 [Комментарий]
					,_Fld7372RRef [Ответственный]
					From _Document373(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗапросВПФРОЗаработкеСотрудника();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ГодС = Читалка.GetDecimal(7);
							Ссылка.ГодПо = Читалка.GetDecimal(8);
							Ссылка.НаименованиеТерриториальногоОрганаПФР = Читалка.GetString(11);
							Ссылка.АдресОрганизации = Читалка.GetString(12);
							Ссылка.ТелефонОрганизации = Читалка.GetString(13);
							Ссылка.СтраховойНомерПФР = Читалка.GetString(14);
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.Фамилия = Читалка.GetString(16);
							Ссылка.Имя = Читалка.GetString(17);
							Ссылка.Отчество = Читалка.GetString(18);
							Ссылка.Адрес = Читалка.GetString(19);
							Ссылка.СерияДокумента = Читалка.GetString(21);
							Ссылка.НомерДокумента = Читалка.GetString(22);
							Ссылка.ДатаВыдачиДокумента = Читалка.GetDateTime(23);
							Ссылка.КемВыданДокумент = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld7349RRef [Организация]
					,_Fld7350RRef [Сотрудник]
					,_Fld7351RRef [ФизЛицо]
					,_Fld7352RRef [Страхователь]
					,_Fld7353 [ГодС]
					,_Fld7354 [ГодПо]
					,_Fld7355RRef [Руководитель]
					,_Fld7356RRef [ДолжностьРуководителя]
					,_Fld7357 [НаименованиеТерриториальногоОрганаПФР]
					,_Fld7358 [АдресОрганизации]
					,_Fld7359 [ТелефонОрганизации]
					,_Fld7360 [СтраховойНомерПФР]
					,_Fld7361 [ДатаРождения]
					,_Fld7362 [Фамилия]
					,_Fld7363 [Имя]
					,_Fld7364 [Отчество]
					,_Fld7365 [Адрес]
					,_Fld7366RRef [ВидДокумента]
					,_Fld7367 [СерияДокумента]
					,_Fld7368 [НомерДокумента]
					,_Fld7369 [ДатаВыдачиДокумента]
					,_Fld7370 [КемВыданДокумент]
					,_Fld7371 [Комментарий]
					,_Fld7372RRef [Ответственный]
					From _Document373(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗапросВПФРОЗаработкеСотрудника();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ГодС = Читалка.GetDecimal(7);
							Ссылка.ГодПо = Читалка.GetDecimal(8);
							Ссылка.НаименованиеТерриториальногоОрганаПФР = Читалка.GetString(11);
							Ссылка.АдресОрганизации = Читалка.GetString(12);
							Ссылка.ТелефонОрганизации = Читалка.GetString(13);
							Ссылка.СтраховойНомерПФР = Читалка.GetString(14);
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.Фамилия = Читалка.GetString(16);
							Ссылка.Имя = Читалка.GetString(17);
							Ссылка.Отчество = Читалка.GetString(18);
							Ссылка.Адрес = Читалка.GetString(19);
							Ссылка.СерияДокумента = Читалка.GetString(21);
							Ссылка.НомерДокумента = Читалка.GetString(22);
							Ссылка.ДатаВыдачиДокумента = Читалка.GetDateTime(23);
							Ссылка.КемВыданДокумент = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld7349RRef [Организация]
					,_Fld7350RRef [Сотрудник]
					,_Fld7351RRef [ФизЛицо]
					,_Fld7352RRef [Страхователь]
					,_Fld7353 [ГодС]
					,_Fld7354 [ГодПо]
					,_Fld7355RRef [Руководитель]
					,_Fld7356RRef [ДолжностьРуководителя]
					,_Fld7357 [НаименованиеТерриториальногоОрганаПФР]
					,_Fld7358 [АдресОрганизации]
					,_Fld7359 [ТелефонОрганизации]
					,_Fld7360 [СтраховойНомерПФР]
					,_Fld7361 [ДатаРождения]
					,_Fld7362 [Фамилия]
					,_Fld7363 [Имя]
					,_Fld7364 [Отчество]
					,_Fld7365 [Адрес]
					,_Fld7366RRef [ВидДокумента]
					,_Fld7367 [СерияДокумента]
					,_Fld7368 [НомерДокумента]
					,_Fld7369 [ДатаВыдачиДокумента]
					,_Fld7370 [КемВыданДокумент]
					,_Fld7371 [Комментарий]
					,_Fld7372RRef [Ответственный]
					From _Document373(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ЗапросВПФРОЗаработкеСотрудника();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗапросВПФРОЗаработкеСотрудника();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ГодС = Читалка.GetDecimal(7);
							Ссылка.ГодПо = Читалка.GetDecimal(8);
							Ссылка.НаименованиеТерриториальногоОрганаПФР = Читалка.GetString(11);
							Ссылка.АдресОрганизации = Читалка.GetString(12);
							Ссылка.ТелефонОрганизации = Читалка.GetString(13);
							Ссылка.СтраховойНомерПФР = Читалка.GetString(14);
							Ссылка.ДатаРождения = Читалка.GetDateTime(15);
							Ссылка.Фамилия = Читалка.GetString(16);
							Ссылка.Имя = Читалка.GetString(17);
							Ссылка.Отчество = Читалка.GetString(18);
							Ссылка.Адрес = Читалка.GetString(19);
							Ссылка.СерияДокумента = Читалка.GetString(21);
							Ссылка.НомерДокумента = Читалка.GetString(22);
							Ссылка.ДатаВыдачиДокумента = Читалка.GetDateTime(23);
							Ссылка.КемВыданДокумент = Читалка.GetString(24);
							Ссылка.Комментарий = Читалка.GetString(25);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ЗапросВПФРОЗаработкеСотрудника СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ЗапросВПФРОЗаработкеСотрудника();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.НаименованиеТерриториальногоОрганаПФР = "";
			Объект.АдресОрганизации = "";
			Объект.ТелефонОрганизации = "";
			Объект.СтраховойНомерПФР = "";
			Объект.Фамилия = "";
			Объект.Имя = "";
			Объект.Отчество = "";
			Объект.Адрес = "";
			Объект.СерияДокумента = "";
			Объект.НомерДокумента = "";
			Объект.КемВыданДокумент = "";
			Объект.Комментарий = "";
			return Объект;
		}
	}
}