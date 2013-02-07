
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class ОтправкиФСС:СправочникМенеджер
	{

		public static СправочникиСсылка.ОтправкиФСС НайтиПоКоду(string Код)
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
					,_Fld3132_TYPE [ОтчетСсылка_Тип],_Fld3132_RRRef [ОтчетСсылка],_Fld3132_RTRef [ОтчетСсылка_Вид]
					,_Fld3133 [ИдентификаторОтправкиНаСервере]
					,_Fld3134 [ЗашифрованныйПакет]
					,_Fld3135 [ИмяФайлаПакета]
					,_Fld3136RRef [СтатусОтправки]
					,_Fld3137 [Протокол]
					,_Fld3138 [ДатаОтправки]
					,_Fld3139 [ДатаПолученияРезультата]
					,_Fld3140RRef [Организация]
					,_Fld3141 [КодОрганаФСС]
					,_Fld3142 [Квитанция]
					From _Reference184(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ОтправкиФСС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторОтправкиНаСервере = Читалка.GetString(9);
							Ссылка.ИмяФайлаПакета = Читалка.GetString(11);
							Ссылка.СтатусОтправки = V82.Перечисления/*Ссылка*/.СтатусыОтправки.ПустаяСсылка.Получить((byte[])Читалка.GetValue(12));
							Ссылка.ДатаОтправки = Читалка.GetDateTime(14);
							Ссылка.ДатаПолученияРезультата = Читалка.GetDateTime(15);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(16));
							Ссылка.КодОрганаФСС = Читалка.GetString(17);
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

		public static СправочникиВыборка.ОтправкиФСС Выбрать()
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
					,_Fld3132_TYPE [ОтчетСсылка_Тип],_Fld3132_RRRef [ОтчетСсылка],_Fld3132_RTRef [ОтчетСсылка_Вид]
					,_Fld3133 [ИдентификаторОтправкиНаСервере]
					,_Fld3134 [ЗашифрованныйПакет]
					,_Fld3135 [ИмяФайлаПакета]
					,_Fld3136RRef [СтатусОтправки]
					,_Fld3137 [Протокол]
					,_Fld3138 [ДатаОтправки]
					,_Fld3139 [ДатаПолученияРезультата]
					,_Fld3140RRef [Организация]
					,_Fld3141 [КодОрганаФСС]
					,_Fld3142 [Квитанция]
							From _Reference184(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ОтправкиФСС();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ОтправкиФСС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ИдентификаторОтправкиНаСервере = Читалка.GetString(9);
							Ссылка.ИмяФайлаПакета = Читалка.GetString(11);
							Ссылка.СтатусОтправки = V82.Перечисления/*Ссылка*/.СтатусыОтправки.ПустаяСсылка.Получить((byte[])Читалка.GetValue(12));
							Ссылка.ДатаОтправки = Читалка.GetDateTime(14);
							Ссылка.ДатаПолученияРезультата = Читалка.GetDateTime(15);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(16));
							Ссылка.КодОрганаФСС = Читалка.GetString(17);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ОтправкиФСС СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ОтправкиФСС();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.ИдентификаторОтправкиНаСервере = "";
			Объект.ИмяФайлаПакета = "";
			Объект.КодОрганаФСС = "";
			Объект.СтатусОтправки = V82.Перечисления/*Ссылка*/.СтатусыОтправки.ПустаяСсылка;
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			return Объект;
		}
	}
}