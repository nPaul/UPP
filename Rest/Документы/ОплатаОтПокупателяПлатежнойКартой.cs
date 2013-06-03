﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//OplataOtPokupatelyaPlatezhnojjKartojj
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой","")]
	public class ОплатаОтПокупателяПлатежнойКартойЗапрос: V82.ДокументыСсылка.ОплатаОтПокупателяПлатежнойКартой,IReturn<ОплатаОтПокупателяПлатежнойКартойЗапрос>
	{
	}
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/ПоСсылке","{Ссылка}")]
	public class ОплатаОтПокупателяПлатежнойКартойНайтиПоСсылке: V82.ДокументыСсылка.ОплатаОтПокупателяПлатежнойКартой,IReturn<ОплатаОтПокупателяПлатежнойКартойНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/ПоНомеру","{Номер}")]
	public class ОплатаОтПокупателяПлатежнойКартойНайтиПоНомеру: V82.ДокументыСсылка.ОплатаОтПокупателяПлатежнойКартой,IReturn<ОплатаОтПокупателяПлатежнойКартойНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОплатаОтПокупателяПлатежнойКартойВыбратьПоСсылке: V82.ДокументыСсылка.ОплатаОтПокупателяПлатежнойКартой,IReturn<ОплатаОтПокупателяПлатежнойКартойВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ОплатаОтПокупателяПлатежнойКартойВыбратьПоНомеру: V82.ДокументыСсылка.ОплатаОтПокупателяПлатежнойКартой,IReturn<ОплатаОтПокупателяПлатежнойКартойВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОплатаОтПокупателяПлатежнойКартойСтраницаПоСсылке: V82.ДокументыСсылка.ОплатаОтПокупателяПлатежнойКартой,IReturn<ОплатаОтПокупателяПлатежнойКартойСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ОплатаОтПокупателяПлатежнойКартой/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ОплатаОтПокупателяПлатежнойКартойСтраницаПоНомеру: V82.ДокументыСсылка.ОплатаОтПокупателяПлатежнойКартой,IReturn<ОплатаОтПокупателяПлатежнойКартойСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОплатаОтПокупателяПлатежнойКартойОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОплатаОтПокупателяПлатежнойКартойСервис : Service
	{
		
		public object Get(ОплатаОтПокупателяПлатежнойКартойЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОплатаОтПокупателяПлатежнойКартойНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ОплатаОтПокупателяПлатежнойКартой.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ОплатаОтПокупателяПлатежнойКартойОтвет() { Ответ = "ОплатаОтПокупателяПлатежнойКартой c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОплатаОтПокупателяПлатежнойКартойНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ОплатаОтПокупателяПлатежнойКартой.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ОплатаОтПокупателяПлатежнойКартойОтвет() {Ответ = "ОплатаОтПокупателяПлатежнойКартой c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОплатаОтПокупателяПлатежнойКартойВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ОплатаОтПокупателяПлатежнойКартой.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОплатаОтПокупателяПлатежнойКартойВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ОплатаОтПокупателяПлатежнойКартойСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОплатаОтПокупателяПлатежнойКартойСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ОплатаОтПокупателяПлатежнойКартойЗапрос Запрос)
		{
			return new ОплатаОтПокупателяПлатежнойКартойОтвет {Ответ = "ОплатаОтПокупателяПлатежнойКартой, "};
		}

		public object Post(ОплатаОтПокупателяПлатежнойКартойЗапрос ЗапросОплатаОтПокупателяПлатежнойКартой)
		{
			var Ссылка = (ДокументыСсылка.ОплатаОтПокупателяПлатежнойКартой)ЗапросОплатаОтПокупателяПлатежнойКартой;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}