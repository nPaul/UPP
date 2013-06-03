﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//SpravkaPoNDFLVNalogovyjjOrgan
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган","")]
	public class СправкаПоНДФЛВНалоговыйОрганЗапрос: V82.ДокументыСсылка.СправкаПоНДФЛВНалоговыйОрган,IReturn<СправкаПоНДФЛВНалоговыйОрганЗапрос>
	{
	}
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/ПоСсылке","{Ссылка}")]
	public class СправкаПоНДФЛВНалоговыйОрганНайтиПоСсылке: V82.ДокументыСсылка.СправкаПоНДФЛВНалоговыйОрган,IReturn<СправкаПоНДФЛВНалоговыйОрганНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/ПоНомеру","{Номер}")]
	public class СправкаПоНДФЛВНалоговыйОрганНайтиПоНомеру: V82.ДокументыСсылка.СправкаПоНДФЛВНалоговыйОрган,IReturn<СправкаПоНДФЛВНалоговыйОрганНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СправкаПоНДФЛВНалоговыйОрганВыбратьПоСсылке: V82.ДокументыСсылка.СправкаПоНДФЛВНалоговыйОрган,IReturn<СправкаПоНДФЛВНалоговыйОрганВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class СправкаПоНДФЛВНалоговыйОрганВыбратьПоНомеру: V82.ДокументыСсылка.СправкаПоНДФЛВНалоговыйОрган,IReturn<СправкаПоНДФЛВНалоговыйОрганВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СправкаПоНДФЛВНалоговыйОрганСтраницаПоСсылке: V82.ДокументыСсылка.СправкаПоНДФЛВНалоговыйОрган,IReturn<СправкаПоНДФЛВНалоговыйОрганСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/СправкаПоНДФЛВНалоговыйОрган/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class СправкаПоНДФЛВНалоговыйОрганСтраницаПоНомеру: V82.ДокументыСсылка.СправкаПоНДФЛВНалоговыйОрган,IReturn<СправкаПоНДФЛВНалоговыйОрганСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СправкаПоНДФЛВНалоговыйОрганОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СправкаПоНДФЛВНалоговыйОрганСервис : Service
	{
		
		public object Get(СправкаПоНДФЛВНалоговыйОрганЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СправкаПоНДФЛВНалоговыйОрганНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.СправкаПоНДФЛВНалоговыйОрган.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СправкаПоНДФЛВНалоговыйОрганОтвет() { Ответ = "СправкаПоНДФЛВНалоговыйОрган c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СправкаПоНДФЛВНалоговыйОрганНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.СправкаПоНДФЛВНалоговыйОрган.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new СправкаПоНДФЛВНалоговыйОрганОтвет() {Ответ = "СправкаПоНДФЛВНалоговыйОрган c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СправкаПоНДФЛВНалоговыйОрганВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.СправкаПоНДФЛВНалоговыйОрган.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СправкаПоНДФЛВНалоговыйОрганВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(СправкаПоНДФЛВНалоговыйОрганСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СправкаПоНДФЛВНалоговыйОрганСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(СправкаПоНДФЛВНалоговыйОрганЗапрос Запрос)
		{
			return new СправкаПоНДФЛВНалоговыйОрганОтвет {Ответ = "СправкаПоНДФЛВНалоговыйОрган, "};
		}

		public object Post(СправкаПоНДФЛВНалоговыйОрганЗапрос ЗапросСправкаПоНДФЛВНалоговыйОрган)
		{
			var Ссылка = (ДокументыСсылка.СправкаПоНДФЛВНалоговыйОрган)ЗапросСправкаПоНДФЛВНалоговыйОрган;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}