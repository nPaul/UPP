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
	///(Упр)
	///</summary>
	public partial class Должности:СправочникОбъект
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
		public string/*(0)*/ Требования;
		public string/*(0)*/ Обязанности;
		public string/*(0)*/ Условия;
		///<summary>
		///Название вакансии в средствах массовой информации
		///</summary>
		public string/*(200)*/ УдалитьНазваниеВакансииВСМИ;//Название вакансии в СМИ
		public V82.СправочникиСсылка.ТиповыеАнкеты АнкетаРезюмеКандидата;//Анкета резюме кандидата
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
						Insert Into _Reference91(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2270
						,_Fld2271
						,_Fld2272
						,_Fld2273
						,_Fld2274RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@Требования
						,@Обязанности
						,@Условия
						,@УдалитьНазваниеВакансииВСМИ
						,@АнкетаРезюмеКандидата)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference91
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2270	= @Требования
						,_Fld2271	= @Обязанности
						,_Fld2272	= @Условия
						,_Fld2273	= @УдалитьНазваниеВакансииВСМИ
						,_Fld2274RRef	= @АнкетаРезюмеКандидата
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Требования", Требования);
					Команда.Parameters.AddWithValue("Обязанности", Обязанности);
					Команда.Parameters.AddWithValue("Условия", Условия);
					Команда.Parameters.AddWithValue("УдалитьНазваниеВакансииВСМИ", УдалитьНазваниеВакансииВСМИ);
					Команда.Parameters.AddWithValue("АнкетаРезюмеКандидата", АнкетаРезюмеКандидата.Ссылка);
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
					Команда.CommandText = @"Delete _Reference91
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public object Печать(/*НазваниеОтчета = Неопределено ,Результат = Неопределено*/)
		{
			if(true/*Результат = Неопределено*/)
			{
				//Результат = Новый ТабличныйДокумент;
			}
			//Результат.ТолькоПросмотр  = Истина;
			//Результат.ОтображатьСетку = Ложь;
			//Результат.ОтображатьЗаголовки = Ложь;
			//СхемаКомпоновкиДанных = ПолучитьМакет("ОсновнаяСхемаКомпоновкиДанных");
			/*// Получить настройки схемы компоновки данных
*/
			//Настройки = СхемаКомпоновкиДанных.НастройкиПоУмолчанию;
			//ТиповыеОтчеты.ДобавитьОтбор(Настройки.Отбор, "Должность", Ссылка);
			/*// очистим результирующий табличный документ
*/
			/*//Результат.АвтоМасштаб = Истина;
*/
			//Результат.Очистить();
			/*// получим макет компоновки данных
*/
			//КомпоновщикМакета = Новый КомпоновщикМакетаКомпоновкиДанных;
			//МакетКомпоновки   = КомпоновщикМакета.Выполнить(СхемаКомпоновкиДанных, Настройки, );
			/*// создадим и инициализируем процессор компоновки данных
*/
			//ПроцессорКомпоновки = Новый ПроцессорКомпоновкиДанных;
			//ПроцессорКомпоновки.Инициализировать(МакетКомпоновки, , );
			/*// выведем отчет в табличный документ "Результат"
*/
			//ВывестиРезультатВТабличныйДокумент(ПроцессорКомпоновки, Результат);
			return null;
		}

		public void ВывестиРезультатВТабличныйДокумент(/*ПроцессорКомпоновкиДанных, ТабличныйДокумент*/)
		{
			/*// Создадим и инициализируем процессор вывода результата
*/
			//ПроцессорВывода = Новый ПроцессорВыводаРезультатаКомпоновкиДанныхВТабличныйДокумент;
			//ПроцессорВывода.УстановитьДокумент(ТабличныйДокумент);
			/*// Обозначим начало вывода
*/
			//ПроцессорВывода.НачатьВывод();
			//Состояние(НСТР("ru='Если Вы хотите прервать вывод отчета, нажмите Ctrl+Break'"));
			/*// Основной цикл вывода отчета
*/
			while(true/*Истина*/)
			{
				/*// Получим следующий элемент результата компоновки
*/
				//ЭлементРезультата = ПроцессорКомпоновкиДанных.Следующий();
				if(true/*ЭлементРезультата = Неопределено*/)
				{
					/*// Следующий элемент не получен - заканчиваем цикл вывода
*/
				}
				//ОбработкаПрерыванияПользователя();
			}
			/*;
	
	ПроцессорВывода.ЗакончитьВывод();*/
		}
	}
}