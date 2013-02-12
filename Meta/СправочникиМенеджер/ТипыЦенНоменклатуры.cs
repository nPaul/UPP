﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	///<summary>
	///(Упр)
	///</summary>
	public partial class ТипыЦенНоменклатуры:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ТипыЦенНоменклатуры НайтиПоКоду(string Код)
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
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld3965RRef [ВалютаЦены]
					,_Fld3966RRef [БазовыйТипЦен]
					,_Fld3967 [Рассчитывается]
					,_Fld3968 [ПроцентСкидкиНаценки]
					,_Fld3969 [ЦенаВключаетНДС]
					,_Fld3970RRef [ПорядокОкругления]
					,_Fld3971 [ОкруглятьВБольшуюСторону]
					,_Fld3972 [Комментарий]
					,_Fld3973RRef [СпособРасчетаЦены]
					From _Reference269(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ВалютаЦены = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(6));
							//Ссылка.БазовыйТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
							Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
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
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры Выбрать()
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
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld3965RRef [ВалютаЦены]
					,_Fld3966RRef [БазовыйТипЦен]
					,_Fld3967 [Рассчитывается]
					,_Fld3968 [ПроцентСкидкиНаценки]
					,_Fld3969 [ЦенаВключаетНДС]
					,_Fld3970RRef [ПорядокОкругления]
					,_Fld3971 [ОкруглятьВБольшуюСторону]
					,_Fld3972 [Комментарий]
					,_Fld3973RRef [СпособРасчетаЦены]
							From _Reference269(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ВалютаЦены = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(6));
							//Ссылка.БазовыйТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
							Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld3965RRef [ВалютаЦены]
					,_Fld3966RRef [БазовыйТипЦен]
					,_Fld3967 [Рассчитывается]
					,_Fld3968 [ПроцентСкидкиНаценки]
					,_Fld3969 [ЦенаВключаетНДС]
					,_Fld3970RRef [ПорядокОкругления]
					,_Fld3971 [ОкруглятьВБольшуюСторону]
					,_Fld3972 [Комментарий]
					,_Fld3973RRef [СпособРасчетаЦены]
							From _Reference269(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ВалютаЦены = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(6));
							//Ссылка.БазовыйТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
							Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld3965RRef [ВалютаЦены]
					,_Fld3966RRef [БазовыйТипЦен]
					,_Fld3967 [Рассчитывается]
					,_Fld3968 [ПроцентСкидкиНаценки]
					,_Fld3969 [ЦенаВключаетНДС]
					,_Fld3970RRef [ПорядокОкругления]
					,_Fld3971 [ОкруглятьВБольшуюСторону]
					,_Fld3972 [Комментарий]
					,_Fld3973RRef [СпособРасчетаЦены]
							From _Reference269(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ВалютаЦены = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(6));
							//Ссылка.БазовыйТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
							Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатуры ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld3965RRef [ВалютаЦены]
					,_Fld3966RRef [БазовыйТипЦен]
					,_Fld3967 [Рассчитывается]
					,_Fld3968 [ПроцентСкидкиНаценки]
					,_Fld3969 [ЦенаВключаетНДС]
					,_Fld3970RRef [ПорядокОкругления]
					,_Fld3971 [ОкруглятьВБольшуюСторону]
					,_Fld3972 [Комментарий]
					,_Fld3973RRef [СпособРасчетаЦены]
							From _Reference269(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ВалютаЦены = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(6));
							//Ссылка.БазовыйТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(7));
							Ссылка.Рассчитывается = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(9);
							Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
							Ссылка.ОкруглятьВБольшуюСторону = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.Комментарий = Читалка.GetString(13);
							Ссылка.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ТипыЦенНоменклатуры СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ТипыЦенНоменклатуры();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Комментарий = "";
			Объект.ВалютаЦены = new V82.СправочникиСсылка.Валюты();
			Объект.БазовыйТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
			Объект.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка;
			Объект.СпособРасчетаЦены = V82.Перечисления/*Ссылка*/.СпособыРасчетаЦены.ПустаяСсылка;
			return Объект;
		}
	}
}