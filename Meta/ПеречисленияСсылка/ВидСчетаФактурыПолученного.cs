﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///Вид полученного счета-фактуры
	///</summary>
	[DataContract]
	public enum ВидСчетаФактурыПолученного
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"f4cd7548-af79-4ff7-a9e3-f12e9b843270\", \"Представление\":\"НаПоступление\"}")]
		НаПоступление = 0,//На поступление
		[EnumMember(Value = "{\"Ссылка\":\"3f40975a-d874-4c76-91f2-b3cd2e42c5dc\", \"Представление\":\"НаАванс\"}")]
		НаАванс = 1,//На аванс
		[EnumMember(Value = "{\"Ссылка\":\"ce8957c6-6b20-4833-a1bd-b6c12edfafa5\", \"Представление\":\"Корректировочный\"}")]
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