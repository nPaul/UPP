﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SemejjnoePolozhenieFizLic
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц","")]
	public class СемейноеПоложениеФизЛицЗапрос: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицЗапрос>
	{
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ПоСсылке","{Ссылка}")]
	public class СемейноеПоложениеФизЛицНайтиПоСсылке: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ПоКоду","{Код}")]
	public class СемейноеПоложениеФизЛицНайтиПоКоду: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ПоНаименованию","{Наименование}")]
	public class СемейноеПоложениеФизЛицНайтиПоНаименованию: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СемейноеПоложениеФизЛицВыбратьПоСсылке: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СемейноеПоложениеФизЛицВыбратьПоКоду: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СемейноеПоложениеФизЛицВыбратьПоНаименованию: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class СемейноеПоложениеФизЛицОтвет
	{
		public string Ответ {get;set;}
	}

	public class СемейноеПоложениеФизЛицСервис : Service
	{
		
		public object Get(СемейноеПоложениеФизЛицНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СемейноеПоложениеФизЛиц.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СемейноеПоложениеФизЛицОтвет() {Ответ = "СемейноеПоложениеФизЛиц c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СемейноеПоложениеФизЛицНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СемейноеПоложениеФизЛицЗапрос Запрос)
		{
			return new СемейноеПоложениеФизЛицОтвет {Ответ = "СемейноеПоложениеФизЛиц, "};
		}

		public object Post(СемейноеПоложениеФизЛицЗапрос ЗапросСемейноеПоложениеФизЛиц)
		{
			var Ссылка = (СправочникиСсылка.СемейноеПоложениеФизЛиц)ЗапросСемейноеПоложениеФизЛиц;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}