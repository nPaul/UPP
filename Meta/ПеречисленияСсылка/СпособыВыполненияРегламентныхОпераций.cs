﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum СпособыВыполненияРегламентныхОпераций
	{
		ПустаяСсылка = - 1,
		Вручную = 0,
		Автоматически = 1,
		Принудительно = 2,//Без проверок
	}
	public static partial class СпособыВыполненияРегламентныхОпераций_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Вручную = new Guid("5ce355b4-9b3e-8937-49c8-7f718f739ea9");
		public static readonly Guid Автоматически = new Guid("5591dfac-b079-0df4-44ef-a809e7df8ec2");
		public static readonly Guid Принудительно = new Guid("25a70f9c-d035-69c7-4164-9dd222d7d106");//Без проверок
		public static СпособыВыполненияРегламентныхОпераций Получить(this СпособыВыполненияРегламентныхОпераций Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыВыполненияРегламентныхОпераций Получить(this СпособыВыполненияРегламентныхОпераций Значение, Guid Ссылка)
		{
			if(Ссылка == Вручную)
			{
				return СпособыВыполненияРегламентныхОпераций.Вручную;
			}
			else if(Ссылка == Автоматически)
			{
				return СпособыВыполненияРегламентныхОпераций.Автоматически;
			}
			else if(Ссылка == Принудительно)
			{
				return СпособыВыполненияРегламентныхОпераций.Принудительно;
			}
			return СпособыВыполненияРегламентныхОпераций.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыВыполненияРегламентныхОпераций Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыВыполненияРегламентныхОпераций Значение)
		{
			switch (Значение)
			{
				case СпособыВыполненияРегламентныхОпераций.Вручную: return Вручную;
				case СпособыВыполненияРегламентныхОпераций.Автоматически: return Автоматически;
				case СпособыВыполненияРегламентныхОпераций.Принудительно: return Принудительно;
			}
			return Guid.Empty;
		}
	}
}