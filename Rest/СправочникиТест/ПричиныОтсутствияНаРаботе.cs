﻿
using System;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceClient.Web;
using V82.Справочники;

namespace V82.Rest.СправочникиТест
{
	public class ПричиныОтсутствияНаРаботе:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ПричиныОтсутствияНаРаботеЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ПричиныОтсутствияНаРаботе/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ПричиныОтсутствияНаРаботеЗапрос ПричиныОтсутствияНаРаботеЗапрос = null;
			try
			{
				ПричиныОтсутствияНаРаботеЗапрос = Клиент.Get(new ПричиныОтсутствияНаРаботеЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ПричиныОтсутствияНаРаботеЗапрос;
		}
		public static ПричиныОтсутствияНаРаботеЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ПричиныОтсутствияНаРаботе/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ПричиныОтсутствияНаРаботеЗапрос ПричиныОтсутствияНаРаботеЗапрос = null;
			try
			{
				ПричиныОтсутствияНаРаботеЗапрос = Клиент.Get(new ПричиныОтсутствияНаРаботеЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ПричиныОтсутствияНаРаботеЗапрос;
		}
		public static ПричиныОтсутствияНаРаботеЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ПричиныОтсутствияНаРаботе/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ПричиныОтсутствияНаРаботеЗапрос ПричиныОтсутствияНаРаботеЗапрос = null;
			try
			{
				ПричиныОтсутствияНаРаботеЗапрос = Клиент.Get(new ПричиныОтсутствияНаРаботеЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ПричиныОтсутствияНаРаботеЗапрос;
		}
		public static void ЗаписатьНовый(ПричиныОтсутствияНаРаботеЗапрос ПричиныОтсутствияНаРаботеЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ПричиныОтсутствияНаРаботе?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ПричиныОтсутствияНаРаботеОтвет = Клиент.Post(ПричиныОтсутствияНаРаботеЗапрос);
		}
		public static void Записать(ПричиныОтсутствияНаРаботеЗапрос ПричиныОтсутствияНаРаботеЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ПричиныОтсутствияНаРаботе?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ПричиныОтсутствияНаРаботеОтвет = Клиент.Put(ПричиныОтсутствияНаРаботеЗапрос);
		}
		public static void Удалить(ПричиныОтсутствияНаРаботеЗапрос ПричиныОтсутствияНаРаботеЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ПричиныОтсутствияНаРаботе?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ПричиныОтсутствияНаРаботеОтвет = Клиент.Delete(ПричиныОтсутствияНаРаботеЗапрос);
		}
	}
}