﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum МетодыРаспределенияПоПроектам
	{
		ПустаяСсылка = - 1,
		РегламентнымДокументом = 0,//Регламентным документом
		ПриПроведенииДокументов = 1,//При проведении документов
	}
	public static partial class МетодыРаспределенияПоПроектам_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid РегламентнымДокументом = new Guid("92fbffb3-d78f-6fe1-4130-afb30eff5e77");//Регламентным документом
		public static readonly Guid ПриПроведенииДокументов = new Guid("fd9c58a8-dde0-9fb8-41d3-282e6c837773");//При проведении документов
		public static МетодыРаспределенияПоПроектам Получить(this МетодыРаспределенияПоПроектам Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static МетодыРаспределенияПоПроектам Получить(this МетодыРаспределенияПоПроектам Значение, Guid Ссылка)
		{
			if(Ссылка == РегламентнымДокументом)
			{
				return МетодыРаспределенияПоПроектам.РегламентнымДокументом;
			}
			else if(Ссылка == ПриПроведенииДокументов)
			{
				return МетодыРаспределенияПоПроектам.ПриПроведенииДокументов;
			}
			return МетодыРаспределенияПоПроектам.ПустаяСсылка;
		}
		public static byte[] Ключ(this МетодыРаспределенияПоПроектам Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this МетодыРаспределенияПоПроектам Значение)
		{
			switch (Значение)
			{
				case МетодыРаспределенияПоПроектам.РегламентнымДокументом: return РегламентнымДокументом;
				case МетодыРаспределенияПоПроектам.ПриПроведенииДокументов: return ПриПроведенииДокументов;
			}
			return Guid.Empty;
		}
	}
}