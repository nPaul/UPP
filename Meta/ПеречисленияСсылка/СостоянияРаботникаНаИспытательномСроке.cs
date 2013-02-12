﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum СостоянияРаботникаНаИспытательномСроке
	{
		ПустаяСсылка = - 1,
		ПринятНаИспытательныйСрок = 0,//Принят на испытательный срок
		НеПрошелИспытательныйСрок = 1,//Не прошел испытательный срок
		ПринятНаРаботу = 2,//Принят на работу
	}
	public static partial class СостоянияРаботникаНаИспытательномСроке_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПринятНаИспытательныйСрок = new Guid("5c2b859d-7f65-fad2-4639-0f60fc4510fd");//Принят на испытательный срок
		public static readonly Guid НеПрошелИспытательныйСрок = new Guid("c5f9f7ad-4d44-0dcc-48bd-539287e995b9");//Не прошел испытательный срок
		public static readonly Guid ПринятНаРаботу = new Guid("cfc7af8e-26c8-81dd-4d26-6c486e71b8bf");//Принят на работу
		public static СостоянияРаботникаНаИспытательномСроке Получить(this СостоянияРаботникаНаИспытательномСроке Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СостоянияРаботникаНаИспытательномСроке Получить(this СостоянияРаботникаНаИспытательномСроке Значение, Guid Ссылка)
		{
			if(Ссылка == ПринятНаИспытательныйСрок)
			{
				return СостоянияРаботникаНаИспытательномСроке.ПринятНаИспытательныйСрок;
			}
			else if(Ссылка == НеПрошелИспытательныйСрок)
			{
				return СостоянияРаботникаНаИспытательномСроке.НеПрошелИспытательныйСрок;
			}
			else if(Ссылка == ПринятНаРаботу)
			{
				return СостоянияРаботникаНаИспытательномСроке.ПринятНаРаботу;
			}
			return СостоянияРаботникаНаИспытательномСроке.ПустаяСсылка;
		}
		public static byte[] Ключ(this СостоянияРаботникаНаИспытательномСроке Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СостоянияРаботникаНаИспытательномСроке Значение)
		{
			switch (Значение)
			{
				case СостоянияРаботникаНаИспытательномСроке.ПринятНаИспытательныйСрок: return ПринятНаИспытательныйСрок;
				case СостоянияРаботникаНаИспытательномСроке.НеПрошелИспытательныйСрок: return НеПрошелИспытательныйСрок;
				case СостоянияРаботникаНаИспытательномСроке.ПринятНаРаботу: return ПринятНаРаботу;
			}
			return Guid.Empty;
		}
	}
}