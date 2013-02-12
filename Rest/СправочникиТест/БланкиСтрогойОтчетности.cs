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
	public class БланкиСтрогойОтчетности:V82.Rest.СправочникиТест.СправочникТест
	{
		public static БланкиСтрогойОтчетностиЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/БланкиСтрогойОтчетности/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			БланкиСтрогойОтчетностиЗапрос БланкиСтрогойОтчетностиЗапрос = null;
			try
			{
				БланкиСтрогойОтчетностиЗапрос = Клиент.Get(new БланкиСтрогойОтчетностиЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return БланкиСтрогойОтчетностиЗапрос;
		}
		public static БланкиСтрогойОтчетностиЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/БланкиСтрогойОтчетности/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			БланкиСтрогойОтчетностиЗапрос БланкиСтрогойОтчетностиЗапрос = null;
			try
			{
				БланкиСтрогойОтчетностиЗапрос = Клиент.Get(new БланкиСтрогойОтчетностиЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return БланкиСтрогойОтчетностиЗапрос;
		}
		public static БланкиСтрогойОтчетностиЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/БланкиСтрогойОтчетности/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			БланкиСтрогойОтчетностиЗапрос БланкиСтрогойОтчетностиЗапрос = null;
			try
			{
				БланкиСтрогойОтчетностиЗапрос = Клиент.Get(new БланкиСтрогойОтчетностиЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return БланкиСтрогойОтчетностиЗапрос;
		}
		public static void ЗаписатьНовый(БланкиСтрогойОтчетностиЗапрос БланкиСтрогойОтчетностиЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/БланкиСтрогойОтчетности?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var БланкиСтрогойОтчетностиОтвет = Клиент.Post(БланкиСтрогойОтчетностиЗапрос);
		}
		public static void Записать(БланкиСтрогойОтчетностиЗапрос БланкиСтрогойОтчетностиЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/БланкиСтрогойОтчетности?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var БланкиСтрогойОтчетностиОтвет = Клиент.Put(БланкиСтрогойОтчетностиЗапрос);
		}
		public static void Удалить(БланкиСтрогойОтчетностиЗапрос БланкиСтрогойОтчетностиЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/БланкиСтрогойОтчетности?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var БланкиСтрогойОтчетностиОтвет = Клиент.Delete(БланкиСтрогойОтчетностиЗапрос);
		}
	}
}