﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class СотрудникиОрганизацийДополнительный
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции модуля объекта

		public void ДополнитьСтруктуруПечатныхФорм(/*СтруктураПечатныхФорм, СотрудникОбъект*/)
		{
			if(true/*Не ЗначениеЗаполнено(СотрудникОбъект.ВидДоговора) Или СотрудникОбъект.ВидДоговора = Перечисления.ВидыДоговоровСФизЛицами.ТрудовойДоговор*/)
			{
				//СтруктураПечатныхФорм.Вставить("Печать", "Трудовой договор");
				//СтруктураПечатныхФорм.Вставить("РегламентированныйОтпуск",	"Справка по отпуску");
				//ИспользоватьУправленческийУчетЗарплаты = глЗначениеПеременной("глИспользоватьУправленческийУчетЗарплаты");
				if(true/*ИспользоватьУправленческийУчетЗарплаты*/)
				{
					//СтруктураПечатныхФорм.Вставить("УправленческийОтпуск",	"Справка по отпуску в компании");
				}
			}
		}
		// ДополнитьСтруктуруПечатныхФорм

		public void ПечатьДополнительныхПечатныхФорм(/*ИмяМакета, КоличествоЭкземпляров = 1, НаПринтер = Ложь, СотрудникОбъект*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ПечатьДополнительныхПечатныхФорм
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы c формой элемента

		public void ОбработкаОткрытияФизлица(/*Владелец, Ключ, Физлицо, ГоловнаяОрганизация = Неопределено, СтандартнаяОбработка = Неопределено*/)
		{
			/*// В этой конфигурации используется стандартная обработка
*/
			//СтандартнаяОбработка = Истина;
		}
		// ОбработкаОткрытияФизлица
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы c формой списка

		public void ФормаСпискаПередОткрытиемДополнительно(/*Форма, ДополнительныеДействия*/)
		{
			//Форма.ЭлементыФормы.ПанельДополнительныеСведения.Свертка = РежимСверткиЭлементаУправления.Низ;
		}
		// ФормаСпискаПередОткрытиемДополнительно

		public void ФормаСпискаПередЗакрытиемДополнительно(/*Форма, Отказ, СтандартнаяОбработка*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаСпискаПередЗакрытиемДополнительно

		public void ФормаСпискаПриПолученииДанныхДополнительно(/*Форма, Элемент, ОформленияСтрок*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаСпискаПриПолученииДанныхДополнительно

		public void ФормаСпискаПриАктивизацииСтрокиДополнительно(/*Форма, Элемент, ДанныеСтроки*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаСпискаПриАктивизацииСтрокиДополнительно

		public void ФормаСпискаВыполнитьДополнительныеДействия(/*Форма, Кнопка*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаСпискаВыполнитьДополнительныеДействия

		public void ФормаСпискаОбработкаОповещенияДополнительно(/*Форма, ИмяСобытия, Параметр, Источник*/)
		{
			/*// В этой конфигурации дополнительные действия не предусмотрены
*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры формирования меню ввести документ в формах справочника сотрудники

		public void СформироватьПодменюВвестиДокумент(/*МассивКнопокПодменю, СтруктураСоответствияДействий, ДанныеСотрудника, Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ДополнитьСтруктуруСоответствияДействий(/*СтруктураСоответствияДействий, ДополнительныеДействия*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
	}
}
