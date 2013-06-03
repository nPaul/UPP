﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//VvodSvedenijjOPlanovykhNachisleniyakhRabotnikovOrganizacijj
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций","")]
	public class ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийЗапрос: V82.ДокументыСсылка.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций,IReturn<ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийЗапрос>
	{
	}
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/ПоСсылке","{Ссылка}")]
	public class ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийНайтиПоСсылке: V82.ДокументыСсылка.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций,IReturn<ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/ПоНомеру","{Номер}")]
	public class ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийНайтиПоНомеру: V82.ДокументыСсылка.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций,IReturn<ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийВыбратьПоСсылке: V82.ДокументыСсылка.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций,IReturn<ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийВыбратьПоНомеру: V82.ДокументыСсылка.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций,IReturn<ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийСтраницаПоСсылке: V82.ДокументыСсылка.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций,IReturn<ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийСтраницаПоНомеру: V82.ДокументыСсылка.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций,IReturn<ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийСервис : Service
	{
		
		public object Get(ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийОтвет() { Ответ = "ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийОтвет() {Ответ = "ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийЗапрос Запрос)
		{
			return new ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийОтвет {Ответ = "ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций, "};
		}

		public object Post(ВводСведенийОПлановыхНачисленияхРаботниковОрганизацийЗапрос ЗапросВводСведенийОПлановыхНачисленияхРаботниковОрганизаций)
		{
			var Ссылка = (ДокументыСсылка.ВводСведенийОПлановыхНачисленияхРаботниковОрганизаций)ЗапросВводСведенийОПлановыхНачисленияхРаботниковОрганизаций;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}