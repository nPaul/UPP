﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ФормированиеПечатныхФормСервер
	{
		// Формирует описание серий и характеристик ТМЦ для печати
		//
		// Параметры
		//  Выборка  – <ВыборкаИзРезультатаЗапроса > – Исходные данные
		//
		// Возвращаемое значение:
		//   Строка - Описание серий и характеристик ТМЦ
		//

		public object ПредставлениеСерий(/*Выборка*/)
		{
			//Результат = "(";
			if(true/*ЗначениеЗаполнено(Выборка.Характеристика)*/)
			{
				//Результат = Результат + Выборка.Характеристика;
				//Результат = СтрЗаменить(Результат, "<>", "");
			}
			if(true/*ЗначениеЗаполнено(Выборка.Серия)*/)
			{
				//Результат = ?(Результат = "(", Результат, Результат + "; ");
				//Результат = Результат + Выборка.Серия;
				//Результат = СтрЗаменить(Результат,  "(<>", "(");
				//Результат = СтрЗаменить(Результат, "; <>",  "");
			}
			//Результат = Результат + ")";
			//Возврат ?(Результат = "()", "", " " + Результат);
			return null;
		}
		// ПредставлениеСерий()
		// Возвращает структуру данных со сводным описанием контрагента
		//
		// Параметры:
		//  СписокСведений - список значений со значенийми параметров организации
		//   СписокСведений формируется функцией СведенияОЮрФизЛице
		//  Список         - список запрашиваемых параметров организаиии
		//  СПрефиксом     - Признак выводить или нет префикс параметра организации
		//
		// Возвращаемое значение:
		//  Строка - описатель организации / контрагента / физ.лица.
		//

		public object ОписаниеОрганизации(/*СписокСведений, Список = "", СПрефиксом = Истина*/)
		{
			if(true/*ПустаяСтрока(Список)*/)
			{
				//Список = "ПолноеНаименование,ИНН,Свидетельство,ЮридическийАдрес,Телефоны,НомерСчета,Банк,БИК,КоррСчет";
			}
			//Результат = "";
			//СоответствиеПараметров = Новый Соответствие();
			//СоответствиеПараметров.Вставить("ПолноеНаименование", 		" ");
			//СоответствиеПараметров.Вставить("НаименованиеСокращенное", 	" ");
			//СоответствиеПараметров.Вставить("ИНН",                		" ИНН ");
			//СоответствиеПараметров.Вставить("КПП",                		" КПП ");
			//СоответствиеПараметров.Вставить("Свидетельство",			" ");
			//СоответствиеПараметров.Вставить("СвидетельствоДатаВыдачи",	" от ");
			//СоответствиеПараметров.Вставить("ЮридическийАдрес",   		" ");
			//СоответствиеПараметров.Вставить("ФактическийАдрес",   		" ");
			//СоответствиеПараметров.Вставить("Телефоны",           		" тел.: ");
			//СоответствиеПараметров.Вставить("НомерСчета",         		" р/с ");
			//СоответствиеПараметров.Вставить("Банк",               		" в банке ");
			//СоответствиеПараметров.Вставить("БИК",                		" БИК ");
			//СоответствиеПараметров.Вставить("КоррСчет",           		" к/с ");
			//СоответствиеПараметров.Вставить("КодПоОКПО",          		" Код по ОКПО ");
			//Список          = Список + ?(Прав(Список, 1) = ",", "", ",");
			//ЧислоПараметров = СтрЧислоВхождений(Список, ",");
			return null;
		}
		// ОписаниеОрганизации()
		// Проверяет, умещаются ли переданные табличные документы на страницу при печати.
		//
		// Параметры
		//  ТабДокумент        – Табличный документ
		//  ВыводимыеОбласти   – Массив из проверяемых таблиц или табличный документ
		//  РезультатПриОшибке - Какой возвращать результат при возникновении ошибки
		//
		// Возвращаемое значение:
		//   Булево   – умещаются или нет переданные документы
		//

		public object ПроверитьВыводТабличногоДокумента(/*ТабДокумент, ВыводимыеОбласти, РезультатПриОшибке = Истина*/)
		{
			return null;
		}
		// ПроверитьВыводТабличногоДокумента()
		// Функция собирает фамилию, имя и отчество физ. лица на указанную дату
		//
		// Параметры:
		//  ФизЛицо.    - физ. лицо, для которго необходимо получить данные
		//  ДатаПериода - дата получения сведений
		//
		// Возвращаемое значение:
		//  Структура с данными.
		//

		public object ФамилияИмяОтчество(/*ФизЛицо, ДатаПериода*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("ПарФизЛицо",     ФизЛицо);
			//Запрос.УстановитьПараметр("ПарДатаПериода", ДатаПериода);
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	Фамилия,
	|	Имя,
	|	Отчество
	|ИЗ
	|	РегистрСведений.ФИОФизЛиц.СрезПоследних(&ПарДатаПериода, ФизЛицо = &ПарФизЛицо)
	|";*/
			//Шапка = Запрос.Выполнить().Выбрать();
			//Шапка.Следующий();
			//Результат = Новый Структура("Фамилия, Имя, Отчество");
			//Результат.Фамилия  = ?(НЕ ЗначениеЗаполнено(Шапка.Фамилия),  "", Шапка.Фамилия);
			//Результат.Имя      = ?(НЕ ЗначениеЗаполнено(Шапка.Имя),      "", Шапка.Имя);
			//Результат.Отчество = ?(НЕ ЗначениеЗаполнено(Шапка.Отчество), "", Шапка.Отчество);
			return null;
		}
		// ФамилияИмяОтчество()
	}
}
