﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class ОбъявлениеНаВзносНаличными:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Банковский счет организации
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетОрганизации;//Счет организации
		public V82.СправочникиСсылка.Кассы Касса;
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public bool Оплачено;
		public DateTime ДатаОплаты;//Дата оплаты
		public V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств;//Статья движения денежных средств
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
	}
}