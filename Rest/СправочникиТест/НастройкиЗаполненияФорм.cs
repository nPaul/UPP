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
	public class НастройкиЗаполненияФорм:V82.Rest.СправочникиТест.СправочникТест
	{
		public static НастройкиЗаполненияФормЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/НастройкиЗаполненияФорм/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			НастройкиЗаполненияФормЗапрос НастройкиЗаполненияФормЗапрос = null;
			try
			{
				НастройкиЗаполненияФормЗапрос = Клиент.Get(new НастройкиЗаполненияФормЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return НастройкиЗаполненияФормЗапрос;
		}
		public static НастройкиЗаполненияФормЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/НастройкиЗаполненияФорм/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			НастройкиЗаполненияФормЗапрос НастройкиЗаполненияФормЗапрос = null;
			try
			{
				НастройкиЗаполненияФормЗапрос = Клиент.Get(new НастройкиЗаполненияФормЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return НастройкиЗаполненияФормЗапрос;
		}
		public static void ЗаписатьНовый(НастройкиЗаполненияФормЗапрос НастройкиЗаполненияФормЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/НастройкиЗаполненияФорм?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var НастройкиЗаполненияФормОтвет = Клиент.Post(НастройкиЗаполненияФормЗапрос);
		}
		public static void Записать(НастройкиЗаполненияФормЗапрос НастройкиЗаполненияФормЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/НастройкиЗаполненияФорм?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var НастройкиЗаполненияФормОтвет = Клиент.Put(НастройкиЗаполненияФормЗапрос);
		}
		public static void Удалить(НастройкиЗаполненияФормЗапрос НастройкиЗаполненияФормЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/НастройкиЗаполненияФорм?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var НастройкиЗаполненияФормОтвет = Клиент.Delete(НастройкиЗаполненияФормЗапрос);
		}
	}
}