
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
	///(Общ)
	///</summary>
	public partial class СтатьиЗатрат:СправочникМенеджер
	{

		public static СправочникиСсылка.СтатьиЗатрат НайтиПоКоду(string Код)
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
					,_Fld3811RRef [ВидЗатрат]
					,_Fld3812RRef [СтатусМатериальныхЗатрат]
					,_Fld3813RRef [ХарактерЗатрат]
					,_Fld3814RRef [ВидРасходовНУ]
					From _Reference248(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиЗатрат();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВидЗатрат = V82.Перечисления/*Ссылка*/.ВидыЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.СтатусМатериальныхЗатрат = V82.Перечисления/*Ссылка*/.СтатусыМатериальныхЗатратНаПроизводство.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.ХарактерЗатрат = V82.Перечисления/*Ссылка*/.ХарактерЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ВидРасходовНУ = V82.Перечисления/*Ссылка*/.ВидыРасходовНУ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
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

		public static СправочникиВыборка.СтатьиЗатрат Выбрать()
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
					,_Fld3811RRef [ВидЗатрат]
					,_Fld3812RRef [СтатусМатериальныхЗатрат]
					,_Fld3813RRef [ХарактерЗатрат]
					,_Fld3814RRef [ВидРасходовНУ]
							From _Reference248(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СтатьиЗатрат();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СтатьиЗатрат();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВидЗатрат = V82.Перечисления/*Ссылка*/.ВидыЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.СтатусМатериальныхЗатрат = V82.Перечисления/*Ссылка*/.СтатусыМатериальныхЗатратНаПроизводство.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.ХарактерЗатрат = V82.Перечисления/*Ссылка*/.ХарактерЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ВидРасходовНУ = V82.Перечисления/*Ссылка*/.ВидыРасходовНУ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.СтатьиЗатрат СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.СтатьиЗатрат();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.ВидЗатрат = V82.Перечисления/*Ссылка*/.ВидыЗатрат.ПустаяСсылка;
			Объект.СтатусМатериальныхЗатрат = V82.Перечисления/*Ссылка*/.СтатусыМатериальныхЗатратНаПроизводство.ПустаяСсылка;
			Объект.ХарактерЗатрат = V82.Перечисления/*Ссылка*/.ХарактерЗатрат.ПустаяСсылка;
			Объект.ВидРасходовНУ = V82.Перечисления/*Ссылка*/.ВидыРасходовНУ.ПустаяСсылка;
			return Объект;
		}
	}
}