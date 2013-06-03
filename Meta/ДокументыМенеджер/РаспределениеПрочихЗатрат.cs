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
	public partial class РаспределениеПрочихЗатрат:ДокументМенеджер
	{
		
		public static ДокументыСсылка.РаспределениеПрочихЗатрат НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld15162RRef [Подразделение]
					,_Fld15163_TYPE [Заказ_Тип],_Fld15163_RRRef [Заказ],_Fld15163_RTRef [Заказ_Вид]
					,_Fld15164RRef [Организация]
					,_Fld15165 [Комментарий]
					,_Fld15166RRef [Ответственный]
					,_Fld15167 [ОтражатьВУправленческомУчете]
					,_Fld15168 [ОтражатьВБухгалтерскомУчете]
					,_Fld15169 [ОтражатьВНалоговомУчете]
					,_Fld15170 [ДатаНачалаПериода]
					,_Fld15171 [ДатаОкончанияПериода]
					,_Fld15172RRef [ПодразделениеОрганизации]
					,_Fld15173RRef [ДокументИнвентаризация]
					,_Fld15174 [ИспользоватьПодразделенияНЗП]
					,_Fld15175 [ИспользоватьНаработку]
					From _Document548(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РаспределениеПрочихЗатрат();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(13);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(14);
							Ссылка.ДокументИнвентаризация = V82.ДокументыСсылка.ИнвентаризацияНЗП.ВзятьИзКэша((byte[])Читалка.GetValue(16));
							Ссылка.ИспользоватьПодразделенияНЗП = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ИспользоватьНаработку = ((byte[])Читалка.GetValue(18))[0]==1;
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
		
		public static ДокументыСсылка.РаспределениеПрочихЗатрат НайтиПоНомеру(string Номер)
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
					,_Fld15162RRef [Подразделение]
					,_Fld15163_TYPE [Заказ_Тип],_Fld15163_RRRef [Заказ],_Fld15163_RTRef [Заказ_Вид]
					,_Fld15164RRef [Организация]
					,_Fld15165 [Комментарий]
					,_Fld15166RRef [Ответственный]
					,_Fld15167 [ОтражатьВУправленческомУчете]
					,_Fld15168 [ОтражатьВБухгалтерскомУчете]
					,_Fld15169 [ОтражатьВНалоговомУчете]
					,_Fld15170 [ДатаНачалаПериода]
					,_Fld15171 [ДатаОкончанияПериода]
					,_Fld15172RRef [ПодразделениеОрганизации]
					,_Fld15173RRef [ДокументИнвентаризация]
					,_Fld15174 [ИспользоватьПодразделенияНЗП]
					,_Fld15175 [ИспользоватьНаработку]
					From _Document548(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РаспределениеПрочихЗатрат();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(13);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(14);
							Ссылка.ДокументИнвентаризация = V82.ДокументыСсылка.ИнвентаризацияНЗП.ВзятьИзКэша((byte[])Читалка.GetValue(16));
							Ссылка.ИспользоватьПодразделенияНЗП = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ИспользоватьНаработку = ((byte[])Читалка.GetValue(18))[0]==1;
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
		
		public static ДокументыВыборка.РаспределениеПрочихЗатрат Выбрать()
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
					,_Fld15162RRef [Подразделение]
					,_Fld15163_TYPE [Заказ_Тип],_Fld15163_RRRef [Заказ],_Fld15163_RTRef [Заказ_Вид]
					,_Fld15164RRef [Организация]
					,_Fld15165 [Комментарий]
					,_Fld15166RRef [Ответственный]
					,_Fld15167 [ОтражатьВУправленческомУчете]
					,_Fld15168 [ОтражатьВБухгалтерскомУчете]
					,_Fld15169 [ОтражатьВНалоговомУчете]
					,_Fld15170 [ДатаНачалаПериода]
					,_Fld15171 [ДатаОкончанияПериода]
					,_Fld15172RRef [ПодразделениеОрганизации]
					,_Fld15173RRef [ДокументИнвентаризация]
					,_Fld15174 [ИспользоватьПодразделенияНЗП]
					,_Fld15175 [ИспользоватьНаработку]
					From _Document548(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.РаспределениеПрочихЗатрат();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РаспределениеПрочихЗатрат();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(13);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(14);
							Ссылка.ДокументИнвентаризация = V82.ДокументыСсылка.ИнвентаризацияНЗП.ВзятьИзКэша((byte[])Читалка.GetValue(16));
							Ссылка.ИспользоватьПодразделенияНЗП = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ИспользоватьНаработку = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РаспределениеПрочихЗатрат ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld15162RRef [Подразделение]
					,_Fld15163_TYPE [Заказ_Тип],_Fld15163_RRRef [Заказ],_Fld15163_RTRef [Заказ_Вид]
					,_Fld15164RRef [Организация]
					,_Fld15165 [Комментарий]
					,_Fld15166RRef [Ответственный]
					,_Fld15167 [ОтражатьВУправленческомУчете]
					,_Fld15168 [ОтражатьВБухгалтерскомУчете]
					,_Fld15169 [ОтражатьВНалоговомУчете]
					,_Fld15170 [ДатаНачалаПериода]
					,_Fld15171 [ДатаОкончанияПериода]
					,_Fld15172RRef [ПодразделениеОрганизации]
					,_Fld15173RRef [ДокументИнвентаризация]
					,_Fld15174 [ИспользоватьПодразделенияНЗП]
					,_Fld15175 [ИспользоватьНаработку]
					From _Document548(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.РаспределениеПрочихЗатрат();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РаспределениеПрочихЗатрат();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(13);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(14);
							Ссылка.ДокументИнвентаризация = V82.ДокументыСсылка.ИнвентаризацияНЗП.ВзятьИзКэша((byte[])Читалка.GetValue(16));
							Ссылка.ИспользоватьПодразделенияНЗП = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ИспользоватьНаработку = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РаспределениеПрочихЗатрат ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld15162RRef [Подразделение]
					,_Fld15163_TYPE [Заказ_Тип],_Fld15163_RRRef [Заказ],_Fld15163_RTRef [Заказ_Вид]
					,_Fld15164RRef [Организация]
					,_Fld15165 [Комментарий]
					,_Fld15166RRef [Ответственный]
					,_Fld15167 [ОтражатьВУправленческомУчете]
					,_Fld15168 [ОтражатьВБухгалтерскомУчете]
					,_Fld15169 [ОтражатьВНалоговомУчете]
					,_Fld15170 [ДатаНачалаПериода]
					,_Fld15171 [ДатаОкончанияПериода]
					,_Fld15172RRef [ПодразделениеОрганизации]
					,_Fld15173RRef [ДокументИнвентаризация]
					,_Fld15174 [ИспользоватьПодразделенияНЗП]
					,_Fld15175 [ИспользоватьНаработку]
					From _Document548(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.РаспределениеПрочихЗатрат();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РаспределениеПрочихЗатрат();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(13);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(14);
							Ссылка.ДокументИнвентаризация = V82.ДокументыСсылка.ИнвентаризацияНЗП.ВзятьИзКэша((byte[])Читалка.GetValue(16));
							Ссылка.ИспользоватьПодразделенияНЗП = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ИспользоватьНаработку = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РаспределениеПрочихЗатрат СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld15162RRef [Подразделение]
					,_Fld15163_TYPE [Заказ_Тип],_Fld15163_RRRef [Заказ],_Fld15163_RTRef [Заказ_Вид]
					,_Fld15164RRef [Организация]
					,_Fld15165 [Комментарий]
					,_Fld15166RRef [Ответственный]
					,_Fld15167 [ОтражатьВУправленческомУчете]
					,_Fld15168 [ОтражатьВБухгалтерскомУчете]
					,_Fld15169 [ОтражатьВНалоговомУчете]
					,_Fld15170 [ДатаНачалаПериода]
					,_Fld15171 [ДатаОкончанияПериода]
					,_Fld15172RRef [ПодразделениеОрганизации]
					,_Fld15173RRef [ДокументИнвентаризация]
					,_Fld15174 [ИспользоватьПодразделенияНЗП]
					,_Fld15175 [ИспользоватьНаработку]
					From _Document548(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.РаспределениеПрочихЗатрат();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РаспределениеПрочихЗатрат();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(13);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(14);
							Ссылка.ДокументИнвентаризация = V82.ДокументыСсылка.ИнвентаризацияНЗП.ВзятьИзКэша((byte[])Читалка.GetValue(16));
							Ссылка.ИспользоватьПодразделенияНЗП = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ИспользоватьНаработку = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РаспределениеПрочихЗатрат СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld15162RRef [Подразделение]
					,_Fld15163_TYPE [Заказ_Тип],_Fld15163_RRRef [Заказ],_Fld15163_RTRef [Заказ_Вид]
					,_Fld15164RRef [Организация]
					,_Fld15165 [Комментарий]
					,_Fld15166RRef [Ответственный]
					,_Fld15167 [ОтражатьВУправленческомУчете]
					,_Fld15168 [ОтражатьВБухгалтерскомУчете]
					,_Fld15169 [ОтражатьВНалоговомУчете]
					,_Fld15170 [ДатаНачалаПериода]
					,_Fld15171 [ДатаОкончанияПериода]
					,_Fld15172RRef [ПодразделениеОрганизации]
					,_Fld15173RRef [ДокументИнвентаризация]
					,_Fld15174 [ИспользоватьПодразделенияНЗП]
					,_Fld15175 [ИспользоватьНаработку]
					From _Document548(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.РаспределениеПрочихЗатрат();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РаспределениеПрочихЗатрат();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(11))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(13);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(14);
							Ссылка.ДокументИнвентаризация = V82.ДокументыСсылка.ИнвентаризацияНЗП.ВзятьИзКэша((byte[])Читалка.GetValue(16));
							Ссылка.ИспользоватьПодразделенияНЗП = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ИспользоватьНаработку = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.РаспределениеПрочихЗатрат СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.РаспределениеПрочихЗатрат();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ДокументИнвентаризация = new V82.ДокументыСсылка.ИнвентаризацияНЗП();
			return Объект;
		}
	}
}