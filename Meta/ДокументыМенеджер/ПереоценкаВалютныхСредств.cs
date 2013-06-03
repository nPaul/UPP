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
	public partial class ПереоценкаВалютныхСредств:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ПереоценкаВалютныхСредств НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld12592 [ОтражатьВУправленческомУчете]
					,_Fld12593 [ОтражатьВБухгалтерскомУчете]
					,_Fld12594 [ОтражатьВНалоговомУчете]
					,_Fld12595RRef [Организация]
					,_Fld12596 [ВзаиморасчетыСКонтрагентами]
					,_Fld12597 [ВзаиморасчетыСПодотчетнымиЛицами]
					,_Fld12598 [ДенежныеСредстваВКассах]
					,_Fld12599 [ДенежныеСредстваНаБанковскихСчетах]
					,_Fld12600 [Комментарий]
					,_Fld12601RRef [Ответственный]
					,_Fld12602RRef [Подразделение]
					,_Fld12603 [ПереоценкаВалютныхСредствРегл]
					,_Fld12604 [ПереоценкаРасчетовВУсловныхЕдиницахРегл]
					From _Document499(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПереоценкаВалютныхСредств();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(4))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ВзаиморасчетыСКонтрагентами = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ВзаиморасчетыСПодотчетнымиЛицами = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ДенежныеСредстваВКассах = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ДенежныеСредстваНаБанковскихСчетах = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.ПереоценкаВалютныхСредствРегл = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ПереоценкаРасчетовВУсловныхЕдиницахРегл = ((byte[])Читалка.GetValue(15))[0]==1;
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
		
		public static ДокументыСсылка.ПереоценкаВалютныхСредств НайтиПоНомеру(string Номер)
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
					,_Fld12592 [ОтражатьВУправленческомУчете]
					,_Fld12593 [ОтражатьВБухгалтерскомУчете]
					,_Fld12594 [ОтражатьВНалоговомУчете]
					,_Fld12595RRef [Организация]
					,_Fld12596 [ВзаиморасчетыСКонтрагентами]
					,_Fld12597 [ВзаиморасчетыСПодотчетнымиЛицами]
					,_Fld12598 [ДенежныеСредстваВКассах]
					,_Fld12599 [ДенежныеСредстваНаБанковскихСчетах]
					,_Fld12600 [Комментарий]
					,_Fld12601RRef [Ответственный]
					,_Fld12602RRef [Подразделение]
					,_Fld12603 [ПереоценкаВалютныхСредствРегл]
					,_Fld12604 [ПереоценкаРасчетовВУсловныхЕдиницахРегл]
					From _Document499(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПереоценкаВалютныхСредств();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(4))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ВзаиморасчетыСКонтрагентами = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ВзаиморасчетыСПодотчетнымиЛицами = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ДенежныеСредстваВКассах = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ДенежныеСредстваНаБанковскихСчетах = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.ПереоценкаВалютныхСредствРегл = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ПереоценкаРасчетовВУсловныхЕдиницахРегл = ((byte[])Читалка.GetValue(15))[0]==1;
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
		
		public static ДокументыВыборка.ПереоценкаВалютныхСредств Выбрать()
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
					,_Fld12592 [ОтражатьВУправленческомУчете]
					,_Fld12593 [ОтражатьВБухгалтерскомУчете]
					,_Fld12594 [ОтражатьВНалоговомУчете]
					,_Fld12595RRef [Организация]
					,_Fld12596 [ВзаиморасчетыСКонтрагентами]
					,_Fld12597 [ВзаиморасчетыСПодотчетнымиЛицами]
					,_Fld12598 [ДенежныеСредстваВКассах]
					,_Fld12599 [ДенежныеСредстваНаБанковскихСчетах]
					,_Fld12600 [Комментарий]
					,_Fld12601RRef [Ответственный]
					,_Fld12602RRef [Подразделение]
					,_Fld12603 [ПереоценкаВалютныхСредствРегл]
					,_Fld12604 [ПереоценкаРасчетовВУсловныхЕдиницахРегл]
					From _Document499(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПереоценкаВалютныхСредств();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПереоценкаВалютныхСредств();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(4))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ВзаиморасчетыСКонтрагентами = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ВзаиморасчетыСПодотчетнымиЛицами = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ДенежныеСредстваВКассах = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ДенежныеСредстваНаБанковскихСчетах = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.ПереоценкаВалютныхСредствРегл = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ПереоценкаРасчетовВУсловныхЕдиницахРегл = ((byte[])Читалка.GetValue(15))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПереоценкаВалютныхСредств ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld12592 [ОтражатьВУправленческомУчете]
					,_Fld12593 [ОтражатьВБухгалтерскомУчете]
					,_Fld12594 [ОтражатьВНалоговомУчете]
					,_Fld12595RRef [Организация]
					,_Fld12596 [ВзаиморасчетыСКонтрагентами]
					,_Fld12597 [ВзаиморасчетыСПодотчетнымиЛицами]
					,_Fld12598 [ДенежныеСредстваВКассах]
					,_Fld12599 [ДенежныеСредстваНаБанковскихСчетах]
					,_Fld12600 [Комментарий]
					,_Fld12601RRef [Ответственный]
					,_Fld12602RRef [Подразделение]
					,_Fld12603 [ПереоценкаВалютныхСредствРегл]
					,_Fld12604 [ПереоценкаРасчетовВУсловныхЕдиницахРегл]
					From _Document499(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ПереоценкаВалютныхСредств();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПереоценкаВалютныхСредств();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(4))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ВзаиморасчетыСКонтрагентами = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ВзаиморасчетыСПодотчетнымиЛицами = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ДенежныеСредстваВКассах = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ДенежныеСредстваНаБанковскихСчетах = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.ПереоценкаВалютныхСредствРегл = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ПереоценкаРасчетовВУсловныхЕдиницахРегл = ((byte[])Читалка.GetValue(15))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПереоценкаВалютныхСредств ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld12592 [ОтражатьВУправленческомУчете]
					,_Fld12593 [ОтражатьВБухгалтерскомУчете]
					,_Fld12594 [ОтражатьВНалоговомУчете]
					,_Fld12595RRef [Организация]
					,_Fld12596 [ВзаиморасчетыСКонтрагентами]
					,_Fld12597 [ВзаиморасчетыСПодотчетнымиЛицами]
					,_Fld12598 [ДенежныеСредстваВКассах]
					,_Fld12599 [ДенежныеСредстваНаБанковскихСчетах]
					,_Fld12600 [Комментарий]
					,_Fld12601RRef [Ответственный]
					,_Fld12602RRef [Подразделение]
					,_Fld12603 [ПереоценкаВалютныхСредствРегл]
					,_Fld12604 [ПереоценкаРасчетовВУсловныхЕдиницахРегл]
					From _Document499(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ПереоценкаВалютныхСредств();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПереоценкаВалютныхСредств();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(4))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ВзаиморасчетыСКонтрагентами = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ВзаиморасчетыСПодотчетнымиЛицами = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ДенежныеСредстваВКассах = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ДенежныеСредстваНаБанковскихСчетах = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.ПереоценкаВалютныхСредствРегл = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ПереоценкаРасчетовВУсловныхЕдиницахРегл = ((byte[])Читалка.GetValue(15))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПереоценкаВалютныхСредств СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld12592 [ОтражатьВУправленческомУчете]
					,_Fld12593 [ОтражатьВБухгалтерскомУчете]
					,_Fld12594 [ОтражатьВНалоговомУчете]
					,_Fld12595RRef [Организация]
					,_Fld12596 [ВзаиморасчетыСКонтрагентами]
					,_Fld12597 [ВзаиморасчетыСПодотчетнымиЛицами]
					,_Fld12598 [ДенежныеСредстваВКассах]
					,_Fld12599 [ДенежныеСредстваНаБанковскихСчетах]
					,_Fld12600 [Комментарий]
					,_Fld12601RRef [Ответственный]
					,_Fld12602RRef [Подразделение]
					,_Fld12603 [ПереоценкаВалютныхСредствРегл]
					,_Fld12604 [ПереоценкаРасчетовВУсловныхЕдиницахРегл]
					From _Document499(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПереоценкаВалютныхСредств();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПереоценкаВалютныхСредств();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(4))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ВзаиморасчетыСКонтрагентами = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ВзаиморасчетыСПодотчетнымиЛицами = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ДенежныеСредстваВКассах = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ДенежныеСредстваНаБанковскихСчетах = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.ПереоценкаВалютныхСредствРегл = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ПереоценкаРасчетовВУсловныхЕдиницахРегл = ((byte[])Читалка.GetValue(15))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ПереоценкаВалютныхСредств СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld12592 [ОтражатьВУправленческомУчете]
					,_Fld12593 [ОтражатьВБухгалтерскомУчете]
					,_Fld12594 [ОтражатьВНалоговомУчете]
					,_Fld12595RRef [Организация]
					,_Fld12596 [ВзаиморасчетыСКонтрагентами]
					,_Fld12597 [ВзаиморасчетыСПодотчетнымиЛицами]
					,_Fld12598 [ДенежныеСредстваВКассах]
					,_Fld12599 [ДенежныеСредстваНаБанковскихСчетах]
					,_Fld12600 [Комментарий]
					,_Fld12601RRef [Ответственный]
					,_Fld12602RRef [Подразделение]
					,_Fld12603 [ПереоценкаВалютныхСредствРегл]
					,_Fld12604 [ПереоценкаРасчетовВУсловныхЕдиницахРегл]
					From _Document499(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ПереоценкаВалютныхСредств();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ПереоценкаВалютныхСредств();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(4))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(5))[0]==1;
							Ссылка.ВзаиморасчетыСКонтрагентами = ((byte[])Читалка.GetValue(7))[0]==1;
							Ссылка.ВзаиморасчетыСПодотчетнымиЛицами = ((byte[])Читалка.GetValue(8))[0]==1;
							Ссылка.ДенежныеСредстваВКассах = ((byte[])Читалка.GetValue(9))[0]==1;
							Ссылка.ДенежныеСредстваНаБанковскихСчетах = ((byte[])Читалка.GetValue(10))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.ПереоценкаВалютныхСредствРегл = ((byte[])Читалка.GetValue(14))[0]==1;
							Ссылка.ПереоценкаРасчетовВУсловныхЕдиницахРегл = ((byte[])Читалка.GetValue(15))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ПереоценкаВалютныхСредств СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ПереоценкаВалютныхСредств();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			return Объект;
		}
	}
}