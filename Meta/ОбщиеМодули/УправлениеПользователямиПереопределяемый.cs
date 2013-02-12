﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class УправлениеПользователямиПереопределяемый
	{
		// Функция формирует список интерфейсов для выбора из списка
		//
		// Параметры
		//  Элемент - Элемент управления, в котором производится выбор из списка
		//
		// Возвращаемое значение:
		//   СписокЗначений   - список значений Метаданные.Интерфейсы
		//

		public object ПолучитьСписокВыбораИнтерфейсов(/*Элемент*/)
		{
			//СписокИсключаемыхИнтерфейсов = Новый Массив;
			//СписокИсключаемыхИнтерфейсов.Добавить(Метаданные.Интерфейсы.Общий);
			//СписокИсключаемыхИнтерфейсов.Добавить(Метаданные.Интерфейсы.ОбщийАдминистратора);
			//СписокИсключаемыхИнтерфейсов.Добавить(Метаданные.Интерфейсы.ОбщийВнешниеОбработки);
			//СписокИсключаемыхИнтерфейсов.Добавить(Метаданные.Интерфейсы.ОбщийРегламентированный);
			//СписокИсключаемыхИнтерфейсов.Добавить(Метаданные.Интерфейсы.ОбщийЭлектроннаяПочта);
			//СписокИсключаемыхИнтерфейсов.Добавить(Метаданные.Интерфейсы.РегламентированныйУчет);
			//СписокВыбора = Новый СписокЗначений;
			if(true/*(Элемент.Значение <> Неопределено) И (СписокВыбора.НайтиПоЗначению(Элемент.Значение) = Неопределено)*/)
			{
				//СписокВыбора.Добавить(Элемент.Значение, Элемент.Значение.Синоним);
			}
			return null;
		}
		// Процедура устанавливает в списке СписокДоступныхРолейПользователяИБ пометку у роли
		// Пользователь, если пользователь установил пометку у роли, требующей еще и роль Пользователь
		//
		// Параметры
		//  СписокДоступныхРолейПользователяИБ  - СписокЗначений, содержит роли пользователей
		//
		//  ТекущаяСтрока  - Текущие данные строки списка значений, в которой пользователь изменил Пометку
		//

		public void НайтиИПометитьВСпискеРольПользователь(/*СписокДоступныхРолейПользователяИБ, ТекущаяСтрока*/)
		{
			//МассивРолей = Новый Массив;
			//МассивРолей.Добавить(Метаданные.Роли.КадровикРегламентированныхДанных);
			//МассивРолей.Добавить(Метаданные.Роли.КадровикУправленческихДанных);
			//МассивРолей.Добавить(Метаданные.Роли.МенеджерПоНаборуПерсонала);
			//МассивРолей.Добавить(Метаданные.Роли.РасчетчикРегламентированнойЗарплаты);
			//МассивРолей.Добавить(Метаданные.Роли.РасчетчикУправленческойЗарплаты);
			//УправлениеПользователямиДополнительный.ДополнитьСписокРолейДляПометкиРолиПользователь(МассивРолей);
			if(true/*ТекущаяСтрока.Пометка И МассивРолей.Найти(ТекущаяСтрока.Значение) <> Неопределено*/)
			{
				//СписокДоступныхРолейПользователяИБ.Найти(Метаданные.Роли.Пользователь, "Значение").Пометка = Истина;
			}
		}
		// НайтиИПометитьВСпискеРольПользователь()
		// Функция проверяет, что роли настроены правильно
		//
		// Параметры
		//	СписокДоступныхРолейПользователяИБ  - СписокЗначений, содержит роли пользователей
		//

		public object РолиНастроеныПравильно(/*СписокДоступныхРолейПользователяИБ*/)
		{
			//МассивРолей = Новый Массив;
			//МассивРолей.Добавить(Метаданные.Роли.ПолныеПрава);
			//МассивРолей.Добавить(Метаданные.Роли.Пользователь);
			//УправлениеПользователямиДополнительный.ДополнитьСписокРолейДляПроверкиПравильностиНастройки(МассивРолей);
			//НастроеныПравильно = Ложь;
			//ПредставлениеНеобходимыхРолей = "";
			if(true/*Не НастроеныПравильно*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Для пользователя необходимо установить одну из ролей """ + ПредставлениеНеобходимыхРолей +  """!");
			}
			if(true/*Не УправлениеПользователямиДополнительный.РолиСочетаютсяПравильно(СписокДоступныхРолейПользователяИБ)*/)
			{
			}
			return null;
		}
	}
}
