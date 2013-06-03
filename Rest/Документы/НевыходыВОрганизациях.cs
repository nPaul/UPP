﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//NevykhodyVOrganizaciyakh
	[Маршрут("Документы/НевыходыВОрганизациях","")]
	public class НевыходыВОрганизацияхЗапрос: V82.ДокументыСсылка.НевыходыВОрганизациях,IReturn<НевыходыВОрганизацияхЗапрос>
	{
	}
	[Маршрут("Документы/НевыходыВОрганизациях/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/НевыходыВОрганизациях/ПоСсылке","{Ссылка}")]
	public class НевыходыВОрганизацияхНайтиПоСсылке: V82.ДокументыСсылка.НевыходыВОрганизациях,IReturn<НевыходыВОрганизацияхНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/НевыходыВОрганизациях/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/НевыходыВОрганизациях/ПоНомеру","{Номер}")]
	public class НевыходыВОрганизацияхНайтиПоНомеру: V82.ДокументыСсылка.НевыходыВОрганизациях,IReturn<НевыходыВОрганизацияхНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/НевыходыВОрганизациях/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/НевыходыВОрганизациях/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/НевыходыВОрганизациях/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НевыходыВОрганизацияхВыбратьПоСсылке: V82.ДокументыСсылка.НевыходыВОрганизациях,IReturn<НевыходыВОрганизацияхВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/НевыходыВОрганизациях/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/НевыходыВОрганизациях/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/НевыходыВОрганизациях/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class НевыходыВОрганизацияхВыбратьПоНомеру: V82.ДокументыСсылка.НевыходыВОрганизациях,IReturn<НевыходыВОрганизацияхВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/НевыходыВОрганизациях/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НевыходыВОрганизацияхСтраницаПоСсылке: V82.ДокументыСсылка.НевыходыВОрганизациях,IReturn<НевыходыВОрганизацияхСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/НевыходыВОрганизациях/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class НевыходыВОрганизацияхСтраницаПоНомеру: V82.ДокументыСсылка.НевыходыВОрганизациях,IReturn<НевыходыВОрганизацияхСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НевыходыВОрганизацияхОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НевыходыВОрганизацияхСервис : Service
	{
		
		public object Get(НевыходыВОрганизацияхЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НевыходыВОрганизацияхНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.НевыходыВОрганизациях.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new НевыходыВОрганизацияхОтвет() { Ответ = "НевыходыВОрганизациях c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НевыходыВОрганизацияхНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.НевыходыВОрганизациях.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new НевыходыВОрганизацияхОтвет() {Ответ = "НевыходыВОрганизациях c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НевыходыВОрганизацияхВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.НевыходыВОрганизациях.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(НевыходыВОрганизацияхВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(НевыходыВОрганизацияхСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НевыходыВОрганизацияхСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(НевыходыВОрганизацияхЗапрос Запрос)
		{
			return new НевыходыВОрганизацияхОтвет {Ответ = "НевыходыВОрганизациях, "};
		}

		public object Post(НевыходыВОрганизацияхЗапрос ЗапросНевыходыВОрганизациях)
		{
			var Ссылка = (ДокументыСсылка.НевыходыВОрганизациях)ЗапросНевыходыВОрганизациях;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}