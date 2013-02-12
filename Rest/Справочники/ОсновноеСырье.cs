﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//OsnovnoeSyre
	[Маршрут("Справочники/ОсновноеСырье","")]
	public class ОсновноеСырьеЗапрос: V82.СправочникиСсылка.ОсновноеСырье,IReturn<ОсновноеСырьеЗапрос>
	{
	}
	[Маршрут("Справочники/ОсновноеСырье/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОсновноеСырье/ПоСсылке","{Ссылка}")]
	public class ОсновноеСырьеНайтиПоСсылке: V82.СправочникиСсылка.ОсновноеСырье,IReturn<ОсновноеСырьеНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОсновноеСырье/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ОсновноеСырье/ПоКоду","{Код}")]
	public class ОсновноеСырьеНайтиПоКоду: V82.СправочникиСсылка.ОсновноеСырье,IReturn<ОсновноеСырьеНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ОсновноеСырье/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОсновноеСырье/ПоНаименованию","{Наименование}")]
	public class ОсновноеСырьеНайтиПоНаименованию: V82.СправочникиСсылка.ОсновноеСырье,IReturn<ОсновноеСырьеНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОсновноеСырье/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОсновноеСырьеВыбратьПоСсылке: V82.СправочникиСсылка.ОсновноеСырье,IReturn<ОсновноеСырьеВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОсновноеСырье/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОсновноеСырьеВыбратьПоКоду: V82.СправочникиСсылка.ОсновноеСырье,IReturn<ОсновноеСырьеВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОсновноеСырье/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОсновноеСырьеВыбратьПоНаименованию: V82.СправочникиСсылка.ОсновноеСырье,IReturn<ОсновноеСырьеВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class ОсновноеСырьеОтвет
	{
		public string Ответ {get;set;}
	}

	public class ОсновноеСырьеСервис : Service
	{
		
		public object Get(ОсновноеСырьеНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОсновноеСырьеНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ОсновноеСырье.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОсновноеСырьеОтвет() {Ответ = "ОсновноеСырье c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ОсновноеСырьеНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОсновноеСырьеВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОсновноеСырьеВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОсновноеСырьеВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОсновноеСырьеЗапрос Запрос)
		{
			return new ОсновноеСырьеОтвет {Ответ = "ОсновноеСырье, "};
		}

		public object Post(ОсновноеСырьеЗапрос ЗапросОсновноеСырье)
		{
			var Ссылка = (СправочникиСсылка.ОсновноеСырье)ЗапросОсновноеСырье;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}