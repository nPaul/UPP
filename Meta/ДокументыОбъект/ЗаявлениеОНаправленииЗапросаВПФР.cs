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
	public partial class ЗаявлениеОНаправленииЗапросаВПФР:ДокументОбъект
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
		[DataMember]
		[ProtoMember(9)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		[DataMember]
		[ProtoMember(10)]
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник {get;set;}
		[DataMember]
		[ProtoMember(11)]
		public V82.СправочникиСсылка.ФизическиеЛица ФизЛицо {get;set;}//Физическое лицо
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.Работодатели Страхователь {get;set;}
		[DataMember]
		[ProtoMember(13)]
		public V82.Перечисления/*Ссылка*/.ВидыПособийСоциальногоСтрахования ВидПособия {get;set;}//Вид пособия
		[DataMember]
		[ProtoMember(14)]
		public DateTime ПериодРаботыС {get;set;}//Период работы С
		[DataMember]
		[ProtoMember(15)]
		public DateTime ПериодРаботыПо {get;set;}//Период работы по
		[DataMember]
		[ProtoMember(16)]
		public bool СтраховательПрекратилДеятельность {get;set;}//Страхователь прекратил деятельность
		[DataMember]
		[ProtoMember(17)]
		public string/*(0)*/ ИныеПричиныОтсутствияСправки {get;set;}//Иные причины отсутствия справки
		[DataMember]
		[ProtoMember(18)]
		public string/*(14)*/ СтраховойНомерПФР {get;set;}//Страховой номер ПФР
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public DateTime ДатаРождения {get;set;}//Дата рождения
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public string/*(40)*/ Фамилия {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public string/*(40)*/ Имя {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(22)]
		public string/*(40)*/ Отчество {get;set;}
		[DataMember]
		[ProtoMember(23)]
		public string/*(240)*/ Адрес {get;set;}
		[DataMember]
		[ProtoMember(24)]
		public string/*(240)*/ Телефон {get;set;}
		[DataMember]
		[ProtoMember(25)]
		public V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность ВидДокумента {get;set;}//Вид документа
		[DataMember]
		[ProtoMember(26)]
		public string/*(14)*/ СерияДокумента {get;set;}//Серия документа
		[DataMember]
		[ProtoMember(27)]
		public string/*(14)*/ НомерДокумента {get;set;}//Номер документа
		[DataMember]
		[ProtoMember(28)]
		public DateTime ДатаВыдачиДокумента {get;set;}//Дата выдачи документа
		[DataMember]
		[ProtoMember(29)]
		public string/*(0)*/ КемВыданДокумент {get;set;}//Кем выдан документ
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(30)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(31)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
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
						Insert Into _Document386(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld7744RRef
						,_Fld7745RRef
						,_Fld7746RRef
						,_Fld7747RRef
						,_Fld7748RRef
						,_Fld7749
						,_Fld7750
						,_Fld7751
						,_Fld7752
						,_Fld7753
						,_Fld7754
						,_Fld7755
						,_Fld7756
						,_Fld7757
						,_Fld7758
						,_Fld7759
						,_Fld7760RRef
						,_Fld7761
						,_Fld7762
						,_Fld7763
						,_Fld7764
						,_Fld7765
						,_Fld7766RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@Организация
						,@Сотрудник
						,@ФизЛицо
						,@Страхователь
						,@ВидПособия
						,@ПериодРаботыС
						,@ПериодРаботыПо
						,@СтраховательПрекратилДеятельность
						,@ИныеПричиныОтсутствияСправки
						,@СтраховойНомерПФР
						,@ДатаРождения
						,@Фамилия
						,@Имя
						,@Отчество
						,@Адрес
						,@Телефон
						,@ВидДокумента
						,@СерияДокумента
						,@НомерДокумента
						,@ДатаВыдачиДокумента
						,@КемВыданДокумент
						,@Комментарий
						,@Ответственный)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document386
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld7744RRef	= @Организация
						,_Fld7745RRef	= @Сотрудник
						,_Fld7746RRef	= @ФизЛицо
						,_Fld7747RRef	= @Страхователь
						,_Fld7748RRef	= @ВидПособия
						,_Fld7749	= @ПериодРаботыС
						,_Fld7750	= @ПериодРаботыПо
						,_Fld7751	= @СтраховательПрекратилДеятельность
						,_Fld7752	= @ИныеПричиныОтсутствияСправки
						,_Fld7753	= @СтраховойНомерПФР
						,_Fld7754	= @ДатаРождения
						,_Fld7755	= @Фамилия
						,_Fld7756	= @Имя
						,_Fld7757	= @Отчество
						,_Fld7758	= @Адрес
						,_Fld7759	= @Телефон
						,_Fld7760RRef	= @ВидДокумента
						,_Fld7761	= @СерияДокумента
						,_Fld7762	= @НомерДокумента
						,_Fld7763	= @ДатаВыдачиДокумента
						,_Fld7764	= @КемВыданДокумент
						,_Fld7765	= @Комментарий
						,_Fld7766RRef	= @Ответственный
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("ВидПособия", ВидПособия.Ключ());
					Команда.Parameters.AddWithValue("ПериодРаботыС", ПериодРаботыС);
					Команда.Parameters.AddWithValue("ПериодРаботыПо", ПериодРаботыПо);
					Команда.Parameters.AddWithValue("СтраховательПрекратилДеятельность", СтраховательПрекратилДеятельность);
					Команда.Parameters.AddWithValue("ИныеПричиныОтсутствияСправки", ИныеПричиныОтсутствияСправки);
					Команда.Parameters.AddWithValue("СтраховойНомерПФР", СтраховойНомерПФР);
					Команда.Parameters.AddWithValue("ДатаРождения", ДатаРождения);
					Команда.Parameters.AddWithValue("Фамилия", Фамилия);
					Команда.Parameters.AddWithValue("Имя", Имя);
					Команда.Parameters.AddWithValue("Отчество", Отчество);
					Команда.Parameters.AddWithValue("Адрес", Адрес);
					Команда.Parameters.AddWithValue("Телефон", Телефон);
					Команда.Parameters.AddWithValue("СерияДокумента", СерияДокумента);
					Команда.Parameters.AddWithValue("НомерДокумента", НомерДокумента);
					Команда.Parameters.AddWithValue("ДатаВыдачиДокумента", ДатаВыдачиДокумента);
					Команда.Parameters.AddWithValue("КемВыданДокумент", КемВыданДокумент);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
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
					Команда.CommandText = @"Delete _Document386
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}