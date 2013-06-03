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
	public partial class ПланПроизводства:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ПланПроизводства НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld12882RRef [ВалютаДокумента]
					,_Fld12883 [ДатаПланирования]
					,_Fld12884 [Комментарий]
					,_Fld12885 [КратностьДокумента]
					,_Fld12886 [КурсДокумента]
					,_Fld12887RRef [Ответственный]
					,_Fld12888RRef [Подразделение]
					,_Fld12889RRef [Проект]
					,_Fld12890RRef [Сценарий]
					,_Fld12891 [СуммаДокумента]
					,_Fld12892 [НастройкиПомощникаПланирования]
					,_Fld12893RRef [ТипЦен]
					,_Fld12894 [СуммаВключаетНДС]
					,_Fld12895 [УчитыватьНДС]
					,_Fld12896RRef [ПериодичностьДетализации]
					From _Document512(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПроизводства();
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
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(16))[0]==1;
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
		
		public static ДокументыСсылка.ПланПроизводства НайтиПоНомеру(string Номер)
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
					,_Fld12882RRef [ВалютаДокумента]
					,_Fld12883 [ДатаПланирования]
					,_Fld12884 [Комментарий]
					,_Fld12885 [КратностьДокумента]
					,_Fld12886 [КурсДокумента]
					,_Fld12887RRef [Ответственный]
					,_Fld12888RRef [Подразделение]
					,_Fld12889RRef [Проект]
					,_Fld12890RRef [Сценарий]
					,_Fld12891 [СуммаДокумента]
					,_Fld12892 [НастройкиПомощникаПланирования]
					,_Fld12893RRef [ТипЦен]
					,_Fld12894 [СуммаВключаетНДС]
					,_Fld12895 [УчитыватьНДС]
					,_Fld12896RRef [ПериодичностьДетализации]
					From _Document512(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПроизводства();
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
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(16))[0]==1;
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
		
		public static ДокументыВыборка.ПланПроизводства Выбрать()
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
					,_Fld12882RRef [ВалютаДокумента]
					,_Fld12883 [ДатаПланирования]
					,_Fld12884 [Комментарий]
					,_Fld12885 [КратностьДокумента]
					,_Fld12886 [КурсДокумента]
					,_Fld12887RRef [Ответственный]
					,_Fld12888RRef [Подразделение]
					,_Fld12889RRef [Проект]
					,_Fld12890RRef [Сценарий]
					,_Fld12891 [СуммаДокумента]
					,_Fld12892 [НастройкиПомощникаПланирования]
					,_Fld12893RRef [ТипЦен]
					,_Fld12894 [СуммаВключаетНДС]
					,_Fld12895 [УчитыватьНДС]
					,_Fld12896RRef [ПериодичностьДетализации]
					From _Document512(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПланПроизводства();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПроизводства();
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
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПланПроизводства ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld12882RRef [ВалютаДокумента]
					,_Fld12883 [ДатаПланирования]
					,_Fld12884 [Комментарий]
					,_Fld12885 [КратностьДокумента]
					,_Fld12886 [КурсДокумента]
					,_Fld12887RRef [Ответственный]
					,_Fld12888RRef [Подразделение]
					,_Fld12889RRef [Проект]
					,_Fld12890RRef [Сценарий]
					,_Fld12891 [СуммаДокумента]
					,_Fld12892 [НастройкиПомощникаПланирования]
					,_Fld12893RRef [ТипЦен]
					,_Fld12894 [СуммаВключаетНДС]
					,_Fld12895 [УчитыватьНДС]
					,_Fld12896RRef [ПериодичностьДетализации]
					From _Document512(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ПланПроизводства();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПроизводства();
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
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПланПроизводства ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld12882RRef [ВалютаДокумента]
					,_Fld12883 [ДатаПланирования]
					,_Fld12884 [Комментарий]
					,_Fld12885 [КратностьДокумента]
					,_Fld12886 [КурсДокумента]
					,_Fld12887RRef [Ответственный]
					,_Fld12888RRef [Подразделение]
					,_Fld12889RRef [Проект]
					,_Fld12890RRef [Сценарий]
					,_Fld12891 [СуммаДокумента]
					,_Fld12892 [НастройкиПомощникаПланирования]
					,_Fld12893RRef [ТипЦен]
					,_Fld12894 [СуммаВключаетНДС]
					,_Fld12895 [УчитыватьНДС]
					,_Fld12896RRef [ПериодичностьДетализации]
					From _Document512(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ПланПроизводства();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПроизводства();
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
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПланПроизводства СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld12882RRef [ВалютаДокумента]
					,_Fld12883 [ДатаПланирования]
					,_Fld12884 [Комментарий]
					,_Fld12885 [КратностьДокумента]
					,_Fld12886 [КурсДокумента]
					,_Fld12887RRef [Ответственный]
					,_Fld12888RRef [Подразделение]
					,_Fld12889RRef [Проект]
					,_Fld12890RRef [Сценарий]
					,_Fld12891 [СуммаДокумента]
					,_Fld12892 [НастройкиПомощникаПланирования]
					,_Fld12893RRef [ТипЦен]
					,_Fld12894 [СуммаВключаетНДС]
					,_Fld12895 [УчитыватьНДС]
					,_Fld12896RRef [ПериодичностьДетализации]
					From _Document512(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПланПроизводства();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПроизводства();
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
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПланПроизводства СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld12882RRef [ВалютаДокумента]
					,_Fld12883 [ДатаПланирования]
					,_Fld12884 [Комментарий]
					,_Fld12885 [КратностьДокумента]
					,_Fld12886 [КурсДокумента]
					,_Fld12887RRef [Ответственный]
					,_Fld12888RRef [Подразделение]
					,_Fld12889RRef [Проект]
					,_Fld12890RRef [Сценарий]
					,_Fld12891 [СуммаДокумента]
					,_Fld12892 [НастройкиПомощникаПланирования]
					,_Fld12893RRef [ТипЦен]
					,_Fld12894 [СуммаВключаетНДС]
					,_Fld12895 [УчитыватьНДС]
					,_Fld12896RRef [ПериодичностьДетализации]
					From _Document512(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПланПроизводства();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПланПроизводства();
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
							Ссылка.СуммаВключаетНДС = ((byte[])Читалка.GetValue(15))[0]==1;
							Ссылка.УчитыватьНДС = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(17));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ПланПроизводства СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ПланПроизводства();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ПериодичностьДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			return Объект;
		}
	}
}