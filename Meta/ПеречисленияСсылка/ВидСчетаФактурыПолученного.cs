﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///Вид полученного счета-фактуры
		///</summary>
	public enum ВидСчетаФактурыПолученного
	{
		ПустаяСсылка = - 1,
		НаПоступление = 0,//На поступление
		НаАванс = 1,//На аванс
		Корректировочный = 2,
	}
	public static partial class ВидСчетаФактурыПолученного_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НаПоступление = new Guid("2ef1e3a9-849b-7032-4ff7-af79f4cd7548");//На поступление
		public static readonly Guid НаАванс = new Guid("cdb3f291-422e-dcc5-4c76-d8743f40975a");//На аванс
		public static readonly Guid Корректировочный = new Guid("c1b6bda1-df2e-a5af-4833-6b20ce8957c6");
		public static ВидСчетаФактурыПолученного Получить(this ВидСчетаФактурыПолученного Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидСчетаФактурыПолученного Получить(this ВидСчетаФактурыПолученного Значение, Guid Ссылка)
		{
			if(Ссылка == НаПоступление)
			{
				return ВидСчетаФактурыПолученного.НаПоступление;
			}
			else if(Ссылка == НаАванс)
			{
				return ВидСчетаФактурыПолученного.НаАванс;
			}
			else if(Ссылка == Корректировочный)
			{
				return ВидСчетаФактурыПолученного.Корректировочный;
			}
			return ВидСчетаФактурыПолученного.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидСчетаФактурыПолученного Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидСчетаФактурыПолученного Значение)
		{
			switch (Значение)
			{
				case ВидСчетаФактурыПолученного.НаПоступление: return НаПоступление;
				case ВидСчетаФактурыПолученного.НаАванс: return НаАванс;
				case ВидСчетаФактурыПолученного.Корректировочный: return Корректировочный;
			}
			return Guid.Empty;
		}
	}
}