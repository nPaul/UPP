﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Упр)
	///</summary>
	public partial class ПланПродаж:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
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
		public V82.СправочникиСсылка.Проекты Проект;
		public V82.СправочникиСсылка.СценарииПланирования Сценарий;
		///<summary>
		///Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен;//Тип цен
		public bool СуммаВключаетНДС;//Сумма включает НДС
		public bool УчитыватьНДС;//Учитывать НДС
		public ХранилищеЗначения НастройкиПомощникаПланирования;//Настройки помощника планирования
		public V82.Перечисления/*Ссылка*/.Периодичность ПериодичностьДетализации;//Периодичность детализации
	}
}