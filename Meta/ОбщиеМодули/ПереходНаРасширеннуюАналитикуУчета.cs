﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПереходНаРасширеннуюАналитикуУчета
	{

		public object РазделыУчета(/**/)
		{
			//РазделыУчета = Новый Массив();
			//РазделыУчета.Добавить("НезавершенноеПроизводство");
			//РазделыУчета.Добавить("БракВПроизводстве");
			//РазделыУчета.Добавить("ЗатратыНаВыпускПродукции");
			//РазделыУчета.Добавить("Затраты");
			//РазделыУчета.Добавить("ПартииТоваров");
			//РазделыУчета.Добавить("МатериалыВЭксплуатации");
			return null;
		}

		public object ПолучитьИсточникиДанных(/*РазделУчета, ВидОтраженияВУчете*/)
		{
			//ИсточникиДанных = Новый Массив();
			//ИсточникДанных  = Новый Структура("ТекстЗапроса, Комментарий");
			if(true/*РазделУчета = "ПартииТоваров"*/)
			{
				/*// Для этого раздела - два источника.
*/
				/*// Первый: 
*/
				//ИсточникДанных.ТекстЗапроса = ПолучитьЗапросПоРегиструПартииТоваровНаСкладах(ВидОтраженияВУчете);
				//ИсточникДанных.Комментарий  = "Партии товаров на складах";
				//ИсточникиДанных.Добавить(ИсточникДанных);
				/*// Второй:
*/
				//ИсточникДанных  = Новый Структура("ТекстЗапроса, Комментарий");
				//ИсточникДанных.ТекстЗапроса = ПолучитьЗапросПоРегиструПартииТоваровПереданные(ВидОтраженияВУчете);
				//ИсточникДанных.Комментарий  = "Партии товаров переданных";
				/*// Второй источник добавляется в массив в конце функции.
*/
				/*// Для остальных разделов - по одному источнику данных.
*/
			}
			//ИсточникиДанных.Добавить(ИсточникДанных);
			return null;
		}

		public object НетОстатковПоРазделуУчета(/*РазделУчета,ВидОтраженияВУчете,ДатаОстатков*/)
		{
			//Запрос = Новый Запрос();
			//Запрос.УстановитьПараметр("ПериодКонец",ДатаОстатков);
			//Запрос.УстановитьПараметр("ГраницаПериода",Новый Граница(ДатаОстатков,ВидГраницы.Включая));
			//НетОстатков = Истина;
			return null;
		}
		///////////////////////////////////////////////////////////////////////////////////////////
		//ФУНКЦИИ ПОЛУЧЕНИЯ ЗАПРОСОВ ПО РЕГИСТРАМ, ДЛЯ ПЕРЕНОСА ОСТАТКОВ В ПОДСИСТЕМУ РАСШИРЕННОЙ АНАЛИТИКИ
		// Функция формирует текст запроса по регистру "Незавершенное производство".
		//
		// Параметры:
		//	ВидОтраженияВУчете - ПеречислениеСсылка.ВидыОтраженияВУчете - Вид отражения в учете
		//
		// Возвращаемое значение:
		//	Строка - Текст запроса
		//

		public object ПолучитьЗапросПоРегиструНезавершенноеПроизводство(/*ВидОтраженияВУчете*/)
		{
			/*//Перечисления.РазделыУчета.Затраты
*/
			/*ТекстЗапроса = "
	|ВЫБРАТЬ
	|	*,
	|	ЗНАЧЕНИЕ(Перечисление.РазделыУчета.Затраты) КАК РазделУчета,
	|	//ДляУпрУчета Подразделение КАК Подразделение,
	|	//ДляБухУчета Подразделение КАК ПодразделениеОрганизации,
	|	//ДляНалУчета Подразделение КАК ПодразделениеОрганизации,
	|
	|	ВЫБОР КОГДА Затрата ССЫЛКА Перечисление.ХарактерЗатрат ТОГДА
	|		Затрата
	|	ИНАЧЕ
	|	//ДляУпрУчета ЕСТЬNULL(СтатьяЗатрат.ХарактерЗатрат,Неопределено)
	|	//ДляБухУчета Неопределено
	|	//ДляНалУчета Неопределено
	|	КОНЕЦ КАК ХарактерЗатрат,
	|
	|	ВЫБОР КОГДА Затрата ССЫЛКА Справочник.СпособыРаспределенияЗатратНаВыпуск ТОГДА
	|		Затрата
	|	ИНАЧЕ
	|		Неопределено
	|	КОНЕЦ КАК СпособРаспределенияЗатрат,
	|
	|	&ПериодКонец КАК Период,
	|	Неопределено КАК КодОперации,
	|
	|	//ДляНалУчета ПостояннаяРазницаОстаток КАК ПостояннаяРазница,
	|	//ДляНалУчета ВременнаяРазницаОстаток КАК ВременнаяРазница,
	|	//ДляНалУчета КоличествоОстаток КАК КоличествоНУ,
	|	//ДляНалУчета СтоимостьОстаток КАК СтоимостьНУ
	|	//ДляУпрУчета КоличествоОстаток КАК Количество,
	|	//ДляУпрУчета СтоимостьОстаток КАК Стоимость
	|	//ДляБухУчета КоличествоОстаток КАК Количество,
	|	//ДляБухУчета СтоимостьОстаток КАК Стоимость	
	|ИЗ
	|	РегистрНакопления.НезавершенноеПроизводство%СуффиксУчета%.Остатки(&ГраницаПериода,) КАК НезавершенноеПроизводство
	|";*/
			//ТекстЗапроса = УправлениеЗатратами.ЗаменитьКомментарииВТекстеЗапроса(ТекстЗапроса, ВидОтраженияВУчете);
			return null;
		}
		// ПолучитьЗапросПоРегиструНезавершенноеПроизводство()
		// Функция формирует текст запроса по регистру "Затраты".
		//
		// Параметры:
		//	ВидОтраженияВУчете - ПеречислениеСсылка.ВидыОтраженияВУчете - Вид отражения в учете
		//
		// Возвращаемое значение:
		//	Строка - Текст запроса
		//

		public object ПолучитьЗапросПоРегиструЗатраты(/*ВидОтраженияВУчете*/)
		{
			/*ТекстЗапроса = "
	|ВЫБРАТЬ
	|	*,
	|	ЗНАЧЕНИЕ(Перечисление.РазделыУчета.Затраты) КАК РазделУчета,
	|	//ДляУпрУчета Подразделение КАК Подразделение,
	|	//ДляБухУчета Подразделение КАК ПодразделениеОрганизации,
	|	//ДляНалУчета Подразделение КАК ПодразделениеОрганизации,
	|
	|	//ДляУпрУчета ЕСТЬNULL(СтатьяЗатрат.ХарактерЗатрат,Неопределено) КАК ХарактерЗатрат,
	|
	|	&ПериодКонец КАК Период,
	|	Неопределено КАК КодОперации,
	|
	|	//ДляНалУчета ПостояннаяРазницаОстаток КАК ПостояннаяРазница,
	|	//ДляНалУчета ВременнаяРазницаОстаток КАК ВременнаяРазница,
	|	//ДляНалУчета СуммаОстаток КАК СтоимостьНУ
	|	//ДляУпрУчета СуммаОстаток КАК Стоимость
	|	//ДляБухУчета СуммаОстаток КАК Стоимость	
	|ИЗ
	|	РегистрНакопления.Затраты%СуффиксУчета%.Остатки(&ГраницаПериода,) КАК Затраты
	|";*/
			//ТекстЗапроса = УправлениеЗатратами.ЗаменитьКомментарииВТекстеЗапроса(ТекстЗапроса, ВидОтраженияВУчете);
			return null;
		}
		// ПолучитьЗапросПоРегиструЗатраты()
		// Функция формирует текст запроса по регистру "Брак в производстве".
		//
		// Параметры:
		//	ВидОтраженияВУчете - ПеречислениеСсылка.ВидыОтраженияВУчете - Вид отражения в учете
		//
		// Возвращаемое значение:
		//	Строка - Текст запроса
		//

		public object ПолучитьЗапросПоРегиструБракВПроизводстве(/*ВидОтраженияВУчете*/)
		{
			/*ТекстЗапроса = "
	|ВЫБРАТЬ
	|	*,
	|	ЗНАЧЕНИЕ(Перечисление.РазделыУчета.Затраты) КАК РазделУчета,
	|	//ДляУпрУчета Подразделение КАК Подразделение,
	|	//ДляБухУчета Подразделение КАК ПодразделениеОрганизации,
	|	//ДляНалУчета Подразделение КАК ПодразделениеОрганизации,
	|
	|	//ДляУпрУчета ЕСТЬNULL(СтатьяЗатрат.ХарактерЗатрат,Неопределено) КАК ХарактерЗатрат,
	|
	|	&ПериодКонец КАК Период,
	|	Неопределено КАК КодОперации,
	|
	|	//ДляНалУчета ПостояннаяРазницаОстаток КАК ПостояннаяРазница,
	|	//ДляНалУчета ВременнаяРазницаОстаток КАК ВременнаяРазница,
	|	//ДляНалУчета СуммаОстаток КАК СтоимостьНУ
	|	//ДляУпрУчета СуммаОстаток КАК Стоимость
	|	//ДляБухУчета СуммаОстаток КАК Стоимость	
	|ИЗ
	|	РегистрНакопления.БракВПроизводстве%СуффиксУчета%.Остатки(&ГраницаПериода,) КАК БракВПроизводстве
	|";*/
			//ТекстЗапроса = УправлениеЗатратами.ЗаменитьКомментарииВТекстеЗапроса(ТекстЗапроса, ВидОтраженияВУчете);
			return null;
		}
		// ПолучитьЗапросПоРегиструБракВПроизводстве()
		// Функция формирует текст запроса по регистру "Выпуск продукции (наработка)".
		//
		// Параметры:
		//	ВидОтраженияВУчете - ПеречислениеСсылка.ВидыОтраженияВУчете - Вид отражения в учете
		//
		// Возвращаемое значение:
		//	Строка - Текст запроса
		//

		public object ПолучитьЗапросПоРегиструЗатратыНаВыпускПродукцииНаработка(/*ВидОтраженияВУчете*/)
		{
			/*ТекстЗапроса = "
	|ВЫБРАТЬ
	|	*,
	|	ЗНАЧЕНИЕ(Перечисление.РазделыУчета.ЗатратыПоНаработке) КАК РазделУчета,
	|	//ДляУпрУчета Подразделение КАК Подразделение,
	|	//ДляБухУчета Подразделение КАК ПодразделениеОрганизации,
	|	//ДляНалУчета Подразделение КАК ПодразделениеОрганизации,
	|
	|	//ДляУпрУчета ЕСТЬNULL(СтатьяЗатрат.ХарактерЗатрат,Неопределено) КАК ХарактерЗатрат,
	|
	|	&ПериодКонец КАК Период,
	|	Неопределено КАК КодОперации,
	|
	|	//ДляНалУчета КоличествоОстаток КАК КоличествоНУ
	|	//ДляУпрУчета КоличествоОстаток КАК Количество
	|	//ДляБухУчета КоличествоОстаток КАК Количество
	|ИЗ
	|	РегистрНакопления.ЗатратыНаВыпускПродукцииНаработка%СуффиксУчета%.Остатки(&ГраницаПериода,) КАК ЗатратыНаВыпускПродукцииНаработка
	|";*/
			//ТекстЗапроса = УправлениеЗатратами.ЗаменитьКомментарииВТекстеЗапроса(ТекстЗапроса, ВидОтраженияВУчете);
			return null;
		}
		// ПолучитьЗапросПоРегиструЗатратыНаВыпускПродукцииНаработка()
		// Функция формирует текст запроса по регистру "Партии товаров на складах".
		//
		// Параметры:
		//	ВидОтраженияВУчете - ПеречислениеСсылка.ВидыОтраженияВУчете - Вид отражения в учете
		//
		// Возвращаемое значение:
		//	Строка - Текст запроса
		//

		public object ПолучитьЗапросПоРегиструПартииТоваровНаСкладах(/*ВидОтраженияВУчете*/)
		{
			/*ТекстЗапроса = "
	|ВЫБРАТЬ
	|	Номенклатура КАК Затрата,
	|	Склад КАК Склад,
	|	ХарактеристикаНоменклатуры КАК ХарактеристикаЗатраты,
	|	СерияНоменклатуры КАК СерияЗатраты,
	|	//ДляУпрУчета ВЫБОР КОГДА (СтатусПартии = ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.Продукция))
	|	//ДляУпрУчета 			ИЛИ (СтатусПартии = ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.Оборудование))
	|	//ДляУпрУчета 			ИЛИ (СтатусПартии = ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.КупленныйОтложеннаяОтгрузка)) ТОГДА
	|	//ДляУпрУчета 	ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.Купленный)
	|	//ДляУпрУчета ИНАЧЕ 
	|	//ДляУпрУчета 	ВЫБОР КОГДА СтатусПартии = ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.ВозвратнаяТараОтложеннаяОтгрузка) ТОГДА
	|	//ДляУпрУчета 		ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.ВозвратнаяТара)
	|	//ДляУпрУчета 	ИНАЧЕ
	|	//ДляУпрУчета 		СтатусПартии 
	|	//ДляУпрУчета 	КОНЕЦ
	|	//ДляУпрУчета КОНЕЦ КАК СтатусПартии,
	|	//ДляБухУчета СчетУчета КАК СчетУчета,
	|	//ДляНалУчета СчетУчета КАК СчетУчетаНУ,
	|	Заказ КАК Заказ,
	|	Качество КАК Качество,
	|	Организация КАК Организация,
	|	ЗНАЧЕНИЕ(Перечисление.РазделыУчета.МПЗ) КАК РазделУчета,
	|
	|	&ПериодКонец КАК Период,
	|	Неопределено КАК КодОперации,
	|
	|	//ДляНалУчета ПостояннаяРазницаОстаток КАК ПостояннаяРазница,
	|	//ДляНалУчета ВременнаяРазницаОстаток КАК ВременнаяРазница,
	|	//ДляНалУчета КоличествоОстаток КАК КоличествоНУ,
	|	//ДляНалУчета СтоимостьОстаток КАК СтоимостьНУ
	|	//ДляУпрУчета КоличествоОстаток КАК Количество,
	|	//ДляУпрУчета СтоимостьОстаток КАК Стоимость
	|	//ДляБухУчета КоличествоОстаток КАК Количество,
	|	//ДляБухУчета СтоимостьОстаток КАК Стоимость	
	|ИЗ
	|	РегистрНакопления.ПартииТоваровНаСкладах%СуффиксУчета%.Остатки(&ГраницаПериода,
	|	//ДляУпрУчета (СтатусПартии	<> ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.НаКомиссию)) 
	|	//ДляУпрУчета   И  (СтатусПартии <> ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.ВПереработку))
	|	//ДляУпрУчета   И  (СтатусПартии <> ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.ПоОрдеру))
	|	//ДляБухУчета (НЕ СчетУчета В ИЕРАРХИИ (ЗНАЧЕНИЕ(ПланСчетов.Хозрасчетный.ТоварыПринятыеНаКомиссию)))
	|	//ДляБухУчета   И (НЕ СчетУчета В ИЕРАРХИИ (ЗНАЧЕНИЕ(ПланСчетов.Хозрасчетный.МатериалыПринятыеВПереработку)))
	|	//ДляНалУчета (НЕ СчетУчета В ИЕРАРХИИ (ЗНАЧЕНИЕ(ПланСчетов.Налоговый.ТоварыПринятыеНаКомиссию)))
	|	//ДляНалУчета И (НЕ СчетУчета ССЫЛКА ПланСчетов.Хозрасчетный)
	|	) КАК ПартииТоваровНаСкладах
	|";*/
			//ТекстЗапроса = УправлениеЗатратами.ЗаменитьКомментарииВТекстеЗапроса(ТекстЗапроса, ВидОтраженияВУчете);
			return null;
		}
		// ПолучитьЗапросПоРегиструПартииТоваровНаСкладах()
		// Функция формирует текст запроса по регистру "Партии товаров переданные".
		//
		// Параметры:
		//	ВидОтраженияВУчете - ПеречислениеСсылка.ВидыОтраженияВУчете - Вид отражения в учете
		//
		// Возвращаемое значение:
		//	Строка - Текст запроса
		//

		public object ПолучитьЗапросПоРегиструПартииТоваровПереданные(/*ВидОтраженияВУчете*/)
		{
			/*ТекстЗапроса = "
	|ВЫБРАТЬ
	|	Номенклатура КАК Затрата,
	|	ДоговорКонтрагента КАК ДоговорКомиссионера,
	|	ДоговорКонтрагента.Владелец КАК Комиссионер,
	|	ХарактеристикаНоменклатуры КАК ХарактеристикаЗатраты,
	|	//ДляУпрУчета СтатусПартии КАК СтатусПартии,
	|	//ДляБухУчета СчетУчета КАК СчетУчета,
	|	//ДляНалУчета СчетУчета КАК СчетУчетаНУ,
	|	Организация КАК Организация,
	|	ЗНАЧЕНИЕ(Перечисление.РазделыУчета.ТоварыОтгруженные) КАК РазделУчета,
	|
	|	&ПериодКонец КАК Период,
	|	Неопределено КАК КодОперации,
	|
	|	//ДляНалУчета ПостояннаяРазницаОстаток КАК ПостояннаяРазница,
	|	//ДляНалУчета ВременнаяРазницаОстаток КАК ВременнаяРазница,
	|	//ДляНалУчета КоличествоОстаток КАК КоличествоНУ,
	|	//ДляНалУчета СтоимостьОстаток КАК СтоимостьНУ
	|	//ДляУпрУчета КоличествоОстаток КАК Количество,
	|	//ДляУпрУчета СтоимостьОстаток КАК Стоимость
	|	//ДляБухУчета КоличествоОстаток КАК Количество,
	|	//ДляБухУчета СтоимостьОстаток КАК Стоимость	
	|ИЗ
	|	РегистрНакопления.ПартииТоваровПереданные%СуффиксУчета%.Остатки(&ГраницаПериода,
	|	//ДляУпрУчета (СтатусПартии	<> ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.НаКомиссию)) 
	|	//ДляУпрУчета   И  (СтатусПартии <> ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.ВПереработку))
	|	//ДляУпрУчета   И  (СтатусПартии <> ЗНАЧЕНИЕ(Перечисление.СтатусыПартийТоваров.ПоОрдеру))
	|	//ДляБухУчета (НЕ СчетУчета В ИЕРАРХИИ (ЗНАЧЕНИЕ(ПланСчетов.Хозрасчетный.ТоварыПринятыеНаКомиссию)))
	|	//ДляБухУчета   И (НЕ СчетУчета В ИЕРАРХИИ (ЗНАЧЕНИЕ(ПланСчетов.Хозрасчетный.МатериалыПринятыеВПереработку)))
	|	//ДляНалУчета (НЕ СчетУчета В ИЕРАРХИИ (ЗНАЧЕНИЕ(ПланСчетов.Налоговый.ТоварыПринятыеНаКомиссию)))
	|	//ДляНалУчета И (НЕ СчетУчета ССЫЛКА ПланСчетов.Хозрасчетный)
	|	) КАК ПартииТоваровПереданные
	|";*/
			//ТекстЗапроса = УправлениеЗатратами.ЗаменитьКомментарииВТекстеЗапроса(ТекстЗапроса, ВидОтраженияВУчете);
			return null;
		}
		// ПолучитьЗапросПоРегиструПартииТоваровПереданные()
		// Функция формирует текст запроса по регистру "Партии материалов в эксплуатации".
		//
		// Параметры:
		//	ВидОтраженияВУчете - ПеречислениеСсылка.ВидыОтраженияВУчете - Вид отражения в учете
		//
		// Возвращаемое значение:
		//	Строка - Текст запроса
		//

		public object ПолучитьЗапросПоРегиструПартииМатериаловВЭксплуатации(/*ВидОтраженияВУчете*/)
		{
			/*ТекстЗапроса = "
	|ВЫБРАТЬ
	|	//ДляБухУчета Организация КАК Организация,
	|	//ДляНалУчета Организация КАК Организация,
	|	Номенклатура КАК Затрата,
	|	ХарактеристикаНоменклатуры КАК ХарактеристикаЗатраты,
	|	СерияНоменклатуры КАК СерияЗатраты,
	|	//ДляУпрУчета Подразделение КАК Подразделение,
	|	//ДляБухУчета Подразделение КАК ПодразделениеОрганизации,
	|	//ДляНалУчета Подразделение КАК ПодразделениеОрганизации,
	|	//ДляБухУчета СчетУчета КАК СчетУчета,
	|	//ДляНалУчета СчетУчета КАК СчетУчетаНУ,
	|	ДокументПередачи КАК ДокументПередачи,
	|	ФизЛицо КАК ФизЛицо,
	|	НазначениеИспользования КАК НазначениеИспользования,
	|	ЗНАЧЕНИЕ(Перечисление.РазделыУчета.МатериалыВЭксплуатации) КАК РазделУчета,
	|
	|	&ПериодКонец КАК Период,
	|	Неопределено КАК КодОперации,
	|
	|	//ДляНалУчета ВЫБОР КОГДА НазначениеИспользования.СпособПогашенияСтоимости = ЗНАЧЕНИЕ(Перечисление.СпособыПогашенияСтоимости.Линейный)
	|	//ДляНалУчета ТОГДА ПостояннаяРазницаОстаток
	|	//ДляНалУчета ИНАЧЕ 0
	|	//ДляНалУчета КОНЕЦ КАК ПостояннаяРазница,
	|	//ДляНалУчета ВЫБОР КОГДА НазначениеИспользования.СпособПогашенияСтоимости = ЗНАЧЕНИЕ(Перечисление.СпособыПогашенияСтоимости.Линейный)
	|	//ДляНалУчета ТОГДА ВременнаяРазницаОстаток
	|	//ДляНалУчета ИНАЧЕ 0
	|	//ДляНалУчета КОНЕЦ КАК ВременнаяРазница,
	|	//ДляНалУчета КоличествоОстаток КАК КоличествоНУ,
	|	//ДляНалУчета ВЫБОР КОГДА НазначениеИспользования.СпособПогашенияСтоимости = ЗНАЧЕНИЕ(Перечисление.СпособыПогашенияСтоимости.Линейный)
	|	//ДляНалУчета ТОГДА СтоимостьОстаток
	|	//ДляНалУчета ИНАЧЕ 0
	|	//ДляНалУчета КОНЕЦ КАК СтоимостьНУ
	|	//ДляУпрУчета КоличествоОстаток КАК Количество,
	|	//ДляУпрУчета ВЫБОР КОГДА НазначениеИспользования.СпособПогашенияСтоимости = ЗНАЧЕНИЕ(Перечисление.СпособыПогашенияСтоимости.Линейный)
	|	//ДляУпрУчета ТОГДА СтоимостьОстаток
	|	//ДляУпрУчета ИНАЧЕ 0
	|	//ДляУпрУчета КОНЕЦ КАК Стоимость
	|	//ДляБухУчета КоличествоОстаток КАК Количество,
	|	//ДляБухУчета ВЫБОР КОГДА НазначениеИспользования.СпособПогашенияСтоимости = ЗНАЧЕНИЕ(Перечисление.СпособыПогашенияСтоимости.Линейный)
	|	//ДляБухУчета ТОГДА СтоимостьОстаток
	|	//ДляБухУчета ИНАЧЕ 0
	|	//ДляБухУчета КОНЕЦ КАК Стоимость	
	|ИЗ
	|	РегистрНакопления.ПартииМатериаловВЭксплуатации%СуффиксУчета%.Остатки(&ГраницаПериода,) КАК ПартииМатериаловВЭксплуатации
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	//ДляБухУчета Организация КАК Организация,
	|	//ДляНалУчета Организация КАК Организация,
	|	Номенклатура КАК Затрата,
	|	ХарактеристикаНоменклатуры КАК ХарактеристикаЗатраты,
	|	СерияНоменклатуры КАК СерияЗатраты,
	|	//ДляУпрУчета Подразделение КАК Подразделение,
	|	//ДляБухУчета Подразделение КАК ПодразделениеОрганизации,
	|	//ДляНалУчета Подразделение КАК ПодразделениеОрганизации,
	|	//ДляБухУчета СчетУчета КАК СчетУчета,
	|	//ДляНалУчета СчетУчета КАК СчетУчетаНУ,
	|	ДокументПередачи КАК ДокументПередачи,
	|	ФизЛицо КАК ФизЛицо,
	|	НазначениеИспользования КАК НазначениеИспользования,
	|	ЗНАЧЕНИЕ(Перечисление.РазделыУчета.ПогашеннаяСтоимость) КАК РазделУчета,
	|
	|	&ПериодКонец КАК Период,
	|	Неопределено КАК КодОперации,
	|
	|	//ДляНалУчета 0 - ПогашеннаяСтоимостьПРОстаток КАК ПостояннаяРазница,
	|	//ДляНалУчета 0 - ПогашеннаяСтоимостьВРОстаток КАК ВременнаяРазница,
	|	//ДляНалУчета 0 КАК КоличествоНУ,
	|	//ДляНалУчета 0 КАК СтоимостьНУ
	|	//ДляУпрУчета 0 КАК Количество,
	|	//ДляУпрУчета 0 - ПогашеннаяСтоимостьОстаток КАК Стоимость
	|	//ДляБухУчета 0 КАК Количество,
	|	//ДляБухУчета 0 - ПогашеннаяСтоимостьОстаток КАК Стоимость	
	|ИЗ
	|	РегистрНакопления.ПартииМатериаловВЭксплуатации%СуффиксУчета%.Остатки(&ГраницаПериода, НазначениеИспользования.СпособПогашенияСтоимости = ЗНАЧЕНИЕ(Перечисление.СпособыПогашенияСтоимости.Линейный)) КАК ПартииМатериаловВЭксплуатации
	|";*/
			//ТекстЗапроса = УправлениеЗатратами.ЗаменитьКомментарииВТекстеЗапроса(ТекстЗапроса, ВидОтраженияВУчете);
			return null;
		}
		// ПолучитьЗапросПоРегиструПартииМатериаловВЭксплуатации()
		///////////////////////////////////////////////////////////////////////////////////////////
		//ПРОЦЕДУРЫ ФОРМИРОВАНИЯ ОСТАТКОВ

		public object ПолучитьТаблицуСоответствияСчетовНУиБУ(/*ДатаОстатков*/)
		{
			/*Запрос = Новый Запрос("ВЫБРАТЬ РАЗЛИЧНЫЕ
	                      |	СоответствиеСчетовБУиНУСрезПоследних.СчетНУ,
	                      |	СоответствиеСчетовБУиНУСрезПоследних.СчетБУ
	                      |ИЗ
	                      |	РегистрСведений.СоответствиеСчетовБУиНУ.СрезПоследних(&ДатаОстатков, ) КАК СоответствиеСчетовБУиНУСрезПоследних
	                      |ГДЕ
	                      |	(НЕ СоответствиеСчетовБУиНУСрезПоследних.СчетНУ.ЗапретитьИспользоватьВПроводках)
	                      |	И (НЕ СоответствиеСчетовБУиНУСрезПоследних.СчетБУ.ЗапретитьИспользоватьВПроводках)
	                      |
	                      |СГРУППИРОВАТЬ ПО
	                      |	СоответствиеСчетовБУиНУСрезПоследних.СчетНУ,
	                      |	СоответствиеСчетовБУиНУСрезПоследних.СчетБУ");*/
			//Запрос.УстановитьПараметр("ДатаОстатков",ДатаОстатков);
			//ТаблицаСоответствия = Запрос.Выполнить().Выгрузить();
			//ТаблицаСоответствия.Индексы.Добавить("СчетНУ");
			return null;
		}
		// Возвращает структуру для формирования ключа аналитики учета затрат. Дополняет исходную структуру полем ХарактерЗатрат
		//

		public object ПолучитьСтруктуруДляФормированияКлючаАналитикиУчетаЗатрат(/*ВидОтраженияВУчете, Колонки, Выборка*/)
		{
			//СтруктураДляФормированияКлючаУчетаАналитикиЗатрат = Новый Структура();
			if(true/*Колонки.Найти("СтатьяЗатрат") <> Неопределено*/)
			{
				if(true/*(Колонки.Найти("ХарактерЗатрат") = Неопределено)
		  ИЛИ (НЕ ЗначениеЗаполнено(Выборка.ХарактерЗатрат))*/)
				{
					if(true/*ВидОтраженияВУчете = Перечисления.ВидыОтраженияВУчете.ОтражатьВУправленческомУчете*/)
					{
						if(true/*ЗначениеЗаполнено(Выборка.СтатьяЗатрат)*/)
						{
							//СтруктураДляФормированияКлючаУчетаАналитикиЗатрат.Вставить("ХарактерЗатрат",Выборка.СтатьяЗатрат.ХарактерЗатрат);
						}
					}
				}
			}
			return null;
		}
		// Возвращает структуру для формирования ключа аналитики вида учета. Дополняет исходную структуру полем СчетУчетаНУ
		//

		public object ПолучитьСтруктуруДляФормированияКлючаАналитикиВидаУчета(/*ВидОтраженияВУчете, Колонки, Выборка, ТаблицаСоответствияСчетовНУиБУ*/)
		{
			//СтруктураДляФормированияКлючаАналитикиВидаУчета = Новый Структура();
			if(true/*ВидОтраженияВУчете = Перечисления.ВидыОтраженияВУчете.ОтражатьВНалоговомУчете*/)
			{
				if(true/*Колонки.Найти("СчетУчета") <> Неопределено 
		  И ТипЗНЧ(Выборка.СчетУчета) = Тип("ПланСчетовСсылка.Налоговый")
		  И ЗначениеЗаполнено(Выборка.СчетУчета)*/)
				{
					//СтруктураДляФормированияКлючаАналитикиВидаУчета.Вставить("СчетУчетаНУ",Выборка.СчетУчета);
					//СтруктураДляФормированияКлючаАналитикиВидаУчета.СчетУчета = РасширеннаяАналитикаУчета.ПолучитьСчетБУПоСчетуНУ(Выборка.СчетУчета,ТаблицаСоответствияСчетовНУиБУ);
				}
			}
			return null;
		}
		// Процедура ввода остатков по регистрам "Учет затрат" и "Учет затрат (бухгалтерский и налоговый учет)".
		// Используется при включении использования расширенной аналитики учета из обработки настройки параметров учета (начиная с версии 1.2.15).
		//
		// Параметры:
		//	Запрос - Запрос - Запрос по остаткам
		//	ДатаДокумента - Дата - Дата документа ввода остатков
		//	ВидОтраженияВУчете - ПеречислениеСсылка.ВидыОтраженияВУчете - Вид отражения в учете
		//	ТекстДляКомментария - Строка - Комментарий документа
		//

		public void СформироватьДвиженияПоРегиструУчетЗатратПоРазделуУчета(/*Запрос, ДатаДокумента, ВидОтраженияВУчете, ТекстДляКомментария, ТаблицаСоответствияСчетовНУиБУ*/)
		{
			if(true/*ВидОтраженияВУчете = Перечисления.ВидыОтраженияВУчете.ОтражатьВУправленческомУчете*/)
			{
				//ИмяРегистра = "УчетЗатрат";
				//ПредставлениеРегистра = "Учет затрат (управленческий учет)";
				//ПредставлениеВидаУчета = "управленческий учет";
			}
			//Результат = Запрос.Выполнить();
			if(true/*НЕ Результат.Пустой()*/)
			{
				//ДокументКорректировкиЗаписейРегистров = Документы.КорректировкаЗаписейРегистров.СоздатьДокумент();
				//ДокументКорректировкиЗаписейРегистров.Дата = ДатаДокумента;
				/*// Заполнить реквизиты значениями по умолчанию.
*/
				//ЗаполнениеДокументов.ЗаполнитьШапкуДокумента(ДокументКорректировкиЗаписейРегистров);
				//ДокументКорректировкиЗаписейРегистров.Комментарий = "Ввод остатков по регистру """ + ПредставлениеРегистра + """ на основании данных регистра """ + ТекстДляКомментария + " (" + ПредставлениеВидаУчета + ")""";
				//НоваяСтрока = ДокументКорректировкиЗаписейРегистров.ТаблицаРегистровНакопления.Добавить();
				//НоваяСтрока.Имя = ИмяРегистра;
				//НоваяСтрока.Представление = ПредставлениеРегистра;
				//ДокументКорректировкиЗаписейРегистров.Записать();
				//НачатьТранзакцию();
				//НаборЗаписей = ДокументКорректировкиЗаписейРегистров.Движения[ИмяРегистра];
				//СтруктураКлючиАналитики = Новый Структура();
				//СтруктураШапкиДокумента = Новый Структура();
				//СтруктураШапкиДокумента.Вставить("Дата", ДатаДокумента);
				//СтруктураШапкиДокумента.Вставить("Ссылка", ДокументКорректировкиЗаписейРегистров.Ссылка);
				//СтруктураШапкиДокумента.Вставить("ПоддержкаПБУ18", Истина);
				//Выборка = Результат.Выбрать();
				while(true/*Выборка.Следующий()*/)
				{
					//СтруктураДляФормированияКлючаАналитикиВидаУчета = ПолучитьСтруктуруДляФормированияКлючаАналитикиВидаУчета(ВидОтраженияВУчете, Результат.Колонки, Выборка, ТаблицаСоответствияСчетовНУиБУ);
					/*//Для организаций на УСН в регистрах учета затрат не должен заполняться счет учета НУ
*/
					if(true/*ВидОтраженияВУчете = Перечисления.ВидыОтраженияВУчете.ОтражатьВБухгалтерскомУчете 
			  ИЛИ ВидОтраженияВУчете = Перечисления.ВидыОтраженияВУчете.ОтражатьВНалоговомУчете*/)
					{
						//УчетнаяПолитикаРегл = ОбщегоНазначения.ПолучитьПараметрыУчетнойПолитикиРегл(ДатаДокумента,СтруктураДляФормированияКлючаАналитикиВидаУчета.Организация);
						if(true/*ЗначениеЗаполнено(УчетнаяПолитикаРегл) И УчетнаяПолитикаРегл.СистемаНалогообложения = Перечисления.СистемыНалогообложения.Упрощенная*/)
						{
							//СтруктураШапкиДокумента.Вставить("ОтражатьВНалоговомУчете", Ложь);
						}
					}
					/*АналитикаВидаУчетаПолучатель = РасширеннаяАналитикаУчета.ПолучитьЗначениеКлючаАналитики(
				СтруктураШапкиДокумента,
				СтруктураДляФормированияКлючаАналитикиВидаУчета,
				Перечисления.КлючиАналитики.АналитикаВидаУчета,
				ВидОтраженияВУчете,
				СтруктураКлючиАналитики
			);*/
					//СтруктураДляФормированияКлючаУчетаАналитикиЗатрат = ПолучитьСтруктуруДляФормированияКлючаАналитикиУчетаЗатрат(ВидОтраженияВУчете, Результат.Колонки, Выборка);
					/*АналитикаУчетаЗатратПолучатель = РасширеннаяАналитикаУчета.ПолучитьЗначениеКлючаАналитики(
				СтруктураШапкиДокумента,
				СтруктураДляФормированияКлючаУчетаАналитикиЗатрат,
				Перечисления.КлючиАналитики.АналитикаУчетаЗатрат,
				ВидОтраженияВУчете,
				СтруктураКлючиАналитики
			);*/
					/*АналитикаУчетаПартийПолучатель = РасширеннаяАналитикаУчета.ПолучитьЗначениеКлючаАналитики(
				СтруктураШапкиДокумента,
				Выборка,
				Перечисления.КлючиАналитики.АналитикаУчетаПартий,
				ВидОтраженияВУчете,
				СтруктураКлючиАналитики
			);*/
					/*АналитикаРаспределенияЗатратПолучатель = РасширеннаяАналитикаУчета.ПолучитьЗначениеКлючаАналитики(
				СтруктураШапкиДокумента,
				Выборка,
				Перечисления.КлючиАналитики.АналитикаРаспределенияЗатрат,
				ВидОтраженияВУчете,
				СтруктураКлючиАналитики
			);*/
					//СтруктураСумм = Новый Структура("Количество, КоличествоНУ, Стоимость, СтоимостьНУ, ПостояннаяРазница, ВременнаяРазница",0,0,0,0,0,0);
					//ЗаполнитьЗначенияСвойств(СтруктураСумм,Выборка);
					/*// АналитикаВидаУчета
*/
					/*// АналитикаУчетаЗатрат
*/
					/*// АналитикаУчетаПартий
*/
					/*// АналитикаУчетаВыпуска
*/
					/*// КорАналитикаВидаУчета
*/
					/*// КорАналитикаУчетаЗатрат
*/
					/*// КорАналитикаУчетаПартий
*/
					/*// КорАналитикаУчетаВыпуска
*/
					/*ВидДвиженияНакопления.Приход,
				Неопределено,
				СтруктураСумм.Количество,
				СтруктураСумм.Стоимость,
				СтруктураСумм.КоличествоНУ,
				СтруктураСумм.СтоимостьНУ,
				СтруктураСумм.ПостояннаяРазница,
				НаборЗаписей
			);*/
				}
				if(true/*НаборЗаписей.Модифицированность()*/)
				{
					//НаборЗаписей.Записать(Ложь);
				}
				//ЗафиксироватьТранзакцию();
			}
		}
		// СформироватьДвиженияПоРегиструУчетЗатратПоРазделуУчета()
		// Процедура ввода остатков по регистрам "Учет затрат" и "Учет затрат (бухгалтерский и налоговый учет)".
		// Используется при включении использования расширенной аналитики учета из обработки настройки параметров учета (начиная с версии 1.2.15).
		//
		// Параметры:
		//	ДатаПереноса - Дата - Дата переноса остатков
		//	УправленческийУчет - Булево - Признак переноса остатков по управленческому учету
		//	БухгалтерскийУчет - Булево - Признак переноса остатков по бухгалтерскому учету
		//	НалоговыйУчет - Булево - Признак переноса остатков по налоговому учету
		//	РазделыУчета - СписокЗначений - Имена разделов, по которым формировать остатки.
		//                 Список разделов - см. в РазделыУчета()
		//

		public void СформироватьОстаткиПоРегистрамУчетЗатратИУчетЗатратРегл(/*
	ДатаПереноса,
	УправленческийУчет,
	БухгалтерскийУчет,
	НалоговыйУчет,
	РазделыУчета
	*/)
		{
			//МассивВидовУчета = Новый Массив();
			if(true/*УправленческийУчет*/)
			{
				//МассивВидовУчета.Добавить(Перечисления.ВидыОтраженияВУчете.ОтражатьВУправленческомУчете);
			}
			if(true/*БухгалтерскийУчет*/)
			{
				//МассивВидовУчета.Добавить(Перечисления.ВидыОтраженияВУчете.ОтражатьВБухгалтерскомУчете);
			}
			if(true/*НалоговыйУчет*/)
			{
				//МассивВидовУчета.Добавить(Перечисления.ВидыОтраженияВУчете.ОтражатьВНалоговомУчете);
			}
			//Запрос = Новый Запрос();
			//Запрос.УстановитьПараметр("ПериодКонец",ДатаПереноса);
			//Запрос.УстановитьПараметр("ГраницаПериода",Новый Граница(ДатаПереноса,ВидГраницы.Включая));
		}
	}
}
