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
	///(Упр)
	///</summary>
	public partial class СтатьиОборотовПоБюджетам: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника СтатьиОборотовПоБюджетам. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.СтатьиОборотовПоБюджетам.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,100);//"Наименование " + НомерЭлемента;

				Объект.НаименованиеПолное = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.УчетПоКоличеству = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.УчетПоСумме = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИсточникДанныхДляЦены = V82.Справочники/*Менеджер*/.ИсточникиДанныхДляРасчетовБюджетирования.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования();
				Объект.ПоказательИсточникаДанныхДляЦены = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,50);
				Объект.ИсточникДанныхДляФакта = V82.Справочники/*Менеджер*/.ИсточникиДанныхДляРасчетовБюджетирования.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования();
				Объект.ПоказательИсточникаДанныхДляФактаСум = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,100);
				Объект.СпособОпределенияВалютыОборотаФакт = (V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.СпособыОпределенияВалютыОборотаПоСтатье));
				Объект.ПоказательИсточникаДанныхДляФактаКол = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,100);
				Объект.ЕдиницаИзмерения = V82.Справочники/*Менеджер*/.КлассификаторЕдиницИзмерения.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения();
				Объект.РазделениеПоКонтрагентам = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.РазделениеПоНоменклатуре = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОсновнаяВалюта = V82.Справочники/*Менеджер*/.Валюты.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Валюты();
				Объект.ОсновноеЦФО = V82.Справочники/*Менеджер*/.Подразделения.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Подразделения();
				Объект.ОсновнойПроект = V82.Справочники/*Менеджер*/.Проекты.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Проекты();
				Объект.ОсновнойКонтрагент = V82.Справочники/*Менеджер*/.Контрагенты.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Контрагенты();
				Объект.Комментарий = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.КоэффициентДляФактаСум = ГенераторСлучайныхЧисел.Следующий(999999999);
				Объект.КоэффициентДляФактаКол = ГенераторСлучайныхЧисел.Следующий(999999999);

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
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.СтатьиОборотовПоБюджетам.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника СтатьиОборотовПоБюджетам. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.СтатьиОборотовПоБюджетам.Выбрать())
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
			Console.WriteLine("СериализацияJson 1000 элементов справочника СтатьиОборотовПоБюджетам. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.СтатьиОборотовПоБюджетам.Выбрать())
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