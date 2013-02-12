﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//OstatkiOtpuskov
	[Маршрут("Справочники/ОстаткиОтпусков","")]
	public class ОстаткиОтпусковЗапрос: V82.СправочникиСсылка.ОстаткиОтпусков,IReturn<ОстаткиОтпусковЗапрос>
	{
	}
	[Маршрут("Справочники/ОстаткиОтпусков/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОстаткиОтпусков/ПоСсылке","{Ссылка}")]
	public class ОстаткиОтпусковНайтиПоСсылке: V82.СправочникиСсылка.ОстаткиОтпусков,IReturn<ОстаткиОтпусковНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОстаткиОтпусков/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОстаткиОтпусков/ПоНаименованию","{Наименование}")]
	public class ОстаткиОтпусковНайтиПоНаименованию: V82.СправочникиСсылка.ОстаткиОтпусков,IReturn<ОстаткиОтпусковНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОстаткиОтпусков/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОстаткиОтпусковВыбратьПоСсылке: V82.СправочникиСсылка.ОстаткиОтпусков,IReturn<ОстаткиОтпусковВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОстаткиОтпусков/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОстаткиОтпусковВыбратьПоНаименованию: V82.СправочникиСсылка.ОстаткиОтпусков,IReturn<ОстаткиОтпусковВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class ОстаткиОтпусковОтвет
	{
		public string Ответ {get;set;}
	}

	public class ОстаткиОтпусковСервис : Service
	{
		
		public object Get(ОстаткиОтпусковНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОстаткиОтпусковНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОстаткиОтпусковВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОстаткиОтпусковВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОстаткиОтпусковЗапрос Запрос)
		{
			return new ОстаткиОтпусковОтвет {Ответ = "ОстаткиОтпусков, "};
		}

		public object Post(ОстаткиОтпусковЗапрос ЗапросОстаткиОтпусков)
		{
			var Ссылка = (СправочникиСсылка.ОстаткиОтпусков)ЗапросОстаткиОтпусков;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}