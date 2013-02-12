﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///Субъекты доверенности налогоплательщика
		///</summary>
	public enum СубъектыДоверенностиНалогоплательщика
	{
		ПустаяСсылка = - 1,
		ДоверительРук = 0,
		ДоверительФЛ = 1,
		ДоверительЮЛ = 2,
		ПредставительЮЛ = 3,
		ПредставительФЛ = 4,//Представитель ФЛ
		НотариусФЛ = 5,
	}
	public static partial class СубъектыДоверенностиНалогоплательщика_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ДоверительРук = new Guid("de66738a-39bd-c9b7-49ee-4c693bcbceea");
		public static readonly Guid ДоверительФЛ = new Guid("cf4be29c-e4cb-09fb-4857-44010ea68d24");
		public static readonly Guid ДоверительЮЛ = new Guid("df8b42a5-98a5-0dac-48df-86f1c69a1571");
		public static readonly Guid ПредставительЮЛ = new Guid("a24473b6-5f0e-b163-4613-40e468079e20");
		public static readonly Guid ПредставительФЛ = new Guid("54f3fea4-d02e-9150-46f5-ec399a7a1469");//Представитель ФЛ
		public static readonly Guid НотариусФЛ = new Guid("a30ef2ab-7f4d-673b-49cc-f2bf411f3008");
		public static СубъектыДоверенностиНалогоплательщика Получить(this СубъектыДоверенностиНалогоплательщика Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СубъектыДоверенностиНалогоплательщика Получить(this СубъектыДоверенностиНалогоплательщика Значение, Guid Ссылка)
		{
			if(Ссылка == ДоверительРук)
			{
				return СубъектыДоверенностиНалогоплательщика.ДоверительРук;
			}
			else if(Ссылка == ДоверительФЛ)
			{
				return СубъектыДоверенностиНалогоплательщика.ДоверительФЛ;
			}
			else if(Ссылка == ДоверительЮЛ)
			{
				return СубъектыДоверенностиНалогоплательщика.ДоверительЮЛ;
			}
			else if(Ссылка == ПредставительЮЛ)
			{
				return СубъектыДоверенностиНалогоплательщика.ПредставительЮЛ;
			}
			else if(Ссылка == ПредставительФЛ)
			{
				return СубъектыДоверенностиНалогоплательщика.ПредставительФЛ;
			}
			else if(Ссылка == НотариусФЛ)
			{
				return СубъектыДоверенностиНалогоплательщика.НотариусФЛ;
			}
			return СубъектыДоверенностиНалогоплательщика.ПустаяСсылка;
		}
		public static byte[] Ключ(this СубъектыДоверенностиНалогоплательщика Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СубъектыДоверенностиНалогоплательщика Значение)
		{
			switch (Значение)
			{
				case СубъектыДоверенностиНалогоплательщика.ДоверительРук: return ДоверительРук;
				case СубъектыДоверенностиНалогоплательщика.ДоверительФЛ: return ДоверительФЛ;
				case СубъектыДоверенностиНалогоплательщика.ДоверительЮЛ: return ДоверительЮЛ;
				case СубъектыДоверенностиНалогоплательщика.ПредставительЮЛ: return ПредставительЮЛ;
				case СубъектыДоверенностиНалогоплательщика.ПредставительФЛ: return ПредставительФЛ;
				case СубъектыДоверенностиНалогоплательщика.НотариусФЛ: return НотариусФЛ;
			}
			return Guid.Empty;
		}
	}
}