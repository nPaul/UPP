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
	///(Общ)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class СписаниеТоваров:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("f6211454-6d37-4b0b-947a-efbd220180b7");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191027.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public V82.Перечисления/*Ссылка*/.ВидыОперацийСписаниеТоваров ВидОперации {get;set;}//Вид операции
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Склады Склад {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете {get;set;}//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента {get;set;}//Сумма документа
		///<summary>
		///(Общ) Основание (статья) списания
		///</summary>
		public string/*(0)*/ Основание {get;set;}
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.ДокументыСсылка.ИнвентаризацияТоваровНаСкладе ИнвентаризацияТоваровНаСкладе {get;set;}//Инвентаризация товаров на складе
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///Необходимые действия по включению или исключению НДС в тоимости товаров при перемещении
		///</summary>
		public V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров НДСвСтоимостиТоваров {get;set;}//НДС в стоимости товаров
		
		public СписаниеТоваров()
		{
		}
		
		public СписаниеТоваров(byte[] УникальныйИдентификатор)
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
					,_Fld17417RRef [ВидОперации]
					,_Fld17418RRef [Организация]
					,_Fld17419RRef [Подразделение]
					,_Fld17420RRef [Склад]
					,_Fld17421 [ОтражатьВУправленческомУчете]
					,_Fld17422 [ОтражатьВБухгалтерскомУчете]
					,_Fld17423 [ОтражатьВНалоговомУчете]
					,_Fld17424 [СуммаДокумента]
					,_Fld17425 [Основание]
					,_Fld17426 [Комментарий]
					,_Fld17427RRef [ИнвентаризацияТоваровНаСкладе]
					,_Fld17428RRef [Ответственный]
					,_Fld17429RRef [НДСвСтоимостиТоваров]
					From _Document597(NOLOCK)
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
							ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийСписаниеТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(8))[0]==1;
							ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(9))[0]==1;
							ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(10))[0]==1;
							СуммаДокумента = Читалка.GetDecimal(11);
							Основание = Читалка.GetString(12);
							Комментарий = Читалка.GetString(13);
							ИнвентаризацияТоваровНаСкладе = new V82.ДокументыСсылка.ИнвентаризацияТоваровНаСкладе((byte[])Читалка.GetValue(14));
							НДСвСтоимостиТоваров = V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
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
		
		public V82.ДокументыОбъект.СписаниеТоваров  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.СписаниеТоваров();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.ВидОперации = ВидОперации;
			Объект.Организация = Организация;
			Объект.Подразделение = Подразделение;
			Объект.Склад = Склад;
			Объект.ОтражатьВУправленческомУчете = ОтражатьВУправленческомУчете;
			Объект.ОтражатьВБухгалтерскомУчете = ОтражатьВБухгалтерскомУчете;
			Объект.ОтражатьВНалоговомУчете = ОтражатьВНалоговомУчете;
			Объект.СуммаДокумента = СуммаДокумента;
			Объект.Основание = Основание;
			Объект.Комментарий = Комментарий;
			Объект.ИнвентаризацияТоваровНаСкладе = ИнвентаризацияТоваровНаСкладе;
			Объект.Ответственный = Ответственный;
			Объект.НДСвСтоимостиТоваров = НДСвСтоимостиТоваров;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.СписаниеТоваров ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.СписаниеТоваров)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.СписаниеТоваров(УникальныйИдентификатор);
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