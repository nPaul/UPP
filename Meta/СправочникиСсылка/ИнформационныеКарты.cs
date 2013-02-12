﻿
using System;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	///<summary>
	///(Упр) Магнитные и штриховые карты.
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ИнформационныеКарты:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("d48a9040-ce93-4dd7-86c6-e0e6b848fea5");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221190834.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(3)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(4)]
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public bool ЭтоГруппа {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public Guid Родитель {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*50*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public string/*(100)*/ КодКарты {get;set;}//Код карты
		[DataMember]
		[ProtoMember(10)]
		public object ВладелецКарты {get;set;}//Владелец карты
		[DataMember]
		[ProtoMember(11)]
		public V82.Перечисления/*Ссылка*/.ВидыИнформационныхКарт ВидКарты {get;set;}//Вид карты
		[DataMember]
		[ProtoMember(12)]
		public V82.Перечисления/*Ссылка*/.ТипыИнформационныхКарт ТипКарты {get;set;}//Тип карты
		[DataMember]
		[ProtoMember(13)]
		public object ТипШтрихКода {get;set;}//Тип штрих кода
		[DataMember]
		[ProtoMember(14)]
		public V82.СправочникиСсылка.ВидыДисконтныхКарт ВидДисконтнойКарты {get;set;}//Вид дисконтной карты

		public V82.СправочникиОбъект.ИнформационныеКарты  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ИнформационныеКарты();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.ЭтоГруппа = ЭтоГруппа;
			Объект.Родитель = Родитель;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.КодКарты = КодКарты;
			Объект.ВладелецКарты = ВладелецКарты;
			Объект.ВидКарты = ВидКарты;
			Объект.ТипКарты = ТипКарты;
			Объект.ТипШтрихКода = ТипШтрихКода;
			Объект.ВидДисконтнойКарты = ВидДисконтнойКарты;
			return Объект;
		}

		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}

		public string СериализацияJson()
		{
			return this.ToJson();
		}

		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}