﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//SvedeniyaODokhodakhFizlic
	[Маршрут("Документы/СведенияОДоходахФизлиц","")]
	public class СведенияОДоходахФизлицЗапрос: V82.ДокументыСсылка.СведенияОДоходахФизлиц,IReturn<СведенияОДоходахФизлицЗапрос>
	{
	}
	[Маршрут("Документы/СведенияОДоходахФизлиц/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/СведенияОДоходахФизлиц/ПоСсылке","{Ссылка}")]
	public class СведенияОДоходахФизлицНайтиПоСсылке: V82.ДокументыСсылка.СведенияОДоходахФизлиц,IReturn<СведенияОДоходахФизлицНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/СведенияОДоходахФизлиц/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/СведенияОДоходахФизлиц/ПоНомеру","{Номер}")]
	public class СведенияОДоходахФизлицНайтиПоНомеру: V82.ДокументыСсылка.СведенияОДоходахФизлиц,IReturn<СведенияОДоходахФизлицНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/СведенияОДоходахФизлиц/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/СведенияОДоходахФизлиц/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СведенияОДоходахФизлиц/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СведенияОДоходахФизлицВыбратьПоСсылке: V82.ДокументыСсылка.СведенияОДоходахФизлиц,IReturn<СведенияОДоходахФизлицВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/СведенияОДоходахФизлиц/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/СведенияОДоходахФизлиц/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СведенияОДоходахФизлиц/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class СведенияОДоходахФизлицВыбратьПоНомеру: V82.ДокументыСсылка.СведенияОДоходахФизлиц,IReturn<СведенияОДоходахФизлицВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/СведенияОДоходахФизлиц/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СведенияОДоходахФизлицСтраницаПоСсылке: V82.ДокументыСсылка.СведенияОДоходахФизлиц,IReturn<СведенияОДоходахФизлицСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/СведенияОДоходахФизлиц/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class СведенияОДоходахФизлицСтраницаПоНомеру: V82.ДокументыСсылка.СведенияОДоходахФизлиц,IReturn<СведенияОДоходахФизлицСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СведенияОДоходахФизлицОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СведенияОДоходахФизлицСервис : Service
	{
		
		public object Get(СведенияОДоходахФизлицЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СведенияОДоходахФизлицНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.СведенияОДоходахФизлиц.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СведенияОДоходахФизлицОтвет() { Ответ = "СведенияОДоходахФизлиц c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СведенияОДоходахФизлицНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.СведенияОДоходахФизлиц.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new СведенияОДоходахФизлицОтвет() {Ответ = "СведенияОДоходахФизлиц c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СведенияОДоходахФизлицВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.СведенияОДоходахФизлиц.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СведенияОДоходахФизлицВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(СведенияОДоходахФизлицСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СведенияОДоходахФизлицСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(СведенияОДоходахФизлицЗапрос Запрос)
		{
			return new СведенияОДоходахФизлицОтвет {Ответ = "СведенияОДоходахФизлиц, "};
		}

		public object Post(СведенияОДоходахФизлицЗапрос ЗапросСведенияОДоходахФизлиц)
		{
			var Ссылка = (ДокументыСсылка.СведенияОДоходахФизлиц)ЗапросСведенияОДоходахФизлиц;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}