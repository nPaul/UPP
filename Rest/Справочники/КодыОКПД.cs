﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KodyOKPD
	[Маршрут("Справочники/КодыОКПД","")]
	public class КодыОКПДЗапрос: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДЗапрос>
	{
	}
	[Маршрут("Справочники/КодыОКПД/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КодыОКПД/ПоСсылке","{Ссылка}")]
	public class КодыОКПДНайтиПоСсылке: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КодыОКПД/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/КодыОКПД/ПоКоду","{Код}")]
	public class КодыОКПДНайтиПоКоду: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/КодыОКПД/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КодыОКПДВыбратьПоСсылке: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КодыОКПД/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class КодыОКПДВыбратьПоКоду: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class КодыОКПДОтвет
	{
		public string Ответ {get;set;}
	}

	public class КодыОКПДСервис : Service
	{
		
		public object Get(КодыОКПДНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КодыОКПДНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.КодыОКПД.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new КодыОКПДОтвет() {Ответ = "КодыОКПД c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(КодыОКПДВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КодыОКПДВыбратьПоКоду Запрос)
		{
			return null;
		}

		public object Any(КодыОКПДЗапрос Запрос)
		{
			return new КодыОКПДОтвет {Ответ = "КодыОКПД, "};
		}

		public object Post(КодыОКПДЗапрос ЗапросКодыОКПД)
		{
			var Ссылка = (СправочникиСсылка.КодыОКПД)ЗапросКодыОКПД;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}