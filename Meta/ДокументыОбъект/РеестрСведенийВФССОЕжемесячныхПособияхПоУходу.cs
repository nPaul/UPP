﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class РеестрСведенийВФССОЕжемесячныхПособияхПоУходу:ДокументОбъект
	{
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
		public V82.СправочникиСсылка.ФизическиеЛица Руководитель;
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьРуководителя;//Должность руководителя
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public string/*(12)*/ ИНН;
		public string/*(9)*/ КПП;
		public string/*(15)*/ ОГРН;
		public V82.СправочникиСсылка.ФизическиеЛица РеестрСоставил;//Реестр составил
		public string/*(30)*/ ТелефонСоставителя;//Телефон составителя
		public string/*(40)*/ АдресЭлектроннойПочтыСоставителя;//Адрес электронной почты составителя
		public V82.СправочникиСсылка.ФизическиеЛица ГлавныйБухгалтер;//Главный бухгалтер
		public bool ВыводитьПодписиВРеестрПособий;//Выводить подписи в реестр пособий
	}
}