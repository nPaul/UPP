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
	public partial class ЗаявлениеВФССОВозмещенииРасходовНаПогребение:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld7679RRef [Организация]
					,_Fld7680RRef [Ответственный]
					,_Fld7681 [Комментарий]
					,_Fld7682 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld7683 [РегистрационныйНомерФСС]
					,_Fld7684 [ДополнительныйКодФСС]
					,_Fld7685 [КодПодчиненностиФСС]
					,_Fld7686 [АдресОрганизации]
					,_Fld7687RRef [Руководитель]
					,_Fld7688RRef [ДолжностьРуководителя]
					,_Fld7689 [КраткийСоставДокумента]
					,_Fld7690 [КоличествоСтраниц]
					,_Fld7691 [ТелефонСоставителя]
					,_Fld7692RRef [Банк]
					,_Fld7693 [НаименованиеБанка]
					,_Fld7694 [НомерЛицевогоСчета]
					,_Fld7695 [НомерСчета]
					,_Fld7696 [БИКБанка]
					,_Fld7697 [КоррСчетБанка]
					From _Document384(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.НаименованиеТерриториальногоОрганаФСС = Читалка.GetString(6);
							Ссылка.РегистрационныйНомерФСС = Читалка.GetString(7);
							Ссылка.ДополнительныйКодФСС = Читалка.GetString(8);
							Ссылка.КодПодчиненностиФСС = Читалка.GetString(9);
							Ссылка.АдресОрганизации = Читалка.GetString(10);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(13);
							Ссылка.КоличествоСтраниц = Читалка.GetDecimal(14);
							Ссылка.ТелефонСоставителя = Читалка.GetString(15);
							Ссылка.НаименованиеБанка = Читалка.GetString(17);
							Ссылка.НомерЛицевогоСчета = Читалка.GetString(18);
							Ссылка.НомерСчета = Читалка.GetString(19);
							Ссылка.БИКБанка = Читалка.GetString(20);
							Ссылка.КоррСчетБанка = Читалка.GetString(21);
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
		
		public static ДокументыСсылка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение НайтиПоНомеру(string Номер)
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
					,_Fld7679RRef [Организация]
					,_Fld7680RRef [Ответственный]
					,_Fld7681 [Комментарий]
					,_Fld7682 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld7683 [РегистрационныйНомерФСС]
					,_Fld7684 [ДополнительныйКодФСС]
					,_Fld7685 [КодПодчиненностиФСС]
					,_Fld7686 [АдресОрганизации]
					,_Fld7687RRef [Руководитель]
					,_Fld7688RRef [ДолжностьРуководителя]
					,_Fld7689 [КраткийСоставДокумента]
					,_Fld7690 [КоличествоСтраниц]
					,_Fld7691 [ТелефонСоставителя]
					,_Fld7692RRef [Банк]
					,_Fld7693 [НаименованиеБанка]
					,_Fld7694 [НомерЛицевогоСчета]
					,_Fld7695 [НомерСчета]
					,_Fld7696 [БИКБанка]
					,_Fld7697 [КоррСчетБанка]
					From _Document384(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.НаименованиеТерриториальногоОрганаФСС = Читалка.GetString(6);
							Ссылка.РегистрационныйНомерФСС = Читалка.GetString(7);
							Ссылка.ДополнительныйКодФСС = Читалка.GetString(8);
							Ссылка.КодПодчиненностиФСС = Читалка.GetString(9);
							Ссылка.АдресОрганизации = Читалка.GetString(10);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(13);
							Ссылка.КоличествоСтраниц = Читалка.GetDecimal(14);
							Ссылка.ТелефонСоставителя = Читалка.GetString(15);
							Ссылка.НаименованиеБанка = Читалка.GetString(17);
							Ссылка.НомерЛицевогоСчета = Читалка.GetString(18);
							Ссылка.НомерСчета = Читалка.GetString(19);
							Ссылка.БИКБанка = Читалка.GetString(20);
							Ссылка.КоррСчетБанка = Читалка.GetString(21);
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
		
		public static ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение Выбрать()
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
					,_Fld7679RRef [Организация]
					,_Fld7680RRef [Ответственный]
					,_Fld7681 [Комментарий]
					,_Fld7682 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld7683 [РегистрационныйНомерФСС]
					,_Fld7684 [ДополнительныйКодФСС]
					,_Fld7685 [КодПодчиненностиФСС]
					,_Fld7686 [АдресОрганизации]
					,_Fld7687RRef [Руководитель]
					,_Fld7688RRef [ДолжностьРуководителя]
					,_Fld7689 [КраткийСоставДокумента]
					,_Fld7690 [КоличествоСтраниц]
					,_Fld7691 [ТелефонСоставителя]
					,_Fld7692RRef [Банк]
					,_Fld7693 [НаименованиеБанка]
					,_Fld7694 [НомерЛицевогоСчета]
					,_Fld7695 [НомерСчета]
					,_Fld7696 [БИКБанка]
					,_Fld7697 [КоррСчетБанка]
					From _Document384(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.НаименованиеТерриториальногоОрганаФСС = Читалка.GetString(6);
							Ссылка.РегистрационныйНомерФСС = Читалка.GetString(7);
							Ссылка.ДополнительныйКодФСС = Читалка.GetString(8);
							Ссылка.КодПодчиненностиФСС = Читалка.GetString(9);
							Ссылка.АдресОрганизации = Читалка.GetString(10);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(13);
							Ссылка.КоличествоСтраниц = Читалка.GetDecimal(14);
							Ссылка.ТелефонСоставителя = Читалка.GetString(15);
							Ссылка.НаименованиеБанка = Читалка.GetString(17);
							Ссылка.НомерЛицевогоСчета = Читалка.GetString(18);
							Ссылка.НомерСчета = Читалка.GetString(19);
							Ссылка.БИКБанка = Читалка.GetString(20);
							Ссылка.КоррСчетБанка = Читалка.GetString(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld7679RRef [Организация]
					,_Fld7680RRef [Ответственный]
					,_Fld7681 [Комментарий]
					,_Fld7682 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld7683 [РегистрационныйНомерФСС]
					,_Fld7684 [ДополнительныйКодФСС]
					,_Fld7685 [КодПодчиненностиФСС]
					,_Fld7686 [АдресОрганизации]
					,_Fld7687RRef [Руководитель]
					,_Fld7688RRef [ДолжностьРуководителя]
					,_Fld7689 [КраткийСоставДокумента]
					,_Fld7690 [КоличествоСтраниц]
					,_Fld7691 [ТелефонСоставителя]
					,_Fld7692RRef [Банк]
					,_Fld7693 [НаименованиеБанка]
					,_Fld7694 [НомерЛицевогоСчета]
					,_Fld7695 [НомерСчета]
					,_Fld7696 [БИКБанка]
					,_Fld7697 [КоррСчетБанка]
					From _Document384(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.НаименованиеТерриториальногоОрганаФСС = Читалка.GetString(6);
							Ссылка.РегистрационныйНомерФСС = Читалка.GetString(7);
							Ссылка.ДополнительныйКодФСС = Читалка.GetString(8);
							Ссылка.КодПодчиненностиФСС = Читалка.GetString(9);
							Ссылка.АдресОрганизации = Читалка.GetString(10);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(13);
							Ссылка.КоличествоСтраниц = Читалка.GetDecimal(14);
							Ссылка.ТелефонСоставителя = Читалка.GetString(15);
							Ссылка.НаименованиеБанка = Читалка.GetString(17);
							Ссылка.НомерЛицевогоСчета = Читалка.GetString(18);
							Ссылка.НомерСчета = Читалка.GetString(19);
							Ссылка.БИКБанка = Читалка.GetString(20);
							Ссылка.КоррСчетБанка = Читалка.GetString(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld7679RRef [Организация]
					,_Fld7680RRef [Ответственный]
					,_Fld7681 [Комментарий]
					,_Fld7682 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld7683 [РегистрационныйНомерФСС]
					,_Fld7684 [ДополнительныйКодФСС]
					,_Fld7685 [КодПодчиненностиФСС]
					,_Fld7686 [АдресОрганизации]
					,_Fld7687RRef [Руководитель]
					,_Fld7688RRef [ДолжностьРуководителя]
					,_Fld7689 [КраткийСоставДокумента]
					,_Fld7690 [КоличествоСтраниц]
					,_Fld7691 [ТелефонСоставителя]
					,_Fld7692RRef [Банк]
					,_Fld7693 [НаименованиеБанка]
					,_Fld7694 [НомерЛицевогоСчета]
					,_Fld7695 [НомерСчета]
					,_Fld7696 [БИКБанка]
					,_Fld7697 [КоррСчетБанка]
					From _Document384(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.НаименованиеТерриториальногоОрганаФСС = Читалка.GetString(6);
							Ссылка.РегистрационныйНомерФСС = Читалка.GetString(7);
							Ссылка.ДополнительныйКодФСС = Читалка.GetString(8);
							Ссылка.КодПодчиненностиФСС = Читалка.GetString(9);
							Ссылка.АдресОрганизации = Читалка.GetString(10);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(13);
							Ссылка.КоличествоСтраниц = Читалка.GetDecimal(14);
							Ссылка.ТелефонСоставителя = Читалка.GetString(15);
							Ссылка.НаименованиеБанка = Читалка.GetString(17);
							Ссылка.НомерЛицевогоСчета = Читалка.GetString(18);
							Ссылка.НомерСчета = Читалка.GetString(19);
							Ссылка.БИКБанка = Читалка.GetString(20);
							Ссылка.КоррСчетБанка = Читалка.GetString(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld7679RRef [Организация]
					,_Fld7680RRef [Ответственный]
					,_Fld7681 [Комментарий]
					,_Fld7682 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld7683 [РегистрационныйНомерФСС]
					,_Fld7684 [ДополнительныйКодФСС]
					,_Fld7685 [КодПодчиненностиФСС]
					,_Fld7686 [АдресОрганизации]
					,_Fld7687RRef [Руководитель]
					,_Fld7688RRef [ДолжностьРуководителя]
					,_Fld7689 [КраткийСоставДокумента]
					,_Fld7690 [КоличествоСтраниц]
					,_Fld7691 [ТелефонСоставителя]
					,_Fld7692RRef [Банк]
					,_Fld7693 [НаименованиеБанка]
					,_Fld7694 [НомерЛицевогоСчета]
					,_Fld7695 [НомерСчета]
					,_Fld7696 [БИКБанка]
					,_Fld7697 [КоррСчетБанка]
					From _Document384(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.НаименованиеТерриториальногоОрганаФСС = Читалка.GetString(6);
							Ссылка.РегистрационныйНомерФСС = Читалка.GetString(7);
							Ссылка.ДополнительныйКодФСС = Читалка.GetString(8);
							Ссылка.КодПодчиненностиФСС = Читалка.GetString(9);
							Ссылка.АдресОрганизации = Читалка.GetString(10);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(13);
							Ссылка.КоличествоСтраниц = Читалка.GetDecimal(14);
							Ссылка.ТелефонСоставителя = Читалка.GetString(15);
							Ссылка.НаименованиеБанка = Читалка.GetString(17);
							Ссылка.НомерЛицевогоСчета = Читалка.GetString(18);
							Ссылка.НомерСчета = Читалка.GetString(19);
							Ссылка.БИКБанка = Читалка.GetString(20);
							Ссылка.КоррСчетБанка = Читалка.GetString(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld7679RRef [Организация]
					,_Fld7680RRef [Ответственный]
					,_Fld7681 [Комментарий]
					,_Fld7682 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld7683 [РегистрационныйНомерФСС]
					,_Fld7684 [ДополнительныйКодФСС]
					,_Fld7685 [КодПодчиненностиФСС]
					,_Fld7686 [АдресОрганизации]
					,_Fld7687RRef [Руководитель]
					,_Fld7688RRef [ДолжностьРуководителя]
					,_Fld7689 [КраткийСоставДокумента]
					,_Fld7690 [КоличествоСтраниц]
					,_Fld7691 [ТелефонСоставителя]
					,_Fld7692RRef [Банк]
					,_Fld7693 [НаименованиеБанка]
					,_Fld7694 [НомерЛицевогоСчета]
					,_Fld7695 [НомерСчета]
					,_Fld7696 [БИКБанка]
					,_Fld7697 [КоррСчетБанка]
					From _Document384(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.НаименованиеТерриториальногоОрганаФСС = Читалка.GetString(6);
							Ссылка.РегистрационныйНомерФСС = Читалка.GetString(7);
							Ссылка.ДополнительныйКодФСС = Читалка.GetString(8);
							Ссылка.КодПодчиненностиФСС = Читалка.GetString(9);
							Ссылка.АдресОрганизации = Читалка.GetString(10);
							Ссылка.КраткийСоставДокумента = Читалка.GetString(13);
							Ссылка.КоличествоСтраниц = Читалка.GetDecimal(14);
							Ссылка.ТелефонСоставителя = Читалка.GetString(15);
							Ссылка.НаименованиеБанка = Читалка.GetString(17);
							Ссылка.НомерЛицевогоСчета = Читалка.GetString(18);
							Ссылка.НомерСчета = Читалка.GetString(19);
							Ссылка.БИКБанка = Читалка.GetString(20);
							Ссылка.КоррСчетБанка = Читалка.GetString(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ЗаявлениеВФССОВозмещенииРасходовНаПогребение СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ЗаявлениеВФССОВозмещенииРасходовНаПогребение();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.НаименованиеТерриториальногоОрганаФСС = "";
			Объект.РегистрационныйНомерФСС = "";
			Объект.ДополнительныйКодФСС = "";
			Объект.КодПодчиненностиФСС = "";
			Объект.АдресОрганизации = "";
			Объект.КраткийСоставДокумента = "";
			Объект.ТелефонСоставителя = "";
			Объект.НаименованиеБанка = "";
			Объект.НомерЛицевогоСчета = "";
			Объект.НомерСчета = "";
			Объект.БИКБанка = "";
			Объект.КоррСчетБанка = "";
			return Объект;
		}
	}
}