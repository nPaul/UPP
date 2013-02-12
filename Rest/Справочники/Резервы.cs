﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Rezervy
	[Маршрут("Справочники/Резервы","")]
	public class РезервыЗапрос: V82.СправочникиСсылка.Резервы,IReturn<РезервыЗапрос>
	{
	}
	[Маршрут("Справочники/Резервы/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Резервы/ПоСсылке","{Ссылка}")]
	public class РезервыНайтиПоСсылке: V82.СправочникиСсылка.Резервы,IReturn<РезервыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Резервы/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Резервы/ПоКоду","{Код}")]
	public class РезервыНайтиПоКоду: V82.СправочникиСсылка.Резервы,IReturn<РезервыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Резервы/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Резервы/ПоНаименованию","{Наименование}")]
	public class РезервыНайтиПоНаименованию: V82.СправочникиСсылка.Резервы,IReturn<РезервыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Резервы/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РезервыВыбратьПоСсылке: V82.СправочникиСсылка.Резервы,IReturn<РезервыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Резервы/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class РезервыВыбратьПоКоду: V82.СправочникиСсылка.Резервы,IReturn<РезервыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Резервы/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class РезервыВыбратьПоНаименованию: V82.СправочникиСсылка.Резервы,IReturn<РезервыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class РезервыОтвет
	{
		public string Ответ {get;set;}
	}

	public class РезервыСервис : Service
	{
		
		public object Get(РезервыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РезервыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Резервы.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new РезервыОтвет() {Ответ = "Резервы c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(РезервыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РезервыВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РезервыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РезервыВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(РезервыЗапрос Запрос)
		{
			return new РезервыОтвет {Ответ = "Резервы, "};
		}

		public object Post(РезервыЗапрос ЗапросРезервы)
		{
			var Ссылка = (СправочникиСсылка.Резервы)ЗапросРезервы;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}