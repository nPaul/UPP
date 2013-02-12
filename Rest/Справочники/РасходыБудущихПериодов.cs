﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//RaskhodyBudushhikhPeriodov
	[Маршрут("Справочники/РасходыБудущихПериодов","")]
	public class РасходыБудущихПериодовЗапрос: V82.СправочникиСсылка.РасходыБудущихПериодов,IReturn<РасходыБудущихПериодовЗапрос>
	{
	}
	[Маршрут("Справочники/РасходыБудущихПериодов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/РасходыБудущихПериодов/ПоСсылке","{Ссылка}")]
	public class РасходыБудущихПериодовНайтиПоСсылке: V82.СправочникиСсылка.РасходыБудущихПериодов,IReturn<РасходыБудущихПериодовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/РасходыБудущихПериодов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/РасходыБудущихПериодов/ПоКоду","{Код}")]
	public class РасходыБудущихПериодовНайтиПоКоду: V82.СправочникиСсылка.РасходыБудущихПериодов,IReturn<РасходыБудущихПериодовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/РасходыБудущихПериодов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/РасходыБудущихПериодов/ПоНаименованию","{Наименование}")]
	public class РасходыБудущихПериодовНайтиПоНаименованию: V82.СправочникиСсылка.РасходыБудущихПериодов,IReturn<РасходыБудущихПериодовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/РасходыБудущихПериодов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РасходыБудущихПериодовВыбратьПоСсылке: V82.СправочникиСсылка.РасходыБудущихПериодов,IReturn<РасходыБудущихПериодовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/РасходыБудущихПериодов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class РасходыБудущихПериодовВыбратьПоКоду: V82.СправочникиСсылка.РасходыБудущихПериодов,IReturn<РасходыБудущихПериодовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/РасходыБудущихПериодов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class РасходыБудущихПериодовВыбратьПоНаименованию: V82.СправочникиСсылка.РасходыБудущихПериодов,IReturn<РасходыБудущихПериодовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class РасходыБудущихПериодовОтвет
	{
		public string Ответ {get;set;}
	}

	public class РасходыБудущихПериодовСервис : Service
	{
		
		public object Get(РасходыБудущихПериодовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РасходыБудущихПериодовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.РасходыБудущихПериодов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new РасходыБудущихПериодовОтвет() {Ответ = "РасходыБудущихПериодов c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(РасходыБудущихПериодовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РасходыБудущихПериодовВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РасходыБудущихПериодовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РасходыБудущихПериодовВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(РасходыБудущихПериодовЗапрос Запрос)
		{
			return new РасходыБудущихПериодовОтвет {Ответ = "РасходыБудущихПериодов, "};
		}

		public object Post(РасходыБудущихПериодовЗапрос ЗапросРасходыБудущихПериодов)
		{
			var Ссылка = (СправочникиСсылка.РасходыБудущихПериодов)ЗапросРасходыБудущихПериодов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}