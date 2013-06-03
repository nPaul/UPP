﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//ByudzhetnayaOperaciya
	[Маршрут("Документы/БюджетнаяОперация","")]
	public class БюджетнаяОперацияЗапрос: V82.ДокументыСсылка.БюджетнаяОперация,IReturn<БюджетнаяОперацияЗапрос>
	{
	}
	[Маршрут("Документы/БюджетнаяОперация/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/БюджетнаяОперация/ПоСсылке","{Ссылка}")]
	public class БюджетнаяОперацияНайтиПоСсылке: V82.ДокументыСсылка.БюджетнаяОперация,IReturn<БюджетнаяОперацияНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/БюджетнаяОперация/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/БюджетнаяОперация/ПоНомеру","{Номер}")]
	public class БюджетнаяОперацияНайтиПоНомеру: V82.ДокументыСсылка.БюджетнаяОперация,IReturn<БюджетнаяОперацияНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/БюджетнаяОперация/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/БюджетнаяОперация/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/БюджетнаяОперация/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class БюджетнаяОперацияВыбратьПоСсылке: V82.ДокументыСсылка.БюджетнаяОперация,IReturn<БюджетнаяОперацияВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/БюджетнаяОперация/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/БюджетнаяОперация/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/БюджетнаяОперация/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class БюджетнаяОперацияВыбратьПоНомеру: V82.ДокументыСсылка.БюджетнаяОперация,IReturn<БюджетнаяОперацияВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/БюджетнаяОперация/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class БюджетнаяОперацияСтраницаПоСсылке: V82.ДокументыСсылка.БюджетнаяОперация,IReturn<БюджетнаяОперацияСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/БюджетнаяОперация/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class БюджетнаяОперацияСтраницаПоНомеру: V82.ДокументыСсылка.БюджетнаяОперация,IReturn<БюджетнаяОперацияСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class БюджетнаяОперацияОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class БюджетнаяОперацияСервис : Service
	{
		
		public object Get(БюджетнаяОперацияЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(БюджетнаяОперацияНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.БюджетнаяОперация.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new БюджетнаяОперацияОтвет() { Ответ = "БюджетнаяОперация c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(БюджетнаяОперацияНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.БюджетнаяОперация.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new БюджетнаяОперацияОтвет() {Ответ = "БюджетнаяОперация c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(БюджетнаяОперацияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.БюджетнаяОперация.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(БюджетнаяОперацияВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(БюджетнаяОперацияСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(БюджетнаяОперацияСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(БюджетнаяОперацияЗапрос Запрос)
		{
			return new БюджетнаяОперацияОтвет {Ответ = "БюджетнаяОперация, "};
		}

		public object Post(БюджетнаяОперацияЗапрос ЗапросБюджетнаяОперация)
		{
			var Ссылка = (ДокументыСсылка.БюджетнаяОперация)ЗапросБюджетнаяОперация;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}