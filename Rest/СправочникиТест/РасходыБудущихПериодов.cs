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
	public class РасходыБудущихПериодов:V82.Rest.СправочникиТест.СправочникТест
	{
		public static РасходыБудущихПериодовЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/РасходыБудущихПериодов/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			РасходыБудущихПериодовЗапрос РасходыБудущихПериодовЗапрос = null;
			try
			{
				РасходыБудущихПериодовЗапрос = Клиент.Get(new РасходыБудущихПериодовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return РасходыБудущихПериодовЗапрос;
		}
		public static РасходыБудущихПериодовЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/РасходыБудущихПериодов/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			РасходыБудущихПериодовЗапрос РасходыБудущихПериодовЗапрос = null;
			try
			{
				РасходыБудущихПериодовЗапрос = Клиент.Get(new РасходыБудущихПериодовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return РасходыБудущихПериодовЗапрос;
		}
		public static РасходыБудущихПериодовЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/РасходыБудущихПериодов/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			РасходыБудущихПериодовЗапрос РасходыБудущихПериодовЗапрос = null;
			try
			{
				РасходыБудущихПериодовЗапрос = Клиент.Get(new РасходыБудущихПериодовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return РасходыБудущихПериодовЗапрос;
		}
		public static void ЗаписатьНовый(РасходыБудущихПериодовЗапрос РасходыБудущихПериодовЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/РасходыБудущихПериодов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var РасходыБудущихПериодовОтвет = Клиент.Post(РасходыБудущихПериодовЗапрос);
		}
		public static void Записать(РасходыБудущихПериодовЗапрос РасходыБудущихПериодовЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/РасходыБудущихПериодов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var РасходыБудущихПериодовОтвет = Клиент.Put(РасходыБудущихПериодовЗапрос);
		}
		public static void Удалить(РасходыБудущихПериодовЗапрос РасходыБудущихПериодовЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/РасходыБудущихПериодов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var РасходыБудущихПериодовОтвет = Клиент.Delete(РасходыБудущихПериодовЗапрос);
		}
	}
}