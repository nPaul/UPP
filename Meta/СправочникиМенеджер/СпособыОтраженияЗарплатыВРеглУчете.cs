
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
	public partial class СпособыОтраженияЗарплатыВРеглУчете:СправочникМенеджер
	{


		public static СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете Выбрать()
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
					,_Fld3688RRef [СчетДт]
					,_Fld3689RRef [СубконтоДт1]
					,_Fld3690RRef [СубконтоДт2]
					,_Fld3691RRef [СубконтоДт3]
					,_Fld3692RRef [СпособРаспределенияЗатрат]
					,_Fld3693RRef [СчетКт]
					,_Fld3694RRef [СубконтоКт1]
					,_Fld3695RRef [СубконтоКт2]
					,_Fld3696RRef [СубконтоКт3]
					,_Fld3697RRef [СчетДтНУ]
					,_Fld3698RRef [СубконтоДтНУ1]
					,_Fld3699RRef [СубконтоДтНУ2]
					,_Fld3700RRef [СубконтоДтНУ3]
					,_Fld3701RRef [СчетКтНУ]
					,_Fld3702RRef [СубконтоКтНУ1]
					,_Fld3703RRef [СубконтоКтНУ2]
					,_Fld3704RRef [СубконтоКтНУ3]
					,_Fld3705RRef [ОтражениеВУСН]
					,_Fld3706RRef [ПодразделениеДт]
					,_Fld3707RRef [ПодразделениеКт]
					,_Fld3708RRef [ВидНачисленийОплатыТрудаПоСтатье255НК]
							From _Reference241(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							//Ссылка.СпособРаспределенияЗатрат = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск((byte[])Читалка.GetValue(9));
							Ссылка.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(22));
							//Ссылка.ПодразделениеДт = new V82.СправочникиСсылка.ПодразделенияОрганизаций((byte[])Читалка.GetValue(23));
							//Ссылка.ПодразделениеКт = new V82.СправочникиСсылка.ПодразделенияОрганизаций((byte[])Читалка.GetValue(24));
							Ссылка.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.СпособыОтраженияЗарплатыВРеглУчете СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.СпособыОтраженияЗарплатыВРеглУчете();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.СпособРаспределенияЗатрат = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
			Объект.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка;
			Объект.ПодразделениеДт = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			Объект.ПодразделениеКт = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			Объект.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка;
			return Объект;
		}
	}
}