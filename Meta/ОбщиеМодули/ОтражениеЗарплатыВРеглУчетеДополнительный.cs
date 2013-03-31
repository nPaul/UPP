﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ОтражениеЗарплатыВРеглУчетеДополнительный
	{
		// Функция возвращает счет прочих расходов из плана счетов Хозрасчетный
		//
		// Параметры
		//  ОтражениеНаСчетеЕНВД  - Булево. Параметр, уточняющий, какой счет возвращать
		//

		public object ПолучитьСчетПрочихРасходов(/*ОтражениеНаСчетеЕНВД*/)
		{
			if(true/*ОтражениеНаСчетеЕНВД*/)
			{
			}
			return null;
		}
		// ПолучитьСчетПрочихРасходов()
		// Функция проверяет программу бухучета и налоговый режим, для проверки и
		// заполнения строк отражения в учете

		public object ПолучитьСтруктураПараметровПеременныхВеденияУчета(/*Организация, ПериодРегистрации*/)
		{
			//СтруктураЗначенияПеременных = Новый Структура;
			/*// определим налоговый режим
*/
			//НалоговыйУчет.ОбновитьДанныеУчетнойПолитикиПоНалоговомуУчету(глЗначениеПеременной("УчетнаяПолитикаОтраженияЗарплатыВУчете"), КонецМесяца(ПериодРегистрации), Организация);
			//УчетнаяПолитика = глЗначениеПеременной("УчетнаяПолитикаОтраженияЗарплатыВУчете")[КонецМесяца(ПериодРегистрации)][Организация];
			//УСН = УчетнаяПолитика.УСН;
			//СтруктураЗначенияПеременных.Вставить("УСН", УСН);
			//СтруктураЗначенияПеременных.Вставить("ОбъектНалогообложенияУСН", УчетнаяПолитика.ОбъектНалогообложенияУСН);
			//СтруктураЗначенияПеременных.Вставить("ОрганизацияЯвляетсяПлательщикомЕНВД", УчетнаяПолитика.ОрганизацияЯвляетсяПлательщикомЕНВД);
			//СтруктураЗначенияПеременных.Вставить("УплачиватьДобровольныеВзносыВФСС", УчетнаяПолитика.УплачиватьДобровольныеВзносыВФСС);
			//ПредпринимательНаОСН = Не УСН и ОбщегоНазначения.ПолучитьЗначениеРеквизита(Организация, "ЮрФизЛицо") = Перечисления.ЮрФизЛицо.ФизЛицо;
			//СтруктураЗначенияПеременных.Вставить("ПредпринимательНаОСН", ПредпринимательНаОСН);
			//СтруктураЗначенияПеременных.Вставить("ВариантУчетаРасходовПоНалогамСФОТВНалоговомУчете", УчетнаяПолитика.ВариантУчетаРасходовПоНалогамСФОТВНалоговомУчете);
			//ЗаполнятьДанныеНУ = Не (УСН или ПредпринимательНаОСН);
			//СтруктураЗначенияПеременных.Вставить("ЗаполнятьДанныеНУ", ЗаполнятьДанныеНУ);
			//ЗаполнятьСчетаНУ  = Истина;
			//СтруктураЗначенияПеременных.Вставить("ЗаполнятьСчетаНУ", ЗаполнятьСчетаНУ);
			//ЗаполнятьОКАТОКПП  = Истина;
			//СтруктураЗначенияПеременных.Вставить("ЗаполнятьОКАТОКПП", ЗаполнятьОКАТОКПП);
			//УчетПоПодразделениямНаСчетах = Ложь;
			//СтруктураЗначенияПеременных.Вставить("УчетПоПодразделениямНаСчетах", УчетПоПодразделениямНаСчетах);
			//СтруктураЗначенияПеременных.Вставить("ПорядокПризнанияРасходовПоОтпускам", ПолучитьПорядокПризнанияРасходовПоОтпускам(Организация, ПериодРегистрации));
			//УчетнаяПолитикаПоОценочнымОбязательствам = ПолучитьУчетнуюПолитикуПоОценочнымОбязательствам(Организация, ПериодРегистрации);
			//СтруктураЗначенияПеременных.Вставить("ОценочныеОбязательстваФормироватьБУ", УчетнаяПолитикаПоОценочнымОбязательствам.ФормироватьБУ);
			//СтруктураЗначенияПеременных.Вставить("ОценочныеОбязательстваФормироватьНУ", УчетнаяПолитикаПоОценочнымОбязательствам.ФормироватьНУ);
			//СтруктураЗначенияПеременных.Вставить("ОценочныеОбязательстваПорядокРасчета", УчетнаяПолитикаПоОценочнымОбязательствам.ПорядокРасчета);
			//СтруктураЗначенияПеременных.Вставить("ОценочноеОбязательствоДляОтпуска", УчетнаяПолитикаПоОценочнымОбязательствам.ОценочноеОбязательствоДляОтпуска);
			return null;
		}

		public object ПолучитьУчетнуюПолитикуПоОценочнымОбязательствам(/*Организация, Период*/)
		{
			//УчетнаяПолитикаПоОценочнымОбязательствам = Новый Структура;
			if(true/*НЕ ЗначениеЗаполнено(Период) или Период < ДатаДействияПриказа186Н() или Не ЗначениеЗаполнено(Организация)*/)
			{
				/*//если не заполнены параметры или до 2011 года, учетная политика не применялась
*/
				//УчетнаяПолитикаПоОценочнымОбязательствам.Вставить("ФормироватьБУ", Ложь);
				//УчетнаяПолитикаПоОценочнымОбязательствам.Вставить("ФормироватьНУ", Ложь);
				//УчетнаяПолитикаПоОценочнымОбязательствам.Вставить("ПорядокРасчета", Перечисления.ПорядокРасчетаОценочныхОбязательств.ПустаяСсылка());
				//УчетнаяПолитикаПоОценочнымОбязательствам.Вставить("ОценочноеОбязательствоДляОтпуска", Справочники.Резервы.ПустаяСсылка());
			}
			return null;
		}
		// УчетнаяПолитикаПоОценочнымОбязательствам()

		public object ПолучитьПорядокПризнанияРасходовПоОтпускам(/*Организация, Период*/)
		{
			if(true/*НЕ ЗначениеЗаполнено(Период) или Период < ДатаДействияПриказа186Н() или Не ЗначениеЗаполнено(Организация)*/)
			{
				/*//значение по умолчанию
*/
			}
			return null;
		}
		// ПолучитьПорядокПризнанияРасходовПоОтпускам()

		public object ДатаДействияПриказа186Н(/**/)
		{
			return null;
		}
		// ДатаДействияПриказа186Н()
		////////////////////////////////////////////////
		// Функция формирует текст запроса для получения временной таблицы - списка начислений, которые входят в базу оценочного обязательства (резерва),
		// и размеры ОО в разрезе видов расчета
		// Источник данных - регистры БУОсновныеНачисления и БУДополнительныеНачисления
		//
		// Параметры
		//  ОценочныеОбязательстваПорядокРасчета - ПеречислениеСсылка.ПорядокРасчетаОценочныхОбязательств
		//
		// Возвращаемое значение:
		//   Текст запроса
		//

		public object ПолучитьТекстЗапросаРасчетОценочныхОбязательств(/*ОценочныеОбязательстваПорядокРасчета*/)
		{
			/*// параметры запроса
*/
			/*// ЕстьЕНВД - булево, наличие ЕНВД в периоде регистрации
*/
			/*// Организация - Организация
*/
			/*// ПоВсемРезервам - булево, признак формирования запроса без отбора по конкртетному резерву
*/
			/*// Резерв - СправочникСсылка.Резервы
*/
			/*// парамПериодРегистрации - период регистрации
*/
			/*// создается таблица ВТСписокНачислений
*/
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	БУНачисления.Резерв КАК Резерв,
	|	БУНачисления.ВидРасчета КАК ВидРасчета,
	|	БУНачисления.СчетДт КАК СчетДт,
	|	БУНачисления.СубконтоДт1 КАК СубконтоДт1,
	|	БУНачисления.СубконтоДт2 КАК СубконтоДт2,
	|	БУНачисления.СубконтоДт3 КАК СубконтоДт3,
	|	БУНачисления.СчетДтНУ,
	|	БУНачисления.СубконтоДтНУ1,
	|	БУНачисления.СубконтоДтНУ2,
	|	БУНачисления.СубконтоДтНУ3,
	|	БУНачисления.ПодразделениеДт КАК ПодразделениеДт,
	|	БУНачисления.ПодразделениеКт,
	|	БУНачисления.ФизЛицо КАК ФизЛицо,
	|	ВЫБОР
	|		КОГДА (НЕ &ЕстьЕНВД)
	|			ТОГДА ЛОЖЬ
	|		КОГДА СчетаУчетаПоДеятельностиЕНВД.Счет ЕСТЬ NULL 
	|			ТОГДА ЛОЖЬ
	|		ИНАЧЕ ИСТИНА
	|	КОНЕЦ КАК ОблагаетсяЕНВД,
	|	СУММА(БУНачисления.Результат) КАК Результат,
	|	БУНачисления.ПроцентОтчислений
	|ПОМЕСТИТЬ ВТСписокНачислений
	|ИЗ
	|	(ВЫБРАТЬ
	|		БУНачисления.СчетДт КАК СчетДт,
	|		БУНачисления.СубконтоДт1 КАК СубконтоДт1,
	|		БУНачисления.СубконтоДт2 КАК СубконтоДт2,
	|		БУНачисления.СубконтоДт3 КАК СубконтоДт3,
	|		БУНачисления.СчетДтНУ КАК СчетДтНУ,
	|		БУНачисления.СубконтоДтНУ1 КАК СубконтоДтНУ1,
	|		БУНачисления.СубконтоДтНУ2 КАК СубконтоДтНУ2,
	|		БУНачисления.СубконтоДтНУ3 КАК СубконтоДтНУ3,
	|		БУНачисления.Результат КАК Результат,
	|		РазмерыОтчисленийВРезервы.Резерв КАК Резерв,
	|		РазмерыОтчисленийВРезервы.Размер КАК ПроцентОтчислений,
	|		БУНачисления.ПодразделениеДт КАК ПодразделениеДт,
	|		БУНачисления.ПодразделениеКт КАК ПодразделениеКт,
	|		БУНачисления.ВидРасчета КАК ВидРасчета,
	|		БУНачисления.ФизЛицо КАК ФизЛицо
	|	ИЗ
	|		РегистрРасчета.БУОсновныеНачисления КАК БУНачисления
	|			ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.РазмерыОтчисленийВРезервы.СрезПоследних(
	|					&парамПериодРегистрации,
	|					Организация = &Организация
	|						И (&ПоВсемРезервам
	|							ИЛИ Резерв = &Резерв)) КАК РазмерыОтчисленийВРезервы
	|			ПО (РазмерыОтчисленийВРезервы.Размер > 0)
	|			ВНУТРЕННЕЕ СОЕДИНЕНИЕ Справочник.Резервы.БазовыеВидыРасчета КАК БазовыеВидыРасчета
	|			ПО (РазмерыОтчисленийВРезервы.Резерв = БазовыеВидыРасчета.Ссылка)
	|				И ((ВЫРАЗИТЬ(БазовыеВидыРасчета.ВидРасчета КАК ПланВидовРасчета.ОсновныеНачисленияОрганизаций)) = БУНачисления.ВидРасчета)
	|	ГДЕ
	|		БУНачисления.ПериодРегистрации = &парамПериодРегистрации
	|		И БУНачисления.ОбособленноеПодразделение = &Организация
	|	
	|	ОБЪЕДИНИТЬ ВСЕ
	|	
	|	ВЫБРАТЬ
	|		БУНачисления.СчетДт,
	|		БУНачисления.СубконтоДт1,
	|		БУНачисления.СубконтоДт2,
	|		БУНачисления.СубконтоДт3,
	|		БУНачисления.СчетДтНУ,
	|		БУНачисления.СубконтоДтНУ1,
	|		БУНачисления.СубконтоДтНУ2,
	|		БУНачисления.СубконтоДтНУ3,
	|		БУНачисления.Результат,
	|		РазмерыОтчисленийВРезервы.Резерв,
	|		РазмерыОтчисленийВРезервы.Размер,
	|		БУНачисления.ПодразделениеДт,
	|		БУНачисления.ПодразделениеКт,
	|		БУНачисления.ВидРасчета,
	|		БУНачисления.ФизЛицо
	|	ИЗ
	|		РегистрРасчета.БУДополнительныеНачисления КАК БУНачисления
	|			ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.РазмерыОтчисленийВРезервы.СрезПоследних(
	|					&парамПериодРегистрации,
	|					Организация = &Организация
	|						И (&ПоВсемРезервам
	|							ИЛИ Резерв = &Резерв)) КАК РазмерыОтчисленийВРезервы
	|			ПО (РазмерыОтчисленийВРезервы.Размер > 0)
	|			ВНУТРЕННЕЕ СОЕДИНЕНИЕ Справочник.Резервы.БазовыеВидыРасчета КАК БазовыеВидыРасчета
	|			ПО (РазмерыОтчисленийВРезервы.Резерв = БазовыеВидыРасчета.Ссылка)
	|				И ((ВЫРАЗИТЬ(БазовыеВидыРасчета.ВидРасчета КАК ПланВидовРасчета.ДополнительныеНачисленияОрганизаций)) = БУНачисления.ВидРасчета)
	|	ГДЕ
	|		НАЧАЛОПЕРИОДА(БУНачисления.ПериодРегистрации, МЕСЯЦ) = &парамПериодРегистрации
	|		И БУНачисления.ОбособленноеПодразделение = &Организация) КАК БУНачисления
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.СчетаУчетаПоДеятельностиЕНВД КАК СчетаУчетаПоДеятельностиЕНВД
	|		ПО БУНачисления.СчетДт = СчетаУчетаПоДеятельностиЕНВД.Счет
	|
	|СГРУППИРОВАТЬ ПО
	|	БУНачисления.ВидРасчета,
	|	БУНачисления.Резерв,
	|	БУНачисления.ФизЛицо,
	|	БУНачисления.СубконтоДтНУ3,
	|	БУНачисления.ПодразделениеКт,
	|	БУНачисления.ПодразделениеДт,
	|	БУНачисления.СубконтоДтНУ1,
	|	БУНачисления.СубконтоДтНУ2,
	|	БУНачисления.СчетДтНУ,
	|	БУНачисления.СубконтоДт3,
	|	БУНачисления.СчетДт,
	|	БУНачисления.СубконтоДт2,
	|	БУНачисления.СубконтоДт1,
	|	БУНачисления.ПроцентОтчислений,
	|	ВЫБОР
	|		КОГДА (НЕ &ЕстьЕНВД)
	|			ТОГДА ЛОЖЬ
	|		КОГДА СчетаУчетаПоДеятельностиЕНВД.Счет ЕСТЬ NULL 
	|			ТОГДА ЛОЖЬ
	|		ИНАЧЕ ИСТИНА
	|	КОНЕЦ
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	ФизЛицо,
	|	ВидРасчета";*/
			if(true/*ОценочныеОбязательстваПорядокРасчета = Перечисления.ПорядокРасчетаОценочныхОбязательств.Начисления*/)
			{
				/*ТекстЗапроса = ТекстЗапроса + ";"+
		"ВЫБРАТЬ
		|	РезервыПоВидамРасчета.Резерв,
		|	РезервыПоВидамРасчета.ВидРасчета,
		|	ВЫРАЗИТЬ(РезервыПоВидамРасчета.Результат * РезервыПоВидамРасчета.ПроцентОтчислений / 100 КАК ЧИСЛО(15, 2)) КАК РазмерОтчислений,
		|	0 КАК РазмерОтчисленийВзносы,
		|	0 КАК РазмерОтчисленийФССНесчастныеСлучаи,
		|	РезервыПоВидамРасчета.Результат,
		|	0 КАК РезультатВзносы,
		|	РезервыПоВидамРасчета.ПроцентОтчислений,
		|	ВЫРАЗИТЬ(РезервыПоВидамРасчета.Результат * РезервыПоВидамРасчета.ПроцентОтчислений / 100 КАК ЧИСЛО(15, 2)) КАК ВсегоОтчислений
		|ИЗ
		|	(ВЫБРАТЬ
		|		ВТСписокНачислений.Резерв КАК Резерв,
		|		ВТСписокНачислений.ВидРасчета КАК ВидРасчета,
		|		СУММА(ВТСписокНачислений.Результат) КАК Результат,
		|		ВТСписокНачислений.ПроцентОтчислений КАК ПроцентОтчислений
		|	ИЗ
		|		ВТСписокНачислений КАК ВТСписокНачислений
		|	
		|	СГРУППИРОВАТЬ ПО
		|		ВТСписокНачислений.Резерв,
		|		ВТСписокНачислений.ВидРасчета,
		|		ВТСписокНачислений.ПроцентОтчислений) КАК РезервыПоВидамРасчета";*/
			}
			return null;
		}
		// ПолучитьТекстЗапросаРасчетОценочныхОбязательств()
	}
}
