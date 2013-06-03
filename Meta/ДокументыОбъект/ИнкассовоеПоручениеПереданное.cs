﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Общ)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ИнкассовоеПоручениеПереданное:ДокументОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public DateTime Дата {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public DateTime ПрефиксНомера {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*11*/ Номер {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public bool Проведен {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public object ДокументОснование {get;set;}//Документ основание
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Общ) Банковский счет организации
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public V82.СправочникиСсылка.БанковскиеСчета СчетОрганизации {get;set;}//Счет организации
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.Контрагенты Контрагент {get;set;}//Плательщик
		///<summary>
		///(Общ) Банковский счет контрагента
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public V82.СправочникиСсылка.БанковскиеСчета СчетКонтрагента {get;set;}//Счет контрагента
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента {get;set;}//Договор контрагента
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public decimal/*(15.2)*/ СуммаДокумента {get;set;}//Сумма документа
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public V82.СправочникиСсылка.Валюты ВалютаДокумента {get;set;}//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств ВидОперации {get;set;}//Вид операции
		///<summary>
		///(Общ) электронно, почтой, телеграфом
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public string/*(15)*/ ВидПлатежа {get;set;}//Вид платежа
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public decimal/*(1)*/ ОчередностьПлатежа {get;set;}//Очередность платежа
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public string/*(0)*/ НазначениеПлатежа {get;set;}//Назначение платежа
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public bool ОтраженоВОперУчете {get;set;}//Отражено в опер. учете
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(22)]
		public string/*(0)*/ ТекстПлательщика {get;set;}//Текст плательщика
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public string/*(0)*/ ТекстПолучателя {get;set;}//Текст получателя
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(24)]
		public string/*(12)*/ ИННПлательщика {get;set;}//ИНН плательщика
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(25)]
		public string/*(9)*/ КПППлательщика {get;set;}//КПП плательщика
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(26)]
		public string/*(12)*/ ИННПолучателя {get;set;}//ИНН получателя
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(27)]
		public string/*(9)*/ КПППолучателя {get;set;}//КПП получателя
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(28)]
		public bool Оплачено {get;set;}
		///<summary>
		///(Упр)
		///</summary>
		[DataMember]
		[ProtoMember(29)]
		public DateTime ДатаОплаты {get;set;}//Дата оплаты
		///<summary>
		///(общ)
		///</summary>
		[DataMember]
		[ProtoMember(30)]
		public bool ЧастичнаяОплата {get;set;}//По документу происходит оплата частями
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(31)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(32)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(33)]
		public object СчетУчетаРасчетовСКонтрагентом {get;set;}//Счет учета расчетов с контрагентом
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(34)]
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(35)]
		public V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get;set;}//Статья движения денежных средств
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(36)]
		public object СубконтоКт1 {get;set;}//Субконто Кт1
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(37)]
		public object СубконтоКт2 {get;set;}//Субконто Кт1
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(38)]
		public object СубконтоКт3 {get;set;}//Субконто Кт1
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(39)]
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		[DataMember]
		[ProtoMember(40)]
		public string/*(200)*/ Содержание_УСН {get;set;}//Содержание УСН
		[DataMember]
		[ProtoMember(41)]
		public decimal/*(15.2)*/ Графа4_УСН {get;set;}//Графа4 УСН
		[DataMember]
		[ProtoMember(42)]
		public decimal/*(15.2)*/ Графа5_УСН {get;set;}//Графа5 УСН
		[DataMember]
		[ProtoMember(43)]
		public decimal/*(15.2)*/ Графа6_УСН {get;set;}//Графа5
		[DataMember]
		[ProtoMember(44)]
		public decimal/*(15.2)*/ Графа7_УСН {get;set;}//Графа5
		[DataMember]
		[ProtoMember(45)]
		public bool ДоходыЕНВД_УСН {get;set;}//ДоходыЕНВД
		[DataMember]
		[ProtoMember(46)]
		public bool РасходыЕНВД_УСН {get;set;}//Расходы ЕНВД УСН
		[DataMember]
		[ProtoMember(47)]
		public decimal/*(15.2)*/ НДС_УСН {get;set;}//НДС УСН
		[DataMember]
		[ProtoMember(48)]
		public bool РучнаяНастройка_УСН {get;set;}//Ручная настройка УСН
		[DataMember]
		[ProtoMember(49)]
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(50)]
		public object СчетУчетаРасчетовСКонтрагентомНУ {get;set;}//Счет учета расчетов с контрагентом НУ
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(51)]
		public object СубконтоНУКт1 {get;set;}//Субконто НУ Кт1
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(52)]
		public object СубконтоНУКт2 {get;set;}//Субконто НУ Кт2
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(53)]
		public object СубконтоНУКт3 {get;set;}//Субконто НУ Кт3
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для Документов.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Document408(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld8317RRef
						,_Fld8318RRef
						,_Fld8319RRef
						,_Fld8320RRef
						,_Fld8321RRef
						,_Fld8322
						,_Fld8323RRef
						,_Fld8324RRef
						,_Fld8325
						,_Fld8326
						,_Fld8327
						,_Fld8328
						,_Fld8329
						,_Fld8330
						,_Fld8331
						,_Fld8332
						,_Fld8333
						,_Fld8334
						,_Fld8335
						,_Fld8336
						,_Fld8337
						,_Fld8338
						,_Fld8339RRef
						,_Fld8340RRef
						,_Fld8341
						,_Fld8342RRef
						,_Fld8343RRef
						,_Fld8344RRef
						,_Fld8345RRef
						,_Fld8346
						,_Fld8347
						,_Fld8348
						,_Fld8349
						,_Fld8350
						,_Fld8351
						,_Fld8352
						,_Fld8353
						,_Fld8354
						,_Fld8355
						,_Fld8356RRef
						,_Fld8357RRef
						,_Fld8358RRef
						,_Fld8359RRef
						,_Fld8360RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@Организация
						,@СчетОрганизации
						,@Контрагент
						,@СчетКонтрагента
						,@ДоговорКонтрагента
						,@СуммаДокумента
						,@ВалютаДокумента
						,@ВидОперации
						,@ВидПлатежа
						,@ОчередностьПлатежа
						,@НазначениеПлатежа
						,@ОтраженоВОперУчете
						,@ТекстПлательщика
						,@ТекстПолучателя
						,@ИННПлательщика
						,@КПППлательщика
						,@ИННПолучателя
						,@КПППолучателя
						,@Оплачено
						,@ДатаОплаты
						,@ЧастичнаяОплата
						,@Комментарий
						,@Ответственный
						,@СчетУчетаРасчетовСКонтрагентом
						,@ОтражатьВБухгалтерскомУчете
						,@СтатьяДвиженияДенежныхСредств
						,@СубконтоКт1
						,@СубконтоКт2
						,@СубконтоКт3
						,@ОтражатьВНалоговомУчете
						,@Содержание_УСН
						,@Графа4_УСН
						,@Графа5_УСН
						,@Графа6_УСН
						,@Графа7_УСН
						,@ДоходыЕНВД_УСН
						,@РасходыЕНВД_УСН
						,@НДС_УСН
						,@РучнаяНастройка_УСН
						,@Подразделение
						,@СчетУчетаРасчетовСКонтрагентомНУ
						,@СубконтоНУКт1
						,@СубконтоНУКт2
						,@СубконтоНУКт3)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document408
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld8317RRef	= @Организация
						,_Fld8318RRef	= @СчетОрганизации
						,_Fld8319RRef	= @Контрагент
						,_Fld8320RRef	= @СчетКонтрагента
						,_Fld8321RRef	= @ДоговорКонтрагента
						,_Fld8322	= @СуммаДокумента
						,_Fld8323RRef	= @ВалютаДокумента
						,_Fld8324RRef	= @ВидОперации
						,_Fld8325	= @ВидПлатежа
						,_Fld8326	= @ОчередностьПлатежа
						,_Fld8327	= @НазначениеПлатежа
						,_Fld8328	= @ОтраженоВОперУчете
						,_Fld8329	= @ТекстПлательщика
						,_Fld8330	= @ТекстПолучателя
						,_Fld8331	= @ИННПлательщика
						,_Fld8332	= @КПППлательщика
						,_Fld8333	= @ИННПолучателя
						,_Fld8334	= @КПППолучателя
						,_Fld8335	= @Оплачено
						,_Fld8336	= @ДатаОплаты
						,_Fld8337	= @ЧастичнаяОплата
						,_Fld8338	= @Комментарий
						,_Fld8339RRef	= @Ответственный
						,_Fld8340RRef	= @СчетУчетаРасчетовСКонтрагентом
						,_Fld8341	= @ОтражатьВБухгалтерскомУчете
						,_Fld8342RRef	= @СтатьяДвиженияДенежныхСредств
						,_Fld8343RRef	= @СубконтоКт1
						,_Fld8344RRef	= @СубконтоКт2
						,_Fld8345RRef	= @СубконтоКт3
						,_Fld8346	= @ОтражатьВНалоговомУчете
						,_Fld8347	= @Содержание_УСН
						,_Fld8348	= @Графа4_УСН
						,_Fld8349	= @Графа5_УСН
						,_Fld8350	= @Графа6_УСН
						,_Fld8351	= @Графа7_УСН
						,_Fld8352	= @ДоходыЕНВД_УСН
						,_Fld8353	= @РасходыЕНВД_УСН
						,_Fld8354	= @НДС_УСН
						,_Fld8355	= @РучнаяНастройка_УСН
						,_Fld8356RRef	= @Подразделение
						,_Fld8357RRef	= @СчетУчетаРасчетовСКонтрагентомНУ
						,_Fld8358RRef	= @СубконтоНУКт1
						,_Fld8359RRef	= @СубконтоНУКт2
						,_Fld8360RRef	= @СубконтоНУКт3
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("СуммаДокумента", СуммаДокумента);
					Команда.Parameters.AddWithValue("ВидОперации", ВидОперации.Ключ());
					Команда.Parameters.AddWithValue("ВидПлатежа", ВидПлатежа);
					Команда.Parameters.AddWithValue("ОчередностьПлатежа", ОчередностьПлатежа);
					Команда.Parameters.AddWithValue("НазначениеПлатежа", НазначениеПлатежа);
					Команда.Parameters.AddWithValue("ОтраженоВОперУчете", ОтраженоВОперУчете);
					Команда.Parameters.AddWithValue("ТекстПлательщика", ТекстПлательщика);
					Команда.Parameters.AddWithValue("ТекстПолучателя", ТекстПолучателя);
					Команда.Parameters.AddWithValue("ИННПлательщика", ИННПлательщика);
					Команда.Parameters.AddWithValue("КПППлательщика", КПППлательщика);
					Команда.Parameters.AddWithValue("ИННПолучателя", ИННПолучателя);
					Команда.Parameters.AddWithValue("КПППолучателя", КПППолучателя);
					Команда.Parameters.AddWithValue("Оплачено", Оплачено);
					Команда.Parameters.AddWithValue("ДатаОплаты", ДатаОплаты);
					Команда.Parameters.AddWithValue("ЧастичнаяОплата", ЧастичнаяОплата);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("СчетУчетаРасчетовСКонтрагентом", Guid.Empty);
					Команда.Parameters.AddWithValue("ОтражатьВБухгалтерскомУчете", ОтражатьВБухгалтерскомУчете);
					Команда.Parameters.AddWithValue("СубконтоКт1", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоКт2", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоКт3", Guid.Empty);
					Команда.Parameters.AddWithValue("ОтражатьВНалоговомУчете", ОтражатьВНалоговомУчете);
					Команда.Parameters.AddWithValue("Содержание_УСН", Содержание_УСН);
					Команда.Parameters.AddWithValue("Графа4_УСН", Графа4_УСН);
					Команда.Parameters.AddWithValue("Графа5_УСН", Графа5_УСН);
					Команда.Parameters.AddWithValue("Графа6_УСН", Графа6_УСН);
					Команда.Parameters.AddWithValue("Графа7_УСН", Графа7_УСН);
					Команда.Parameters.AddWithValue("ДоходыЕНВД_УСН", ДоходыЕНВД_УСН);
					Команда.Parameters.AddWithValue("РасходыЕНВД_УСН", РасходыЕНВД_УСН);
					Команда.Parameters.AddWithValue("НДС_УСН", НДС_УСН);
					Команда.Parameters.AddWithValue("РучнаяНастройка_УСН", РучнаяНастройка_УСН);
					Команда.Parameters.AddWithValue("СчетУчетаРасчетовСКонтрагентомНУ", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоНУКт1", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоНУКт2", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоНУКт3", Guid.Empty);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Document408
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}