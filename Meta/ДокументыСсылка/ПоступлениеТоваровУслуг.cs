﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class ПоступлениеТоваровУслуг:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеТоваровУслуг ВидОперации;//Вид операции
		///<summary>
		///(Общ) Вид поступления: на склад или по ордеру
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров ВидПоступления;//Вид поступления
		///<summary>
		///(Общ) 
		///</summary>
		public DateTime ДатаВходящегоДокумента;//Дата документа сторонней организации
		///<summary>
		///(Общ) 
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор  контрагента
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета БанковскийСчетКонтрагента;//Банковский счет контрагента
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ) 
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		///<summary>
		///(Общ) 
		///</summary>
		public decimal/*(10)*/ КратностьВзаиморасчетов;//Кратность взаиморасчетов
		///<summary>
		///(Общ) 
		///</summary>
		public decimal/*(10.4)*/ КурсВзаиморасчетов;//Курс взаиморасчетов
		///<summary>
		///(Регл)
		///</summary>
		public bool НДСВключенВСтоимость;//НДС включен в стоимость
		///<summary>
		///(Общ) 
		///</summary>
		public string/*(30)*/ НомерВходящегоДокумента;//Номер документа сторонней организации
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///(Общ) 
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Регл) 
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		///<summary>
		///(Общ) 
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Упр) 
		///</summary>
		public bool РегистрироватьЦеныПоставщика;//Регистрировать цены поставщика
		///<summary>
		///(Общ)
		///</summary>
		public bool СуммаВключаетНДС;//Сумма включает НДС
		///<summary>
		///(Общ)
		///</summary>
		public object СкладОрдер;//Склад-ордер
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовПоАвансам;//Счет учета расчетов по авансам
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовПоТаре;//Счет учета расчетов по таре
		///<summary>
		///(Регл) 
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом;//Счет учета расчетов с контрагентом
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов ТипЦен;//Тип цен
		///<summary>
		///(Общ)
		///</summary>
		public bool УчитыватьНДС;//Учитывать НДС
		///<summary>
		///(Общ) 
		///</summary>
		public object Сделка;
		public V82.СправочникиСсылка.УсловияПродаж УсловиеПродаж;//Условие продаж
		public object Проект;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Грузоотправитель;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Грузополучатель;
		public string/*(20)*/ НомерВходящегоДокументаЭлектронногоОбмена;//Номер входящего документа электронного обмена
		public DateTime ДатаВходящегоДокументаЭлектронногоОбмена;//Дата входящего документа электронного обмена
	}
}