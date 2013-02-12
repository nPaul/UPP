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
	///(Общ)
	///</summary>
	public partial class АккредитивПереданный:ДокументОбъект
	{
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///Отзывный (непокрытый), Отзывный (покрытый), Безотзывный (непокрытый), Безотзывный (покрытый)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыАккредитивов ВидАккредитива;//Вид аккредитива
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийСписаниеБезналичныхДенежныхСредств ВидОперации;//Вид операции
		///<summary>
		///(Общ) электронно, почтой, телеграфом
		///</summary>
		public string/*(15)*/ ВидПлатежа;//Вид платежа
		///<summary>
		///(Упр)
		///</summary>
		public DateTime ДатаОплаты;//Дата оплаты
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		///<summary>
		///(Общ)
		///</summary>
		public object ДокументОснование;//Документ основание
		///<summary>
		///Перечень документов, по которым производится платеж
		///</summary>
		public string/*(0)*/ ДокументыКПредъявлению;//Документы к предъявлению
		///<summary>
		///Дополнительные условия по договору
		///</summary>
		public string/*(0)*/ ДополнительныеУсловия;//Дополнительные условия
		///<summary>
		///(Регл)
		///</summary>
		public string/*(12)*/ ИННПлательщика;//ИНН плательщика
		///<summary>
		///(Регл)
		///</summary>
		public string/*(12)*/ ИННПолучателя;//ИНН получателя
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент;//Получатель
		///<summary>
		///(Регл)
		///</summary>
		public string/*(9)*/ КПППлательщика;//КПП плательщика
		///<summary>
		///(Регл)
		///</summary>
		public string/*(9)*/ КПППолучателя;//КПП получателя
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ НазначениеПлатежа;//Назначение платежа
		///<summary>
		///(Общ)
		///</summary>
		public bool Оплачено;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
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
		public bool ОтраженоВОперУчете;//Отражено в опер. учете
		///<summary>
		///Срок действия аккредитива
		///</summary>
		public DateTime СрокДействия;//Срок действия
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств;//Статья движения денежных средств
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт1;//Субконто Дт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт2;//Субконто Дт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт3;//Субконто Дт1
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///Счет депонирования в случае покрытого аккредитива
		///</summary>
		public string/*(20)*/ СчетДепонента;//Счет депонента
		///<summary>
		///(Общ) Банковский счет контрагента
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетКонтрагента;//Счет контрагента
		///<summary>
		///(Общ) Банковский счет организации
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетОрганизации;//Счет организации
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом;//Счет учета расчетов с контрагентом
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ТекстПлательщика;//Текст плательщика
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ТекстПолучателя;//Текст получателя
		///<summary>
		///(Упр)
		///</summary>
		public V82.Перечисления/*Ссылка*/.УсловияОплатыРасчетныхДокументов УсловиеОплаты;//Условие оплаты
		///<summary>
		///(общ)
		///</summary>
		public bool ЧастичнаяОплата;//По документу происходит оплата частями
		public string/*(200)*/ Содержание_УСН;//Содержание УСН
		public decimal/*(15.2)*/ Графа4_УСН;//Графа4 УСН
		public decimal/*(15.2)*/ Графа5_УСН;//Графа5 УСН
		public decimal/*(15.2)*/ Графа6_УСН;//Графа5
		public decimal/*(15.2)*/ Графа7_УСН;//Графа5
		public bool ДоходыЕНВД_УСН;//ДоходыЕНВД
		public bool РасходыЕНВД_УСН;//Расходы ЕНВД УСН
		public decimal/*(15.2)*/ НДС_УСН;//НДС УСН
		public bool РучнаяНастройка_УСН;//Ручная настройка УСН
		public V82.СправочникиСсылка.Подразделения Подразделение;
	}
}