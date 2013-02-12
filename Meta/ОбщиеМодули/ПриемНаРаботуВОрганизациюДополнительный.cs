﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПриемНаРаботуВОрганизациюДополнительный
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта
		// Заполняет табличную часть документа "Работники" списком работников компании
		//

		public void ЗаполнитьТабличнуюЧастьРаботникиПринятымиВКомпанию(/*Объект, ДатаНачалаПериода, ДатаОкончанияПериода*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("ДатаНачалаПериода",		ДатаНачалаПериода);
			//Запрос.УстановитьПараметр("ДатаОкончанияПериода",	ДатаОкончанияПериода);
			//Запрос.УстановитьПараметр("Организация",			Объект.Организация);
			//Запрос.УстановитьПараметр("Дата",					Объект.Дата);
			/*Запрос.Текст =
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	ВложенныйЗапрос.Сотрудник,
	|	ВложенныйЗапрос.Сотрудник.Физлицо КАК Физлицо,
	|	СоответствиеПодразделенийИПодразделенийОрганизаций.ПодразделениеОрганизации,
	|	ПриемыВКомпанию.Должность КАК Должность,
	|	ВложенныйЗапрос.ЗанимаемыхСтавок,
	|	ВложенныйЗапрос.ДатаПриема,
	|	ВложенныйЗапрос.ИспытательныйСрок,
	|	ПриемыВКомпанию.ДатаУвольнения,
	|	ПриемыВКомпанию.ГрафикРаботы,
	|	ИСТИНА КАК НапомнитьПоЗавершении
	|ИЗ
	|	(ВЫБРАТЬ
	|		ВложенныйЗапрос.Сотрудник КАК Сотрудник,
	|		ВложенныйЗапрос.ДатаПриема КАК ДатаПриема,
	|		0 КАК ИспытательныйСрок,
	|		1 КАК ЗанимаемыхСтавок
	|	ИЗ
	|		(ВЫБРАТЬ РАЗЛИЧНЫЕ
	|			ПриемыВКомпанию.Сотрудник КАК Сотрудник,
	|			МИНИМУМ(ПриемыВКомпанию.ДатаПриема) КАК ДатаПриема
	|		ИЗ
	|			Документ.ПриемНаРаботу.Работники КАК ПриемыВКомпанию
	|		ГДЕ
	|			ПриемыВКомпанию.Ссылка.Проведен
	|			И ПриемыВКомпанию.ДатаПриема МЕЖДУ &ДатаНачалаПериода И &ДатаОкончанияПериода
	|		
	|		СГРУППИРОВАТЬ ПО
	|			ПриемыВКомпанию.Сотрудник) КАК ВложенныйЗапрос
	|			ЛЕВОЕ СОЕДИНЕНИЕ Документ.ПриемНаРаботу.Работники КАК ПриемыВКомпанию
	|			ПО ВложенныйЗапрос.ДатаПриема = ПриемыВКомпанию.ДатаПриема
	|				И ВложенныйЗапрос.Сотрудник = ПриемыВКомпанию.Сотрудник
	|	
	|	СГРУППИРОВАТЬ ПО
	|		ВложенныйЗапрос.ДатаПриема,
	|		ВложенныйЗапрос.Сотрудник) КАК ВложенныйЗапрос
	|		ЛЕВОЕ СОЕДИНЕНИЕ Документ.ПриемНаРаботу.Работники КАК ПриемыВКомпанию
	|			ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.СоответствиеПодразделенийИПодразделенийОрганизаций КАК СоответствиеПодразделенийИПодразделенийОрганизаций
	|			ПО ПриемыВКомпанию.Подразделение = СоответствиеПодразделенийИПодразделенийОрганизаций.Подразделение
	|				И (СоответствиеПодразделенийИПодразделенийОрганизаций.Организация = &Организация)
	|		ПО ВложенныйЗапрос.ДатаПриема = ПриемыВКомпанию.ДатаПриема
	|			И ВложенныйЗапрос.Сотрудник = ПриемыВКомпанию.Сотрудник
	|
	|УПОРЯДОЧИТЬ ПО
	|	ВложенныйЗапрос.Сотрудник.Наименование";*/
			//Объект.ОсновныеНачисления.Очистить();
			//Объект.РаботникиОрганизации.Загрузить(Запрос.Выполнить().Выгрузить());
		}
		// ЗаполнитьТабличнуюЧастьРаботникиПринятымиВКомпанию()

		public void ДополнитьСтруктуруПечатныхФорм(/*СтруктураПечатныхФорм, ДокументОбъект*/)
		{
			/*// В этой конфигурации структура печатных форм не дополняется
*/
		}

		public object ПечатьДополнительныхФорм(/*ИмяМакета, Объект*/)
		{
			return null;
		}

		public void ДобавитьДополнительноПоСтроке(/*ДокументОбъект, СтрокаТабличнойЧасти*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ДобавитьДополнительныеДвижения(/*ДокументОбъект, Отказ, Заголовок*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ЗаполнитьДополнительно(/*ДокументОбъект*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ДвиженияНаДатуУвольненияДополнительно(/*Движение*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ДополнитьДвиженияПоСостояниюРаботниковНаИспытательномСроке(/*Движение, ВыборкаПоРаботникиОрганизации*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

		public void ДополнитьСоставКолонок(/*Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void РаботникиОрганизацийПриПолученииДанныхДополнительно(/*ПолеРаботники, ОформленияСтрок*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ФормаДокументаПередОткрытиемДополнительно(/*Форма, ДополнительныеДействия, ДополнительныеОбработчики*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ВыполнитьДополнительныеДействия(/*Форма, Кнопка*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ОбработатьДополнительноПриИзменении(/*Форма, Элемент*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void УдалитьДополнительноПоСтроке(/*Форма, Сотрудник*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ФормаДокументаРаботникиПослеУдаленияСтрокиДополнительно(/*Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы списка

		public void ФормаСпискаПередОткрытиемДополнительно(/*ФормаСписка*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаСпискаПередОткрытиемДополнительно
	}
}
