﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//InventarizaciyaNZP
	[Маршрут("Документы/ИнвентаризацияНЗП","")]
	public class ИнвентаризацияНЗПЗапрос: V82.ДокументыСсылка.ИнвентаризацияНЗП,IReturn<ИнвентаризацияНЗПЗапрос>
	{
	}
	[Маршрут("Документы/ИнвентаризацияНЗП/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ИнвентаризацияНЗП/ПоСсылке","{Ссылка}")]
	public class ИнвентаризацияНЗПНайтиПоСсылке: V82.ДокументыСсылка.ИнвентаризацияНЗП,IReturn<ИнвентаризацияНЗПНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ИнвентаризацияНЗП/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ИнвентаризацияНЗП/ПоНомеру","{Номер}")]
	public class ИнвентаризацияНЗПНайтиПоНомеру: V82.ДокументыСсылка.ИнвентаризацияНЗП,IReturn<ИнвентаризацияНЗПНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ИнвентаризацияНЗП/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ИнвентаризацияНЗП/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИнвентаризацияНЗП/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ИнвентаризацияНЗПВыбратьПоСсылке: V82.ДокументыСсылка.ИнвентаризацияНЗП,IReturn<ИнвентаризацияНЗПВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ИнвентаризацияНЗП/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ИнвентаризацияНЗП/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИнвентаризацияНЗП/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ИнвентаризацияНЗПВыбратьПоНомеру: V82.ДокументыСсылка.ИнвентаризацияНЗП,IReturn<ИнвентаризацияНЗПВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ИнвентаризацияНЗП/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ИнвентаризацияНЗПСтраницаПоСсылке: V82.ДокументыСсылка.ИнвентаризацияНЗП,IReturn<ИнвентаризацияНЗПСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ИнвентаризацияНЗП/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ИнвентаризацияНЗПСтраницаПоНомеру: V82.ДокументыСсылка.ИнвентаризацияНЗП,IReturn<ИнвентаризацияНЗПСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ИнвентаризацияНЗПОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ИнвентаризацияНЗПСервис : Service
	{
		
		public object Get(ИнвентаризацияНЗПЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ИнвентаризацияНЗПНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ИнвентаризацияНЗП.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ИнвентаризацияНЗПОтвет() { Ответ = "ИнвентаризацияНЗП c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИнвентаризацияНЗПНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ИнвентаризацияНЗП.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ИнвентаризацияНЗПОтвет() {Ответ = "ИнвентаризацияНЗП c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИнвентаризацияНЗПВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ИнвентаризацияНЗП.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ИнвентаризацияНЗПВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ИнвентаризацияНЗПСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИнвентаризацияНЗПСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ИнвентаризацияНЗПЗапрос Запрос)
		{
			return new ИнвентаризацияНЗПОтвет {Ответ = "ИнвентаризацияНЗП, "};
		}

		public object Post(ИнвентаризацияНЗПЗапрос ЗапросИнвентаризацияНЗП)
		{
			var Ссылка = (ДокументыСсылка.ИнвентаризацияНЗП)ЗапросИнвентаризацияНЗП;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}