﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыНалоговыхЛьготПоТранспортномуНалогу
	{
		ПустаяСсылка = - 1,
		НеПрименяется = 0,//Не применяется
		ОсвобождениеОтНалогообложения = 1,//Освобождение от налогообложения
		СнижениеНалоговойСтавки = 2,//Снижение налоговой ставки
		УменьшениеСуммыНалогаНаСумму = 3,//Уменьшение суммы налога (на сумму)
		УменьшениеСуммыНалогаВПроцентах = 4,//Уменьшение суммы налога (в процентах)
	}
	public static partial class ВидыНалоговыхЛьготПоТранспортномуНалогу_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НеПрименяется = new Guid("42008f8d-b958-bd5d-4d80-740fb169235d");//Не применяется
		public static readonly Guid ОсвобождениеОтНалогообложения = new Guid("36f19ca9-00d3-8168-409b-0bd012aba8da");//Освобождение от налогообложения
		public static readonly Guid СнижениеНалоговойСтавки = new Guid("02d24393-9864-4dff-45fa-d330d7b97451");//Снижение налоговой ставки
		public static readonly Guid УменьшениеСуммыНалогаНаСумму = new Guid("0c12ab8d-99a9-7356-4355-fb32a984e4ad");//Уменьшение суммы налога (на сумму)
		public static readonly Guid УменьшениеСуммыНалогаВПроцентах = new Guid("b7b6b2b9-89a9-bb6a-4848-363d55006ee1");//Уменьшение суммы налога (в процентах)
		public static ВидыНалоговыхЛьготПоТранспортномуНалогу Получить(this ВидыНалоговыхЛьготПоТранспортномуНалогу Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыНалоговыхЛьготПоТранспортномуНалогу Получить(this ВидыНалоговыхЛьготПоТранспортномуНалогу Значение, Guid Ссылка)
		{
			if(Ссылка == НеПрименяется)
			{
				return ВидыНалоговыхЛьготПоТранспортномуНалогу.НеПрименяется;
			}
			else if(Ссылка == ОсвобождениеОтНалогообложения)
			{
				return ВидыНалоговыхЛьготПоТранспортномуНалогу.ОсвобождениеОтНалогообложения;
			}
			else if(Ссылка == СнижениеНалоговойСтавки)
			{
				return ВидыНалоговыхЛьготПоТранспортномуНалогу.СнижениеНалоговойСтавки;
			}
			else if(Ссылка == УменьшениеСуммыНалогаНаСумму)
			{
				return ВидыНалоговыхЛьготПоТранспортномуНалогу.УменьшениеСуммыНалогаНаСумму;
			}
			else if(Ссылка == УменьшениеСуммыНалогаВПроцентах)
			{
				return ВидыНалоговыхЛьготПоТранспортномуНалогу.УменьшениеСуммыНалогаВПроцентах;
			}
			return ВидыНалоговыхЛьготПоТранспортномуНалогу.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыНалоговыхЛьготПоТранспортномуНалогу Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыНалоговыхЛьготПоТранспортномуНалогу Значение)
		{
			switch (Значение)
			{
				case ВидыНалоговыхЛьготПоТранспортномуНалогу.НеПрименяется: return НеПрименяется;
				case ВидыНалоговыхЛьготПоТранспортномуНалогу.ОсвобождениеОтНалогообложения: return ОсвобождениеОтНалогообложения;
				case ВидыНалоговыхЛьготПоТранспортномуНалогу.СнижениеНалоговойСтавки: return СнижениеНалоговойСтавки;
				case ВидыНалоговыхЛьготПоТранспортномуНалогу.УменьшениеСуммыНалогаНаСумму: return УменьшениеСуммыНалогаНаСумму;
				case ВидыНалоговыхЛьготПоТранспортномуНалогу.УменьшениеСуммыНалогаВПроцентах: return УменьшениеСуммыНалогаВПроцентах;
			}
			return Guid.Empty;
		}
	}
}