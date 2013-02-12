﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SertifikatyEHCP
	[Маршрут("Справочники/СертификатыЭЦП","")]
	public class СертификатыЭЦПЗапрос: V82.СправочникиСсылка.СертификатыЭЦП,IReturn<СертификатыЭЦПЗапрос>
	{
	}
	[Маршрут("Справочники/СертификатыЭЦП/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СертификатыЭЦП/ПоСсылке","{Ссылка}")]
	public class СертификатыЭЦПНайтиПоСсылке: V82.СправочникиСсылка.СертификатыЭЦП,IReturn<СертификатыЭЦПНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СертификатыЭЦП/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СертификатыЭЦП/ПоНаименованию","{Наименование}")]
	public class СертификатыЭЦПНайтиПоНаименованию: V82.СправочникиСсылка.СертификатыЭЦП,IReturn<СертификатыЭЦПНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СертификатыЭЦП/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СертификатыЭЦПВыбратьПоСсылке: V82.СправочникиСсылка.СертификатыЭЦП,IReturn<СертификатыЭЦПВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СертификатыЭЦП/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СертификатыЭЦПВыбратьПоНаименованию: V82.СправочникиСсылка.СертификатыЭЦП,IReturn<СертификатыЭЦПВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class СертификатыЭЦПОтвет
	{
		public string Ответ {get;set;}
	}

	public class СертификатыЭЦПСервис : Service
	{
		
		public object Get(СертификатыЭЦПНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СертификатыЭЦПНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СертификатыЭЦПВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СертификатыЭЦПВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СертификатыЭЦПЗапрос Запрос)
		{
			return new СертификатыЭЦПОтвет {Ответ = "СертификатыЭЦП, "};
		}

		public object Post(СертификатыЭЦПЗапрос ЗапросСертификатыЭЦП)
		{
			var Ссылка = (СправочникиСсылка.СертификатыЭЦП)ЗапросСертификатыЭЦП;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}