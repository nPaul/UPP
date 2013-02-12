﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//IstochnikiDannykhDlyaRaschetovByudzhetirovaniya
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования","")]
	public class ИсточникиДанныхДляРасчетовБюджетированияЗапрос: V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования,IReturn<ИсточникиДанныхДляРасчетовБюджетированияЗапрос>
	{
	}
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования/ПоСсылке","{Ссылка}")]
	public class ИсточникиДанныхДляРасчетовБюджетированияНайтиПоСсылке: V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования,IReturn<ИсточникиДанныхДляРасчетовБюджетированияНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования/ПоКоду","{Код}")]
	public class ИсточникиДанныхДляРасчетовБюджетированияНайтиПоКоду: V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования,IReturn<ИсточникиДанныхДляРасчетовБюджетированияНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования/ПоНаименованию","{Наименование}")]
	public class ИсточникиДанныхДляРасчетовБюджетированияНайтиПоНаименованию: V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования,IReturn<ИсточникиДанныхДляРасчетовБюджетированияНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ИсточникиДанныхДляРасчетовБюджетированияВыбратьПоСсылке: V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования,IReturn<ИсточникиДанныхДляРасчетовБюджетированияВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ИсточникиДанныхДляРасчетовБюджетированияВыбратьПоКоду: V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования,IReturn<ИсточникиДанныхДляРасчетовБюджетированияВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ИсточникиДанныхДляРасчетовБюджетирования/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ИсточникиДанныхДляРасчетовБюджетированияВыбратьПоНаименованию: V82.СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования,IReturn<ИсточникиДанныхДляРасчетовБюджетированияВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}

	public class ИсточникиДанныхДляРасчетовБюджетированияОтвет
	{
		public string Ответ {get;set;}
	}

	public class ИсточникиДанныхДляРасчетовБюджетированияСервис : Service
	{
		
		public object Get(ИсточникиДанныхДляРасчетовБюджетированияНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиДанныхДляРасчетовБюджетированияНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ИсточникиДанныхДляРасчетовБюджетирования.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ИсточникиДанныхДляРасчетовБюджетированияОтвет() {Ответ = "ИсточникиДанныхДляРасчетовБюджетирования c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ИсточникиДанныхДляРасчетовБюджетированияНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиДанныхДляРасчетовБюджетированияВыбратьПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиДанныхДляРасчетовБюджетированияВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиДанныхДляРасчетовБюджетированияВыбратьПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ИсточникиДанныхДляРасчетовБюджетированияЗапрос Запрос)
		{
			return new ИсточникиДанныхДляРасчетовБюджетированияОтвет {Ответ = "ИсточникиДанныхДляРасчетовБюджетирования, "};
		}

		public object Post(ИсточникиДанныхДляРасчетовБюджетированияЗапрос ЗапросИсточникиДанныхДляРасчетовБюджетирования)
		{
			var Ссылка = (СправочникиСсылка.ИсточникиДанныхДляРасчетовБюджетирования)ЗапросИсточникиДанныхДляРасчетовБюджетирования;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}