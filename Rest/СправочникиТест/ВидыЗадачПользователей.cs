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
	public class ВидыЗадачПользователей:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ВидыЗадачПользователейЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыЗадачПользователей/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ВидыЗадачПользователейЗапрос ВидыЗадачПользователейЗапрос = null;
			try
			{
				ВидыЗадачПользователейЗапрос = Клиент.Get(new ВидыЗадачПользователейЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ВидыЗадачПользователейЗапрос;
		}
		public static ВидыЗадачПользователейЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыЗадачПользователей/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ВидыЗадачПользователейЗапрос ВидыЗадачПользователейЗапрос = null;
			try
			{
				ВидыЗадачПользователейЗапрос = Клиент.Get(new ВидыЗадачПользователейЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ВидыЗадачПользователейЗапрос;
		}
		public static ВидыЗадачПользователейЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыЗадачПользователей/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ВидыЗадачПользователейЗапрос ВидыЗадачПользователейЗапрос = null;
			try
			{
				ВидыЗадачПользователейЗапрос = Клиент.Get(new ВидыЗадачПользователейЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ВидыЗадачПользователейЗапрос;
		}
		public static void ЗаписатьНовый(ВидыЗадачПользователейЗапрос ВидыЗадачПользователейЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыЗадачПользователей?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ВидыЗадачПользователейОтвет = Клиент.Post(ВидыЗадачПользователейЗапрос);
		}
		public static void Записать(ВидыЗадачПользователейЗапрос ВидыЗадачПользователейЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыЗадачПользователей?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ВидыЗадачПользователейОтвет = Клиент.Put(ВидыЗадачПользователейЗапрос);
		}
		public static void Удалить(ВидыЗадачПользователейЗапрос ВидыЗадачПользователейЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ВидыЗадачПользователей?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ВидыЗадачПользователейОтвет = Клиент.Delete(ВидыЗадачПользователейЗапрос);
		}
	}
}