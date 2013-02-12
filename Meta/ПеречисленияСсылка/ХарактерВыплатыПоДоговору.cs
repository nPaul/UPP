﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ХарактерВыплатыПоДоговору
	{
		ПустаяСсылка = - 1,
		ОднократноВКонцеСрока = 0,//Однократно в конце срока
		Ежемесячно = 1,
	}
	public static partial class ХарактерВыплатыПоДоговору_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОднократноВКонцеСрока = new Guid("399a8e9f-e217-7f46-4701-af55158708f4");//Однократно в конце срока
		public static readonly Guid Ежемесячно = new Guid("66542690-a64e-95b2-4960-9dbe48c9408f");
		public static ХарактерВыплатыПоДоговору Получить(this ХарактерВыплатыПоДоговору Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ХарактерВыплатыПоДоговору Получить(this ХарактерВыплатыПоДоговору Значение, Guid Ссылка)
		{
			if(Ссылка == ОднократноВКонцеСрока)
			{
				return ХарактерВыплатыПоДоговору.ОднократноВКонцеСрока;
			}
			else if(Ссылка == Ежемесячно)
			{
				return ХарактерВыплатыПоДоговору.Ежемесячно;
			}
			return ХарактерВыплатыПоДоговору.ПустаяСсылка;
		}
		public static byte[] Ключ(this ХарактерВыплатыПоДоговору Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ХарактерВыплатыПоДоговору Значение)
		{
			switch (Значение)
			{
				case ХарактерВыплатыПоДоговору.ОднократноВКонцеСрока: return ОднократноВКонцеСрока;
				case ХарактерВыплатыПоДоговору.Ежемесячно: return Ежемесячно;
			}
			return Guid.Empty;
		}
	}
}