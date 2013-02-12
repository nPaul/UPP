﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЭлектронныеДокументыКлиентСлужебный
	{
		////////////////////////////////////////////////////////////////////////////////
		// ЭлектронныеДокументыКлиентСлужебный: механизм обмена электронными документами.
		//
		////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЙ ПРОГРАММНЫЙ ИНТЕРФЕЙС
		// Только для внутреннего использования

		public object СоответствиеПаролейКСертификатам(/*МассивСоглашений = Неопределено*/)
		{
			//СоответствиеВозврата = Неопределено;
			//СписокВыбора = ПолучитьИзВременногоХранилища(ЭлектронныеДокументыСлужебный.РезультатЗапросаПоСертификатам(МассивСоглашений));
			if(true/*СписокВыбора.Количество() > 0*/)
			{
				/*ТекстВопроса = НСтр("ru = 'Для выполнения обмена с оператором ЭДО ""Такском"" необходимо ввести парол%1 к %2 ЭЦП.
		|Продолжить?'");*/
				/*ТекстВопроса = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(ТекстВопроса,
			?(СписокВыбора.Количество() > 1, "и", "ь"), ?(СписокВыбора.Количество() = 1, "", СписокВыбора.Количество()));*/
				//Ответ = Вопрос(ТекстВопроса, РежимДиалогаВопрос.ДаНетОтмена, 30, КодВозвратаДиалога.Да);
				if(true/*Ответ = КодВозвратаДиалога.Да*/)
				{
					//СоответствиеВозврата = Новый Соответствие;
					//СписокВыбора.ЗаполнитьПометки(Истина);
					if(true/*СписокВыбора.Количество() > 1*/)
					{
						//СписокВыбора.ОтметитьЭлементы(НСтр("ru = 'Отметьте сертификаты по которым необходимо выполнить обмен'"));
					}
					//ЗаголовокФормы = НСтр("ru = 'Введите пароль для ЭЦП'");
				}
			}
			return null;
		}

		public object ПроверитьИспользованиеИнтернетПоддержкаПользователей(/**/)
		{
			//Использование = Неопределено;
			//ЭлектронныеДокументыКлиентПереопределяемый.ПроверитьИспользованиеИнтернетПоддержкаПользователей(Использование);
			if(true/*Использование = Неопределено*/)
			{
				//Использование = Ложь;
				if(true/*Метаданные.Константы.Найти("ФайлОбработкиИнтернетПоддержкиПользователей") <> Неопределено*/)
				{
					//Использование = Истина;
				}
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Оповещение пользователя об обработке ЭД
		// Выводит сообщение пользователю о нехватки прав доступа.

		public void СообщитьПользователюОНарушенииПравДоступа(/**/)
		{
			//ОчиститьСообщения();
			//ТекстСообщения = НСтр("ru = 'Нарушение прав доступа'");
			//ЭлектронныеДокументыКлиентПереопределяемый.ПодготовитьТекстСообщенияОНарушенииПравДоступа(ТекстСообщения);
			//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
		}
		// Оповещает пользователя о смене ответственных при обработке электронных документов.
		//
		// Параметры:
		//  КоличествоОбработанных - Число, количество обработанных электронных документов
		//  СписокОбъектов - СписокФормы, список объектов, которым сменяли ответственного
		//  Ответственный - Пользователь, новый ответственный за выбранные электронные документы.
		//

		public void ОповеститьПользователяОСменеОтветственного(/*КоличествоОбработанных, СписокОбъектов, Ответственный*/)
		{
			//ОчиститьСообщения();
			if(true/*КоличествоОбработанных > 0*/)
			{
				//СписокОбъектов.Обновить();
				/*ТекстСообщения = НСтр("ru='Для %КоличествоОбработанных% из %КоличествоВсего% выделенных эл.документов
		|установлен ответственный ""%Ответственный%""'");*/
				//ТекстСообщения = СтрЗаменить(ТекстСообщения, "%КоличествоОбработанных%", КоличествоОбработанных);
				//ТекстСообщения = СтрЗаменить(ТекстСообщения, "%КоличествоВсего%",        СписокОбъектов.ВыделенныеСтроки.Количество());
				//ТекстСообщения = СтрЗаменить(ТекстСообщения, "%Ответственный%",          Ответственный);
				//ТекстЗаголовка = НСтр("ru='Ответственный ""%Ответственный%"" установлен'");
				//ТекстЗаголовка = СтрЗаменить(ТекстЗаголовка, "%Ответственный%", Ответственный);
				//ПоказатьОповещениеПользователя(ТекстЗаголовка, , ТекстСообщения, БиблиотекаКартинок.Информация32);
			}
		}
		////////////////////////////////////////////////////////////////////////////////
		// Работа с электронными документами
		// Только для внутреннего использования

		public void ОтправитьПодтверждениеЭД(/*ПараметрКоманды, ЭД = Неопределено*/)
		{
			//МассивСсылок = ПолучитьМассивПараметров(ПараметрКоманды);
			if(true/*МассивСсылок = Неопределено*/)
			{
			}
			//ОбработатьЭД(МассивСсылок, "УтвердитьПодписатьОтправить", , ЭД);
			//Оповестить("ОбновитьСостояниеЭД");
		}
		// Только для внутреннего использования

		public void УтвердитьЭД(/*ПараметрКоманды, ЭД = Неопределено, ФлагОтправки = Истина*/)
		{
			if(true/*НЕ (ЭлектронныеДокументыПереопределяемый.ЕстьПравоОбработкиЭД())*/)
			{
				//СообщитьПользователюОНарушенииПравДоступа();
			}
			//МассивСсылок = ПолучитьМассивПараметров(ПараметрКоманды);
			if(true/*МассивСсылок = Неопределено*/)
			{
			}
			if(true/*ФлагОтправки*/)
			{
				//ИмяКоманды = "УтвердитьОтправить";
			}
			//ОбработатьЭД(МассивСсылок, ИмяКоманды, , ЭД);
			//Оповестить("ОбновитьСостояниеЭД");
		}
		// Функция получает массив ссылок на объекты.
		//
		// Параметры:
		//  ПараметрКоманды - ссылка на объект или массив
		//
		// Возвращаемое значение:
		//  МассивСсылок - если передан в параметр массив, то возвращает его же
		//                 если передана пустая ссылка возвращает неопределено
		//

		public object ПолучитьМассивПараметров(/*ПараметрКоманды*/)
		{
			if(true/*ТипЗнч(ПараметрКоманды) = Тип("Массив")*/)
			{
				if(true/*ПараметрКоманды.Количество() = 0*/)
				{
				}
				//МассивСсылок = ПараметрКоманды;
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Сравнение электронных документов
		// Только для внутреннего использования

		public void ВыполнитьСравнениеЭД(/*СтруктураПараметров*/)
		{
			//ТекстСообщения = НСтр("ru='Сравнение электронных документов можно сделать только в режиме толстого клиента.'");
			//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			//ЭДПервый = СтруктураПараметров.ЭДПервый;
			//ЭДВторой = СтруктураПараметров.ЭДВторой;
			if(true/*НЕ (ЗначениеЗаполнено(ЭДПервый) И ЗначениеЗаполнено(ЭДВторой))*/)
			{
				//ТекстСообщения = НСтр("ru='Не указан один из сравниваемых электронных документов.'");
				//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			}
			//МассивЭД = Новый Массив;
			//МассивЭД.Добавить(ЭДПервый);
			//МассивЭД.Добавить(ЭДВторой);
			//ПереченьВременныхФайлов = ЭлектронныеДокументыФорматОбмена.ПодготовитьВременныеФайлыПросмотраЭД(МассивЭД);
			if(true/*ПереченьВременныхФайлов = Неопределено*/)
			{
				//ТекстСообщения = НСтр("ru='Ошибка при разборе электронного документа.'");
				//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			}
			//ИмяФайла = ЭлектронныеДокументыСлужебный.ТекущееИмяВременногоФайла("mxl");
			/*// Необходимо заменить фрагмент от последнего подчеркивания до фрагмента ".mxl"
*/
			//ДлинаСтроки = СтрДлина(ИмяФайла);
			//НазваниеЭД = ПереченьВременныхФайлов[0].НазваниеЭД;
			//ЭлектронныеДокументыСлужебный.СкорректироватьИмяФайла(НазваниеЭД);
			//ИмяПервогоФайлаMXL = Лев(ИмяФайла, ДлинаСтроки - ОбратныйИндекс) + НазваниеЭД + Прав(ИмяФайла, 4);
			//ТабличныйДокумент = ПолучитьИзВременногоХранилища(ПереченьВременныхФайлов[0].АдресФайлаДанных);
			//ТабличныйДокумент.Записать(ИмяПервогоФайлаMXL);
			//НазваниеЭД = ПереченьВременныхФайлов[0].НазваниеЭД;
			//ЭлектронныеДокументыСлужебный.СкорректироватьИмяФайла(НазваниеЭД);
			//ИмяВторогоФайлаMXL = Лев(ИмяФайла, ДлинаСтроки - ОбратныйИндекс) + НазваниеЭД + Прав(ИмяФайла, 4);
			//ТабличныйДокумент = ПолучитьИзВременногоХранилища(ПереченьВременныхФайлов[1].АдресФайлаДанных);
			//ТабличныйДокумент.Записать(ИмяВторогоФайлаMXL);
			//Сравнение = Новый СравнениеФайлов;
			//Сравнение.СпособСравнения = СпособСравненияФайлов.ТабличныйДокумент;
			//Сравнение.ПервыйФайл = ИмяПервогоФайлаMXL;
			//Сравнение.ВторойФайл = ИмяВторогоФайлаMXL;
			//Сравнение.ПоказатьРазличияМодально();
		}
		////////////////////////////////////////////////////////////////////////////////
		// Работа с ЭЦП
		// Подписывает электронные документы определенным сертификатом криптографии.
		//
		// Параметры:
		//  ДобавленныеФайлы - Массив ссылок на электронные документы, которые необходимо подписать,
		//  СертификатПодписи - СертификатКриптографии, сертификат, которым необходимо подписать переданные электронные документы,
		//  ПарольПользователя - Строка, пароль установки ЭЦП данным сертификатом.
		//

		public object ПодписатьЭДОпределеннымСертификатом(/*ДобавленныеФайлы, СертификатПодписи, ПарольПользователя = Неопределено*/)
		{
			//ОчиститьСообщения();
			if(true/*НЕ ПодключитьРасширениеРаботыСКриптографией()*/)
			{
				//ТекстСообщения = НСтр("ru = 'Расширение для работы с криптографией не подключено, операция прервана.'");
				//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			}
			if(true/*ЭлектронныеДокументыСлужебный.ПолучитьЗначениеРеквизитаВПривилегированномРежиме(СертификатПодписи, "Отозван")*/)
			{
				//ШаблонСообщения = НСтр("ru = 'Невозможно подписать документы. Сертификат (%1) отозван.'");
				//ТекстСообщения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(ШаблонСообщения, СертификатПодписи);
				//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			}
			//МенеджерКриптографии.ВключениеСертификатовВПодпись = РежимВключенияСертификатовКриптографии.ВключатьСертификатСубъекта;
			/*// Проверим сертификат с помощью менеджера криптографии.
*/
			/*// Если есть ошибка - подпись не производим.
*/
			//КриптоСертификат = ПодписьДоступнаПоСертификату(СертификатПодписи);
			//КоличествоПодписанныхЭД = 0;
			if(true/*КриптоСертификат <> Неопределено*/)
			{
				if(true/*ЭлектронныеДокументыСлужебный.ПолучитьЗначениеРеквизитаВПривилегированномРежиме(СертификатПодписи, "ЗапомнитьПарольКСертификату")
			И ПарольПользователя = Неопределено*/)
				{
					/*ПарольПользователя = ЭлектронныеДокументыСлужебный.ПолучитьЗначениеРеквизитаВПривилегированномРежиме(
				СертификатПодписи, "ПарольПользователя");*/
				}
				if(true/*ПарольПользователя = Неопределено*/)
				{
					/*ПараметрыФормы = Новый Структура("Заголовок, ПредставлениеСертификата", 
			НСтр("ru = 'Введите пароль для ЭЦП'"), СертификатПодписи);*/
					//КодВозврата = ОткрытьФормуМодально("ОбщаяФорма.ЗапросПароляНаЭЦПШифрование", ПараметрыФормы);
					if(true/*ТипЗнч(КодВозврата) = Тип("Строка")*/)
					{
						//ПарольПользователя = КодВозврата;
					}
				}
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Отправка пакетов
		// Готовит к отправке электронные документы (формирует пакеты ЭД).
		//
		// Параметры:
		//  ДобавленныеФайлы - Массив ссылок на электронные документы, которые необходимо подготовить к отправке,
		//  ПризнакПодписи - булево, признак того, что электронные документы подписаны ЭЦП,
		//

		public object ПодготовитьКОтправкеЭД(/*ДобавленныеФайлы, ПризнакПодписи*/)
		{
			//МассивСтруктурПакетовЭД = ЭлектронныеДокументыСлужебный.СоздатьДокументыПакетовЭД(ДобавленныеФайлы, ПризнакПодписи);
			return null;
		}
		// Готовит к отправке ЭД и ОТПРАВЛЯЕТ (подготовленные электронные документы).
		//
		// Параметры:
		//  ДобавленныеФайлы - Массив ссылок на электронные документы, которые необходимо поместить в пакеты ЭД,
		//  ПризнакПодписи - булево, признак того, что электронные документы подписаны ЭЦП,
		//

		public object ПодготовитьИОтправитьПЭД(/*ДобавленныеФайлы, ПризнакПодписи*/)
		{
			//МассивСтруктурПакетовЭД = ЭлектронныеДокументыСлужебный.СоздатьДокументыПакетовЭД(ДобавленныеФайлы, ПризнакПодписи);
			return null;
		}
		// Только для внутреннего использования

		public object ОтправитьМассивПакетовЭД(/*Знач МассивПЭД, СоответствиеПаролейДляЭДО*/)
		{
			//Результат = ЭлектронныеДокументыСлужебный.ОтправкаПакетовЭД(МассивПЭД, СоответствиеПаролейДляЭДО);
			//Оповестить("ОбновитьСостояниеЭД");
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Работа с подписями
		// Процедура предназначена для коррекции имени файла  - замена некорректных символов на пробел
		//
		// Параметры
		//  СтрИмяФайла  - Строка - Имя файла
		//

		public void СкорректироватьИмяФайла(/*СтрИмяФайла*/)
		{
			/*// Перечень запрещенных символов взят отсюда: http://support.microsoft.com/kb/100108/ru.
*/
			/*// При этом были объединены запрещенные символы для файловых систем FAT и NTFS.
*/
			//СтрИсключения = """ / \ [ ] : ; | = , ? * < >";
			//СтрИсключения = СтрЗаменить(СтрИсключения, " ", "");
			//СтрИмяФайла = СокрЛП(СтрИмяФайла);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Обработка электронных документов
		// Выводит пользователю информацию об обработанных электронных документах.
		//
		// Параметры:
		//  КолСформированных - число, количество сформированных электронных документов,
		//  КолПодписанных - число, количество подписанных электронных документов,
		//  КолОтправленных - число, количество отправленных электронных документов.
		//

		public void ВывестиИнформациюОбОбработанныхЭД(/*КолСформированных, КолУтвержденных, КолПодписанных, КолПодготовленных*/)
		{
			if(true/*КолПодготовленных > 0*/)
			{
				if(true/*КолПодписанных > 0*/)
				{
					if(true/*КолУтвержденных > 0*/)
					{
						if(true/*КолСформированных > 0*/)
						{
							//Текст = НСтр("ru = 'Сформировано: (%1), утверждено: (%2), подписано: (%3), подготовлено к отправке пакетов: (%4)'");
							/*Текст = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(Текст, КолСформированных, 
					КолУтвержденных, КолПодписанных, КолПодготовленных);*/
						}
					}
				}
			}
			//ТекстЗаголовка = НСтр("ru = 'Обмен электронными документами'");
			//ПоказатьОповещениеПользователя(ТекстЗаголовка, ,Текст);
			//Оповестить("ОбновитьСостояниеЭД");
		}
		// Обрабатывает переданные документы ИБ в системе обмена электронными документами в соответствие с параметрами.
		//
		// Параметры:
		//  МассивСсылокНаОбъект - массив ссылок на объекты ИБ, которые необходимо обработать,
		//  Действие - строка, представление действия, которое необходимо произвести с электронными документами,
		//  ДопПараметры - структура, дополнительные параметры обработки электронных документов.
		//  ЭД - СправочникСсылка.ЭДПрисоединенныеФайлы, ссылка на элемент справочника ЭДПрисоединенныеФайлы
		//

		public void ОбработатьЭД(/*МассивСсылокНаОбъект, Действие, ДопПараметры = "", ЭД = Неопределено*/)
		{
			//ОчиститьСообщения();
			/*СтруктураДействий = ЭлектронныеДокументыСлужебный.ВыполнитьДействияПоЭД(МассивСсылокНаОбъект,
		МассивСтруктурСертификатов, Действие, ДопПараметры, ЭД);*/
			if(true/*СтруктураДействий = Неопределено*/)
			{
			}
			//ИтогКолНовыхЭД = 0;
			//ИтогКолОтправленныхНаПодпись = 0;
			//ИтогКолПодписанных = 0;
			//ИтогКолПодготовленных = 0;
			if(true/*ТипЗнч(СтруктураДействий) = Тип("Структура")*/)
			{
				if(true/*СтруктураДействий.Свойство("КоличествоНовыхЭД")*/)
				{
					//ИтогКолНовыхЭД = СтруктураДействий.КоличествоНовыхЭД;
				}
				if(true/*СтруктураДействий.Свойство("КоличествоУтвержденныхЭД")*/)
				{
					//ИтогКолОтправленныхНаПодпись = СтруктураДействий.КоличествоУтвержденныхЭД;
				}
				//МассивОбработки = "";
				if(true/*СтруктураДействий.Свойство("МассивСертификатов", МассивОбработки)*/)
				{
				}
				//МассивОбработки = "";
				if(true/*СтруктураДействий.Свойство("МассивСоглашений", МассивОбработки)*/)
				{
				}
				//МассивОбработки = "";
				if(true/*СтруктураДействий.Свойство("МассивНовыхЭД", МассивОбработки) И МассивОбработки <> Неопределено*/)
				{
				}
			}
			//ВывестиИнформациюОбОбработанныхЭД(ИтогКолНовыхЭД, ИтогКолОтправленныхНаПодпись, ИтогКолПодписанных, ИтогКолПодготовленных);
		}
		// Отправка и получение электронных документов одной командой.

		public void ОтправитьПолучитьЭлектронныеДокументы(/**/)
		{
			if(true/*НЕ ЭлектронныеДокументыПереопределяемый.ЕстьПравоОбработкиЭД()*/)
			{
				//СообщитьПользователюОНарушенииПравДоступа();
			}
			if(true/*НЕ ЭлектронныеДокументыСлужебный.ИспользуетсяОбменЭД()*/)
			{
				//ТекстСообщения = ЭлектронныеДокументыСлужебный.ТекстСообщенияОНеобходимостиНастройкиСистемы("РаботаСЭД");
				//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			}
			/*// Получение и отправка документов.
*/
			//СоответствиеПаролейДляЭДО = СоответствиеПаролейКСертификатам();
			//СтруктураВозврата = ЭлектронныеДокументыСлужебный.ОтправитьИПолучитьДокументы(СоответствиеПаролейДляЭДО);
			/*// Распаковываем принятые пакеты с электронными документами.
*/
			//НовыеДокументы = СтруктураВозврата.НовыеДокументы;
			//КоличествоНовыхЭД = НовыеДокументы.МассивВозврата.Количество();
			/*// Подготовим вывод сообщения для пользователя об отправке/получению пакетов ЭД.
*/
			//КолОтправленныхПакетов = СтруктураВозврата.КолОтправленныхПакетов;
			//ШаблонОповещения = НСтр("ru = 'Отправлено пакетов: (%1), получено пакетов: (%2).'");
			/*ТекстОповещения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(ШаблонОповещения, КолОтправленныхПакетов,
		КоличествоНовыхЭД);*/
			if(true/*КолОтправленныхПакетов > 0 ИЛИ КоличествоНовыхЭД > 0
		ИЛИ СтруктураВозврата.НовыеДокументы.ВызватьОповещение*/)
			{
				//Оповестить("ОбновитьСостояниеЭД");
			}
			//ЗаголовокОповещения = НСтр("ru = 'Обмен электронными документами'");
			//ПоказатьОповещениеПользователя(ЗаголовокОповещения, , ТекстОповещения);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Распаковка пакетов ЭД (расшифровка, проверка, подписи)
		// Только для внутреннего использования

		public void РаспаковатьМассивПакетовЭД(/*МассивПЭД*/)
		{
			//СписокДокументов = Новый Массив;
			//ПараметрыШифрования = ЭлектронныеДокументыСлужебный.ОпределитьШифрованиеИСтатус(МассивПЭД);
			if(true/*ПараметрыШифрования = Неопределено*/)
			{
			}
			//Индекс = 0;
			//ВсегоРаспакованоЭД = 0;
			//ЗаголовокОповещения = НСтр("ru = 'Обмен электронными документами'");
			/*ТекстОповещения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(
		НСтр("ru = 'Распаковано электронных документов: (%1)'"), ВсегоРаспакованоЭД);*/
			//ПоказатьОповещениеПользователя(ЗаголовокОповещения, , ТекстОповещения);
			//Оповестить("ОбновитьСостояниеЭД");
		}
		////////////////////////////////////////////////////////////////////////////////
		// Работа с уточнением
		// Только для внутреннего использования

		public object СформироватьПодписатьЭДУведомлениеОбУточнении(/*СсылкаНаЭД, ТекстУточнения*/)
		{
			//КолСформированных = 0;
			//КолУтвержденных   = 0;
			//КолПодписанных    = 0;
			//КолПодготовленных = 0;
			//ФайлУведомления = ЭлектронныеДокументыФорматОбмена.СформироватьЭДУведомлениеОбУточнении(СсылкаНаЭД, ТекстУточнения);
			if(true/*ФайлУведомления <> Неопределено*/)
			{
				//КолСформированных = 1;
				//КолУтвержденных   = 1;
				//ДобавленныеФайлы  = Новый Массив;
				//ДобавленныеФайлы.Добавить(ФайлУведомления);
				/*СертификатПодписи = ЭлектронныеДокументыОператорыЭДО.ОпределитьСертификатПодписиСлужебногоДокумента(СсылкаНаЭД,
			"УведомлениеОбУточнении");*/
				if(true/*СертификатПодписи <> Неопределено*/)
				{
					if(true/*ОбщегоНазначения.ПолучитьЗначениеРеквизита(СертификатПодписи, "ЗапомнитьПарольКСертификату")*/)
					{
						/*КолПодписанных = ПодписатьЭДОпределеннымСертификатом(ДобавленныеФайлы, СертификатПодписи,
					ОбщегоНазначения.ПолучитьЗначениеРеквизита(СертификатПодписи, "ПарольПользователя"));*/
						if(true/*КолПодписанных > 0*/)
						{
							//КолПодготовленных = ПодготовитьКОтправкеЭД(ДобавленныеФайлы, Истина);
						}
					}
				}
				//Оповестить("ОбновитьСостояниеЭД");
			}
			//ВывестиИнформациюОбОбработанныхЭД(КолСформированных, КолУтвержденных, КолПодписанных, КолПодготовленных);
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		////////////////////////////////////////////////////////////////////////////////
		// Работа с ЭЦП

		public object ПодписьДоступнаПоСертификату(/*СертификатПодписи*/)
		{
			//ТребуемаяПодпись = ЭлектронныеДокументыСлужебный.ПолучитьОтпечатокСертификата(СертификатПодписи);
			return null;
		}

		public object ПодписьДоступна(/*ТребуемаяПодпись*/)
		{
			return null;
		}
		// Выводит результат проверки корректности сертификата криптографии.
		//
		// Параметры
		//  ОтпечатокСертификатаПодписи - строка-отпечаток сертификата ЭЦП
		//

		public void ТестНастроекСертификата(/*ОтпечатокСертификатаПодписи*/)
		{
			/*ШаблонСообщения = НСтр("ru = '%1
	|%2'");*/
			/*// Блок проверки установленных криптосредств на компьютере.
*/
			//ОписаниеТеста =  НСтр("ru = 'Тест. Проверка средства криптографии на компьютере.'");
			/*ТекстСообщения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(ШаблонСообщения,
		ОписаниеТеста, РезультатТеста);*/
			//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			/*// Критичная ошибка - дальше тесты не проводим.
*/
			if(true/*МенеджерКриптографии = Неопределено*/)
			{
			}
			/*// Блок проверки наличия сертификата в хранилище сертификатов компьютера.
*/
			//ОписаниеТеста =  НСтр("ru = 'Тест. Проверка наличия сертификата на компьютере.'");
			//Сертификат = ЭлектроннаяЦифроваяПодписьКлиент.ПолучитьСертификатПоОтпечатку(ОтпечатокСертификатаПодписи);
			//РезультатТеста = НСтр("ru = 'Пройден успешно.'");
			if(true/*Сертификат = Неопределено*/)
			{
				//РезультатТеста = НСтр("ru = 'Код ошибки 101. Сертификат не найден в хранилище сертификатов.'");
			}
			/*ТекстСообщения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(ШаблонСообщения,
		ОписаниеТеста, РезультатТеста);*/
			//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			/*// Блок проверки сертификата на корректность.
*/
			//ОписаниеТеста =  НСтр("ru = 'Тест. Проверка реквизитов сертификата.'");
			/*ТекстСообщения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(ШаблонСообщения,
		ОписаниеТеста, РезультатТеста);*/
			//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			/*// Блок проверки шифрования/расшифрования.
*/
			//ОтпечатокДвоичныеДанные = Base64Значение(ОтпечатокСертификатаПодписи);
			//ФайлДанных = ЭлектронныеДокументыСлужебный.ТекущееИмяВременногоФайла("txt");
			//ОписаниеТеста =  НСтр("ru = 'Тест. Проверка операций шифрования/расшифровки.'");
			//МенеджерКриптографии.Зашифровать(ОтпечатокДвоичныеДанные, ФайлДанных, Сертификат);
			/*ТекстСообщения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(ШаблонСообщения,
		ОписаниеТеста, РезультатТеста);*/
			//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			/*// Блок проверки ЭЦП.
*/
			//ОписаниеТеста =  НСтр("ru = 'Тест. Проверка операций формирования/проверки ЭЦП.'");
			/*ТекстСообщения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(ШаблонСообщения,
		ОписаниеТеста, РезультатТеста);*/
			//ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстСообщения);
			//УдалитьФайлы(ФайлДанных);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Распаковка пакетов ЭД (расшифровка, проверка, подписи)

		public void ДобавитьМассив(/*МассивПриемник, МассивИсточник*/)
		{
			if(true/*ТипЗнч(МассивИсточник) <> Тип("Массив")*/)
			{
			}
		}
		// Расшифровывает и распаковывает пакет электронных документов.
		//
		// Параметры:
		//  ПакетЭД - ДокументСсылка.ПакетЭД, исследуемый пакет электронных документов.
		//  ПараметрыШифрования - Структура, параметры шифрования для данного пакета электронных документов.
		//

		public object РаспаковатьПакетЭДНаКлиенте(/*ПакетЭД, ПараметрыШифрования = ""*/)
		{
			//МассивВозврата = Новый Массив;
			//ЭлектронныеДокументыСлужебный.УдалитьПапкуНаСервере(ПапкаДляРаспаковки);
			//ЭлектронныеДокументыСлужебный.УдалитьПапкуНаСервере(ПапкаДляРасшифровки);
			return null;
		}

		public object ПарольЗадан(/*ТекущаяСтруктура, ПараметрыШифрования, ПарольДоступа*/)
		{
			//СертификатПоиска = ТекущаяСтруктура.Сертификат;
			//ВозвращаемоеЗначение = Ложь;
			return null;
		}

		public object НайтиСтруктуруВПараметрах(/*ИмяПоиска, ПараметрыШифрования*/)
		{
			//ВозвращаемыйПараметр = Неопределено;
			if(true/*ТипЗнч(ПараметрыШифрования) = Тип("Массив")*/)
			{
			}
			return null;
		}
	}
}
