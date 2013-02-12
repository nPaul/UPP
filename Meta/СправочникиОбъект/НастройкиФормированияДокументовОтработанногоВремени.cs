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
	///<summary>
	///Настройки формирования документов отработанного времени
	///</summary>
	public partial class НастройкиФормированияДокументовОтработанногоВремени:СправочникОбъект
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
		public DateTime ГраницаОбработки;//Граница обработки
		public V82.Перечисления/*Ссылка*/.Периодичность ПериодДетализации;//Период детализации
		public V82.СправочникиСсылка.Организации Организация;
		public V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени СпособВводаДанных;//Способ ввода данных
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		public bool ФормироватьДокументыАвтоматически;//Формировать документы автоматически
		///<summary>
		///Уникальный идентификатор регламентного задания
		///</summary>
		public string/*(36)*/ РегламентноеЗадание;//Регламентное задание
		public bool НеОбрабатыватьВсеДокументы;//Не обрабатывать все документы
		public string/*(0)*/ Комментарий;
		///<summary>
		///Количество дней после окончания периода, по истечении которых формируются документы
		///</summary>
		public decimal/*(2)*/ Задержка;
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
						Insert Into _Reference159(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Description
						,_Fld2871
						,_Fld2872RRef
						,_Fld2873RRef
						,_Fld2874RRef
						,_Fld2875RRef
						,_Fld2876
						,_Fld2877
						,_Fld2878
						,_Fld2879
						,_Fld2880)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Наименование
						,@ГраницаОбработки
						,@ПериодДетализации
						,@Организация
						,@СпособВводаДанных
						,@ПодразделениеОрганизации
						,@ФормироватьДокументыАвтоматически
						,@РегламентноеЗадание
						,@НеОбрабатыватьВсеДокументы
						,@Комментарий
						,@Задержка)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference159
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Description	= @Наименование
						,_Fld2871	= @ГраницаОбработки
						,_Fld2872RRef	= @ПериодДетализации
						,_Fld2873RRef	= @Организация
						,_Fld2874RRef	= @СпособВводаДанных
						,_Fld2875RRef	= @ПодразделениеОрганизации
						,_Fld2876	= @ФормироватьДокументыАвтоматически
						,_Fld2877	= @РегламентноеЗадание
						,_Fld2878	= @НеОбрабатыватьВсеДокументы
						,_Fld2879	= @Комментарий
						,_Fld2880	= @Задержка
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ГраницаОбработки", ГраницаОбработки);
					Команда.Parameters.AddWithValue("ПериодДетализации", ПериодДетализации.Ключ());
					Команда.Parameters.AddWithValue("Организация", Организация.Ссылка);
					Команда.Parameters.AddWithValue("СпособВводаДанных", СпособВводаДанных.Ключ());
					Команда.Parameters.AddWithValue("ПодразделениеОрганизации", ПодразделениеОрганизации.Ссылка);
					Команда.Parameters.AddWithValue("ФормироватьДокументыАвтоматически", ФормироватьДокументыАвтоматически);
					Команда.Parameters.AddWithValue("РегламентноеЗадание", РегламентноеЗадание);
					Команда.Parameters.AddWithValue("НеОбрабатыватьВсеДокументы", НеОбрабатыватьВсеДокументы);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("Задержка", Задержка);
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
					Команда.CommandText = @"Delete _Reference159
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ОБЩИЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Выполняет проверку заполненности реквизитов.
		//
		// Параметры
		//	Заголовок - заголовок сообщения об ошибке
		//
		// Возвращаемое значение
		//	Истина  - все проверяемые реквизиты заполнены
		//	Ложь	- не все проверяемые реквизиты заполнены

		public object РеквизитыЗаполнены(/*Знач Заголовок*/)
		{
			if(true/*ЭтоГруппа*/)
			{
			}
			//Отказ = Ложь;
			/*// Должны быть заполнены обязательные реквизиты
*/
			//СтруктураОбязательныхПолей = Новый Структура();
			//СтруктураОбязательныхПолей.Вставить("ПериодДетализации",	   "Не указан период детализации формируемых документов");
			//ЗаполнениеДокументов.ПроверитьЗаполнениеШапкиДокумента(ЭтотОбъект, СтруктураОбязательныхПолей, Отказ, Заголовок);
			return null;
		}
		// Подготавливает заголовок сообщений об ошибках при записи
		//
		// Возвращаемое значение
		//  Строка, заголовок сообщений

		public object ЗаголовокПриЗаписи(/**/)
		{
			return null;
		}
		// Возвращает имя объекта метаданных для создания регл. задания
		//
		// Возвращаемое значение
		//	Строка  - имя объекта метаданных

		public object ИмяРегламентногоЗадания(/**/)
		{
			return null;
		}
	}
}