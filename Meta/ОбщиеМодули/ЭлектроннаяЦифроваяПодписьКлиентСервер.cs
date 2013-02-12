﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЭлектроннаяЦифроваяПодписьКлиентСервер
	{
		////////////////////////////////////////////////////////////////////////////////
		//  ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ДЛЯ РАБОТЫ С ЭЦП
		// Получает назначение сертификата ЭЦП
		//
		// Параметры
		//  ФиксированныйМассивСвойств  - ФиксированныйМассив - массив расширенных свойств сертификата (EKU)

		public object ПолучитьНазначение(/*ФиксированныйМассивСвойств*/)
		{
			//Назначение = "";
			return null;
		}
		// Получает представление поля КомуВыдан или КемВыдан сертификата ЭЦП
		//
		// Параметры
		//  СтруктураПользователя  - Структура - структура поля КомуВыдан или КемВыдан сертификата
		// Возвращаемое значение - Строка - представление
		//
		// Возвращаемое значение:
		//   Строка  - представление

		public object ПолучитьПредставлениеПользователя(/*СтруктураПользователя*/)
		{
			//Представление = "";
			//CN = "";
			if(true/*СтруктураПользователя.Свойство("CN", CN)*/)
			{
				//Представление = Представление + CN;
			}
			//O = "";
			if(true/*СтруктураПользователя.Свойство("O", O)*/)
			{
				//Представление = Представление + ", " + O;
			}
			//OU = "";
			if(true/*СтруктураПользователя.Свойство("OU", OU)*/)
			{
				//Представление = Представление + ", " + OU;
			}
			return null;
		}
		// Заполняет структуру полями сертификата
		//
		// Параметры
		//  Сертификат  - СертификатКриптографии - сертификат криптографии
		//
		// Возвращаемое значение:
		//   Структура  - структура с полями сертификата

		public object ЗаполнитьСтруктуруСертификата(/*Сертификат*/)
		{
			//КомуВыдан = ПолучитьПредставлениеПользователя(Сертификат.Субъект);
			//КемВыдан = ПолучитьПредставлениеПользователя(Сертификат.Издатель);
			//ДействителенДо = Сертификат.ДатаОкончания;
			//EKU = Неопределено;
			if(true/*Сертификат.РасширенныеСвойства.Свойство("EKU", EKU)*/)
			{
				//Назначение = ПолучитьНазначение(EKU);
			}
			//Отпечаток = Base64Строка(Сертификат.Отпечаток);
			/*СтруктураВозврата = Новый Структура("КомуВыдан, КемВыдан, ДействителенДо, Назначение, Отпечаток",
		КомуВыдан, КемВыдан, ДействителенДо, Назначение, Отпечаток);*/
			return null;
		}
	}
}
