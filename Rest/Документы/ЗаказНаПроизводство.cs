﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//ZakazNaProizvodstvo
	[Маршрут("Документы/ЗаказНаПроизводство","")]
	public class ЗаказНаПроизводствоЗапрос: V82.ДокументыСсылка.ЗаказНаПроизводство,IReturn<ЗаказНаПроизводствоЗапрос>
	{
	}
	[Маршрут("Документы/ЗаказНаПроизводство/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ЗаказНаПроизводство/ПоСсылке","{Ссылка}")]
	public class ЗаказНаПроизводствоНайтиПоСсылке: V82.ДокументыСсылка.ЗаказНаПроизводство,IReturn<ЗаказНаПроизводствоНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ЗаказНаПроизводство/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ЗаказНаПроизводство/ПоНомеру","{Номер}")]
	public class ЗаказНаПроизводствоНайтиПоНомеру: V82.ДокументыСсылка.ЗаказНаПроизводство,IReturn<ЗаказНаПроизводствоНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ЗаказНаПроизводство/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ЗаказНаПроизводство/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ЗаказНаПроизводство/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ЗаказНаПроизводствоВыбратьПоСсылке: V82.ДокументыСсылка.ЗаказНаПроизводство,IReturn<ЗаказНаПроизводствоВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ЗаказНаПроизводство/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ЗаказНаПроизводство/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ЗаказНаПроизводство/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ЗаказНаПроизводствоВыбратьПоНомеру: V82.ДокументыСсылка.ЗаказНаПроизводство,IReturn<ЗаказНаПроизводствоВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ЗаказНаПроизводство/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ЗаказНаПроизводствоСтраницаПоСсылке: V82.ДокументыСсылка.ЗаказНаПроизводство,IReturn<ЗаказНаПроизводствоСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ЗаказНаПроизводство/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ЗаказНаПроизводствоСтраницаПоНомеру: V82.ДокументыСсылка.ЗаказНаПроизводство,IReturn<ЗаказНаПроизводствоСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ЗаказНаПроизводствоОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ЗаказНаПроизводствоСервис : Service
	{
		
		public object Get(ЗаказНаПроизводствоЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ЗаказНаПроизводствоНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ЗаказНаПроизводство.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ЗаказНаПроизводствоОтвет() { Ответ = "ЗаказНаПроизводство c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЗаказНаПроизводствоНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ЗаказНаПроизводство.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ЗаказНаПроизводствоОтвет() {Ответ = "ЗаказНаПроизводство c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЗаказНаПроизводствоВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ЗаказНаПроизводство.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ЗаказНаПроизводствоВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ЗаказНаПроизводствоСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЗаказНаПроизводствоСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ЗаказНаПроизводствоЗапрос Запрос)
		{
			return new ЗаказНаПроизводствоОтвет {Ответ = "ЗаказНаПроизводство, "};
		}

		public object Post(ЗаказНаПроизводствоЗапрос ЗапросЗаказНаПроизводство)
		{
			var Ссылка = (ДокументыСсылка.ЗаказНаПроизводство)ЗапросЗаказНаПроизводство;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}