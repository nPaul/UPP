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
	public class УчетныеЗаписиДокументооборота:V82.Rest.СправочникиТест.СправочникТест
	{
		public static УчетныеЗаписиДокументооборотаЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/УчетныеЗаписиДокументооборота/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			УчетныеЗаписиДокументооборотаЗапрос УчетныеЗаписиДокументооборотаЗапрос = null;
			try
			{
				УчетныеЗаписиДокументооборотаЗапрос = Клиент.Get(new УчетныеЗаписиДокументооборотаЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return УчетныеЗаписиДокументооборотаЗапрос;
		}
		public static УчетныеЗаписиДокументооборотаЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Catalogs/УчетныеЗаписиДокументооборота/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			УчетныеЗаписиДокументооборотаЗапрос УчетныеЗаписиДокументооборотаЗапрос = null;
			try
			{
				УчетныеЗаписиДокументооборотаЗапрос = Клиент.Get(new УчетныеЗаписиДокументооборотаЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return УчетныеЗаписиДокументооборотаЗапрос;
		}
		public static УчетныеЗаписиДокументооборотаЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Catalogs/УчетныеЗаписиДокументооборота/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			УчетныеЗаписиДокументооборотаЗапрос УчетныеЗаписиДокументооборотаЗапрос = null;
			try
			{
				УчетныеЗаписиДокументооборотаЗапрос = Клиент.Get(new УчетныеЗаписиДокументооборотаЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return УчетныеЗаписиДокументооборотаЗапрос;
		}
		public static void ЗаписатьНовый(УчетныеЗаписиДокументооборотаЗапрос УчетныеЗаписиДокументооборотаЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Catalogs/УчетныеЗаписиДокументооборота?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var УчетныеЗаписиДокументооборотаОтвет = Клиент.Post(УчетныеЗаписиДокументооборотаЗапрос);
		}
		public static void Записать(УчетныеЗаписиДокументооборотаЗапрос УчетныеЗаписиДокументооборотаЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Catalogs/УчетныеЗаписиДокументооборота?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var УчетныеЗаписиДокументооборотаОтвет = Клиент.Put(УчетныеЗаписиДокументооборотаЗапрос);
		}
		public static void Удалить(УчетныеЗаписиДокументооборотаЗапрос УчетныеЗаписиДокументооборотаЗапрос)//
		{
			var Урл = "http://localhost:1337/Catalogs/УчетныеЗаписиДокументооборота?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var УчетныеЗаписиДокументооборотаОтвет = Клиент.Delete(УчетныеЗаписиДокументооборотаЗапрос);
		}
	}
}