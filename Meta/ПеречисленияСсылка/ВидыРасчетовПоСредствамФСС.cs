﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыРасчетовПоСредствамФСС
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"aea710ff-f44e-4839-99d1-3a9455c3ea96\", \"Представление\":\"РасходыПоСтрахованию\"}")]
		РасходыПоСтрахованию = 0,//Расходы по страхованию
		[EnumMember(Value = "{\"Ссылка\":\"8a37e833-0ac1-4e42-99a0-d91b2d43abc2\", \"Представление\":\"ПеречисленоСтрахователем\"}")]
		ПеречисленоСтрахователем = 1,//Перечислено страхователем
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"7fb224a5-580e-4085-b45b-87e78c51cc72\", \"Представление\":\"НеПринято\"}")]
		НеПринято = 2,//Не принято к зачету
	}
	public static partial class ВидыРасчетовПоСредствамФСС_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid РасходыПоСтрахованию = new Guid("943ad199-c355-96ea-4839-f44eaea710ff");//Расходы по страхованию
		public static readonly Guid ПеречисленоСтрахователем = new Guid("1bd9a099-432d-c2ab-4e42-0ac18a37e833");//Перечислено страхователем
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid НеПринято = new Guid("e7875bb4-518c-72cc-4085-580e7fb224a5");//Не принято к зачету
		public static ВидыРасчетовПоСредствамФСС Получить(this ВидыРасчетовПоСредствамФСС Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыРасчетовПоСредствамФСС Получить(this ВидыРасчетовПоСредствамФСС Значение, Guid Ссылка)
		{
			if(Ссылка == РасходыПоСтрахованию)
			{
				return ВидыРасчетовПоСредствамФСС.РасходыПоСтрахованию;
			}
			else if(Ссылка == ПеречисленоСтрахователем)
			{
				return ВидыРасчетовПоСредствамФСС.ПеречисленоСтрахователем;
			}
			else if(Ссылка == НеПринято)
			{
				return ВидыРасчетовПоСредствамФСС.НеПринято;
			}
			return ВидыРасчетовПоСредствамФСС.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыРасчетовПоСредствамФСС Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыРасчетовПоСредствамФСС Значение)
		{
			switch (Значение)
			{
				case ВидыРасчетовПоСредствамФСС.РасходыПоСтрахованию: return РасходыПоСтрахованию;
				case ВидыРасчетовПоСредствамФСС.ПеречисленоСтрахователем: return ПеречисленоСтрахователем;
				case ВидыРасчетовПоСредствамФСС.НеПринято: return НеПринято;
			}
			return Guid.Empty;
		}
	}
}