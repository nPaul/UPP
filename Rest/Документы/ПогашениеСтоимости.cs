﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PogashenieStoimosti
	[Маршрут("Документы/ПогашениеСтоимости","")]
	public class ПогашениеСтоимостиЗапрос: V82.ДокументыСсылка.ПогашениеСтоимости,IReturn<ПогашениеСтоимостиЗапрос>
	{
	}
	[Маршрут("Документы/ПогашениеСтоимости/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПогашениеСтоимости/ПоСсылке","{Ссылка}")]
	public class ПогашениеСтоимостиНайтиПоСсылке: V82.ДокументыСсылка.ПогашениеСтоимости,IReturn<ПогашениеСтоимостиНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПогашениеСтоимости/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПогашениеСтоимости/ПоНомеру","{Номер}")]
	public class ПогашениеСтоимостиНайтиПоНомеру: V82.ДокументыСсылка.ПогашениеСтоимости,IReturn<ПогашениеСтоимостиНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПогашениеСтоимости/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПогашениеСтоимости/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПогашениеСтоимости/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПогашениеСтоимостиВыбратьПоСсылке: V82.ДокументыСсылка.ПогашениеСтоимости,IReturn<ПогашениеСтоимостиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПогашениеСтоимости/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПогашениеСтоимости/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПогашениеСтоимости/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПогашениеСтоимостиВыбратьПоНомеру: V82.ДокументыСсылка.ПогашениеСтоимости,IReturn<ПогашениеСтоимостиВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПогашениеСтоимости/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПогашениеСтоимостиСтраницаПоСсылке: V82.ДокументыСсылка.ПогашениеСтоимости,IReturn<ПогашениеСтоимостиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПогашениеСтоимости/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПогашениеСтоимостиСтраницаПоНомеру: V82.ДокументыСсылка.ПогашениеСтоимости,IReturn<ПогашениеСтоимостиСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПогашениеСтоимостиОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПогашениеСтоимостиСервис : Service
	{
		
		public object Get(ПогашениеСтоимостиЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПогашениеСтоимостиНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПогашениеСтоимости.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПогашениеСтоимостиОтвет() { Ответ = "ПогашениеСтоимости c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПогашениеСтоимостиНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПогашениеСтоимости.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПогашениеСтоимостиОтвет() {Ответ = "ПогашениеСтоимости c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПогашениеСтоимостиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПогашениеСтоимости.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПогашениеСтоимостиВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПогашениеСтоимостиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПогашениеСтоимостиСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПогашениеСтоимостиЗапрос Запрос)
		{
			return new ПогашениеСтоимостиОтвет {Ответ = "ПогашениеСтоимости, "};
		}

		public object Post(ПогашениеСтоимостиЗапрос ЗапросПогашениеСтоимости)
		{
			var Ссылка = (ДокументыСсылка.ПогашениеСтоимости)ЗапросПогашениеСтоимости;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}