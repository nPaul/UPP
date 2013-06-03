﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//ObescenenieAktivovMezhdunarodnyjj
	[Маршрут("Документы/ОбесценениеАктивовМеждународный","")]
	public class ОбесценениеАктивовМеждународныйЗапрос: V82.ДокументыСсылка.ОбесценениеАктивовМеждународный,IReturn<ОбесценениеАктивовМеждународныйЗапрос>
	{
	}
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/ПоСсылке","{Ссылка}")]
	public class ОбесценениеАктивовМеждународныйНайтиПоСсылке: V82.ДокументыСсылка.ОбесценениеАктивовМеждународный,IReturn<ОбесценениеАктивовМеждународныйНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/ПоНомеру","{Номер}")]
	public class ОбесценениеАктивовМеждународныйНайтиПоНомеру: V82.ДокументыСсылка.ОбесценениеАктивовМеждународный,IReturn<ОбесценениеАктивовМеждународныйНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбесценениеАктивовМеждународныйВыбратьПоСсылке: V82.ДокументыСсылка.ОбесценениеАктивовМеждународный,IReturn<ОбесценениеАктивовМеждународныйВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбесценениеАктивовМеждународныйВыбратьПоНомеру: V82.ДокументыСсылка.ОбесценениеАктивовМеждународный,IReturn<ОбесценениеАктивовМеждународныйВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОбесценениеАктивовМеждународныйСтраницаПоСсылке: V82.ДокументыСсылка.ОбесценениеАктивовМеждународный,IReturn<ОбесценениеАктивовМеждународныйСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ОбесценениеАктивовМеждународный/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ОбесценениеАктивовМеждународныйСтраницаПоНомеру: V82.ДокументыСсылка.ОбесценениеАктивовМеждународный,IReturn<ОбесценениеАктивовМеждународныйСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОбесценениеАктивовМеждународныйОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОбесценениеАктивовМеждународныйСервис : Service
	{
		
		public object Get(ОбесценениеАктивовМеждународныйЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОбесценениеАктивовМеждународныйНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ОбесценениеАктивовМеждународный.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ОбесценениеАктивовМеждународныйОтвет() { Ответ = "ОбесценениеАктивовМеждународный c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОбесценениеАктивовМеждународныйНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ОбесценениеАктивовМеждународный.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ОбесценениеАктивовМеждународныйОтвет() {Ответ = "ОбесценениеАктивовМеждународный c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОбесценениеАктивовМеждународныйВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ОбесценениеАктивовМеждународный.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОбесценениеАктивовМеждународныйВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ОбесценениеАктивовМеждународныйСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОбесценениеАктивовМеждународныйСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ОбесценениеАктивовМеждународныйЗапрос Запрос)
		{
			return new ОбесценениеАктивовМеждународныйОтвет {Ответ = "ОбесценениеАктивовМеждународный, "};
		}

		public object Post(ОбесценениеАктивовМеждународныйЗапрос ЗапросОбесценениеАктивовМеждународный)
		{
			var Ссылка = (ДокументыСсылка.ОбесценениеАктивовМеждународный)ЗапросОбесценениеАктивовМеждународный;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}