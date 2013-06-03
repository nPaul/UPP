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
	public partial class ДепонированиеОрганизаций:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ДепонированиеОрганизаций НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld6781RRef [Организация]
					,_Fld6782 [Комментарий]
					,_Fld6783RRef [Ответственный]
					,_Fld6784 [СуммаДокумента]
					,_Fld6785RRef [СчетУчетаРасходов]
					,_Fld6786RRef [Субконто1]
					,_Fld6787RRef [Субконто2]
					,_Fld6788RRef [Субконто3]
					,_Fld6789 [КраткийСоставДокумента]
					,_Fld6790 [ОтражатьВНалоговомУчете]
					From _Document354(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДепонированиеОрганизаций();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(11);
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
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
		
		public static ДокументыСсылка.ДепонированиеОрганизаций НайтиПоНомеру(string Номер)
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
					,_Fld6781RRef [Организация]
					,_Fld6782 [Комментарий]
					,_Fld6783RRef [Ответственный]
					,_Fld6784 [СуммаДокумента]
					,_Fld6785RRef [СчетУчетаРасходов]
					,_Fld6786RRef [Субконто1]
					,_Fld6787RRef [Субконто2]
					,_Fld6788RRef [Субконто3]
					,_Fld6789 [КраткийСоставДокумента]
					,_Fld6790 [ОтражатьВНалоговомУчете]
					From _Document354(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДепонированиеОрганизаций();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(11);
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
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
		
		public static ДокументыВыборка.ДепонированиеОрганизаций Выбрать()
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
					,_Fld6781RRef [Организация]
					,_Fld6782 [Комментарий]
					,_Fld6783RRef [Ответственный]
					,_Fld6784 [СуммаДокумента]
					,_Fld6785RRef [СчетУчетаРасходов]
					,_Fld6786RRef [Субконто1]
					,_Fld6787RRef [Субконто2]
					,_Fld6788RRef [Субконто3]
					,_Fld6789 [КраткийСоставДокумента]
					,_Fld6790 [ОтражатьВНалоговомУчете]
					From _Document354(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ДепонированиеОрганизаций();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДепонированиеОрганизаций();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(11);
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДепонированиеОрганизаций ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld6781RRef [Организация]
					,_Fld6782 [Комментарий]
					,_Fld6783RRef [Ответственный]
					,_Fld6784 [СуммаДокумента]
					,_Fld6785RRef [СчетУчетаРасходов]
					,_Fld6786RRef [Субконто1]
					,_Fld6787RRef [Субконто2]
					,_Fld6788RRef [Субконто3]
					,_Fld6789 [КраткийСоставДокумента]
					,_Fld6790 [ОтражатьВНалоговомУчете]
					From _Document354(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ДепонированиеОрганизаций();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДепонированиеОрганизаций();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(11);
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДепонированиеОрганизаций ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld6781RRef [Организация]
					,_Fld6782 [Комментарий]
					,_Fld6783RRef [Ответственный]
					,_Fld6784 [СуммаДокумента]
					,_Fld6785RRef [СчетУчетаРасходов]
					,_Fld6786RRef [Субконто1]
					,_Fld6787RRef [Субконто2]
					,_Fld6788RRef [Субконто3]
					,_Fld6789 [КраткийСоставДокумента]
					,_Fld6790 [ОтражатьВНалоговомУчете]
					From _Document354(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ДепонированиеОрганизаций();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДепонированиеОрганизаций();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(11);
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДепонированиеОрганизаций СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld6781RRef [Организация]
					,_Fld6782 [Комментарий]
					,_Fld6783RRef [Ответственный]
					,_Fld6784 [СуммаДокумента]
					,_Fld6785RRef [СчетУчетаРасходов]
					,_Fld6786RRef [Субконто1]
					,_Fld6787RRef [Субконто2]
					,_Fld6788RRef [Субконто3]
					,_Fld6789 [КраткийСоставДокумента]
					,_Fld6790 [ОтражатьВНалоговомУчете]
					From _Document354(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ДепонированиеОрганизаций();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДепонированиеОрганизаций();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(11);
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДепонированиеОрганизаций СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld6781RRef [Организация]
					,_Fld6782 [Комментарий]
					,_Fld6783RRef [Ответственный]
					,_Fld6784 [СуммаДокумента]
					,_Fld6785RRef [СчетУчетаРасходов]
					,_Fld6786RRef [Субконто1]
					,_Fld6787RRef [Субконто2]
					,_Fld6788RRef [Субконто3]
					,_Fld6789 [КраткийСоставДокумента]
					,_Fld6790 [ОтражатьВНалоговомУчете]
					From _Document354(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ДепонированиеОрганизаций();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДепонированиеОрганизаций();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(4);
							Ссылка.СуммаДокумента = Читалка.GetDecimal(6);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(11);
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ДепонированиеОрганизаций СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ДепонированиеОрганизаций();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.КраткийСоставДокумента = "";
			return Объект;
		}
	}
}