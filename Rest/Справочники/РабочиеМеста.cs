﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//RabochieMesta
	[Маршрут("Справочники/РабочиеМеста","")]
	public class РабочиеМестаЗапрос: V82.СправочникиСсылка.РабочиеМеста,IReturn<РабочиеМестаЗапрос>
	{
	}
	[Маршрут("Справочники/РабочиеМеста/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/РабочиеМеста/ПоСсылке","{Ссылка}")]
	public class РабочиеМестаНайтиПоСсылке: V82.СправочникиСсылка.РабочиеМеста,IReturn<РабочиеМестаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/РабочиеМеста/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/РабочиеМеста/ПоКоду","{Код}")]
	public class РабочиеМестаНайтиПоКоду: V82.СправочникиСсылка.РабочиеМеста,IReturn<РабочиеМестаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/РабочиеМеста/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/РабочиеМеста/ПоНаименованию","{Наименование}")]
	public class РабочиеМестаНайтиПоНаименованию: V82.СправочникиСсылка.РабочиеМеста,IReturn<РабочиеМестаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/РабочиеМеста/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РабочиеМестаВыбратьПоСсылке: V82.СправочникиСсылка.РабочиеМеста,IReturn<РабочиеМестаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/РабочиеМеста/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class РабочиеМестаВыбратьПоКоду: V82.СправочникиСсылка.РабочиеМеста,IReturn<РабочиеМестаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/РабочиеМеста/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class РабочиеМестаВыбратьПоНаименованию: V82.СправочникиСсылка.РабочиеМеста,IReturn<РабочиеМестаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class РабочиеМестаОтвет
	{
		public string Ответ {get;set;}
	}

	public class РабочиеМестаСервис : Service
	{
		
		public object Get(РабочиеМестаНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РабочиеМестаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.РабочиеМеста.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new РабочиеМестаОтвет() {Ответ = "РабочиеМеста c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(РабочиеМестаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РабочиеМестаВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РабочиеМестаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РабочиеМестаВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(РабочиеМестаЗапрос Запрос)
		{
			return new РабочиеМестаОтвет {Ответ = "РабочиеМеста, "};
		}

		public object Post(РабочиеМестаЗапрос ЗапросРабочиеМеста)
		{
			var Ссылка = (СправочникиСсылка.РабочиеМеста)ЗапросРабочиеМеста;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}