﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыЭД
	{
		ПустаяСсылка = - 1,
		АктВыполненныхРабот = 0,//Акт выполненных работ (CommerceML)
		АктЗаказчик = 1,//Акт (титул заказчика, ФНС 5.01)
		АктИсполнитель = 2,//Акт (титул исполнителя, ФНС 5.01)
		ВозвратТоваровМеждуОрганизациями = 3,//Возврат товаров между организациями
		ЗаказТовара = 4,//Заказ товара
		ИзвещениеОПолучении = 5,//Извещение о получении
		КаталогТоваров = 6,//Каталог товаров
		ОтветНаЗаказ = 7,//Ответ на заказ
		ОтчетОПродажахКомиссионногоТовара = 8,//Отчет о продажах комиссионного товара
		ОтчетОСписанииКомиссионногоТовара = 9,//Отчет о списании комиссионного товара
		Ошибка = 10,
		ПередачаТоваровМеждуОрганизациями = 11,//Передача товаров между организациями
		Подтверждение = 12,
		ПрайсЛист = 13,//Прайс-лист
		ПроизвольныйЭД = 14,//Произвольный электронный документ
		СчетНаОплату = 15,//Счет на оплату
		СчетФактура = 16,//Счет-фактура
		ТОРГ12 = 17,//ТОРГ-12 (CommerceML)
		ТОРГ12Покупатель = 18,//ТОРГ-12 (титул покупателя, ФНС 5.01)
		ТОРГ12Продавец = 19,//ТОРГ-12 (титул продавца, ФНС 5.01)
		УведомлениеОбУточнении = 20,//Уведомление об уточнении
		ДопДанные = 21,//Дополнительные данные
	}
	public static partial class ВидыЭД_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid АктВыполненныхРабот = new Guid("1e07e0ac-8bb1-bc76-4dd6-8413934f3354");//Акт выполненных работ (CommerceML)
		public static readonly Guid АктЗаказчик = new Guid("8e0fbf9d-6db3-d230-425e-edc022445df0");//Акт (титул заказчика, ФНС 5.01)
		public static readonly Guid АктИсполнитель = new Guid("70353eb4-d400-8dde-462b-cea04d817c2e");//Акт (титул исполнителя, ФНС 5.01)
		public static readonly Guid ВозвратТоваровМеждуОрганизациями = new Guid("cf09a986-7c44-61ef-4de7-8e2e0ccb4e60");//Возврат товаров между организациями
		public static readonly Guid ЗаказТовара = new Guid("48008084-fbbd-9574-4eca-d067de88793b");//Заказ товара
		public static readonly Guid ИзвещениеОПолучении = new Guid("b3d4fe82-21a6-a9a0-4798-ff4289b84fc6");//Извещение о получении
		public static readonly Guid КаталогТоваров = new Guid("889397a3-1b6b-56fe-42ef-4b1898bd9772");//Каталог товаров
		public static readonly Guid ОтветНаЗаказ = new Guid("7874da99-9f58-fe22-4a3a-e76014bd5c0f");//Ответ на заказ
		public static readonly Guid ОтчетОПродажахКомиссионногоТовара = new Guid("7ff11a81-af97-4d20-45c2-baecac770e3c");//Отчет о продажах комиссионного товара
		public static readonly Guid ОтчетОСписанииКомиссионногоТовара = new Guid("0d1ac594-2235-7286-4ef5-76b1dfb9ae1b");//Отчет о списании комиссионного товара
		public static readonly Guid Ошибка = new Guid("d9f455a1-5e88-c0d3-4a60-dec479b5676a");
		public static readonly Guid ПередачаТоваровМеждуОрганизациями = new Guid("fdd89499-ea97-a409-4900-d3e328bfe568");//Передача товаров между организациями
		public static readonly Guid Подтверждение = new Guid("cb33b1a4-a7ca-b459-4b4a-eda3e6b0127d");
		public static readonly Guid ПрайсЛист = new Guid("4a7b558c-ce5a-15c5-4f6d-00bf5d4512d0");//Прайс-лист
		public static readonly Guid ПроизвольныйЭД = new Guid("f7a16899-427d-116b-4490-de6e765ab560");//Произвольный электронный документ
		public static readonly Guid СчетНаОплату = new Guid("b036e493-ca76-3db2-4934-708bf1b2c7d8");//Счет на оплату
		public static readonly Guid СчетФактура = new Guid("5095bbb5-1316-3286-472c-a3059b40acec");//Счет-фактура
		public static readonly Guid ТОРГ12 = new Guid("02fbbcb2-5236-71f5-4986-9c9ec92d858f");//ТОРГ-12 (CommerceML)
		public static readonly Guid ТОРГ12Покупатель = new Guid("e67689a2-d1fa-cfeb-4d3c-943f85e4adb1");//ТОРГ-12 (титул покупателя, ФНС 5.01)
		public static readonly Guid ТОРГ12Продавец = new Guid("6b585aa8-98c0-0fa2-4a4f-239bdc4b5af1");//ТОРГ-12 (титул продавца, ФНС 5.01)
		public static readonly Guid УведомлениеОбУточнении = new Guid("afbaa88f-8d0c-e2f3-4d12-d1c93c43ade1");//Уведомление об уточнении
		public static readonly Guid ДопДанные = new Guid("38677e84-f980-2bd8-467a-b28a0f816b3e");//Дополнительные данные
		public static ВидыЭД Получить(this ВидыЭД Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыЭД Получить(this ВидыЭД Значение, Guid Ссылка)
		{
			if(Ссылка == АктВыполненныхРабот)
			{
				return ВидыЭД.АктВыполненныхРабот;
			}
			else if(Ссылка == АктЗаказчик)
			{
				return ВидыЭД.АктЗаказчик;
			}
			else if(Ссылка == АктИсполнитель)
			{
				return ВидыЭД.АктИсполнитель;
			}
			else if(Ссылка == ВозвратТоваровМеждуОрганизациями)
			{
				return ВидыЭД.ВозвратТоваровМеждуОрганизациями;
			}
			else if(Ссылка == ЗаказТовара)
			{
				return ВидыЭД.ЗаказТовара;
			}
			else if(Ссылка == ИзвещениеОПолучении)
			{
				return ВидыЭД.ИзвещениеОПолучении;
			}
			else if(Ссылка == КаталогТоваров)
			{
				return ВидыЭД.КаталогТоваров;
			}
			else if(Ссылка == ОтветНаЗаказ)
			{
				return ВидыЭД.ОтветНаЗаказ;
			}
			else if(Ссылка == ОтчетОПродажахКомиссионногоТовара)
			{
				return ВидыЭД.ОтчетОПродажахКомиссионногоТовара;
			}
			else if(Ссылка == ОтчетОСписанииКомиссионногоТовара)
			{
				return ВидыЭД.ОтчетОСписанииКомиссионногоТовара;
			}
			else if(Ссылка == Ошибка)
			{
				return ВидыЭД.Ошибка;
			}
			else if(Ссылка == ПередачаТоваровМеждуОрганизациями)
			{
				return ВидыЭД.ПередачаТоваровМеждуОрганизациями;
			}
			else if(Ссылка == Подтверждение)
			{
				return ВидыЭД.Подтверждение;
			}
			else if(Ссылка == ПрайсЛист)
			{
				return ВидыЭД.ПрайсЛист;
			}
			else if(Ссылка == ПроизвольныйЭД)
			{
				return ВидыЭД.ПроизвольныйЭД;
			}
			else if(Ссылка == СчетНаОплату)
			{
				return ВидыЭД.СчетНаОплату;
			}
			else if(Ссылка == СчетФактура)
			{
				return ВидыЭД.СчетФактура;
			}
			else if(Ссылка == ТОРГ12)
			{
				return ВидыЭД.ТОРГ12;
			}
			else if(Ссылка == ТОРГ12Покупатель)
			{
				return ВидыЭД.ТОРГ12Покупатель;
			}
			else if(Ссылка == ТОРГ12Продавец)
			{
				return ВидыЭД.ТОРГ12Продавец;
			}
			else if(Ссылка == УведомлениеОбУточнении)
			{
				return ВидыЭД.УведомлениеОбУточнении;
			}
			else if(Ссылка == ДопДанные)
			{
				return ВидыЭД.ДопДанные;
			}
			return ВидыЭД.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыЭД Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыЭД Значение)
		{
			switch (Значение)
			{
				case ВидыЭД.АктВыполненныхРабот: return АктВыполненныхРабот;
				case ВидыЭД.АктЗаказчик: return АктЗаказчик;
				case ВидыЭД.АктИсполнитель: return АктИсполнитель;
				case ВидыЭД.ВозвратТоваровМеждуОрганизациями: return ВозвратТоваровМеждуОрганизациями;
				case ВидыЭД.ЗаказТовара: return ЗаказТовара;
				case ВидыЭД.ИзвещениеОПолучении: return ИзвещениеОПолучении;
				case ВидыЭД.КаталогТоваров: return КаталогТоваров;
				case ВидыЭД.ОтветНаЗаказ: return ОтветНаЗаказ;
				case ВидыЭД.ОтчетОПродажахКомиссионногоТовара: return ОтчетОПродажахКомиссионногоТовара;
				case ВидыЭД.ОтчетОСписанииКомиссионногоТовара: return ОтчетОСписанииКомиссионногоТовара;
				case ВидыЭД.Ошибка: return Ошибка;
				case ВидыЭД.ПередачаТоваровМеждуОрганизациями: return ПередачаТоваровМеждуОрганизациями;
				case ВидыЭД.Подтверждение: return Подтверждение;
				case ВидыЭД.ПрайсЛист: return ПрайсЛист;
				case ВидыЭД.ПроизвольныйЭД: return ПроизвольныйЭД;
				case ВидыЭД.СчетНаОплату: return СчетНаОплату;
				case ВидыЭД.СчетФактура: return СчетФактура;
				case ВидыЭД.ТОРГ12: return ТОРГ12;
				case ВидыЭД.ТОРГ12Покупатель: return ТОРГ12Покупатель;
				case ВидыЭД.ТОРГ12Продавец: return ТОРГ12Продавец;
				case ВидыЭД.УведомлениеОбУточнении: return УведомлениеОбУточнении;
				case ВидыЭД.ДопДанные: return ДопДанные;
			}
			return Guid.Empty;
		}
	}
}