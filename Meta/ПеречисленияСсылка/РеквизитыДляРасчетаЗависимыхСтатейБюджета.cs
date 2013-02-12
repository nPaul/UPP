﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum РеквизитыДляРасчетаЗависимыхСтатейБюджета
	{
		ПустаяСсылка = - 1,
		Количество = 0,
		Сумма = 1,
	}
	public static partial class РеквизитыДляРасчетаЗависимыхСтатейБюджета_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Количество = new Guid("439fe6bc-2277-8a94-4c7c-1bed5a7254cd");
		public static readonly Guid Сумма = new Guid("5826eca4-f8f1-8cba-4a49-a39b632ca6f4");
		public static РеквизитыДляРасчетаЗависимыхСтатейБюджета Получить(this РеквизитыДляРасчетаЗависимыхСтатейБюджета Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static РеквизитыДляРасчетаЗависимыхСтатейБюджета Получить(this РеквизитыДляРасчетаЗависимыхСтатейБюджета Значение, Guid Ссылка)
		{
			if(Ссылка == Количество)
			{
				return РеквизитыДляРасчетаЗависимыхСтатейБюджета.Количество;
			}
			else if(Ссылка == Сумма)
			{
				return РеквизитыДляРасчетаЗависимыхСтатейБюджета.Сумма;
			}
			return РеквизитыДляРасчетаЗависимыхСтатейБюджета.ПустаяСсылка;
		}
		public static byte[] Ключ(this РеквизитыДляРасчетаЗависимыхСтатейБюджета Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this РеквизитыДляРасчетаЗависимыхСтатейБюджета Значение)
		{
			switch (Значение)
			{
				case РеквизитыДляРасчетаЗависимыхСтатейБюджета.Количество: return Количество;
				case РеквизитыДляРасчетаЗависимыхСтатейБюджета.Сумма: return Сумма;
			}
			return Guid.Empty;
		}
	}
}