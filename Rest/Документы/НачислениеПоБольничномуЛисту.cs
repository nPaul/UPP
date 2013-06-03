﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//NachisleniePoBolnichnomuListu
	[Маршрут("Документы/НачислениеПоБольничномуЛисту","")]
	public class НачислениеПоБольничномуЛистуЗапрос: V82.ДокументыСсылка.НачислениеПоБольничномуЛисту,IReturn<НачислениеПоБольничномуЛистуЗапрос>
	{
	}
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/ПоСсылке","{Ссылка}")]
	public class НачислениеПоБольничномуЛистуНайтиПоСсылке: V82.ДокументыСсылка.НачислениеПоБольничномуЛисту,IReturn<НачислениеПоБольничномуЛистуНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/ПоНомеру","{Номер}")]
	public class НачислениеПоБольничномуЛистуНайтиПоНомеру: V82.ДокументыСсылка.НачислениеПоБольничномуЛисту,IReturn<НачислениеПоБольничномуЛистуНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НачислениеПоБольничномуЛистуВыбратьПоСсылке: V82.ДокументыСсылка.НачислениеПоБольничномуЛисту,IReturn<НачислениеПоБольничномуЛистуВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class НачислениеПоБольничномуЛистуВыбратьПоНомеру: V82.ДокументыСсылка.НачислениеПоБольничномуЛисту,IReturn<НачислениеПоБольничномуЛистуВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НачислениеПоБольничномуЛистуСтраницаПоСсылке: V82.ДокументыСсылка.НачислениеПоБольничномуЛисту,IReturn<НачислениеПоБольничномуЛистуСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/НачислениеПоБольничномуЛисту/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class НачислениеПоБольничномуЛистуСтраницаПоНомеру: V82.ДокументыСсылка.НачислениеПоБольничномуЛисту,IReturn<НачислениеПоБольничномуЛистуСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НачислениеПоБольничномуЛистуОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НачислениеПоБольничномуЛистуСервис : Service
	{
		
		public object Get(НачислениеПоБольничномуЛистуЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НачислениеПоБольничномуЛистуНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.НачислениеПоБольничномуЛисту.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new НачислениеПоБольничномуЛистуОтвет() { Ответ = "НачислениеПоБольничномуЛисту c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НачислениеПоБольничномуЛистуНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.НачислениеПоБольничномуЛисту.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new НачислениеПоБольничномуЛистуОтвет() {Ответ = "НачислениеПоБольничномуЛисту c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НачислениеПоБольничномуЛистуВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.НачислениеПоБольничномуЛисту.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(НачислениеПоБольничномуЛистуВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(НачислениеПоБольничномуЛистуСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НачислениеПоБольничномуЛистуСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(НачислениеПоБольничномуЛистуЗапрос Запрос)
		{
			return new НачислениеПоБольничномуЛистуОтвет {Ответ = "НачислениеПоБольничномуЛисту, "};
		}

		public object Post(НачислениеПоБольничномуЛистуЗапрос ЗапросНачислениеПоБольничномуЛисту)
		{
			var Ссылка = (ДокументыСсылка.НачислениеПоБольничномуЛисту)ЗапросНачислениеПоБольничномуЛисту;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}