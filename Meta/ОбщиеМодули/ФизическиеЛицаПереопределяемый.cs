﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ФизическиеЛицаПереопределяемый
	{

		public void ДополнитьСтруктуруДанныхЗапросом(/*Запрос, СтруктураДанных*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ДополнитьДанныеКадровогоУчета(/*Запрос, СтруктураДанных*/)
		{
			if(true/*ПользователиДополнительный.ДоступнаРольКадровикаУпр()*/)
			{
				/*Запрос.Текст = 
		"ВЫБРАТЬ РАЗРЕШЕННЫЕ
		|	РаботникиСрезПоследних.ЗанимаемыхСтавок,
		|	РаботникиСрезПоследних.Должность.Представление КАК Должность,
		|	РаботникиСрезПоследних.Подразделение.Представление КАК Подразделение,
		|	ВЫБОР
		|		КОГДА РаботникиСрезПоследних.ПричинаИзмененияСостояния = ЗНАЧЕНИЕ(Перечисление.ПричиныИзмененияСостояния.Увольнение)
		|			ТОГДА ""Не работает (уволен)""
		|		ИНАЧЕ ""Работает""
		|	КОНЕЦ КАК Состояние
		|ИЗ
		|	РегистрСведений.Работники.СрезПоследних(&ДатаАктуальности, ФизЛицо = &ФизЛицо) КАК РаботникиСрезПоследних";*/
				//Запрос.УстановитьПараметр("Уволен",Перечисления.ПричиныИзмененияСостояния.Увольнение);
				//РезультатЗапроса = Запрос.Выполнить();
				//Выборка = РезультатЗапроса.Выбрать();
				//Выборка.Следующий();
				if(true/*Выборка.Состояние <> Null*/)
				{
					//СтруктураДанных.Вставить("Работники", РезультатЗапроса.Выбрать());
				}
				if(true/*НЕ РезультатЗапроса.Пустой()*/)
				{
					/*Запрос.Текст = 
			"ВЫБРАТЬ
			|	ПриемНаРаботуРаботники.Ссылка КАК Документ,
			|	ПриемНаРаботуРаботники.Ссылка.Представление,
			|	ПриемНаРаботуРаботники.Ссылка.Дата КАК Дата,
			|	ПриемНаРаботуРаботники.ДатаПриема КАК ДатаС,
			|	ПриемНаРаботуРаботники.ДатаУвольнения КАК ДатаПо,
			|	ПриемНаРаботуРаботники.Подразделение КАК Подразделение,
			|	ПриемНаРаботуРаботники.Должность,
			|	ПриемНаРаботуРаботники.ЗанимаемыхСтавок,
			|	ПриемНаРаботуРаботники.ИспытательныйСрок КАК Примечание
			|ИЗ
			|	Документ.ПриемНаРаботу.Работники КАК ПриемНаРаботуРаботники
			|
			|ГДЕ
			|	ПриемНаРаботуРаботники.Сотрудник.ФизЛицо = &ФизЛицо И
			|	ПриемНаРаботуРаботники.Ссылка.Проведен
			|
			|ОБЪЕДИНИТЬ ВСЕ
			|
			|ВЫБРАТЬ
			|	КадровоеПеремещениеРаботники.Ссылка,
			|	КадровоеПеремещениеРаботники.Ссылка.Представление,
			|	КадровоеПеремещениеРаботники.Ссылка.Дата,
			|	КадровоеПеремещениеРаботники.ДатаНачала,
			|	КадровоеПеремещениеРаботники.ДатаОкончания,
			|	КадровоеПеремещениеРаботники.НовоеПодразделение,
			|	КадровоеПеремещениеРаботники.НоваяДолжность,
			|	КадровоеПеремещениеРаботники.ЗанимаемыхСтавок,
			|	NULL
			|ИЗ
			|	Документ.КадровоеПеремещение.Работники КАК КадровоеПеремещениеРаботники
			|
			|ГДЕ
			|	КадровоеПеремещениеРаботники.Сотрудник.ФизЛицо = &ФизЛицо И
			|	КадровоеПеремещениеРаботники.Ссылка.Проведен
			|
			|ОБЪЕДИНИТЬ ВСЕ
			|
			|ВЫБРАТЬ
			|	УвольнениеРаботники.Ссылка,
			|	УвольнениеРаботники.Ссылка.Представление,
			|	УвольнениеРаботники.Ссылка.Дата,
			|	УвольнениеРаботники.ДатаУвольнения,
			|	NULL,
			|	NULL,
			|	NULL,
			|	NULL,
			|	УвольнениеРаботники.ПричинаУвольнения
			|ИЗ
			|	Документ.Увольнение.Работники КАК УвольнениеРаботники
			|
			|ГДЕ
			|	УвольнениеРаботники.Сотрудник.ФизЛицо = &ФизЛицо И
			|	УвольнениеРаботники.Ссылка.Проведен
			|
			|УПОРЯДОЧИТЬ ПО
			|	Дата";*/
					//СтруктураДанных.Вставить("ПеремещенияВКомпании", Запрос.Выполнить().Выбрать());
					/*Запрос.Текст = 
			"ВЫБРАТЬ
			|	ОтсутствиеНаРаботеРаботники.ДатаНачала КАК ДатаС,
			|	ОтсутствиеНаРаботеРаботники.ДатаОкончания КАК ДатаПо,
			|	ОтсутствиеНаРаботеРаботники.Ссылка.Дата КАК Дата,
			|	ОтсутствиеНаРаботеРаботники.Ссылка.Представление,
			|	ОтсутствиеНаРаботеРаботники.ПричинаОтсутствия,
			|	ВЫБОР
			|		КОГДА ОтсутствиеНаРаботеРаботники.ПричинаОтсутствия = ЗНАЧЕНИЕ(Справочник.ПричиныОтсутствияНаРаботе.ЕжегодныйОтпуск)
			|			ТОГДА ""Отпуск""
			|		ИНАЧЕ ОтсутствиеНаРаботеРаботники.ПричинаОтсутствия
			|	КОНЕЦ КАК ВидОтсутствия
			|ИЗ
			|	Документ.ОтсутствияНаРабочемМесте КАК ОтсутствиеНаРаботеРаботники
			|ГДЕ
			|	ОтсутствиеНаРаботеРаботники.Физлицо = &ФизЛицо
			|	И ОтсутствиеНаРаботеРаботники.Ссылка.Проведен
			|
			|УПОРЯДОЧИТЬ ПО
			|	ВидОтсутствия,
			|	Дата";*/
					//СтруктураДанных.Вставить("Отклонения", Запрос.Выполнить().Выбрать());
				}
			}
		}

		public void ПроверитьДополнительныеУсловия(/*ИмяОбновляемогоЭлемента, ЭтаФорма*/)
		{
			/*// В этой конфигурации дополнительных условий не предусмотрено
*/
		}

		public object ИмяОбновляемогоЭлементаДополнительно(/**/)
		{
			return null;
		}

		public object ТекстЗапросаРезультатыАнкетирования(/**/)
		{
			return null;
		}

		public void ПриКопировании(/*ЭтотОбъект, ОбъектКопирования*/)
		{
			//ФизическиеЛицаДополнительный.ПриКопировании(ЭтотОбъект, ОбъектКопирования);
		}

		public void ПередЗаписью(/*ЭтотОбъект, Отказ*/)
		{
			//ФизическиеЛицаДополнительный.ПередЗаписью(ЭтотОбъект, Отказ);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры печати

		public void Печать(/*МассивОбъектов, ПараметрыПечати, КоллекцияПечатныхФорм, ОбъектыПечати, ПараметрыВывода*/)
		{
			//ФизическиеЛицаДополнительный.Печать(МассивОбъектов, ПараметрыПечати, КоллекцияПечатныхФорм, ОбъектыПечати, ПараметрыВывода);
		}

		public object ПечатьСведенийОФизлице(/*Ссылка, ОбъектыПечати = Неопределено, НазваниеОтчета = Неопределено, Результат = Неопределено*/)
		{
			return null;
		}
	}
}
