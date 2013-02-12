﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыСообщений
	{
		ПустаяСсылка = - 1,
		Раздел = 0,
		Информация = 1,
		ВажнаяИнформация = 2,//Важная информация
		Ошибка = 3,
		Таблица = 4,
		ТаблицаСворачиваемаяСИтогами = 5,//Таблица сворачиваемая с итогами
	}
	public static partial class ВидыСообщений_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Раздел = new Guid("f035c898-0e47-9ca4-4d21-f803c95bb81e");
		public static readonly Guid Информация = new Guid("0f44c894-e114-22e2-4511-edc698255106");
		public static readonly Guid ВажнаяИнформация = new Guid("57a63c91-88c6-9a60-4337-ed6528fa5f41");//Важная информация
		public static readonly Guid Ошибка = new Guid("38484daa-e5eb-77c7-4649-b9a9e3001587");
		public static readonly Guid Таблица = new Guid("5d56a79b-fed8-6e26-4738-3cf9125e86f3");
		public static readonly Guid ТаблицаСворачиваемаяСИтогами = new Guid("97b5fea3-24f6-2c44-467f-419381060f82");//Таблица сворачиваемая с итогами
		public static ВидыСообщений Получить(this ВидыСообщений Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыСообщений Получить(this ВидыСообщений Значение, Guid Ссылка)
		{
			if(Ссылка == Раздел)
			{
				return ВидыСообщений.Раздел;
			}
			else if(Ссылка == Информация)
			{
				return ВидыСообщений.Информация;
			}
			else if(Ссылка == ВажнаяИнформация)
			{
				return ВидыСообщений.ВажнаяИнформация;
			}
			else if(Ссылка == Ошибка)
			{
				return ВидыСообщений.Ошибка;
			}
			else if(Ссылка == Таблица)
			{
				return ВидыСообщений.Таблица;
			}
			else if(Ссылка == ТаблицаСворачиваемаяСИтогами)
			{
				return ВидыСообщений.ТаблицаСворачиваемаяСИтогами;
			}
			return ВидыСообщений.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыСообщений Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыСообщений Значение)
		{
			switch (Значение)
			{
				case ВидыСообщений.Раздел: return Раздел;
				case ВидыСообщений.Информация: return Информация;
				case ВидыСообщений.ВажнаяИнформация: return ВажнаяИнформация;
				case ВидыСообщений.Ошибка: return Ошибка;
				case ВидыСообщений.Таблица: return Таблица;
				case ВидыСообщений.ТаблицаСворачиваемаяСИтогами: return ТаблицаСворачиваемаяСИтогами;
			}
			return Guid.Empty;
		}
	}
}