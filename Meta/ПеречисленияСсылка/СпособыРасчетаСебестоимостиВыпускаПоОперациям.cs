﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum СпособыРасчетаСебестоимостиВыпускаПоОперациям
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		ПоНулевойСтоимости = 0,//По нулевой стоимости
	///<summary>
	///(Общ)
	///</summary>
		ПоПлановойСебестоимости = 1,//По плановой себестоимости
	///<summary>
	///(Общ)
	///</summary>
		ПоПрямымЗатратам = 2,//По прямым затратам
	}
	public static partial class СпособыРасчетаСебестоимостиВыпускаПоОперациям_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоНулевойСтоимости = new Guid("46041c9e-6ae4-aa6a-4263-48ee4b4f8947");//По нулевой стоимости
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоПлановойСебестоимости = new Guid("725a178a-a5c4-59a3-4c66-fbe555b08be0");//По плановой себестоимости
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоПрямымЗатратам = new Guid("564315b8-c269-ed7d-448f-788cfc72cc44");//По прямым затратам
		public static СпособыРасчетаСебестоимостиВыпускаПоОперациям Получить(this СпособыРасчетаСебестоимостиВыпускаПоОперациям Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыРасчетаСебестоимостиВыпускаПоОперациям Получить(this СпособыРасчетаСебестоимостиВыпускаПоОперациям Значение, Guid Ссылка)
		{
			if(Ссылка == ПоНулевойСтоимости)
			{
				return СпособыРасчетаСебестоимостиВыпускаПоОперациям.ПоНулевойСтоимости;
			}
			else if(Ссылка == ПоПлановойСебестоимости)
			{
				return СпособыРасчетаСебестоимостиВыпускаПоОперациям.ПоПлановойСебестоимости;
			}
			else if(Ссылка == ПоПрямымЗатратам)
			{
				return СпособыРасчетаСебестоимостиВыпускаПоОперациям.ПоПрямымЗатратам;
			}
			return СпособыРасчетаСебестоимостиВыпускаПоОперациям.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыРасчетаСебестоимостиВыпускаПоОперациям Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыРасчетаСебестоимостиВыпускаПоОперациям Значение)
		{
			switch (Значение)
			{
				case СпособыРасчетаСебестоимостиВыпускаПоОперациям.ПоНулевойСтоимости: return ПоНулевойСтоимости;
				case СпособыРасчетаСебестоимостиВыпускаПоОперациям.ПоПлановойСебестоимости: return ПоПлановойСебестоимости;
				case СпособыРасчетаСебестоимостиВыпускаПоОперациям.ПоПрямымЗатратам: return ПоПрямымЗатратам;
			}
			return Guid.Empty;
		}
	}
}