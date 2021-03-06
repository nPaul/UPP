﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PostuplenieTovarovUslugVNTT
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ","")]
	public class ПоступлениеТоваровУслугВНТТЗапрос: V82.ДокументыСсылка.ПоступлениеТоваровУслугВНТТ,IReturn<ПоступлениеТоваровУслугВНТТЗапрос>
	{
	}
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/ПоСсылке","{Ссылка}")]
	public class ПоступлениеТоваровУслугВНТТНайтиПоСсылке: V82.ДокументыСсылка.ПоступлениеТоваровУслугВНТТ,IReturn<ПоступлениеТоваровУслугВНТТНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/ПоНомеру","{Номер}")]
	public class ПоступлениеТоваровУслугВНТТНайтиПоНомеру: V82.ДокументыСсылка.ПоступлениеТоваровУслугВНТТ,IReturn<ПоступлениеТоваровУслугВНТТНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПоступлениеТоваровУслугВНТТВыбратьПоСсылке: V82.ДокументыСсылка.ПоступлениеТоваровУслугВНТТ,IReturn<ПоступлениеТоваровУслугВНТТВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПоступлениеТоваровУслугВНТТВыбратьПоНомеру: V82.ДокументыСсылка.ПоступлениеТоваровУслугВНТТ,IReturn<ПоступлениеТоваровУслугВНТТВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПоступлениеТоваровУслугВНТТСтраницаПоСсылке: V82.ДокументыСсылка.ПоступлениеТоваровУслугВНТТ,IReturn<ПоступлениеТоваровУслугВНТТСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПоступлениеТоваровУслугВНТТ/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПоступлениеТоваровУслугВНТТСтраницаПоНомеру: V82.ДокументыСсылка.ПоступлениеТоваровУслугВНТТ,IReturn<ПоступлениеТоваровУслугВНТТСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПоступлениеТоваровУслугВНТТОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПоступлениеТоваровУслугВНТТСервис : Service
	{
		
		public object Get(ПоступлениеТоваровУслугВНТТЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПоступлениеТоваровУслугВНТТНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПоступлениеТоваровУслугВНТТ.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПоступлениеТоваровУслугВНТТОтвет() { Ответ = "ПоступлениеТоваровУслугВНТТ c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПоступлениеТоваровУслугВНТТНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПоступлениеТоваровУслугВНТТ.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПоступлениеТоваровУслугВНТТОтвет() {Ответ = "ПоступлениеТоваровУслугВНТТ c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПоступлениеТоваровУслугВНТТВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПоступлениеТоваровУслугВНТТ.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПоступлениеТоваровУслугВНТТВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПоступлениеТоваровУслугВНТТСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПоступлениеТоваровУслугВНТТСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПоступлениеТоваровУслугВНТТЗапрос Запрос)
		{
			return new ПоступлениеТоваровУслугВНТТОтвет {Ответ = "ПоступлениеТоваровУслугВНТТ, "};
		}

		public object Post(ПоступлениеТоваровУслугВНТТЗапрос ЗапросПоступлениеТоваровУслугВНТТ)
		{
			var Ссылка = (ДокументыСсылка.ПоступлениеТоваровУслугВНТТ)ЗапросПоступлениеТоваровУслугВНТТ;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}