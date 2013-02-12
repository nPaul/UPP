﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ПричиныИзмененияСостояния
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		ПриемНаРаботу = 0,//Прием на работу
	///<summary>
	///(Общ)
	///</summary>
		Перемещение = 1,
	///<summary>
	///(Общ)
	///</summary>
		Увольнение = 2,
	}
	public static partial class ПричиныИзмененияСостояния_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПриемНаРаботу = new Guid("35a52a80-d843-e776-4516-8658be039fa0");//Прием на работу
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Перемещение = new Guid("ca6d61bf-fb26-7fb1-470f-154ef835f3c7");
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Увольнение = new Guid("e5d0f385-bcbb-9e92-4d9f-6331c2c3998a");
		public static ПричиныИзмененияСостояния Получить(this ПричиныИзмененияСостояния Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПричиныИзмененияСостояния Получить(this ПричиныИзмененияСостояния Значение, Guid Ссылка)
		{
			if(Ссылка == ПриемНаРаботу)
			{
				return ПричиныИзмененияСостояния.ПриемНаРаботу;
			}
			else if(Ссылка == Перемещение)
			{
				return ПричиныИзмененияСостояния.Перемещение;
			}
			else if(Ссылка == Увольнение)
			{
				return ПричиныИзмененияСостояния.Увольнение;
			}
			return ПричиныИзмененияСостояния.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПричиныИзмененияСостояния Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПричиныИзмененияСостояния Значение)
		{
			switch (Значение)
			{
				case ПричиныИзмененияСостояния.ПриемНаРаботу: return ПриемНаРаботу;
				case ПричиныИзмененияСостояния.Перемещение: return Перемещение;
				case ПричиныИзмененияСостояния.Увольнение: return Увольнение;
			}
			return Guid.Empty;
		}
	}
}