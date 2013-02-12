﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//StrokiFinansovogoRascheta
	[Маршрут("Справочники/СтрокиФинансовогоРасчета","")]
	public class СтрокиФинансовогоРасчетаЗапрос: V82.СправочникиСсылка.СтрокиФинансовогоРасчета,IReturn<СтрокиФинансовогоРасчетаЗапрос>
	{
	}
	[Маршрут("Справочники/СтрокиФинансовогоРасчета/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СтрокиФинансовогоРасчета/ПоСсылке","{Ссылка}")]
	public class СтрокиФинансовогоРасчетаНайтиПоСсылке: V82.СправочникиСсылка.СтрокиФинансовогоРасчета,IReturn<СтрокиФинансовогоРасчетаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СтрокиФинансовогоРасчета/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СтрокиФинансовогоРасчета/ПоКоду","{Код}")]
	public class СтрокиФинансовогоРасчетаНайтиПоКоду: V82.СправочникиСсылка.СтрокиФинансовогоРасчета,IReturn<СтрокиФинансовогоРасчетаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СтрокиФинансовогоРасчета/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СтрокиФинансовогоРасчета/ПоНаименованию","{Наименование}")]
	public class СтрокиФинансовогоРасчетаНайтиПоНаименованию: V82.СправочникиСсылка.СтрокиФинансовогоРасчета,IReturn<СтрокиФинансовогоРасчетаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СтрокиФинансовогоРасчета/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СтрокиФинансовогоРасчетаВыбратьПоСсылке: V82.СправочникиСсылка.СтрокиФинансовогоРасчета,IReturn<СтрокиФинансовогоРасчетаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтрокиФинансовогоРасчета/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СтрокиФинансовогоРасчетаВыбратьПоКоду: V82.СправочникиСсылка.СтрокиФинансовогоРасчета,IReturn<СтрокиФинансовогоРасчетаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтрокиФинансовогоРасчета/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СтрокиФинансовогоРасчетаВыбратьПоНаименованию: V82.СправочникиСсылка.СтрокиФинансовогоРасчета,IReturn<СтрокиФинансовогоРасчетаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class СтрокиФинансовогоРасчетаОтвет
	{
		public string Ответ {get;set;}
	}

	public class СтрокиФинансовогоРасчетаСервис : Service
	{
		
		public object Get(СтрокиФинансовогоРасчетаНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтрокиФинансовогоРасчетаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СтрокиФинансовогоРасчета.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СтрокиФинансовогоРасчетаОтвет() {Ответ = "СтрокиФинансовогоРасчета c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СтрокиФинансовогоРасчетаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтрокиФинансовогоРасчетаВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтрокиФинансовогоРасчетаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтрокиФинансовогоРасчетаВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СтрокиФинансовогоРасчетаЗапрос Запрос)
		{
			return new СтрокиФинансовогоРасчетаОтвет {Ответ = "СтрокиФинансовогоРасчета, "};
		}

		public object Post(СтрокиФинансовогоРасчетаЗапрос ЗапросСтрокиФинансовогоРасчета)
		{
			var Ссылка = (СправочникиСсылка.СтрокиФинансовогоРасчета)ЗапросСтрокиФинансовогоРасчета;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}