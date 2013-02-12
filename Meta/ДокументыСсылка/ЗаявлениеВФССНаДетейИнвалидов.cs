﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class ЗаявлениеВФССНаДетейИнвалидов:ДокументСсылка
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
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public string/*(135)*/ НаименованиеТерриториальногоОрганаФСС;//Наименование территориального органа ФСС
		public string/*(14)*/ РегистрационныйНомерФСС;//Регистрационный номер ФСС
		public string/*(14)*/ ДополнительныйКодФСС;//Дополнительный код ФСС
		public string/*(5)*/ КодПодчиненностиФСС;//Код подчиненности ФСС
		public string/*(240)*/ АдресОрганизации;//Адрес организации
		public V82.СправочникиСсылка.ФизическиеЛица Руководитель;
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьРуководителя;//Должность руководителя
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public decimal/*(15.2)*/ СуммаПособий;//Сумма пособий
		public decimal/*(2)*/ КоличествоСтраниц;//Количество страниц
		public string/*(30)*/ ТелефонСоставителя;//Телефон составителя
		public V82.СправочникиСсылка.Банки Банк;
		public string/*(100)*/ НаименованиеБанка;//Наименование банка
		public string/*(20)*/ НомерЛицевогоСчета;//Номер лицевого счета
		public string/*(20)*/ НомерСчета;//Номер счета
		public string/*(9)*/ БИКБанка;//БИК банка
		///<summary>
		///Корреспонденский счет банка
		///</summary>
		public string/*(20)*/ КоррСчетБанка;//Корр. счет банка
	}
}