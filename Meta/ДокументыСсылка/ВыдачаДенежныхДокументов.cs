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
	[ProtoContract]
	[DataContract]
	public partial class ВыдачаДенежныхДокументов:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("1dc044b0-b2f0-4d99-8918-6c6718ec5fbf");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191621.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента {get;set;}//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийВыдачаДенежныхДокументов ВидОперации {get;set;}//Вид операции
		///<summary>
		///(Общ) 
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента {get;set;}//Договор контрагента
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ) 
		///</summary>
		public object Контрагент {get;set;}
		///<summary>
		///(Общ) 
		///</summary>
		public decimal/*(10)*/ КратностьВзаиморасчетов {get;set;}//Кратность взаиморасчетов
		///<summary>
		///(Общ) 
		///</summary>
		public decimal/*(10.4)*/ КурсВзаиморасчетов {get;set;}//Курс взаиморасчетов
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Общ) 
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента {get;set;}//Сумма документа
		///<summary>
		///(Регл) 
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом {get;set;}//Счет учета расчетов с контрагентом
		public bool РучнаяКорректировка {get;set;}//Ручная корректировка
		public object СубконтоДт1 {get;set;}//Субконто Дт1
		public object СубконтоДт2 {get;set;}//Субконто Дт2
		public object СубконтоДт3 {get;set;}//Субконто Дт3
		public object СчетУчетаДенежныхДокументов {get;set;}//Счет учета денежных документов
		public string/*(0)*/ Выдано {get;set;}
		public V82.СправочникиСсылка.ПрочиеДоходыИРасходы СтатьяДоходовИРасходов {get;set;}//Статья доходов и расходов
		public object СчетУчетаДоходов {get;set;}//Счет учета доходов
		public object СчетУчетаРасходов {get;set;}//Счет учета расходов
		public object СчетУчетаДоходовНУ {get;set;}//Счет учета доходов (НУ)
		public object СчетУчетаРасходовНУ {get;set;}//Счет учета расходов (НУ)
		public string/*(200)*/ Содержание_УСН {get;set;}//Содержание УСН
		public decimal/*(15.2)*/ Графа4_УСН {get;set;}//Графа4 УСН
		public decimal/*(15.2)*/ Графа5_УСН {get;set;}//Графа5 УСН
		public decimal/*(15.2)*/ Графа6_УСН {get;set;}//Графа5
		public decimal/*(15.2)*/ Графа7_УСН {get;set;}//Графа5
		public bool ДоходыЕНВД_УСН {get;set;}//ДоходыЕНВД
		public bool РасходыЕНВД_УСН {get;set;}//Расходы ЕНВД УСН
		public decimal/*(15.2)*/ НДС_УСН {get;set;}//НДС УСН
		public bool РучнаяНастройка_УСН {get;set;}//Ручная настройка УСН
		
		public ВыдачаДенежныхДокументов()
		{
		}
		
		public ВыдачаДенежныхДокументов(byte[] УникальныйИдентификатор)
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
					,_Fld6593RRef [ВалютаДокумента]
					,_Fld6594RRef [ВидОперации]
					,_Fld6595RRef [ДоговорКонтрагента]
					,_Fld6596 [Комментарий]
					,_Fld6597_TYPE [Контрагент_Тип],_Fld6597_RRRef [Контрагент],_Fld6597_RTRef [Контрагент_Вид]
					,_Fld6598 [КратностьВзаиморасчетов]
					,_Fld6599 [КурсВзаиморасчетов]
					,_Fld6600RRef [Организация]
					,_Fld6601RRef [Ответственный]
					,_Fld6602 [СуммаДокумента]
					,_Fld6603RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld6604 [РучнаяКорректировка]
					,_Fld6605RRef [СубконтоДт1]
					,_Fld6606RRef [СубконтоДт2]
					,_Fld6607RRef [СубконтоДт3]
					,_Fld6608RRef [СчетУчетаДенежныхДокументов]
					,_Fld6609 [Выдано]
					,_Fld6610RRef [СтатьяДоходовИРасходов]
					,_Fld6611RRef [СчетУчетаДоходов]
					,_Fld6612RRef [СчетУчетаРасходов]
					,_Fld6613RRef [СчетУчетаДоходовНУ]
					,_Fld6614RRef [СчетУчетаРасходовНУ]
					,_Fld6615 [Содержание_УСН]
					,_Fld6616 [Графа4_УСН]
					,_Fld6617 [Графа5_УСН]
					,_Fld6618 [Графа6_УСН]
					,_Fld6619 [Графа7_УСН]
					,_Fld6620 [ДоходыЕНВД_УСН]
					,_Fld6621 [РасходыЕНВД_УСН]
					,_Fld6622 [НДС_УСН]
					,_Fld6623 [РучнаяНастройка_УСН]
					From _Document347(NOLOCK)
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
							ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийВыдачаДенежныхДокументов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Комментарий = Читалка.GetString(7);
							КратностьВзаиморасчетов = Читалка.GetDecimal(11);
							КурсВзаиморасчетов = Читалка.GetDecimal(12);
							СуммаДокумента = Читалка.GetDecimal(15);
							РучнаяКорректировка = ((byte[])Читалка.GetValue(17))[0]==1;
							Выдано = Читалка.GetString(22);
							Содержание_УСН = Читалка.GetString(28);
							Графа4_УСН = Читалка.GetDecimal(29);
							Графа5_УСН = Читалка.GetDecimal(30);
							Графа6_УСН = Читалка.GetDecimal(31);
							Графа7_УСН = Читалка.GetDecimal(32);
							ДоходыЕНВД_УСН = ((byte[])Читалка.GetValue(33))[0]==1;
							РасходыЕНВД_УСН = ((byte[])Читалка.GetValue(34))[0]==1;
							НДС_УСН = Читалка.GetDecimal(35);
							РучнаяНастройка_УСН = ((byte[])Читалка.GetValue(36))[0]==1;
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
		
		public V82.ДокументыОбъект.ВыдачаДенежныхДокументов  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.ВыдачаДенежныхДокументов();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.ВалютаДокумента = ВалютаДокумента;
			Объект.ВидОперации = ВидОперации;
			Объект.ДоговорКонтрагента = ДоговорКонтрагента;
			Объект.Комментарий = Комментарий;
			Объект.Контрагент = Контрагент;
			Объект.КратностьВзаиморасчетов = КратностьВзаиморасчетов;
			Объект.КурсВзаиморасчетов = КурсВзаиморасчетов;
			Объект.Организация = Организация;
			Объект.Ответственный = Ответственный;
			Объект.СуммаДокумента = СуммаДокумента;
			Объект.СчетУчетаРасчетовСКонтрагентом = СчетУчетаРасчетовСКонтрагентом;
			Объект.РучнаяКорректировка = РучнаяКорректировка;
			Объект.СубконтоДт1 = СубконтоДт1;
			Объект.СубконтоДт2 = СубконтоДт2;
			Объект.СубконтоДт3 = СубконтоДт3;
			Объект.СчетУчетаДенежныхДокументов = СчетУчетаДенежныхДокументов;
			Объект.Выдано = Выдано;
			Объект.СтатьяДоходовИРасходов = СтатьяДоходовИРасходов;
			Объект.СчетУчетаДоходов = СчетУчетаДоходов;
			Объект.СчетУчетаРасходов = СчетУчетаРасходов;
			Объект.СчетУчетаДоходовНУ = СчетУчетаДоходовНУ;
			Объект.СчетУчетаРасходовНУ = СчетУчетаРасходовНУ;
			Объект.Содержание_УСН = Содержание_УСН;
			Объект.Графа4_УСН = Графа4_УСН;
			Объект.Графа5_УСН = Графа5_УСН;
			Объект.Графа6_УСН = Графа6_УСН;
			Объект.Графа7_УСН = Графа7_УСН;
			Объект.ДоходыЕНВД_УСН = ДоходыЕНВД_УСН;
			Объект.РасходыЕНВД_УСН = РасходыЕНВД_УСН;
			Объект.НДС_УСН = НДС_УСН;
			Объект.РучнаяНастройка_УСН = РучнаяНастройка_УСН;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.ВыдачаДенежныхДокументов ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.ВыдачаДенежныхДокументов)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.ВыдачаДенежныхДокументов(УникальныйИдентификатор);
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