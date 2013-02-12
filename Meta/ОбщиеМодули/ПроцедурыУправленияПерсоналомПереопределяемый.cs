﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПроцедурыУправленияПерсоналомПереопределяемый
	{
		// Проверяет, заполнен ли регламентированный производственный календарь за переданный период
		//
		// Параметры
		//  ДатаНач, ДатаКон - дата, определяют проверяемый период
		//  ВыводитьСообщения - булево - признак вывода сообщений в окно сообщений, по умолчанию - ложь
		//
		// Возвращаемое значение:
		//   Булево  - если колендарь заполнен за весь период
		//

		public object РегламентированныйКалендарьЗаполнен(/*ДатаНач, ДатаКон, ВыводитьСообщения = Ложь*/)
		{
			//Сообщение = "";
			//КалендарьЗаполнен = ПроцедурыУправленияПерсоналом.РегламентированныйКалендарьЗаполнен(ДатаНач, ДатаКон, Сообщение);
			if(true/*Не КалендарьЗаполнен и ВыводитьСообщения*/)
			{
				/*Сообщить(Сообщение + "
		|Интерфейсы: ""Полный"", ""Расчет зарплаты организаций"", ""Кадровый учет организаций"", пункт меню Предприятие - Производственный календарь.");*/
			}
			return null;
		}
		// РегламентированныйКалендарьЗаполнен()
		////////////////////////////////////////////////////////////////////////////////
		// ГОЛОВНЫЕ ОРГАНИЗАЦИИ И ОБОСОБЛЕННЫЕ ПОДРАЗДЕЛЕНИЯ
		// Функция ищет резюме кандидата
		//
		// В параметр ТиповаяАнкета будет передана ссылка на найденную типовую анкету

		public object НайтиРезюмеКандидата(/*ЗаявкаКандидата, ТиповаяАнкета = Неопределено*/)
		{
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ ОБЕСПЕЧЕНИЯ РАБОТЫ ФОРМ ДОКУМЕНТОВ

		public object СписокДоговоровФормыВыбораСотрудника(/*Режим*/)
		{
			//СписокДоговоров = Новый СписокЗначений;
			if(true/*Режим = 1*/)
			{
				//СписокДоговоров.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ТрудовойДоговор);
				//СписокДоговоров.Добавить(Перечисления.ВидыДоговоровСФизЛицами.Подряда);
				//СписокДоговоров.Добавить(Перечисления.ВидыДоговоровСФизЛицами.Авторский);
			}
			return null;
		}
		// СписокДоговоровФормыВыбораСотрудника
		// Функция ищет единственного сотрудника среди работников предприятия или организаций по
		//  началу его наименования
		//
		// Параметры
		//  СтандартнаяОбработка – параметр стандартной обработки события обработчика АвтоПодборТекста
		//	Режим – число, определяет источники, из которых производится подбор
		//	Текст  - начальные буквы ФИО, текст из обработчика АвтоПодборТекста
		//	Организация – ссылка на организацию по которой подбирать сотрудников (работников)
		//	ВозвращатьФизлицо – параметр определяет, что должна вернуть функция, наименование Сотрудника или Физлица
		//	ТолькоАктуальных – параметр определяет, вести поиск среди всех сотрудников, или только актуальных
		//	Регистратор - при вызове из приема на работу передаем ссылку на текущий Документ
		//
		// Возвращаемое значение
		//  строка - наименование найденного сотрудника, физлица, если он единственный

		public object ПодобратьФИОСотрудника(/*СтандартнаяОбработка, Режим, Знач Текст, Организация = Неопределено, ВозвращатьФизлицо = Ложь, ТолькоАктуальные = Истина, Регистратор = Неопределено*/)
		{
			//ТекстАвтоПодбора = "";
			//СтандартнаяОбработка = Ложь;
			//Запрос = Новый Запрос;
			/*// заменим спецсимволы
*/
			//Текст = СтрЗаменить(Текст, "~", "~~");
			//Текст = СтрЗаменить(Текст, "%", "~%");
			//Текст = СтрЗаменить(Текст, "_", "~_");
			//Текст = СтрЗаменить(Текст, "[", "~[");
			//Текст = СтрЗаменить(Текст, "-", "~-");
			//Текст = Текст+"%";
			//Запрос.УстановитьПараметр("Текст", Текст);
			/*//условие по Организации используем, если в качестве параметра передана не пустая ссылка на справочник
*/
			if(true/*ЗначениеЗаполнено(Организация) и ТипЗнч(Организация) = Тип("СправочникСсылка.Организации")*/)
			{
				//Запрос.УстановитьПараметр("ГоловнаяОрганизация", ОбщегоНазначения.ГоловнаяОрганизация(Организация));
			}
			//Запрос.УстановитьПараметр("НеОтбиратьПоОрганизации", Не (ЗначениеЗаполнено(Организация) и ТипЗнч(Организация) = Тип("СправочникСсылка.Организации")));
			//Запрос.УстановитьПараметр("НеУчитыватьАктуальность", Не ТолькоАктуальные);
			if(true/*Режим = 0 или Режим = 1 или Режим = 6*/)
			{
				//ДоговорыГПХ = Новый Массив;
				//ДоговорыГПХ.Добавить(Перечисления.ВидыДоговоровСФизЛицами.Авторский);
				//ДоговорыГПХ.Добавить(Перечисления.ВидыДоговоровСФизЛицами.Подряда);
				//Запрос.УстановитьПараметр("ДоговорыГПХ", ДоговорыГПХ);
				//СписокДоговоров = Новый Массив;
				//СписокДоговоров.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ТрудовойДоговор);
				//Запрос.УстановитьПараметр("СписокДоговоров", СписокДоговоров);
				if(true/*ВозвращатьФизлицо*/)
				{
					/*Запрос.Текст =
			"ВЫБРАТЬ РАЗРЕШЕННЫЕ РАЗЛИЧНЫЕ ПЕРВЫЕ 2
            |   Сотрудники.ФизлицоНаименование КАК Наименование
            |ИЗ
            |   (ВЫБРАТЬ РАЗЛИЧНЫЕ ПЕРВЫЕ 2
            |       Работники.Сотрудник.Физлицо.Наименование КАК ФизлицоНаименование
            |   ИЗ
            |       РегистрСведений.РаботникиОрганизаций КАК Работники
            |   ГДЕ
            |       Работники.Сотрудник.Наименование ПОДОБНО &Текст СПЕЦСИМВОЛ ""~""
            |       И (&НеОтбиратьПоОрганизации
            |               ИЛИ Работники.Сотрудник.Организация = &ГоловнаяОрганизация)
            |       И (&НеУчитыватьАктуальность
            |               ИЛИ Работники.Сотрудник.Актуальность)
            |       И Работники.Сотрудник.ВидДоговора В(&СписокДоговоров)
            |   
            |   ОБЪЕДИНИТЬ
            |   
            |   ВЫБРАТЬ РАЗЛИЧНЫЕ ПЕРВЫЕ 2
            |       Договорники.Физлицо.Наименование
            |   ИЗ
            |       Справочник.СотрудникиОрганизаций КАК Договорники
            |   ГДЕ
            |       Договорники.Наименование ПОДОБНО &Текст СПЕЦСИМВОЛ ""~""
            |       И (&НеОтбиратьПоОрганизации
            |               ИЛИ Договорники.Организация = &ГоловнаяОрганизация)
            |       И (&НеУчитыватьАктуальность
            |               ИЛИ Договорники.Актуальность)
            |       И Договорники.ВидДоговора В(&ДоговорыГПХ)) КАК Сотрудники";*/
				}
			}
			//Выборка = Запрос.Выполнить().Выбрать();
			if(true/*Выборка.Количество() = 1*/)
			{
				//Выборка.Следующий();
				//ТекстАвтоПодбора = Выборка.Наименование;
			}
			return null;
		}
		// ПодобратьФИОСотрудника()
		// Функция ищет сотрудника среди работников предприятия или организаций по
		//  началу его наименования
		//
		// Параметры
		// 	СтандартнаяОбработка – параметр стандартной обработки события обработчика АвтоПодборТекста
		//	Режим – число, определяет источники, из которых производится подбор
		//	Текст  - начальные буквы ФИО, текст из обработчика АвтоПодборТекста
		//	Организация – ссылка на организацию по которой подбирать сотрудников (работников)
		//	ВозвращатьФизлицо – параметр определяет, что должна вернуть функция, ссылку на Сотрудника или Физлицо
		//	ТолькоАктуальных – параметр определяет, вести поиск среди всех сотрудников, или только актуальных
		//	Регистратор - при вызове из приема на работу передаем ссылку на текущий Документ
		//
		// Возвращаемое значение
		//  СписокЗначений - список подходящих физлиц, если их найдено не более 50
		//  Неопределено - если найдено более 50 подходящих физлиц
		//

		public object ПодобратьСписокСотрудников(/*СтандартнаяОбработка, Режим, Знач Текст, Организация = Неопределено, ВозвращатьФизлицо = Ложь, ТолькоАктуальные = Истина, Регистратор = Неопределено*/)
		{
			if(true/*ПустаяСтрока(Текст)*/)
			{
			}
			//Запрос = Новый Запрос;
			/*// заменим спецсимволы
*/
			//Текст = СОКРЛП(Текст);
			//Текст = СтрЗаменить(Текст, "~", "~~");
			//Текст = СтрЗаменить(Текст, "%", "~%");
			//Текст = СтрЗаменить(Текст, "_", "~_");
			//Текст = СтрЗаменить(Текст, "[", "~[");
			//Текст = СтрЗаменить(Текст, "-", "~-");
			//Текст = Текст+"%";
			//Запрос.УстановитьПараметр("Текст", Текст);
			/*//условие по Организации используем, если в качестве параметра передана не пустая ссылка на справочник
*/
			if(true/*ЗначениеЗаполнено(Организация) и ТипЗнч(Организация) = Тип("СправочникСсылка.Организации")*/)
			{
				//Запрос.УстановитьПараметр("ГоловнаяОрганизация", ОбщегоНазначения.ГоловнаяОрганизация(Организация));
			}
			//Запрос.УстановитьПараметр("НеОтбиратьПоОрганизации", Не (ЗначениеЗаполнено(Организация) и ТипЗнч(Организация) = Тип("СправочникСсылка.Организации")));
			//Запрос.УстановитьПараметр("НеУчитыватьАктуальность", Не ТолькоАктуальные);
			if(true/*Режим = 0 или Режим = 1 или Режим = 6*/)
			{
				//ДоговорыГПХ = Новый Массив;
				//ДоговорыГПХ.Добавить(Перечисления.ВидыДоговоровСФизЛицами.Авторский);
				//ДоговорыГПХ.Добавить(Перечисления.ВидыДоговоровСФизЛицами.Подряда);
				//Запрос.УстановитьПараметр("ДоговорыГПХ", ДоговорыГПХ);
				//СписокДоговоров = Новый Массив;
				//СписокДоговоров.Добавить(Перечисления.ВидыДоговоровСФизЛицами.ТрудовойДоговор);
				//Запрос.УстановитьПараметр("СписокДоговоров", СписокДоговоров);
				if(true/*ВозвращатьФизлицо*/)
				{
					/*Запрос.Текст =
			"ВЫБРАТЬ РАЗРЕШЕННЫЕ РАЗЛИЧНЫЕ ПЕРВЫЕ 51
			|	Сотрудники.Физлицо КАК Ссылка,
			|	Сотрудники.ФизлицоНаименование КАК Наименование,
			|	Сотрудники.Код КАК Код,
			|	Сотрудники.НайденоПоНаименованию КАК НайденоПоНаименованию,
			|	Сотрудники.СотрудникНаименование КАК СотрудникНаименование
			|ИЗ
			|	(ВЫБРАТЬ РАЗЛИЧНЫЕ ПЕРВЫЕ 51
			|		Работники.Сотрудник.Физлицо КАК Физлицо,
			|		Работники.Сотрудник.Физлицо.Наименование КАК ФизлицоНаименование,
			|		Работники.Сотрудник.Код КАК Код,
			|		ИСТИНА КАК НайденоПоНаименованию,
			|		Работники.Сотрудник.Наименование КАК СотрудникНаименование
			|	ИЗ
			|		РегистрСведений.РаботникиОрганизаций КАК Работники
			|	ГДЕ
			|		Работники.Сотрудник.Наименование ПОДОБНО &Текст СПЕЦСИМВОЛ ""~""
			|		И (&НеОтбиратьПоОрганизации
			|				ИЛИ Работники.Сотрудник.Организация = &ГоловнаяОрганизация)
			|		И (&НеУчитыватьАктуальность
			|				ИЛИ Работники.Сотрудник.Актуальность)
			|		И Работники.Сотрудник.ВидДоговора В(&СписокДоговоров)
			|	
			|	ОБЪЕДИНИТЬ
			|	
			|	ВЫБРАТЬ РАЗЛИЧНЫЕ ПЕРВЫЕ 51
			|		Договорники.Физлицо,
			|		Договорники.Физлицо.Наименование,
			|		Договорники.Код,
			|		ИСТИНА,
			|		Договорники.Наименование
			|	ИЗ
			|		Справочник.СотрудникиОрганизаций КАК Договорники
			|	ГДЕ
			|		Договорники.Наименование ПОДОБНО &Текст СПЕЦСИМВОЛ ""~""
			|		И (&НеОтбиратьПоОрганизации
			|				ИЛИ Договорники.Организация = &ГоловнаяОрганизация)
			|		И (&НеУчитыватьАктуальность
			|				ИЛИ Договорники.Актуальность)
			|		И Договорники.ВидДоговора В(&ДоговорыГПХ)
			|	
			|	ОБЪЕДИНИТЬ
			|	
			|	ВЫБРАТЬ РАЗЛИЧНЫЕ ПЕРВЫЕ 51
			|		Работники.Сотрудник.Физлицо,
			|		Работники.Сотрудник.Физлицо.Наименование,
			|		Работники.Сотрудник.Код,
			|		ЛОЖЬ,
			|		Работники.Сотрудник.Наименование
			|	ИЗ
			|		РегистрСведений.РаботникиОрганизаций КАК Работники
			|	ГДЕ
			|		Работники.Сотрудник.Код ПОДОБНО &Текст СПЕЦСИМВОЛ ""~""
			|		И (&НеОтбиратьПоОрганизации
			|				ИЛИ Работники.Сотрудник.Организация = &ГоловнаяОрганизация)
			|		И (&НеУчитыватьАктуальность
			|				ИЛИ Работники.Сотрудник.Актуальность)
			|		И Работники.Сотрудник.ВидДоговора В(&СписокДоговоров)
			|	
			|	ОБЪЕДИНИТЬ
			|	
			|	ВЫБРАТЬ РАЗЛИЧНЫЕ ПЕРВЫЕ 51
			|		Договорники.Физлицо,
			|		Договорники.Физлицо.Наименование,
			|		Договорники.Код,
			|		ЛОЖЬ,
			|		Договорники.Наименование
			|	ИЗ
			|		Справочник.СотрудникиОрганизаций КАК Договорники
			|	ГДЕ
			|		Договорники.Код ПОДОБНО &Текст СПЕЦСИМВОЛ ""~""
			|		И (&НеОтбиратьПоОрганизации
			|				ИЛИ Договорники.Организация = &ГоловнаяОрганизация)
			|		И (&НеУчитыватьАктуальность
			|				ИЛИ Договорники.Актуальность)
			|		И Договорники.ВидДоговора В(&ДоговорыГПХ)) КАК Сотрудники
			|
			|УПОРЯДОЧИТЬ ПО
			|	СотрудникНаименование УБЫВ";*/
				}
			}
			//Выборка = Запрос.Выполнить().Выбрать();
			//Количество = Выборка.Количество();
			if(true/*Количество < 51*/)
			{
				//Значение = Новый СписокЗначений;
				while(true/*Выборка.Следующий()*/)
				{
					//Значение.Добавить(Выборка.Ссылка, ?(Выборка.НайденоПоНаименованию,Выборка.Наименование, Выборка.Код + " (" + Выборка.Наименование + ")"));
				}
				/*;
		
		СтандартнаяОбработка = Ложь;*/
			}
			return null;
		}
		// ПодобратьСписокСотрудников()

		public void ОткрытьФормуВыбораСотрудника(/*Владелец, Ключ, ЗакрыватьПриВыборе, ДатаСреза, СтандартнаяОбработка = Неопределено, ТекущееЗначение = Неопределено, ВыборФизлица = Ложь, ПараметрыПодбора = Неопределено, Подразделение = Неопределено, ПараметрыОтбора = Неопределено*/)
		{
			//СтандартнаяОбработка = Ложь;
			//Форма = Справочники.СотрудникиОрганизаций.ПолучитьФормуВыбора(, Владелец, Ключ);
			//Форма.ДатаСреза 					= ДатаСреза;
			//Форма.ПараметрВыборГруппИЭлементов	= ИспользованиеГруппИЭлементов.Элементы;
			//Форма.РежимВыбора					= Истина;
			//Форма.ЗакрыватьПриВыборе			= ЗакрыватьПриВыборе;
			//Форма.ВыборФизлица					= ВыборФизлица;
			//Форма.мПараметрыПодбора				= ПараметрыПодбора;
			if(true/*ТекущееЗначение <> Неопределено*/)
			{
				if(true/*ТипЗнч(ТекущееЗначение) = Тип("СправочникСсылка.СотрудникиОрганизаций")*/)
				{
					//Форма.ПараметрТекущаяСтрока	= ТекущееЗначение;
				}
			}
			//Форма.Отбор.ВидЗанятости.ВидСравнения = ВидСравнения.НеРавно;
			//Форма.Отбор.ВидЗанятости.Использование = Истина;
			//Форма.Отбор.ВидЗанятости.Значение = Перечисления.ВидыЗанятостиВОрганизации.ВнутреннееСовместительство;
			if(true/*Подразделение <> Неопределено*/)
			{
				//Форма.Отбор.ТекущееПодразделениеКомпании.ВидСравнения	= ВидСравнения.ВСписке;
				//Запрос = Новый Запрос;
				/*Запрос.Текст =
		"ВЫБРАТЬ
		|	Спр.Ссылка
		|ИЗ
		|	Справочник.Подразделения КАК Спр
		|ГДЕ
		|	Спр.Родитель В (&Ссылка)";*/
				//Ссылка = ?(Подразделение = Неопределено ИЛИ Подразделение.Пустая(), Неопределено, Подразделение);
				//СписокПодразделений = Новый СписокЗначений;
				//СписокПодразделений.Добавить(Ссылка);
				while(true/*Ссылка <> Неопределено*/)
				{
					//Запрос.УстановитьПараметр("Ссылка",	Ссылка);
					//СписокСсылок = Запрос.Выполнить().Выгрузить().ВыгрузитьКолонку("Ссылка");
					if(true/*СписокСсылок.Количество() > 0*/)
					{
						//Ссылка = СписокСсылок;
					}
				}
				/*;
		
		Форма.Отбор.ТекущееПодразделениеКомпании.Значение		= СписокПодразделений;*/
				//Форма.Отбор.ТекущееПодразделениеКомпании.Использование	= Истина;
			}
			if(true/*НЕ ПараметрыОтбора = Неопределено*/)
			{
			}
			//Форма.Открыть();
		}
		// ОткрытьФормуВыбораСотрудника()
		// Функция возвращаект сведения о позиции штатного расписания на выбранную дату
		// для измерений Подразделение и Должность
		//

		public object СведенияОПозицииШтатногоРасписания(/*Период, Подразделение, Должность*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("ДатаАктуальности",	Период);
			//Запрос.УстановитьПараметр("Подразделение",		Подразделение);
			//Запрос.УстановитьПараметр("Должность",			Должность);
			/*Запрос.Текст =
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	ШтатноеРасписаниеОрганизацийСрезПоследних.КоличествоСтавок,
	|	ШтатноеРасписаниеОрганизацийСрезПоследних.МинимальнаяТарифнаяСтавка,
	|	ШтатноеРасписаниеОрганизацийСрезПоследних.МаксимальнаяТарифнаяСтавка,
	|	ШтатноеРасписаниеОрганизацийСрезПоследних.ВидТарифнойСтавки,
	|	ШтатноеРасписаниеОрганизацийСрезПоследних.ГрафикРаботы,
	|	ШтатноеРасписаниеОрганизацийСрезПоследних.ВалютаТарифнойСтавки,
	|	ШтатноеРасписаниеОрганизацийСрезПоследних.ОсобыеУсловияТруда
	|ИЗ
	|	РегистрСведений.ШтатноеРасписаниеОрганизаций.СрезПоследних(
	|		&ДатаАктуальности,
	|		ПодразделениеОрганизации = &Подразделение
	|			И Должность = &Должность) КАК ШтатноеРасписаниеОрганизацийСрезПоследних";*/
			return null;
		}
		// СведенияОПозицииШтатногоРасписания()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ формирования движений кадровых документов по плановым начислениям работников организации

		public object СформироватьТекстЗапросаПоПроверкеСоответствияШтатномуРасписанию(/**/)
		{
			/*Возврат
	"ВЫБРАТЬ
	|	ТЧНачисления.НомерСтроки КАК НомерСтроки,
	|	ВЫБОР
	|		КОГДА ТЧНачисления.ЗанимаемыхСтавок <> 1
	|			ТОГДА ИСТИНА
	|		КОГДА ТЧНачисления.ЗачетОтработанногоВремени
	|				И ТЧНачисления.Действие В (ЗНАЧЕНИЕ(Перечисление.ВидыДействияСНачислением.Начать), ЗНАЧЕНИЕ(Перечисление.ВидыДействияСНачислением.Изменить))
	|			ТОГДА ВЫБОР
	|					КОГДА ТЧНачисления.СпособРасчета В (ЗНАЧЕНИЕ(Перечисление.СпособыРасчетаОплатыТруда.ПоМесячнойТарифнойСтавкеПоДням), ЗНАЧЕНИЕ(Перечисление.СпособыРасчетаОплатыТруда.ПоМесячнойТарифнойСтавкеПоЧасам))
	|							И ШтатноеРасписаниеОрганизаций.ВидТарифнойСтавки = ЗНАЧЕНИЕ(Перечисление.ВидыТарифныхСтавок.Месячная)
	|						ТОГДА ВЫБОР
	|								КОГДА ТЧНачисления.ТребуетВводаТарифногоРазряда
	|									ТОГДА ВЫБОР
	|											КОГДА РазмерТарифныхСтавок.Размер < ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МинимальнаяТарифнаяСтавка, 0)
	|												ТОГДА ЛОЖЬ
	|											КОГДА РазмерТарифныхСтавок.Размер > ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МаксимальнаяТарифнаяСтавка, 0)
	|												ТОГДА ЛОЖЬ
	|											ИНАЧЕ ИСТИНА
	|										КОНЕЦ
	|								ИНАЧЕ ВЫБОР
	|										КОГДА ТЧНачисления.Показатель1 < ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МинимальнаяТарифнаяСтавка, 0)
	|											ТОГДА ЛОЖЬ
	|										КОГДА ТЧНачисления.Показатель1 > ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МаксимальнаяТарифнаяСтавка, 0)
	|											ТОГДА ЛОЖЬ
	|										ИНАЧЕ ИСТИНА
	|									КОНЕЦ
	|							КОНЕЦ
	|					КОГДА ТЧНачисления.СпособРасчета = ЗНАЧЕНИЕ(Перечисление.СпособыРасчетаОплатыТруда.ПоДневнойТарифнойСтавке)
	|							И ШтатноеРасписаниеОрганизаций.ВидТарифнойСтавки = ЗНАЧЕНИЕ(Перечисление.ВидыТарифныхСтавок.Дневная)
	|						ТОГДА ВЫБОР
	|								КОГДА ТЧНачисления.ТребуетВводаТарифногоРазряда
	|									ТОГДА ВЫБОР
	|											КОГДА РазмерТарифныхСтавок.Размер < ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МинимальнаяТарифнаяСтавка, 0)
	|												ТОГДА ЛОЖЬ
	|											КОГДА РазмерТарифныхСтавок.Размер > ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МаксимальнаяТарифнаяСтавка, 0)
	|												ТОГДА ЛОЖЬ
	|											ИНАЧЕ ИСТИНА
	|										КОНЕЦ
	|								ИНАЧЕ ВЫБОР
	|										КОГДА ТЧНачисления.Показатель1 < ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МинимальнаяТарифнаяСтавка, 0)
	|											ТОГДА ЛОЖЬ
	|										КОГДА ТЧНачисления.Показатель1 > ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МаксимальнаяТарифнаяСтавка, 0)
	|											ТОГДА ЛОЖЬ
	|										ИНАЧЕ ИСТИНА
	|									КОНЕЦ
	|							КОНЕЦ
	|					КОГДА ТЧНачисления.СпособРасчета = ЗНАЧЕНИЕ(Перечисление.СпособыРасчетаОплатыТруда.ПоЧасовойТарифнойСтавке)
	|							И ШтатноеРасписаниеОрганизаций.ВидТарифнойСтавки = ЗНАЧЕНИЕ(Перечисление.ВидыТарифныхСтавок.Часовая)
	|						ТОГДА ВЫБОР
	|								КОГДА ТЧНачисления.ТребуетВводаТарифногоРазряда
	|									ТОГДА ВЫБОР
	|											КОГДА РазмерТарифныхСтавок.Размер < ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МинимальнаяТарифнаяСтавка, 0)
	|												ТОГДА ЛОЖЬ
	|											КОГДА РазмерТарифныхСтавок.Размер > ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МаксимальнаяТарифнаяСтавка, 0)
	|												ТОГДА ЛОЖЬ
	|											ИНАЧЕ ИСТИНА
	|										КОНЕЦ
	|								ИНАЧЕ ВЫБОР
	|										КОГДА ТЧНачисления.Показатель1 < ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МинимальнаяТарифнаяСтавка, 0)
	|											ТОГДА ЛОЖЬ
	|										КОГДА ТЧНачисления.Показатель1 > ЕСТЬNULL(ШтатноеРасписаниеОрганизаций.МаксимальнаяТарифнаяСтавка, 0)
	|											ТОГДА ЛОЖЬ
	|										ИНАЧЕ ИСТИНА
	|									КОНЕЦ
	|							КОНЕЦ
	|					ИНАЧЕ ВЫБОР
	|							КОГДА ШтатноеРасписаниеОрганизаций.ВидТарифнойСтавки ЕСТЬ NULL 
	|								ТОГДА ЛОЖЬ
	|							ИНАЧЕ ИСТИНА
	|						КОНЕЦ
	|				КОНЕЦ
	|		ИНАЧЕ ИСТИНА
	|	КОНЕЦ КАК РазмерСоответствуетШТР
	|ПОМЕСТИТЬ ВТДанныеШтатногоРасписания
	|ИЗ
	|	(ВЫБРАТЬ
	|		ТЧНачисления.НомерСтроки КАК НомерСтроки,
	|		ТЧНачисления.ПодразделениеОрганизации КАК ПодразделениеОрганизации,
	|		ТЧНачисления.Должность КАК Должность,
	|		ТЧНачисления.ЗанимаемыхСтавок КАК ЗанимаемыхСтавок,
	|		ТЧНачисления.ТарифныйРазряд1 КАК ТарифныйРазряд1,
	|		ТЧНачисления.ТарифныйРазряд2 КАК ТарифныйРазряд2,
	|		ТЧНачисления.ТарифныйРазряд3 КАК ТарифныйРазряд3,
	|		ТЧНачисления.ТарифныйРазряд4 КАК ТарифныйРазряд4,
	|		ТЧНачисления.ТарифныйРазряд5 КАК ТарифныйРазряд5,
	|		ТЧНачисления.ТарифныйРазряд6 КАК ТарифныйРазряд6,
	|		ТЧНачисления.Показатель1 КАК Показатель1,
	|		ТЧНачисления.ЗачетОтработанногоВремени КАК ЗачетОтработанногоВремени,
	|		ТЧНачисления.ТребуетВводаТарифногоРазряда КАК ТребуетВводаТарифногоРазряда,
	|		ТЧНачисления.СпособРасчета КАК СпособРасчета,
	|		ТЧНачисления.Действие КАК Действие,
	|		МАКСИМУМ(ШтатноеРасписаниеОрганизаций.Период) КАК ПериодШтР,
	|		МАКСИМУМ(РазмерТарифныхСтавок.Период) КАК ПериодРазряда
	|	ИЗ
	|		ВТДанныеОНачислениях КАК ТЧНачисления
	|			ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.ШтатноеРасписаниеОрганизаций КАК ШтатноеРасписаниеОрганизаций
	|			ПО ТЧНачисления.ПодразделениеОрганизации = ШтатноеРасписаниеОрганизаций.ПодразделениеОрганизации
	|				И ТЧНачисления.Должность = ШтатноеРасписаниеОрганизаций.Должность
	|				И ТЧНачисления.Период >= ШтатноеРасписаниеОрганизаций.Период
	|			ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.РазмерТарифныхСтавок КАК РазмерТарифныхСтавок
	|			ПО ТЧНачисления.Период >= РазмерТарифныхСтавок.Период
	|				И ТЧНачисления.ТарифныйРазряд1 = РазмерТарифныхСтавок.ТарифныйРазряд
	|	
	|	СГРУППИРОВАТЬ ПО
	|		ТЧНачисления.ПодразделениеОрганизации,
	|		ТЧНачисления.Должность,
	|		ТЧНачисления.ЗанимаемыхСтавок,
	|		ТЧНачисления.ТарифныйРазряд1,
	|		ТЧНачисления.ТарифныйРазряд2,
	|		ТЧНачисления.ТарифныйРазряд3,
	|		ТЧНачисления.ТарифныйРазряд4,
	|		ТЧНачисления.ТарифныйРазряд5,
	|		ТЧНачисления.ТарифныйРазряд6,
	|		ТЧНачисления.Показатель1,
	|		ТЧНачисления.ЗачетОтработанногоВремени,
	|		ТЧНачисления.ТребуетВводаТарифногоРазряда,
	|		ТЧНачисления.СпособРасчета,
	|		ТЧНачисления.Действие,
	|		ТЧНачисления.НомерСтроки) КАК ТЧНачисления
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.ШтатноеРасписаниеОрганизаций КАК ШтатноеРасписаниеОрганизаций
	|		ПО ТЧНачисления.ПериодШтР = ШтатноеРасписаниеОрганизаций.Период
	|			И ТЧНачисления.ПодразделениеОрганизации = ШтатноеРасписаниеОрганизаций.ПодразделениеОрганизации
	|			И ТЧНачисления.Должность = ШтатноеРасписаниеОрганизаций.Должность
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.РазмерТарифныхСтавок КАК РазмерТарифныхСтавок
	|		ПО ТЧНачисления.ПериодРазряда = РазмерТарифныхСтавок.Период
	|			И (ТЧНачисления.ТарифныйРазряд1 = РазмерТарифныхСтавок.ТарифныйРазряд
	|				ИЛИ ТЧНачисления.ТарифныйРазряд2 = РазмерТарифныхСтавок.ТарифныйРазряд
	|				ИЛИ ТЧНачисления.ТарифныйРазряд3 = РазмерТарифныхСтавок.ТарифныйРазряд
	|				ИЛИ ТЧНачисления.ТарифныйРазряд4 = РазмерТарифныхСтавок.ТарифныйРазряд
	|				ИЛИ ТЧНачисления.ТарифныйРазряд5 = РазмерТарифныхСтавок.ТарифныйРазряд
	|				ИЛИ ТЧНачисления.ТарифныйРазряд6 = РазмерТарифныхСтавок.ТарифныйРазряд)
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	НомерСтроки";*/
			return null;
		}
	}
}
