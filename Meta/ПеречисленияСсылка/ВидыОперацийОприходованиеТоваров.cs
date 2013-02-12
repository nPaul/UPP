﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыОперацийОприходованиеТоваров
	{
		ПустаяСсылка = - 1,
		ОприходованиеТоваров = 0,//оприходование товаров
		ВводНачальныхОстатков = 1,//ввод начальных остатков
	}
	public static partial class ВидыОперацийОприходованиеТоваров_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОприходованиеТоваров = new Guid("0a6339a5-9be5-18ae-4050-42f648408a20");//оприходование товаров
		public static readonly Guid ВводНачальныхОстатков = new Guid("128144a2-ec31-4de5-4fda-ccff6e50dde3");//ввод начальных остатков
		public static ВидыОперацийОприходованиеТоваров Получить(this ВидыОперацийОприходованиеТоваров Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийОприходованиеТоваров Получить(this ВидыОперацийОприходованиеТоваров Значение, Guid Ссылка)
		{
			if(Ссылка == ОприходованиеТоваров)
			{
				return ВидыОперацийОприходованиеТоваров.ОприходованиеТоваров;
			}
			else if(Ссылка == ВводНачальныхОстатков)
			{
				return ВидыОперацийОприходованиеТоваров.ВводНачальныхОстатков;
			}
			return ВидыОперацийОприходованиеТоваров.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийОприходованиеТоваров Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийОприходованиеТоваров Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийОприходованиеТоваров.ОприходованиеТоваров: return ОприходованиеТоваров;
				case ВидыОперацийОприходованиеТоваров.ВводНачальныхОстатков: return ВводНачальныхОстатков;
			}
			return Guid.Empty;
		}
	}
}