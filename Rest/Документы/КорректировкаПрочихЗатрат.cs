﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//KorrektirovkaProchikhZatrat
	[Маршрут("Документы/КорректировкаПрочихЗатрат","")]
	public class КорректировкаПрочихЗатратЗапрос: V82.ДокументыСсылка.КорректировкаПрочихЗатрат,IReturn<КорректировкаПрочихЗатратЗапрос>
	{
	}
	[Маршрут("Документы/КорректировкаПрочихЗатрат/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/КорректировкаПрочихЗатрат/ПоСсылке","{Ссылка}")]
	public class КорректировкаПрочихЗатратНайтиПоСсылке: V82.ДокументыСсылка.КорректировкаПрочихЗатрат,IReturn<КорректировкаПрочихЗатратНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/КорректировкаПрочихЗатрат/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/КорректировкаПрочихЗатрат/ПоНомеру","{Номер}")]
	public class КорректировкаПрочихЗатратНайтиПоНомеру: V82.ДокументыСсылка.КорректировкаПрочихЗатрат,IReturn<КорректировкаПрочихЗатратНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/КорректировкаПрочихЗатрат/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/КорректировкаПрочихЗатрат/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/КорректировкаПрочихЗатрат/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КорректировкаПрочихЗатратВыбратьПоСсылке: V82.ДокументыСсылка.КорректировкаПрочихЗатрат,IReturn<КорректировкаПрочихЗатратВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/КорректировкаПрочихЗатрат/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/КорректировкаПрочихЗатрат/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/КорректировкаПрочихЗатрат/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class КорректировкаПрочихЗатратВыбратьПоНомеру: V82.ДокументыСсылка.КорректировкаПрочихЗатрат,IReturn<КорректировкаПрочихЗатратВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/КорректировкаПрочихЗатрат/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КорректировкаПрочихЗатратСтраницаПоСсылке: V82.ДокументыСсылка.КорректировкаПрочихЗатрат,IReturn<КорректировкаПрочихЗатратСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/КорректировкаПрочихЗатрат/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class КорректировкаПрочихЗатратСтраницаПоНомеру: V82.ДокументыСсылка.КорректировкаПрочихЗатрат,IReturn<КорректировкаПрочихЗатратСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КорректировкаПрочихЗатратОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КорректировкаПрочихЗатратСервис : Service
	{
		
		public object Get(КорректировкаПрочихЗатратЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КорректировкаПрочихЗатратНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.КорректировкаПрочихЗатрат.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new КорректировкаПрочихЗатратОтвет() { Ответ = "КорректировкаПрочихЗатрат c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КорректировкаПрочихЗатратНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.КорректировкаПрочихЗатрат.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new КорректировкаПрочихЗатратОтвет() {Ответ = "КорректировкаПрочихЗатрат c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КорректировкаПрочихЗатратВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.КорректировкаПрочихЗатрат.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(КорректировкаПрочихЗатратВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(КорректировкаПрочихЗатратСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КорректировкаПрочихЗатратСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(КорректировкаПрочихЗатратЗапрос Запрос)
		{
			return new КорректировкаПрочихЗатратОтвет {Ответ = "КорректировкаПрочихЗатрат, "};
		}

		public object Post(КорректировкаПрочихЗатратЗапрос ЗапросКорректировкаПрочихЗатрат)
		{
			var Ссылка = (ДокументыСсылка.КорректировкаПрочихЗатрат)ЗапросКорректировкаПрочихЗатрат;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}