﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//VybytieNMAMezhdunarodnyjj
	[Маршрут("Документы/ВыбытиеНМАМеждународный","")]
	public class ВыбытиеНМАМеждународныйЗапрос: V82.ДокументыСсылка.ВыбытиеНМАМеждународный,IReturn<ВыбытиеНМАМеждународныйЗапрос>
	{
	}
	[Маршрут("Документы/ВыбытиеНМАМеждународный/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ВыбытиеНМАМеждународный/ПоСсылке","{Ссылка}")]
	public class ВыбытиеНМАМеждународныйНайтиПоСсылке: V82.ДокументыСсылка.ВыбытиеНМАМеждународный,IReturn<ВыбытиеНМАМеждународныйНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ВыбытиеНМАМеждународный/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ВыбытиеНМАМеждународный/ПоНомеру","{Номер}")]
	public class ВыбытиеНМАМеждународныйНайтиПоНомеру: V82.ДокументыСсылка.ВыбытиеНМАМеждународный,IReturn<ВыбытиеНМАМеждународныйНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ВыбытиеНМАМеждународный/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ВыбытиеНМАМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ВыбытиеНМАМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВыбытиеНМАМеждународныйВыбратьПоСсылке: V82.ДокументыСсылка.ВыбытиеНМАМеждународный,IReturn<ВыбытиеНМАМеждународныйВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ВыбытиеНМАМеждународный/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ВыбытиеНМАМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ВыбытиеНМАМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ВыбытиеНМАМеждународныйВыбратьПоНомеру: V82.ДокументыСсылка.ВыбытиеНМАМеждународный,IReturn<ВыбытиеНМАМеждународныйВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ВыбытиеНМАМеждународный/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВыбытиеНМАМеждународныйСтраницаПоСсылке: V82.ДокументыСсылка.ВыбытиеНМАМеждународный,IReturn<ВыбытиеНМАМеждународныйСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ВыбытиеНМАМеждународный/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ВыбытиеНМАМеждународныйСтраницаПоНомеру: V82.ДокументыСсылка.ВыбытиеНМАМеждународный,IReturn<ВыбытиеНМАМеждународныйСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВыбытиеНМАМеждународныйОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВыбытиеНМАМеждународныйСервис : Service
	{
		
		public object Get(ВыбытиеНМАМеждународныйЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВыбытиеНМАМеждународныйНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ВыбытиеНМАМеждународный.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВыбытиеНМАМеждународныйОтвет() { Ответ = "ВыбытиеНМАМеждународный c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВыбытиеНМАМеждународныйНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ВыбытиеНМАМеждународный.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ВыбытиеНМАМеждународныйОтвет() {Ответ = "ВыбытиеНМАМеждународный c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВыбытиеНМАМеждународныйВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ВыбытиеНМАМеждународный.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВыбытиеНМАМеждународныйВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ВыбытиеНМАМеждународныйСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВыбытиеНМАМеждународныйСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ВыбытиеНМАМеждународныйЗапрос Запрос)
		{
			return new ВыбытиеНМАМеждународныйОтвет {Ответ = "ВыбытиеНМАМеждународный, "};
		}

		public object Post(ВыбытиеНМАМеждународныйЗапрос ЗапросВыбытиеНМАМеждународный)
		{
			var Ссылка = (ДокументыСсылка.ВыбытиеНМАМеждународный)ЗапросВыбытиеНМАМеждународный;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}