﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class НачислениеЗарплатыРаботникамОрганизаций:ДокументОбъект
	{
		public DateTime ПериодРегистрации;//Период регистрации
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public object ПерерассчитываемыйДокумент;//Перерассчитываемый документ
		public V82.Перечисления/*Ссылка*/.ВидыОперацийНачислениеЗарплатыРаботникамОрганизаций ВидОперации;//Вид операции
		public V82.Перечисления/*Ссылка*/.ПериодНачисленияЗарплаты ПериодНачисления;//Период начисления
		public DateTime ПериодНачисленияДатаНачала;//Период начисления дата начала
		public DateTime ПериодНачисленияДатаОкончания;//Период начисления дата окончания
	}
}