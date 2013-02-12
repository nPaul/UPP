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
	public class ВидыАлкогольнойПродукции:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ВидыАлкогольнойПродукцииЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыАлкогольнойПродукции/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ВидыАлкогольнойПродукцииЗапрос ВидыАлкогольнойПродукцииЗапрос = null;
			try
			{
				ВидыАлкогольнойПродукцииЗапрос = Клиент.Get(new ВидыАлкогольнойПродукцииЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ВидыАлкогольнойПродукцииЗапрос;
		}
		public static ВидыАлкогольнойПродукцииЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыАлкогольнойПродукции/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ВидыАлкогольнойПродукцииЗапрос ВидыАлкогольнойПродукцииЗапрос = null;
			try
			{
				ВидыАлкогольнойПродукцииЗапрос = Клиент.Get(new ВидыАлкогольнойПродукцииЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ВидыАлкогольнойПродукцииЗапрос;
		}
		public static ВидыАлкогольнойПродукцииЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыАлкогольнойПродукции/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ВидыАлкогольнойПродукцииЗапрос ВидыАлкогольнойПродукцииЗапрос = null;
			try
			{
				ВидыАлкогольнойПродукцииЗапрос = Клиент.Get(new ВидыАлкогольнойПродукцииЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ВидыАлкогольнойПродукцииЗапрос;
		}
		public static void ЗаписатьНовый(ВидыАлкогольнойПродукцииЗапрос ВидыАлкогольнойПродукцииЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыАлкогольнойПродукции?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ВидыАлкогольнойПродукцииОтвет = Клиент.Post(ВидыАлкогольнойПродукцииЗапрос);
		}
		public static void Записать(ВидыАлкогольнойПродукцииЗапрос ВидыАлкогольнойПродукцииЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыАлкогольнойПродукции?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ВидыАлкогольнойПродукцииОтвет = Клиент.Put(ВидыАлкогольнойПродукцииЗапрос);
		}
		public static void Удалить(ВидыАлкогольнойПродукцииЗапрос ВидыАлкогольнойПродукцииЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыАлкогольнойПродукции?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ВидыАлкогольнойПродукцииОтвет = Клиент.Delete(ВидыАлкогольнойПродукцииЗапрос);
		}
	}
}