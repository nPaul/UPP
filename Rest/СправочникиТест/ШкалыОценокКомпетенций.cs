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
	public class ШкалыОценокКомпетенций:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ШкалыОценокКомпетенцийЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ШкалыОценокКомпетенций/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ШкалыОценокКомпетенцийЗапрос ШкалыОценокКомпетенцийЗапрос = null;
			try
			{
				ШкалыОценокКомпетенцийЗапрос = Клиент.Get(new ШкалыОценокКомпетенцийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ШкалыОценокКомпетенцийЗапрос;
		}
		public static ШкалыОценокКомпетенцийЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ШкалыОценокКомпетенций/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ШкалыОценокКомпетенцийЗапрос ШкалыОценокКомпетенцийЗапрос = null;
			try
			{
				ШкалыОценокКомпетенцийЗапрос = Клиент.Get(new ШкалыОценокКомпетенцийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ШкалыОценокКомпетенцийЗапрос;
		}
		public static ШкалыОценокКомпетенцийЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ШкалыОценокКомпетенций/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ШкалыОценокКомпетенцийЗапрос ШкалыОценокКомпетенцийЗапрос = null;
			try
			{
				ШкалыОценокКомпетенцийЗапрос = Клиент.Get(new ШкалыОценокКомпетенцийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ШкалыОценокКомпетенцийЗапрос;
		}
		public static void ЗаписатьНовый(ШкалыОценокКомпетенцийЗапрос ШкалыОценокКомпетенцийЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ШкалыОценокКомпетенций?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ШкалыОценокКомпетенцийОтвет = Клиент.Post(ШкалыОценокКомпетенцийЗапрос);
		}
		public static void Записать(ШкалыОценокКомпетенцийЗапрос ШкалыОценокКомпетенцийЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ШкалыОценокКомпетенций?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ШкалыОценокКомпетенцийОтвет = Клиент.Put(ШкалыОценокКомпетенцийЗапрос);
		}
		public static void Удалить(ШкалыОценокКомпетенцийЗапрос ШкалыОценокКомпетенцийЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ШкалыОценокКомпетенций?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ШкалыОценокКомпетенцийОтвет = Клиент.Delete(ШкалыОценокКомпетенцийЗапрос);
		}
	}
}