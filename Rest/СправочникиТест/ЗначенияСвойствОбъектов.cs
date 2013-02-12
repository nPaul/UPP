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
	public class ЗначенияСвойствОбъектов:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ЗначенияСвойствОбъектовЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ЗначенияСвойствОбъектов/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ЗначенияСвойствОбъектовЗапрос ЗначенияСвойствОбъектовЗапрос = null;
			try
			{
				ЗначенияСвойствОбъектовЗапрос = Клиент.Get(new ЗначенияСвойствОбъектовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ЗначенияСвойствОбъектовЗапрос;
		}
		public static ЗначенияСвойствОбъектовЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ЗначенияСвойствОбъектов/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ЗначенияСвойствОбъектовЗапрос ЗначенияСвойствОбъектовЗапрос = null;
			try
			{
				ЗначенияСвойствОбъектовЗапрос = Клиент.Get(new ЗначенияСвойствОбъектовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ЗначенияСвойствОбъектовЗапрос;
		}
		public static ЗначенияСвойствОбъектовЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ЗначенияСвойствОбъектов/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ЗначенияСвойствОбъектовЗапрос ЗначенияСвойствОбъектовЗапрос = null;
			try
			{
				ЗначенияСвойствОбъектовЗапрос = Клиент.Get(new ЗначенияСвойствОбъектовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ЗначенияСвойствОбъектовЗапрос;
		}
		public static void ЗаписатьНовый(ЗначенияСвойствОбъектовЗапрос ЗначенияСвойствОбъектовЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ЗначенияСвойствОбъектов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ЗначенияСвойствОбъектовОтвет = Клиент.Post(ЗначенияСвойствОбъектовЗапрос);
		}
		public static void Записать(ЗначенияСвойствОбъектовЗапрос ЗначенияСвойствОбъектовЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ЗначенияСвойствОбъектов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ЗначенияСвойствОбъектовОтвет = Клиент.Put(ЗначенияСвойствОбъектовЗапрос);
		}
		public static void Удалить(ЗначенияСвойствОбъектовЗапрос ЗначенияСвойствОбъектовЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ЗначенияСвойствОбъектов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ЗначенияСвойствОбъектовОтвет = Клиент.Delete(ЗначенияСвойствОбъектовЗапрос);
		}
	}
}