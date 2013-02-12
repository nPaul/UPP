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
	///(Упр)
	///</summary>
	public partial class ПереоценкаТоваровОтданныхНаКомиссию:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен;//Тип цен
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public decimal/*(10.4)*/ КурсВзаиморасчетов;//Курс взаиморасчетов
		public decimal/*(10)*/ КратностьВзаиморасчетов;//Кратность взаиморасчетов
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public object Сделка;
	}
}