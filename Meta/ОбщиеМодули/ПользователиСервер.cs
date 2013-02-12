﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПользователиСервер
	{
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры и функции программного интерфейса
		// Функция АвторизованныйПользователь возвращает
		// текущего пользователя сеанса.
		//
		// Возвращаемое значение:
		//  СправочникСсылка.Пользователи, СправочникСсылка.ВнешниеПользователи.
		//

		public object АвторизованныйПользователь(/**/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			return null;
		}
		// Получает значение параметра сеанса "Текущий пользователь"
		//
		// Возвращаемое значение:
		//  СправочникСсылка.Пользователи
		//

		public object ТекущийПользователь(/**/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			return null;
		}
		// Функция ЭтоПолноправныйПользовательИБ проверяет,
		// является ли полноправным текущий пользователь ИБ или
		// пользователь ИБ заданного пользователя (обычного или внешнего).
		//
		//  Полноправными считается:
		// а) пользователь ИБ при пустом списке пользователей ИБ,
		//    если основная роль не задана или ПолныеПрава,
		// б) пользователь ИБ с ролью ПолныеПрава.
		//
		//
		// Параметры:
		//  Пользователь - Неопределено (проверяется текущий пользователь ИБ),
		//                 Справочник.Пользователи, Справочник.ВнешниеПользователи
		//                 (осуществляется поиск пользователя ИБ по уникальному
		//                  идентификатору, заданному в реквизите ИдентификаторПользователяИБ,
		//                  если пользователь ИБ не найден, возвращается Ложь).
		//
		// Возвращаемое значение:
		//  Булево.
		//

		public object ЭтоПолноправныйПользовательИБ(/*Пользователь = Неопределено*/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			if(true/*ЗначениеЗаполнено(Пользователь) И Пользователь <> АвторизованныйПользователь()*/)
			{
				//ПользовательИБ = ПользователиИнформационнойБазы.НайтиПоУникальномуИдентификатору(ОбщегоНазначения.ПолучитьЗначениеРеквизита(Пользователь, "ИдентификаторПользователяИБ"));
				if(true/*ПользовательИБ = Неопределено*/)
				{
				}
			}
			if(true/*ПользовательИБ.УникальныйИдентификатор = ПользователиИнформационнойБазы.ТекущийПользователь().УникальныйИдентификатор*/)
			{
				if(true/*ЗначениеЗаполнено(ПользовательИБ.Имя)*/)
				{
				}
			}
			return null;
		}
		// Функция ПолноеИмяНеУказанногоПользователя возвращает
		// представление не указанного пользователя, т.е. когда
		// список пользователей пуст.
		//
		// Возвращаемое значение:
		//  Строка.
		//

		public object ПолноеИмяНеУказанногоПользователя(/**/)
		{
			//Возврат НСтр("ru = '<Не указан>'");
			return null;
		}
		// Возвращает доступность хотя бы одной из указанных ролей или полноправность
		// пользователя (текущего или указанного).
		//
		// Параметры:
		//  ИменаРолей   - Строка - имена ролей, разделенные запятыми, доступность которых проверяется.
		//
		//  Пользователь - Неопределено - проверяется текущий пользователь ИБ;
		//                 СправочникСсылка.Пользователи,
		//                 СправочникСсылка.ВнешниеПользователи - осуществляется поиск
		//                    пользователя ИБ по уникальному идентификатору,
		//                    заданному в реквизите ИдентификаторПользователяИБ
		//                    Прим.: если пользователь ИБ не найден, возвращается Ложь.
		//                 ПользовательИнформационнойБазы - проверяется указанный
		//                    пользователь ИБ
		//
		// Возвращаемое значение:
		//  Булево - Истина, если хотя бы одна из указанных ролей доступна,
		//           или функция ЭтоПолноправныйПользователь(Пользователь) возвращает Истина.
		//

		public object РолиДоступны(/*Знач ИменаРолей, Пользователь = Неопределено*/)
		{
			if(true/*ЭтоПолноправныйПользовательИБ(Пользователь)*/)
			{
			}
			//УстановитьПривилегированныйРежим(Истина);
			if(true/*Пользователь = Неопределено ИЛИ Пользователь = АвторизованныйПользователь()*/)
			{
				//ПользовательИБ = ПользователиИнформационнойБазы.ТекущийПользователь();
			}
			//УказанТекущийПользовательИБ = ПользовательИБ.УникальныйИдентификатор = ПользователиИнформационнойБазы.ТекущийПользователь().УникальныйИдентификатор;
			//МассивИменРолей = СтроковыеФункцииКлиентСервер.РазложитьСтрокуВМассивПодстрок(ИменаРолей);
			return null;
		}
	}
}
