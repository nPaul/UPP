﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//ReestrSchetov
	[Маршрут("Документы/РеестрСчетов","")]
	public class РеестрСчетовЗапрос: V82.ДокументыСсылка.РеестрСчетов,IReturn<РеестрСчетовЗапрос>
	{
	}
	[Маршрут("Документы/РеестрСчетов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/РеестрСчетов/ПоСсылке","{Ссылка}")]
	public class РеестрСчетовНайтиПоСсылке: V82.ДокументыСсылка.РеестрСчетов,IReturn<РеестрСчетовНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/РеестрСчетов/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/РеестрСчетов/ПоНомеру","{Номер}")]
	public class РеестрСчетовНайтиПоНомеру: V82.ДокументыСсылка.РеестрСчетов,IReturn<РеестрСчетовНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/РеестрСчетов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/РеестрСчетов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/РеестрСчетов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РеестрСчетовВыбратьПоСсылке: V82.ДокументыСсылка.РеестрСчетов,IReturn<РеестрСчетовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/РеестрСчетов/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/РеестрСчетов/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/РеестрСчетов/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class РеестрСчетовВыбратьПоНомеру: V82.ДокументыСсылка.РеестрСчетов,IReturn<РеестрСчетовВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/РеестрСчетов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class РеестрСчетовСтраницаПоСсылке: V82.ДокументыСсылка.РеестрСчетов,IReturn<РеестрСчетовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/РеестрСчетов/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class РеестрСчетовСтраницаПоНомеру: V82.ДокументыСсылка.РеестрСчетов,IReturn<РеестрСчетовСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class РеестрСчетовОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class РеестрСчетовСервис : Service
	{
		
		public object Get(РеестрСчетовЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(РеестрСчетовНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.РеестрСчетов.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new РеестрСчетовОтвет() { Ответ = "РеестрСчетов c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(РеестрСчетовНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.РеестрСчетов.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new РеестрСчетовОтвет() {Ответ = "РеестрСчетов c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(РеестрСчетовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.РеестрСчетов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(РеестрСчетовВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(РеестрСчетовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РеестрСчетовСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(РеестрСчетовЗапрос Запрос)
		{
			return new РеестрСчетовОтвет {Ответ = "РеестрСчетов, "};
		}

		public object Post(РеестрСчетовЗапрос ЗапросРеестрСчетов)
		{
			var Ссылка = (ДокументыСсылка.РеестрСчетов)ЗапросРеестрСчетов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}