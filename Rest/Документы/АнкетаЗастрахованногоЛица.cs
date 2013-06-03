﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//AnketaZastrakhovannogoLica
	[Маршрут("Документы/АнкетаЗастрахованногоЛица","")]
	public class АнкетаЗастрахованногоЛицаЗапрос: V82.ДокументыСсылка.АнкетаЗастрахованногоЛица,IReturn<АнкетаЗастрахованногоЛицаЗапрос>
	{
	}
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/ПоСсылке","{Ссылка}")]
	public class АнкетаЗастрахованногоЛицаНайтиПоСсылке: V82.ДокументыСсылка.АнкетаЗастрахованногоЛица,IReturn<АнкетаЗастрахованногоЛицаНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/ПоНомеру","{Номер}")]
	public class АнкетаЗастрахованногоЛицаНайтиПоНомеру: V82.ДокументыСсылка.АнкетаЗастрахованногоЛица,IReturn<АнкетаЗастрахованногоЛицаНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class АнкетаЗастрахованногоЛицаВыбратьПоСсылке: V82.ДокументыСсылка.АнкетаЗастрахованногоЛица,IReturn<АнкетаЗастрахованногоЛицаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class АнкетаЗастрахованногоЛицаВыбратьПоНомеру: V82.ДокументыСсылка.АнкетаЗастрахованногоЛица,IReturn<АнкетаЗастрахованногоЛицаВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class АнкетаЗастрахованногоЛицаСтраницаПоСсылке: V82.ДокументыСсылка.АнкетаЗастрахованногоЛица,IReturn<АнкетаЗастрахованногоЛицаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/АнкетаЗастрахованногоЛица/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class АнкетаЗастрахованногоЛицаСтраницаПоНомеру: V82.ДокументыСсылка.АнкетаЗастрахованногоЛица,IReturn<АнкетаЗастрахованногоЛицаСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class АнкетаЗастрахованногоЛицаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class АнкетаЗастрахованногоЛицаСервис : Service
	{
		
		public object Get(АнкетаЗастрахованногоЛицаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(АнкетаЗастрахованногоЛицаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.АнкетаЗастрахованногоЛица.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new АнкетаЗастрахованногоЛицаОтвет() { Ответ = "АнкетаЗастрахованногоЛица c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(АнкетаЗастрахованногоЛицаНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.АнкетаЗастрахованногоЛица.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new АнкетаЗастрахованногоЛицаОтвет() {Ответ = "АнкетаЗастрахованногоЛица c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(АнкетаЗастрахованногоЛицаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.АнкетаЗастрахованногоЛица.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(АнкетаЗастрахованногоЛицаВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(АнкетаЗастрахованногоЛицаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(АнкетаЗастрахованногоЛицаСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(АнкетаЗастрахованногоЛицаЗапрос Запрос)
		{
			return new АнкетаЗастрахованногоЛицаОтвет {Ответ = "АнкетаЗастрахованногоЛица, "};
		}

		public object Post(АнкетаЗастрахованногоЛицаЗапрос ЗапросАнкетаЗастрахованногоЛица)
		{
			var Ссылка = (ДокументыСсылка.АнкетаЗастрахованногоЛица)ЗапросАнкетаЗастрахованногоЛица;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}