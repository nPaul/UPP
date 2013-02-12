﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ФорматыДатаВремениЗначенияРазряда
	{
		ПустаяСсылка = - 1,
		Дата = 0,
		ДатаВремя = 1,//Дата / время
		Время = 2,
		Минута = 3,
		Час = 4,
		ДеньНедели = 5,//День недели
		ДеньМесяца = 6,//День месяца
		ДеньГода = 7,//День года
		Месяц = 8,
		Квартал = 9,
		Год = 10,
	}
	public static partial class ФорматыДатаВремениЗначенияРазряда_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Дата = new Guid("c9a293a0-ebb8-42c0-4106-bc7d3573c37d");
		public static readonly Guid ДатаВремя = new Guid("3970acb6-7ade-0228-41dd-09b1f9edd561");//Дата / время
		public static readonly Guid Время = new Guid("212e749f-5005-0d20-4713-e2cd893ba69c");
		public static readonly Guid Минута = new Guid("4a85c685-85ee-836c-480a-eda728fc7b3d");
		public static readonly Guid Час = new Guid("ffcd32ae-99bc-9a04-4dfe-48da18be2702");
		public static readonly Guid ДеньНедели = new Guid("610dcfbe-46ac-c84a-486e-1b97d0401444");//День недели
		public static readonly Guid ДеньМесяца = new Guid("49e375ac-e121-e391-4743-a45b74ab50d3");//День месяца
		public static readonly Guid ДеньГода = new Guid("1acd2dbc-b488-c04e-497d-ab179717bc19");//День года
		public static readonly Guid Месяц = new Guid("9e852981-a868-4e0c-4255-3bf9b92e6396");
		public static readonly Guid Квартал = new Guid("50085598-a195-ed2e-40c6-7d15e9381f22");
		public static readonly Guid Год = new Guid("03e535bf-8094-d6bd-4597-a76da04fd743");
		public static ФорматыДатаВремениЗначенияРазряда Получить(this ФорматыДатаВремениЗначенияРазряда Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ФорматыДатаВремениЗначенияРазряда Получить(this ФорматыДатаВремениЗначенияРазряда Значение, Guid Ссылка)
		{
			if(Ссылка == Дата)
			{
				return ФорматыДатаВремениЗначенияРазряда.Дата;
			}
			else if(Ссылка == ДатаВремя)
			{
				return ФорматыДатаВремениЗначенияРазряда.ДатаВремя;
			}
			else if(Ссылка == Время)
			{
				return ФорматыДатаВремениЗначенияРазряда.Время;
			}
			else if(Ссылка == Минута)
			{
				return ФорматыДатаВремениЗначенияРазряда.Минута;
			}
			else if(Ссылка == Час)
			{
				return ФорматыДатаВремениЗначенияРазряда.Час;
			}
			else if(Ссылка == ДеньНедели)
			{
				return ФорматыДатаВремениЗначенияРазряда.ДеньНедели;
			}
			else if(Ссылка == ДеньМесяца)
			{
				return ФорматыДатаВремениЗначенияРазряда.ДеньМесяца;
			}
			else if(Ссылка == ДеньГода)
			{
				return ФорматыДатаВремениЗначенияРазряда.ДеньГода;
			}
			else if(Ссылка == Месяц)
			{
				return ФорматыДатаВремениЗначенияРазряда.Месяц;
			}
			else if(Ссылка == Квартал)
			{
				return ФорматыДатаВремениЗначенияРазряда.Квартал;
			}
			else if(Ссылка == Год)
			{
				return ФорматыДатаВремениЗначенияРазряда.Год;
			}
			return ФорматыДатаВремениЗначенияРазряда.ПустаяСсылка;
		}
		public static byte[] Ключ(this ФорматыДатаВремениЗначенияРазряда Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ФорматыДатаВремениЗначенияРазряда Значение)
		{
			switch (Значение)
			{
				case ФорматыДатаВремениЗначенияРазряда.Дата: return Дата;
				case ФорматыДатаВремениЗначенияРазряда.ДатаВремя: return ДатаВремя;
				case ФорматыДатаВремениЗначенияРазряда.Время: return Время;
				case ФорматыДатаВремениЗначенияРазряда.Минута: return Минута;
				case ФорматыДатаВремениЗначенияРазряда.Час: return Час;
				case ФорматыДатаВремениЗначенияРазряда.ДеньНедели: return ДеньНедели;
				case ФорматыДатаВремениЗначенияРазряда.ДеньМесяца: return ДеньМесяца;
				case ФорматыДатаВремениЗначенияРазряда.ДеньГода: return ДеньГода;
				case ФорматыДатаВремениЗначенияРазряда.Месяц: return Месяц;
				case ФорматыДатаВремениЗначенияРазряда.Квартал: return Квартал;
				case ФорматыДатаВремениЗначенияРазряда.Год: return Год;
			}
			return Guid.Empty;
		}
	}
}