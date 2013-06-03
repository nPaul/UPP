﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//ZakrytieZakazovPostavshhikam
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам","")]
	public class ЗакрытиеЗаказовПоставщикамЗапрос: V82.ДокументыСсылка.ЗакрытиеЗаказовПоставщикам,IReturn<ЗакрытиеЗаказовПоставщикамЗапрос>
	{
	}
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/ПоСсылке","{Ссылка}")]
	public class ЗакрытиеЗаказовПоставщикамНайтиПоСсылке: V82.ДокументыСсылка.ЗакрытиеЗаказовПоставщикам,IReturn<ЗакрытиеЗаказовПоставщикамНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/ПоНомеру","{Номер}")]
	public class ЗакрытиеЗаказовПоставщикамНайтиПоНомеру: V82.ДокументыСсылка.ЗакрытиеЗаказовПоставщикам,IReturn<ЗакрытиеЗаказовПоставщикамНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ЗакрытиеЗаказовПоставщикамВыбратьПоСсылке: V82.ДокументыСсылка.ЗакрытиеЗаказовПоставщикам,IReturn<ЗакрытиеЗаказовПоставщикамВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ЗакрытиеЗаказовПоставщикамВыбратьПоНомеру: V82.ДокументыСсылка.ЗакрытиеЗаказовПоставщикам,IReturn<ЗакрытиеЗаказовПоставщикамВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ЗакрытиеЗаказовПоставщикамСтраницаПоСсылке: V82.ДокументыСсылка.ЗакрытиеЗаказовПоставщикам,IReturn<ЗакрытиеЗаказовПоставщикамСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ЗакрытиеЗаказовПоставщикам/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ЗакрытиеЗаказовПоставщикамСтраницаПоНомеру: V82.ДокументыСсылка.ЗакрытиеЗаказовПоставщикам,IReturn<ЗакрытиеЗаказовПоставщикамСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ЗакрытиеЗаказовПоставщикамОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ЗакрытиеЗаказовПоставщикамСервис : Service
	{
		
		public object Get(ЗакрытиеЗаказовПоставщикамЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ЗакрытиеЗаказовПоставщикамНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ЗакрытиеЗаказовПоставщикам.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ЗакрытиеЗаказовПоставщикамОтвет() { Ответ = "ЗакрытиеЗаказовПоставщикам c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЗакрытиеЗаказовПоставщикамНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ЗакрытиеЗаказовПоставщикам.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ЗакрытиеЗаказовПоставщикамОтвет() {Ответ = "ЗакрытиеЗаказовПоставщикам c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЗакрытиеЗаказовПоставщикамВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ЗакрытиеЗаказовПоставщикам.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ЗакрытиеЗаказовПоставщикамВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ЗакрытиеЗаказовПоставщикамСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЗакрытиеЗаказовПоставщикамСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ЗакрытиеЗаказовПоставщикамЗапрос Запрос)
		{
			return new ЗакрытиеЗаказовПоставщикамОтвет {Ответ = "ЗакрытиеЗаказовПоставщикам, "};
		}

		public object Post(ЗакрытиеЗаказовПоставщикамЗапрос ЗапросЗакрытиеЗаказовПоставщикам)
		{
			var Ссылка = (ДокументыСсылка.ЗакрытиеЗаказовПоставщикам)ЗапросЗакрытиеЗаказовПоставщикам;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}