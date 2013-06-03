﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//ZakazPostavshhiku
	[Маршрут("Документы/ЗаказПоставщику","")]
	public class ЗаказПоставщикуЗапрос: V82.ДокументыСсылка.ЗаказПоставщику,IReturn<ЗаказПоставщикуЗапрос>
	{
	}
	[Маршрут("Документы/ЗаказПоставщику/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ЗаказПоставщику/ПоСсылке","{Ссылка}")]
	public class ЗаказПоставщикуНайтиПоСсылке: V82.ДокументыСсылка.ЗаказПоставщику,IReturn<ЗаказПоставщикуНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ЗаказПоставщику/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ЗаказПоставщику/ПоНомеру","{Номер}")]
	public class ЗаказПоставщикуНайтиПоНомеру: V82.ДокументыСсылка.ЗаказПоставщику,IReturn<ЗаказПоставщикуНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ЗаказПоставщику/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ЗаказПоставщику/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ЗаказПоставщику/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ЗаказПоставщикуВыбратьПоСсылке: V82.ДокументыСсылка.ЗаказПоставщику,IReturn<ЗаказПоставщикуВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ЗаказПоставщику/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ЗаказПоставщику/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ЗаказПоставщику/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ЗаказПоставщикуВыбратьПоНомеру: V82.ДокументыСсылка.ЗаказПоставщику,IReturn<ЗаказПоставщикуВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ЗаказПоставщику/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ЗаказПоставщикуСтраницаПоСсылке: V82.ДокументыСсылка.ЗаказПоставщику,IReturn<ЗаказПоставщикуСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ЗаказПоставщику/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ЗаказПоставщикуСтраницаПоНомеру: V82.ДокументыСсылка.ЗаказПоставщику,IReturn<ЗаказПоставщикуСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ЗаказПоставщикуОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ЗаказПоставщикуСервис : Service
	{
		
		public object Get(ЗаказПоставщикуЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ЗаказПоставщикуНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ЗаказПоставщику.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ЗаказПоставщикуОтвет() { Ответ = "ЗаказПоставщику c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЗаказПоставщикуНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ЗаказПоставщику.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ЗаказПоставщикуОтвет() {Ответ = "ЗаказПоставщику c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЗаказПоставщикуВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ЗаказПоставщику.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ЗаказПоставщикуВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ЗаказПоставщикуСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЗаказПоставщикуСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ЗаказПоставщикуЗапрос Запрос)
		{
			return new ЗаказПоставщикуОтвет {Ответ = "ЗаказПоставщику, "};
		}

		public object Post(ЗаказПоставщикуЗапрос ЗапросЗаказПоставщику)
		{
			var Ссылка = (ДокументыСсылка.ЗаказПоставщику)ЗапросЗаказПоставщику;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}