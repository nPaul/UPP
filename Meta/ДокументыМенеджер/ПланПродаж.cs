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
	///(Упр)
	///</summary>
	public partial class ПланПродаж:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ПланПродаж НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld12845RRef [ВалютаДокумента]
					,_Fld12846 [ДатаПланирования]
					,_Fld12847 [Комментарий]
					,_Fld12848 [КратностьДокумента]
					,_Fld12849 [КурсДокумента]
					,_Fld12850RRef [Ответственный]
					,_Fld12851RRef [Подразделение]
					,_Fld12852RRef [Проект]
					,_Fld12853RRef [Сценарий]
					,_Fld12854 [СуммаДокумента]
					,_Fld12855RRef [ТипЦен]
					,_Fld12856 [СуммаВключаетНДС]
					,_Fld12857 [УчитыватьНДС]
					,_Fld12858 [НастройкиПомощникаПланирования]
					,_Fld12859RRef [ПериодичностьДетализации]
					From _Document511(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПродаж();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаПланирования = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(6);
							Ссылка.КурсДокумента = Читалка.GetDecimal(7);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(12);
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
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
		
		public static ДокументыСсылка.ПланПродаж НайтиПоНомеру(string Номер)
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
					,_Fld12845RRef [ВалютаДокумента]
					,_Fld12846 [ДатаПланирования]
					,_Fld12847 [Комментарий]
					,_Fld12848 [КратностьДокумента]
					,_Fld12849 [КурсДокумента]
					,_Fld12850RRef [Ответственный]
					,_Fld12851RRef [Подразделение]
					,_Fld12852RRef [Проект]
					,_Fld12853RRef [Сценарий]
					,_Fld12854 [СуммаДокумента]
					,_Fld12855RRef [ТипЦен]
					,_Fld12856 [СуммаВключаетНДС]
					,_Fld12857 [УчитыватьНДС]
					,_Fld12858 [НастройкиПомощникаПланирования]
					,_Fld12859RRef [ПериодичностьДетализации]
					From _Document511(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПродаж();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаПланирования = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(6);
							Ссылка.КурсДокумента = Читалка.GetDecimal(7);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(12);
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
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
		
		public static ДокументыВыборка.ПланПродаж Выбрать()
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
					,_Fld12845RRef [ВалютаДокумента]
					,_Fld12846 [ДатаПланирования]
					,_Fld12847 [Комментарий]
					,_Fld12848 [КратностьДокумента]
					,_Fld12849 [КурсДокумента]
					,_Fld12850RRef [Ответственный]
					,_Fld12851RRef [Подразделение]
					,_Fld12852RRef [Проект]
					,_Fld12853RRef [Сценарий]
					,_Fld12854 [СуммаДокумента]
					,_Fld12855RRef [ТипЦен]
					,_Fld12856 [СуммаВключаетНДС]
					,_Fld12857 [УчитыватьНДС]
					,_Fld12858 [НастройкиПомощникаПланирования]
					,_Fld12859RRef [ПериодичностьДетализации]
					From _Document511(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПланПродаж();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПродаж();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаПланирования = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(6);
							Ссылка.КурсДокумента = Читалка.GetDecimal(7);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(12);
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПланПродаж ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld12845RRef [ВалютаДокумента]
					,_Fld12846 [ДатаПланирования]
					,_Fld12847 [Комментарий]
					,_Fld12848 [КратностьДокумента]
					,_Fld12849 [КурсДокумента]
					,_Fld12850RRef [Ответственный]
					,_Fld12851RRef [Подразделение]
					,_Fld12852RRef [Проект]
					,_Fld12853RRef [Сценарий]
					,_Fld12854 [СуммаДокумента]
					,_Fld12855RRef [ТипЦен]
					,_Fld12856 [СуммаВключаетНДС]
					,_Fld12857 [УчитыватьНДС]
					,_Fld12858 [НастройкиПомощникаПланирования]
					,_Fld12859RRef [ПериодичностьДетализации]
					From _Document511(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ПланПродаж();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПродаж();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаПланирования = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(6);
							Ссылка.КурсДокумента = Читалка.GetDecimal(7);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(12);
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПланПродаж ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld12845RRef [ВалютаДокумента]
					,_Fld12846 [ДатаПланирования]
					,_Fld12847 [Комментарий]
					,_Fld12848 [КратностьДокумента]
					,_Fld12849 [КурсДокумента]
					,_Fld12850RRef [Ответственный]
					,_Fld12851RRef [Подразделение]
					,_Fld12852RRef [Проект]
					,_Fld12853RRef [Сценарий]
					,_Fld12854 [СуммаДокумента]
					,_Fld12855RRef [ТипЦен]
					,_Fld12856 [СуммаВключаетНДС]
					,_Fld12857 [УчитыватьНДС]
					,_Fld12858 [НастройкиПомощникаПланирования]
					,_Fld12859RRef [ПериодичностьДетализации]
					From _Document511(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ПланПродаж();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПродаж();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаПланирования = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(6);
							Ссылка.КурсДокумента = Читалка.GetDecimal(7);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(12);
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПланПродаж СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld12845RRef [ВалютаДокумента]
					,_Fld12846 [ДатаПланирования]
					,_Fld12847 [Комментарий]
					,_Fld12848 [КратностьДокумента]
					,_Fld12849 [КурсДокумента]
					,_Fld12850RRef [Ответственный]
					,_Fld12851RRef [Подразделение]
					,_Fld12852RRef [Проект]
					,_Fld12853RRef [Сценарий]
					,_Fld12854 [СуммаДокумента]
					,_Fld12855RRef [ТипЦен]
					,_Fld12856 [СуммаВключаетНДС]
					,_Fld12857 [УчитыватьНДС]
					,_Fld12858 [НастройкиПомощникаПланирования]
					,_Fld12859RRef [ПериодичностьДетализации]
					From _Document511(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПланПродаж();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПродаж();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаПланирования = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(6);
							Ссылка.КурсДокумента = Читалка.GetDecimal(7);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(12);
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПланПродаж СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld12845RRef [ВалютаДокумента]
					,_Fld12846 [ДатаПланирования]
					,_Fld12847 [Комментарий]
					,_Fld12848 [КратностьДокумента]
					,_Fld12849 [КурсДокумента]
					,_Fld12850RRef [Ответственный]
					,_Fld12851RRef [Подразделение]
					,_Fld12852RRef [Проект]
					,_Fld12853RRef [Сценарий]
					,_Fld12854 [СуммаДокумента]
					,_Fld12855RRef [ТипЦен]
					,_Fld12856 [СуммаВключаетНДС]
					,_Fld12857 [УчитыватьНДС]
					,_Fld12858 [НастройкиПомощникаПланирования]
					,_Fld12859RRef [ПериодичностьДетализации]
					From _Document511(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПланПродаж();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПродаж();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ДатаПланирования = Читалка.GetDateTime(4);
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.КратностьДокумента = Читалка.GetDecimal(6);
							Ссылка.КурсДокумента = Читалка.GetDecimal(7);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(12);
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ПланПродаж СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ПланПродаж();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			return Объект;
		}
	}
}