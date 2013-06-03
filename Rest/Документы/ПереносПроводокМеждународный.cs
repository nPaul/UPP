﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PerenosProvodokMezhdunarodnyjj
	[Маршрут("Документы/ПереносПроводокМеждународный","")]
	public class ПереносПроводокМеждународныйЗапрос: V82.ДокументыСсылка.ПереносПроводокМеждународный,IReturn<ПереносПроводокМеждународныйЗапрос>
	{
	}
	[Маршрут("Документы/ПереносПроводокМеждународный/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПереносПроводокМеждународный/ПоСсылке","{Ссылка}")]
	public class ПереносПроводокМеждународныйНайтиПоСсылке: V82.ДокументыСсылка.ПереносПроводокМеждународный,IReturn<ПереносПроводокМеждународныйНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПереносПроводокМеждународный/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПереносПроводокМеждународный/ПоНомеру","{Номер}")]
	public class ПереносПроводокМеждународныйНайтиПоНомеру: V82.ДокументыСсылка.ПереносПроводокМеждународный,IReturn<ПереносПроводокМеждународныйНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПереносПроводокМеждународный/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПереносПроводокМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПереносПроводокМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПереносПроводокМеждународныйВыбратьПоСсылке: V82.ДокументыСсылка.ПереносПроводокМеждународный,IReturn<ПереносПроводокМеждународныйВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПереносПроводокМеждународный/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПереносПроводокМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПереносПроводокМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПереносПроводокМеждународныйВыбратьПоНомеру: V82.ДокументыСсылка.ПереносПроводокМеждународный,IReturn<ПереносПроводокМеждународныйВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПереносПроводокМеждународный/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПереносПроводокМеждународныйСтраницаПоСсылке: V82.ДокументыСсылка.ПереносПроводокМеждународный,IReturn<ПереносПроводокМеждународныйСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПереносПроводокМеждународный/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПереносПроводокМеждународныйСтраницаПоНомеру: V82.ДокументыСсылка.ПереносПроводокМеждународный,IReturn<ПереносПроводокМеждународныйСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПереносПроводокМеждународныйОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПереносПроводокМеждународныйСервис : Service
	{
		
		public object Get(ПереносПроводокМеждународныйЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПереносПроводокМеждународныйНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПереносПроводокМеждународный.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПереносПроводокМеждународныйОтвет() { Ответ = "ПереносПроводокМеждународный c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПереносПроводокМеждународныйНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПереносПроводокМеждународный.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПереносПроводокМеждународныйОтвет() {Ответ = "ПереносПроводокМеждународный c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПереносПроводокМеждународныйВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПереносПроводокМеждународный.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПереносПроводокМеждународныйВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПереносПроводокМеждународныйСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПереносПроводокМеждународныйСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПереносПроводокМеждународныйЗапрос Запрос)
		{
			return new ПереносПроводокМеждународныйОтвет {Ответ = "ПереносПроводокМеждународный, "};
		}

		public object Post(ПереносПроводокМеждународныйЗапрос ЗапросПереносПроводокМеждународный)
		{
			var Ссылка = (ДокументыСсылка.ПереносПроводокМеждународный)ЗапросПереносПроводокМеждународный;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}