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
	public partial class ОплатаПоСреднемуЗаработку:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public DateTime ПериодРегистрации;//Период регистрации
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник;
		public V82.СправочникиСсылка.ФизическиеЛица Физлицо;//Физическое лицо
		public object ВидРасчета;//Вид расчета
		///<summary>
		///Процент оплаты
		///</summary>
		public decimal/*(6.2)*/ ПроцентОплаты;//Процент оплаты
		public DateTime ДатаНачала;//Дата начала
		public DateTime ДатаОкончания;//Дата окончания
		public decimal/*(7.2)*/ ОплачиватьЧасов;//Оплачивать часов
		public V82.ДокументыСсылка.ОплатаПоСреднемуЗаработку ПерерассчитываемыйДокумент;//Перерассчитываемый документ
		public V82.Перечисления/*Ссылка*/.СпособыРегистрацииВремени СпособРегистрацииВремени;//Способ регистрации времени
		public V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию УдалитьПриказ;//Удалить приказ
		///<summary>
		///Дата начала события, оплачиваемого по среднему заработку
		///</summary>
		public DateTime ДатаНачалаСобытия;//Дата начала события
		///<summary>
		///Дата начала расчетного периода
		///</summary>
		public DateTime ПериодРасчетаСреднегоЗаработкаНачало;//Период расчета среднего заработка начало
		///<summary>
		///Дата окончания расчетного периода
		///</summary>
		public DateTime ПериодРасчетаСреднегоЗаработкаОкончание;//Период расчета среднего заработка окончание
	}
}