﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//PodklyuchaemoeOborudovanie
	[Маршрут("Справочники/ПодключаемоеОборудование","")]
	public class ПодключаемоеОборудованиеЗапрос: V82.СправочникиСсылка.ПодключаемоеОборудование,IReturn<ПодключаемоеОборудованиеЗапрос>
	{
	}
	[Маршрут("Справочники/ПодключаемоеОборудование/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ПодключаемоеОборудование/ПоСсылке","{Ссылка}")]
	public class ПодключаемоеОборудованиеНайтиПоСсылке: V82.СправочникиСсылка.ПодключаемоеОборудование,IReturn<ПодключаемоеОборудованиеНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ПодключаемоеОборудование/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ПодключаемоеОборудование/ПоНаименованию","{Наименование}")]
	public class ПодключаемоеОборудованиеНайтиПоНаименованию: V82.СправочникиСсылка.ПодключаемоеОборудование,IReturn<ПодключаемоеОборудованиеНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ПодключаемоеОборудование/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПодключаемоеОборудованиеВыбратьПоСсылке: V82.СправочникиСсылка.ПодключаемоеОборудование,IReturn<ПодключаемоеОборудованиеВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПодключаемоеОборудование/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПодключаемоеОборудованиеВыбратьПоНаименованию: V82.СправочникиСсылка.ПодключаемоеОборудование,IReturn<ПодключаемоеОборудованиеВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class ПодключаемоеОборудованиеОтвет
	{
		public string Ответ {get;set;}
	}

	public class ПодключаемоеОборудованиеСервис : Service
	{
		
		public object Get(ПодключаемоеОборудованиеНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПодключаемоеОборудованиеНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПодключаемоеОборудованиеВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПодключаемоеОборудованиеВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПодключаемоеОборудованиеЗапрос Запрос)
		{
			return new ПодключаемоеОборудованиеОтвет {Ответ = "ПодключаемоеОборудование, "};
		}

		public object Post(ПодключаемоеОборудованиеЗапрос ЗапросПодключаемоеОборудование)
		{
			var Ссылка = (СправочникиСсылка.ПодключаемоеОборудование)ЗапросПодключаемоеОборудование;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}