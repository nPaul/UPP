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
	[ProtoContract]
	[DataContract]
	public partial class ВыдачаДенежныхДокументов:ДокументОбъект
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
		public V82.СправочникиСсылка.Валюты ВалютаДокумента {get;set;}//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public V82.Перечисления/*Ссылка*/.ВидыОперацийВыдачаДенежныхДокументов ВидОперации {get;set;}//Вид операции
		///<summary>
		///(Общ) 
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента {get;set;}//Договор контрагента
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ) 
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public object Контрагент {get;set;}
		///<summary>
		///(Общ) 
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public decimal/*(10)*/ КратностьВзаиморасчетов {get;set;}//Кратность взаиморасчетов
		///<summary>
		///(Общ) 
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public decimal/*(10.4)*/ КурсВзаиморасчетов {get;set;}//Курс взаиморасчетов
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Общ) 
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public decimal/*(15.2)*/ СуммаДокумента {get;set;}//Сумма документа
		///<summary>
		///(Регл) 
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public object СчетУчетаРасчетовСКонтрагентом {get;set;}//Счет учета расчетов с контрагентом
		[DataMember]
		[ProtoMember(20)]
		public bool РучнаяКорректировка {get;set;}//Ручная корректировка
		[DataMember]
		[ProtoMember(21)]
		public object СубконтоДт1 {get;set;}//Субконто Дт1
		[DataMember]
		[ProtoMember(22)]
		public object СубконтоДт2 {get;set;}//Субконто Дт2
		[DataMember]
		[ProtoMember(23)]
		public object СубконтоДт3 {get;set;}//Субконто Дт3
		[DataMember]
		[ProtoMember(24)]
		public object СчетУчетаДенежныхДокументов {get;set;}//Счет учета денежных документов
		[DataMember]
		[ProtoMember(25)]
		public string/*(0)*/ Выдано {get;set;}
		[DataMember]
		[ProtoMember(26)]
		public V82.СправочникиСсылка.ПрочиеДоходыИРасходы СтатьяДоходовИРасходов {get;set;}//Статья доходов и расходов
		[DataMember]
		[ProtoMember(27)]
		public object СчетУчетаДоходов {get;set;}//Счет учета доходов
		[DataMember]
		[ProtoMember(28)]
		public object СчетУчетаРасходов {get;set;}//Счет учета расходов
		[DataMember]
		[ProtoMember(29)]
		public object СчетУчетаДоходовНУ {get;set;}//Счет учета доходов (НУ)
		[DataMember]
		[ProtoMember(30)]
		public object СчетУчетаРасходовНУ {get;set;}//Счет учета расходов (НУ)
		[DataMember]
		[ProtoMember(31)]
		public string/*(200)*/ Содержание_УСН {get;set;}//Содержание УСН
		[DataMember]
		[ProtoMember(32)]
		public decimal/*(15.2)*/ Графа4_УСН {get;set;}//Графа4 УСН
		[DataMember]
		[ProtoMember(33)]
		public decimal/*(15.2)*/ Графа5_УСН {get;set;}//Графа5 УСН
		[DataMember]
		[ProtoMember(34)]
		public decimal/*(15.2)*/ Графа6_УСН {get;set;}//Графа5
		[DataMember]
		[ProtoMember(35)]
		public decimal/*(15.2)*/ Графа7_УСН {get;set;}//Графа5
		[DataMember]
		[ProtoMember(36)]
		public bool ДоходыЕНВД_УСН {get;set;}//ДоходыЕНВД
		[DataMember]
		[ProtoMember(37)]
		public bool РасходыЕНВД_УСН {get;set;}//Расходы ЕНВД УСН
		[DataMember]
		[ProtoMember(38)]
		public decimal/*(15.2)*/ НДС_УСН {get;set;}//НДС УСН
		[DataMember]
		[ProtoMember(39)]
		public bool РучнаяНастройка_УСН {get;set;}//Ручная настройка УСН
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
						Insert Into _Document347(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld6593RRef
						,_Fld6594RRef
						,_Fld6595RRef
						,_Fld6596
						,_Fld6598
						,_Fld6599
						,_Fld6600RRef
						,_Fld6601RRef
						,_Fld6602
						,_Fld6603RRef
						,_Fld6604
						,_Fld6605RRef
						,_Fld6606RRef
						,_Fld6607RRef
						,_Fld6608RRef
						,_Fld6609
						,_Fld6610RRef
						,_Fld6611RRef
						,_Fld6612RRef
						,_Fld6613RRef
						,_Fld6614RRef
						,_Fld6615
						,_Fld6616
						,_Fld6617
						,_Fld6618
						,_Fld6619
						,_Fld6620
						,_Fld6621
						,_Fld6622
						,_Fld6623)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@ВалютаДокумента
						,@ВидОперации
						,@ДоговорКонтрагента
						,@Комментарий
						,@КратностьВзаиморасчетов
						,@КурсВзаиморасчетов
						,@Организация
						,@Ответственный
						,@СуммаДокумента
						,@СчетУчетаРасчетовСКонтрагентом
						,@РучнаяКорректировка
						,@СубконтоДт1
						,@СубконтоДт2
						,@СубконтоДт3
						,@СчетУчетаДенежныхДокументов
						,@Выдано
						,@СтатьяДоходовИРасходов
						,@СчетУчетаДоходов
						,@СчетУчетаРасходов
						,@СчетУчетаДоходовНУ
						,@СчетУчетаРасходовНУ
						,@Содержание_УСН
						,@Графа4_УСН
						,@Графа5_УСН
						,@Графа6_УСН
						,@Графа7_УСН
						,@ДоходыЕНВД_УСН
						,@РасходыЕНВД_УСН
						,@НДС_УСН
						,@РучнаяНастройка_УСН)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document347
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld6593RRef	= @ВалютаДокумента
						,_Fld6594RRef	= @ВидОперации
						,_Fld6595RRef	= @ДоговорКонтрагента
						,_Fld6596	= @Комментарий
						,_Fld6598	= @КратностьВзаиморасчетов
						,_Fld6599	= @КурсВзаиморасчетов
						,_Fld6600RRef	= @Организация
						,_Fld6601RRef	= @Ответственный
						,_Fld6602	= @СуммаДокумента
						,_Fld6603RRef	= @СчетУчетаРасчетовСКонтрагентом
						,_Fld6604	= @РучнаяКорректировка
						,_Fld6605RRef	= @СубконтоДт1
						,_Fld6606RRef	= @СубконтоДт2
						,_Fld6607RRef	= @СубконтоДт3
						,_Fld6608RRef	= @СчетУчетаДенежныхДокументов
						,_Fld6609	= @Выдано
						,_Fld6610RRef	= @СтатьяДоходовИРасходов
						,_Fld6611RRef	= @СчетУчетаДоходов
						,_Fld6612RRef	= @СчетУчетаРасходов
						,_Fld6613RRef	= @СчетУчетаДоходовНУ
						,_Fld6614RRef	= @СчетУчетаРасходовНУ
						,_Fld6615	= @Содержание_УСН
						,_Fld6616	= @Графа4_УСН
						,_Fld6617	= @Графа5_УСН
						,_Fld6618	= @Графа6_УСН
						,_Fld6619	= @Графа7_УСН
						,_Fld6620	= @ДоходыЕНВД_УСН
						,_Fld6621	= @РасходыЕНВД_УСН
						,_Fld6622	= @НДС_УСН
						,_Fld6623	= @РучнаяНастройка_УСН
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("ВидОперации", ВидОперации.Ключ());
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("КратностьВзаиморасчетов", КратностьВзаиморасчетов);
					Команда.Parameters.AddWithValue("КурсВзаиморасчетов", КурсВзаиморасчетов);
					Команда.Parameters.AddWithValue("СуммаДокумента", СуммаДокумента);
					Команда.Parameters.AddWithValue("СчетУчетаРасчетовСКонтрагентом", Guid.Empty);
					Команда.Parameters.AddWithValue("РучнаяКорректировка", РучнаяКорректировка);
					Команда.Parameters.AddWithValue("СубконтоДт1", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоДт2", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоДт3", Guid.Empty);
					Команда.Parameters.AddWithValue("СчетУчетаДенежныхДокументов", Guid.Empty);
					Команда.Parameters.AddWithValue("Выдано", Выдано);
					Команда.Parameters.AddWithValue("СчетУчетаДоходов", Guid.Empty);
					Команда.Parameters.AddWithValue("СчетУчетаРасходов", Guid.Empty);
					Команда.Parameters.AddWithValue("СчетУчетаДоходовНУ", Guid.Empty);
					Команда.Parameters.AddWithValue("СчетУчетаРасходовНУ", Guid.Empty);
					Команда.Parameters.AddWithValue("Содержание_УСН", Содержание_УСН);
					Команда.Parameters.AddWithValue("Графа4_УСН", Графа4_УСН);
					Команда.Parameters.AddWithValue("Графа5_УСН", Графа5_УСН);
					Команда.Parameters.AddWithValue("Графа6_УСН", Графа6_УСН);
					Команда.Parameters.AddWithValue("Графа7_УСН", Графа7_УСН);
					Команда.Parameters.AddWithValue("ДоходыЕНВД_УСН", ДоходыЕНВД_УСН);
					Команда.Parameters.AddWithValue("РасходыЕНВД_УСН", РасходыЕНВД_УСН);
					Команда.Parameters.AddWithValue("НДС_УСН", НДС_УСН);
					Команда.Parameters.AddWithValue("РучнаяНастройка_УСН", РучнаяНастройка_УСН);
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
					Команда.CommandText = @"Delete _Document347
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}