
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class ПодключаемоеОборудование:СправочникМенеджер
	{


		public static СправочникиВыборка.ПодключаемоеОборудование Выбрать()
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
					,_Description [Наименование]
					,_Fld3184 [ВерсияКомпоненты]
					,_Fld3185 [ИдентификаторУстройства]
					,_Fld3186 [УстройствоОтключено]
					,_Fld3187 [УстройствоИспользуется]
					,_Fld3188RRef [ОбработчикДрайвера]
					,_Fld3189 [Параметры]
					,_Fld3190RRef [РабочееМесто]
					,_Fld3191RRef [ТипОборудования]
					,_Fld3192 [ТребуетсяПереустановка]
							From _Reference190(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ПодключаемоеОборудование();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПодключаемоеОборудование();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ВерсияКомпоненты = Читалка.GetString(5);
							Ссылка.ИдентификаторУстройства = Читалка.GetString(6);
							Ссылка.УстройствоОтключено = ((byte[])Читалка.GetValue(7))[0]==1?true:false;
							Ссылка.УстройствоИспользуется = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.ОбработчикДрайвера = V82.Перечисления/*Ссылка*/.ОбработчикиДрайверовПодключаемогоОборудования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							//Ссылка.РабочееМесто = new V82.СправочникиСсылка.РабочиеМеста((byte[])Читалка.GetValue(11));
							Ссылка.ТипОборудования = V82.Перечисления/*Ссылка*/.ТипыПодключаемогоОборудования.ПустаяСсылка.Получить((byte[])Читалка.GetValue(12));
							Ссылка.ТребуетсяПереустановка = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ПодключаемоеОборудование СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ПодключаемоеОборудование();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.ВерсияКомпоненты = "";
			Объект.ИдентификаторУстройства = "";
			Объект.ОбработчикДрайвера = V82.Перечисления/*Ссылка*/.ОбработчикиДрайверовПодключаемогоОборудования.ПустаяСсылка;
			Объект.РабочееМесто = new V82.СправочникиСсылка.РабочиеМеста();
			Объект.ТипОборудования = V82.Перечисления/*Ссылка*/.ТипыПодключаемогоОборудования.ПустаяСсылка;
			return Объект;
		}
	}
}