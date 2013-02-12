﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//StatiOborotovPoByudzhetam
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам","")]
	public class СтатьиОборотовПоБюджетамЗапрос: V82.СправочникиСсылка.СтатьиОборотовПоБюджетам,IReturn<СтатьиОборотовПоБюджетамЗапрос>
	{
	}
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам/ПоСсылке","{Ссылка}")]
	public class СтатьиОборотовПоБюджетамНайтиПоСсылке: V82.СправочникиСсылка.СтатьиОборотовПоБюджетам,IReturn<СтатьиОборотовПоБюджетамНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам/ПоКоду","{Код}")]
	public class СтатьиОборотовПоБюджетамНайтиПоКоду: V82.СправочникиСсылка.СтатьиОборотовПоБюджетам,IReturn<СтатьиОборотовПоБюджетамНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам/ПоНаименованию","{Наименование}")]
	public class СтатьиОборотовПоБюджетамНайтиПоНаименованию: V82.СправочникиСсылка.СтатьиОборотовПоБюджетам,IReturn<СтатьиОборотовПоБюджетамНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиОборотовПоБюджетамВыбратьПоСсылке: V82.СправочникиСсылка.СтатьиОборотовПоБюджетам,IReturn<СтатьиОборотовПоБюджетамВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиОборотовПоБюджетамВыбратьПоКоду: V82.СправочникиСсылка.СтатьиОборотовПоБюджетам,IReturn<СтатьиОборотовПоБюджетамВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиОборотовПоБюджетам/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиОборотовПоБюджетамВыбратьПоНаименованию: V82.СправочникиСсылка.СтатьиОборотовПоБюджетам,IReturn<СтатьиОборотовПоБюджетамВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class СтатьиОборотовПоБюджетамОтвет
	{
		public string Ответ {get;set;}
	}

	public class СтатьиОборотовПоБюджетамСервис : Service
	{
		
		public object Get(СтатьиОборотовПоБюджетамНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиОборотовПоБюджетамНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СтатьиОборотовПоБюджетам.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СтатьиОборотовПоБюджетамОтвет() {Ответ = "СтатьиОборотовПоБюджетам c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СтатьиОборотовПоБюджетамНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиОборотовПоБюджетамВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиОборотовПоБюджетамВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиОборотовПоБюджетамВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СтатьиОборотовПоБюджетамЗапрос Запрос)
		{
			return new СтатьиОборотовПоБюджетамОтвет {Ответ = "СтатьиОборотовПоБюджетам, "};
		}

		public object Post(СтатьиОборотовПоБюджетамЗапрос ЗапросСтатьиОборотовПоБюджетам)
		{
			var Ссылка = (СправочникиСсылка.СтатьиОборотовПоБюджетам)ЗапросСтатьиОборотовПоБюджетам;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}