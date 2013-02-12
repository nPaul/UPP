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
	public class СостоянияЗаявокКандидатов:V82.Rest.СправочникиТест.СправочникТест
	{
		public static СостоянияЗаявокКандидатовЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/СостоянияЗаявокКандидатов/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СостоянияЗаявокКандидатовЗапрос СостоянияЗаявокКандидатовЗапрос = null;
			try
			{
				СостоянияЗаявокКандидатовЗапрос = Клиент.Get(new СостоянияЗаявокКандидатовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СостоянияЗаявокКандидатовЗапрос;
		}
		public static СостоянияЗаявокКандидатовЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/СостоянияЗаявокКандидатов/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СостоянияЗаявокКандидатовЗапрос СостоянияЗаявокКандидатовЗапрос = null;
			try
			{
				СостоянияЗаявокКандидатовЗапрос = Клиент.Get(new СостоянияЗаявокКандидатовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СостоянияЗаявокКандидатовЗапрос;
		}
		public static СостоянияЗаявокКандидатовЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/СостоянияЗаявокКандидатов/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СостоянияЗаявокКандидатовЗапрос СостоянияЗаявокКандидатовЗапрос = null;
			try
			{
				СостоянияЗаявокКандидатовЗапрос = Клиент.Get(new СостоянияЗаявокКандидатовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СостоянияЗаявокКандидатовЗапрос;
		}
		public static void ЗаписатьНовый(СостоянияЗаявокКандидатовЗапрос СостоянияЗаявокКандидатовЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/СостоянияЗаявокКандидатов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СостоянияЗаявокКандидатовОтвет = Клиент.Post(СостоянияЗаявокКандидатовЗапрос);
		}
		public static void Записать(СостоянияЗаявокКандидатовЗапрос СостоянияЗаявокКандидатовЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/СостоянияЗаявокКандидатов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СостоянияЗаявокКандидатовОтвет = Клиент.Put(СостоянияЗаявокКандидатовЗапрос);
		}
		public static void Удалить(СостоянияЗаявокКандидатовЗапрос СостоянияЗаявокКандидатовЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/СостоянияЗаявокКандидатов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СостоянияЗаявокКандидатовОтвет = Клиент.Delete(СостоянияЗаявокКандидатовЗапрос);
		}
	}
}