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
	public class СпецификацииНоменклатуры:V82.Rest.СправочникиТест.СправочникТест
	{
		public static СпецификацииНоменклатурыЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/СпецификацииНоменклатуры/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СпецификацииНоменклатурыЗапрос СпецификацииНоменклатурыЗапрос = null;
			try
			{
				СпецификацииНоменклатурыЗапрос = Клиент.Get(new СпецификацииНоменклатурыЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СпецификацииНоменклатурыЗапрос;
		}
		public static СпецификацииНоменклатурыЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/СпецификацииНоменклатуры/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СпецификацииНоменклатурыЗапрос СпецификацииНоменклатурыЗапрос = null;
			try
			{
				СпецификацииНоменклатурыЗапрос = Клиент.Get(new СпецификацииНоменклатурыЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СпецификацииНоменклатурыЗапрос;
		}
		public static СпецификацииНоменклатурыЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/СпецификацииНоменклатуры/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			СпецификацииНоменклатурыЗапрос СпецификацииНоменклатурыЗапрос = null;
			try
			{
				СпецификацииНоменклатурыЗапрос = Клиент.Get(new СпецификацииНоменклатурыЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return СпецификацииНоменклатурыЗапрос;
		}
		public static void ЗаписатьНовый(СпецификацииНоменклатурыЗапрос СпецификацииНоменклатурыЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/СпецификацииНоменклатуры?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СпецификацииНоменклатурыОтвет = Клиент.Post(СпецификацииНоменклатурыЗапрос);
		}
		public static void Записать(СпецификацииНоменклатурыЗапрос СпецификацииНоменклатурыЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/СпецификацииНоменклатуры?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СпецификацииНоменклатурыОтвет = Клиент.Put(СпецификацииНоменклатурыЗапрос);
		}
		public static void Удалить(СпецификацииНоменклатурыЗапрос СпецификацииНоменклатурыЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/СпецификацииНоменклатуры?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var СпецификацииНоменклатурыОтвет = Клиент.Delete(СпецификацииНоменклатурыЗапрос);
		}
	}
}