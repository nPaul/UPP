﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VychetyNDFL
	[Маршрут("Справочники/ВычетыНДФЛ","")]
	public class ВычетыНДФЛЗапрос: V82.СправочникиСсылка.ВычетыНДФЛ,IReturn<ВычетыНДФЛЗапрос>
	{
	}
	[Маршрут("Справочники/ВычетыНДФЛ/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВычетыНДФЛ/ПоСсылке","{Ссылка}")]
	public class ВычетыНДФЛНайтиПоСсылке: V82.СправочникиСсылка.ВычетыНДФЛ,IReturn<ВычетыНДФЛНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВычетыНДФЛ/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВычетыНДФЛ/ПоКоду","{Код}")]
	public class ВычетыНДФЛНайтиПоКоду: V82.СправочникиСсылка.ВычетыНДФЛ,IReturn<ВычетыНДФЛНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВычетыНДФЛ/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВычетыНДФЛ/ПоНаименованию","{Наименование}")]
	public class ВычетыНДФЛНайтиПоНаименованию: V82.СправочникиСсылка.ВычетыНДФЛ,IReturn<ВычетыНДФЛНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВычетыНДФЛ/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВычетыНДФЛВыбратьПоСсылке: V82.СправочникиСсылка.ВычетыНДФЛ,IReturn<ВычетыНДФЛВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВычетыНДФЛ/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВычетыНДФЛВыбратьПоКоду: V82.СправочникиСсылка.ВычетыНДФЛ,IReturn<ВычетыНДФЛВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВычетыНДФЛ/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВычетыНДФЛВыбратьПоНаименованию: V82.СправочникиСсылка.ВычетыНДФЛ,IReturn<ВычетыНДФЛВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class ВычетыНДФЛОтвет
	{
		public string Ответ {get;set;}
	}

	public class ВычетыНДФЛСервис : Service
	{
		
		public object Get(ВычетыНДФЛНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВычетыНДФЛНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВычетыНДФЛ.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВычетыНДФЛОтвет() {Ответ = "ВычетыНДФЛ c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ВычетыНДФЛНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВычетыНДФЛВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВычетыНДФЛВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВычетыНДФЛВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВычетыНДФЛЗапрос Запрос)
		{
			return new ВычетыНДФЛОтвет {Ответ = "ВычетыНДФЛ, "};
		}

		public object Post(ВычетыНДФЛЗапрос ЗапросВычетыНДФЛ)
		{
			var Ссылка = (СправочникиСсылка.ВычетыНДФЛ)ЗапросВычетыНДФЛ;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}