﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PereocenkaAktivovMezhdunarodnyjj
	[Маршрут("Документы/ПереоценкаАктивовМеждународный","")]
	public class ПереоценкаАктивовМеждународныйЗапрос: V82.ДокументыСсылка.ПереоценкаАктивовМеждународный,IReturn<ПереоценкаАктивовМеждународныйЗапрос>
	{
	}
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/ПоСсылке","{Ссылка}")]
	public class ПереоценкаАктивовМеждународныйНайтиПоСсылке: V82.ДокументыСсылка.ПереоценкаАктивовМеждународный,IReturn<ПереоценкаАктивовМеждународныйНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/ПоНомеру","{Номер}")]
	public class ПереоценкаАктивовМеждународныйНайтиПоНомеру: V82.ДокументыСсылка.ПереоценкаАктивовМеждународный,IReturn<ПереоценкаАктивовМеждународныйНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПереоценкаАктивовМеждународныйВыбратьПоСсылке: V82.ДокументыСсылка.ПереоценкаАктивовМеждународный,IReturn<ПереоценкаАктивовМеждународныйВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПереоценкаАктивовМеждународныйВыбратьПоНомеру: V82.ДокументыСсылка.ПереоценкаАктивовМеждународный,IReturn<ПереоценкаАктивовМеждународныйВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПереоценкаАктивовМеждународныйСтраницаПоСсылке: V82.ДокументыСсылка.ПереоценкаАктивовМеждународный,IReturn<ПереоценкаАктивовМеждународныйСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПереоценкаАктивовМеждународный/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПереоценкаАктивовМеждународныйСтраницаПоНомеру: V82.ДокументыСсылка.ПереоценкаАктивовМеждународный,IReturn<ПереоценкаАктивовМеждународныйСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПереоценкаАктивовМеждународныйОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПереоценкаАктивовМеждународныйСервис : Service
	{
		
		public object Get(ПереоценкаАктивовМеждународныйЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПереоценкаАктивовМеждународныйНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПереоценкаАктивовМеждународный.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПереоценкаАктивовМеждународныйОтвет() { Ответ = "ПереоценкаАктивовМеждународный c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПереоценкаАктивовМеждународныйНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПереоценкаАктивовМеждународный.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПереоценкаАктивовМеждународныйОтвет() {Ответ = "ПереоценкаАктивовМеждународный c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПереоценкаАктивовМеждународныйВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПереоценкаАктивовМеждународный.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПереоценкаАктивовМеждународныйВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПереоценкаАктивовМеждународныйСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПереоценкаАктивовМеждународныйСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПереоценкаАктивовМеждународныйЗапрос Запрос)
		{
			return new ПереоценкаАктивовМеждународныйОтвет {Ответ = "ПереоценкаАктивовМеждународный, "};
		}

		public object Post(ПереоценкаАктивовМеждународныйЗапрос ЗапросПереоценкаАктивовМеждународный)
		{
			var Ссылка = (ДокументыСсылка.ПереоценкаАктивовМеждународный)ЗапросПереоценкаАктивовМеждународный;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}