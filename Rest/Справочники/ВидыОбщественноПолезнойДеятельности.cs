﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyObshhestvennoPoleznojjDeyatelnosti
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности","")]
	public class ВидыОбщественноПолезнойДеятельностиЗапрос: V82.СправочникиСсылка.ВидыОбщественноПолезнойДеятельности,IReturn<ВидыОбщественноПолезнойДеятельностиЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности/ПоСсылке","{Ссылка}")]
	public class ВидыОбщественноПолезнойДеятельностиНайтиПоСсылке: V82.СправочникиСсылка.ВидыОбщественноПолезнойДеятельности,IReturn<ВидыОбщественноПолезнойДеятельностиНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности/ПоКоду","{Код}")]
	public class ВидыОбщественноПолезнойДеятельностиНайтиПоКоду: V82.СправочникиСсылка.ВидыОбщественноПолезнойДеятельности,IReturn<ВидыОбщественноПолезнойДеятельностиНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности/ПоНаименованию","{Наименование}")]
	public class ВидыОбщественноПолезнойДеятельностиНайтиПоНаименованию: V82.СправочникиСсылка.ВидыОбщественноПолезнойДеятельности,IReturn<ВидыОбщественноПолезнойДеятельностиНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыОбщественноПолезнойДеятельностиВыбратьПоСсылке: V82.СправочникиСсылка.ВидыОбщественноПолезнойДеятельности,IReturn<ВидыОбщественноПолезнойДеятельностиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыОбщественноПолезнойДеятельностиВыбратьПоКоду: V82.СправочникиСсылка.ВидыОбщественноПолезнойДеятельности,IReturn<ВидыОбщественноПолезнойДеятельностиВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыОбщественноПолезнойДеятельности/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыОбщественноПолезнойДеятельностиВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыОбщественноПолезнойДеятельности,IReturn<ВидыОбщественноПолезнойДеятельностиВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class ВидыОбщественноПолезнойДеятельностиОтвет
	{
		public string Ответ {get;set;}
	}

	public class ВидыОбщественноПолезнойДеятельностиСервис : Service
	{
		
		public object Get(ВидыОбщественноПолезнойДеятельностиНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыОбщественноПолезнойДеятельностиНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыОбщественноПолезнойДеятельности.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыОбщественноПолезнойДеятельностиОтвет() {Ответ = "ВидыОбщественноПолезнойДеятельности c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ВидыОбщественноПолезнойДеятельностиНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыОбщественноПолезнойДеятельностиВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыОбщественноПолезнойДеятельностиВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыОбщественноПолезнойДеятельностиВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыОбщественноПолезнойДеятельностиЗапрос Запрос)
		{
			return new ВидыОбщественноПолезнойДеятельностиОтвет {Ответ = "ВидыОбщественноПолезнойДеятельности, "};
		}

		public object Post(ВидыОбщественноПолезнойДеятельностиЗапрос ЗапросВидыОбщественноПолезнойДеятельности)
		{
			var Ссылка = (СправочникиСсылка.ВидыОбщественноПолезнойДеятельности)ЗапросВидыОбщественноПолезнойДеятельности;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}