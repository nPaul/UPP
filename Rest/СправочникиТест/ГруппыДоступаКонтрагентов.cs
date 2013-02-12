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
	public class ГруппыДоступаКонтрагентов:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ГруппыДоступаКонтрагентовЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыДоступаКонтрагентов/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ГруппыДоступаКонтрагентовЗапрос ГруппыДоступаКонтрагентовЗапрос = null;
			try
			{
				ГруппыДоступаКонтрагентовЗапрос = Клиент.Get(new ГруппыДоступаКонтрагентовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ГруппыДоступаКонтрагентовЗапрос;
		}
		public static ГруппыДоступаКонтрагентовЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыДоступаКонтрагентов/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ГруппыДоступаКонтрагентовЗапрос ГруппыДоступаКонтрагентовЗапрос = null;
			try
			{
				ГруппыДоступаКонтрагентовЗапрос = Клиент.Get(new ГруппыДоступаКонтрагентовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ГруппыДоступаКонтрагентовЗапрос;
		}
		public static ГруппыДоступаКонтрагентовЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыДоступаКонтрагентов/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ГруппыДоступаКонтрагентовЗапрос ГруппыДоступаКонтрагентовЗапрос = null;
			try
			{
				ГруппыДоступаКонтрагентовЗапрос = Клиент.Get(new ГруппыДоступаКонтрагентовЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ГруппыДоступаКонтрагентовЗапрос;
		}
		public static void ЗаписатьНовый(ГруппыДоступаКонтрагентовЗапрос ГруппыДоступаКонтрагентовЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыДоступаКонтрагентов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ГруппыДоступаКонтрагентовОтвет = Клиент.Post(ГруппыДоступаКонтрагентовЗапрос);
		}
		public static void Записать(ГруппыДоступаКонтрагентовЗапрос ГруппыДоступаКонтрагентовЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыДоступаКонтрагентов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ГруппыДоступаКонтрагентовОтвет = Клиент.Put(ГруппыДоступаКонтрагентовЗапрос);
		}
		public static void Удалить(ГруппыДоступаКонтрагентовЗапрос ГруппыДоступаКонтрагентовЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыДоступаКонтрагентов?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ГруппыДоступаКонтрагентовОтвет = Клиент.Delete(ГруппыДоступаКонтрагентовЗапрос);
		}
	}
}