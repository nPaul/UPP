﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//IzmenenieKadrovogoPlana
	[Маршрут("Документы/ИзменениеКадровогоПлана","")]
	public class ИзменениеКадровогоПланаЗапрос: V82.ДокументыСсылка.ИзменениеКадровогоПлана,IReturn<ИзменениеКадровогоПланаЗапрос>
	{
	}
	[Маршрут("Документы/ИзменениеКадровогоПлана/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ИзменениеКадровогоПлана/ПоСсылке","{Ссылка}")]
	public class ИзменениеКадровогоПланаНайтиПоСсылке: V82.ДокументыСсылка.ИзменениеКадровогоПлана,IReturn<ИзменениеКадровогоПланаНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ИзменениеКадровогоПлана/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ИзменениеКадровогоПлана/ПоНомеру","{Номер}")]
	public class ИзменениеКадровогоПланаНайтиПоНомеру: V82.ДокументыСсылка.ИзменениеКадровогоПлана,IReturn<ИзменениеКадровогоПланаНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ИзменениеКадровогоПлана/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ИзменениеКадровогоПлана/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИзменениеКадровогоПлана/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ИзменениеКадровогоПланаВыбратьПоСсылке: V82.ДокументыСсылка.ИзменениеКадровогоПлана,IReturn<ИзменениеКадровогоПланаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ИзменениеКадровогоПлана/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ИзменениеКадровогоПлана/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИзменениеКадровогоПлана/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ИзменениеКадровогоПланаВыбратьПоНомеру: V82.ДокументыСсылка.ИзменениеКадровогоПлана,IReturn<ИзменениеКадровогоПланаВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ИзменениеКадровогоПлана/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ИзменениеКадровогоПланаСтраницаПоСсылке: V82.ДокументыСсылка.ИзменениеКадровогоПлана,IReturn<ИзменениеКадровогоПланаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ИзменениеКадровогоПлана/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ИзменениеКадровогоПланаСтраницаПоНомеру: V82.ДокументыСсылка.ИзменениеКадровогоПлана,IReturn<ИзменениеКадровогоПланаСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ИзменениеКадровогоПланаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ИзменениеКадровогоПланаСервис : Service
	{
		
		public object Get(ИзменениеКадровогоПланаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ИзменениеКадровогоПланаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ИзменениеКадровогоПлана.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ИзменениеКадровогоПланаОтвет() { Ответ = "ИзменениеКадровогоПлана c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИзменениеКадровогоПланаНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ИзменениеКадровогоПлана.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ИзменениеКадровогоПланаОтвет() {Ответ = "ИзменениеКадровогоПлана c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИзменениеКадровогоПланаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ИзменениеКадровогоПлана.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ИзменениеКадровогоПланаВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ИзменениеКадровогоПланаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИзменениеКадровогоПланаСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ИзменениеКадровогоПланаЗапрос Запрос)
		{
			return new ИзменениеКадровогоПланаОтвет {Ответ = "ИзменениеКадровогоПлана, "};
		}

		public object Post(ИзменениеКадровогоПланаЗапрос ЗапросИзменениеКадровогоПлана)
		{
			var Ссылка = (ДокументыСсылка.ИзменениеКадровогоПлана)ЗапросИзменениеКадровогоПлана;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}