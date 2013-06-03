﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PlanProizvodstva
	[Маршрут("Документы/ПланПроизводства","")]
	public class ПланПроизводстваЗапрос: V82.ДокументыСсылка.ПланПроизводства,IReturn<ПланПроизводстваЗапрос>
	{
	}
	[Маршрут("Документы/ПланПроизводства/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПланПроизводства/ПоСсылке","{Ссылка}")]
	public class ПланПроизводстваНайтиПоСсылке: V82.ДокументыСсылка.ПланПроизводства,IReturn<ПланПроизводстваНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПланПроизводства/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПланПроизводства/ПоНомеру","{Номер}")]
	public class ПланПроизводстваНайтиПоНомеру: V82.ДокументыСсылка.ПланПроизводства,IReturn<ПланПроизводстваНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПланПроизводства/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПланПроизводства/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПланПроизводства/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПланПроизводстваВыбратьПоСсылке: V82.ДокументыСсылка.ПланПроизводства,IReturn<ПланПроизводстваВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПланПроизводства/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПланПроизводства/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПланПроизводства/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПланПроизводстваВыбратьПоНомеру: V82.ДокументыСсылка.ПланПроизводства,IReturn<ПланПроизводстваВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПланПроизводства/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПланПроизводстваСтраницаПоСсылке: V82.ДокументыСсылка.ПланПроизводства,IReturn<ПланПроизводстваСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПланПроизводства/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПланПроизводстваСтраницаПоНомеру: V82.ДокументыСсылка.ПланПроизводства,IReturn<ПланПроизводстваСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПланПроизводстваОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПланПроизводстваСервис : Service
	{
		
		public object Get(ПланПроизводстваЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПланПроизводстваНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПланПроизводства.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПланПроизводстваОтвет() { Ответ = "ПланПроизводства c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПланПроизводстваНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПланПроизводства.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПланПроизводстваОтвет() {Ответ = "ПланПроизводства c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПланПроизводстваВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПланПроизводства.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПланПроизводстваВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПланПроизводстваСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПланПроизводстваСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПланПроизводстваЗапрос Запрос)
		{
			return new ПланПроизводстваОтвет {Ответ = "ПланПроизводства, "};
		}

		public object Post(ПланПроизводстваЗапрос ЗапросПланПроизводства)
		{
			var Ссылка = (ДокументыСсылка.ПланПроизводства)ЗапросПланПроизводства;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}