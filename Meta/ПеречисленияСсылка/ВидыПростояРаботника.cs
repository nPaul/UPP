﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum ВидыПростояРаботника
	{
		ПустаяСсылка = - 1,
		ПоВинеРаботодателя = 0,//По вине работодателя
		ПоНезависящимПричинам = 1,//По причинам, не зависящим от работодателя и сотрудника
	}
	public static partial class ВидыПростояРаботника_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоВинеРаботодателя = new Guid("40bca087-ec25-8649-46b9-cac6350d3bee");//По вине работодателя
		public static readonly Guid ПоНезависящимПричинам = new Guid("47ec628b-12a5-8efb-4218-a1350b0d24df");//По причинам, не зависящим от работодателя и сотрудника
		public static ВидыПростояРаботника Получить(this ВидыПростояРаботника Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыПростояРаботника Получить(this ВидыПростояРаботника Значение, Guid Ссылка)
		{
			if(Ссылка == ПоВинеРаботодателя)
			{
				return ВидыПростояРаботника.ПоВинеРаботодателя;
			}
			else if(Ссылка == ПоНезависящимПричинам)
			{
				return ВидыПростояРаботника.ПоНезависящимПричинам;
			}
			return ВидыПростояРаботника.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыПростояРаботника Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыПростояРаботника Значение)
		{
			switch (Значение)
			{
				case ВидыПростояРаботника.ПоВинеРаботодателя: return ПоВинеРаботодателя;
				case ВидыПростояРаботника.ПоНезависящимПричинам: return ПоНезависящимПричинам;
			}
			return Guid.Empty;
		}
	}
}