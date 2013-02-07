
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class ВидыКонтактнойИнформации:СправочникМенеджер
	{

		public static СправочникиСсылка.ВидыКонтактнойИнформации НайтиПоКоду(string Код)
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
					,_Fld1944RRef [Тип]
					,_Fld1945RRef [ВидОбъектаКонтактнойИнформации]
					From _Reference53(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВидыКонтактнойИнформации();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыКонтактнойИнформации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ВидОбъектаКонтактнойИнформации = V82.Перечисления/*Ссылка*/.ВидыОбъектовКонтактнойИнформации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
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

		public static СправочникиВыборка.ВидыКонтактнойИнформации Выбрать()
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
					,_Fld1944RRef [Тип]
					,_Fld1945RRef [ВидОбъектаКонтактнойИнформации]
							From _Reference53(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВидыКонтактнойИнформации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВидыКонтактнойИнформации();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыКонтактнойИнформации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ВидОбъектаКонтактнойИнформации = V82.Перечисления/*Ссылка*/.ВидыОбъектовКонтактнойИнформации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ВидыКонтактнойИнформации СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ВидыКонтактнойИнформации();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Тип = V82.Перечисления/*Ссылка*/.ТипыКонтактнойИнформации.ПустаяСсылка;
			Объект.ВидОбъектаКонтактнойИнформации = V82.Перечисления/*Ссылка*/.ВидыОбъектовКонтактнойИнформации.ПустаяСсылка;
			return Объект;
		}
	}
}