﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class УправлениеОтчетамиПереопределяемый
	{

		public void УстановитьОтбор(/*Отчет, Поле, Значение*/)
		{
			if(true/*Отчет.ЗначенияНастроекПанелиПользователя = Неопределено*/)
			{
			}
			//ЗначениеПользовательскойНастройки = Отчет.ЗначенияНастроекПанелиПользователя.Получить();
			if(true/*ЗначениеПользовательскойНастройки = Неопределено*/)
			{
			}
			if(true/*ЗначениеПользовательскойНастройки.ДинамическиеОтборы.Получить(Поле) <> Неопределено*/)
			{
				if(true/*ТипЗнч(ЗначениеПользовательскойНастройки.ДинамическиеОтборы.Получить(Поле).Значение) <> Тип("СписокЗначений")*/)
				{
					//ЗначениеПользовательскойНастройки.ДинамическиеОтборы.Получить(Поле).Значение = Значение;
					//ЗначениеПользовательскойНастройки.ДинамическиеОтборы.Получить(Поле).Использование = истина;
				}
			}
			//Отчет.ЗначенияНастроекПанелиПользователя = Новый ХранилищеЗначения(ЗначениеПользовательскойНастройки);
		}
		// Открывает форму отчета "РасчетныеЛистки" с переданным параметром
		//
		// Параметры:
		//  ТекущиеДанные -  строка в форме списка регистра расчетов
		//  ИмяФормы - имя формы, из которой вызывается отчет
		//

		public void ВызовРасчетногоЛисткаИзФормыСпискаРР(/*ТекущиеДанные,ИмяФормы*/)
		{
			if(true/*ТекущиеДанные <> Неопределено*/)
			{
				if(true/*Найти(ИмяФормы,"Организаций") > 0*/)
				{
					//РасчетныйЛисток	= Отчеты.РасчетныеЛисткиОрганизаций.Создать();
					//РасчетныйЛисток.СохраненнаяНастройка = Справочники.СохраненныеНастройки.РасчетныеЛисткиОрганизаций;
					//РасчетныйЛисток.ПрименитьНастройку();
					//РасчетныйЛистокФорма = РасчетныйЛисток.ПолучитьФорму();
					//РасчетныйЛистокФорма.Открыть();
					if(true/*РасчетныйЛисток.ЗначенияНастроекПанелиПользователя = Неопределено*/)
					{
						if(true/*РасчетныйЛисток.ЗначенияНастроекПанелиПользователя.Получить().ДинамическиеОтборы.Количество() = 0*/)
						{
							//РасчетныйЛисток.ЗначенияНастроекПанелиПользователя = Новый ХранилищеЗначения(ТиповыеОтчеты.ПолучитьЗначенияНастроекПанелиПользователя(РасчетныйЛисток, РасчетныйЛистокФорма));
						}
					}
					//РасчетныйЛистокФорма.ЭтоОтработкаРасшифровки = истина;
					//УстановитьОтбор(РасчетныйЛисток, "Организация", ТекущиеДанные.ОбособленноеПодразделение);
				}
				//ЗначенияНастроекПанелиПользователя = РасчетныйЛисток.ЗначенияНастроекПанелиПользователя.Получить();
				//ЗначенияНастроекПанелиПользователя.СтандартныйПериод.ДатаНачала   = НачалоМесяца(ТекущиеДанные.ПериодРегистрации);
				//ЗначенияНастроекПанелиПользователя.СтандартныйПериод.ДатаОкончания = КонецМесяца(ТекущиеДанные.ПериодРегистрации);
				//РасчетныйЛисток.ЗначенияНастроекПанелиПользователя = Новый ХранилищеЗначения(ЗначенияНастроекПанелиПользователя);
				//ТиповыеОтчеты.УстановитьПараметр(РасчетныйЛисток.КомпоновщикНастроек,  "Группировать",  ложь);
				if(true/*Найти(ИмяФормы,"Удержания") > 0 или Найти(ИмяФормы,"Организаций") = 0*/)
				{
					//ТиповыеОтчеты.ДобавитьОтбор(РасчетныйЛисток.КомпоновщикНастроек, "ФизЛицо", ТекущиеДанные.ФизЛицо);
				}
				//ДокументРезультат = РасчетныйЛистокФорма.ЭлементыФормы.Результат;
				//РасчетныйЛистокФорма.ОбновлениеОтображения();
				//РасчетныйЛисток.СформироватьОтчет(ДокументРезультат);
			}
		}
		// ВызовРасчетногоЛисткаИзФормыСпискаРР()
		///////////////////////////////////////////////////////////////////////////////////
		// ФУНКЦИИ ОПРЕДЛЕНИЯ ОТЧЕТОВ УСТАНОВЛЕНЫХ НА ПОДДЕРЖКУ

		public void ИсполнениеКадровогоПланаПриСозданииОтчета(/*ОтчетОбъект*/)
		{
			//РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоЦентрамОтветственности*/)
			{
				//ОтчетОбъект.СхемаКомпоновкиДанных = ОтчетОбъект.ПолучитьМакет("ПоЦентрамОтветственности");
			}
		}
		// Процедура устанавливает параметр СКД отчета Вид договора соответсвующим списком значений видов трудовых договоров

		public void ОценкиКомпетенцийРаботниковДоработкаКомпоновщика(/*ОтчетОбъект*/)
		{
			//СписокЗначений = Новый СписокЗначений;
			//СписокЗначений.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ДоговорУправленческий);
			//СписокЗначений.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ТрудовойДоговор);
			//Параметр = ТиповыеОтчеты.УстановитьПараметр(ОтчетОбъект.КомпоновщикНастроек, "ВидДоговора", СписокЗначений);
			//Параметр.Использование = истина;
		}

		public void ОценкиКомпетенцийРаботниковПриСозданииОтчета(/*ОтчетОбъект*/)
		{
			/*ТЗ = "ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	РаботникиСрезПоследних.ФизЛицо КАК Измерение,
	|	РаботникиСрезПоследних.Подразделение КАК Подразделение,
	|	РаботникиСрезПоследних.Должность КАК Должность
	|ПОМЕСТИТЬ ПодразделениеДолжность
	|ИЗ
	|	РегистрСведений.Работники.СрезПоследних(&КонецПериода, ) КАК РаботникиСрезПоследних";*/
			/*СтрокаЗамены = "ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	"""" КАК Измерение,
	|	"""" КАК Подразделение,
	|	"""" КАК Должность
	|ПОМЕСТИТЬ ПодразделениеДолжность";*/
			//ОтчетОбъект.СхемаКомпоновкиДанных.НаборыДанных.ОценкиКомпетенцийРаботников.Запрос = СтрЗаменить(ОтчетОбъект.СхемаКомпоновкиДанных.НаборыДанных.ОценкиКомпетенцийРаботников.Запрос, СтрокаЗамены, ТЗ);
		}

		public void ПройденныеКурсыОбученияДоработкаКомпоновщика(/*ОтчетОбъект*/)
		{
			//СписокЗначений = Новый СписокЗначений;
			//СписокЗначений.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ТрудовойДоговор);
			//СписокЗначений.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ДоговорУправленческий);
			//Параметр = ТиповыеОтчеты.УстановитьПараметр(ОтчетОбъект.КомпоновщикНастроек, "ВидДоговора", СписокЗначений);
			//Параметр.Использование = истина;
		}

		public void РазвитиеКомпетенцийДоработкаКомпоновщика(/*ОтчетОбъект*/)
		{
			//СписокЗначений = Новый СписокЗначений;
			//СписокЗначений.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ТрудовойДоговор);
			//СписокЗначений.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ДоговорУправленческий);
			//Параметр = ТиповыеОтчеты.УстановитьПараметр(ОтчетОбъект.КомпоновщикНастроек, "ВидДоговора", СписокЗначений);
			//Параметр.Использование = истина;
		}

		public void ДобавитьУчетнуюПолитикуПОУСНДляРасчетаСреднесписочнойЧисленности(/*СхемаКомпоновкиДанных*/)
		{
			//СхемаКомпоновкиДанных.НаборыДанных.МесяцыУСН.Запрос = СтрЗаменить(СхемаКомпоновкиДанных.НаборыДанных.МесяцыУСН.Запрос, "ЛОЖЬ КАК УСН", "УчетнаяПолитикаНалоговыйУчет.УСН");
		}

		public void УстановитьСКДОтчетСостояниеКадровогоПлана(/*ОтчетОбъект*/)
		{
			if(true/*Константы.РежимНабораПерсонала.Получить() = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоЦентрамОтветственности*/)
			{
				//ОтчетОбъект.СхемаКомпоновкиДанных = ОтчетОбъект.ПолучитьМакет("ПоЦентрамОтветственности");
				//ОтчетОбъект.КомпоновщикНастроек.ЗагрузитьНастройки(ОтчетОбъект.СхемаКомпоновкиДанных.НастройкиПоУмолчанию);
			}
		}

		public object ДоступныеНастройкиДляСостоянияКадровогоПлана(/**/)
		{
			//ИспользоватьУправленческийУчетЗарплаты = Константы.РежимНабораПерсонала.Получить() = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоЦентрамОтветственности;
			//СписокНастроек = Новый СписокЗначений;
			if(true/*ИспользоватьУправленческийУчетЗарплаты*/)
			{
				//СписокНастроек.Добавить(Справочники.СохраненныеНастройки.СостояниеКадровогоПлана);
			}
			return null;
		}

		public object ПодставитьЗапросДляПолученияНалоговойПолитики(/*ТекстЗапроса*/)
		{
			/*ТекстЗамены = "ВЫБРАТЬ РАЗРЕШЕННЫЕ
	              |	ДАТАВРЕМЯ(1, 1, 1) КАК Период,
	              |	ЗНАЧЕНИЕ(Справочник.Организации.ПустаяСсылка) КАК Организация,
	              |	ЗНАЧЕНИЕ(Перечисление.ТарифыСтраховыхВзносов.ПустаяСсылка) КАК ВидТарифаСтраховыхВзносов,
	              |	ЛОЖЬ КАК УплачиватьДобровольныеВзносыВФСС
	              |ПОМЕСТИТЬ ВТНалоговыйУчет";*/
			/*ТекстНовый = "ВЫБРАТЬ РАЗРЕШЕННЫЕ
	             |	УчетнаяПолитикаНалоговыйУчет.Период,
	             |	УчетнаяПолитикаНалоговыйУчет.Организация,
	             |	УчетнаяПолитикаНалоговыйУчет.ВидТарифаСтраховыхВзносов КАК ВидТарифаСтраховыхВзносов,
	             |	УчетнаяПолитикаНалоговыйУчет.УплачиватьДобровольныеВзносыВФСС,
	             |	ЕСТЬNULL(ВЫБОР
	             |			КОГДА УчетнаяПолитикаНалоговыйУчет.СистемаНалогообложения = ЗНАЧЕНИЕ(Перечисление.СистемыНалогообложения.Упрощенная)
	             |				ТОГДА ИСТИНА
	             |			ИНАЧЕ ЛОЖЬ
	             |		КОНЕЦ, ЛОЖЬ) КАК УСН,
	             |	УчетнаяПолитикаНалоговыйУчет.ОрганизацияЯвляетсяПлательщикомЕНВД
	             |ПОМЕСТИТЬ ВТНалоговыйУчет
	             |ИЗ
	             |	РегистрСведений.УчетнаяПолитикаОрганизаций КАК УчетнаяПолитикаНалоговыйУчет";*/
			return null;
		}

		public void НастроитьТипИДоступностьПолейОтчетаПоЗаявкамКандидатов(/*СхемаКомпоновкиДанных*/)
		{
			//РежимНабораПерсонала = Константы.РежимНабораПерсонала.Получить();
			//МассивТипов = Новый Массив;
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				//ПолеНабора = СхемаКомпоновкиДанных.НаборыДанных.ЗаявкиСоискателей.Поля.Найти("Организация");
				//ПолеНабора.ОграничениеИспользования.Группировка = Истина;
				//ПолеНабора.ОграничениеИспользования.Поле        = Истина;
				//ПолеНабора.ОграничениеИспользования.Порядок     = Истина;
				//ПолеНабора.ОграничениеИспользования.Условие     = Истина;
				//МассивТипов.Добавить(Тип("СправочникСсылка.ПодразделенияОрганизаций"));
			}
			//ПолеНабора = СхемаКомпоновкиДанных.НаборыДанных.ЗаявкиСоискателей.Поля.Найти("Подразделение");
			//ОписаниеТипаПодразделения = Новый ОписаниеТипов(МассивТипов);
			//ПолеНабора.ТипЗначения = ОписаниеТипаПодразделения;
		}

		public void НастроитьДоступностьВариантовОтчетаПоЗаявкамКандидатов(/*СхемаКомпоновкиДанных, СтруктураНаcтроек*/)
		{
			//СписокПолейПодстановкиОтборовПоУмолчанию = Новый Соответствие;
			//РежимНабораПерсонала = Константы.РежимНабораПерсонала.Получить();
			//СписокНастроек = Новый СписокЗначений;
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				//СписокПолейПодстановкиОтборовПоУмолчанию.Вставить("Организация", "ОсновнаяОрганизация");
				//СписокНастроек.Добавить(Справочники.СохраненныеНастройки.ОтчетПоЗаявкамКандидатов);
			}
			//СтруктураНаcтроек.ЗаполнитьОтборыПоУмолчанию = истина;
			//СтруктураНаcтроек.СписокПолейПодстановкиОтборовПоУмолчанию = СписокПолейПодстановкиОтборовПоУмолчанию;
			//СтруктураНаcтроек.СписокДоступныхПредопределенныхНастроек = СписокНастроек;
		}
	}
}
