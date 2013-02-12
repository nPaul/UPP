﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///Значения перечисления соответствуют способам назначения PLU новым товарным позициям, подлежащим выгрузке в ККМ Off-line
		///</summary>
	public enum ПорядокПрисвоенияPLU
	{
		ПустаяСсылка = - 1,
	///<summary>
	///Новой позиции назначается код, превосходящий максимальное заданное значение на 1
	///</summary>
		ПоПорядку = 0,//По порядку
	///<summary>
	///Новой позиции назначается код, совпадающий с кодом номенклатуры в соответствующей позиции
	///</summary>
		ПоКодуНоменклатуры = 1,//По коду номенклатуры
	}
	public static partial class ПорядокПрисвоенияPLU_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///Новой позиции назначается код, превосходящий максимальное заданное значение на 1
		///</summary>
		public static readonly Guid ПоПорядку = new Guid("04d465b3-013a-7766-4fb4-c92634f8e2a9");//По порядку
		///<summary>
		///Новой позиции назначается код, совпадающий с кодом номенклатуры в соответствующей позиции
		///</summary>
		public static readonly Guid ПоКодуНоменклатуры = new Guid("dec798be-b0af-68c9-45ca-fa0655ea011e");//По коду номенклатуры
		public static ПорядокПрисвоенияPLU Получить(this ПорядокПрисвоенияPLU Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПорядокПрисвоенияPLU Получить(this ПорядокПрисвоенияPLU Значение, Guid Ссылка)
		{
			if(Ссылка == ПоПорядку)
			{
				return ПорядокПрисвоенияPLU.ПоПорядку;
			}
			else if(Ссылка == ПоКодуНоменклатуры)
			{
				return ПорядокПрисвоенияPLU.ПоКодуНоменклатуры;
			}
			return ПорядокПрисвоенияPLU.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПорядокПрисвоенияPLU Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПорядокПрисвоенияPLU Значение)
		{
			switch (Значение)
			{
				case ПорядокПрисвоенияPLU.ПоПорядку: return ПоПорядку;
				case ПорядокПрисвоенияPLU.ПоКодуНоменклатуры: return ПоКодуНоменклатуры;
			}
			return Guid.Empty;
		}
	}
}