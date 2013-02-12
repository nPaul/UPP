﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///Виды операций по вводу начальных остатков для подсистемы учета НДС
		///</summary>
	public enum ВидыОперацийВводНачОстатковНДС
	{
		ПустаяСсылка = - 1,
		НДСПоПриобретеннымЦенностям = 0,//НДС по приобретенным ценностям
		НДСпоАвансамПолученным = 1,//НДС по авансам полученным
		НДСНеПолученныйОтПокупателей = 2,//НДС неполученный от покупателей
		НДСпоСМРдляСобственногоПотребления = 3,//НДС по СМР для собственного потребления
		НДСПоАвансамВыданным = 4,//НДС по авансам выданным
	}
	public static partial class ВидыОперацийВводНачОстатковНДС_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НДСПоПриобретеннымЦенностям = new Guid("6ef66fba-bc32-cf54-405b-7a8e3e76c6be");//НДС по приобретенным ценностям
		public static readonly Guid НДСпоАвансамПолученным = new Guid("50c9b68f-613d-9769-4d3a-57a756439548");//НДС по авансам полученным
		public static readonly Guid НДСНеПолученныйОтПокупателей = new Guid("6fda9daf-ee55-b14d-4314-1abd645734de");//НДС неполученный от покупателей
		public static readonly Guid НДСпоСМРдляСобственногоПотребления = new Guid("43a1b191-3147-c309-41e8-c344b2514998");//НДС по СМР для собственного потребления
		public static readonly Guid НДСПоАвансамВыданным = new Guid("f8d622b4-40dd-f48d-48a7-6332edb9a126");//НДС по авансам выданным
		public static ВидыОперацийВводНачОстатковНДС Получить(this ВидыОперацийВводНачОстатковНДС Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийВводНачОстатковНДС Получить(this ВидыОперацийВводНачОстатковНДС Значение, Guid Ссылка)
		{
			if(Ссылка == НДСПоПриобретеннымЦенностям)
			{
				return ВидыОперацийВводНачОстатковНДС.НДСПоПриобретеннымЦенностям;
			}
			else if(Ссылка == НДСпоАвансамПолученным)
			{
				return ВидыОперацийВводНачОстатковНДС.НДСпоАвансамПолученным;
			}
			else if(Ссылка == НДСНеПолученныйОтПокупателей)
			{
				return ВидыОперацийВводНачОстатковНДС.НДСНеПолученныйОтПокупателей;
			}
			else if(Ссылка == НДСпоСМРдляСобственногоПотребления)
			{
				return ВидыОперацийВводНачОстатковНДС.НДСпоСМРдляСобственногоПотребления;
			}
			else if(Ссылка == НДСПоАвансамВыданным)
			{
				return ВидыОперацийВводНачОстатковНДС.НДСПоАвансамВыданным;
			}
			return ВидыОперацийВводНачОстатковНДС.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийВводНачОстатковНДС Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийВводНачОстатковНДС Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийВводНачОстатковНДС.НДСПоПриобретеннымЦенностям: return НДСПоПриобретеннымЦенностям;
				case ВидыОперацийВводНачОстатковНДС.НДСпоАвансамПолученным: return НДСпоАвансамПолученным;
				case ВидыОперацийВводНачОстатковНДС.НДСНеПолученныйОтПокупателей: return НДСНеПолученныйОтПокупателей;
				case ВидыОперацийВводНачОстатковНДС.НДСпоСМРдляСобственногоПотребления: return НДСпоСМРдляСобственногоПотребления;
				case ВидыОперацийВводНачОстатковНДС.НДСПоАвансамВыданным: return НДСПоАвансамВыданным;
			}
			return Guid.Empty;
		}
	}
}