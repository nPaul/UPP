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
	public enum ВидыДействияСНачислением
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"a17977fc-4b7c-468b-aabb-04768376faf6\", \"Представление\":\"Начать\"}")]
		Начать = 0,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"b9c2a3c9-d019-48d8-8448-dda172e0a8b1\", \"Представление\":\"Изменить\"}")]
		Изменить = 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"9ddf0807-1089-4c31-848a-8af50d529014\", \"Представление\":\"НеИзменять\"}")]
		НеИзменять = 2,//Не изменять
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"ec0d0d14-0090-486c-9c1a-389221c21b12\", \"Представление\":\"Прекратить\"}")]
		Прекратить = 3,
	}
	public static partial class ВидыДействияСНачислением_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Начать = new Guid("7604bbaa-7683-f6fa-468b-4b7ca17977fc");
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Изменить = new Guid("a1dd4884-e072-b1a8-48d8-d019b9c2a3c9");
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid НеИзменять = new Guid("f58a8a84-520d-1490-4c31-10899ddf0807");//Не изменять
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Прекратить = new Guid("92381a9c-c221-121b-486c-0090ec0d0d14");
		public static ВидыДействияСНачислением Получить(this ВидыДействияСНачислением Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДействияСНачислением Получить(this ВидыДействияСНачислением Значение, Guid Ссылка)
		{
			if(Ссылка == Начать)
			{
				return ВидыДействияСНачислением.Начать;
			}
			else if(Ссылка == Изменить)
			{
				return ВидыДействияСНачислением.Изменить;
			}
			else if(Ссылка == НеИзменять)
			{
				return ВидыДействияСНачислением.НеИзменять;
			}
			else if(Ссылка == Прекратить)
			{
				return ВидыДействияСНачислением.Прекратить;
			}
			return ВидыДействияСНачислением.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДействияСНачислением Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДействияСНачислением Значение)
		{
			switch (Значение)
			{
				case ВидыДействияСНачислением.Начать: return Начать;
				case ВидыДействияСНачислением.Изменить: return Изменить;
				case ВидыДействияСНачислением.НеИзменять: return НеИзменять;
				case ВидыДействияСНачислением.Прекратить: return Прекратить;
			}
			return Guid.Empty;
		}
	}
}