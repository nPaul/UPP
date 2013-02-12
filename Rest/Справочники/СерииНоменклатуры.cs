﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SeriiNomenklatury
	[Маршрут("Справочники/СерииНоменклатуры","")]
	public class СерииНоменклатурыЗапрос: V82.СправочникиСсылка.СерииНоменклатуры,IReturn<СерииНоменклатурыЗапрос>
	{
	}
	[Маршрут("Справочники/СерииНоменклатуры/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СерииНоменклатуры/ПоСсылке","{Ссылка}")]
	public class СерииНоменклатурыНайтиПоСсылке: V82.СправочникиСсылка.СерииНоменклатуры,IReturn<СерииНоменклатурыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СерииНоменклатуры/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СерииНоменклатуры/ПоКоду","{Код}")]
	public class СерииНоменклатурыНайтиПоКоду: V82.СправочникиСсылка.СерииНоменклатуры,IReturn<СерииНоменклатурыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СерииНоменклатуры/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СерииНоменклатуры/ПоНаименованию","{Наименование}")]
	public class СерииНоменклатурыНайтиПоНаименованию: V82.СправочникиСсылка.СерииНоменклатуры,IReturn<СерииНоменклатурыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СерииНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СерииНоменклатурыВыбратьПоСсылке: V82.СправочникиСсылка.СерииНоменклатуры,IReturn<СерииНоменклатурыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СерииНоменклатуры/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СерииНоменклатурыВыбратьПоКоду: V82.СправочникиСсылка.СерииНоменклатуры,IReturn<СерииНоменклатурыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СерииНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СерииНоменклатурыВыбратьПоНаименованию: V82.СправочникиСсылка.СерииНоменклатуры,IReturn<СерииНоменклатурыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class СерииНоменклатурыОтвет
	{
		public string Ответ {get;set;}
	}

	public class СерииНоменклатурыСервис : Service
	{
		
		public object Get(СерииНоменклатурыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СерииНоменклатурыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СерииНоменклатуры.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СерииНоменклатурыОтвет() {Ответ = "СерииНоменклатуры c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СерииНоменклатурыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СерииНоменклатурыВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СерииНоменклатурыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СерииНоменклатурыВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СерииНоменклатурыЗапрос Запрос)
		{
			return new СерииНоменклатурыОтвет {Ответ = "СерииНоменклатуры, "};
		}

		public object Post(СерииНоменклатурыЗапрос ЗапросСерииНоменклатуры)
		{
			var Ссылка = (СправочникиСсылка.СерииНоменклатуры)ЗапросСерииНоменклатуры;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}