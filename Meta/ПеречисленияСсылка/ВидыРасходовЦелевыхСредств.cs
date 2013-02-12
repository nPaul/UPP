﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum ВидыРасходовЦелевыхСредств
	{
		ПустаяСсылка = - 1,
		РасходыСвязанныеСОплатойТруда = 0,//Расходы, связанные с оплатой труда
		ВыплатыНеСвязанныеСОплатойТруда = 1,//Выплаты, не связанные с оплатой труда
		ОказаниеСоциальнойИБлаготворительнойПомощи = 2,//Оказание социальной и благотворительной помощи
		ПроведениеКонференцийСеминаров = 3,//Проведение конференций, семинаров и т.п.
		ПроведениеИныхЦелевыхМероприятий = 4,//Проведение иных целевых мероприятий
		РасходыНаСлужебныеКомандировкиИДеловыеПоездки = 5,//Расходы на служебные командировки и деловые поездки
		СодержаниеПомещенийЗданийАвтотранспортаИИногоИмущества = 6,//Содержание помещений, зданий, автомобильного транспорта и иного имущества
		РемонтОсновныхСредствИИногоИмущества = 7,//Ремонт основных средств и иного имущества
		ПрочиеРасходыНаСодержаниеАппаратаУправления = 8,//Прочие расходы на содержание аппарата управления
		ПриобретениеОсновныхСредствИнвентаряИИногоИмущества = 9,//Приобретение основных средств, инвентаря и иного имущества
		РасходыСвязанныеСПредпринимательскойДеятельностью = 10,//Расходы, связанные с предпринимательской деятельностью
		ПрочиеРасходы = 11,//Прочие расходы
	}
	public static partial class ВидыРасходовЦелевыхСредств_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid РасходыСвязанныеСОплатойТруда = new Guid("cda7d4bc-bcca-2d23-4b34-09f8d8aaaaaa");//Расходы, связанные с оплатой труда
		public static readonly Guid ВыплатыНеСвязанныеСОплатойТруда = new Guid("bcc95a8f-9f19-0645-42c9-829a1832f6d4");//Выплаты, не связанные с оплатой труда
		public static readonly Guid ОказаниеСоциальнойИБлаготворительнойПомощи = new Guid("eb4e1bbc-b861-0a1d-45fb-694dd5abc361");//Оказание социальной и благотворительной помощи
		public static readonly Guid ПроведениеКонференцийСеминаров = new Guid("164a64ba-9aea-63d7-44da-72d8f3f4f5e9");//Проведение конференций, семинаров и т.п.
		public static readonly Guid ПроведениеИныхЦелевыхМероприятий = new Guid("932a30a4-f9e7-8816-4646-c01fe2898238");//Проведение иных целевых мероприятий
		public static readonly Guid РасходыНаСлужебныеКомандировкиИДеловыеПоездки = new Guid("4264aca5-fcdf-837c-43ca-271e4ade4553");//Расходы на служебные командировки и деловые поездки
		public static readonly Guid СодержаниеПомещенийЗданийАвтотранспортаИИногоИмущества = new Guid("18382a8f-9e44-236f-41da-a300e77f685e");//Содержание помещений, зданий, автомобильного транспорта и иного имущества
		public static readonly Guid РемонтОсновныхСредствИИногоИмущества = new Guid("fee9c292-1f49-67b5-475d-25641a932b40");//Ремонт основных средств и иного имущества
		public static readonly Guid ПрочиеРасходыНаСодержаниеАппаратаУправления = new Guid("ca3b5799-6971-d5d4-4932-f1a414ea8420");//Прочие расходы на содержание аппарата управления
		public static readonly Guid ПриобретениеОсновныхСредствИнвентаряИИногоИмущества = new Guid("c47b4980-5fea-374d-4987-e4f22cd9f392");//Приобретение основных средств, инвентаря и иного имущества
		public static readonly Guid РасходыСвязанныеСПредпринимательскойДеятельностью = new Guid("e804d7b9-b323-4c15-4b2e-17cef35b778e");//Расходы, связанные с предпринимательской деятельностью
		public static readonly Guid ПрочиеРасходы = new Guid("3d7bb198-6eb5-3fd0-4e99-a96a3e42c5c8");//Прочие расходы
		public static ВидыРасходовЦелевыхСредств Получить(this ВидыРасходовЦелевыхСредств Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыРасходовЦелевыхСредств Получить(this ВидыРасходовЦелевыхСредств Значение, Guid Ссылка)
		{
			if(Ссылка == РасходыСвязанныеСОплатойТруда)
			{
				return ВидыРасходовЦелевыхСредств.РасходыСвязанныеСОплатойТруда;
			}
			else if(Ссылка == ВыплатыНеСвязанныеСОплатойТруда)
			{
				return ВидыРасходовЦелевыхСредств.ВыплатыНеСвязанныеСОплатойТруда;
			}
			else if(Ссылка == ОказаниеСоциальнойИБлаготворительнойПомощи)
			{
				return ВидыРасходовЦелевыхСредств.ОказаниеСоциальнойИБлаготворительнойПомощи;
			}
			else if(Ссылка == ПроведениеКонференцийСеминаров)
			{
				return ВидыРасходовЦелевыхСредств.ПроведениеКонференцийСеминаров;
			}
			else if(Ссылка == ПроведениеИныхЦелевыхМероприятий)
			{
				return ВидыРасходовЦелевыхСредств.ПроведениеИныхЦелевыхМероприятий;
			}
			else if(Ссылка == РасходыНаСлужебныеКомандировкиИДеловыеПоездки)
			{
				return ВидыРасходовЦелевыхСредств.РасходыНаСлужебныеКомандировкиИДеловыеПоездки;
			}
			else if(Ссылка == СодержаниеПомещенийЗданийАвтотранспортаИИногоИмущества)
			{
				return ВидыРасходовЦелевыхСредств.СодержаниеПомещенийЗданийАвтотранспортаИИногоИмущества;
			}
			else if(Ссылка == РемонтОсновныхСредствИИногоИмущества)
			{
				return ВидыРасходовЦелевыхСредств.РемонтОсновныхСредствИИногоИмущества;
			}
			else if(Ссылка == ПрочиеРасходыНаСодержаниеАппаратаУправления)
			{
				return ВидыРасходовЦелевыхСредств.ПрочиеРасходыНаСодержаниеАппаратаУправления;
			}
			else if(Ссылка == ПриобретениеОсновныхСредствИнвентаряИИногоИмущества)
			{
				return ВидыРасходовЦелевыхСредств.ПриобретениеОсновныхСредствИнвентаряИИногоИмущества;
			}
			else if(Ссылка == РасходыСвязанныеСПредпринимательскойДеятельностью)
			{
				return ВидыРасходовЦелевыхСредств.РасходыСвязанныеСПредпринимательскойДеятельностью;
			}
			else if(Ссылка == ПрочиеРасходы)
			{
				return ВидыРасходовЦелевыхСредств.ПрочиеРасходы;
			}
			return ВидыРасходовЦелевыхСредств.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыРасходовЦелевыхСредств Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыРасходовЦелевыхСредств Значение)
		{
			switch (Значение)
			{
				case ВидыРасходовЦелевыхСредств.РасходыСвязанныеСОплатойТруда: return РасходыСвязанныеСОплатойТруда;
				case ВидыРасходовЦелевыхСредств.ВыплатыНеСвязанныеСОплатойТруда: return ВыплатыНеСвязанныеСОплатойТруда;
				case ВидыРасходовЦелевыхСредств.ОказаниеСоциальнойИБлаготворительнойПомощи: return ОказаниеСоциальнойИБлаготворительнойПомощи;
				case ВидыРасходовЦелевыхСредств.ПроведениеКонференцийСеминаров: return ПроведениеКонференцийСеминаров;
				case ВидыРасходовЦелевыхСредств.ПроведениеИныхЦелевыхМероприятий: return ПроведениеИныхЦелевыхМероприятий;
				case ВидыРасходовЦелевыхСредств.РасходыНаСлужебныеКомандировкиИДеловыеПоездки: return РасходыНаСлужебныеКомандировкиИДеловыеПоездки;
				case ВидыРасходовЦелевыхСредств.СодержаниеПомещенийЗданийАвтотранспортаИИногоИмущества: return СодержаниеПомещенийЗданийАвтотранспортаИИногоИмущества;
				case ВидыРасходовЦелевыхСредств.РемонтОсновныхСредствИИногоИмущества: return РемонтОсновныхСредствИИногоИмущества;
				case ВидыРасходовЦелевыхСредств.ПрочиеРасходыНаСодержаниеАппаратаУправления: return ПрочиеРасходыНаСодержаниеАппаратаУправления;
				case ВидыРасходовЦелевыхСредств.ПриобретениеОсновныхСредствИнвентаряИИногоИмущества: return ПриобретениеОсновныхСредствИнвентаряИИногоИмущества;
				case ВидыРасходовЦелевыхСредств.РасходыСвязанныеСПредпринимательскойДеятельностью: return РасходыСвязанныеСПредпринимательскойДеятельностью;
				case ВидыРасходовЦелевыхСредств.ПрочиеРасходы: return ПрочиеРасходы;
			}
			return Guid.Empty;
		}
	}
}