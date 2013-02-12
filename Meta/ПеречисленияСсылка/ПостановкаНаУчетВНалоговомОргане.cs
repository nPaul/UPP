﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ПостановкаНаУчетВНалоговомОргане
	{
		ПустаяСсылка = - 1,
		ПоМестуНахожденияОрганизации = 0,//По месту нахождения организации
		СДругимКодомПоОКАТО = 1,//С другим кодом по ОКАТО
		ВДругомНалоговомОргане = 2,//В другом налоговом органе
	}
	public static partial class ПостановкаНаУчетВНалоговомОргане_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоМестуНахожденияОрганизации = new Guid("298f4985-095d-e259-4ecd-54707cc7f8a0");//По месту нахождения организации
		public static readonly Guid СДругимКодомПоОКАТО = new Guid("0805cf80-dd03-07f9-49b4-5bc02d43490d");//С другим кодом по ОКАТО
		public static readonly Guid ВДругомНалоговомОргане = new Guid("7a84b293-1c13-a851-4285-351f568763b5");//В другом налоговом органе
		public static ПостановкаНаУчетВНалоговомОргане Получить(this ПостановкаНаУчетВНалоговомОргане Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПостановкаНаУчетВНалоговомОргане Получить(this ПостановкаНаУчетВНалоговомОргане Значение, Guid Ссылка)
		{
			if(Ссылка == ПоМестуНахожденияОрганизации)
			{
				return ПостановкаНаУчетВНалоговомОргане.ПоМестуНахожденияОрганизации;
			}
			else if(Ссылка == СДругимКодомПоОКАТО)
			{
				return ПостановкаНаУчетВНалоговомОргане.СДругимКодомПоОКАТО;
			}
			else if(Ссылка == ВДругомНалоговомОргане)
			{
				return ПостановкаНаУчетВНалоговомОргане.ВДругомНалоговомОргане;
			}
			return ПостановкаНаУчетВНалоговомОргане.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПостановкаНаУчетВНалоговомОргане Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПостановкаНаУчетВНалоговомОргане Значение)
		{
			switch (Значение)
			{
				case ПостановкаНаУчетВНалоговомОргане.ПоМестуНахожденияОрганизации: return ПоМестуНахожденияОрганизации;
				case ПостановкаНаУчетВНалоговомОргане.СДругимКодомПоОКАТО: return СДругимКодомПоОКАТО;
				case ПостановкаНаУчетВНалоговомОргане.ВДругомНалоговомОргане: return ВДругомНалоговомОргане;
			}
			return Guid.Empty;
		}
	}
}