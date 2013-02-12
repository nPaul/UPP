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
	public class СотрудникиОрганизаций:V82.Rest.СправочникиТест.СправочникТест
	{
		public static СотрудникиОрганизацийЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/СотрудникиОрганизаций/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СотрудникиОрганизацийЗапрос СотрудникиОрганизацийЗапрос = null;
			try
			{
				СотрудникиОрганизацийЗапрос = Клиент.Get(new СотрудникиОрганизацийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СотрудникиОрганизацийЗапрос;
		}
		public static СотрудникиОрганизацийЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/СотрудникиОрганизаций/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СотрудникиОрганизацийЗапрос СотрудникиОрганизацийЗапрос = null;
			try
			{
				СотрудникиОрганизацийЗапрос = Клиент.Get(new СотрудникиОрганизацийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СотрудникиОрганизацийЗапрос;
		}
		public static СотрудникиОрганизацийЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/СотрудникиОрганизаций/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СотрудникиОрганизацийЗапрос СотрудникиОрганизацийЗапрос = null;
			try
			{
				СотрудникиОрганизацийЗапрос = Клиент.Get(new СотрудникиОрганизацийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СотрудникиОрганизацийЗапрос;
		}
		public static void ЗаписатьНовый(СотрудникиОрганизацийЗапрос СотрудникиОрганизацийЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/СотрудникиОрганизаций?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СотрудникиОрганизацийОтвет = Клиент.Post(СотрудникиОрганизацийЗапрос);
		}
		public static void Записать(СотрудникиОрганизацийЗапрос СотрудникиОрганизацийЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/СотрудникиОрганизаций?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СотрудникиОрганизацийОтвет = Клиент.Put(СотрудникиОрганизацийЗапрос);
		}
		public static void Удалить(СотрудникиОрганизацийЗапрос СотрудникиОрганизацийЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/СотрудникиОрганизаций?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СотрудникиОрганизацийОтвет = Клиент.Delete(СотрудникиОрганизацийЗапрос);
		}
	}
}