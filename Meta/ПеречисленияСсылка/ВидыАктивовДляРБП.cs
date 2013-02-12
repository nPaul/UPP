﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыАктивовДляРБП
	{
		ПустаяСсылка = - 1,
		ДебиторскаяЗадолженность = 0,//Дебиторская задолженность
		Запасы = 1,
		ПрочиеОборотныеАктивы = 2,//Прочие оборотные активы
		ПрочиеВнеоборотныеАктивы = 3,//Прочие внеоборотные активы
		ОсновныеСредства = 4,//Основные средства
	}
	public static partial class ВидыАктивовДляРБП_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ДебиторскаяЗадолженность = new Guid("0c8396bb-20b0-1f65-46d6-1a280d6236f7");//Дебиторская задолженность
		public static readonly Guid Запасы = new Guid("c941d2a7-dc64-97a7-4b0c-30c91a32660b");
		public static readonly Guid ПрочиеОборотныеАктивы = new Guid("a3e0be81-0a9e-6ec8-428e-a87d0ac1b59f");//Прочие оборотные активы
		public static readonly Guid ПрочиеВнеоборотныеАктивы = new Guid("09b8918d-f4ad-e6a2-4aba-5f9fd8561287");//Прочие внеоборотные активы
		public static readonly Guid ОсновныеСредства = new Guid("1dd2e29f-ae2b-452b-4ea4-19f85fb2cee6");//Основные средства
		public static ВидыАктивовДляРБП Получить(this ВидыАктивовДляРБП Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыАктивовДляРБП Получить(this ВидыАктивовДляРБП Значение, Guid Ссылка)
		{
			if(Ссылка == ДебиторскаяЗадолженность)
			{
				return ВидыАктивовДляРБП.ДебиторскаяЗадолженность;
			}
			else if(Ссылка == Запасы)
			{
				return ВидыАктивовДляРБП.Запасы;
			}
			else if(Ссылка == ПрочиеОборотныеАктивы)
			{
				return ВидыАктивовДляРБП.ПрочиеОборотныеАктивы;
			}
			else if(Ссылка == ПрочиеВнеоборотныеАктивы)
			{
				return ВидыАктивовДляРБП.ПрочиеВнеоборотныеАктивы;
			}
			else if(Ссылка == ОсновныеСредства)
			{
				return ВидыАктивовДляРБП.ОсновныеСредства;
			}
			return ВидыАктивовДляРБП.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыАктивовДляРБП Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыАктивовДляРБП Значение)
		{
			switch (Значение)
			{
				case ВидыАктивовДляРБП.ДебиторскаяЗадолженность: return ДебиторскаяЗадолженность;
				case ВидыАктивовДляРБП.Запасы: return Запасы;
				case ВидыАктивовДляРБП.ПрочиеОборотныеАктивы: return ПрочиеОборотныеАктивы;
				case ВидыАктивовДляРБП.ПрочиеВнеоборотныеАктивы: return ПрочиеВнеоборотныеАктивы;
				case ВидыАктивовДляРБП.ОсновныеСредства: return ОсновныеСредства;
			}
			return Guid.Empty;
		}
	}
}