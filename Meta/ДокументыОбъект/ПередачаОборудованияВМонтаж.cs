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
	public partial class ПередачаОборудованияВМонтаж:ДокументОбъект
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
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public V82.СправочникиСсылка.ОбъектыСтроительства ОбъектСтроительства {get;set;}//Объект строительства
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатрат {get;set;}//Статья затрат
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.Склады Склад {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public bool ОтражатьВУправленческомУчете {get;set;}//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public object СчетУчетаБУОбъектаСтроительства {get;set;}//Счет учета БУ объекта строительства
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Обш)
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public object СчетУчетаНУОбъектаСтроительства {get;set;}//Счет учета НУ объекта строительства
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
						Insert Into _Document486(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld12189RRef
						,_Fld12190RRef
						,_Fld12191RRef
						,_Fld12192RRef
						,_Fld12193
						,_Fld12194
						,_Fld12195
						,_Fld12196RRef
						,_Fld12197RRef
						,_Fld12198
						,_Fld12199RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@Организация
						,@ОбъектСтроительства
						,@СтатьяЗатрат
						,@Склад
						,@ОтражатьВНалоговомУчете
						,@ОтражатьВУправленческомУчете
						,@ОтражатьВБухгалтерскомУчете
						,@СчетУчетаБУОбъектаСтроительства
						,@Ответственный
						,@Комментарий
						,@СчетУчетаНУОбъектаСтроительства)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document486
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld12189RRef	= @Организация
						,_Fld12190RRef	= @ОбъектСтроительства
						,_Fld12191RRef	= @СтатьяЗатрат
						,_Fld12192RRef	= @Склад
						,_Fld12193	= @ОтражатьВНалоговомУчете
						,_Fld12194	= @ОтражатьВУправленческомУчете
						,_Fld12195	= @ОтражатьВБухгалтерскомУчете
						,_Fld12196RRef	= @СчетУчетаБУОбъектаСтроительства
						,_Fld12197RRef	= @Ответственный
						,_Fld12198	= @Комментарий
						,_Fld12199RRef	= @СчетУчетаНУОбъектаСтроительства
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("ОтражатьВНалоговомУчете", ОтражатьВНалоговомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВУправленческомУчете", ОтражатьВУправленческомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВБухгалтерскомУчете", ОтражатьВБухгалтерскомУчете);
					Команда.Parameters.AddWithValue("СчетУчетаБУОбъектаСтроительства", Guid.Empty);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("СчетУчетаНУОбъектаСтроительства", Guid.Empty);
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
					Команда.CommandText = @"Delete _Document486
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}