﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//DogovoryKontragentov
	[Маршрут("Справочники/ДоговорыКонтрагентов","")]
	public class ДоговорыКонтрагентовЗапрос: V82.СправочникиСсылка.ДоговорыКонтрагентов,IReturn<ДоговорыКонтрагентовЗапрос>
	{
	}
	[Маршрут("Справочники/ДоговорыКонтрагентов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ДоговорыКонтрагентов/ПоСсылке","{Ссылка}")]
	public class ДоговорыКонтрагентовНайтиПоСсылке: V82.СправочникиСсылка.ДоговорыКонтрагентов,IReturn<ДоговорыКонтрагентовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ДоговорыКонтрагентов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ДоговорыКонтрагентов/ПоКоду","{Код}")]
	public class ДоговорыКонтрагентовНайтиПоКоду: V82.СправочникиСсылка.ДоговорыКонтрагентов,IReturn<ДоговорыКонтрагентовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ДоговорыКонтрагентов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ДоговорыКонтрагентов/ПоНаименованию","{Наименование}")]
	public class ДоговорыКонтрагентовНайтиПоНаименованию: V82.СправочникиСсылка.ДоговорыКонтрагентов,IReturn<ДоговорыКонтрагентовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ДоговорыКонтрагентов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоговорыКонтрагентовВыбратьПоСсылке: V82.СправочникиСсылка.ДоговорыКонтрагентов,IReturn<ДоговорыКонтрагентовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДоговорыКонтрагентов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоговорыКонтрагентовВыбратьПоКоду: V82.СправочникиСсылка.ДоговорыКонтрагентов,IReturn<ДоговорыКонтрагентовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДоговорыКонтрагентов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоговорыКонтрагентовВыбратьПоНаименованию: V82.СправочникиСсылка.ДоговорыКонтрагентов,IReturn<ДоговорыКонтрагентовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class ДоговорыКонтрагентовОтвет
	{
		public string Ответ {get;set;}
	}

	public class ДоговорыКонтрагентовСервис : Service
	{
		
		public object Get(ДоговорыКонтрагентовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыКонтрагентовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ДоговорыКонтрагентов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ДоговорыКонтрагентовОтвет() {Ответ = "ДоговорыКонтрагентов c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ДоговорыКонтрагентовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыКонтрагентовВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыКонтрагентовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыКонтрагентовВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ДоговорыКонтрагентовЗапрос Запрос)
		{
			return new ДоговорыКонтрагентовОтвет {Ответ = "ДоговорыКонтрагентов, "};
		}

		public object Post(ДоговорыКонтрагентовЗапрос ЗапросДоговорыКонтрагентов)
		{
			var Ссылка = (СправочникиСсылка.ДоговорыКонтрагентов)ЗапросДоговорыКонтрагентов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}