﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//OtchetMasteraSmeny
	[Маршрут("Документы/ОтчетМастераСмены","")]
	public class ОтчетМастераСменыЗапрос: V82.ДокументыСсылка.ОтчетМастераСмены,IReturn<ОтчетМастераСменыЗапрос>
	{
	}
	[Маршрут("Документы/ОтчетМастераСмены/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ОтчетМастераСмены/ПоСсылке","{Ссылка}")]
	public class ОтчетМастераСменыНайтиПоСсылке: V82.ДокументыСсылка.ОтчетМастераСмены,IReturn<ОтчетМастераСменыНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ОтчетМастераСмены/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ОтчетМастераСмены/ПоНомеру","{Номер}")]
	public class ОтчетМастераСменыНайтиПоНомеру: V82.ДокументыСсылка.ОтчетМастераСмены,IReturn<ОтчетМастераСменыНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ОтчетМастераСмены/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ОтчетМастераСмены/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ОтчетМастераСмены/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОтчетМастераСменыВыбратьПоСсылке: V82.ДокументыСсылка.ОтчетМастераСмены,IReturn<ОтчетМастераСменыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ОтчетМастераСмены/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ОтчетМастераСмены/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ОтчетМастераСмены/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ОтчетМастераСменыВыбратьПоНомеру: V82.ДокументыСсылка.ОтчетМастераСмены,IReturn<ОтчетМастераСменыВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ОтчетМастераСмены/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОтчетМастераСменыСтраницаПоСсылке: V82.ДокументыСсылка.ОтчетМастераСмены,IReturn<ОтчетМастераСменыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ОтчетМастераСмены/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ОтчетМастераСменыСтраницаПоНомеру: V82.ДокументыСсылка.ОтчетМастераСмены,IReturn<ОтчетМастераСменыСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОтчетМастераСменыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОтчетМастераСменыСервис : Service
	{
		
		public object Get(ОтчетМастераСменыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОтчетМастераСменыНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ОтчетМастераСмены.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ОтчетМастераСменыОтвет() { Ответ = "ОтчетМастераСмены c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОтчетМастераСменыНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ОтчетМастераСмены.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ОтчетМастераСменыОтвет() {Ответ = "ОтчетМастераСмены c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОтчетМастераСменыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ОтчетМастераСмены.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОтчетМастераСменыВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ОтчетМастераСменыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОтчетМастераСменыСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ОтчетМастераСменыЗапрос Запрос)
		{
			return new ОтчетМастераСменыОтвет {Ответ = "ОтчетМастераСмены, "};
		}

		public object Post(ОтчетМастераСменыЗапрос ЗапросОтчетМастераСмены)
		{
			var Ссылка = (ДокументыСсылка.ОтчетМастераСмены)ЗапросОтчетМастераСмены;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}