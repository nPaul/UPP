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
	public class ОтраслевыеСегментыПоМСФО:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ОтраслевыеСегментыПоМСФОЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ОтраслевыеСегментыПоМСФО/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ОтраслевыеСегментыПоМСФОЗапрос ОтраслевыеСегментыПоМСФОЗапрос = null;
			try
			{
				ОтраслевыеСегментыПоМСФОЗапрос = Клиент.Get(new ОтраслевыеСегментыПоМСФОЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ОтраслевыеСегментыПоМСФОЗапрос;
		}
		public static ОтраслевыеСегментыПоМСФОЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/ОтраслевыеСегментыПоМСФО/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ОтраслевыеСегментыПоМСФОЗапрос ОтраслевыеСегментыПоМСФОЗапрос = null;
			try
			{
				ОтраслевыеСегментыПоМСФОЗапрос = Клиент.Get(new ОтраслевыеСегментыПоМСФОЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ОтраслевыеСегментыПоМСФОЗапрос;
		}
		public static ОтраслевыеСегментыПоМСФОЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/ОтраслевыеСегментыПоМСФО/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ОтраслевыеСегментыПоМСФОЗапрос ОтраслевыеСегментыПоМСФОЗапрос = null;
			try
			{
				ОтраслевыеСегментыПоМСФОЗапрос = Клиент.Get(new ОтраслевыеСегментыПоМСФОЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ОтраслевыеСегментыПоМСФОЗапрос;
		}
		public static void ЗаписатьНовый(ОтраслевыеСегментыПоМСФОЗапрос ОтраслевыеСегментыПоМСФОЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/ОтраслевыеСегментыПоМСФО?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ОтраслевыеСегментыПоМСФООтвет = Клиент.Post(ОтраслевыеСегментыПоМСФОЗапрос);
		}
		public static void Записать(ОтраслевыеСегментыПоМСФОЗапрос ОтраслевыеСегментыПоМСФОЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/ОтраслевыеСегментыПоМСФО?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ОтраслевыеСегментыПоМСФООтвет = Клиент.Put(ОтраслевыеСегментыПоМСФОЗапрос);
		}
		public static void Удалить(ОтраслевыеСегментыПоМСФОЗапрос ОтраслевыеСегментыПоМСФОЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/ОтраслевыеСегментыПоМСФО?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ОтраслевыеСегментыПоМСФООтвет = Клиент.Delete(ОтраслевыеСегментыПоМСФОЗапрос);
		}
	}
}