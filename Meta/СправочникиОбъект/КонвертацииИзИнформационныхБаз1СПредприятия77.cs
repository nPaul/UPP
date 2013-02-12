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
	///Конвертации из информационных баз 1С:Предприятия
	///</summary>
	public partial class КонвертацииИзИнформационныхБаз1СПредприятия77:СправочникОбъект
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
		public string/*9*/ Код;
		public string/*25*/ Наименование;
		public string/*(50)*/ ИдентификаторКонфигурации;//Идентификатор конфигурации
		public string/*(0)*/ Конфигурация;
		public string/*(8)*/ НомерРелиза;//Номер релиза
		public string/*(10)*/ КонвертацияПомощник;//Помощник выгрузки
		public string/*(10)*/ КонвертацияОбработка;//Обработка выгрузки
		public string/*(10)*/ КонвертацияПравила;//Правила выгрузки
		public ХранилищеЗначения ХранилищеПомощник;//Хранилище помощника
		public ХранилищеЗначения ХранилищеОписаниеПомощника;//Хранилище описания помощника
		public ХранилищеЗначения ХранилищеОбработка;//Хранилище обработки выгрузки
		public ХранилищеЗначения ХранилищеПравила;//Хранилище правил выгрузки
		public string/*(256)*/ ИдентификаторЭлемента;//Идентификатор элемента
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
						Insert Into _Reference127(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2436
						,_Fld2437
						,_Fld2438
						,_Fld2439
						,_Fld2440
						,_Fld2441
						,_Fld2442
						,_Fld2443
						,_Fld2444
						,_Fld2445
						,_Fld2446)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@ИдентификаторКонфигурации
						,@Конфигурация
						,@НомерРелиза
						,@КонвертацияПомощник
						,@КонвертацияОбработка
						,@КонвертацияПравила
						,@ХранилищеПомощник
						,@ХранилищеОписаниеПомощника
						,@ХранилищеОбработка
						,@ХранилищеПравила
						,@ИдентификаторЭлемента)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference127
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2436	= @ИдентификаторКонфигурации
						,_Fld2437	= @Конфигурация
						,_Fld2438	= @НомерРелиза
						,_Fld2439	= @КонвертацияПомощник
						,_Fld2440	= @КонвертацияОбработка
						,_Fld2441	= @КонвертацияПравила
						,_Fld2442	= @ХранилищеПомощник
						,_Fld2443	= @ХранилищеОписаниеПомощника
						,_Fld2444	= @ХранилищеОбработка
						,_Fld2445	= @ХранилищеПравила
						,_Fld2446	= @ИдентификаторЭлемента
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ИдентификаторКонфигурации", ИдентификаторКонфигурации);
					Команда.Parameters.AddWithValue("Конфигурация", Конфигурация);
					Команда.Parameters.AddWithValue("НомерРелиза", НомерРелиза);
					Команда.Parameters.AddWithValue("КонвертацияПомощник", КонвертацияПомощник);
					Команда.Parameters.AddWithValue("КонвертацияОбработка", КонвертацияОбработка);
					Команда.Parameters.AddWithValue("КонвертацияПравила", КонвертацияПравила);
					Команда.Parameters.AddWithValue("ХранилищеПомощник",new byte[0]);
					Команда.Parameters.AddWithValue("ХранилищеОписаниеПомощника",new byte[0]);
					Команда.Parameters.AddWithValue("ХранилищеОбработка",new byte[0]);
					Команда.Parameters.AddWithValue("ХранилищеПравила",new byte[0]);
					Команда.Parameters.AddWithValue("ИдентификаторЭлемента", ИдентификаторЭлемента);
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
					Команда.CommandText = @"Delete _Reference127
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}