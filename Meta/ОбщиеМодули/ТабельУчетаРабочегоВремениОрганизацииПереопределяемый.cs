﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ТабельУчетаРабочегоВремениОрганизацииПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта

		public object СформироватьЗапросПоНезаполненнымСотрудникам(/*ЗапросАвтоЗаполнения*/)
		{
			/*// Запрос для вывода сообщения о незаполненных сотрудниках
*/
			/*ЗапросАвтоЗаполнения.Текст = 
	"ВЫБРАТЬ РАЗЛИЧНЫЕ
	|	ПРЕДСТАВЛЕНИЕ(РегистрТабеля.Сотрудник) КАК ПредставлениеСотрудника,
	|	РегистрТабеля.Регистратор КАК ДокументОснование,
	|	ПРЕДСТАВЛЕНИЕ(РегистрТабеля.Регистратор) КАК ПредставлениеДокумента,
	|	РегистрТабеля.Сотрудник,
	|	РегистрТабеля.Регистратор КАК ВведенныйДокумент
	|ИЗ
	|	РегистрНакопления.РабочееВремяРаботниковОрганизаций КАК РегистрТабеля
	|ГДЕ
	|	РегистрТабеля.Сотрудник В
	|			(ВЫБРАТЬ
	|				ВТСписокРаботников.Ссылка
	|			ИЗ
	|				ВТСписокРаботников)
	|	И РегистрТабеля.Регистратор <> &ДокументСсылка
	|	И (РегистрТабеля.Регистратор ССЫЛКА Документ.ТабельУчетаРабочегоВремениОрганизации
	|			ИЛИ РегистрТабеля.Регистратор ССЫЛКА Документ.СдельныйНаряд)
	|	И ВЫБОР
	|			КОГДА РегистрТабеля.Регистратор ССЫЛКА Документ.СдельныйНаряд
	|				ТОГДА РегистрТабеля.Регистратор.ОтражатьВБухгалтерскомУчете
	|			ИНАЧЕ ИСТИНА
	|		КОНЕЦ
	|	И (РегистрТабеля.Период МЕЖДУ &НачалоМесяца И &КонецМесяца
	|			ИЛИ РегистрТабеля.ВЦеломЗаПериод
	|				И РегистрТабеля.Период = &Месяц)";*/
			return null;
		}

		public void ДополнитьЗапросПоУникальностиЗаписи(/*Запрос*/)
		{
			/*Запрос.Текст = 
	"ВЫБРАТЬ РАЗЛИЧНЫЕ
	|	РабочееВремяРаботниковОрганизаций.Сотрудник КАК Сотрудник,
	|	РабочееВремяРаботниковОрганизаций.Регистратор КАК Регистратор,
	|	РабочееВремяРаботниковОрганизаций.НомерСтроки КАК НомерСтроки,
	|	ДЕНЬ(РабочееВремяРаботниковОрганизаций.Период) КАК ИндексДня,
	|	ВЫБОР
	|		КОГДА РабочееВремяРаботниковОрганизаций.Регистратор ССЫЛКА Документ.СдельныйНаряд
	|			ТОГДА РабочееВремяРаботниковОрганизаций.Регистратор.ОтражатьВБухгалтерскомУчете
	|		ИНАЧЕ ИСТИНА
	|	КОНЕЦ КАК Соединяться
	|ПОМЕСТИТЬ ВТРабочееВремяРаботниковОрганизаций
	|ИЗ
	|	РегистрНакопления.РабочееВремяРаботниковОрганизаций КАК РабочееВремяРаботниковОрганизаций
	|ГДЕ
	|	РабочееВремяРаботниковОрганизаций.Регистратор <> &ДокументСсылка
	|	И (РабочееВремяРаботниковОрганизаций.ВЦеломЗаПериод
	|				И РабочееВремяРаботниковОрганизаций.Период = &Месяц
	|			ИЛИ (НЕ РабочееВремяРаботниковОрганизаций.ВЦеломЗаПериод)
	|				И (РабочееВремяРаботниковОрганизаций.Период МЕЖДУ &НачалоМесяца И &КонецМесяца))
	|	И РабочееВремяРаботниковОрганизаций.Сотрудник В(&СписокСотрудников)
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	Сотрудник,
	|	ИндексДня,
	|	НомерСтроки,
	|	Регистратор,
	|	Соединяться
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ РАЗЛИЧНЫЕ
	|	ГрафикиРаботыПоВидамВремени.ГрафикРаботы КАК ГрафикРаботы,
	|	ДЕНЬ(ГрафикиРаботыПоВидамВремени.Дата) КАК ИндексДня,
	|	ГрафикиРаботыПоВидамВремени.Документ КАК Документ
	|ПОМЕСТИТЬ ВТГрафикиРаботыПоВидамВремени
	|ИЗ
	|	РегистрСведений.ГрафикиРаботыПоВидамВремени КАК ГрафикиРаботыПоВидамВремени
	|ГДЕ
	|	ГрафикиРаботыПоВидамВремени.Месяц = &Месяц
	|	И ГрафикиРаботыПоВидамВремени.Дата МЕЖДУ &НачалоМесяца И &КонецМесяца
	|	И ГрафикиРаботыПоВидамВремени.Документ <> &ДокументСсылка
	|	И (НЕ ГрафикиРаботыПоВидамВремени.План)
	|	И (НЕ ГрафикиРаботыПоВидамВремени.Документ В (ЗНАЧЕНИЕ(Документ.ТабельУчетаРабочегоВремениОрганизации.ПустаяСсылка), ЗНАЧЕНИЕ(Документ.СдельныйНаряд.ПустаяСсылка)))
	|	И ГрафикиРаботыПоВидамВремени.ГрафикРаботы В(&СписокСотрудников)
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	ГрафикРаботы,
	|	ИндексДня,
	|	Документ
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ РАЗЛИЧНЫЕ
	|	ПРЕДСТАВЛЕНИЕ(ЕСТЬNULL(РабочееВремяРаботниковОрганизаций.Регистратор, ГрафикиРаботыПоВидамВремени.Документ)) КАК ДокументПредставление,
	|	ЕСТЬNULL(СотрудникиТабеля.СотрудникНаименование, ГрафикиРаботыПоВидамВремени.ГрафикРаботы.Наименование) КАК СотрудникНаименование
	|ИЗ
	|	(ВЫБРАТЬ РАЗЛИЧНЫЕ
	|		СотрудникиТабеля.ИндексДня КАК ИндексДня,
	|		СотрудникиТабеля.Сотрудник.Наименование КАК СотрудникНаименование,
	|		СотрудникиТабеля.Сотрудник КАК Сотрудник
	|	ИЗ
	|		ВТДанныеТабеляПоДням КАК СотрудникиТабеля) КАК СотрудникиТабеля
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТРабочееВремяРаботниковОрганизаций КАК РабочееВремяРаботниковОрганизаций
	|		ПО СотрудникиТабеля.Сотрудник = РабочееВремяРаботниковОрганизаций.Сотрудник
	|			И (РабочееВремяРаботниковОрганизаций.Соединяться)
	|			И СотрудникиТабеля.ИндексДня = РабочееВремяРаботниковОрганизаций.ИндексДня
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТГрафикиРаботыПоВидамВремени КАК ГрафикиРаботыПоВидамВремени
	|		ПО СотрудникиТабеля.Сотрудник = ГрафикиРаботыПоВидамВремени.ГрафикРаботы
	|			И СотрудникиТабеля.ИндексДня = ГрафикиРаботыПоВидамВремени.ИндексДня
	|ГДЕ
	|	(РабочееВремяРаботниковОрганизаций.НомерСтроки ЕСТЬ НЕ NULL 
	|			ИЛИ ГрафикиРаботыПоВидамВремени.ГрафикРаботы ЕСТЬ НЕ NULL )
	|	И (РабочееВремяРаботниковОрганизаций.Регистратор ЕСТЬ НЕ NULL 
	|			ИЛИ ГрафикиРаботыПоВидамВремени.Документ ЕСТЬ НЕ NULL )";*/
		}

		public void ПроведениеПоРегиструРасчетаДополнительно(/*Документ*/)
		{
		}

		public object ДополнитьТекстМакетаВстроеннойСправки(/**/)
		{
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции печати

		public object ДополнитьСтруктуруПечатныхФорм(/*СтруктураМакетов*/)
		{
			return null;
		}
		// Возвращает "длинное" описание печатной формы
		//
		// Параметры
		//  ИмяМакета - строка, идентификатор печатной формы
		//
		// Возвращаемое значение:
		//   строка
		//

		public object ПолучитьОписаниеПечатнойФормы(/*ИмяМакета*/)
		{
			if(true/*ИмяМакета = "Т13"*/)
			{
			}
			return null;
		}
		// ПолучитьОписаниеПечатнойФормы()
		// Для переданного документа формирует указанную печатную форму
		//
		// Параметры
		//  ИмяМакета - строка, идентификатор печатной формы
		//
		// Возвращаемое значение:
		//   табличный документ или Неопределено
		//

		public object СформироватьПечатнуюФорму(/*ИмяМакета, ДокументОбъект, СписокСотрудников*/)
		{
			return null;
		}
		// СформироватьПечатнуюФорму()
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

		public object РежимПодбораСотрудников(/**/)
		{
			/*//	Режим 		- 0-всех, 1 - только по трудовым договорам, 2 - только договора ГПХ
*/
			/*//				- 3 - военнослужащих, 4 - госслужащих
*/
			//Режим = 1;
			return null;
		}

		public void ФормаДокументаПередОткрытиемДополнительно(/*Форма, ДополнительныеДействия*/)
		{
			//ТабельУчетаРабочегоВремениОрганизацииДополнительный.ФормаДокументаПередОткрытиемДополнительно(Форма, ДополнительныеДействия);
		}
		// ФормаДокументаПередОткрытиемДополнительно

		public void ФормаДокументаВыполнитьДополнительныеДействия(/*Форма, Элемент*/)
		{
			//ТабельУчетаРабочегоВремениОрганизацииДополнительный.ФормаДокументаВыполнитьДополнительныеДействия(Форма, Элемент);
		}
		// ФормаДокументаВыполнитьДополнительныеДействия
	}
}
