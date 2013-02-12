﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KlyuchiAnalitikiRaspredeleniyaZatrat
	[Маршрут("Справочники/КлючиАналитикиРаспределенияЗатрат","")]
	public class КлючиАналитикиРаспределенияЗатратЗапрос: V82.СправочникиСсылка.КлючиАналитикиРаспределенияЗатрат,IReturn<КлючиАналитикиРаспределенияЗатратЗапрос>
	{
	}
	[Маршрут("Справочники/КлючиАналитикиРаспределенияЗатрат/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КлючиАналитикиРаспределенияЗатрат/ПоСсылке","{Ссылка}")]
	public class КлючиАналитикиРаспределенияЗатратНайтиПоСсылке: V82.СправочникиСсылка.КлючиАналитикиРаспределенияЗатрат,IReturn<КлючиАналитикиРаспределенияЗатратНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КлючиАналитикиРаспределенияЗатрат/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/КлючиАналитикиРаспределенияЗатрат/ПоНаименованию","{Наименование}")]
	public class КлючиАналитикиРаспределенияЗатратНайтиПоНаименованию: V82.СправочникиСсылка.КлючиАналитикиРаспределенияЗатрат,IReturn<КлючиАналитикиРаспределенияЗатратНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/КлючиАналитикиРаспределенияЗатрат/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КлючиАналитикиРаспределенияЗатратВыбратьПоСсылке: V82.СправочникиСсылка.КлючиАналитикиРаспределенияЗатрат,IReturn<КлючиАналитикиРаспределенияЗатратВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлючиАналитикиРаспределенияЗатрат/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КлючиАналитикиРаспределенияЗатратВыбратьПоНаименованию: V82.СправочникиСсылка.КлючиАналитикиРаспределенияЗатрат,IReturn<КлючиАналитикиРаспределенияЗатратВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class КлючиАналитикиРаспределенияЗатратОтвет
	{
		public string Ответ {get;set;}
	}

	public class КлючиАналитикиРаспределенияЗатратСервис : Service
	{
		
		public object Get(КлючиАналитикиРаспределенияЗатратНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиРаспределенияЗатратНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиРаспределенияЗатратВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиРаспределенияЗатратВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КлючиАналитикиРаспределенияЗатратЗапрос Запрос)
		{
			return new КлючиАналитикиРаспределенияЗатратОтвет {Ответ = "КлючиАналитикиРаспределенияЗатрат, "};
		}

		public object Post(КлючиАналитикиРаспределенияЗатратЗапрос ЗапросКлючиАналитикиРаспределенияЗатрат)
		{
			var Ссылка = (СправочникиСсылка.КлючиАналитикиРаспределенияЗатрат)ЗапросКлючиАналитикиРаспределенияЗатрат;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}