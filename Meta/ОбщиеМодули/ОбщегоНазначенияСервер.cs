﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ОбщегоНазначенияСервер
	{
		////////////////////////////////////////////////////////////////////////////////
		// Работа с массивами и таблицами значений
		// Функция возвращает результат вычитания элементов множества таблицы
		// ТаблицаВычитаемая из ТаблицаОсновная.
		//

		public object ВычестьТаблицу(/*знач ТаблицаОсновная,
                       знач ТаблицаВычитаемая,
                       знач КолонкаСравненияОсновнойТаблицы = "",
                       знач КолонкаСравненияВычитаемойТаблицы = ""*/)
		{
			if(true/*Не ЗначениеЗаполнено(КолонкаСравненияОсновнойТаблицы)*/)
			{
				//КолонкаСравненияОсновнойТаблицы = "Значение";
			}
			if(true/*Не ЗначениеЗаполнено(КолонкаСравненияВычитаемойТаблицы)*/)
			{
				//КолонкаСравненияВычитаемойТаблицы = "Значение";
			}
			//ТаблицаРезультат = Новый ТаблицаЗначений;
			//ТаблицаРезультат = ТаблицаОсновная.Скопировать();
			return null;
		}
		// Функция возвращает таблицу созданную на основе ТаблицаИнициализации.
		// Если ТаблицаИнициализации не указана, то создается пустая таблица.
		//

		public object СоздатьТаблицуСравнения(/*ТаблицаИнициализации = Неопределено,
                                ИмяКолонкиСравнения = "Значение"*/)
		{
			//Таблица = Новый ТаблицаЗначений;
			//Таблица.Колонки.Добавить(ИмяКолонкиСравнения);
			if(true/*ТаблицаИнициализации <> Неопределено*/)
			{
				//МассивЗначений = ТаблицаИнициализации.ВыгрузитьКолонку(ИмяКолонкиСравнения);
			}
			return null;
		}

		public object ЗапретитьОткрытиеНесколькихСеансов(/**/)
		{
			//ЗапретитьОткрытиеНесколькихСеансов = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ЗапретитьОткрытиеНесколькихСеансов");
			if(true/*НЕ ЗапретитьОткрытиеНесколькихСеансов*/)
			{
			}
			//ТекущийНомерСоединения = НомерСоединенияИнформационнойБазы();
			//УникальныйИдентификаторПользователя = ПользователиИнформационнойБазы.ТекущийПользователь().УникальныйИдентификатор;
			//МассивСоединений = ПолучитьСоединенияИнформационнойБазы();
			return null;
		}
	}
}
