﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РаботаСФайламиКлиент
	{
		// Удаление файла со снятием атрибута readonly

		public void УдалитьФайл(/*ПолноеИмяФайла, ЗадаватьВопрос = Неопределено, ШапкаВопроса = Неопределено*/)
		{
			//ПодтверждатьПриУдаленииИзЛокальногоКэшаФайлов = ФайловыеФункцииКлиентПовтИсп.ПолучитьПерсональныеНастройкиРаботыСФайлами().ПодтверждатьПриУдаленииИзЛокальногоКэшаФайлов;
			if(true/*ЗадаватьВопрос <> Неопределено*/)
			{
				//ПодтверждатьПриУдаленииИзЛокальногоКэшаФайлов = ЗадаватьВопрос;
			}
			if(true/*ПодтверждатьПриУдаленииИзЛокальногоКэшаФайлов = Истина*/)
			{
				//ТекстВопроса = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(НСтр("ru = 'Удалить файл ""%1"" из основного рабочего каталога?'"), ПолноеИмяФайла);
				if(true/*ШапкаВопроса <> Неопределено*/)
				{
					//ТекстВопроса = ШапкаВопроса + Символы.ПС + Символы.ПС + ТекстВопроса;
				}
				if(true/*Вопрос(ТекстВопроса, РежимДиалогаВопрос.ДаНет) = КодВозвратаДиалога.Нет*/)
				{
				}
			}
			//Файл = Новый Файл(ПолноеИмяФайла);
			//Файл.УстановитьТолькоЧтение(Ложь);
			//УдалитьФайлы(ПолноеИмяФайла);
		}
		// Очистка рабочего каталога - для освобождения места - в первую очередь удаляет файлы
		// наиболее давно помещенные в рабочий каталог

		public void ОчиститьРабочийКаталог(/*РазмерФайловВРабочемКаталоге, РазмерДобавляемогоФайла, ОчищатьВсе*/)
		{
			//ФайловыеФункцииКлиент.ПроинициализироватьПутьКРабочемуКаталогу();
			//ИмяКаталога = ФайловыеФункцииКлиентПовтИсп.ПолучитьПерсональныеНастройкиРаботыСФайлами().ПутьКЛокальномуКэшуФайлов;
			//ТаблицаФайлов = Новый Массив;
			//МассивФайлов = НайтиФайлы(ИмяКаталога, "*.*");
			//ОбходФайловТаблица(ИмяКаталога, МассивФайлов, ТаблицаФайлов);
			/*// Вызов сервера - для сортировки
*/
			/*//  сортировка по дате - в начале будут самые давно помещенные в рабочий каталог
*/
			//РаботаСФайламиВызовСервера.СортироватьМассивСтруктур(ТаблицаФайлов);
			//МаксРазмер = ФайловыеФункцииКлиентПовтИсп.ПолучитьПерсональныеНастройкиРаботыСФайлами().МаксимальныйРазмерЛокальногоКэшаФайлов;
			//СреднийРазмерФайла = 1000;
			if(true/*ТаблицаФайлов.Количество() <> 0*/)
			{
				//СреднийРазмерФайла = РазмерФайловВРабочемКаталоге / ТаблицаФайлов.Количество();
			}
			//СколькоНадоОсвободитьМеста = МаксРазмер / 10;
			if(true/*СреднийРазмерФайла * 3 / 2 > СколькоНадоОсвободитьМеста*/)
			{
				//СколькоНадоОсвободитьМеста = СреднийРазмерФайла * 3 / 2;
			}
			//СколькоОсталось = РазмерФайловВРабочемКаталоге + РазмерДобавляемогоФайла;
		}
		// Рекурсивный обход файлов в рабочем каталоге и сбор информации о них

		public void ОбходФайловТаблица(/*Путь, МассивФайлов, ТаблицаФайлов*/)
		{
			//ИмяКаталога = ФайловыеФункцииКлиентПовтИсп.ПолучитьПерсональныеНастройкиРаботыСФайлами().ПутьКЛокальномуКэшуФайлов;
		}
		// Выбрать путь к рабочему каталогу
		// Параметры
		//  ИмяКаталога  - Строка - прежнее имя каталога
		//  Заголовок  - Строка - заголовок формы выбора пути каталога
		//  РабочийКаталогВладельца - Строка-  Рабочий каталог владельца
		//
		// Возвращаемое значение:
		//   Булево  - успешно ли выполнена операция

		public object ВыбратьПутьКРабочемуКаталогу(/*ИмяКаталога, Заголовок, РабочийКаталогВладельца*/)
		{
			//Режим = РежимДиалогаВыбораФайла.ВыборКаталога;
			//ДиалогОткрытияФайла = Новый ДиалогВыбораФайла(Режим);
			//ДиалогОткрытияФайла.ПолноеИмяФайла = "";
			//ДиалогОткрытияФайла.Каталог = ИмяКаталога;
			//ДиалогОткрытияФайла.МножественныйВыбор = Ложь;
			//ДиалогОткрытияФайла.Заголовок = Заголовок;
			if(true/*ДиалогОткрытияФайла.Выбрать()*/)
			{
				//ИмяКаталога = ДиалогОткрытияФайла.Каталог;
				/*ОбщегоНазначенияКлиентСервер.ДобавитьКонечныйРазделительПути(   ИмяКаталога, 
																			ОбщегоНазначенияКлиентПовтИсп.ТипПлатформыКлиента());*/
				/*// Создать каталог для файлов
*/
				if(true/*РабочийКаталогВладельца = Ложь*/)
				{
					//МассивФайловВКаталоге = НайтиФайлы(ИмяКаталога, "*.*");
					if(true/*МассивФайловВКаталоге.Количество() <> 0*/)
					{
						/*ТекстОшибки 
						= СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(НСтр("ru = 'В выбранном рабочем каталоге (""%1"") уже есть файлы. Выберите другой каталог.'"),
						ИмяКаталога);*/
						//Предупреждение(ТекстОшибки);
					}
				}
			}
			return null;
		}
	}
}
