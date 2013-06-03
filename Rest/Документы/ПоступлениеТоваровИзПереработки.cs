﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PostuplenieTovarovIzPererabotki
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки","")]
	public class ПоступлениеТоваровИзПереработкиЗапрос: V82.ДокументыСсылка.ПоступлениеТоваровИзПереработки,IReturn<ПоступлениеТоваровИзПереработкиЗапрос>
	{
	}
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/ПоСсылке","{Ссылка}")]
	public class ПоступлениеТоваровИзПереработкиНайтиПоСсылке: V82.ДокументыСсылка.ПоступлениеТоваровИзПереработки,IReturn<ПоступлениеТоваровИзПереработкиНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/ПоНомеру","{Номер}")]
	public class ПоступлениеТоваровИзПереработкиНайтиПоНомеру: V82.ДокументыСсылка.ПоступлениеТоваровИзПереработки,IReturn<ПоступлениеТоваровИзПереработкиНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПоступлениеТоваровИзПереработкиВыбратьПоСсылке: V82.ДокументыСсылка.ПоступлениеТоваровИзПереработки,IReturn<ПоступлениеТоваровИзПереработкиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПоступлениеТоваровИзПереработкиВыбратьПоНомеру: V82.ДокументыСсылка.ПоступлениеТоваровИзПереработки,IReturn<ПоступлениеТоваровИзПереработкиВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПоступлениеТоваровИзПереработкиСтраницаПоСсылке: V82.ДокументыСсылка.ПоступлениеТоваровИзПереработки,IReturn<ПоступлениеТоваровИзПереработкиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПоступлениеТоваровИзПереработки/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПоступлениеТоваровИзПереработкиСтраницаПоНомеру: V82.ДокументыСсылка.ПоступлениеТоваровИзПереработки,IReturn<ПоступлениеТоваровИзПереработкиСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПоступлениеТоваровИзПереработкиОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПоступлениеТоваровИзПереработкиСервис : Service
	{
		
		public object Get(ПоступлениеТоваровИзПереработкиЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПоступлениеТоваровИзПереработкиНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПоступлениеТоваровИзПереработки.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПоступлениеТоваровИзПереработкиОтвет() { Ответ = "ПоступлениеТоваровИзПереработки c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПоступлениеТоваровИзПереработкиНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПоступлениеТоваровИзПереработки.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПоступлениеТоваровИзПереработкиОтвет() {Ответ = "ПоступлениеТоваровИзПереработки c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПоступлениеТоваровИзПереработкиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПоступлениеТоваровИзПереработки.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПоступлениеТоваровИзПереработкиВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПоступлениеТоваровИзПереработкиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПоступлениеТоваровИзПереработкиСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПоступлениеТоваровИзПереработкиЗапрос Запрос)
		{
			return new ПоступлениеТоваровИзПереработкиОтвет {Ответ = "ПоступлениеТоваровИзПереработки, "};
		}

		public object Post(ПоступлениеТоваровИзПереработкиЗапрос ЗапросПоступлениеТоваровИзПереработки)
		{
			var Ссылка = (ДокументыСсылка.ПоступлениеТоваровИзПереработки)ЗапросПоступлениеТоваровИзПереработки;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}