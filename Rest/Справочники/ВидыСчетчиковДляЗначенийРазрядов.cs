﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidySchetchikovDlyaZnachenijjRazryadov
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов","")]
	public class ВидыСчетчиковДляЗначенийРазрядовЗапрос: V82.СправочникиСсылка.ВидыСчетчиковДляЗначенийРазрядов,IReturn<ВидыСчетчиковДляЗначенийРазрядовЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов/ПоСсылке","{Ссылка}")]
	public class ВидыСчетчиковДляЗначенийРазрядовНайтиПоСсылке: V82.СправочникиСсылка.ВидыСчетчиковДляЗначенийРазрядов,IReturn<ВидыСчетчиковДляЗначенийРазрядовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов/ПоКоду","{Код}")]
	public class ВидыСчетчиковДляЗначенийРазрядовНайтиПоКоду: V82.СправочникиСсылка.ВидыСчетчиковДляЗначенийРазрядов,IReturn<ВидыСчетчиковДляЗначенийРазрядовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов/ПоНаименованию","{Наименование}")]
	public class ВидыСчетчиковДляЗначенийРазрядовНайтиПоНаименованию: V82.СправочникиСсылка.ВидыСчетчиковДляЗначенийРазрядов,IReturn<ВидыСчетчиковДляЗначенийРазрядовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыСчетчиковДляЗначенийРазрядовВыбратьПоСсылке: V82.СправочникиСсылка.ВидыСчетчиковДляЗначенийРазрядов,IReturn<ВидыСчетчиковДляЗначенийРазрядовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыСчетчиковДляЗначенийРазрядовВыбратьПоКоду: V82.СправочникиСсылка.ВидыСчетчиковДляЗначенийРазрядов,IReturn<ВидыСчетчиковДляЗначенийРазрядовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыСчетчиковДляЗначенийРазрядов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыСчетчиковДляЗначенийРазрядовВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыСчетчиковДляЗначенийРазрядов,IReturn<ВидыСчетчиковДляЗначенийРазрядовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class ВидыСчетчиковДляЗначенийРазрядовОтвет
	{
		public string Ответ {get;set;}
	}

	public class ВидыСчетчиковДляЗначенийРазрядовСервис : Service
	{
		
		public object Get(ВидыСчетчиковДляЗначенийРазрядовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСчетчиковДляЗначенийРазрядовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыСчетчиковДляЗначенийРазрядов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыСчетчиковДляЗначенийРазрядовОтвет() {Ответ = "ВидыСчетчиковДляЗначенийРазрядов c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ВидыСчетчиковДляЗначенийРазрядовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСчетчиковДляЗначенийРазрядовВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСчетчиковДляЗначенийРазрядовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыСчетчиковДляЗначенийРазрядовВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыСчетчиковДляЗначенийРазрядовЗапрос Запрос)
		{
			return new ВидыСчетчиковДляЗначенийРазрядовОтвет {Ответ = "ВидыСчетчиковДляЗначенийРазрядов, "};
		}

		public object Post(ВидыСчетчиковДляЗначенийРазрядовЗапрос ЗапросВидыСчетчиковДляЗначенийРазрядов)
		{
			var Ссылка = (СправочникиСсылка.ВидыСчетчиковДляЗначенийРазрядов)ЗапросВидыСчетчиковДляЗначенийРазрядов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}