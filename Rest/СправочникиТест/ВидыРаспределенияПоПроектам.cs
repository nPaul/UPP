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
	public class ВидыРаспределенияПоПроектам:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ВидыРаспределенияПоПроектамЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыРаспределенияПоПроектам/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ВидыРаспределенияПоПроектамЗапрос ВидыРаспределенияПоПроектамЗапрос = null;
			try
			{
				ВидыРаспределенияПоПроектамЗапрос = Клиент.Get(new ВидыРаспределенияПоПроектамЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ВидыРаспределенияПоПроектамЗапрос;
		}
		public static ВидыРаспределенияПоПроектамЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыРаспределенияПоПроектам/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ВидыРаспределенияПоПроектамЗапрос ВидыРаспределенияПоПроектамЗапрос = null;
			try
			{
				ВидыРаспределенияПоПроектамЗапрос = Клиент.Get(new ВидыРаспределенияПоПроектамЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ВидыРаспределенияПоПроектамЗапрос;
		}
		public static ВидыРаспределенияПоПроектамЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыРаспределенияПоПроектам/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ВидыРаспределенияПоПроектамЗапрос ВидыРаспределенияПоПроектамЗапрос = null;
			try
			{
				ВидыРаспределенияПоПроектамЗапрос = Клиент.Get(new ВидыРаспределенияПоПроектамЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ВидыРаспределенияПоПроектамЗапрос;
		}
		public static void ЗаписатьНовый(ВидыРаспределенияПоПроектамЗапрос ВидыРаспределенияПоПроектамЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыРаспределенияПоПроектам?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ВидыРаспределенияПоПроектамОтвет = Клиент.Post(ВидыРаспределенияПоПроектамЗапрос);
		}
		public static void Записать(ВидыРаспределенияПоПроектамЗапрос ВидыРаспределенияПоПроектамЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыРаспределенияПоПроектам?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ВидыРаспределенияПоПроектамОтвет = Клиент.Put(ВидыРаспределенияПоПроектамЗапрос);
		}
		public static void Удалить(ВидыРаспределенияПоПроектамЗапрос ВидыРаспределенияПоПроектамЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыРаспределенияПоПроектам?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ВидыРаспределенияПоПроектамОтвет = Клиент.Delete(ВидыРаспределенияПоПроектамЗапрос);
		}
	}
}