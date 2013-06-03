﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//UchetPolozhenijjPerekhodnogoPeriodaPoNDS
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС","")]
	public class УчетПоложенийПереходногоПериодаПоНДСЗапрос: V82.ДокументыСсылка.УчетПоложенийПереходногоПериодаПоНДС,IReturn<УчетПоложенийПереходногоПериодаПоНДСЗапрос>
	{
	}
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/ПоСсылке","{Ссылка}")]
	public class УчетПоложенийПереходногоПериодаПоНДСНайтиПоСсылке: V82.ДокументыСсылка.УчетПоложенийПереходногоПериодаПоНДС,IReturn<УчетПоложенийПереходногоПериодаПоНДСНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/ПоНомеру","{Номер}")]
	public class УчетПоложенийПереходногоПериодаПоНДСНайтиПоНомеру: V82.ДокументыСсылка.УчетПоложенийПереходногоПериодаПоНДС,IReturn<УчетПоложенийПереходногоПериодаПоНДСНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class УчетПоложенийПереходногоПериодаПоНДСВыбратьПоСсылке: V82.ДокументыСсылка.УчетПоложенийПереходногоПериодаПоНДС,IReturn<УчетПоложенийПереходногоПериодаПоНДСВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class УчетПоложенийПереходногоПериодаПоНДСВыбратьПоНомеру: V82.ДокументыСсылка.УчетПоложенийПереходногоПериодаПоНДС,IReturn<УчетПоложенийПереходногоПериодаПоНДСВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class УчетПоложенийПереходногоПериодаПоНДССтраницаПоСсылке: V82.ДокументыСсылка.УчетПоложенийПереходногоПериодаПоНДС,IReturn<УчетПоложенийПереходногоПериодаПоНДССтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/УчетПоложенийПереходногоПериодаПоНДС/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class УчетПоложенийПереходногоПериодаПоНДССтраницаПоНомеру: V82.ДокументыСсылка.УчетПоложенийПереходногоПериодаПоНДС,IReturn<УчетПоложенийПереходногоПериодаПоНДССтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class УчетПоложенийПереходногоПериодаПоНДСОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class УчетПоложенийПереходногоПериодаПоНДССервис : Service
	{
		
		public object Get(УчетПоложенийПереходногоПериодаПоНДСЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(УчетПоложенийПереходногоПериодаПоНДСНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.УчетПоложенийПереходногоПериодаПоНДС.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new УчетПоложенийПереходногоПериодаПоНДСОтвет() { Ответ = "УчетПоложенийПереходногоПериодаПоНДС c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(УчетПоложенийПереходногоПериодаПоНДСНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.УчетПоложенийПереходногоПериодаПоНДС.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new УчетПоложенийПереходногоПериодаПоНДСОтвет() {Ответ = "УчетПоложенийПереходногоПериодаПоНДС c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(УчетПоложенийПереходногоПериодаПоНДСВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.УчетПоложенийПереходногоПериодаПоНДС.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(УчетПоложенийПереходногоПериодаПоНДСВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(УчетПоложенийПереходногоПериодаПоНДССтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(УчетПоложенийПереходногоПериодаПоНДССтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(УчетПоложенийПереходногоПериодаПоНДСЗапрос Запрос)
		{
			return new УчетПоложенийПереходногоПериодаПоНДСОтвет {Ответ = "УчетПоложенийПереходногоПериодаПоНДС, "};
		}

		public object Post(УчетПоложенийПереходногоПериодаПоНДСЗапрос ЗапросУчетПоложенийПереходногоПериодаПоНДС)
		{
			var Ссылка = (ДокументыСсылка.УчетПоложенийПереходногоПериодаПоНДС)ЗапросУчетПоложенийПереходногоПериодаПоНДС;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}