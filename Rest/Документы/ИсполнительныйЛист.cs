﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//IspolnitelnyjjList
	[Маршрут("Документы/ИсполнительныйЛист","")]
	public class ИсполнительныйЛистЗапрос: V82.ДокументыСсылка.ИсполнительныйЛист,IReturn<ИсполнительныйЛистЗапрос>
	{
	}
	[Маршрут("Документы/ИсполнительныйЛист/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ИсполнительныйЛист/ПоСсылке","{Ссылка}")]
	public class ИсполнительныйЛистНайтиПоСсылке: V82.ДокументыСсылка.ИсполнительныйЛист,IReturn<ИсполнительныйЛистНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ИсполнительныйЛист/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ИсполнительныйЛист/ПоНомеру","{Номер}")]
	public class ИсполнительныйЛистНайтиПоНомеру: V82.ДокументыСсылка.ИсполнительныйЛист,IReturn<ИсполнительныйЛистНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ИсполнительныйЛист/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ИсполнительныйЛист/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИсполнительныйЛист/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ИсполнительныйЛистВыбратьПоСсылке: V82.ДокументыСсылка.ИсполнительныйЛист,IReturn<ИсполнительныйЛистВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ИсполнительныйЛист/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ИсполнительныйЛист/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИсполнительныйЛист/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ИсполнительныйЛистВыбратьПоНомеру: V82.ДокументыСсылка.ИсполнительныйЛист,IReturn<ИсполнительныйЛистВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ИсполнительныйЛист/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ИсполнительныйЛистСтраницаПоСсылке: V82.ДокументыСсылка.ИсполнительныйЛист,IReturn<ИсполнительныйЛистСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ИсполнительныйЛист/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ИсполнительныйЛистСтраницаПоНомеру: V82.ДокументыСсылка.ИсполнительныйЛист,IReturn<ИсполнительныйЛистСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ИсполнительныйЛистОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ИсполнительныйЛистСервис : Service
	{
		
		public object Get(ИсполнительныйЛистЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ИсполнительныйЛистНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ИсполнительныйЛист.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ИсполнительныйЛистОтвет() { Ответ = "ИсполнительныйЛист c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИсполнительныйЛистНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ИсполнительныйЛист.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ИсполнительныйЛистОтвет() {Ответ = "ИсполнительныйЛист c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИсполнительныйЛистВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ИсполнительныйЛист.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ИсполнительныйЛистВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ИсполнительныйЛистСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИсполнительныйЛистСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ИсполнительныйЛистЗапрос Запрос)
		{
			return new ИсполнительныйЛистОтвет {Ответ = "ИсполнительныйЛист, "};
		}

		public object Post(ИсполнительныйЛистЗапрос ЗапросИсполнительныйЛист)
		{
			var Ссылка = (ДокументыСсылка.ИсполнительныйЛист)ЗапросИсполнительныйЛист;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}