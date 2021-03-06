﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum ДиректКостингБазаРаспределения
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"dc5c71ce-9d50-4c85-9f38-1f75f1031dc4\", \"Представление\":\"Себестоимость\"}")]
		Себестоимость = 0,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"52695f32-02f8-49ab-8cf0-e254d25ed0b2\", \"Представление\":\"ВыручкаОтПродаж\"}")]
		ВыручкаОтПродаж = 1,//Выручка от продаж
	}
	public static partial class ДиректКостингБазаРаспределения_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Себестоимость = new Guid("751f389f-03f1-c41d-4c85-9d50dc5c71ce");
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВыручкаОтПродаж = new Guid("54e2f08c-5ed2-b2d0-49ab-02f852695f32");//Выручка от продаж
		public static ДиректКостингБазаРаспределения Получить(this ДиректКостингБазаРаспределения Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ДиректКостингБазаРаспределения Получить(this ДиректКостингБазаРаспределения Значение, Guid Ссылка)
		{
			if(Ссылка == Себестоимость)
			{
				return ДиректКостингБазаРаспределения.Себестоимость;
			}
			else if(Ссылка == ВыручкаОтПродаж)
			{
				return ДиректКостингБазаРаспределения.ВыручкаОтПродаж;
			}
			return ДиректКостингБазаРаспределения.ПустаяСсылка;
		}
		public static byte[] Ключ(this ДиректКостингБазаРаспределения Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ДиректКостингБазаРаспределения Значение)
		{
			switch (Значение)
			{
				case ДиректКостингБазаРаспределения.Себестоимость: return Себестоимость;
				case ДиректКостингБазаРаспределения.ВыручкаОтПродаж: return ВыручкаОтПродаж;
			}
			return Guid.Empty;
		}
	}
}