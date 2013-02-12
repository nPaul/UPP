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
	public class ТехнологическиеОперации:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ТехнологическиеОперацииЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ТехнологическиеОперации/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ТехнологическиеОперацииЗапрос ТехнологическиеОперацииЗапрос = null;
			try
			{
				ТехнологическиеОперацииЗапрос = Клиент.Get(new ТехнологическиеОперацииЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ТехнологическиеОперацииЗапрос;
		}
		public static ТехнологическиеОперацииЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ТехнологическиеОперации/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ТехнологическиеОперацииЗапрос ТехнологическиеОперацииЗапрос = null;
			try
			{
				ТехнологическиеОперацииЗапрос = Клиент.Get(new ТехнологическиеОперацииЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ТехнологическиеОперацииЗапрос;
		}
		public static ТехнологическиеОперацииЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ТехнологическиеОперации/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ТехнологическиеОперацииЗапрос ТехнологическиеОперацииЗапрос = null;
			try
			{
				ТехнологическиеОперацииЗапрос = Клиент.Get(new ТехнологическиеОперацииЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ТехнологическиеОперацииЗапрос;
		}
		public static void ЗаписатьНовый(ТехнологическиеОперацииЗапрос ТехнологическиеОперацииЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ТехнологическиеОперации?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ТехнологическиеОперацииОтвет = Клиент.Post(ТехнологическиеОперацииЗапрос);
		}
		public static void Записать(ТехнологическиеОперацииЗапрос ТехнологическиеОперацииЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ТехнологическиеОперации?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ТехнологическиеОперацииОтвет = Клиент.Put(ТехнологическиеОперацииЗапрос);
		}
		public static void Удалить(ТехнологическиеОперацииЗапрос ТехнологическиеОперацииЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ТехнологическиеОперации?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ТехнологическиеОперацииОтвет = Клиент.Delete(ТехнологическиеОперацииЗапрос);
		}
	}
}