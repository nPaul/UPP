﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class ЗарплатаКВыплатеОрганизаций:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.Организации Организация;
		public DateTime ПериодРегистрации;//Период регистрации
		public V82.Перечисления/*Ссылка*/.СпособыВыплатыЗарплаты СпособВыплаты;//Способ выплаты
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///Количество дней, на которые задержана выплата зарплаты
		///</summary>
		public decimal/*(5)*/ ДнейНеВыплаты;//Дней не выплаты
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public V82.Перечисления/*Ссылка*/.ХарактерВыплатыЗарплаты ХарактерВыплаты;//Характер выплаты
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		public object ДокументОснование;//Документ основание
		public DateTime ДатаНачала;//Дата начала
		public DateTime ДатаОкончания;//Дата окончания
		public V82.СправочникиСсылка.Контрагенты Банк;
		public decimal/*(3)*/ ПроцентВыплаты;//Процент выплаты
		public bool ПредварительныйУчетУдержаний;//Предварительный учет удержаний
		public V82.Перечисления/*Ссылка*/.СпособыОкругленияЗарплатыКВыплате Округление;
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		public bool ДанныеПрошлойВерсии;//Перенесен из 7.7
	}
}