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
	public partial class СписаниеДепонентовВДоходыОрганизаций:ДокументОбъект
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
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public object СчетДоходовБУ {get;set;}//Счет учета доходов в БУ
		[DataMember]
		[ProtoMember(13)]
		public object Субконто1 {get;set;}//Субконто номер 1
		[DataMember]
		[ProtoMember(14)]
		public object Субконто2 {get;set;}//Субконто номер 2
		[DataMember]
		[ProtoMember(15)]
		public object Субконто3 {get;set;}//Субконто номер 3
		[DataMember]
		[ProtoMember(16)]
		public decimal/*(15.2)*/ СуммаДокумента {get;set;}//Сумма документа
		[DataMember]
		[ProtoMember(17)]
		public object СчетДоходовНУ {get;set;}//Счет учета доходов в НУ
		[DataMember]
		[ProtoMember(18)]
		public object СубконтоНУ1 {get;set;}//Субконто нал. учета номер 1
		[DataMember]
		[ProtoMember(19)]
		public object СубконтоНУ2 {get;set;}//Субконто нал. учета номер 2
		[DataMember]
		[ProtoMember(20)]
		public object СубконтоНУ3 {get;set;}//Субконто нал. учета номер 3
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		[DataMember]
		[ProtoMember(22)]
		public string/*(100)*/ КраткийСоставДокумента {get;set;}//Краткий состав документа
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
						Insert Into _Document589(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld17229RRef
						,_Fld17230RRef
						,_Fld17231
						,_Fld17232RRef
						,_Fld17233RRef
						,_Fld17234RRef
						,_Fld17235RRef
						,_Fld17236
						,_Fld17237RRef
						,_Fld17238RRef
						,_Fld17239RRef
						,_Fld17240RRef
						,_Fld17241
						,_Fld17242)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@Организация
						,@Ответственный
						,@Комментарий
						,@СчетДоходовБУ
						,@Субконто1
						,@Субконто2
						,@Субконто3
						,@СуммаДокумента
						,@СчетДоходовНУ
						,@СубконтоНУ1
						,@СубконтоНУ2
						,@СубконтоНУ3
						,@ОтражатьВНалоговомУчете
						,@КраткийСоставДокумента)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document589
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld17229RRef	= @Организация
						,_Fld17230RRef	= @Ответственный
						,_Fld17231	= @Комментарий
						,_Fld17232RRef	= @СчетДоходовБУ
						,_Fld17233RRef	= @Субконто1
						,_Fld17234RRef	= @Субконто2
						,_Fld17235RRef	= @Субконто3
						,_Fld17236	= @СуммаДокумента
						,_Fld17237RRef	= @СчетДоходовНУ
						,_Fld17238RRef	= @СубконтоНУ1
						,_Fld17239RRef	= @СубконтоНУ2
						,_Fld17240RRef	= @СубконтоНУ3
						,_Fld17241	= @ОтражатьВНалоговомУчете
						,_Fld17242	= @КраткийСоставДокумента
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("СчетДоходовБУ", Guid.Empty);
					Команда.Parameters.AddWithValue("Субконто1", Guid.Empty);
					Команда.Parameters.AddWithValue("Субконто2", Guid.Empty);
					Команда.Parameters.AddWithValue("Субконто3", Guid.Empty);
					Команда.Parameters.AddWithValue("СуммаДокумента", СуммаДокумента);
					Команда.Parameters.AddWithValue("СчетДоходовНУ", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоНУ1", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоНУ2", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоНУ3", Guid.Empty);
					Команда.Parameters.AddWithValue("ОтражатьВНалоговомУчете", ОтражатьВНалоговомУчете);
					Команда.Parameters.AddWithValue("КраткийСоставДокумента", КраткийСоставДокумента);
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
					Команда.CommandText = @"Delete _Document589
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}