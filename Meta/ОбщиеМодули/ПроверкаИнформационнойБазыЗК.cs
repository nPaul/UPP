﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПроверкаИнформационнойБазыЗК
	{
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ СООБЩЕНИЯ ОБ ОШИБКАХ НАСТРОЙКИ ПВР
		//
		// Процедура сообщает об ошибках настройки списка ведущих и вытесняющих в.р.
		// в общей форме ДиалогОшибкаВопрос и вызывает обработку исправления ошибок
		//

		public void СообщитьОбОшибкеНастройкиВР(/*Событие, ЕстьОшибкиВытеснения = Ложь, ЕстьОшибкиВедущих = Ложь*/)
		{
			//Форма = ПолучитьОбщуюФорму("ДиалогОшибкаВопрос");
			if(true/*Событие = "ОбновлениеКонфигурации"*/)
			{
				//Форма.Заголовок	= "Обновление конфигурации";
				/*Форма.ЭлементыФормы.НадписьСообщениеОПроблеме.Заголовок =
		"Конфигурация не может быть обновлена.
		|Обнаружены ошибки в настройках видов расчета.";*/
				/*Форма.ЭлементыФормы.НадписьДействияПользователя.Заголовок =
		"Перед обновление конфигурации необходимо исправить ошибки настройки видов расчета.
		|
		|Вы можете сделать это сейчас или позже, выполнив команду меню «Сервис – Служебные – Проверка и исправление ошибок настройки видов расчета».";*/
				//Форма.ЭлементыФормы.КнопкаДействие1.Заголовок = "Исправить сейчас";
				//Форма.ЭлементыФормы.КнопкаДействие2.Заголовок = "Я исправлю позже";
			}
			//Результат = Форма.ОткрытьМодально();
			if(true/*Не ПустаяСтрока(Результат) и Результат = "1"*/)
			{
				//ФормаОбработки = Обработки.ПроверкаНастройкиВедущихВытесняющихВР.ПолучитьФорму(,,);
				//ФормаОбработки.Открыть();
			}
		}
		// Процедура вызывает проверку настройки списка ведущих и вытесняющих в.р.
		// и сообщает об ошибках с возможностью вызова обработки исправления ошибок
		//

		public void ПроверитьНастройкуВедущихВытесняющихВРиСообщитьОбОшибках(/*Событие*/)
		{
			//ТаблицаПлохихВРВытесняющие = "";
			//ТаблицаПлохихВРВедущие = "";
			if(true/*ЕстьОшибкиНастройкиВедущихВытесняющихВР( ,ТаблицаПлохихВРВытесняющие, ,ТаблицаПлохихВРВедущие)*/)
			{
				//ЕстьОшибкиВытеснения = ТаблицаПлохихВРВытесняющие.Количество()>0;
				//ЕстьОшибкиВедущих 	 = ТаблицаПлохихВРВедущие.Количество()>0;
				//СообщитьОбОшибкеНастройкиВР(Событие, ЕстьОшибкиВытеснения, ЕстьОшибкиВедущих);
			}
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПРОВЕРКИ НАСТРОЙКИ ПВР
		//
		// Процедура формирует тексты запросов для получения списка видов расчета из всех ПВР
		// в список помещаются в.р. из тех ПВР, по которым у пользователя есть право "Изменение"
		//
		//	Параметры
		//		ТекстЗапросаВытесняющие - переменная в которую помещаем текст запроса списка в.р. для проверки вытеснения
		//		ТекстЗапросаВедущие     - переменная, в которую помещаем текст запроса списка в.р. проверки ведущих в.р.
		//

		public void ПолучитьТекстыЗапросовСписковВР(/*ТекстЗапросаВытесняющие, ТекстЗапросаВедущие*/)
		{
			//Номер = 1;
		}
		//ПолучитьТаблицуПлохихВедущихВытесняющихВР
		// Функция проверяет настройку списка ведущих или вытесняющих в.р. и формирует таблицу значений с «плохими» в.р
		//
		//	Параметры
		//	ТаблицаВРДляПроверки - таблица значений
		//				Ссылка      - ссылка на вид расчета настройку которого проверяем
		//				ВидРасчета  - ссылка на вид расчета, который входит в список вытесняющих или ведущих в.р вида расчета из поля Ссылка
		//				Наименование - наименование проверяемого в.р.
		//				Предопределенный - ВидРасчета входит в список ведущих или вытесняющих в.р. Ссылка как предопределенный
		//				НомерПВР - номер для сортировки
		//
		//	Возвращаемое значение
		//		Таблица значений "плохих" в.р.
		//

		public object ПолучитьТаблицуПлохихВедущихВытесняющихВР(/*ТаблицаВРДляПроверки*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.МенеджерВременныхТаблиц = Новый МенеджерВременныхТаблиц;
			//Запрос.УстановитьПараметр("ТаблицаВР", ТаблицаВРДляПроверки);
			/*// результат запроса - ТаблицаРезультатов
*/
			/*// Поля
*/
			/*// 	Ссылка - вид расчета, корректировку которого необходимо произвести
*/
			/*// 	ВидРасчетаУдалить - вид расчета, который необходимо удалить из списка вытесняющих/ведущих
*/
			/*// 	ВидРасчетаДобавить - вид расчета, который необходимо добавить в список вытесняющих/ведущих
*/
			/*// 	Предопределенный - этот ВР нельзя удалять из списка
*/
			/*// 	ОбязательныйКУдалению - ВР обязательный к удалению из-за циклической ссылки
*/
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	СписокВР.Ссылка КАК Ссылка,
	|	СписокВР.Наименование КАК Наименование,
	|	СписокВР.ВидРасчета КАК ВидРасчета,
	|	СписокВР.Предопределенный,
	|	СписокВР.НомерПВР
	|ПОМЕСТИТЬ ВТ_СписокВР
	|ИЗ
	|	&ТаблицаВР КАК СписокВР
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	Ссылка,
	|	ВидРасчета
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ОсновнойСписокВР.Ссылка КАК Ссылка,
	|	ОсновнойСписокВР.ВидРасчета КАК ВидРасчетаУдалить,
	|	ДополнительныйСписокВР.ВидРасчета КАК ВидРасчетаДобавить,
	|	ОсновнойСписокВР.Предопределенный КАК Предопределенный,
	|	ОсновнойСписокВР.НомерПВР,
	|	ОсновнойСписокВР.Наименование
	|ПОМЕСТИТЬ ВТ_ОсновнойСписокВР
	|ИЗ
	|	ВТ_СписокВР КАК ОсновнойСписокВР
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТ_СписокВР КАК ДополнительныйСписокВР
	|		ПО ОсновнойСписокВР.ВидРасчета = ДополнительныйСписокВР.Ссылка
	|ГДЕ
	|	(НЕ ДополнительныйСписокВР.ВидРасчета ЕСТЬ NULL )
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	Ссылка
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ОсновнойСписокВР.Ссылка КАК Ссылка,
	|	ОсновнойСписокВР.ВидРасчетаУдалить КАК ВидРасчетаУдалить,
	|	ОсновнойСписокВР.ВидРасчетаДобавить КАК ВидРасчетаДобавить,
	|	ОсновнойСписокВР.Предопределенный,
	|	ВЫБОР
	|		КОГДА ОсновнойСписокВР.Ссылка = ОсновнойСписокВР.ВидРасчетаДобавить
	|			ТОГДА ИСТИНА
	|		ИНАЧЕ ЛОЖЬ
	|	КОНЕЦ КАК ОбязательныйКУдалению,
	|	ОсновнойСписокВР.НомерПВР КАК НомерПВР
	|ИЗ
	|	ВТ_ОсновнойСписокВР КАК ОсновнойСписокВР
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТ_СписокВР КАК ДополнительныйСписокВР
	|		ПО ОсновнойСписокВР.Ссылка = ДополнительныйСписокВР.Ссылка
	|			И ОсновнойСписокВР.ВидРасчетаДобавить = ДополнительныйСписокВР.ВидРасчета
	|ГДЕ
	|	ДополнительныйСписокВР.ВидРасчета ЕСТЬ NULL 
	|
	|УПОРЯДОЧИТЬ ПО
	|	НомерПВР,
	|	ОсновнойСписокВР.Наименование
	|АВТОУПОРЯДОЧИВАНИЕ";*/
			return null;
		}
		//ПолучитьТаблицуПлохихВедущихВытесняющихВР
		// Экспортная функция, выполняющая проверку настройки списка ведущих и вытесняющих в.р.
		//	Пераметры
		//		ТаблицаВРВытесняющие, ТаблицаВРВедущие - таблицы значений, в которые будут переданы таблицы вытесняющих и ведущих в.р.
		//		ТаблицаПлохихВРВытесняющие, ТаблицаПлохихВРВедущие - таблицы значений, в которые будут переданы таблицы "плохих" вытесняющих и ведущих в.р.
		//
		// Возвращаемое значение
		//		Булево - результат проверки, Истина - есть ошибки настройки
		//

		public object ЕстьОшибкиНастройкиВедущихВытесняющихВР(/*ТаблицаВРВытесняющие = Неопределено, ТаблицаПлохихВРВытесняющие = Неопределено,
													ТаблицаВРВедущие = Неопределено, ТаблицаПлохихВРВедущие = Неопределено*/)
		{
			//ТекстЗапросаВытесняющие = "";
			//ТекстЗапросаВедущие = "";
			//ПолучитьТекстыЗапросовСписковВР(ТекстЗапросаВытесняющие, ТекстЗапросаВедущие);
			//Запрос = Новый Запрос;
			//ЕстьОшибкиВытесняющихВР = Ложь;
			if(true/*Не ПустаяСтрока(ТекстЗапросаВытесняющие)*/)
			{
				//Запрос.Текст =  ТекстЗапросаВытесняющие;
				//ТаблицаВРВытесняющие = Запрос.Выполнить().Выгрузить();
				//ТаблицаПлохихВРВытесняющие = ПолучитьТаблицуПлохихВедущихВытесняющихВР(ТаблицаВРВытесняющие);
				//ЕстьОшибкиВытесняющихВР = ТаблицаПлохихВРВытесняющие.Количество()>0;
			}
			//ЕстьОшибкиВедущихВР = Ложь;
			if(true/*Не ПустаяСтрока(ТекстЗапросаВедущие)*/)
			{
				//Запрос.Текст =  ТекстЗапросаВедущие;
				//ТаблицаВРВедущие = Запрос.Выполнить().Выгрузить();
				//ТаблицаПлохихВРВедущие = ПолучитьТаблицуПлохихВедущихВытесняющихВР(ТаблицаВРВедущие);
				//ЕстьОшибкиВедущихВР = ТаблицаПлохихВРВедущие.Количество()>0;
			}
			return null;
		}
	}
}
