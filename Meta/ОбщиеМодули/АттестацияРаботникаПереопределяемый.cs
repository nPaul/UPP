﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class АттестацияРаботникаПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы

		public object СформироватьЗапросПоКомпетенциям(/*ЭтотОбъект*/)
		{
			/*// Получить список компетенций
*/
			//Запрос = Новый Запрос;
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	ДолжностныеКомпетенцииРаботников.Компетенция
	|ИЗ
	|	РегистрСведений.ДолжностныеКомпетенцииРаботников КАК ДолжностныеКомпетенцииРаботников
	|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ (ВЫБРАТЬ
	|			РаботникиСрезПоследних.ФизЛицо КАК ФизЛицо,
	|			РаботникиСрезПоследних.Должность.Должность КАК Должность
	|		ИЗ
	|			РегистрСведений.Работники.СрезПоследних(, ФизЛицо = &ФизЛицо) КАК РаботникиСрезПоследних) КАК ВложенныйЗапрос
	|		ПО ДолжностныеКомпетенцииРаботников.Должность = ВложенныйЗапрос.Должность";*/
			//Запрос.УстановитьПараметр("ФизЛицо", ЭтотОбъект.Физлицо);
			return null;
		}

		public void ФормаДокументаПередОткрытиемДополнительно(/*Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ФормаДокументаДополнительныеДействия(/*ИмяКоманды, Форма*/)
		{
			if(true/*ИмяКоманды = "ОткрытьАнкету"*/)
			{
				//ЭлементыФормы = Форма.ЭлементыФормы;
				if(true/*ЭлементыФормы.СписокКомпетенций.ТекущаяСтрока = неопределено*/)
				{
				}
				//ТиповаяАнкета = ЭлементыФормы.СписокКомпетенций.ТекущаяСтрока.Компетенция.ТиповаяАнкета;
				if(true/*НЕ ЗначениеЗаполнено(ТиповаяАнкета)*/)
				{
					//Ответ = Вопрос ("Типовая анкета не выбрана в справочнике компетенций. Открыть компетенцию?", РежимДиалогаВопрос.ДаНет);
					if(true/*Ответ = КодВозвратаДиалога.Да*/)
					{
						//ЭлементыФормы.СписокКомпетенций.ТекущаяСтрока.Компетенция.ПолучитьФорму().Открыть();
					}
				}
				//ТиповаяАнкета.ПолучитьФорму().Открыть();
			}
		}
	}
}
