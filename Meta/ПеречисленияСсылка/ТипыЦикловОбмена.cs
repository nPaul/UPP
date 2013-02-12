﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ТипыЦикловОбмена
	{
		ПустаяСсылка = - 1,
		НалоговаяИлиБухгалтерскаяОтчетность = 0,//Налоговая или бухгалтерская отчетность
		НеформализованныеДокументыНалоговогоОргана = 1,//Неформализованные документы налогового органа
		НеформализованныеДокументыНалогоплательщика = 2,//Неформализованные документы налогоплательщика
		ЗапросыНаИнформационноеОбслуживание = 3,//Запросы на информационное обслуживание
		ОтчетностьПФР = 4,//Отчетность ПФР
		НеформализованнаяПерепискаПФРВходящие = 5,//Неформализованная переписка с ПФР (входящие)
		НеформализованнаяПерепискаПФРИсходящие = 6,//Неформализованная переписка с ПФР (исходящие)
		Форма2НДФЛ = 7,//Форма 2-НДФЛ
		ОбращениеНП = 8,//Обращение налогоплательщика
		ПисьмоНО = 9,//Индивидуальное информирование абонентов
		Рассылка = 10,//Информационная рассылка со стороны налоговых органов
		РассылкаГрупповая = 11,//Групповая информационная рассылка со стороны налоговых органов
		ИОН = 12,//Информационное обслуживание абонентов
	///<summary>
	///ОтчетСтат
	///</summary>
		ОтчетностьФСГС = 13,//Отчетность ФСГС
	///<summary>
	///ПисьмоРеспондент
	///</summary>
		ПисьменноеОбращениеВФСГС = 14,//Письменное обращение респондента в орган ФСГС
	///<summary>
	///ПисьмоОрганФСГС
	///</summary>
		ИндивидуальноеИнформированиеФСГС = 15,//Индивидуальное информирование респондента со стороны органа ФСГС
		РассылкаФСГС = 16,//Информационная рассылка со стороны органов ФСГС
		Заявление = 17,//Заявление о ввозе товаров и уплате косвенных налогов
		Документ = 18,//Документы реализации полномочий налоговых органов
	}
	public static partial class ТипыЦикловОбмена_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НалоговаяИлиБухгалтерскаяОтчетность = new Guid("318dc188-2982-fe0f-4d7f-3a799a672d55");//Налоговая или бухгалтерская отчетность
		public static readonly Guid НеформализованныеДокументыНалоговогоОргана = new Guid("537ce499-0933-5ce6-4462-5794bc3f5c50");//Неформализованные документы налогового органа
		public static readonly Guid НеформализованныеДокументыНалогоплательщика = new Guid("8362d980-cdd0-81be-48da-0eb3fb076439");//Неформализованные документы налогоплательщика
		public static readonly Guid ЗапросыНаИнформационноеОбслуживание = new Guid("8d8d7589-2e00-8c97-4653-18901b097e9c");//Запросы на информационное обслуживание
		public static readonly Guid ОтчетностьПФР = new Guid("669f45a1-ca75-4b44-4c61-82de3442ec7c");//Отчетность ПФР
		public static readonly Guid НеформализованнаяПерепискаПФРВходящие = new Guid("ed754f83-e266-e43c-4d46-03b3025fda9c");//Неформализованная переписка с ПФР (входящие)
		public static readonly Guid НеформализованнаяПерепискаПФРИсходящие = new Guid("a56c6fad-fcf9-c8e3-4e47-1b065170ceb1");//Неформализованная переписка с ПФР (исходящие)
		public static readonly Guid Форма2НДФЛ = new Guid("2a8b7986-925e-a1ff-4be3-0cb51b4e34a9");//Форма 2-НДФЛ
		public static readonly Guid ОбращениеНП = new Guid("355f1191-e23e-e3de-446f-24fefd304031");//Обращение налогоплательщика
		public static readonly Guid ПисьмоНО = new Guid("0c35dd8e-7e09-c966-41c6-d0370358d6cd");//Индивидуальное информирование абонентов
		public static readonly Guid Рассылка = new Guid("ab6507bf-3eb2-b6f7-44aa-ef435a780554");//Информационная рассылка со стороны налоговых органов
		public static readonly Guid РассылкаГрупповая = new Guid("26d3e5a1-fe8c-aa5e-4bb2-3fb789a428ba");//Групповая информационная рассылка со стороны налоговых органов
		public static readonly Guid ИОН = new Guid("f216a39a-8fed-b759-484f-aca26d7b20cc");//Информационное обслуживание абонентов
		///<summary>
		///ОтчетСтат
		///</summary>
		public static readonly Guid ОтчетностьФСГС = new Guid("c37ccead-0aee-cc84-40b7-ccc1e47a82c7");//Отчетность ФСГС
		///<summary>
		///ПисьмоРеспондент
		///</summary>
		public static readonly Guid ПисьменноеОбращениеВФСГС = new Guid("7acaab87-5767-dd45-4fd1-951f15bd57ca");//Письменное обращение респондента в орган ФСГС
		///<summary>
		///ПисьмоОрганФСГС
		///</summary>
		public static readonly Guid ИндивидуальноеИнформированиеФСГС = new Guid("2a041d94-fe84-37bc-4ce0-dd514ea2b092");//Индивидуальное информирование респондента со стороны органа ФСГС
		public static readonly Guid РассылкаФСГС = new Guid("3c3cc797-457f-b207-46c1-057b03a82b5e");//Информационная рассылка со стороны органов ФСГС
		public static readonly Guid Заявление = new Guid("c4dc4797-28c0-e68f-48b8-469271deb102");//Заявление о ввозе товаров и уплате косвенных налогов
		public static readonly Guid Документ = new Guid("df74f88d-2b7c-e3d0-4e98-f1c4752ce9b4");//Документы реализации полномочий налоговых органов
		public static ТипыЦикловОбмена Получить(this ТипыЦикловОбмена Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыЦикловОбмена Получить(this ТипыЦикловОбмена Значение, Guid Ссылка)
		{
			if(Ссылка == НалоговаяИлиБухгалтерскаяОтчетность)
			{
				return ТипыЦикловОбмена.НалоговаяИлиБухгалтерскаяОтчетность;
			}
			else if(Ссылка == НеформализованныеДокументыНалоговогоОргана)
			{
				return ТипыЦикловОбмена.НеформализованныеДокументыНалоговогоОргана;
			}
			else if(Ссылка == НеформализованныеДокументыНалогоплательщика)
			{
				return ТипыЦикловОбмена.НеформализованныеДокументыНалогоплательщика;
			}
			else if(Ссылка == ЗапросыНаИнформационноеОбслуживание)
			{
				return ТипыЦикловОбмена.ЗапросыНаИнформационноеОбслуживание;
			}
			else if(Ссылка == ОтчетностьПФР)
			{
				return ТипыЦикловОбмена.ОтчетностьПФР;
			}
			else if(Ссылка == НеформализованнаяПерепискаПФРВходящие)
			{
				return ТипыЦикловОбмена.НеформализованнаяПерепискаПФРВходящие;
			}
			else if(Ссылка == НеформализованнаяПерепискаПФРИсходящие)
			{
				return ТипыЦикловОбмена.НеформализованнаяПерепискаПФРИсходящие;
			}
			else if(Ссылка == Форма2НДФЛ)
			{
				return ТипыЦикловОбмена.Форма2НДФЛ;
			}
			else if(Ссылка == ОбращениеНП)
			{
				return ТипыЦикловОбмена.ОбращениеНП;
			}
			else if(Ссылка == ПисьмоНО)
			{
				return ТипыЦикловОбмена.ПисьмоНО;
			}
			else if(Ссылка == Рассылка)
			{
				return ТипыЦикловОбмена.Рассылка;
			}
			else if(Ссылка == РассылкаГрупповая)
			{
				return ТипыЦикловОбмена.РассылкаГрупповая;
			}
			else if(Ссылка == ИОН)
			{
				return ТипыЦикловОбмена.ИОН;
			}
			else if(Ссылка == ОтчетностьФСГС)
			{
				return ТипыЦикловОбмена.ОтчетностьФСГС;
			}
			else if(Ссылка == ПисьменноеОбращениеВФСГС)
			{
				return ТипыЦикловОбмена.ПисьменноеОбращениеВФСГС;
			}
			else if(Ссылка == ИндивидуальноеИнформированиеФСГС)
			{
				return ТипыЦикловОбмена.ИндивидуальноеИнформированиеФСГС;
			}
			else if(Ссылка == РассылкаФСГС)
			{
				return ТипыЦикловОбмена.РассылкаФСГС;
			}
			else if(Ссылка == Заявление)
			{
				return ТипыЦикловОбмена.Заявление;
			}
			else if(Ссылка == Документ)
			{
				return ТипыЦикловОбмена.Документ;
			}
			return ТипыЦикловОбмена.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыЦикловОбмена Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыЦикловОбмена Значение)
		{
			switch (Значение)
			{
				case ТипыЦикловОбмена.НалоговаяИлиБухгалтерскаяОтчетность: return НалоговаяИлиБухгалтерскаяОтчетность;
				case ТипыЦикловОбмена.НеформализованныеДокументыНалоговогоОргана: return НеформализованныеДокументыНалоговогоОргана;
				case ТипыЦикловОбмена.НеформализованныеДокументыНалогоплательщика: return НеформализованныеДокументыНалогоплательщика;
				case ТипыЦикловОбмена.ЗапросыНаИнформационноеОбслуживание: return ЗапросыНаИнформационноеОбслуживание;
				case ТипыЦикловОбмена.ОтчетностьПФР: return ОтчетностьПФР;
				case ТипыЦикловОбмена.НеформализованнаяПерепискаПФРВходящие: return НеформализованнаяПерепискаПФРВходящие;
				case ТипыЦикловОбмена.НеформализованнаяПерепискаПФРИсходящие: return НеформализованнаяПерепискаПФРИсходящие;
				case ТипыЦикловОбмена.Форма2НДФЛ: return Форма2НДФЛ;
				case ТипыЦикловОбмена.ОбращениеНП: return ОбращениеНП;
				case ТипыЦикловОбмена.ПисьмоНО: return ПисьмоНО;
				case ТипыЦикловОбмена.Рассылка: return Рассылка;
				case ТипыЦикловОбмена.РассылкаГрупповая: return РассылкаГрупповая;
				case ТипыЦикловОбмена.ИОН: return ИОН;
				case ТипыЦикловОбмена.ОтчетностьФСГС: return ОтчетностьФСГС;
				case ТипыЦикловОбмена.ПисьменноеОбращениеВФСГС: return ПисьменноеОбращениеВФСГС;
				case ТипыЦикловОбмена.ИндивидуальноеИнформированиеФСГС: return ИндивидуальноеИнформированиеФСГС;
				case ТипыЦикловОбмена.РассылкаФСГС: return РассылкаФСГС;
				case ТипыЦикловОбмена.Заявление: return Заявление;
				case ТипыЦикловОбмена.Документ: return Документ;
			}
			return Guid.Empty;
		}
	}
}