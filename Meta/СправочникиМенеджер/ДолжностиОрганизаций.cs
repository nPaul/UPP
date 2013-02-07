
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
	///(Регл)
	///</summary>
	public partial class ДолжностиОрганизаций:СправочникМенеджер
	{

		public static СправочникиСсылка.ДолжностиОрганизаций НайтиПоКоду(string Код)
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
					,_Fld2276RRef [КодПозицииСписка]
					,_Fld2277RRef [ОснованиеВыслугиЛет]
					,_Fld2278 [АУП]
					,_Fld2279RRef [КатегорияВоинскогоУчета]
					,_Fld2280 [КодПоОКПДТР]
					,_Fld2281RRef [Должность]
					,_Fld2282RRef [КатегорияСтатистическогоУчета]
					,_Fld2283 [ЯвляетсяДолжностьюЛетногоЭкипажа]
					,_Fld2284 [ЯвляетсяШахтерскойДолжностью]
					,_Fld2285RRef [КатегорияУчетаЗабронированных]
					,_Fld2286 [ЯвляетсяФармацевтическойДолжностью]
					From _Reference92(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ДолжностиОрганизаций();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.КодПозицииСписка = new V82.СправочникиСсылка.СпискиПрофессийДолжностейЛьготногоПенсионногоОбеспечения((byte[])Читалка.GetValue(6));
							//Ссылка.ОснованиеВыслугиЛет = new V82.СправочникиСсылка.ОснованияВыслугиЛет((byte[])Читалка.GetValue(7));
							Ссылка.АУП = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.КатегорияВоинскогоУчета = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляВоинскогоУчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.КодПоОКПДТР = Читалка.GetString(10);
							//Ссылка.Должность = new V82.СправочникиСсылка.Должности((byte[])Читалка.GetValue(11));
							Ссылка.КатегорияСтатистическогоУчета = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляСтатистическогоУчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(12));
							Ссылка.ЯвляетсяДолжностьюЛетногоЭкипажа = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ЯвляетсяШахтерскойДолжностью = ((byte[])Читалка.GetValue(14))[0]==1?true:false;
							Ссылка.КатегорияУчетаЗабронированных = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляУчетаЗабронированныхС2011Года.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ЯвляетсяФармацевтическойДолжностью = ((byte[])Читалка.GetValue(16))[0]==1?true:false;
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

		public static СправочникиВыборка.ДолжностиОрганизаций Выбрать()
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
					,_Fld2276RRef [КодПозицииСписка]
					,_Fld2277RRef [ОснованиеВыслугиЛет]
					,_Fld2278 [АУП]
					,_Fld2279RRef [КатегорияВоинскогоУчета]
					,_Fld2280 [КодПоОКПДТР]
					,_Fld2281RRef [Должность]
					,_Fld2282RRef [КатегорияСтатистическогоУчета]
					,_Fld2283 [ЯвляетсяДолжностьюЛетногоЭкипажа]
					,_Fld2284 [ЯвляетсяШахтерскойДолжностью]
					,_Fld2285RRef [КатегорияУчетаЗабронированных]
					,_Fld2286 [ЯвляетсяФармацевтическойДолжностью]
							From _Reference92(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ДолжностиОрганизаций();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ДолжностиОрганизаций();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.КодПозицииСписка = new V82.СправочникиСсылка.СпискиПрофессийДолжностейЛьготногоПенсионногоОбеспечения((byte[])Читалка.GetValue(6));
							//Ссылка.ОснованиеВыслугиЛет = new V82.СправочникиСсылка.ОснованияВыслугиЛет((byte[])Читалка.GetValue(7));
							Ссылка.АУП = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.КатегорияВоинскогоУчета = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляВоинскогоУчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.КодПоОКПДТР = Читалка.GetString(10);
							//Ссылка.Должность = new V82.СправочникиСсылка.Должности((byte[])Читалка.GetValue(11));
							Ссылка.КатегорияСтатистическогоУчета = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляСтатистическогоУчета.ПустаяСсылка.Получить((byte[])Читалка.GetValue(12));
							Ссылка.ЯвляетсяДолжностьюЛетногоЭкипажа = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ЯвляетсяШахтерскойДолжностью = ((byte[])Читалка.GetValue(14))[0]==1?true:false;
							Ссылка.КатегорияУчетаЗабронированных = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляУчетаЗабронированныхС2011Года.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ЯвляетсяФармацевтическойДолжностью = ((byte[])Читалка.GetValue(16))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ДолжностиОрганизаций СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ДолжностиОрганизаций();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.КодПоОКПДТР = "";
			Объект.КодПозицииСписка = new V82.СправочникиСсылка.СпискиПрофессийДолжностейЛьготногоПенсионногоОбеспечения();
			Объект.ОснованиеВыслугиЛет = new V82.СправочникиСсылка.ОснованияВыслугиЛет();
			Объект.КатегорияВоинскогоУчета = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляВоинскогоУчета.ПустаяСсылка;
			Объект.Должность = new V82.СправочникиСсылка.Должности();
			Объект.КатегорияСтатистическогоУчета = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляСтатистическогоУчета.ПустаяСсылка;
			Объект.КатегорияУчетаЗабронированных = V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляУчетаЗабронированныхС2011Года.ПустаяСсылка;
			return Объект;
		}
	}
}