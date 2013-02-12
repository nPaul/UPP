﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class ПланДвиженияДенежныхСредств:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.СценарииПланирования Сценарий;
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		public DateTime ДатаПланирования;//Дата планирования
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public decimal/*(10)*/ КратностьДокумента;//Кратность документа
		public decimal/*(10.4)*/ КурсДокумента;//Курс документа
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.Подразделения Подразделение;
		public V82.Перечисления/*Ссылка*/.ВидыДенежныхСредств ВидДенежныхСредств;//Вид денежных средств
	}
}