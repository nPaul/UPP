﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//InkassovoePorucheniePeredannoe
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное","")]
	public class ИнкассовоеПоручениеПереданноеЗапрос: V82.ДокументыСсылка.ИнкассовоеПоручениеПереданное,IReturn<ИнкассовоеПоручениеПереданноеЗапрос>
	{
	}
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/ПоСсылке","{Ссылка}")]
	public class ИнкассовоеПоручениеПереданноеНайтиПоСсылке: V82.ДокументыСсылка.ИнкассовоеПоручениеПереданное,IReturn<ИнкассовоеПоручениеПереданноеНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/ПоНомеру","{Номер}")]
	public class ИнкассовоеПоручениеПереданноеНайтиПоНомеру: V82.ДокументыСсылка.ИнкассовоеПоручениеПереданное,IReturn<ИнкассовоеПоручениеПереданноеНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ИнкассовоеПоручениеПереданноеВыбратьПоСсылке: V82.ДокументыСсылка.ИнкассовоеПоручениеПереданное,IReturn<ИнкассовоеПоручениеПереданноеВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ИнкассовоеПоручениеПереданноеВыбратьПоНомеру: V82.ДокументыСсылка.ИнкассовоеПоручениеПереданное,IReturn<ИнкассовоеПоручениеПереданноеВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ИнкассовоеПоручениеПереданноеСтраницаПоСсылке: V82.ДокументыСсылка.ИнкассовоеПоручениеПереданное,IReturn<ИнкассовоеПоручениеПереданноеСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ИнкассовоеПоручениеПереданное/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ИнкассовоеПоручениеПереданноеСтраницаПоНомеру: V82.ДокументыСсылка.ИнкассовоеПоручениеПереданное,IReturn<ИнкассовоеПоручениеПереданноеСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ИнкассовоеПоручениеПереданноеОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ИнкассовоеПоручениеПереданноеСервис : Service
	{
		
		public object Get(ИнкассовоеПоручениеПереданноеЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ИнкассовоеПоручениеПереданноеНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ИнкассовоеПоручениеПереданное.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ИнкассовоеПоручениеПереданноеОтвет() { Ответ = "ИнкассовоеПоручениеПереданное c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИнкассовоеПоручениеПереданноеНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ИнкассовоеПоручениеПереданное.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ИнкассовоеПоручениеПереданноеОтвет() {Ответ = "ИнкассовоеПоручениеПереданное c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИнкассовоеПоручениеПереданноеВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ИнкассовоеПоручениеПереданное.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ИнкассовоеПоручениеПереданноеВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ИнкассовоеПоручениеПереданноеСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИнкассовоеПоручениеПереданноеСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ИнкассовоеПоручениеПереданноеЗапрос Запрос)
		{
			return new ИнкассовоеПоручениеПереданноеОтвет {Ответ = "ИнкассовоеПоручениеПереданное, "};
		}

		public object Post(ИнкассовоеПоручениеПереданноеЗапрос ЗапросИнкассовоеПоручениеПереданное)
		{
			var Ссылка = (ДокументыСсылка.ИнкассовоеПоручениеПереданное)ЗапросИнкассовоеПоручениеПереданное;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}