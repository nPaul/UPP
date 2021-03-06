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
	public partial class РегламентныеОперацииНалоговогоУчетаПоУСН:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("6e96dba5-c1f4-4d4d-8525-22711b568550");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012012.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		///(Общ)
		///</summary>
		public bool РаспределениеРасходовПоВидамДеятельности {get;set;}//Распределение расходов по видам деятельности
		public DateTime ПериодРегистрации {get;set;}//Период регистрации
		public bool ПризнаниеРасходовНаПриобретениеОСУСН {get;set;}//Признание расходов на приобретение ОС
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public bool ПризнаниеРасходовНаПриобретениеНМАУСН {get;set;}//Признание расходов на приобретение НМА (УСН)
		///<summary>
		///(Общ)
		///</summary>
		public bool СписаниеДопРасходовУСН {get;set;}//Списание доп. расходов (УСН)
		
		public РегламентныеОперацииНалоговогоУчетаПоУСН()
		{
		}
		
		public РегламентныеОперацииНалоговогоУчетаПоУСН(byte[] УникальныйИдентификатор)
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
					,_Fld11291RRef [Организация]
					,_Fld11292 [РаспределениеРасходовПоВидамДеятельности]
					,_Fld11293 [ПериодРегистрации]
					,_Fld11294 [ПризнаниеРасходовНаПриобретениеОСУСН]
					,_Fld11295RRef [Ответственный]
					,_Fld11296 [Комментарий]
					,_Fld11297 [ПризнаниеРасходовНаПриобретениеНМАУСН]
					,_Fld22025 [СписаниеДопРасходовУСН]
					From _Document443(NOLOCK)
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
							РаспределениеРасходовПоВидамДеятельности = ((byte[])Читалка.GetValue(5))[0]==1;
							ПериодРегистрации = Читалка.GetDateTime(6);
							ПризнаниеРасходовНаПриобретениеОСУСН = ((byte[])Читалка.GetValue(7))[0]==1;
							Комментарий = Читалка.GetString(9);
							ПризнаниеРасходовНаПриобретениеНМАУСН = ((byte[])Читалка.GetValue(10))[0]==1;
							СписаниеДопРасходовУСН = ((byte[])Читалка.GetValue(11))[0]==1;
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
		
		public V82.ДокументыОбъект.РегламентныеОперацииНалоговогоУчетаПоУСН  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.РегламентныеОперацииНалоговогоУчетаПоУСН();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.Организация = Организация;
			Объект.РаспределениеРасходовПоВидамДеятельности = РаспределениеРасходовПоВидамДеятельности;
			Объект.ПериодРегистрации = ПериодРегистрации;
			Объект.ПризнаниеРасходовНаПриобретениеОСУСН = ПризнаниеРасходовНаПриобретениеОСУСН;
			Объект.Ответственный = Ответственный;
			Объект.Комментарий = Комментарий;
			Объект.ПризнаниеРасходовНаПриобретениеНМАУСН = ПризнаниеРасходовНаПриобретениеНМАУСН;
			Объект.СписаниеДопРасходовУСН = СписаниеДопРасходовУСН;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.РегламентныеОперацииНалоговогоУчетаПоУСН ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.РегламентныеОперацииНалоговогоУчетаПоУСН)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.РегламентныеОперацииНалоговогоУчетаПоУСН(УникальныйИдентификатор);
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