﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РаботаСПочтовымиСообщениямиКлиент
	{
		// Выполняет проверку учетной записи
		//
		// Параметры
		// УчетнаяЗапись - СправочникСсылка.УчетныеЗаписиЭлектроннойПочты - учетная запись,
		//					которую нужно проверить
		//

		public void ПроверитьУчетнуюЗапись(/*знач УчетнаяЗапись*/)
		{
			//ОчиститьСообщения();
			//Состояние(НСтр("ru = 'Проверка учетной записи'"),,НСтр("ru = 'Выполняется проверка учетной записи. Подождите...'"));
			if(true/*ЭлектроннаяПочта.ПарольЗадан(УчетнаяЗапись)*/)
			{
				//ПарольПараметр = Неопределено;
			}
			//СообщениеОбОшибке = "";
			//ДополнительноеСообщение = "";
			//ЭлектроннаяПочта.ПроверитьВозможностьОтправкиИПолученияЭлектроннойПочты(УчетнаяЗапись, ПарольПараметр, СообщениеОбОшибке, ДополнительноеСообщение);
			if(true/*ЗначениеЗаполнено(СообщениеОбОшибке)*/)
			{
				/*Предупреждение(СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(
						НСтр("ru = 'Проверка параметров учетной записи завершилась с ошибками:
								   |%1'"), СообщениеОбОшибке ),,
						НСтр("ru = 'Проверка учетной записи'"));*/
			}
		}
		// ПроверитьУчетнуюЗапись()
	}
}
