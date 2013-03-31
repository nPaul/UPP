﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ФормированиеПоказателейСхемМотивации
	{

		public object ПолучитьИдентификатор(/*СтрНаименование*/)
		{
			//Разделители	=  " .,+,-,/,*,?,=,<,>,(,)%!@#$%&*""№:;{}[]?()\|/`~'^_";
			//Идентификатор = "";
			//БылСпецСимвол = Ложь;
			return null;
		}
		//ПолучитьИдентификатор
		// Функция возвращает показатель схемы мотивации, если есть существующий, иначе создает новый.
		//
		// Параметры:
		//  Наименование - наименование показателя.
		//  ДопНаименование - окончания наименования, может быть либо "", либо "(В целом по предприятию)".
		//	ВидПоказателя - вид показателя, в данной функции может быть только индивидуальным и общим
		//
		// Возвращаемое значение:
		//  Показатель - ссылка на показатель схем мотивации.
		//

		public object НайтиПоказатель(/*Наименование, ДопНаименование, ВидПоказателя, ИмяПоказателя*/)
		{
			//Показатель = Справочники.ПоказателиСхемМотивации.НайтиПоНаименованию(Наименование);
			if(true/*Показатель <> Справочники.ПоказателиСхемМотивации.ПустаяСсылка()*/)
			{
			}
			return null;
		}
		//НайтиПоказатель
		// Функция возвращает ссылку на сотрудника, если есть существующий, иначе создает нового.
		//
		// Параметры:
		//  Менеджер - Справочник пользователи.
		//
		// Возвращаемое значение:
		//  Сотрудник - ссылка на элемент справочника "Сотрудники".
		//

		public object НайтиСотрудника(/*Менеджер*/)
		{
			return null;
		}
		//НайтиСотрудника
		// Функция создает значения показателей по данным отчёта "ПоказателиРаботыМенеджеров" в регистр сведений "ЗначенияПоказателейСхемМотивации"
		// и возвращает Ложь в случае отказе в доступе.
		//
		// Параметры:
		//  ТекстЗапроса - текст запроса, собранного в отчёте "ПоказателиРаботыМенеджеров
		//  Показатели - показатели, значения которых будет получать процедура
		//  ПериодДействия - период, в котором формируются записи регистра.
		//  Менеджер - справочник пользователи.
		//

		public object ФормированиеПоказателей(/*ТекстЗапроса, Показатели, ПериодДействия, Менеджер*/)
		{
			if(true/*Не ПравоДоступа("Использование", Метаданные.Обработки.ФормированиеПоказателейСхемМотивации)*/)
			{
			}
			//Запрос = Новый Запрос;
			//Запрос.Текст = ТекстЗапроса;
			/*//т.к. в форме выбирается месяц, установим период формирования отчёта "Показатели работы менеджера" тоже месяц
*/
			//Запрос.УстановитьПараметр("ДатаНачала", НачалоМесяца(ПериодДействия));
			//Запрос.УстановитьПараметр("ДатаКонца", КонецМесяца(ПериодДействия));
			//Запрос.УстановитьПараметр("ЗначениеОтбораМенеджер", Менеджер);
			//Запрос.УстановитьПараметр("Менеджер", Менеджер);
			/*// как и отчёт, обработка формирует показатели в упр. валюте
*/
			//ВалютаУправленческогоУчета = глЗначениеПеременной("ВалютаУправленческогоУчета");
			//СтруктураВалюты = МодульВалютногоУчета.ПолучитьКурсВалюты(ВалютаУправленческогоУчета, НачалоМесяца(ПериодДействия));
			//КурсВалютыУправленческогоУчета      = СтруктураВалюты.Курс;
			//КратностьВалютыУправленческогоУчета = СтруктураВалюты.Кратность;
			//Запрос.УстановитьПараметр("ВалютаУпрУчета", ВалютаУправленческогоУчета);
			//Запрос.УстановитьПараметр("КратностьВалютыУпр", КратностьВалютыУправленческогоУчета);
			//Запрос.УстановитьПараметр("КурсВалютыУпр", КурсВалютыУправленческогоУчета);
			//Выборка = Запрос.Выполнить().Выбрать();
			while(true/*Выборка.Следующий()*/)
			{
			}
			return null;
		}
		//ФормированиеПоказателей
	}
}
