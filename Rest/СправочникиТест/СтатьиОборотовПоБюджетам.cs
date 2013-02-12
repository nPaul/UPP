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
	public class СтатьиОборотовПоБюджетам:V82.Rest.СправочникиТест.СправочникТест
	{
		public static СтатьиОборотовПоБюджетамЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/СтатьиОборотовПоБюджетам/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СтатьиОборотовПоБюджетамЗапрос СтатьиОборотовПоБюджетамЗапрос = null;
			try
			{
				СтатьиОборотовПоБюджетамЗапрос = Клиент.Get(new СтатьиОборотовПоБюджетамЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СтатьиОборотовПоБюджетамЗапрос;
		}
		public static СтатьиОборотовПоБюджетамЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/СтатьиОборотовПоБюджетам/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СтатьиОборотовПоБюджетамЗапрос СтатьиОборотовПоБюджетамЗапрос = null;
			try
			{
				СтатьиОборотовПоБюджетамЗапрос = Клиент.Get(new СтатьиОборотовПоБюджетамЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СтатьиОборотовПоБюджетамЗапрос;
		}
		public static СтатьиОборотовПоБюджетамЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/СтатьиОборотовПоБюджетам/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СтатьиОборотовПоБюджетамЗапрос СтатьиОборотовПоБюджетамЗапрос = null;
			try
			{
				СтатьиОборотовПоБюджетамЗапрос = Клиент.Get(new СтатьиОборотовПоБюджетамЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СтатьиОборотовПоБюджетамЗапрос;
		}
		public static void ЗаписатьНовый(СтатьиОборотовПоБюджетамЗапрос СтатьиОборотовПоБюджетамЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/СтатьиОборотовПоБюджетам?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СтатьиОборотовПоБюджетамОтвет = Клиент.Post(СтатьиОборотовПоБюджетамЗапрос);
		}
		public static void Записать(СтатьиОборотовПоБюджетамЗапрос СтатьиОборотовПоБюджетамЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/СтатьиОборотовПоБюджетам?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СтатьиОборотовПоБюджетамОтвет = Клиент.Put(СтатьиОборотовПоБюджетамЗапрос);
		}
		public static void Удалить(СтатьиОборотовПоБюджетамЗапрос СтатьиОборотовПоБюджетамЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/СтатьиОборотовПоБюджетам?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СтатьиОборотовПоБюджетамОтвет = Клиент.Delete(СтатьиОборотовПоБюджетамЗапрос);
		}
	}
}