﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ТипыХраненияФайлов
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"6574d8f4-fb97-4a26-b166-711fad63aa07\", \"Представление\":\"ВИнформационнойБазе\"}")]
		ВИнформационнойБазе = 0,//В информационной базе
		[EnumMember(Value = "{\"Ссылка\":\"fb3eddaf-3241-4d59-8314-97a5ae9258c4\", \"Представление\":\"ВТомахНаДиске\"}")]
		ВТомахНаДиске = 1,//В томах на диске
	}
	public static partial class ТипыХраненияФайлов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ВИнформационнойБазе = new Guid("1f7166b1-63ad-07aa-4a26-fb976574d8f4");//В информационной базе
		public static readonly Guid ВТомахНаДиске = new Guid("a5971483-92ae-c458-4d59-3241fb3eddaf");//В томах на диске
		public static ТипыХраненияФайлов Получить(this ТипыХраненияФайлов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыХраненияФайлов Получить(this ТипыХраненияФайлов Значение, Guid Ссылка)
		{
			if(Ссылка == ВИнформационнойБазе)
			{
				return ТипыХраненияФайлов.ВИнформационнойБазе;
			}
			else if(Ссылка == ВТомахНаДиске)
			{
				return ТипыХраненияФайлов.ВТомахНаДиске;
			}
			return ТипыХраненияФайлов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыХраненияФайлов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыХраненияФайлов Значение)
		{
			switch (Значение)
			{
				case ТипыХраненияФайлов.ВИнформационнойБазе: return ВИнформационнойБазе;
				case ТипыХраненияФайлов.ВТомахНаДиске: return ВТомахНаДиске;
			}
			return Guid.Empty;
		}
	}
}