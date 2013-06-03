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
	public partial class РеестрСведенийВФССОЕжемесячныхПособияхПоУходу:ДокументМенеджер
	{
		
		public static ДокументыСсылка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld16297RRef [Организация]
					,_Fld16298RRef [Ответственный]
					,_Fld16299 [Комментарий]
					,_Fld16300 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld16301 [РегистрационныйНомерФСС]
					,_Fld16302 [ДополнительныйКодФСС]
					,_Fld16303 [КодПодчиненностиФСС]
					,_Fld16304RRef [Руководитель]
					,_Fld16305RRef [ДолжностьРуководителя]
					,_Fld16306 [КраткийСоставДокумента]
					,_Fld16307 [ИНН]
					,_Fld16308 [КПП]
					,_Fld16309 [ОГРН]
					,_Fld16310RRef [РеестрСоставил]
					,_Fld16311 [ТелефонСоставителя]
					,_Fld16312 [АдресЭлектроннойПочтыСоставителя]
					,_Fld16313RRef [ГлавныйБухгалтер]
					,_Fld16314 [ВыводитьПодписиВРеестрПособий]
					From _Document574(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
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
							Ссылка.КраткийСоставДокумента = Читалка.GetString(12);
							Ссылка.ИНН = Читалка.GetString(13);
							Ссылка.КПП = Читалка.GetString(14);
							Ссылка.ОГРН = Читалка.GetString(15);
							Ссылка.ТелефонСоставителя = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыСоставителя = Читалка.GetString(18);
							Ссылка.ВыводитьПодписиВРеестрПособий = ((byte[])Читалка.GetValue(20))[0]==1;
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
		
		public static ДокументыСсылка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу НайтиПоНомеру(string Номер)
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
					,_Fld16297RRef [Организация]
					,_Fld16298RRef [Ответственный]
					,_Fld16299 [Комментарий]
					,_Fld16300 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld16301 [РегистрационныйНомерФСС]
					,_Fld16302 [ДополнительныйКодФСС]
					,_Fld16303 [КодПодчиненностиФСС]
					,_Fld16304RRef [Руководитель]
					,_Fld16305RRef [ДолжностьРуководителя]
					,_Fld16306 [КраткийСоставДокумента]
					,_Fld16307 [ИНН]
					,_Fld16308 [КПП]
					,_Fld16309 [ОГРН]
					,_Fld16310RRef [РеестрСоставил]
					,_Fld16311 [ТелефонСоставителя]
					,_Fld16312 [АдресЭлектроннойПочтыСоставителя]
					,_Fld16313RRef [ГлавныйБухгалтер]
					,_Fld16314 [ВыводитьПодписиВРеестрПособий]
					From _Document574(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
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
							Ссылка.КраткийСоставДокумента = Читалка.GetString(12);
							Ссылка.ИНН = Читалка.GetString(13);
							Ссылка.КПП = Читалка.GetString(14);
							Ссылка.ОГРН = Читалка.GetString(15);
							Ссылка.ТелефонСоставителя = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыСоставителя = Читалка.GetString(18);
							Ссылка.ВыводитьПодписиВРеестрПособий = ((byte[])Читалка.GetValue(20))[0]==1;
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
		
		public static ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу Выбрать()
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
					,_Fld16297RRef [Организация]
					,_Fld16298RRef [Ответственный]
					,_Fld16299 [Комментарий]
					,_Fld16300 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld16301 [РегистрационныйНомерФСС]
					,_Fld16302 [ДополнительныйКодФСС]
					,_Fld16303 [КодПодчиненностиФСС]
					,_Fld16304RRef [Руководитель]
					,_Fld16305RRef [ДолжностьРуководителя]
					,_Fld16306 [КраткийСоставДокумента]
					,_Fld16307 [ИНН]
					,_Fld16308 [КПП]
					,_Fld16309 [ОГРН]
					,_Fld16310RRef [РеестрСоставил]
					,_Fld16311 [ТелефонСоставителя]
					,_Fld16312 [АдресЭлектроннойПочтыСоставителя]
					,_Fld16313RRef [ГлавныйБухгалтер]
					,_Fld16314 [ВыводитьПодписиВРеестрПособий]
					From _Document574(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
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
							Ссылка.КраткийСоставДокумента = Читалка.GetString(12);
							Ссылка.ИНН = Читалка.GetString(13);
							Ссылка.КПП = Читалка.GetString(14);
							Ссылка.ОГРН = Читалка.GetString(15);
							Ссылка.ТелефонСоставителя = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыСоставителя = Читалка.GetString(18);
							Ссылка.ВыводитьПодписиВРеестрПособий = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld16297RRef [Организация]
					,_Fld16298RRef [Ответственный]
					,_Fld16299 [Комментарий]
					,_Fld16300 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld16301 [РегистрационныйНомерФСС]
					,_Fld16302 [ДополнительныйКодФСС]
					,_Fld16303 [КодПодчиненностиФСС]
					,_Fld16304RRef [Руководитель]
					,_Fld16305RRef [ДолжностьРуководителя]
					,_Fld16306 [КраткийСоставДокумента]
					,_Fld16307 [ИНН]
					,_Fld16308 [КПП]
					,_Fld16309 [ОГРН]
					,_Fld16310RRef [РеестрСоставил]
					,_Fld16311 [ТелефонСоставителя]
					,_Fld16312 [АдресЭлектроннойПочтыСоставителя]
					,_Fld16313RRef [ГлавныйБухгалтер]
					,_Fld16314 [ВыводитьПодписиВРеестрПособий]
					From _Document574(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
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
							Ссылка.КраткийСоставДокумента = Читалка.GetString(12);
							Ссылка.ИНН = Читалка.GetString(13);
							Ссылка.КПП = Читалка.GetString(14);
							Ссылка.ОГРН = Читалка.GetString(15);
							Ссылка.ТелефонСоставителя = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыСоставителя = Читалка.GetString(18);
							Ссылка.ВыводитьПодписиВРеестрПособий = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld16297RRef [Организация]
					,_Fld16298RRef [Ответственный]
					,_Fld16299 [Комментарий]
					,_Fld16300 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld16301 [РегистрационныйНомерФСС]
					,_Fld16302 [ДополнительныйКодФСС]
					,_Fld16303 [КодПодчиненностиФСС]
					,_Fld16304RRef [Руководитель]
					,_Fld16305RRef [ДолжностьРуководителя]
					,_Fld16306 [КраткийСоставДокумента]
					,_Fld16307 [ИНН]
					,_Fld16308 [КПП]
					,_Fld16309 [ОГРН]
					,_Fld16310RRef [РеестрСоставил]
					,_Fld16311 [ТелефонСоставителя]
					,_Fld16312 [АдресЭлектроннойПочтыСоставителя]
					,_Fld16313RRef [ГлавныйБухгалтер]
					,_Fld16314 [ВыводитьПодписиВРеестрПособий]
					From _Document574(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
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
							Ссылка.КраткийСоставДокумента = Читалка.GetString(12);
							Ссылка.ИНН = Читалка.GetString(13);
							Ссылка.КПП = Читалка.GetString(14);
							Ссылка.ОГРН = Читалка.GetString(15);
							Ссылка.ТелефонСоставителя = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыСоставителя = Читалка.GetString(18);
							Ссылка.ВыводитьПодписиВРеестрПособий = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld16297RRef [Организация]
					,_Fld16298RRef [Ответственный]
					,_Fld16299 [Комментарий]
					,_Fld16300 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld16301 [РегистрационныйНомерФСС]
					,_Fld16302 [ДополнительныйКодФСС]
					,_Fld16303 [КодПодчиненностиФСС]
					,_Fld16304RRef [Руководитель]
					,_Fld16305RRef [ДолжностьРуководителя]
					,_Fld16306 [КраткийСоставДокумента]
					,_Fld16307 [ИНН]
					,_Fld16308 [КПП]
					,_Fld16309 [ОГРН]
					,_Fld16310RRef [РеестрСоставил]
					,_Fld16311 [ТелефонСоставителя]
					,_Fld16312 [АдресЭлектроннойПочтыСоставителя]
					,_Fld16313RRef [ГлавныйБухгалтер]
					,_Fld16314 [ВыводитьПодписиВРеестрПособий]
					From _Document574(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
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
							Ссылка.КраткийСоставДокумента = Читалка.GetString(12);
							Ссылка.ИНН = Читалка.GetString(13);
							Ссылка.КПП = Читалка.GetString(14);
							Ссылка.ОГРН = Читалка.GetString(15);
							Ссылка.ТелефонСоставителя = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыСоставителя = Читалка.GetString(18);
							Ссылка.ВыводитьПодписиВРеестрПособий = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld16297RRef [Организация]
					,_Fld16298RRef [Ответственный]
					,_Fld16299 [Комментарий]
					,_Fld16300 [НаименованиеТерриториальногоОрганаФСС]
					,_Fld16301 [РегистрационныйНомерФСС]
					,_Fld16302 [ДополнительныйКодФСС]
					,_Fld16303 [КодПодчиненностиФСС]
					,_Fld16304RRef [Руководитель]
					,_Fld16305RRef [ДолжностьРуководителя]
					,_Fld16306 [КраткийСоставДокумента]
					,_Fld16307 [ИНН]
					,_Fld16308 [КПП]
					,_Fld16309 [ОГРН]
					,_Fld16310RRef [РеестрСоставил]
					,_Fld16311 [ТелефонСоставителя]
					,_Fld16312 [АдресЭлектроннойПочтыСоставителя]
					,_Fld16313RRef [ГлавныйБухгалтер]
					,_Fld16314 [ВыводитьПодписиВРеестрПособий]
					From _Document574(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
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
							Ссылка.КраткийСоставДокумента = Читалка.GetString(12);
							Ссылка.ИНН = Читалка.GetString(13);
							Ссылка.КПП = Читалка.GetString(14);
							Ссылка.ОГРН = Читалка.GetString(15);
							Ссылка.ТелефонСоставителя = Читалка.GetString(17);
							Ссылка.АдресЭлектроннойПочтыСоставителя = Читалка.GetString(18);
							Ссылка.ВыводитьПодписиВРеестрПособий = ((byte[])Читалка.GetValue(20))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.РеестрСведенийВФССОЕжемесячныхПособияхПоУходу();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.НаименованиеТерриториальногоОрганаФСС = "";
			Объект.РегистрационныйНомерФСС = "";
			Объект.ДополнительныйКодФСС = "";
			Объект.КодПодчиненностиФСС = "";
			Объект.КраткийСоставДокумента = "";
			Объект.ИНН = "";
			Объект.КПП = "";
			Объект.ОГРН = "";
			Объект.ТелефонСоставителя = "";
			Объект.АдресЭлектроннойПочтыСоставителя = "";
			return Объект;
		}
	}
}