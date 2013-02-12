﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(упр)
		///</summary>
	public enum ВидыАккредитивов
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(упр)
	///</summary>
		ОтзывныйПокрытый = 0,//Отзывный (покрытый)
		ОтзывныйНепокрытый = 1,//Отзывный (непокрытый)
		БезотзывныйПокрытый = 2,//Безотзывный (покрытый)
		БезотзывныйНепокрытый = 3,//Безотзывный (непокрытый)
	}
	public static partial class ВидыАккредитивов_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(упр)
		///</summary>
		public static readonly Guid ОтзывныйПокрытый = new Guid("0406b1a3-0faf-17c9-4387-8bb0d3186d76");//Отзывный (покрытый)
		public static readonly Guid ОтзывныйНепокрытый = new Guid("5aaa98ae-bb3e-88e1-4e89-1568ba2e912c");//Отзывный (непокрытый)
		public static readonly Guid БезотзывныйПокрытый = new Guid("9d36b0ac-49b1-a74b-4abe-c3dc66487c22");//Безотзывный (покрытый)
		public static readonly Guid БезотзывныйНепокрытый = new Guid("b78a5898-fe7a-5c7e-4fd3-1ee4d3f3f9b8");//Безотзывный (непокрытый)
		public static ВидыАккредитивов Получить(this ВидыАккредитивов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыАккредитивов Получить(this ВидыАккредитивов Значение, Guid Ссылка)
		{
			if(Ссылка == ОтзывныйПокрытый)
			{
				return ВидыАккредитивов.ОтзывныйПокрытый;
			}
			else if(Ссылка == ОтзывныйНепокрытый)
			{
				return ВидыАккредитивов.ОтзывныйНепокрытый;
			}
			else if(Ссылка == БезотзывныйПокрытый)
			{
				return ВидыАккредитивов.БезотзывныйПокрытый;
			}
			else if(Ссылка == БезотзывныйНепокрытый)
			{
				return ВидыАккредитивов.БезотзывныйНепокрытый;
			}
			return ВидыАккредитивов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыАккредитивов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыАккредитивов Значение)
		{
			switch (Значение)
			{
				case ВидыАккредитивов.ОтзывныйПокрытый: return ОтзывныйПокрытый;
				case ВидыАккредитивов.ОтзывныйНепокрытый: return ОтзывныйНепокрытый;
				case ВидыАккредитивов.БезотзывныйПокрытый: return БезотзывныйПокрытый;
				case ВидыАккредитивов.БезотзывныйНепокрытый: return БезотзывныйНепокрытый;
			}
			return Guid.Empty;
		}
	}
}