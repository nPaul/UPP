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
	///(Общ)
	///</summary>
	public partial class СтатьиЗатрат:СправочникОбъект
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
		public string/*100*/ Наименование;
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыЗатрат ВидЗатрат;//Вид затрат
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.СтатусыМатериальныхЗатратНаПроизводство СтатусМатериальныхЗатрат;//Статус материальных затрат
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ХарактерЗатрат ХарактерЗатрат;//Характер затрат
		///<summary>
		///(Регл)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыРасходовНУ ВидРасходовНУ;//Вид расходов (НУ)
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
						Insert Into _Reference248(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3811RRef
						,_Fld3812RRef
						,_Fld3813RRef
						,_Fld3814RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@ВидЗатрат
						,@СтатусМатериальныхЗатрат
						,@ХарактерЗатрат
						,@ВидРасходовНУ)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference248
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3811RRef	= @ВидЗатрат
						,_Fld3812RRef	= @СтатусМатериальныхЗатрат
						,_Fld3813RRef	= @ХарактерЗатрат
						,_Fld3814RRef	= @ВидРасходовНУ
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ВидЗатрат", ВидЗатрат.Ключ());
					Команда.Parameters.AddWithValue("СтатусМатериальныхЗатрат", СтатусМатериальныхЗатрат.Ключ());
					Команда.Parameters.AddWithValue("ХарактерЗатрат", ХарактерЗатрат.Ключ());
					Команда.Parameters.AddWithValue("ВидРасходовНУ", ВидРасходовНУ.Ключ());
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
					Команда.CommandText = @"Delete _Reference248
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		// Процедура - обработчик события "ПередЗаписью".
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*НЕ ОбменДанными.Загрузка И НЕ ЭтоГруппа*/)
			{
				if(true/*ВидЗатрат.Пустая()*/)
				{
					//Сообщить("Укажите вид затрат!", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
				if(true/*ВидЗатрат = Перечисления.ВидыЗатрат.Материальные 
		   И ХарактерЗатрат = Перечисления.ХарактерЗатрат.ПроизводственныеРасходы
		   И СтатусМатериальныхЗатрат.Пустая()*/)
				{
					//Сообщить("Укажите статус материальных затрат!", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
				if(true/*ХарактерЗатрат.Пустая()*/)
				{
					//Сообщить("Укажите характер затрат!", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
				if(true/*ВидРасходовНУ.Пустая()*/)
				{
					//Сообщить("Укажите вид расходов (НУ)!", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
				if(true/*Не ЭтоНовый()*/)
				{
					if(true/*(ВидЗатрат <> Ссылка.ВидЗатрат
					ИЛИ СтатусМатериальныхЗатрат <> Ссылка.СтатусМатериальныхЗатрат
					ИЛИ ХарактерЗатрат <> Ссылка.ХарактерЗатрат)
			   И ПолныеПрава.СтатьяЗатрат_СуществуютСсылкиВРегистрахНакопления(Ссылка)*/)
					{
						/*ТекстСообщения = "
				|Статья затрат """ + СокрЛП(Ссылка) + """ указана в проведенных документах.
				|Реквизиты ""Характер затрат"", ""Вид затрат"", ""Статус мат. затрат"" не могут быть изменены!";*/
						//ОбщегоНазначения.СообщитьОбОшибке(ТекстСообщения, Отказ);
					}
				}
			}
		}
	}
}