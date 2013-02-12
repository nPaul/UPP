﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class СтруктураПодчиненностиПереопределяемый
	{
		// Формирует массив реквизитов документа.
		//
		// Параметры:
		// ИмяДокумента - Строка - имя документа.
		//
		// Возвращаемое значение:
		// Массив - массив наименований реквизитов документа.
		//

		public object МассивДополнительныхРеквизитовДокумента(/*ИмяДокумента*/)
		{
			//МассивДопРеквизитов = Новый Массив;
			return null;
		}
		// Получает предстваление документа для печати
		//
		// Параметры
		//  Выборка  - КоллекцияДанных - структура или выборка из результатов запроса
		//                 в которой содержатся дополнительные реквизиты, на основании
		//                 которых можно сформировать переопределенное предстваление до-
		//                 кумента для вывода в отчет "Структура подчиненности"
		//
		// Возвращаемое значение:
		//   Строка,Неопределено   - переопределенное представление документа, или Нео-
		//                пределено, если для данного типа документов такое не задано.
		//

		public object ПолучитьПредставлениеДокументаДляПечати(/*Выборка*/)
		{
			return null;
		}
	}
}
