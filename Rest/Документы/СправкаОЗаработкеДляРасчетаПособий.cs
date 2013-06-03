﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//SpravkaOZarabotkeDlyaRaschetaPosobijj
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий","")]
	public class СправкаОЗаработкеДляРасчетаПособийЗапрос: V82.ДокументыСсылка.СправкаОЗаработкеДляРасчетаПособий,IReturn<СправкаОЗаработкеДляРасчетаПособийЗапрос>
	{
	}
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/ПоСсылке","{Ссылка}")]
	public class СправкаОЗаработкеДляРасчетаПособийНайтиПоСсылке: V82.ДокументыСсылка.СправкаОЗаработкеДляРасчетаПособий,IReturn<СправкаОЗаработкеДляРасчетаПособийНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/ПоНомеру","{Номер}")]
	public class СправкаОЗаработкеДляРасчетаПособийНайтиПоНомеру: V82.ДокументыСсылка.СправкаОЗаработкеДляРасчетаПособий,IReturn<СправкаОЗаработкеДляРасчетаПособийНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СправкаОЗаработкеДляРасчетаПособийВыбратьПоСсылке: V82.ДокументыСсылка.СправкаОЗаработкеДляРасчетаПособий,IReturn<СправкаОЗаработкеДляРасчетаПособийВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class СправкаОЗаработкеДляРасчетаПособийВыбратьПоНомеру: V82.ДокументыСсылка.СправкаОЗаработкеДляРасчетаПособий,IReturn<СправкаОЗаработкеДляРасчетаПособийВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СправкаОЗаработкеДляРасчетаПособийСтраницаПоСсылке: V82.ДокументыСсылка.СправкаОЗаработкеДляРасчетаПособий,IReturn<СправкаОЗаработкеДляРасчетаПособийСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/СправкаОЗаработкеДляРасчетаПособий/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class СправкаОЗаработкеДляРасчетаПособийСтраницаПоНомеру: V82.ДокументыСсылка.СправкаОЗаработкеДляРасчетаПособий,IReturn<СправкаОЗаработкеДляРасчетаПособийСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СправкаОЗаработкеДляРасчетаПособийОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СправкаОЗаработкеДляРасчетаПособийСервис : Service
	{
		
		public object Get(СправкаОЗаработкеДляРасчетаПособийЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СправкаОЗаработкеДляРасчетаПособийНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.СправкаОЗаработкеДляРасчетаПособий.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СправкаОЗаработкеДляРасчетаПособийОтвет() { Ответ = "СправкаОЗаработкеДляРасчетаПособий c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СправкаОЗаработкеДляРасчетаПособийНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.СправкаОЗаработкеДляРасчетаПособий.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new СправкаОЗаработкеДляРасчетаПособийОтвет() {Ответ = "СправкаОЗаработкеДляРасчетаПособий c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СправкаОЗаработкеДляРасчетаПособийВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.СправкаОЗаработкеДляРасчетаПособий.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СправкаОЗаработкеДляРасчетаПособийВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(СправкаОЗаработкеДляРасчетаПособийСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СправкаОЗаработкеДляРасчетаПособийСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(СправкаОЗаработкеДляРасчетаПособийЗапрос Запрос)
		{
			return new СправкаОЗаработкеДляРасчетаПособийОтвет {Ответ = "СправкаОЗаработкеДляРасчетаПособий, "};
		}

		public object Post(СправкаОЗаработкеДляРасчетаПособийЗапрос ЗапросСправкаОЗаработкеДляРасчетаПособий)
		{
			var Ссылка = (ДокументыСсылка.СправкаОЗаработкеДляРасчетаПособий)ЗапросСправкаОЗаработкеДляРасчетаПособий;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}