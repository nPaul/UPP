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
	public class ГруппыПочтовойРассылки:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ГруппыПочтовойРассылкиЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыПочтовойРассылки/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ГруппыПочтовойРассылкиЗапрос ГруппыПочтовойРассылкиЗапрос = null;
			try
			{
				ГруппыПочтовойРассылкиЗапрос = Клиент.Get(new ГруппыПочтовойРассылкиЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ГруппыПочтовойРассылкиЗапрос;
		}
		public static ГруппыПочтовойРассылкиЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыПочтовойРассылки/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ГруппыПочтовойРассылкиЗапрос ГруппыПочтовойРассылкиЗапрос = null;
			try
			{
				ГруппыПочтовойРассылкиЗапрос = Клиент.Get(new ГруппыПочтовойРассылкиЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ГруппыПочтовойРассылкиЗапрос;
		}
		public static ГруппыПочтовойРассылкиЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыПочтовойРассылки/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ГруппыПочтовойРассылкиЗапрос ГруппыПочтовойРассылкиЗапрос = null;
			try
			{
				ГруппыПочтовойРассылкиЗапрос = Клиент.Get(new ГруппыПочтовойРассылкиЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ГруппыПочтовойРассылкиЗапрос;
		}
		public static void ЗаписатьНовый(ГруппыПочтовойРассылкиЗапрос ГруппыПочтовойРассылкиЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыПочтовойРассылки?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ГруппыПочтовойРассылкиОтвет = Клиент.Post(ГруппыПочтовойРассылкиЗапрос);
		}
		public static void Записать(ГруппыПочтовойРассылкиЗапрос ГруппыПочтовойРассылкиЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыПочтовойРассылки?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ГруппыПочтовойРассылкиОтвет = Клиент.Put(ГруппыПочтовойРассылкиЗапрос);
		}
		public static void Удалить(ГруппыПочтовойРассылкиЗапрос ГруппыПочтовойРассылкиЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ГруппыПочтовойРассылки?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ГруппыПочтовойРассылкиОтвет = Клиент.Delete(ГруппыПочтовойРассылкиЗапрос);
		}
	}
}