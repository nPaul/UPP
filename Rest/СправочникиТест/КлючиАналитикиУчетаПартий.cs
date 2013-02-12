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
	public class КлючиАналитикиУчетаПартий:V82.Rest.СправочникиТест.СправочникТест
	{
		public static КлючиАналитикиУчетаПартийЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/КлючиАналитикиУчетаПартий/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			КлючиАналитикиУчетаПартийЗапрос КлючиАналитикиУчетаПартийЗапрос = null;
			try
			{
				КлючиАналитикиУчетаПартийЗапрос = Клиент.Get(new КлючиАналитикиУчетаПартийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return КлючиАналитикиУчетаПартийЗапрос;
		}
		public static КлючиАналитикиУчетаПартийЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/КлючиАналитикиУчетаПартий/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			КлючиАналитикиУчетаПартийЗапрос КлючиАналитикиУчетаПартийЗапрос = null;
			try
			{
				КлючиАналитикиУчетаПартийЗапрос = Клиент.Get(new КлючиАналитикиУчетаПартийЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return КлючиАналитикиУчетаПартийЗапрос;
		}
		public static void ЗаписатьНовый(КлючиАналитикиУчетаПартийЗапрос КлючиАналитикиУчетаПартийЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/КлючиАналитикиУчетаПартий?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var КлючиАналитикиУчетаПартийОтвет = Клиент.Post(КлючиАналитикиУчетаПартийЗапрос);
		}
		public static void Записать(КлючиАналитикиУчетаПартийЗапрос КлючиАналитикиУчетаПартийЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/КлючиАналитикиУчетаПартий?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var КлючиАналитикиУчетаПартийОтвет = Клиент.Put(КлючиАналитикиУчетаПартийЗапрос);
		}
		public static void Удалить(КлючиАналитикиУчетаПартийЗапрос КлючиАналитикиУчетаПартийЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/КлючиАналитикиУчетаПартий?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var КлючиАналитикиУчетаПартийОтвет = Клиент.Delete(КлючиАналитикиУчетаПартийЗапрос);
		}
	}
}