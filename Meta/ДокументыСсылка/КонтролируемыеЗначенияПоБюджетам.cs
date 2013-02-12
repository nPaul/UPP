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
	public partial class КонтролируемыеЗначенияПоБюджетам:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.СценарииПланирования Сценарий;
		public V82.Перечисления/*Ссылка*/.ВидыКонтролируемогоЗначенияБюджета ВидКонтролируемыхЗначений;//Вид контролируемых значений
		public V82.Перечисления/*Ссылка*/.ИспользованиеКонтролируемыхЗначенийБюджетов ИспользованиеКонтролируемыхЗначений;//Использование контролируемых значений
		public V82.Перечисления/*Ссылка*/.ВидыОграниченийОборотовБюджета ВидОграниченияОборотов;//Вид ограничения оборотов
		public V82.СправочникиСсылка.СценарииПланирования КонтролирующийСценарий;//Контролирующий сценарий
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов Состояние;
		///<summary>
		///Начало интервала контроля оборотов по контролирующему сценарию
		///</summary>
		public DateTime ДатаНачалаКонтролирующегоСценария;//Дата начала контроля оборотов 
		///<summary>
		///Конец интервала контроля оборотов по контролирующему сценарию
		///</summary>
		public DateTime ДатаКонцаКонтролирующегоСценария;//Дата конца контроля оборотов 
		///<summary>
		///Контролировать обороты в разрезе ЦФО
		///</summary>
		public bool КонтролироватьЦФО;//Контролировать ЦФО
		///<summary>
		///Контролировать обороты в разрезе проектов
		///</summary>
		public bool КонтролироватьПроекты;//Контролировать проекты
		///<summary>
		///Контролировать обороты в разрезе контрагентов
		///</summary>
		public bool КонтролироватьКонтрагентов;//Контролировать контрагентов
		///<summary>
		///Контролировать обороты в разрезе номенклатуры
		///</summary>
		public bool КонтролироватьНоменклатуру;//Контролировать номенклатуру
		public V82.Перечисления/*Ссылка*/.ВидыОтклоненийКонтролируемыхЗначенийБюджетов ВидОтклоненияКонтролируемыхЗначений;//Вид отклонения контролируемых значений
		///<summary>
		///Отклонение от значения контролирующего сценария
		///</summary>
		public decimal/*(15.2)*/ Отклонение;
	}
}