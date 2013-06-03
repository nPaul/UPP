﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//SpisanieMaterialovIzEHkspluatacii
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации","")]
	public class СписаниеМатериаловИзЭксплуатацииЗапрос: V82.ДокументыСсылка.СписаниеМатериаловИзЭксплуатации,IReturn<СписаниеМатериаловИзЭксплуатацииЗапрос>
	{
	}
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/ПоСсылке","{Ссылка}")]
	public class СписаниеМатериаловИзЭксплуатацииНайтиПоСсылке: V82.ДокументыСсылка.СписаниеМатериаловИзЭксплуатации,IReturn<СписаниеМатериаловИзЭксплуатацииНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/ПоНомеру","{Номер}")]
	public class СписаниеМатериаловИзЭксплуатацииНайтиПоНомеру: V82.ДокументыСсылка.СписаниеМатериаловИзЭксплуатации,IReturn<СписаниеМатериаловИзЭксплуатацииНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СписаниеМатериаловИзЭксплуатацииВыбратьПоСсылке: V82.ДокументыСсылка.СписаниеМатериаловИзЭксплуатации,IReturn<СписаниеМатериаловИзЭксплуатацииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class СписаниеМатериаловИзЭксплуатацииВыбратьПоНомеру: V82.ДокументыСсылка.СписаниеМатериаловИзЭксплуатации,IReturn<СписаниеМатериаловИзЭксплуатацииВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СписаниеМатериаловИзЭксплуатацииСтраницаПоСсылке: V82.ДокументыСсылка.СписаниеМатериаловИзЭксплуатации,IReturn<СписаниеМатериаловИзЭксплуатацииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/СписаниеМатериаловИзЭксплуатации/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class СписаниеМатериаловИзЭксплуатацииСтраницаПоНомеру: V82.ДокументыСсылка.СписаниеМатериаловИзЭксплуатации,IReturn<СписаниеМатериаловИзЭксплуатацииСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СписаниеМатериаловИзЭксплуатацииОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СписаниеМатериаловИзЭксплуатацииСервис : Service
	{
		
		public object Get(СписаниеМатериаловИзЭксплуатацииЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СписаниеМатериаловИзЭксплуатацииНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.СписаниеМатериаловИзЭксплуатации.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СписаниеМатериаловИзЭксплуатацииОтвет() { Ответ = "СписаниеМатериаловИзЭксплуатации c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СписаниеМатериаловИзЭксплуатацииНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.СписаниеМатериаловИзЭксплуатации.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new СписаниеМатериаловИзЭксплуатацииОтвет() {Ответ = "СписаниеМатериаловИзЭксплуатации c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СписаниеМатериаловИзЭксплуатацииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.СписаниеМатериаловИзЭксплуатации.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СписаниеМатериаловИзЭксплуатацииВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(СписаниеМатериаловИзЭксплуатацииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СписаниеМатериаловИзЭксплуатацииСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(СписаниеМатериаловИзЭксплуатацииЗапрос Запрос)
		{
			return new СписаниеМатериаловИзЭксплуатацииОтвет {Ответ = "СписаниеМатериаловИзЭксплуатации, "};
		}

		public object Post(СписаниеМатериаловИзЭксплуатацииЗапрос ЗапросСписаниеМатериаловИзЭксплуатации)
		{
			var Ссылка = (ДокументыСсылка.СписаниеМатериаловИзЭксплуатации)ЗапросСписаниеМатериаловИзЭксплуатации;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}