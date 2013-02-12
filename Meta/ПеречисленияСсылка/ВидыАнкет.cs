﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыАнкет
	{
		ПустаяСсылка = - 1,
		Опрос = 0,
		Тестирование = 1,
	}
	public static partial class ВидыАнкет_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Опрос = new Guid("d92bd89f-7deb-708f-4332-b2826b7ca2ca");
		public static readonly Guid Тестирование = new Guid("d0fd90ac-6747-703b-439f-c5f50ba86304");
		public static ВидыАнкет Получить(this ВидыАнкет Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыАнкет Получить(this ВидыАнкет Значение, Guid Ссылка)
		{
			if(Ссылка == Опрос)
			{
				return ВидыАнкет.Опрос;
			}
			else if(Ссылка == Тестирование)
			{
				return ВидыАнкет.Тестирование;
			}
			return ВидыАнкет.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыАнкет Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыАнкет Значение)
		{
			switch (Значение)
			{
				case ВидыАнкет.Опрос: return Опрос;
				case ВидыАнкет.Тестирование: return Тестирование;
			}
			return Guid.Empty;
		}
	}
}