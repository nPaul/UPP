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
	public partial class ПодключаемоеОборудование:СправочникОбъект
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
		///<summary>
		///Версия компоненты
		///</summary>
		public string/*(16)*/ ВерсияКомпоненты;//Версия компоненты
		///<summary>
		///Уникальный идентификатор устройства стандарта оборудования
		///</summary>
		public string/*(36)*/ ИдентификаторУстройства;//Идентификатор устройства
		public bool УстройствоОтключено;//Устройство отключено
		public bool УстройствоИспользуется;//Устройство используется
		public V82.Перечисления/*Ссылка*/.ОбработчикиДрайверовПодключаемогоОборудования ОбработчикДрайвера;//Обработчик драйвера
		public ХранилищеЗначения Параметры;
		public V82.СправочникиСсылка.РабочиеМеста РабочееМесто;//Рабочее место
		public V82.Перечисления/*Ссылка*/.ТипыПодключаемогоОборудования ТипОборудования;//Тип оборудования
		public bool ТребуетсяПереустановка;//Требуется переустановка
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
						Insert Into _Reference190(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Description
						,_Fld3184
						,_Fld3185
						,_Fld3186
						,_Fld3187
						,_Fld3188RRef
						,_Fld3189
						,_Fld3190RRef
						,_Fld3191RRef
						,_Fld3192)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Наименование
						,@ВерсияКомпоненты
						,@ИдентификаторУстройства
						,@УстройствоОтключено
						,@УстройствоИспользуется
						,@ОбработчикДрайвера
						,@Параметры
						,@РабочееМесто
						,@ТипОборудования
						,@ТребуетсяПереустановка)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference190
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Description	= @Наименование
						,_Fld3184	= @ВерсияКомпоненты
						,_Fld3185	= @ИдентификаторУстройства
						,_Fld3186	= @УстройствоОтключено
						,_Fld3187	= @УстройствоИспользуется
						,_Fld3188RRef	= @ОбработчикДрайвера
						,_Fld3189	= @Параметры
						,_Fld3190RRef	= @РабочееМесто
						,_Fld3191RRef	= @ТипОборудования
						,_Fld3192	= @ТребуетсяПереустановка
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ВерсияКомпоненты", ВерсияКомпоненты);
					Команда.Parameters.AddWithValue("ИдентификаторУстройства", ИдентификаторУстройства);
					Команда.Parameters.AddWithValue("УстройствоОтключено", УстройствоОтключено);
					Команда.Parameters.AddWithValue("УстройствоИспользуется", УстройствоИспользуется);
					Команда.Parameters.AddWithValue("ОбработчикДрайвера", ОбработчикДрайвера.Ключ());
					Команда.Parameters.AddWithValue("Параметры",new byte[0]);
					Команда.Parameters.AddWithValue("РабочееМесто", РабочееМесто.Ссылка);
					Команда.Parameters.AddWithValue("ТипОборудования", ТипОборудования.Ключ());
					Команда.Parameters.AddWithValue("ТребуетсяПереустановка", ТребуетсяПереустановка);
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
					Команда.CommandText = @"Delete _Reference190
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ - ОБРАБОТЧИКИ СОБЫТИЙ
		// Процедура производит инициализацию параметров устройства.
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			//УстройствоОтключено = НЕ УстройствоИспользуется;
			if(true/*ЭтоНовый()*/)
			{
				//Параметры = Новый ХранилищеЗначения(Новый Структура());
			}
		}
		// ПередЗаписью()
		// Процедура проверяет уникальность наименования элемента справочника
		// для данного компьютера.

		public void ОбработкаПроверкиЗаполнения(/*Отказ, ПроверяемыеРеквизиты*/)
		{
			if(true/*НЕ ПустаяСтрока(Наименование)*/)
			{
				/*Запрос = Новый Запрос("
		|ВЫБРАТЬ
		|    1
		|ИЗ
		|    Справочник.ПодключаемоеОборудование КАК ПодключаемоеОборудование
		|ГДЕ
		|    ПодключаемоеОборудование.Наименование = &Наименование
		|    И ПодключаемоеОборудование.РабочееМесто = &РабочееМесто
		|    И ПодключаемоеОборудование.Ссылка <> &Ссылка
		|");*/
				//Запрос.УстановитьПараметр("Наименование", Наименование);
				//Запрос.УстановитьПараметр("РабочееМесто", РабочееМесто);
				//Запрос.УстановитьПараметр("Ссылка"      , Ссылка);
				if(true/*Не Запрос.Выполнить().Пустой()*/)
				{
					/*ОбщегоНазначенияКлиентСервер.СообщитьПользователю(НСтр("ru='Указано неуникальное наименование элемента!
			                                                       |Необходимо указать уникальное наименование.'"),
			                                                  ЭтотОбъект, , , Отказ);*/
				}
			}
		}
		// ОбработкаПроверкиЗаполнения()
		// Процедура производит очистку реквизитов, которые не должны копироваться.
		// Следующие реквизиты очищаются при копировании:
		// "УстройствоОтключено" - устанавливается для нового устройства в Ложь;
		// "Параметры"      - параметры устройства сбрасываются в Неопределено;
		// "Наименование"   - устанавливается отличное от исходного наименования;

		public void ПриКопировании(/*ОбъектКопирования*/)
		{
			//УстройствоОтключено = Ложь;
			//УстройствоИспользуется = Истина;
			//Параметры = Неопределено;
			//Наименование = НСтр("ru='%Наименование% (копия)'");
			//Наименование = СтрЗаменить(Наименование, "%Наименование%", ОбъектКопирования.Наименование);
		}
		// При записи
		//

		public void ПриЗаписи(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
		}
	}
}