﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПользователиДополнительный
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции

		public object ПользовательИмеетУправленческиеРоли(/*Код*/)
		{
			//ПользовательИБ = УправлениеПользователями.НайтиПользователяИБ(СокрЛП(Код));
			if(true/*ПользовательИБ = Неопределено*/)
			{
			}
			//РолиУправленческогоУчета = Новый Массив;
			//РолиУправленческогоУчета.Добавить(Метаданные.Роли.ПолныеПрава);
			//РолиУправленческогоУчета.Добавить(Метаданные.Роли.КадровикУправленческихДанных);
			//РолиУправленческогоУчета.Добавить(Метаданные.Роли.РасчетчикУправленческойЗарплаты);
			return null;
		}
		// Проверка доступности роли "управленческого" кадровика
		// это или КадровикУправленческихДанных или полные права
		// Применяется для проверки прав на доступ к кадровым даннам, например,
		// в формах или при выводе на печать
		// Возвращаемое значение:
		//	булево - истина если есть доступ к "кадровым" данным

		public object ДоступнаРольКадровикаУпр(/**/)
		{
			return null;
		}
		//ДоступнаРольРасчетчика
	}
}
