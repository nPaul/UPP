﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ОбновлениеКонфигурацииКлиентСервер
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры и функции
		// Возвращает структуру настроек обновления конфигурации и обновляет их.
		//
		// Параметры:
		//	НастройкиОбновления - структура - старые настройки обновления, которые необходимо обновить
		//
		// Возвращаемое значение:
		//   Структура   – структура настроек обновления.
		//

		public object ПолучитьОбновленныеНастройкиОбновленияКонфигурации(/*НастройкиОбновления*/)
		{
			if(true/*НастройкиОбновления = Неопределено*/)
			{
				//НастройкиОбновления = НовыеНастройкиОбновленияКонфигурации();
			}
			return null;
		}
		// Заполняет структуру настроек обновления конфигурации и возвращает их.
		//
		// Возвращаемое значение:
		//   Структура   – структура настроек обновления.
		//

		public object НовыеНастройкиОбновленияКонфигурации(/**/)
		{
			//Результат = Новый Структура;
			//Результат.Вставить("ПропускатьПриветствие", Ложь);
			//Результат.Вставить("КодПользователяСервераОбновлений", "");
			//Результат.Вставить("ПарольСервераОбновлений", "");
			//Результат.Вставить("ЗапомнитьПарольСервераОбновлений", Истина);
			//Результат.Вставить("ПроверятьНаличиеОбновленияПриЗапуске", Ложь);
			//Результат.Вставить("ИсточникОбновления", 2);
			//Результат.Вставить("РежимОбновления", ?(ОбщегоНазначения.ИнформационнаяБазаФайловая(), 0, 2));
			//Результат.Вставить("РежимОбновления", ?(СтандартныеПодсистемыВызовСервераПереопределяемый.ПараметрыРаботыКлиента().ИнформационнаяБазаФайловая, 0, 2));
			//Результат.Вставить("ДатаВремяОбновления", ДобавитьДни(НачалоДня(ТекущаяДата()), 1));
			//Результат.Вставить("ВыслатьОтчетНаПочту", Ложь);
			//Результат.Вставить("АдресЭлектроннойПочты", "");
			//Результат.Вставить("КодЗадачиПланировщика", 0);
			//Результат.Вставить("РасписаниеПроверкиНаличияОбновления", Неопределено);
			//Результат.Вставить("ПовторныйЗапуск", Ложь);
			//Результат.Вставить("ИмяФайлаОбновления", "");
			//Результат.Вставить("НуженФайлОбновления", 1);
			//Результат.Вставить("СоздаватьРезервнуюКопию", 1);
			//Результат.Вставить("ИмяКаталогаРезервнойКопииИБ", "");
			//Результат.Вставить("ВосстанавливатьИнформационнуюБазу", Ложь);
			//Результат.Вставить("АдресСервераДляПроверкиНаличияОбновления", "");
			//Результат.Вставить("КаталогОбновлений", "");
			//Результат.Вставить("КороткоеИмяКонфигурации", "");
			//Результат.Вставить("АдресРесурсаДляПроверкиНаличияОбновления", "");
			//Результат.Вставить("ДискИТС", "");
			//Результат.Вставить("ИсточникДискаИТС", 0);
			//Результат.Вставить("КластерТребуетАутентификации", Ложь);
			//Результат.Вставить("ИмяАдминистратораКластера", "");
			//Результат.Вставить("ПарольАдминистратораКластера", "");
			//Результат.Вставить("НестандартныеПортыСервера", Ложь);
			//Результат.Вставить("ПортАгентаСервера", 0);
			//Результат.Вставить("ПортКластераСерверов", 0);
			//Результат.Вставить("ВремяПоследнейПроверкиОбновления", Дата(1, 1, 1));
			return null;
		}
		// Добавляет заданное количество дней к дате
		//
		// Параметры:
		//  Дата		- Дата	- Исходная дата
		//  ЧислоДней	- Число	- Количество дней, добавляемых к исходной дате
		//

		public object ДобавитьДни(/*Знач Дата, Знач ЧислоДней*/)
		{
			if(true/*ЧислоДней > 0*/)
			{
				//Разница = День(Дата) + ЧислоДней - День(КонецМесяца(Дата));
				if(true/*Разница > 0*/)
				{
					//НоваяДата = ДобавитьМесяц(Дата, 1);
				}
			}
			return null;
		}
	}
}
