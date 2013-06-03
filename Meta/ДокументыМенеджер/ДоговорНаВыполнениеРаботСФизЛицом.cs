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
	///(Регл)
	///</summary>
	public partial class ДоговорНаВыполнениеРаботСФизЛицом:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld6849RRef [Сотрудник]
					,_Fld6850RRef [ФизЛицо]
					,_Fld6851RRef [Организация]
					,_Fld6852RRef [ВалютаДокумента]
					,_Fld6853 [СуммаЗаРаботу]
					,_Fld6854RRef [ВидРасчета]
					,_Fld6855 [Комментарий]
					,_Fld6856RRef [Ответственный]
					,_Fld6857_TYPE [ВидДоговора_Тип],_Fld6857_RRRef [ВидДоговора],_Fld6857_RTRef [ВидДоговора_Вид]
					,_Fld6858RRef [ВидАвторскогоДоговора]
					,_Fld6859 [ДатаНачала]
					,_Fld6860 [ДатаОкончания]
					,_Fld6861RRef [ПодразделениеОрганизации]
					,_Fld6862RRef [ХарактерОплаты]
					,_Fld6863RRef [ОтнесениеРасходовКДеятельностиЕНВД]
					,_Fld6864RRef [СпособОтраженияВБухучете]
					,_Fld6865RRef [КодВычета]
					,_Fld6866 [ЗаключенСоСтудентомРаботающимВСтудотряде]
					From _Document357(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗаРаботу = Читалка.GetDecimal(7);
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.ВидАвторскогоДоговора = V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаНачала = Читалка.GetDateTime(15);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(16);
							Ссылка.ХарактерОплаты = V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
							Ссылка.ОтнесениеРасходовКДеятельностиЕНВД = V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ЗаключенСоСтудентомРаботающимВСтудотряде = ((byte[])Читалка.GetValue(22))[0]==1;
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
		
		public static ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом НайтиПоНомеру(string Номер)
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
					,_Fld6849RRef [Сотрудник]
					,_Fld6850RRef [ФизЛицо]
					,_Fld6851RRef [Организация]
					,_Fld6852RRef [ВалютаДокумента]
					,_Fld6853 [СуммаЗаРаботу]
					,_Fld6854RRef [ВидРасчета]
					,_Fld6855 [Комментарий]
					,_Fld6856RRef [Ответственный]
					,_Fld6857_TYPE [ВидДоговора_Тип],_Fld6857_RRRef [ВидДоговора],_Fld6857_RTRef [ВидДоговора_Вид]
					,_Fld6858RRef [ВидАвторскогоДоговора]
					,_Fld6859 [ДатаНачала]
					,_Fld6860 [ДатаОкончания]
					,_Fld6861RRef [ПодразделениеОрганизации]
					,_Fld6862RRef [ХарактерОплаты]
					,_Fld6863RRef [ОтнесениеРасходовКДеятельностиЕНВД]
					,_Fld6864RRef [СпособОтраженияВБухучете]
					,_Fld6865RRef [КодВычета]
					,_Fld6866 [ЗаключенСоСтудентомРаботающимВСтудотряде]
					From _Document357(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗаРаботу = Читалка.GetDecimal(7);
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.ВидАвторскогоДоговора = V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаНачала = Читалка.GetDateTime(15);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(16);
							Ссылка.ХарактерОплаты = V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
							Ссылка.ОтнесениеРасходовКДеятельностиЕНВД = V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ЗаключенСоСтудентомРаботающимВСтудотряде = ((byte[])Читалка.GetValue(22))[0]==1;
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
		
		public static ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом Выбрать()
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
					,_Fld6849RRef [Сотрудник]
					,_Fld6850RRef [ФизЛицо]
					,_Fld6851RRef [Организация]
					,_Fld6852RRef [ВалютаДокумента]
					,_Fld6853 [СуммаЗаРаботу]
					,_Fld6854RRef [ВидРасчета]
					,_Fld6855 [Комментарий]
					,_Fld6856RRef [Ответственный]
					,_Fld6857_TYPE [ВидДоговора_Тип],_Fld6857_RRRef [ВидДоговора],_Fld6857_RTRef [ВидДоговора_Вид]
					,_Fld6858RRef [ВидАвторскогоДоговора]
					,_Fld6859 [ДатаНачала]
					,_Fld6860 [ДатаОкончания]
					,_Fld6861RRef [ПодразделениеОрганизации]
					,_Fld6862RRef [ХарактерОплаты]
					,_Fld6863RRef [ОтнесениеРасходовКДеятельностиЕНВД]
					,_Fld6864RRef [СпособОтраженияВБухучете]
					,_Fld6865RRef [КодВычета]
					,_Fld6866 [ЗаключенСоСтудентомРаботающимВСтудотряде]
					From _Document357(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗаРаботу = Читалка.GetDecimal(7);
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.ВидАвторскогоДоговора = V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаНачала = Читалка.GetDateTime(15);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(16);
							Ссылка.ХарактерОплаты = V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
							Ссылка.ОтнесениеРасходовКДеятельностиЕНВД = V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ЗаключенСоСтудентомРаботающимВСтудотряде = ((byte[])Читалка.GetValue(22))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld6849RRef [Сотрудник]
					,_Fld6850RRef [ФизЛицо]
					,_Fld6851RRef [Организация]
					,_Fld6852RRef [ВалютаДокумента]
					,_Fld6853 [СуммаЗаРаботу]
					,_Fld6854RRef [ВидРасчета]
					,_Fld6855 [Комментарий]
					,_Fld6856RRef [Ответственный]
					,_Fld6857_TYPE [ВидДоговора_Тип],_Fld6857_RRRef [ВидДоговора],_Fld6857_RTRef [ВидДоговора_Вид]
					,_Fld6858RRef [ВидАвторскогоДоговора]
					,_Fld6859 [ДатаНачала]
					,_Fld6860 [ДатаОкончания]
					,_Fld6861RRef [ПодразделениеОрганизации]
					,_Fld6862RRef [ХарактерОплаты]
					,_Fld6863RRef [ОтнесениеРасходовКДеятельностиЕНВД]
					,_Fld6864RRef [СпособОтраженияВБухучете]
					,_Fld6865RRef [КодВычета]
					,_Fld6866 [ЗаключенСоСтудентомРаботающимВСтудотряде]
					From _Document357(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗаРаботу = Читалка.GetDecimal(7);
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.ВидАвторскогоДоговора = V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаНачала = Читалка.GetDateTime(15);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(16);
							Ссылка.ХарактерОплаты = V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
							Ссылка.ОтнесениеРасходовКДеятельностиЕНВД = V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ЗаключенСоСтудентомРаботающимВСтудотряде = ((byte[])Читалка.GetValue(22))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld6849RRef [Сотрудник]
					,_Fld6850RRef [ФизЛицо]
					,_Fld6851RRef [Организация]
					,_Fld6852RRef [ВалютаДокумента]
					,_Fld6853 [СуммаЗаРаботу]
					,_Fld6854RRef [ВидРасчета]
					,_Fld6855 [Комментарий]
					,_Fld6856RRef [Ответственный]
					,_Fld6857_TYPE [ВидДоговора_Тип],_Fld6857_RRRef [ВидДоговора],_Fld6857_RTRef [ВидДоговора_Вид]
					,_Fld6858RRef [ВидАвторскогоДоговора]
					,_Fld6859 [ДатаНачала]
					,_Fld6860 [ДатаОкончания]
					,_Fld6861RRef [ПодразделениеОрганизации]
					,_Fld6862RRef [ХарактерОплаты]
					,_Fld6863RRef [ОтнесениеРасходовКДеятельностиЕНВД]
					,_Fld6864RRef [СпособОтраженияВБухучете]
					,_Fld6865RRef [КодВычета]
					,_Fld6866 [ЗаключенСоСтудентомРаботающимВСтудотряде]
					From _Document357(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗаРаботу = Читалка.GetDecimal(7);
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.ВидАвторскогоДоговора = V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаНачала = Читалка.GetDateTime(15);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(16);
							Ссылка.ХарактерОплаты = V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
							Ссылка.ОтнесениеРасходовКДеятельностиЕНВД = V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ЗаключенСоСтудентомРаботающимВСтудотряде = ((byte[])Читалка.GetValue(22))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld6849RRef [Сотрудник]
					,_Fld6850RRef [ФизЛицо]
					,_Fld6851RRef [Организация]
					,_Fld6852RRef [ВалютаДокумента]
					,_Fld6853 [СуммаЗаРаботу]
					,_Fld6854RRef [ВидРасчета]
					,_Fld6855 [Комментарий]
					,_Fld6856RRef [Ответственный]
					,_Fld6857_TYPE [ВидДоговора_Тип],_Fld6857_RRRef [ВидДоговора],_Fld6857_RTRef [ВидДоговора_Вид]
					,_Fld6858RRef [ВидАвторскогоДоговора]
					,_Fld6859 [ДатаНачала]
					,_Fld6860 [ДатаОкончания]
					,_Fld6861RRef [ПодразделениеОрганизации]
					,_Fld6862RRef [ХарактерОплаты]
					,_Fld6863RRef [ОтнесениеРасходовКДеятельностиЕНВД]
					,_Fld6864RRef [СпособОтраженияВБухучете]
					,_Fld6865RRef [КодВычета]
					,_Fld6866 [ЗаключенСоСтудентомРаботающимВСтудотряде]
					From _Document357(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗаРаботу = Читалка.GetDecimal(7);
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.ВидАвторскогоДоговора = V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаНачала = Читалка.GetDateTime(15);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(16);
							Ссылка.ХарактерОплаты = V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
							Ссылка.ОтнесениеРасходовКДеятельностиЕНВД = V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ЗаключенСоСтудентомРаботающимВСтудотряде = ((byte[])Читалка.GetValue(22))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld6849RRef [Сотрудник]
					,_Fld6850RRef [ФизЛицо]
					,_Fld6851RRef [Организация]
					,_Fld6852RRef [ВалютаДокумента]
					,_Fld6853 [СуммаЗаРаботу]
					,_Fld6854RRef [ВидРасчета]
					,_Fld6855 [Комментарий]
					,_Fld6856RRef [Ответственный]
					,_Fld6857_TYPE [ВидДоговора_Тип],_Fld6857_RRRef [ВидДоговора],_Fld6857_RTRef [ВидДоговора_Вид]
					,_Fld6858RRef [ВидАвторскогоДоговора]
					,_Fld6859 [ДатаНачала]
					,_Fld6860 [ДатаОкончания]
					,_Fld6861RRef [ПодразделениеОрганизации]
					,_Fld6862RRef [ХарактерОплаты]
					,_Fld6863RRef [ОтнесениеРасходовКДеятельностиЕНВД]
					,_Fld6864RRef [СпособОтраженияВБухучете]
					,_Fld6865RRef [КодВычета]
					,_Fld6866 [ЗаключенСоСтудентомРаботающимВСтудотряде]
					From _Document357(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ДоговорНаВыполнениеРаботСФизЛицом();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.СуммаЗаРаботу = Читалка.GetDecimal(7);
							Ссылка.Комментарий = Читалка.GetString(9);
							Ссылка.ВидАвторскогоДоговора = V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.ДатаНачала = Читалка.GetDateTime(15);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(16);
							Ссылка.ХарактерОплаты = V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
							Ссылка.ОтнесениеРасходовКДеятельностиЕНВД = V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.ЗаключенСоСтудентомРаботающимВСтудотряде = ((byte[])Читалка.GetValue(22))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ДоговорНаВыполнениеРаботСФизЛицом СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ДоговорНаВыполнениеРаботСФизЛицом();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ВидАвторскогоДоговора = V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора.ПустаяСсылка;
			Объект.ХарактерОплаты = V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору.ПустаяСсылка;
			Объект.ОтнесениеРасходовКДеятельностиЕНВД = V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД.ПустаяСсылка;
			return Объект;
		}
	}
}