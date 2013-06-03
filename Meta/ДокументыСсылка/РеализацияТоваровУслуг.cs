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
	public partial class РеализацияТоваровУслуг:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("6709bdcb-b7c6-4f18-823d-d1b66c0ffbd0");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191855.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета БанковскийСчетОрганизации {get;set;}//Банковский счет организации
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента {get;set;}//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент {get;set;}
		///<summary>
		///(Упр)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыПередачиТоваров ВидПередачи {get;set;}//Вид передачи
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Грузоотправитель {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Грузополучатель {get;set;}
		public V82.СправочникиСсылка.ИнформационныеКарты ДисконтнаяКарта {get;set;}//Дисконтная карта
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента {get;set;}//Договор контрагента
		public string/*(0)*/ АдресДоставки {get;set;}//Адрес доставки
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента {get;set;}//Сумма документа
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10)*/ КратностьВзаиморасчетов {get;set;}//Кратность взаиморасчетов
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10.4)*/ КурсВзаиморасчетов {get;set;}//Курс взаиморасчетов
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете {get;set;}//Отражать в управленческом учете
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		public object Проект {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public object Сделка {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Склады Склад {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public bool СуммаВключаетНДС {get;set;}//Сумма включает НДС
		public V82.Перечисления/*Ссылка*/.ВидыОперацийРеализацияТоваров ВидОперации {get;set;}//Вид операции
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаДоходовПоТареБУ {get;set;}//Счет учета доходов по таре (БУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаДоходовПоТареНУ {get;set;}//Счет учета доходов по таре (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасходовПоТареБУ {get;set;}//Счет учета расходов по таре (БУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасходовПоТареНУ {get;set;}//Счет учета расходов по таре (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовПоАвансам {get;set;}//Счет учета расчетов по авансам
		public V82.СправочникиСсылка.ПрочиеДоходыИРасходы СтатьяПрочихДоходовРасходовПоТаре {get;set;}//Статья прочих доходов расходов по таре
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовПоТаре {get;set;}//Счет учета расчетов по таре
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом {get;set;}//Счет учета расчетов с контрагентом
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен {get;set;}//Тип цен
		///<summary>
		///(Общ)
		///</summary>
		public bool УчитыватьНДС {get;set;}//Учитывать НДС
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ФизическиеЛица ОтпускРазрешил {get;set;}//Отпуск товара разрешил
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ФизическиеЛица ОтпускПроизвел {get;set;}//Отпуск товара произвел
		///<summary>
		///(Общ)
		///</summary>
		public string/*(15)*/ ДоверенностьНомер {get;set;}//Номер доверенности
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДоверенностьДата {get;set;}//Дата доверенности
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ДоверенностьВыдана {get;set;}//Организация выдавшая доверенность
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ДоверенностьЧерезКого {get;set;}//Сотрудник организации на которого выдана доверенность
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтключитьКонтрольВзаиморасчетов {get;set;}//Отключить контроль взаиморасчетов
		public V82.СправочникиСсылка.УсловияПродаж УсловиеПродаж {get;set;}//Условие продаж
		public string/*(0)*/ ДополнениеКАдресуДоставки {get;set;}//Дополнение к адресу доставки
		public V82.СправочникиСсылка.ФизическиеЛица ГлавныйБухгалтер {get;set;}//Главный бухгалтер
		public string/*(50)*/ ЗаГлавногоБухгалтераПоПриказу {get;set;}//За главного бухгалтера по приказу
		public string/*(50)*/ ЗаРуководителяПоПриказу {get;set;}//За руководителя по приказу
		
		public РеализацияТоваровУслуг()
		{
		}
		
		public РеализацияТоваровУслуг(byte[] УникальныйИдентификатор)
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
					,_Fld15776RRef [Организация]
					,_Fld15777RRef [БанковскийСчетОрганизации]
					,_Fld15778RRef [ВалютаДокумента]
					,_Fld15779RRef [Контрагент]
					,_Fld15780RRef [ВидПередачи]
					,_Fld15781RRef [Грузоотправитель]
					,_Fld15782RRef [Грузополучатель]
					,_Fld15783RRef [ДисконтнаяКарта]
					,_Fld15784RRef [ДоговорКонтрагента]
					,_Fld15785 [АдресДоставки]
					,_Fld15786 [СуммаДокумента]
					,_Fld15787 [КратностьВзаиморасчетов]
					,_Fld15788 [КурсВзаиморасчетов]
					,_Fld15789 [Комментарий]
					,_Fld15790RRef [Ответственный]
					,_Fld15791 [ОтражатьВБухгалтерскомУчете]
					,_Fld15792 [ОтражатьВНалоговомУчете]
					,_Fld15793 [ОтражатьВУправленческомУчете]
					,_Fld15794RRef [Подразделение]
					,_Fld15795_TYPE [Проект_Тип],_Fld15795_RRRef [Проект],_Fld15795_RTRef [Проект_Вид]
					,_Fld15796_TYPE [Сделка_Тип],_Fld15796_RRRef [Сделка],_Fld15796_RTRef [Сделка_Вид]
					,_Fld15797RRef [Склад]
					,_Fld15798 [СуммаВключаетНДС]
					,_Fld15799RRef [ВидОперации]
					,_Fld15800RRef [СчетУчетаДоходовПоТареБУ]
					,_Fld15801RRef [СчетУчетаДоходовПоТареНУ]
					,_Fld15802RRef [СчетУчетаРасходовПоТареБУ]
					,_Fld15803RRef [СчетУчетаРасходовПоТареНУ]
					,_Fld15804RRef [СчетУчетаРасчетовПоАвансам]
					,_Fld15805RRef [СтатьяПрочихДоходовРасходовПоТаре]
					,_Fld15806RRef [СчетУчетаРасчетовПоТаре]
					,_Fld15807RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld15808RRef [ТипЦен]
					,_Fld15809 [УчитыватьНДС]
					,_Fld15810RRef [ОтпускРазрешил]
					,_Fld15811RRef [ОтпускПроизвел]
					,_Fld15812 [ДоверенностьНомер]
					,_Fld15813 [ДоверенностьДата]
					,_Fld15814 [ДоверенностьВыдана]
					,_Fld15815 [ДоверенностьЧерезКого]
					,_Fld15816 [ОтключитьКонтрольВзаиморасчетов]
					,_Fld15817RRef [УсловиеПродаж]
					,_Fld15818 [ДополнениеКАдресуДоставки]
					,_Fld15819RRef [ГлавныйБухгалтер]
					,_Fld15820 [ЗаГлавногоБухгалтераПоПриказу]
					,_Fld15821 [ЗаРуководителяПоПриказу]
					From _Document563(NOLOCK)
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
							ВидПередачи = V82.Перечисления/*Ссылка*/.ВидыПередачиТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							АдресДоставки = Читалка.GetString(13);
							СуммаДокумента = Читалка.GetDecimal(14);
							КратностьВзаиморасчетов = Читалка.GetDecimal(15);
							КурсВзаиморасчетов = Читалка.GetDecimal(16);
							Комментарий = Читалка.GetString(17);
							ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(19))[0]==1;
							ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(20))[0]==1;
							ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(21))[0]==1;
							СуммаВключаетНДС = ((byte[])Читалка.GetValue(30))[0]==1;
							ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийРеализацияТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(31));
							УчитыватьНДС = ((byte[])Читалка.GetValue(41))[0]==1;
							ДоверенностьНомер = Читалка.GetString(44);
							ДоверенностьДата = Читалка.GetDateTime(45);
							ДоверенностьВыдана = Читалка.GetString(46);
							ДоверенностьЧерезКого = Читалка.GetString(47);
							ОтключитьКонтрольВзаиморасчетов = ((byte[])Читалка.GetValue(48))[0]==1;
							ДополнениеКАдресуДоставки = Читалка.GetString(50);
							ЗаГлавногоБухгалтераПоПриказу = Читалка.GetString(52);
							ЗаРуководителяПоПриказу = Читалка.GetString(53);
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
		
		public V82.ДокументыОбъект.РеализацияТоваровУслуг  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.РеализацияТоваровУслуг();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.Организация = Организация;
			Объект.БанковскийСчетОрганизации = БанковскийСчетОрганизации;
			Объект.ВалютаДокумента = ВалютаДокумента;
			Объект.Контрагент = Контрагент;
			Объект.ВидПередачи = ВидПередачи;
			Объект.Грузоотправитель = Грузоотправитель;
			Объект.Грузополучатель = Грузополучатель;
			Объект.ДисконтнаяКарта = ДисконтнаяКарта;
			Объект.ДоговорКонтрагента = ДоговорКонтрагента;
			Объект.АдресДоставки = АдресДоставки;
			Объект.СуммаДокумента = СуммаДокумента;
			Объект.КратностьВзаиморасчетов = КратностьВзаиморасчетов;
			Объект.КурсВзаиморасчетов = КурсВзаиморасчетов;
			Объект.Комментарий = Комментарий;
			Объект.Ответственный = Ответственный;
			Объект.ОтражатьВБухгалтерскомУчете = ОтражатьВБухгалтерскомУчете;
			Объект.ОтражатьВНалоговомУчете = ОтражатьВНалоговомУчете;
			Объект.ОтражатьВУправленческомУчете = ОтражатьВУправленческомУчете;
			Объект.Подразделение = Подразделение;
			Объект.Проект = Проект;
			Объект.Сделка = Сделка;
			Объект.Склад = Склад;
			Объект.СуммаВключаетНДС = СуммаВключаетНДС;
			Объект.ВидОперации = ВидОперации;
			Объект.СчетУчетаДоходовПоТареБУ = СчетУчетаДоходовПоТареБУ;
			Объект.СчетУчетаДоходовПоТареНУ = СчетУчетаДоходовПоТареНУ;
			Объект.СчетУчетаРасходовПоТареБУ = СчетУчетаРасходовПоТареБУ;
			Объект.СчетУчетаРасходовПоТареНУ = СчетУчетаРасходовПоТареНУ;
			Объект.СчетУчетаРасчетовПоАвансам = СчетУчетаРасчетовПоАвансам;
			Объект.СтатьяПрочихДоходовРасходовПоТаре = СтатьяПрочихДоходовРасходовПоТаре;
			Объект.СчетУчетаРасчетовПоТаре = СчетУчетаРасчетовПоТаре;
			Объект.СчетУчетаРасчетовСКонтрагентом = СчетУчетаРасчетовСКонтрагентом;
			Объект.ТипЦен = ТипЦен;
			Объект.УчитыватьНДС = УчитыватьНДС;
			Объект.ОтпускРазрешил = ОтпускРазрешил;
			Объект.ОтпускПроизвел = ОтпускПроизвел;
			Объект.ДоверенностьНомер = ДоверенностьНомер;
			Объект.ДоверенностьДата = ДоверенностьДата;
			Объект.ДоверенностьВыдана = ДоверенностьВыдана;
			Объект.ДоверенностьЧерезКого = ДоверенностьЧерезКого;
			Объект.ОтключитьКонтрольВзаиморасчетов = ОтключитьКонтрольВзаиморасчетов;
			Объект.УсловиеПродаж = УсловиеПродаж;
			Объект.ДополнениеКАдресуДоставки = ДополнениеКАдресуДоставки;
			Объект.ГлавныйБухгалтер = ГлавныйБухгалтер;
			Объект.ЗаГлавногоБухгалтераПоПриказу = ЗаГлавногоБухгалтераПоПриказу;
			Объект.ЗаРуководителяПоПриказу = ЗаРуководителяПоПриказу;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.РеализацияТоваровУслуг ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.РеализацияТоваровУслуг)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.РеализацияТоваровУслуг(УникальныйИдентификатор);
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