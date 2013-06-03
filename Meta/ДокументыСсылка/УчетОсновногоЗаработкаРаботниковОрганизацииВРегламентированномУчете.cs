﻿
using System;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Регл)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class УчетОсновногоЗаработкаРаботниковОрганизацииВРегламентированномУчете:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("6fb2dba6-4541-4005-b7fd-eee84e63fce1");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191722.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public DateTime Дата {get;set;}
		public DateTime ПрефиксНомера {get;set;}
		public string/*11*/ Номер {get;set;}
		public bool Проведен {get;set;}
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		public object ОтражаемыйДокумент {get;set;}//Отражаемый документ
		public string/*(100)*/ КраткийСоставДокумента {get;set;}//Краткий состав документа
		
		public УчетОсновногоЗаработкаРаботниковОрганизацииВРегламентированномУчете()
		{
		}
		
		public УчетОсновногоЗаработкаРаботниковОрганизацииВРегламентированномУчете(byte[] УникальныйИдентификатор)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Number [Номер]
					,_Fld18864RRef [Организация]
					,_Fld18865 [Комментарий]
					,_Fld18866RRef [Ответственный]
					,_Fld18867_TYPE [ОтражаемыйДокумент_Тип],_Fld18867_RRRef [ОтражаемыйДокумент],_Fld18867_RTRef [ОтражаемыйДокумент_Вид]
					,_Fld18868 [КраткийСоставДокумента]
					From _Document636(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Номер = Читалка.GetString(3);
							Комментарий = Читалка.GetString(5);
							КраткийСоставДокумента = Читалка.GetString(10);
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.ДокументыОбъект.УчетОсновногоЗаработкаРаботниковОрганизацииВРегламентированномУчете  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.УчетОсновногоЗаработкаРаботниковОрганизацииВРегламентированномУчете();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.Организация = Организация;
			Объект.Комментарий = Комментарий;
			Объект.Ответственный = Ответственный;
			Объект.ОтражаемыйДокумент = ОтражаемыйДокумент;
			Объект.КраткийСоставДокумента = КраткийСоставДокумента;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.УчетОсновногоЗаработкаРаботниковОрганизацииВРегламентированномУчете ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.УчетОсновногоЗаработкаРаботниковОрганизацииВРегламентированномУчете)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.УчетОсновногоЗаработкаРаботниковОрганизацииВРегламентированномУчете(УникальныйИдентификатор);
			Кэш.Add(УИ, Ссылка);
			return Ссылка;
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