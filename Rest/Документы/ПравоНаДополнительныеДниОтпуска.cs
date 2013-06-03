﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PravoNaDopolnitelnyeDniOtpuska
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска","")]
	public class ПравоНаДополнительныеДниОтпускаЗапрос: V82.ДокументыСсылка.ПравоНаДополнительныеДниОтпуска,IReturn<ПравоНаДополнительныеДниОтпускаЗапрос>
	{
	}
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/ПоСсылке","{Ссылка}")]
	public class ПравоНаДополнительныеДниОтпускаНайтиПоСсылке: V82.ДокументыСсылка.ПравоНаДополнительныеДниОтпуска,IReturn<ПравоНаДополнительныеДниОтпускаНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/ПоНомеру","{Номер}")]
	public class ПравоНаДополнительныеДниОтпускаНайтиПоНомеру: V82.ДокументыСсылка.ПравоНаДополнительныеДниОтпуска,IReturn<ПравоНаДополнительныеДниОтпускаНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПравоНаДополнительныеДниОтпускаВыбратьПоСсылке: V82.ДокументыСсылка.ПравоНаДополнительныеДниОтпуска,IReturn<ПравоНаДополнительныеДниОтпускаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПравоНаДополнительныеДниОтпускаВыбратьПоНомеру: V82.ДокументыСсылка.ПравоНаДополнительныеДниОтпуска,IReturn<ПравоНаДополнительныеДниОтпускаВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПравоНаДополнительныеДниОтпускаСтраницаПоСсылке: V82.ДокументыСсылка.ПравоНаДополнительныеДниОтпуска,IReturn<ПравоНаДополнительныеДниОтпускаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПравоНаДополнительныеДниОтпуска/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПравоНаДополнительныеДниОтпускаСтраницаПоНомеру: V82.ДокументыСсылка.ПравоНаДополнительныеДниОтпуска,IReturn<ПравоНаДополнительныеДниОтпускаСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПравоНаДополнительныеДниОтпускаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПравоНаДополнительныеДниОтпускаСервис : Service
	{
		
		public object Get(ПравоНаДополнительныеДниОтпускаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПравоНаДополнительныеДниОтпускаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПравоНаДополнительныеДниОтпуска.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПравоНаДополнительныеДниОтпускаОтвет() { Ответ = "ПравоНаДополнительныеДниОтпуска c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПравоНаДополнительныеДниОтпускаНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПравоНаДополнительныеДниОтпуска.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПравоНаДополнительныеДниОтпускаОтвет() {Ответ = "ПравоНаДополнительныеДниОтпуска c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПравоНаДополнительныеДниОтпускаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПравоНаДополнительныеДниОтпуска.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПравоНаДополнительныеДниОтпускаВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПравоНаДополнительныеДниОтпускаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПравоНаДополнительныеДниОтпускаСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПравоНаДополнительныеДниОтпускаЗапрос Запрос)
		{
			return new ПравоНаДополнительныеДниОтпускаОтвет {Ответ = "ПравоНаДополнительныеДниОтпуска, "};
		}

		public object Post(ПравоНаДополнительныеДниОтпускаЗапрос ЗапросПравоНаДополнительныеДниОтпуска)
		{
			var Ссылка = (ДокументыСсылка.ПравоНаДополнительныеДниОтпуска)ЗапросПравоНаДополнительныеДниОтпуска;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}