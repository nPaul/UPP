﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//VnutrenneePeremeshhenieOsnovnykhSredstvMezhdunarodnyjj
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный","")]
	public class ВнутреннееПеремещениеОсновныхСредствМеждународныйЗапрос: V82.ДокументыСсылка.ВнутреннееПеремещениеОсновныхСредствМеждународный,IReturn<ВнутреннееПеремещениеОсновныхСредствМеждународныйЗапрос>
	{
	}
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/ПоСсылке","{Ссылка}")]
	public class ВнутреннееПеремещениеОсновныхСредствМеждународныйНайтиПоСсылке: V82.ДокументыСсылка.ВнутреннееПеремещениеОсновныхСредствМеждународный,IReturn<ВнутреннееПеремещениеОсновныхСредствМеждународныйНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/ПоНомеру","{Номер}")]
	public class ВнутреннееПеремещениеОсновныхСредствМеждународныйНайтиПоНомеру: V82.ДокументыСсылка.ВнутреннееПеремещениеОсновныхСредствМеждународный,IReturn<ВнутреннееПеремещениеОсновныхСредствМеждународныйНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВнутреннееПеремещениеОсновныхСредствМеждународныйВыбратьПоСсылке: V82.ДокументыСсылка.ВнутреннееПеремещениеОсновныхСредствМеждународный,IReturn<ВнутреннееПеремещениеОсновныхСредствМеждународныйВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ВнутреннееПеремещениеОсновныхСредствМеждународныйВыбратьПоНомеру: V82.ДокументыСсылка.ВнутреннееПеремещениеОсновныхСредствМеждународный,IReturn<ВнутреннееПеремещениеОсновныхСредствМеждународныйВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВнутреннееПеремещениеОсновныхСредствМеждународныйСтраницаПоСсылке: V82.ДокументыСсылка.ВнутреннееПеремещениеОсновныхСредствМеждународный,IReturn<ВнутреннееПеремещениеОсновныхСредствМеждународныйСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ВнутреннееПеремещениеОсновныхСредствМеждународный/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ВнутреннееПеремещениеОсновныхСредствМеждународныйСтраницаПоНомеру: V82.ДокументыСсылка.ВнутреннееПеремещениеОсновныхСредствМеждународный,IReturn<ВнутреннееПеремещениеОсновныхСредствМеждународныйСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВнутреннееПеремещениеОсновныхСредствМеждународныйОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВнутреннееПеремещениеОсновныхСредствМеждународныйСервис : Service
	{
		
		public object Get(ВнутреннееПеремещениеОсновныхСредствМеждународныйЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВнутреннееПеремещениеОсновныхСредствМеждународныйНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ВнутреннееПеремещениеОсновныхСредствМеждународный.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВнутреннееПеремещениеОсновныхСредствМеждународныйОтвет() { Ответ = "ВнутреннееПеремещениеОсновныхСредствМеждународный c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВнутреннееПеремещениеОсновныхСредствМеждународныйНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ВнутреннееПеремещениеОсновныхСредствМеждународный.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ВнутреннееПеремещениеОсновныхСредствМеждународныйОтвет() {Ответ = "ВнутреннееПеремещениеОсновныхСредствМеждународный c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВнутреннееПеремещениеОсновныхСредствМеждународныйВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ВнутреннееПеремещениеОсновныхСредствМеждународный.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВнутреннееПеремещениеОсновныхСредствМеждународныйВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ВнутреннееПеремещениеОсновныхСредствМеждународныйСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВнутреннееПеремещениеОсновныхСредствМеждународныйСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ВнутреннееПеремещениеОсновныхСредствМеждународныйЗапрос Запрос)
		{
			return new ВнутреннееПеремещениеОсновныхСредствМеждународныйОтвет {Ответ = "ВнутреннееПеремещениеОсновныхСредствМеждународный, "};
		}

		public object Post(ВнутреннееПеремещениеОсновныхСредствМеждународныйЗапрос ЗапросВнутреннееПеремещениеОсновныхСредствМеждународный)
		{
			var Ссылка = (ДокументыСсылка.ВнутреннееПеремещениеОсновныхСредствМеждународный)ЗапросВнутреннееПеремещениеОсновныхСредствМеждународный;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}