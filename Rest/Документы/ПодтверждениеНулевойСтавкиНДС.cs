﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PodtverzhdenieNulevojjStavkiNDS
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС","")]
	public class ПодтверждениеНулевойСтавкиНДСЗапрос: V82.ДокументыСсылка.ПодтверждениеНулевойСтавкиНДС,IReturn<ПодтверждениеНулевойСтавкиНДСЗапрос>
	{
	}
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/ПоСсылке","{Ссылка}")]
	public class ПодтверждениеНулевойСтавкиНДСНайтиПоСсылке: V82.ДокументыСсылка.ПодтверждениеНулевойСтавкиНДС,IReturn<ПодтверждениеНулевойСтавкиНДСНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/ПоНомеру","{Номер}")]
	public class ПодтверждениеНулевойСтавкиНДСНайтиПоНомеру: V82.ДокументыСсылка.ПодтверждениеНулевойСтавкиНДС,IReturn<ПодтверждениеНулевойСтавкиНДСНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПодтверждениеНулевойСтавкиНДСВыбратьПоСсылке: V82.ДокументыСсылка.ПодтверждениеНулевойСтавкиНДС,IReturn<ПодтверждениеНулевойСтавкиНДСВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПодтверждениеНулевойСтавкиНДСВыбратьПоНомеру: V82.ДокументыСсылка.ПодтверждениеНулевойСтавкиНДС,IReturn<ПодтверждениеНулевойСтавкиНДСВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПодтверждениеНулевойСтавкиНДССтраницаПоСсылке: V82.ДокументыСсылка.ПодтверждениеНулевойСтавкиНДС,IReturn<ПодтверждениеНулевойСтавкиНДССтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПодтверждениеНулевойСтавкиНДС/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПодтверждениеНулевойСтавкиНДССтраницаПоНомеру: V82.ДокументыСсылка.ПодтверждениеНулевойСтавкиНДС,IReturn<ПодтверждениеНулевойСтавкиНДССтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПодтверждениеНулевойСтавкиНДСОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПодтверждениеНулевойСтавкиНДССервис : Service
	{
		
		public object Get(ПодтверждениеНулевойСтавкиНДСЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПодтверждениеНулевойСтавкиНДСНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПодтверждениеНулевойСтавкиНДС.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПодтверждениеНулевойСтавкиНДСОтвет() { Ответ = "ПодтверждениеНулевойСтавкиНДС c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПодтверждениеНулевойСтавкиНДСНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПодтверждениеНулевойСтавкиНДС.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПодтверждениеНулевойСтавкиНДСОтвет() {Ответ = "ПодтверждениеНулевойСтавкиНДС c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПодтверждениеНулевойСтавкиНДСВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПодтверждениеНулевойСтавкиНДС.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПодтверждениеНулевойСтавкиНДСВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПодтверждениеНулевойСтавкиНДССтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПодтверждениеНулевойСтавкиНДССтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПодтверждениеНулевойСтавкиНДСЗапрос Запрос)
		{
			return new ПодтверждениеНулевойСтавкиНДСОтвет {Ответ = "ПодтверждениеНулевойСтавкиНДС, "};
		}

		public object Post(ПодтверждениеНулевойСтавкиНДСЗапрос ЗапросПодтверждениеНулевойСтавкиНДС)
		{
			var Ссылка = (ДокументыСсылка.ПодтверждениеНулевойСтавкиНДС)ЗапросПодтверждениеНулевойСтавкиНДС;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}