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
	public partial class МедицинскиеСтраховыеПолисы: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника МедицинскиеСтраховыеПолисы. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.МедицинскиеСтраховыеПолисы.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,25);//"Наименование " + НомерЭлемента;

				Объект.Физлицо = V82.Справочники/*Менеджер*/.ФизическиеЛица.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ФизическиеЛица();
				Объект.Организация = V82.Справочники/*Менеджер*/.Организации.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Организации();
				Объект.ВидСтрахования = (V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования));
				Объект.ДатаВыдачиПолиса = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ДатаОкончанияПолиса = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ПрограммаСтрахования = V82.Справочники/*Менеджер*/.ПрограммыМедицинскогоСтрахования.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования();
				Объект.СтрахованиеРодственника = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.Родственник = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,50);
				Объект.Пол = (V82.Перечисления/*Ссылка*/.ПолФизическихЛиц)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ПолФизическихЛиц));
				Объект.ДатаРождения = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.УдостоверениеЛичности = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,300);
				Объект.АдресФактический = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,100);
				Объект.ТелефонДомашний = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,100);
				Объект.ДокументСерия = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,14);
				Объект.ДокументНомер = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,14);
				Объект.ДокументДатаВыдачи = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ДокументКемВыдан = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ДокументКодПодразделения = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,15);
				Объект.Комментарий = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);

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
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.МедицинскиеСтраховыеПолисы.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника МедицинскиеСтраховыеПолисы. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.МедицинскиеСтраховыеПолисы.Выбрать())
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
			Console.WriteLine("СериализацияJson 1000 элементов справочника МедицинскиеСтраховыеПолисы. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.МедицинскиеСтраховыеПолисы.Выбрать())
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