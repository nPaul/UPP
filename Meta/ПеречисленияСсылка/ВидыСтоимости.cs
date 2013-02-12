﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыСтоимости
	{
		ПустаяСсылка = - 1,
	///<summary>
	///Выпуск по фактической стоимости
	///</summary>
		Фактическая = 0,//Выпуск по фактической стоимости
	///<summary>
	///Выпуск по плановой стоимости
	///</summary>
		Плановая = 1,//Выпуск по плановой стоимости
	///<summary>
	///Отклонение фактической стоимости выпуска от плановой
	///</summary>
		Отклонение = 2,
	}
	public static partial class ВидыСтоимости_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///Выпуск по фактической стоимости
		///</summary>
		public static readonly Guid Фактическая = new Guid("10cce9af-c3d5-88f2-47b8-c8c5b2e40314");//Выпуск по фактической стоимости
		///<summary>
		///Выпуск по плановой стоимости
		///</summary>
		public static readonly Guid Плановая = new Guid("3b06ce92-a857-ba93-4492-7fa51f1f9aa6");//Выпуск по плановой стоимости
		///<summary>
		///Отклонение фактической стоимости выпуска от плановой
		///</summary>
		public static readonly Guid Отклонение = new Guid("099be2b6-1a4f-76a9-473e-38d702a28c86");
		public static ВидыСтоимости Получить(this ВидыСтоимости Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыСтоимости Получить(this ВидыСтоимости Значение, Guid Ссылка)
		{
			if(Ссылка == Фактическая)
			{
				return ВидыСтоимости.Фактическая;
			}
			else if(Ссылка == Плановая)
			{
				return ВидыСтоимости.Плановая;
			}
			else if(Ссылка == Отклонение)
			{
				return ВидыСтоимости.Отклонение;
			}
			return ВидыСтоимости.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыСтоимости Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыСтоимости Значение)
		{
			switch (Значение)
			{
				case ВидыСтоимости.Фактическая: return Фактическая;
				case ВидыСтоимости.Плановая: return Плановая;
				case ВидыСтоимости.Отклонение: return Отклонение;
			}
			return Guid.Empty;
		}
	}
}