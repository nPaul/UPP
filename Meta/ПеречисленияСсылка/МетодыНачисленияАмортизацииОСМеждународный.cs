﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum МетодыНачисленияАмортизацииОСМеждународный
	{
		ПустаяСсылка = - 1,
	///<summary>
	///Оригинальное название - straight-line method
	///</summary>
		Линейный = 0,
	///<summary>
	///Оригинальное название - diminishing balance method
	///</summary>
		УменьшаемогоОстатка = 1,//Метод уменьшаемого остатка
	///<summary>
	///Оригинальное название - sum-of-the-units method
	///</summary>
		ПропорциональноОбъемуПродукции = 2,//Пропорционально объему продукции
	}
	public static partial class МетодыНачисленияАмортизацииОСМеждународный_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///Оригинальное название - straight-line method
		///</summary>
		public static readonly Guid Линейный = new Guid("50008596-83ba-8ec2-11d8-5242547506cb");
		///<summary>
		///Оригинальное название - diminishing balance method
		///</summary>
		public static readonly Guid УменьшаемогоОстатка = new Guid("50008596-83ba-8ec2-11d8-5242547506cc");//Метод уменьшаемого остатка
		///<summary>
		///Оригинальное название - sum-of-the-units method
		///</summary>
		public static readonly Guid ПропорциональноОбъемуПродукции = new Guid("50008596-83ba-8ec2-11d8-5242547506cd");//Пропорционально объему продукции
		public static МетодыНачисленияАмортизацииОСМеждународный Получить(this МетодыНачисленияАмортизацииОСМеждународный Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static МетодыНачисленияАмортизацииОСМеждународный Получить(this МетодыНачисленияАмортизацииОСМеждународный Значение, Guid Ссылка)
		{
			if(Ссылка == Линейный)
			{
				return МетодыНачисленияАмортизацииОСМеждународный.Линейный;
			}
			else if(Ссылка == УменьшаемогоОстатка)
			{
				return МетодыНачисленияАмортизацииОСМеждународный.УменьшаемогоОстатка;
			}
			else if(Ссылка == ПропорциональноОбъемуПродукции)
			{
				return МетодыНачисленияАмортизацииОСМеждународный.ПропорциональноОбъемуПродукции;
			}
			return МетодыНачисленияАмортизацииОСМеждународный.ПустаяСсылка;
		}
		public static byte[] Ключ(this МетодыНачисленияАмортизацииОСМеждународный Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this МетодыНачисленияАмортизацииОСМеждународный Значение)
		{
			switch (Значение)
			{
				case МетодыНачисленияАмортизацииОСМеждународный.Линейный: return Линейный;
				case МетодыНачисленияАмортизацииОСМеждународный.УменьшаемогоОстатка: return УменьшаемогоОстатка;
				case МетодыНачисленияАмортизацииОСМеждународный.ПропорциональноОбъемуПродукции: return ПропорциональноОбъемуПродукции;
			}
			return Guid.Empty;
		}
	}
}