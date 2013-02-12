﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	public partial class СохраненныеНастройки:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		public Guid Ссылка;
		public long Версия;
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления;
		public bool Предопределенный;
		public Guid Владелец;
		public bool ЭтоГруппа;
		public Guid Родитель;
		public string/*100*/ Наименование;
		public V82.Перечисления/*Ссылка*/.ТипыНастроек ТипНастройки;//Тип настройки
		public object НастраиваемыйОбъект;//Настраиваемый объект
		public bool СохранятьАвтоматически;//Сохранять автоматически
		public bool ИспользоватьПриОткрытии;//Использовать при открытии
		public bool СохранятьПериод;//Сохранять период
		public bool ОткрыватьПриЗапуске;//Открывать при запуске
		public ХранилищеЗначения ХранилищеНастроек;//Хранилище настроек
		public string/*(1000)*/ Описание;
		public string/*(100)*/ КраткийСоставНастройки;//Краткий состав настройки
		public void Записать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference238(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Description
						,_Fld3564RRef
						,_Fld3566
						,_Fld3567
						,_Fld3568
						,_Fld3569
						,_Fld3570
						,_Fld3571
						,_Fld3572)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Наименование
						,@ТипНастройки
						,@СохранятьАвтоматически
						,@ИспользоватьПриОткрытии
						,@СохранятьПериод
						,@ОткрыватьПриЗапуске
						,@ХранилищеНастроек
						,@Описание
						,@КраткийСоставНастройки)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference238
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Description	= @Наименование
						,_Fld3564RRef	= @ТипНастройки
						,_Fld3566	= @СохранятьАвтоматически
						,_Fld3567	= @ИспользоватьПриОткрытии
						,_Fld3568	= @СохранятьПериод
						,_Fld3569	= @ОткрыватьПриЗапуске
						,_Fld3570	= @ХранилищеНастроек
						,_Fld3571	= @Описание
						,_Fld3572	= @КраткийСоставНастройки
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ТипНастройки", ТипНастройки.Ключ());
					Команда.Parameters.AddWithValue("СохранятьАвтоматически", СохранятьАвтоматически);
					Команда.Parameters.AddWithValue("ИспользоватьПриОткрытии", ИспользоватьПриОткрытии);
					Команда.Parameters.AddWithValue("СохранятьПериод", СохранятьПериод);
					Команда.Parameters.AddWithValue("ОткрыватьПриЗапуске", ОткрыватьПриЗапуске);
					Команда.Parameters.AddWithValue("ХранилищеНастроек",new byte[0]);
					Команда.Parameters.AddWithValue("Описание", Описание);
					Команда.Parameters.AddWithValue("КраткийСоставНастройки", КраткийСоставНастройки);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Reference238
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ПЕРЕМЕННЫЕ МОДУДЛЯ

		public object ОбязательныеРеквизиты(/**/)
		{
			//СписокИмен = "Наименование, ";
			if(true/*НЕ ЭтоГруппа*/)
			{
				//СписокИмен = СписокИмен + "НастраиваемыйОбъект, ";
			}
			return null;
		}
		// Проверяет обязательные реквизиты объекта.
		// У объекта должен быть определен экспортируемый метод ОбязательныеРеквизиты().
		// У объекта должена быть определена экспортируемая переменная СтруктураРеквизитов.
		//
		// Параметры:
		//  Объект    - объект, реквизиты которого проверяются.
		//  Отказ     - Истина, если проверка выявила проблемы. В противном случае не меняется.
		//              В параметр удобно передавать параметр Отказ обработчика ПередЗаписью.
		//  Сообщение - строка, в которую будут дописаны "замечания", выявленные при проверке.
		//              Сформированная таким образом строка может использоваться в вызывающей
		//              процедуре в качестве сообщения или предупреждения.
		//

		public void ПроверитьОбязательныеРеквизиты(/*Объект, Отказ, Сообщение = "", ВлияющиеРеквизиты = ""*/)
		{
		}
		////////////////////////////////////////////////////////////////////////////////
		// ОБРАБОТЧИКИ СОБЫТИЙ ОБЪЕКТА

		public object ПолучитьВыборкуПодчиненныхСохраненныхНастроек(/**/)
		{
			//Запрос = Новый Запрос;
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	СохраненныеНастройки.Ссылка
	|ИЗ
	|	Справочник.СохраненныеНастройки КАК СохраненныеНастройки
	|ГДЕ
	|	СохраненныеНастройки.ТипНастройки = ЗНАЧЕНИЕ(Перечисление.ТипыНастроек.НастройкиПользователяНастройкиОтчета)
	|	И СохраненныеНастройки.НастраиваемыйОбъект = &НастраиваемыйОбъект";*/
			//Запрос.УстановитьПараметр("НастраиваемыйОбъект", ЭтотОбъект.Ссылка);
			//Выборка = Запрос.Выполнить().Выбрать();
			return null;
		}

		public void ПередЗаписью(/*Отказ*/)
		{
			//Сообщение = "";
			/*//ПроверитьОбязательныеРеквизиты(ЭтотОбъект, Отказ, Сообщение);
*/
			if(true/*Отказ*/)
			{
				//Сообщить("Настройка """ + Наименование + """ не может быть записана:" + Сообщение, СтатусСообщения.Важное);
			}
			/*// Если все же вариант отчета удаляем, нужно удалить все настройки пользователей панели пользователя
*/
			if(true/*ПометкаУдаления И Не Ссылка.ПометкаУдаления*/)
			{
				//Выборка = ПолучитьВыборкуПодчиненныхСохраненныхНастроек();
				while(true/*Выборка.Следующий()*/)
				{
					//Объект = Выборка.Ссылка.ПолучитьОбъект();
					//Объект.УстановитьПометкуУдаления(Истина);
					//Объект.Записать();
				}
				//;;
			}
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			//КраткийСоставНастройки = "";
		}

		public void ПередУдалением(/*Отказ*/)
		{
			if(true/*ЭтотОбъект.ТипНастройки <> Перечисления.ТипыНастроек.НастройкиОтчета*/)
			{
			}
			if(true/*ЭтотОбъект.Метаданные().Реквизиты.Найти("ОтрицательноеКрасным") <> Неопределено*/)
			{
				/*// Проверим возможность удаления варианта пользователем
*/
				//СписокДоступныхВариантов = ТиповыеОтчеты.ПолучитьСписокДоступныхВариантов(ЭтотОбъект.НастраиваемыйОбъект,, Истина, ЭтотОбъект);
				//ДоступныйВариант = СписокДоступныхВариантов.НайтиПоЗначению(ЭтотОбъект.Ссылка);
				if(true/*НЕ РольДоступна("ПолныеПрава") и (ДоступныйВариант = Неопределено ИЛИ Не ДоступныйВариант.Пометка)*/)
				{
					//Отказ = Истина;
					//ОбщегоНазначения.СообщитьОбОшибке("Текущему пользователю запрещено удалять вариант отчета: " + ЭтотОбъект);
				}
				/*// Если все же вариант отчета удаляем, нужно удалить все настройки пользователей панели пользователя
*/
				//Выборка = ПолучитьВыборкуПодчиненныхСохраненныхНастроек();
				while(true/*Выборка.Следующий()*/)
				{
					//Объект = Выборка.Ссылка.ПолучитьОбъект();
					//Объект.Удалить();
				}
				//;;
			}
		}

		public void ПриКопировании(/*ОбъектКопирования*/)
		{
			//ЭтотОбъект.Пользователи.Очистить();
		}
		///////////////////////////////////////////////////////////////////////////////
		// РАЗДЕЛ ОСНОВНОЙ ПРОГРАММЫ
	}
}