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
	public partial class ПлатежноеТребованиеВыставленное:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("b78d689b-aefc-4ec0-aeba-096a4ffea8a0");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191743.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public object ДокументОснование {get;set;}//Документ основание
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Общ) Банковский счет организации
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетОрганизации {get;set;}//Счет организации
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент {get;set;}
		///<summary>
		///(Общ) Банковский счет контрагента
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетКонтрагента {get;set;}//Счет контрагента
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента {get;set;}//Сумма документа
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаОтсылкиДокументов {get;set;}//Дата отсылки документов
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств ВидОперации {get;set;}//Вид операции
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента {get;set;}//Договор контрагента
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента {get;set;}//Валюта документа
		///<summary>
		///(Общ) электронно, почтой, телеграфом
		///</summary>
		public string/*(15)*/ ВидПлатежа {get;set;}//Вид платежа
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(1)*/ ОчередностьПлатежа {get;set;}//Очередность платежа
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтраженоВОперУчете {get;set;}//Отражено в опер. учете
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ТекстПлательщика {get;set;}//Текст плательщика
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ТекстПолучателя {get;set;}//Текст получателя
		///<summary>
		///(Регл)
		///</summary>
		public string/*(12)*/ ИННПлательщика {get;set;}//ИНН плательщика
		///<summary>
		///(Регл)
		///</summary>
		public string/*(9)*/ КПППлательщика {get;set;}//КПП плательщика
		///<summary>
		///(Регл)
		///</summary>
		public string/*(12)*/ ИННПолучателя {get;set;}//ИНН получателя
		///<summary>
		///(Регл)
		///</summary>
		public string/*(9)*/ КПППолучателя {get;set;}//КПП получателя
		///<summary>
		///(Упр)
		///</summary>
		public decimal/*(3)*/ СрокДляАкцепта {get;set;}//Срок для акцепта получателем (дней)
		///<summary>
		///(Упр)
		///</summary>
		public V82.Перечисления/*Ссылка*/.УсловияОплатыРасчетныхДокументов УсловиеОплаты {get;set;}//Условие оплаты
		///<summary>
		///(Упр)
		///</summary>
		public string/*(0)*/ ОснованиеДляБезакцептногоСписания {get;set;}//Основание для безакцептного списания
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом {get;set;}//Счет учета расчетов с контрагентом
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКт1 {get;set;}//Субконто Кт1
		///<summary>
		///(Упр)
		///</summary>
		public DateTime ДатаОплаты {get;set;}//Дата оплаты
		///<summary>
		///(общ)
		///</summary>
		public bool ЧастичнаяОплата {get;set;}//По документу происходит оплата частями
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКт2 {get;set;}//Субконто Кт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКт3 {get;set;}//Субконто Кт1
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get;set;}//Статья движения денежных средств
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool Оплачено {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ НазначениеПлатежа {get;set;}//Назначение платежа
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
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		public string/*(200)*/ Содержание_УСН {get;set;}//Содержание УСН
		public decimal/*(15.2)*/ Графа4_УСН {get;set;}//Графа4 УСН
		public decimal/*(15.2)*/ Графа5_УСН {get;set;}//Графа5 УСН
		public decimal/*(15.2)*/ Графа6_УСН {get;set;}//Графа5
		public decimal/*(15.2)*/ Графа7_УСН {get;set;}//Графа5
		public bool ДоходыЕНВД_УСН {get;set;}//ДоходыЕНВД
		public bool РасходыЕНВД_УСН {get;set;}//Расходы ЕНВД УСН
		public decimal/*(15.2)*/ НДС_УСН {get;set;}//НДС УСН
		public bool РучнаяНастройка_УСН {get;set;}//Ручная настройка УСН
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		public decimal/*(1)*/ ВидАкцепта {get;set;}//Вид акцепта
		
		public ПлатежноеТребованиеВыставленное()
		{
		}
		
		public ПлатежноеТребованиеВыставленное(byte[] УникальныйИдентификатор)
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
					,_Fld13224_TYPE [ДокументОснование_Тип],_Fld13224_RRRef [ДокументОснование],_Fld13224_RTRef [ДокументОснование_Вид]
					,_Fld13225RRef [Организация]
					,_Fld13226RRef [СчетОрганизации]
					,_Fld13227RRef [Контрагент]
					,_Fld13228RRef [СчетКонтрагента]
					,_Fld13229 [СуммаДокумента]
					,_Fld13230 [ДатаОтсылкиДокументов]
					,_Fld13231RRef [ВидОперации]
					,_Fld13232RRef [ДоговорКонтрагента]
					,_Fld13233RRef [ВалютаДокумента]
					,_Fld13234 [ВидПлатежа]
					,_Fld13235 [ОчередностьПлатежа]
					,_Fld13236 [ОтраженоВОперУчете]
					,_Fld13237 [ТекстПлательщика]
					,_Fld13238 [ТекстПолучателя]
					,_Fld13239 [ИННПлательщика]
					,_Fld13240 [КПППлательщика]
					,_Fld13241 [ИННПолучателя]
					,_Fld13242 [КПППолучателя]
					,_Fld13243 [СрокДляАкцепта]
					,_Fld13244RRef [УсловиеОплаты]
					,_Fld13245 [ОснованиеДляБезакцептногоСписания]
					,_Fld13246RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld13247RRef [СубконтоКт1]
					,_Fld13248 [ДатаОплаты]
					,_Fld13249 [ЧастичнаяОплата]
					,_Fld13250RRef [СубконтоКт2]
					,_Fld13251RRef [СубконтоКт3]
					,_Fld13252RRef [СтатьяДвиженияДенежныхСредств]
					,_Fld13253 [ОтражатьВБухгалтерскомУчете]
					,_Fld13254 [Оплачено]
					,_Fld13255 [НазначениеПлатежа]
					,_Fld13256RRef [Ответственный]
					,_Fld13257 [Комментарий]
					,_Fld13258 [ОтражатьВНалоговомУчете]
					,_Fld13259 [Содержание_УСН]
					,_Fld13260 [Графа4_УСН]
					,_Fld13261 [Графа5_УСН]
					,_Fld13262 [Графа6_УСН]
					,_Fld13263 [Графа7_УСН]
					,_Fld13264 [ДоходыЕНВД_УСН]
					,_Fld13265 [РасходыЕНВД_УСН]
					,_Fld13266 [НДС_УСН]
					,_Fld13267 [РучнаяНастройка_УСН]
					,_Fld13268RRef [Подразделение]
					,_Fld13269 [ВидАкцепта]
					From _Document516(NOLOCK)
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
							СуммаДокумента = Читалка.GetDecimal(11);
							ДатаОтсылкиДокументов = Читалка.GetDateTime(12);
							ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							ВидПлатежа = Читалка.GetString(16);
							ОчередностьПлатежа = Читалка.GetDecimal(17);
							ОтраженоВОперУчете = ((byte[])Читалка.GetValue(18))[0]==1;
							ТекстПлательщика = Читалка.GetString(19);
							ТекстПолучателя = Читалка.GetString(20);
							ИННПлательщика = Читалка.GetString(21);
							КПППлательщика = Читалка.GetString(22);
							ИННПолучателя = Читалка.GetString(23);
							КПППолучателя = Читалка.GetString(24);
							СрокДляАкцепта = Читалка.GetDecimal(25);
							УсловиеОплаты = V82.Перечисления/*Ссылка*/.УсловияОплатыРасчетныхДокументов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
							ОснованиеДляБезакцептногоСписания = Читалка.GetString(27);
							ДатаОплаты = Читалка.GetDateTime(30);
							ЧастичнаяОплата = ((byte[])Читалка.GetValue(31))[0]==1;
							ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(35))[0]==1;
							Оплачено = ((byte[])Читалка.GetValue(36))[0]==1;
							НазначениеПлатежа = Читалка.GetString(37);
							Комментарий = Читалка.GetString(39);
							ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(40))[0]==1;
							Содержание_УСН = Читалка.GetString(41);
							Графа4_УСН = Читалка.GetDecimal(42);
							Графа5_УСН = Читалка.GetDecimal(43);
							Графа6_УСН = Читалка.GetDecimal(44);
							Графа7_УСН = Читалка.GetDecimal(45);
							ДоходыЕНВД_УСН = ((byte[])Читалка.GetValue(46))[0]==1;
							РасходыЕНВД_УСН = ((byte[])Читалка.GetValue(47))[0]==1;
							НДС_УСН = Читалка.GetDecimal(48);
							РучнаяНастройка_УСН = ((byte[])Читалка.GetValue(49))[0]==1;
							ВидАкцепта = Читалка.GetDecimal(51);
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
		
		public V82.ДокументыОбъект.ПлатежноеТребованиеВыставленное  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.ПлатежноеТребованиеВыставленное();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.ДокументОснование = ДокументОснование;
			Объект.Организация = Организация;
			Объект.СчетОрганизации = СчетОрганизации;
			Объект.Контрагент = Контрагент;
			Объект.СчетКонтрагента = СчетКонтрагента;
			Объект.СуммаДокумента = СуммаДокумента;
			Объект.ДатаОтсылкиДокументов = ДатаОтсылкиДокументов;
			Объект.ВидОперации = ВидОперации;
			Объект.ДоговорКонтрагента = ДоговорКонтрагента;
			Объект.ВалютаДокумента = ВалютаДокумента;
			Объект.ВидПлатежа = ВидПлатежа;
			Объект.ОчередностьПлатежа = ОчередностьПлатежа;
			Объект.ОтраженоВОперУчете = ОтраженоВОперУчете;
			Объект.ТекстПлательщика = ТекстПлательщика;
			Объект.ТекстПолучателя = ТекстПолучателя;
			Объект.ИННПлательщика = ИННПлательщика;
			Объект.КПППлательщика = КПППлательщика;
			Объект.ИННПолучателя = ИННПолучателя;
			Объект.КПППолучателя = КПППолучателя;
			Объект.СрокДляАкцепта = СрокДляАкцепта;
			Объект.УсловиеОплаты = УсловиеОплаты;
			Объект.ОснованиеДляБезакцептногоСписания = ОснованиеДляБезакцептногоСписания;
			Объект.СчетУчетаРасчетовСКонтрагентом = СчетУчетаРасчетовСКонтрагентом;
			Объект.СубконтоКт1 = СубконтоКт1;
			Объект.ДатаОплаты = ДатаОплаты;
			Объект.ЧастичнаяОплата = ЧастичнаяОплата;
			Объект.СубконтоКт2 = СубконтоКт2;
			Объект.СубконтоКт3 = СубконтоКт3;
			Объект.СтатьяДвиженияДенежныхСредств = СтатьяДвиженияДенежныхСредств;
			Объект.ОтражатьВБухгалтерскомУчете = ОтражатьВБухгалтерскомУчете;
			Объект.Оплачено = Оплачено;
			Объект.НазначениеПлатежа = НазначениеПлатежа;
			Объект.Ответственный = Ответственный;
			Объект.Комментарий = Комментарий;
			Объект.ОтражатьВНалоговомУчете = ОтражатьВНалоговомУчете;
			Объект.Содержание_УСН = Содержание_УСН;
			Объект.Графа4_УСН = Графа4_УСН;
			Объект.Графа5_УСН = Графа5_УСН;
			Объект.Графа6_УСН = Графа6_УСН;
			Объект.Графа7_УСН = Графа7_УСН;
			Объект.ДоходыЕНВД_УСН = ДоходыЕНВД_УСН;
			Объект.РасходыЕНВД_УСН = РасходыЕНВД_УСН;
			Объект.НДС_УСН = НДС_УСН;
			Объект.РучнаяНастройка_УСН = РучнаяНастройка_УСН;
			Объект.Подразделение = Подразделение;
			Объект.ВидАкцепта = ВидАкцепта;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.ПлатежноеТребованиеВыставленное ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.ПлатежноеТребованиеВыставленное)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.ПлатежноеТребованиеВыставленное(УникальныйИдентификатор);
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