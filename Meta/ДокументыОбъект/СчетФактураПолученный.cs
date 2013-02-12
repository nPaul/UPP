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
	public partial class СчетФактураПолученный:ДокументОбъект
	{
		public DateTime ДатаИсправления;//Дата исправления
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		public object ДокументОснование;//Документ основание
		public DateTime ДатаВходящегоДокумента;//Дата документа сторонней организации
		public string/*(30)*/ НомерВходящегоДокумента;//Номер документа сторонней организации
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		public decimal/*(14.2)*/ СуммаДокумента;//Сумма документа
		public bool СформированПриВводеНачальныхОстатковНДС;//Сформирован при вводе начальных остатков НДС
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(20)*/ НомерВходящегоДокументаЭлектронногоОбмена;//Номер входящего документа электронного обмена
		public DateTime ДатаВходящегоДокументаЭлектронногоОбмена;//Дата входящего документа электронного обмена
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public bool УдалитьНаАванс;//(не используется) На аванс
		public DateTime ДатаИсправленияИсходногоДокумента;//Дата исправления исходного документа
		public DateTime ДатаИсходногоДокумента;//Дата корректируемого счета-фактуры
		public bool Исправление;
		public string/*(10)*/ КодВидаОперации;//Код вида операции
		public decimal/*(1)*/ КодСпособаПолучения;//Код способа получения
		public decimal/*(10)*/ НомерИсправления;//Номер исправления
		public decimal/*(10)*/ НомерИсправленияИсходногоДокумента;//Номер исправления исходного документа
		public string/*(30)*/ НомерИсходногоДокумента;//Номер корректируемого счета-фактуры
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Сумма по документу основанию в валюте документа увеличение
		///</summary>
		public decimal/*(14.2)*/ СуммаУвеличение;//Сумма по документу-основанию увеличение
		///<summary>
		///Сумма по документу основанию в валюте документа уменьшение
		///</summary>
		public decimal/*(14.2)*/ СуммаУменьшение;//Сумма по документу-основанию уменьшение
		public bool УчитыватьИсправлениеИсходногоДокумента;//Учитывать исправление исходного документа
		public bool СчетФактураБезНДС;//Счет-фактура без НДС
		///<summary>
		///Сумма НДС по документу основанию в валюте документа увеличение
		///</summary>
		public decimal/*(14.2)*/ СуммаНДСУвеличение;//Сумма НДС по документу-основанию увеличение
		///<summary>
		///Сумма НДС по документу основанию в валюте документа уменьшение
		///</summary>
		public decimal/*(14.2)*/ СуммаНДСУменьшение;//Сумма НДС по документу-основанию уменьшение
		///<summary>
		///Сумма НДС по документу основанию в валюте документа
		///</summary>
		public decimal/*(14.2)*/ СуммаНДСДокумента;//Сумма НДС по документу-основанию
		public V82.ДокументыСсылка.СчетФактураПолученный ИсправляемыйСчетФактура;//Исправляемый счет-фактура
		public V82.Перечисления/*Ссылка*/.ВидСчетаФактурыПолученного ВидСчетаФактуры;//Вид счета-фактуры
		public bool БланкСтрогойОтчетности;//Бланк строгой отчетности
	}
}