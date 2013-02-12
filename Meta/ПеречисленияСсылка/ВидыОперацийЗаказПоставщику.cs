﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum ВидыОперацийЗаказПоставщику
	{
		ПустаяСсылка = - 1,
		ПокупкаКомиссия = 0,//покупка, комиссия
		Переработка = 1,
	///<summary>
	///(Общ)
	///</summary>
		Оборудование = 2,
	}
	public static partial class ВидыОперацийЗаказПоставщику_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПокупкаКомиссия = new Guid("94d32e9a-347f-77ac-42ad-c9820b913b73");//покупка, комиссия
		public static readonly Guid Переработка = new Guid("5d437fae-1733-fbda-44a9-4e3679f92bdd");
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Оборудование = new Guid("bf44a3af-a382-2bf0-4246-df0f2c8cd774");
		public static ВидыОперацийЗаказПоставщику Получить(this ВидыОперацийЗаказПоставщику Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийЗаказПоставщику Получить(this ВидыОперацийЗаказПоставщику Значение, Guid Ссылка)
		{
			if(Ссылка == ПокупкаКомиссия)
			{
				return ВидыОперацийЗаказПоставщику.ПокупкаКомиссия;
			}
			else if(Ссылка == Переработка)
			{
				return ВидыОперацийЗаказПоставщику.Переработка;
			}
			else if(Ссылка == Оборудование)
			{
				return ВидыОперацийЗаказПоставщику.Оборудование;
			}
			return ВидыОперацийЗаказПоставщику.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийЗаказПоставщику Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийЗаказПоставщику Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийЗаказПоставщику.ПокупкаКомиссия: return ПокупкаКомиссия;
				case ВидыОперацийЗаказПоставщику.Переработка: return Переработка;
				case ВидыОперацийЗаказПоставщику.Оборудование: return Оборудование;
			}
			return Guid.Empty;
		}
	}
}