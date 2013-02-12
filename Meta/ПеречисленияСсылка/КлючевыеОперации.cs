﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum КлючевыеОперации
	{
		ПустаяСсылка = - 1,
		ПроведениеДокументаВыпускПродукции = 0,//Проведение документа "Выпуск продукции"
		ПроведениеДокументаЗаказПокупателя = 1,//Проведение документа "Заказ покупателя"
		ПроведениеДокументаЗаказПоставщику = 2,//Проведение документа "Заказ поставщику"
		ПроведениеДокументаКомплектацияНоменклатуры = 3,//Проведение документа "Комплектация номенклатуры"
		ПроведениеДокументаОприходованиеМатериаловИзПроизводства = 4,//Проведение документа "Оприходование материалов из производства"
		ПроведениеДокументаОтчетМастераСмены = 5,//Проведение документа "Отчет мастера смены"
		ПроведениеДокументаОтчетПроизводстваЗаСмену = 6,//Проведение документа "Отчет производства за смену"
		ПроведениеДокументаПоступлениеТоваровУслуг = 7,//Проведение документа "Поступление товаров и услуг"
		ПроведениеДокументаПриходныйКассовыйОрдер = 8,//Проведение документа "Приходный кассовый ордер"
		ПроведениеДокументаПриходныйОрдерНаТовары = 9,//Проведение документа "Приходный ордер на товары"
		ПроведениеДокументаРасходныйКассовыйОрдер = 10,//Проведение документа "Расходный кассовый ордер"
		ПроведениеДокументаРасходныйОрдерНаТовары = 11,//Проведение документа "Расходный ордер на товары"
		ПроведениеДокументаРасчетСебестоимостиВыпуска = 12,//Проведение документа "Расчет себестоимости"
		ПроведениеДокументаРеализацияТоваровУслуг = 13,//Проведение документа "Реализация товаров и услуг"
		ПроведениеДокументаТребованиеНакладная = 14,//Прведение документа "Требование-накладная"
		ОбщаяПроизводительностьСистемы = 15,//Общая производительность системы
	}
	public static partial class КлючевыеОперации_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПроведениеДокументаВыпускПродукции = new Guid("b52cd4bc-c313-29d3-4176-ec68cd600a24");//Проведение документа "Выпуск продукции"
		public static readonly Guid ПроведениеДокументаЗаказПокупателя = new Guid("e3432cbe-4a77-5aca-4ec9-90bae726d3f9");//Проведение документа "Заказ покупателя"
		public static readonly Guid ПроведениеДокументаЗаказПоставщику = new Guid("58358d99-54f2-240f-4631-10a235678298");//Проведение документа "Заказ поставщику"
		public static readonly Guid ПроведениеДокументаКомплектацияНоменклатуры = new Guid("00b397b2-914d-608e-4b70-c9ec68f75a0e");//Проведение документа "Комплектация номенклатуры"
		public static readonly Guid ПроведениеДокументаОприходованиеМатериаловИзПроизводства = new Guid("f71baa82-5a0b-1d1a-4b4e-91ad4509c0ea");//Проведение документа "Оприходование материалов из производства"
		public static readonly Guid ПроведениеДокументаОтчетМастераСмены = new Guid("c75ec38b-1f4f-7725-4a19-0f6c2696e69d");//Проведение документа "Отчет мастера смены"
		public static readonly Guid ПроведениеДокументаОтчетПроизводстваЗаСмену = new Guid("447b2383-8442-aa05-4080-2ab8e9cb19cd");//Проведение документа "Отчет производства за смену"
		public static readonly Guid ПроведениеДокументаПоступлениеТоваровУслуг = new Guid("b6e87e81-ae29-5625-4565-2c7b406dfc28");//Проведение документа "Поступление товаров и услуг"
		public static readonly Guid ПроведениеДокументаПриходныйКассовыйОрдер = new Guid("8d78f280-5dce-b3f7-406d-277b003720a4");//Проведение документа "Приходный кассовый ордер"
		public static readonly Guid ПроведениеДокументаПриходныйОрдерНаТовары = new Guid("b4e6f192-6273-c63a-4d60-e3f2b555ba9b");//Проведение документа "Приходный ордер на товары"
		public static readonly Guid ПроведениеДокументаРасходныйКассовыйОрдер = new Guid("e024c2b3-884c-6ba5-481d-bdf24f51816f");//Проведение документа "Расходный кассовый ордер"
		public static readonly Guid ПроведениеДокументаРасходныйОрдерНаТовары = new Guid("2c964d89-8e75-cf27-4490-2ca343a456ef");//Проведение документа "Расходный ордер на товары"
		public static readonly Guid ПроведениеДокументаРасчетСебестоимостиВыпуска = new Guid("16da87a3-bc69-21a6-4e36-cfbb12e44d37");//Проведение документа "Расчет себестоимости"
		public static readonly Guid ПроведениеДокументаРеализацияТоваровУслуг = new Guid("a498fdb9-a89d-b82a-413d-5fe08b5d80cb");//Проведение документа "Реализация товаров и услуг"
		public static readonly Guid ПроведениеДокументаТребованиеНакладная = new Guid("06b8a2b0-070e-44ee-4262-5931cca9817a");//Прведение документа "Требование-накладная"
		public static readonly Guid ОбщаяПроизводительностьСистемы = new Guid("01850e99-8033-7cf7-42b0-2741db9d05b6");//Общая производительность системы
		public static КлючевыеОперации Получить(this КлючевыеОперации Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static КлючевыеОперации Получить(this КлючевыеОперации Значение, Guid Ссылка)
		{
			if(Ссылка == ПроведениеДокументаВыпускПродукции)
			{
				return КлючевыеОперации.ПроведениеДокументаВыпускПродукции;
			}
			else if(Ссылка == ПроведениеДокументаЗаказПокупателя)
			{
				return КлючевыеОперации.ПроведениеДокументаЗаказПокупателя;
			}
			else if(Ссылка == ПроведениеДокументаЗаказПоставщику)
			{
				return КлючевыеОперации.ПроведениеДокументаЗаказПоставщику;
			}
			else if(Ссылка == ПроведениеДокументаКомплектацияНоменклатуры)
			{
				return КлючевыеОперации.ПроведениеДокументаКомплектацияНоменклатуры;
			}
			else if(Ссылка == ПроведениеДокументаОприходованиеМатериаловИзПроизводства)
			{
				return КлючевыеОперации.ПроведениеДокументаОприходованиеМатериаловИзПроизводства;
			}
			else if(Ссылка == ПроведениеДокументаОтчетМастераСмены)
			{
				return КлючевыеОперации.ПроведениеДокументаОтчетМастераСмены;
			}
			else if(Ссылка == ПроведениеДокументаОтчетПроизводстваЗаСмену)
			{
				return КлючевыеОперации.ПроведениеДокументаОтчетПроизводстваЗаСмену;
			}
			else if(Ссылка == ПроведениеДокументаПоступлениеТоваровУслуг)
			{
				return КлючевыеОперации.ПроведениеДокументаПоступлениеТоваровУслуг;
			}
			else if(Ссылка == ПроведениеДокументаПриходныйКассовыйОрдер)
			{
				return КлючевыеОперации.ПроведениеДокументаПриходныйКассовыйОрдер;
			}
			else if(Ссылка == ПроведениеДокументаПриходныйОрдерНаТовары)
			{
				return КлючевыеОперации.ПроведениеДокументаПриходныйОрдерНаТовары;
			}
			else if(Ссылка == ПроведениеДокументаРасходныйКассовыйОрдер)
			{
				return КлючевыеОперации.ПроведениеДокументаРасходныйКассовыйОрдер;
			}
			else if(Ссылка == ПроведениеДокументаРасходныйОрдерНаТовары)
			{
				return КлючевыеОперации.ПроведениеДокументаРасходныйОрдерНаТовары;
			}
			else if(Ссылка == ПроведениеДокументаРасчетСебестоимостиВыпуска)
			{
				return КлючевыеОперации.ПроведениеДокументаРасчетСебестоимостиВыпуска;
			}
			else if(Ссылка == ПроведениеДокументаРеализацияТоваровУслуг)
			{
				return КлючевыеОперации.ПроведениеДокументаРеализацияТоваровУслуг;
			}
			else if(Ссылка == ПроведениеДокументаТребованиеНакладная)
			{
				return КлючевыеОперации.ПроведениеДокументаТребованиеНакладная;
			}
			else if(Ссылка == ОбщаяПроизводительностьСистемы)
			{
				return КлючевыеОперации.ОбщаяПроизводительностьСистемы;
			}
			return КлючевыеОперации.ПустаяСсылка;
		}
		public static byte[] Ключ(this КлючевыеОперации Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this КлючевыеОперации Значение)
		{
			switch (Значение)
			{
				case КлючевыеОперации.ПроведениеДокументаВыпускПродукции: return ПроведениеДокументаВыпускПродукции;
				case КлючевыеОперации.ПроведениеДокументаЗаказПокупателя: return ПроведениеДокументаЗаказПокупателя;
				case КлючевыеОперации.ПроведениеДокументаЗаказПоставщику: return ПроведениеДокументаЗаказПоставщику;
				case КлючевыеОперации.ПроведениеДокументаКомплектацияНоменклатуры: return ПроведениеДокументаКомплектацияНоменклатуры;
				case КлючевыеОперации.ПроведениеДокументаОприходованиеМатериаловИзПроизводства: return ПроведениеДокументаОприходованиеМатериаловИзПроизводства;
				case КлючевыеОперации.ПроведениеДокументаОтчетМастераСмены: return ПроведениеДокументаОтчетМастераСмены;
				case КлючевыеОперации.ПроведениеДокументаОтчетПроизводстваЗаСмену: return ПроведениеДокументаОтчетПроизводстваЗаСмену;
				case КлючевыеОперации.ПроведениеДокументаПоступлениеТоваровУслуг: return ПроведениеДокументаПоступлениеТоваровУслуг;
				case КлючевыеОперации.ПроведениеДокументаПриходныйКассовыйОрдер: return ПроведениеДокументаПриходныйКассовыйОрдер;
				case КлючевыеОперации.ПроведениеДокументаПриходныйОрдерНаТовары: return ПроведениеДокументаПриходныйОрдерНаТовары;
				case КлючевыеОперации.ПроведениеДокументаРасходныйКассовыйОрдер: return ПроведениеДокументаРасходныйКассовыйОрдер;
				case КлючевыеОперации.ПроведениеДокументаРасходныйОрдерНаТовары: return ПроведениеДокументаРасходныйОрдерНаТовары;
				case КлючевыеОперации.ПроведениеДокументаРасчетСебестоимостиВыпуска: return ПроведениеДокументаРасчетСебестоимостиВыпуска;
				case КлючевыеОперации.ПроведениеДокументаРеализацияТоваровУслуг: return ПроведениеДокументаРеализацияТоваровУслуг;
				case КлючевыеОперации.ПроведениеДокументаТребованиеНакладная: return ПроведениеДокументаТребованиеНакладная;
				case КлючевыеОперации.ОбщаяПроизводительностьСистемы: return ОбщаяПроизводительностьСистемы;
			}
			return Guid.Empty;
		}
	}
}