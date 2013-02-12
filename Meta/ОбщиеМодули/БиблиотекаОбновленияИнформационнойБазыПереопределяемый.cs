﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class БиблиотекаОбновленияИнформационнойБазыПереопределяемый
	{
		// ИНТЕРФЕЙСНАЯ ЧАСТЬ ПЕРЕОПРЕДЕЛЯЕМОГО МОДУЛЯ
		// Возвращает список процедур-обработчиков обновления ИБ для всех поддерживаемых версий ИБ.
		//
		// Пример добавления процедуры-обработчика в список:
		//    Обработчик = Обработчики.Добавить();
		//    Обработчик.Версия = "1.0.0.0";
		//    Обработчик.Процедура = "ОбновлениеИБ.ПерейтиНаВерсию_1_0_0_0";
		//
		// Вызывается перед началом обновления данных ИБ.
		//

		public object ОбработчикиОбновления(/**/)
		{
			//Обработчики = ОбновлениеИнформационнойБазы.НоваяТаблицаОбработчиковОбновления();
			/*// Библиотеки УПП и ЗУП
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия    	= "*";
			//Обработчик.Процедура 	= "БиблиотекаОбновленияИнформационнойБазы.ВыполнитьОбновлениеИнформационнойБазы";
			/*// Библиотеки обмена ЭД
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия    	= "*";
			//Обработчик.Процедура 	= "ЭлектронныеДокументы.ВыполнитьОбновлениеИнформационнойБазы";
			/*// При создании новой базы
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия    	= "1.3.1.1";
			//Обработчик.Процедура    = "Справочники.СпособыРаспределенияЗатратНаВыпуск.ЗаполнитьСпособыРаспределенияПоУмолчанию";
			/*// Версия 1.3.23
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия       = "1.3.23.1";
			//Обработчик.Процедура    = "Справочники.СпособыРаспределенияЗатратНаВыпуск.ЗаполнитьСпособыРаспределенияПоУмолчанию";
			//Обработчик.Опциональный = Истина;
			/*//Вызывается явно при заполнении новой базы
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия       = "1.3.23.1";
			//Обработчик.Процедура    = "Справочники.СпособыРаспределенияЗатратНаВыпуск.ЗаполнитьЗначенияРеквизитовПоУмолчанию";
			//Обработчик.Опциональный = Истина;
			/*// В новой базе не требуется, вызывается для способов распределения, добавленных пользователями
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия       = "1.3.23.1";
			//Обработчик.Процедура    = "БиблиотекаОбновленияИнформационнойБазыПереопределяемый.УстановитьКонстантуНастройкиСпособовРаспределенияЗатрат";
			//Обработчик.Опциональный = Истина;
			/*// В новой базе не требуется - по умолчанию будут использоваться новые способы распределения
*/
			/*// Версия 1.3.24.1
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия       = "1.3.24.1";
			//Обработчик.Процедура    = "Справочники.СпособыРаспределенияЗатратНаВыпуск.ЗаполнитьСпособыРаспределенияПоУмолчанию";
			//Обработчик.Опциональный = Истина;
			/*// В новой базе не требуется - вызывается явно при заполнении новой базы
*/
			/*// Версия 1.3.24.2
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия       = "1.3.24.2";
			//Обработчик.Процедура    = "БиблиотекаОбновленияИнформационнойБазыПереопределяемый.ИзменитьНастройкуВыгрузкиСебестоимостиВРозницу";
			//Обработчик.Опциональный = Истина;
			/*// В новой базе не требуется
*/
			/*// Версия 1.3.25.1
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия       = "1.3.25.1";
			//Обработчик.Процедура    = "Справочники.СпособыРаспределенияЗатратНаВыпуск.ЗаполнитьСпособыРаспределенияПоУмолчанию";
			//Обработчик.Опциональный = Истина;
			/*// В новой базе не требуется - вызывается явно при заполнении новой базы
*/
			/*// Версия 1.3.28.1
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия       = "1.3.28.1";
			//Обработчик.Процедура    = "Справочники.СпособыРаспределенияЗатратНаВыпуск.ЗаполнитьСпособыРаспределенияПоУмолчанию";
			//Обработчик.Опциональный = Истина;
			/*// В новой базе не требуется - вызывается явно при заполнении новой базы
*/
			/*// Версия 1.3.29.1
*/
			//Обработчик = Обработчики.Добавить();
			//Обработчик.Версия       = "1.3.29.1";
			//Обработчик.Процедура    = "Справочники.СпособыРаспределенияЗатратНаВыпуск.ОбновитьСпособМатериальныеЗатраты";
			//Обработчик.Опциональный = Истина;
			return null;
		}
		///////////////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ ОБРАБОТКИ ДАННЫХ, НАКОПЛЕННЫХ В ИНФОРМАЦИОННОЙ БАЗЕ ("ОПЦИОНАЛЬНЫЕ")

		public void УстановитьКонстантуНастройкиСпособовРаспределенияЗатрат(/**/)
		{
			//Константы.ИспользоватьГибкуюНастройкуСпособовРаспределенияЗатрат.Установить(Истина);
		}

		public void ИзменитьНастройкуВыгрузкиСебестоимостиВРозницу(/**/)
		{
			//ВыборкаУзлов = ПланыОбмена.ОбменУправлениеПредприятиемРозничнаяТорговля.Выбрать();
			while(true/*ВыборкаУзлов.Следующий()*/)
			{
				//УзелОбмена = ВыборкаУзлов.ПолучитьОбъект();
				if(true/*УзелОбмена.УдалитьВыгружатьСебестоимость*/)
				{
					//УзелОбмена.СпособВыгрузкиСебестоимости = Перечисления.СпособыВыгрузкиСебестоимостиВРозничнуюТорговлю.ВыгружатьСебестоимостьРегл;
				}
				//УзелОбмена.Записать();
			}
			//;;
		}
	}
}
