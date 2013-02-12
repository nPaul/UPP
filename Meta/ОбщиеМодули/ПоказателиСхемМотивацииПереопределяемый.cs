﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПоказателиСхемМотивацииПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта

		public object ДопустимыйТипПоказателя(/*ТипПоказателя*/)
		{
			//Массив = Новый Массив;
			//Массив.Добавить(Перечисления.ТипыПоказателейСхемМотивации.ОценочнаяШкалаПроцентная);
			//Массив.Добавить(Перечисления.ТипыПоказателейСхемМотивации.ОценочнаяШкалаЧисловая);
			if(true/*Массив.Найти(ТипПоказателя) <> Неопределено*/)
			{
			}
			return null;
		}

		public void ВыполнитьДополнительныеПроверки(/*Отказ, Форма*/)
		{
			//УправлениеПоказателямиСхемМотивации.ВыполнитьДополнительныеПроверки(Отказ, Форма);
		}

		public void ДополнитьСписокВозможностейИзменения(/*СписокВозможностейИзменения, ЭтаФорма*/)
		{
			if(true/*ЭтаФорма.ВидПоказателя <> Перечисления.ВидыПоказателейСхемМотивации.ДляВсехОрганизаций*/)
			{
				//СписокВозможностейИзменения.Добавить(Перечисления.ИзменениеПоказателейСхемМотивации.Ежемесячно);
			}
		}
		// Заполняет таблицу идентификаторов показателей схем мотивации
		//

		public void ЗаполнитьТаблицуПоказателей(/*ВидПВР, Переменные, ГенераторСлучайныхЧисел*/)
		{
			/*Запрос = Новый Запрос(
	"ВЫБРАТЬ
	|	ПоказателиСхемМотивации.Идентификатор КАК Идентификатор
	|ИЗ
	|	Справочник.ПоказателиСхемМотивации КАК ПоказателиСхемМотивации");*/
			if(true/*ВидПВР = "ПлановыеУдержанияРаботниковОрганизаций" Или ВидПВР = "ПлановыеУдержанияРаботников" Или ВидПВР = "ПлановыеДополнительныеНачисленияРаботниковОрганизаций"*/)
			{
				/*Запрос.Текст = Запрос.Текст + "
		|ГДЕ Не ПоказателиСхемМотивации.Ссылка В (&ПарамПоказатели)";*/
				//СписокПоказателей = Новый Массив;
				//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.ВремяВДнях);
				//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.ВремяВЧасах);
				//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.НормаВремениВДнях);
				//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.НормаВремениВЧасах);
				//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.СдельнаяВыработка);
				//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.ОтработаноВремениВДнях);
				//СписокПоказателей.Добавить(Справочники.ПоказателиСхемМотивации.ОтработаноВремениВЧасах);
				//Запрос.УстановитьПараметр("ПарамПоказатели", СписокПоказателей);
			}
			/*Запрос.Текст = Запрос.Текст + "
	|
	|УПОРЯДОЧИТЬ ПО
	|	ПоказателиСхемМотивации.Идентификатор";*/
			//Выборка = Запрос.Выполнить().Выбрать();
			//СтрокВКолонке = Цел(Выборка.Количество()/3);
			if(true/*СтрокВКолонке < Выборка.Количество()/3*/)
			{
				//СтрокВКолонке = СтрокВКолонке + 1;
			}
			while(true/*Выборка.Следующий()*/)
			{
				//Идентификатор = Выборка.Идентификатор;
				if(true/*ЗначениеЗаполнено(Идентификатор)*/)
				{
					//ЧислоДляИдентификатора = ГенераторСлучайныхЧисел.СлучайноеЧисло(10);
					//ЧислоДляИдентификатора = Окр(ЧислоДляИдентификатора / Pow(10, СтрДлина(Формат(ЧислоДляИдентификатора, "ЧГ=")) - 1), 10);
				}
			}
			//;;
		}
		//ЗаполнитьТаблицуПоказателей

		public void ОбновитьФормулыПВРсПоказателямиШкала(/*Ссылка*/)
		{
			//Запрос = Новый Запрос;
			/*Запрос.Текст =
	"ВЫБРАТЬ РАЗЛИЧНЫЕ
	|	ОсновныеНачисленияОрганизацийПоказатели.Ссылка
	|ИЗ
	|	ПланВидовРасчета.ОсновныеНачисленияОрганизаций.Показатели КАК ОсновныеНачисленияОрганизацийПоказатели
	|ГДЕ
	|	ОсновныеНачисленияОрганизацийПоказатели.Показатель = &Показатель
	|
	|ОБЪЕДИНИТЬ
	|
	|ВЫБРАТЬ
	|	ДополнительныеНачисленияОрганизацийПоказатели.Ссылка
	|ИЗ
	|	ПланВидовРасчета.ДополнительныеНачисленияОрганизаций.Показатели КАК ДополнительныеНачисленияОрганизацийПоказатели
	|ГДЕ
	|	ДополнительныеНачисленияОрганизацийПоказатели.Показатель = &Показатель
	|
	|ОБЪЕДИНИТЬ
	|
	|ВЫБРАТЬ
	|	УдержанияОрганизацийПоказатели.Ссылка
	|ИЗ
	|	ПланВидовРасчета.УдержанияОрганизаций.Показатели КАК УдержанияОрганизацийПоказатели
	|ГДЕ
	|	УдержанияОрганизацийПоказатели.Показатель = &Показатель";*/
			//Запрос.УстановитьПараметр("Показатель", Ссылка);
			//Выборка = Запрос.Выполнить().Выбрать();
			//ОбработкаКомментариев = глЗначениеПеременной("глОбработкаСообщений");
			if(true/*ТипЗнч(ОбработкаКомментариев) = Тип("ОбработкаОбъект.СообщенияВыполняемыхДействий")*/)
			{
				//ОбработкаКомментариев.УдалитьСообщения();
			}
			//МассивРазделителей = ПроведениеРасчетов.ПолучитьМассивРазделителей();
			//ОператорыИФункции				=  ".,+,-,/,*,ЦЕЛ,INT,ОКР,ROUND,МАКС,MAX,МИН,MIN,?,=,<,>,<=,>=,ОЦЕНИТЬПО,(,),И,ИЛИ,НЕ,OR,AND,NOT";
			//ОператорыИФункцииОднойСтрокой	=  ".,+,-,/,*,?,=,<,>,(,)";
			//ГенераторСлучайныхЧисел = Новый ГенераторСлучайныхЧисел(546819);
			while(true/*Выборка.Следующий()*/)
			{
				//ПВР = Выборка.Ссылка.ПолучитьОбъект();
				//Показатели = ПВР.Показатели;
				//ФормулаРасчетаДляФормулы = ПроведениеРасчетов.ПолучитьHTLMКодФормулыРасчета(ПВР.ФормулаРасчетаПредставление, Показатели, "Текст", Истина);
				//ПоказателиСхемМотивацииПереопределяемый.ЗаполнитьТаблицуПоказателей(ПВР, Переменные, ГенераторСлучайныхЧисел);
				//ФормулаРасчетаДляФормулы = ПроведениеРасчетов.ПолучитьHTLMКодФормулыРасчета(ФормулаРасчетаДляФормулы, Показатели, "Текст", Истина);
				//СЗПоказатели = Новый СписокЗначений;
				if(true/*Не ПроведениеРасчетов.ПроверкаИФормированиеФормулыРасчета(Ложь, СЗПоказатели, МассивРазделителей, ОператорыИФункцииОднойСтрокой, ОператорыИФункции, Переменные, ОбработкаКомментариев, ФормулаРасчетаДляФормулы, ПВР.ФормулаРасчета, ПВР.ФормулаРасчетаПредставление)*/)
				{
					//ПВР.Записать();
				}
			}
			//;;
		}

		public object ПервоеПодразделение(/*Подразделение, Организация, НазваниеОрганизации, ОтображенныеОрганизации*/)
		{
			if(true/*ОтображенныеОрганизации[Организация] <> Неопределено*/)
			{
			}
			//Запрос = Новый Запрос;
			/*Запрос.Текст = 
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ ПЕРВЫЕ 1
	|	ПодразделенияОрганизаций.Ссылка,
	|	ПодразделенияОрганизаций.Владелец.Наименование КАК НазваниеОрганизации
	|ИЗ
	|	Справочник.ПодразделенияОрганизаций КАК ПодразделенияОрганизаций
	|ГДЕ
	|	ПодразделенияОрганизаций.Владелец = &Организация
	|
	|УПОРЯДОЧИТЬ ПО
	|	ПодразделенияОрганизаций.Наименование ИЕРАРХИЯ";*/
			//Запрос.УстановитьПараметр("Организация", Организация);
			//Выборка = Запрос.Выполнить().Выбрать();
			//Выборка.Следующий();
			//НазваниеОрганизации = Выборка.НазваниеОрганизации;
			//Возврат Выборка.Ссылка = Подразделение;
			return null;
		}
		//ПервоеПодразделение

		public void ДополнитьТипыВидимыхПоказателей(/*ТипыПоказателей*/)
		{
			//УправлениеПоказателямиСхемМотивации.ДополнитьТипыВидимыхПоказателей(ТипыПоказателей);
		}
		// ДополнитьТипыВидимыхПоказателей

		public void ДополнитьТипыПоказателейСОграничениемВида(/*ТипыПоказателей*/)
		{
			//УправлениеПоказателямиСхемМотивации.ДополнитьТипыПоказателейСОграничениемВида(ТипыПоказателей);
		}
		// ДополнитьТипыПоказателейСОграничениемВида

		public void ДополнитьТипыПоказателейСОграничениемВозможностиИзменения(/*ТипыПоказателей*/)
		{
			//УправлениеПоказателямиСхемМотивации.ДополнитьТипыПоказателейСОграничениемВозможностиИзменения(ТипыПоказателей);
		}
		// ДополнитьТипыПоказателейСОграничениемВозможностиИзменения

		public void ДополнитьПоказателиУчетаВремени(/*МассивПоказателей*/)
		{
			//УправлениеПоказателямиСхемМотивации.ДополнитьПоказателиУчетаВремени(МассивПоказателей);
		}
		// ДополнитьПоказателиУчетаВремени

		public void ДополнитьПоказателиНачисляетсяВЦеломЗаМесяц(/*МассивПоказателей*/)
		{
			//УправлениеПоказателямиСхемМотивации.ДополнитьПоказателиНачисляетсяВЦеломЗаМесяц(МассивПоказателей);
		}
		// ДополнитьПоказателиНачисляетсяВЦеломЗаМесяц

		public void ДополнитьТипыПоказателейУчетаВремени(/*МассивПоказателей*/)
		{
			//УправлениеПоказателямиСхемМотивации.ДополнитьТипыПоказателейУчетаВремени(МассивПоказателей);
		}
		// ДополнитьТипыПоказателейУчетаВремени
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы

		public void УстановитьЗаголовкиВФорме(/*ЭтаФорма*/)
		{
			//ЭтаФорма.Заголовок = "Показатели схем мотивации";
		}
	}
}
