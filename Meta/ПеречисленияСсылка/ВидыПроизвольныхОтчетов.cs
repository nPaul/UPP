﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыПроизвольныхОтчетов
	{
		ПустаяСсылка = - 1,
		ПроизвольныйОтчет = 0,//Произвольный отчет
		ПоказательМонитораЭффективности = 1,//Показатель монитора эффективности
		ПоказательМонитораЭффективностиПланФакт = 2,//Показатель монитора эффективности (план-факт)
		ПоказательМонитораЭффективностиПрогноз = 3,//Показатель монитора эффективности (прогноз)
	}
	public static partial class ВидыПроизвольныхОтчетов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПроизвольныйОтчет = new Guid("d80d7ebc-6790-ab1e-4e94-d6a4446a8bd9");//Произвольный отчет
		public static readonly Guid ПоказательМонитораЭффективности = new Guid("bd06e0b6-0e11-b440-4e12-cff7ab4c3027");//Показатель монитора эффективности
		public static readonly Guid ПоказательМонитораЭффективностиПланФакт = new Guid("eedf589b-7118-1651-46db-93478f21ddf4");//Показатель монитора эффективности (план-факт)
		public static readonly Guid ПоказательМонитораЭффективностиПрогноз = new Guid("43420983-8c41-980c-41b3-7c95b5e32df1");//Показатель монитора эффективности (прогноз)
		public static ВидыПроизвольныхОтчетов Получить(this ВидыПроизвольныхОтчетов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыПроизвольныхОтчетов Получить(this ВидыПроизвольныхОтчетов Значение, Guid Ссылка)
		{
			if(Ссылка == ПроизвольныйОтчет)
			{
				return ВидыПроизвольныхОтчетов.ПроизвольныйОтчет;
			}
			else if(Ссылка == ПоказательМонитораЭффективности)
			{
				return ВидыПроизвольныхОтчетов.ПоказательМонитораЭффективности;
			}
			else if(Ссылка == ПоказательМонитораЭффективностиПланФакт)
			{
				return ВидыПроизвольныхОтчетов.ПоказательМонитораЭффективностиПланФакт;
			}
			else if(Ссылка == ПоказательМонитораЭффективностиПрогноз)
			{
				return ВидыПроизвольныхОтчетов.ПоказательМонитораЭффективностиПрогноз;
			}
			return ВидыПроизвольныхОтчетов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыПроизвольныхОтчетов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыПроизвольныхОтчетов Значение)
		{
			switch (Значение)
			{
				case ВидыПроизвольныхОтчетов.ПроизвольныйОтчет: return ПроизвольныйОтчет;
				case ВидыПроизвольныхОтчетов.ПоказательМонитораЭффективности: return ПоказательМонитораЭффективности;
				case ВидыПроизвольныхОтчетов.ПоказательМонитораЭффективностиПланФакт: return ПоказательМонитораЭффективностиПланФакт;
				case ВидыПроизвольныхОтчетов.ПоказательМонитораЭффективностиПрогноз: return ПоказательМонитораЭффективностиПрогноз;
			}
			return Guid.Empty;
		}
	}
}