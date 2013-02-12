﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыОрганизационнойСтруктурыПредприятия
	{
		ПустаяСсылка = - 1,
		ПоСтруктуреЮридическихЛиц = 0,//По структуре юридических лиц
		ПоЦентрамОтветственности = 1,//По центрам ответственности
	}
	public static partial class ВидыОрганизационнойСтруктурыПредприятия_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоСтруктуреЮридическихЛиц = new Guid("6f6d7e88-7dd9-76f5-4e51-85aee8e6156e");//По структуре юридических лиц
		public static readonly Guid ПоЦентрамОтветственности = new Guid("41757d82-7bf4-3707-4c84-9881611653ea");//По центрам ответственности
		public static ВидыОрганизационнойСтруктурыПредприятия Получить(this ВидыОрганизационнойСтруктурыПредприятия Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОрганизационнойСтруктурыПредприятия Получить(this ВидыОрганизационнойСтруктурыПредприятия Значение, Guid Ссылка)
		{
			if(Ссылка == ПоСтруктуреЮридическихЛиц)
			{
				return ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц;
			}
			else if(Ссылка == ПоЦентрамОтветственности)
			{
				return ВидыОрганизационнойСтруктурыПредприятия.ПоЦентрамОтветственности;
			}
			return ВидыОрганизационнойСтруктурыПредприятия.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОрганизационнойСтруктурыПредприятия Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОрганизационнойСтруктурыПредприятия Значение)
		{
			switch (Значение)
			{
				case ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц: return ПоСтруктуреЮридическихЛиц;
				case ВидыОрганизационнойСтруктурыПредприятия.ПоЦентрамОтветственности: return ПоЦентрамОтветственности;
			}
			return Guid.Empty;
		}
	}
}