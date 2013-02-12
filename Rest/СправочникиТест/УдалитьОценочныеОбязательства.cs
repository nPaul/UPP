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
	public class УдалитьОценочныеОбязательства:V82.Rest.СправочникиТест.СправочникТест
	{
		public static УдалитьОценочныеОбязательстваЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/УдалитьОценочныеОбязательства/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			УдалитьОценочныеОбязательстваЗапрос УдалитьОценочныеОбязательстваЗапрос = null;
			try
			{
				УдалитьОценочныеОбязательстваЗапрос = Клиент.Get(new УдалитьОценочныеОбязательстваЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return УдалитьОценочныеОбязательстваЗапрос;
		}
		public static УдалитьОценочныеОбязательстваЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/УдалитьОценочныеОбязательства/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			УдалитьОценочныеОбязательстваЗапрос УдалитьОценочныеОбязательстваЗапрос = null;
			try
			{
				УдалитьОценочныеОбязательстваЗапрос = Клиент.Get(new УдалитьОценочныеОбязательстваЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return УдалитьОценочныеОбязательстваЗапрос;
		}
		public static УдалитьОценочныеОбязательстваЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/УдалитьОценочныеОбязательства/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			УдалитьОценочныеОбязательстваЗапрос УдалитьОценочныеОбязательстваЗапрос = null;
			try
			{
				УдалитьОценочныеОбязательстваЗапрос = Клиент.Get(new УдалитьОценочныеОбязательстваЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return УдалитьОценочныеОбязательстваЗапрос;
		}
		public static void ЗаписатьНовый(УдалитьОценочныеОбязательстваЗапрос УдалитьОценочныеОбязательстваЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/УдалитьОценочныеОбязательства?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var УдалитьОценочныеОбязательстваОтвет = Клиент.Post(УдалитьОценочныеОбязательстваЗапрос);
		}
		public static void Записать(УдалитьОценочныеОбязательстваЗапрос УдалитьОценочныеОбязательстваЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/УдалитьОценочныеОбязательства?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var УдалитьОценочныеОбязательстваОтвет = Клиент.Put(УдалитьОценочныеОбязательстваЗапрос);
		}
		public static void Удалить(УдалитьОценочныеОбязательстваЗапрос УдалитьОценочныеОбязательстваЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/УдалитьОценочныеОбязательства?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var УдалитьОценочныеОбязательстваОтвет = Клиент.Delete(УдалитьОценочныеОбязательстваЗапрос);
		}
	}
}