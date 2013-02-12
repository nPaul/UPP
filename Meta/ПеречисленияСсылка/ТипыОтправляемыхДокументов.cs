﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ТипыОтправляемыхДокументов
	{
		ПустаяСсылка = - 1,
		ПрочаяОтчетностьФНС = 0,//Прочая отчетность в ФНС
		БухгалтерскаяОтчетность = 1,//Бухгалтерская отчетность
		ЗаявлениеОВвозеТоваров = 2,//Заявление о ввозе товаров и уплате косвенных налогов
		Форма2НДФЛ = 3,//2-НДФЛ
		Отчет4ФСС = 4,//4-ФСС
		ПрочаяОтчетностьПФР = 5,//Прочая отчетность в ПФР
		КомплектОтчетностиПФР = 6,//Комплект отчетности в ПФР
		ОтчетФСГС = 7,//Отчет в Росстат
	}
	public static partial class ТипыОтправляемыхДокументов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПрочаяОтчетностьФНС = new Guid("918acaae-f1b0-cd8b-48af-b650765d4562");//Прочая отчетность в ФНС
		public static readonly Guid БухгалтерскаяОтчетность = new Guid("d043ddb4-c3af-91b6-4bef-a0f121e03821");//Бухгалтерская отчетность
		public static readonly Guid ЗаявлениеОВвозеТоваров = new Guid("f74ee7bb-a7dd-4ee2-4da2-7333f566ffa1");//Заявление о ввозе товаров и уплате косвенных налогов
		public static readonly Guid Форма2НДФЛ = new Guid("38808592-1324-e7bc-4bed-c5067a23c057");//2-НДФЛ
		public static readonly Guid Отчет4ФСС = new Guid("6acb088b-9faa-5e81-4353-17d8c5973d65");//4-ФСС
		public static readonly Guid ПрочаяОтчетностьПФР = new Guid("4c7dd1ab-caca-af2b-4dbd-ccd682015ef2");//Прочая отчетность в ПФР
		public static readonly Guid КомплектОтчетностиПФР = new Guid("9711c690-3426-0b24-4aec-dde7e020fdb0");//Комплект отчетности в ПФР
		public static readonly Guid ОтчетФСГС = new Guid("c4c4fc9f-90ed-b2f0-4628-4b9acca8a26d");//Отчет в Росстат
		public static ТипыОтправляемыхДокументов Получить(this ТипыОтправляемыхДокументов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыОтправляемыхДокументов Получить(this ТипыОтправляемыхДокументов Значение, Guid Ссылка)
		{
			if(Ссылка == ПрочаяОтчетностьФНС)
			{
				return ТипыОтправляемыхДокументов.ПрочаяОтчетностьФНС;
			}
			else if(Ссылка == БухгалтерскаяОтчетность)
			{
				return ТипыОтправляемыхДокументов.БухгалтерскаяОтчетность;
			}
			else if(Ссылка == ЗаявлениеОВвозеТоваров)
			{
				return ТипыОтправляемыхДокументов.ЗаявлениеОВвозеТоваров;
			}
			else if(Ссылка == Форма2НДФЛ)
			{
				return ТипыОтправляемыхДокументов.Форма2НДФЛ;
			}
			else if(Ссылка == Отчет4ФСС)
			{
				return ТипыОтправляемыхДокументов.Отчет4ФСС;
			}
			else if(Ссылка == ПрочаяОтчетностьПФР)
			{
				return ТипыОтправляемыхДокументов.ПрочаяОтчетностьПФР;
			}
			else if(Ссылка == КомплектОтчетностиПФР)
			{
				return ТипыОтправляемыхДокументов.КомплектОтчетностиПФР;
			}
			else if(Ссылка == ОтчетФСГС)
			{
				return ТипыОтправляемыхДокументов.ОтчетФСГС;
			}
			return ТипыОтправляемыхДокументов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыОтправляемыхДокументов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыОтправляемыхДокументов Значение)
		{
			switch (Значение)
			{
				case ТипыОтправляемыхДокументов.ПрочаяОтчетностьФНС: return ПрочаяОтчетностьФНС;
				case ТипыОтправляемыхДокументов.БухгалтерскаяОтчетность: return БухгалтерскаяОтчетность;
				case ТипыОтправляемыхДокументов.ЗаявлениеОВвозеТоваров: return ЗаявлениеОВвозеТоваров;
				case ТипыОтправляемыхДокументов.Форма2НДФЛ: return Форма2НДФЛ;
				case ТипыОтправляемыхДокументов.Отчет4ФСС: return Отчет4ФСС;
				case ТипыОтправляемыхДокументов.ПрочаяОтчетностьПФР: return ПрочаяОтчетностьПФР;
				case ТипыОтправляемыхДокументов.КомплектОтчетностиПФР: return КомплектОтчетностиПФР;
				case ТипыОтправляемыхДокументов.ОтчетФСГС: return ОтчетФСГС;
			}
			return Guid.Empty;
		}
	}
}