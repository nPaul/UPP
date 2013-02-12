﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ТипыФайловОтчетностиПФР
	{
		ПустаяСсылка = - 1,
		ПачкаАДВ = 0,//Пачка АДВ
		ПачкаИС = 1,//Пачка ИС
		ПачкаДСВ = 2,//Пачка ДСВ
		РеестрДСВ = 3,//Реестр ДСВ
		ПачкаРСВ = 4,//Пачка РСВ
		ПачкаСВВ = 5,//Пачка СВВ
	}
	public static partial class ТипыФайловОтчетностиПФР_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПачкаАДВ = new Guid("50ed8db0-18b0-052c-4e8b-ca4804a6caac");//Пачка АДВ
		public static readonly Guid ПачкаИС = new Guid("e3626cb4-33cd-1bfa-4fcf-903befb8fb90");//Пачка ИС
		public static readonly Guid ПачкаДСВ = new Guid("32c01b98-9863-902f-4e36-11042815f45e");//Пачка ДСВ
		public static readonly Guid РеестрДСВ = new Guid("3ed5fa9f-a4aa-1899-472f-a7fe9797e104");//Реестр ДСВ
		public static readonly Guid ПачкаРСВ = new Guid("0b44b293-b518-7770-4195-c814fc1737ef");//Пачка РСВ
		public static readonly Guid ПачкаСВВ = new Guid("dc27f295-18f2-c0a2-4e2c-ff758bf1194f");//Пачка СВВ
		public static ТипыФайловОтчетностиПФР Получить(this ТипыФайловОтчетностиПФР Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыФайловОтчетностиПФР Получить(this ТипыФайловОтчетностиПФР Значение, Guid Ссылка)
		{
			if(Ссылка == ПачкаАДВ)
			{
				return ТипыФайловОтчетностиПФР.ПачкаАДВ;
			}
			else if(Ссылка == ПачкаИС)
			{
				return ТипыФайловОтчетностиПФР.ПачкаИС;
			}
			else if(Ссылка == ПачкаДСВ)
			{
				return ТипыФайловОтчетностиПФР.ПачкаДСВ;
			}
			else if(Ссылка == РеестрДСВ)
			{
				return ТипыФайловОтчетностиПФР.РеестрДСВ;
			}
			else if(Ссылка == ПачкаРСВ)
			{
				return ТипыФайловОтчетностиПФР.ПачкаРСВ;
			}
			else if(Ссылка == ПачкаСВВ)
			{
				return ТипыФайловОтчетностиПФР.ПачкаСВВ;
			}
			return ТипыФайловОтчетностиПФР.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыФайловОтчетностиПФР Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыФайловОтчетностиПФР Значение)
		{
			switch (Значение)
			{
				case ТипыФайловОтчетностиПФР.ПачкаАДВ: return ПачкаАДВ;
				case ТипыФайловОтчетностиПФР.ПачкаИС: return ПачкаИС;
				case ТипыФайловОтчетностиПФР.ПачкаДСВ: return ПачкаДСВ;
				case ТипыФайловОтчетностиПФР.РеестрДСВ: return РеестрДСВ;
				case ТипыФайловОтчетностиПФР.ПачкаРСВ: return ПачкаРСВ;
				case ТипыФайловОтчетностиПФР.ПачкаСВВ: return ПачкаСВВ;
			}
			return Guid.Empty;
		}
	}
}