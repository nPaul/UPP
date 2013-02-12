﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Territorii
	[Маршрут("Справочники/Территории","")]
	public class ТерриторииЗапрос: V82.СправочникиСсылка.Территории,IReturn<ТерриторииЗапрос>
	{
	}
	[Маршрут("Справочники/Территории/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Территории/ПоСсылке","{Ссылка}")]
	public class ТерриторииНайтиПоСсылке: V82.СправочникиСсылка.Территории,IReturn<ТерриторииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Территории/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Территории/ПоКоду","{Код}")]
	public class ТерриторииНайтиПоКоду: V82.СправочникиСсылка.Территории,IReturn<ТерриторииНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Территории/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Территории/ПоНаименованию","{Наименование}")]
	public class ТерриторииНайтиПоНаименованию: V82.СправочникиСсылка.Территории,IReturn<ТерриторииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Территории/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ТерриторииВыбратьПоСсылке: V82.СправочникиСсылка.Территории,IReturn<ТерриторииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Территории/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ТерриторииВыбратьПоКоду: V82.СправочникиСсылка.Территории,IReturn<ТерриторииВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Территории/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ТерриторииВыбратьПоНаименованию: V82.СправочникиСсылка.Территории,IReturn<ТерриторииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class ТерриторииОтвет
	{
		public string Ответ {get;set;}
	}

	public class ТерриторииСервис : Service
	{
		
		public object Get(ТерриторииНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Территории.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ТерриторииОтвет() {Ответ = "Территории c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ТерриторииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТерриторииВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ТерриторииЗапрос Запрос)
		{
			return new ТерриторииОтвет {Ответ = "Территории, "};
		}

		public object Post(ТерриторииЗапрос ЗапросТерритории)
		{
			var Ссылка = (СправочникиСсылка.Территории)ЗапросТерритории;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}