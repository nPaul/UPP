﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum МоментыОпределенияНалоговойБазыНДС
	{
		ПустаяСсылка = - 1,
		ПоОтгрузке = 0,//По отгрузке
		ПоОплате = 1,//По оплате
	}
	public static partial class МоментыОпределенияНалоговойБазыНДС_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоОтгрузке = new Guid("bbd07ea0-e30f-148c-4a0f-6f24830e3156");//По отгрузке
		public static readonly Guid ПоОплате = new Guid("091c59b6-a638-3612-4d67-21554eb7551f");//По оплате
		public static МоментыОпределенияНалоговойБазыНДС Получить(this МоментыОпределенияНалоговойБазыНДС Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static МоментыОпределенияНалоговойБазыНДС Получить(this МоментыОпределенияНалоговойБазыНДС Значение, Guid Ссылка)
		{
			if(Ссылка == ПоОтгрузке)
			{
				return МоментыОпределенияНалоговойБазыНДС.ПоОтгрузке;
			}
			else if(Ссылка == ПоОплате)
			{
				return МоментыОпределенияНалоговойБазыНДС.ПоОплате;
			}
			return МоментыОпределенияНалоговойБазыНДС.ПустаяСсылка;
		}
		public static byte[] Ключ(this МоментыОпределенияНалоговойБазыНДС Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this МоментыОпределенияНалоговойБазыНДС Значение)
		{
			switch (Значение)
			{
				case МоментыОпределенияНалоговойБазыНДС.ПоОтгрузке: return ПоОтгрузке;
				case МоментыОпределенияНалоговойБазыНДС.ПоОплате: return ПоОплате;
			}
			return Guid.Empty;
		}
	}
}