﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ВакансииПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта

		public void ПроверитьЗначенияРеквизитов(/*ЭтотОбъект, Отказ, ТекстСообщенияОбОшибке*/)
		{
			//РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();
			//Подразделение 	= ЭтотОбъект.Подразделение;
			//Организация 	= ЭтотОбъект.Организация;
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				if(true/*Организация.Пустая()*/)
				{
					//Отказ = Истина;
					//ТекстСообщенияОбОшибке = ОбщегоНазначения.ПреобразоватьСтрокуИнтерфейса("Не указана организация!");
				}
				if(true/*Подразделение = Неопределено ИЛИ Подразделение.Пустая()*/)
				{
					//Отказ = Истина;
					//ТекстСообщенияОбОшибке = ОбщегоНазначения.ПреобразоватьСтрокуИнтерфейса("Не указано подразделение организации!");
				}
				if(true/*Отказ*/)
				{
				}
				if(true/*Организация <> Подразделение.Владелец*/)
				{
					//Отказ = Истина;
					//ТекстСообщенияОбОшибке = ОбщегоНазначения.ПреобразоватьСтрокуИнтерфейса("Указано подразделение, принадлежащее другой организации!");
				}
			}
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

		public object РегистрСведенийОРабочихМестах(/**/)
		{
			return null;
		}

		public object СформироватьЗапросПоОписаниюВакансии(/*ЭтотОбъект*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("Должность",		ЭтотОбъект.Должность);
			//РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				//Запрос.УстановитьПараметр("ПодразделениеОрганизации",	ЭтотОбъект.Подразделение);
				/*Запрос.Текст =
		"ВЫБРАТЬ ПЕРВЫЕ 1
		|	ВложенныйЗапрос.УточнитьОписаниеВакансии КАК УточнитьОписаниеВакансии,
		|	ВложенныйЗапрос.Требования КАК ВакансияТребования,
		|	ВложенныйЗапрос.Обязанности КАК ВакансияОбязанности,
		|	ВложенныйЗапрос.Условия КАК ВакансияУсловия
		|ИЗ
		|	(ВЫБРАТЬ
		|		Должности.Требования КАК Требования,
		|		Должности.Обязанности КАК Обязанности,
		|		Должности.Условия КАК Условия,
		|		ЛОЖЬ КАК УточнитьОписаниеВакансии,
		|		1 КАК Порядок
		|	ИЗ
		|		Справочник.Должности КАК Должности
		|	ГДЕ
		|		Должности.Ссылка = &Должность
		|	
		|	ОБЪЕДИНИТЬ ВСЕ
		|	
		|	ВЫБРАТЬ
		|		СведенияОРабочихМестах.Требования,
		|		СведенияОРабочихМестах.Обязанности,
		|		СведенияОРабочихМестах.Условия,
		|		ЛОЖЬ,
		|		2
		|	ИЗ
		|		РегистрСведений.СведенияОРабочихМестах КАК СведенияОРабочихМестах
		|	ГДЕ
		|		СведенияОРабочихМестах.Подразделение = ЗНАЧЕНИЕ(Справочник.Подразделения.ПустаяСсылка)
		|		И СведенияОРабочихМестах.ПодразделениеОрганизации = &ПодразделениеОрганизации
		|		И СведенияОРабочихМестах.Должность = &Должность
		|	
		|	ОБЪЕДИНИТЬ ВСЕ
		|	
		|	ВЫБРАТЬ
		|		Вакансии.Требования,
		|		Вакансии.Обязанности,
		|		Вакансии.Условия,
		|		ИСТИНА,
		|		3
		|	ИЗ
		|		Справочник.Вакансии КАК Вакансии
		|	ГДЕ
		|		Вакансии.Подразделение = &ПодразделениеОрганизации
		|		И Вакансии.Должность = &Должность
		|		И ((НЕ Вакансии.Требования ПОДОБНО """")
		|				ИЛИ (НЕ Вакансии.Обязанности ПОДОБНО """")
		|				ИЛИ (НЕ Вакансии.Условия ПОДОБНО """"))) КАК ВложенныйЗапрос
		|
		|УПОРЯДОЧИТЬ ПО
		|	ВложенныйЗапрос.Порядок УБЫВ";*/
			}
			return null;
		}

		public object СформироватьЗапросПоОписаниюДолжности(/*ЭтотОбъект*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("Должность",		ЭтотОбъект.Должность);
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	Должности.Требования,
	|	Должности.Обязанности,
	|	Должности.Условия
	|ИЗ
	|	Справочник.Должности КАК Должности
	|ГДЕ
	|	Должности.Ссылка = &Должность";*/
			return null;
		}

		public void ПодразделениеОчисткаДополнительно(/*ЭтотОбъект*/)
		{
			//РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();
			//Подразделение = ЭтотОбъект.Подразделение;
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				if(true/*ТипЗнч(Подразделение) <> Тип("СправочникСсылка.ПодразделенияОрганизаций")*/)
				{
					//ЭтотОбъект.Подразделение = Справочники.ПодразделенияОрганизаций.ПустаяСсылка();
				}
			}
		}

		public void ПриОткрытииДополнительно(/*ЭтаФорма, ЭтотОбъект*/)
		{
			//РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();
			//Подразделение = ЭтотОбъект.Подразделение;
			//Организация = ЭтотОбъект.Организация;
			if(true/*ЭтотОбъект.ЭтоНовый()*/)
			{
				if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
				{
					if(true/*Организация.Пустая()*/)
					{
						//ЭтотОбъект.Организация = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОсновнаяОрганизация");
					}
					if(true/*Подразделение = Неопределено ИЛИ Подразделение.Пустая()*/)
					{
						//ЭтотОбъект.Подразделение = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОсновноеПодразделениеОрганизации");
					}
				}
			}
			if(true/*РежимНабораПерсонала <> Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				//ЭтаФорма.ЭлементыФормы.ПанельОрганизация.Свертка = РежимСверткиЭлементаУправления.Верх;
			}
		}

		public void ПриОткрытииФормыСпискаДополнительно(/*ЭтаФорма*/)
		{
			//РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();
			//ПоказыватьОрганизацию = РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц;
			//ЭлементыФормы = ЭтаФорма.ЭлементыФормы;
			//ЭлементыФормы.СправочникСписок.Колонки.Организация.Видимость			= ПоказыватьОрганизацию;
			//ЭлементыФормы.СправочникСписок.Колонки.Организация.ИзменятьНастройку	= ПоказыватьОрганизацию;
			//ЭлементыФормы.ОрганизацияФлаг.Видимость									= ПоказыватьОрганизацию;
			//ЭлементыФормы.Организация.Видимость										= ПоказыватьОрганизацию;
		}
	}
}
