﻿
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиТест
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class Контрагенты: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника Контрагенты. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.Контрагенты.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,100);//"Наименование " + НомерЭлемента;

				Объект.НаименованиеПолное = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.Комментарий = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ДополнительноеОписание = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ГоловнойКонтрагент = V82.Справочники/*Менеджер*/.Контрагенты.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Контрагенты();
				Объект.ИсточникИнформацииПриОбращении = V82.Справочники/*Менеджер*/.ИсточникиИнформацииПриОбращенииПокупателей.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей();
				Объект.КодПоОКПО = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,10);
				Объект.ИНН = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,12);
				Объект.КПП = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);
				Объект.ЮрФизЛицо = (V82.Перечисления/*Ссылка*/.ЮрФизЛицо)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ЮрФизЛицо));
				Объект.ОсновнойБанковскийСчет = V82.Справочники/*Менеджер*/.БанковскиеСчета.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.БанковскиеСчета();
				Объект.ОсновнойДоговорКонтрагента = V82.Справочники/*Менеджер*/.ДоговорыКонтрагентов.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ДоговорыКонтрагентов();
				Объект.ОсновнойВидДеятельности = V82.Справочники/*Менеджер*/.ВидыДеятельностиКонтрагентов.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ВидыДеятельностиКонтрагентов();
				Объект.ДокументУдостоверяющийЛичность = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ОсновнойМенеджерПокупателя = V82.Справочники/*Менеджер*/.Пользователи.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Пользователи();
				Объект.Покупатель = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.Поставщик = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.РасписаниеРаботыСтрокой = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.СрокВыполненияЗаказаПоставщиком = ГенераторСлучайныхЧисел.Следующий(999);
				Объект.ОсновноеКонтактноеЛицо = V82.Справочники/*Менеджер*/.КонтактныеЛицаКонтрагентов.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.КонтактныеЛицаКонтрагентов();
				Объект.НеЯвляетсяРезидентом = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОКОПФ = V82.Справочники/*Менеджер*/.КлассификаторОКОПФ.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.КлассификаторОКОПФ();
				Объект.Регион = V82.Справочники/*Менеджер*/.Регионы.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Регионы();
				Объект.ГруппаДоступаКонтрагента = V82.Справочники/*Менеджер*/.ГруппыДоступаКонтрагентов.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ГруппыДоступаКонтрагентов();

				Объект.Записать();
				Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void Удалить1000()
		{
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.Контрагенты.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника Контрагенты. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.Контрагенты.Выбрать())
				{
					НомерЭлемента++;
					Ссылка.СериализацияProtoBuf(Поток);
					Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
					Console.CursorLeft = 0;
				}
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void СериализацияJson1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияJson 1000 элементов справочника Контрагенты. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.Контрагенты.Выбрать())
			{
				НомерЭлемента++;
				Ссылка.СериализацияJson();
				Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}
	}
}