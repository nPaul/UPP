﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum ВидыОбъектовРабочихЦентров
	{
		ПустаяСсылка = - 1,
		ОсновноеСредство = 0,//Основное средство
		Должность = 1,
		Персонал = 2,
	}
	public static partial class ВидыОбъектовРабочихЦентров_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОсновноеСредство = new Guid("ca9a96a6-93bb-b6e7-499d-bf109d3a3be1");//Основное средство
		public static readonly Guid Должность = new Guid("bfa49480-af20-7c04-4be8-36a50f85add4");
		public static readonly Guid Персонал = new Guid("9aff2080-c35f-e7b4-4cbe-c40f0549bd3a");
		public static ВидыОбъектовРабочихЦентров Получить(this ВидыОбъектовРабочихЦентров Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОбъектовРабочихЦентров Получить(this ВидыОбъектовРабочихЦентров Значение, Guid Ссылка)
		{
			if(Ссылка == ОсновноеСредство)
			{
				return ВидыОбъектовРабочихЦентров.ОсновноеСредство;
			}
			else if(Ссылка == Должность)
			{
				return ВидыОбъектовРабочихЦентров.Должность;
			}
			else if(Ссылка == Персонал)
			{
				return ВидыОбъектовРабочихЦентров.Персонал;
			}
			return ВидыОбъектовРабочихЦентров.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОбъектовРабочихЦентров Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОбъектовРабочихЦентров Значение)
		{
			switch (Значение)
			{
				case ВидыОбъектовРабочихЦентров.ОсновноеСредство: return ОсновноеСредство;
				case ВидыОбъектовРабочихЦентров.Должность: return Должность;
				case ВидыОбъектовРабочихЦентров.Персонал: return Персонал;
			}
			return Guid.Empty;
		}
	}
}