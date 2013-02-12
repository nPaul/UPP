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
	public class ДоходыПоСтраховымВзносам:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ДоходыПоСтраховымВзносамЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ДоходыПоСтраховымВзносам/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ДоходыПоСтраховымВзносамЗапрос ДоходыПоСтраховымВзносамЗапрос = null;
			try
			{
				ДоходыПоСтраховымВзносамЗапрос = Клиент.Get(new ДоходыПоСтраховымВзносамЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ДоходыПоСтраховымВзносамЗапрос;
		}
		public static ДоходыПоСтраховымВзносамЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ДоходыПоСтраховымВзносам/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ДоходыПоСтраховымВзносамЗапрос ДоходыПоСтраховымВзносамЗапрос = null;
			try
			{
				ДоходыПоСтраховымВзносамЗапрос = Клиент.Get(new ДоходыПоСтраховымВзносамЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ДоходыПоСтраховымВзносамЗапрос;
		}
		public static void ЗаписатьНовый(ДоходыПоСтраховымВзносамЗапрос ДоходыПоСтраховымВзносамЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ДоходыПоСтраховымВзносам?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ДоходыПоСтраховымВзносамОтвет = Клиент.Post(ДоходыПоСтраховымВзносамЗапрос);
		}
		public static void Записать(ДоходыПоСтраховымВзносамЗапрос ДоходыПоСтраховымВзносамЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ДоходыПоСтраховымВзносам?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ДоходыПоСтраховымВзносамОтвет = Клиент.Put(ДоходыПоСтраховымВзносамЗапрос);
		}
		public static void Удалить(ДоходыПоСтраховымВзносамЗапрос ДоходыПоСтраховымВзносамЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ДоходыПоСтраховымВзносам?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ДоходыПоСтраховымВзносамОтвет = Клиент.Delete(ДоходыПоСтраховымВзносамЗапрос);
		}
	}
}