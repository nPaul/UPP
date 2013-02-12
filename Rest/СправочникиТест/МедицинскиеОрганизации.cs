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
	public class МедицинскиеОрганизации:V82.Rest.СправочникиТест.СправочникТест
	{
		public static МедицинскиеОрганизацииЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/МедицинскиеОрганизации/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			МедицинскиеОрганизацииЗапрос МедицинскиеОрганизацииЗапрос = null;
			try
			{
				МедицинскиеОрганизацииЗапрос = Клиент.Get(new МедицинскиеОрганизацииЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return МедицинскиеОрганизацииЗапрос;
		}
		public static МедицинскиеОрганизацииЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/МедицинскиеОрганизации/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			МедицинскиеОрганизацииЗапрос МедицинскиеОрганизацииЗапрос = null;
			try
			{
				МедицинскиеОрганизацииЗапрос = Клиент.Get(new МедицинскиеОрганизацииЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return МедицинскиеОрганизацииЗапрос;
		}
		public static МедицинскиеОрганизацииЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/МедицинскиеОрганизации/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			МедицинскиеОрганизацииЗапрос МедицинскиеОрганизацииЗапрос = null;
			try
			{
				МедицинскиеОрганизацииЗапрос = Клиент.Get(new МедицинскиеОрганизацииЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return МедицинскиеОрганизацииЗапрос;
		}
		public static void ЗаписатьНовый(МедицинскиеОрганизацииЗапрос МедицинскиеОрганизацииЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/МедицинскиеОрганизации?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var МедицинскиеОрганизацииОтвет = Клиент.Post(МедицинскиеОрганизацииЗапрос);
		}
		public static void Записать(МедицинскиеОрганизацииЗапрос МедицинскиеОрганизацииЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/МедицинскиеОрганизации?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var МедицинскиеОрганизацииОтвет = Клиент.Put(МедицинскиеОрганизацииЗапрос);
		}
		public static void Удалить(МедицинскиеОрганизацииЗапрос МедицинскиеОрганизацииЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/МедицинскиеОрганизации?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var МедицинскиеОрганизацииОтвет = Клиент.Delete(МедицинскиеОрганизацииЗапрос);
		}
	}
}