﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//NastrojjkiRaschetaSebestoimosti
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости","")]
	public class НастройкиРасчетаСебестоимостиЗапрос: V82.СправочникиСсылка.НастройкиРасчетаСебестоимости,IReturn<НастройкиРасчетаСебестоимостиЗапрос>
	{
	}
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/ПоСсылке","{Ссылка}")]
	public class НастройкиРасчетаСебестоимостиНайтиПоСсылке: V82.СправочникиСсылка.НастройкиРасчетаСебестоимости,IReturn<НастройкиРасчетаСебестоимостиНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/ПоНаименованию","{Наименование}")]
	public class НастройкиРасчетаСебестоимостиНайтиПоНаименованию: V82.СправочникиСсылка.НастройкиРасчетаСебестоимости,IReturn<НастройкиРасчетаСебестоимостиНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НастройкиРасчетаСебестоимостиВыбратьПоСсылке: V82.СправочникиСсылка.НастройкиРасчетаСебестоимости,IReturn<НастройкиРасчетаСебестоимостиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class НастройкиРасчетаСебестоимостиВыбратьПоНаименованию: V82.СправочникиСсылка.НастройкиРасчетаСебестоимости,IReturn<НастройкиРасчетаСебестоимостиВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НастройкиРасчетаСебестоимостиСтраницаПоСсылке: V82.СправочникиСсылка.НастройкиРасчетаСебестоимости,IReturn<НастройкиРасчетаСебестоимостиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НастройкиРасчетаСебестоимости/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class НастройкиРасчетаСебестоимостиСтраницаПоНаименованию: V82.СправочникиСсылка.НастройкиРасчетаСебестоимости,IReturn<НастройкиРасчетаСебестоимостиСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НастройкиРасчетаСебестоимостиОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НастройкиРасчетаСебестоимостиСервис : Service
	{
		
		public object Get(НастройкиРасчетаСебестоимостиЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиРасчетаСебестоимостиНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.НастройкиРасчетаСебестоимости.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new НастройкиРасчетаСебестоимостиОтвет() { Ответ = "НастройкиРасчетаСебестоимости c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НастройкиРасчетаСебестоимостиНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиРасчетаСебестоимостиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.НастройкиРасчетаСебестоимости.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(НастройкиРасчетаСебестоимостиВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиРасчетаСебестоимостиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиРасчетаСебестоимостиСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(НастройкиРасчетаСебестоимостиЗапрос Запрос)
		{
			return new НастройкиРасчетаСебестоимостиОтвет {Ответ = "НастройкиРасчетаСебестоимости, "};
		}

		public object Post(НастройкиРасчетаСебестоимостиЗапрос ЗапросНастройкиРасчетаСебестоимости)
		{
			var Ссылка = (СправочникиСсылка.НастройкиРасчетаСебестоимости)ЗапросНастройкиРасчетаСебестоимости;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}