﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class ЗапросНаИнформационноеОбслуживаниеНалогоплательщика:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.РегистрацияВИФНС Получатель;
		public DateTime ДатаНачалаПериода;//Дата начала периода
		public DateTime ДатаОкончанияПериода;//Дата окончания периода
		public V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН ВидУслуги;//Вид услуги
		public V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН ФорматОтвета;//Формат ответа
		public string/*(0)*/ АдресПредставленияСправки;//Адрес представления справки
		public decimal/*(1)*/ ДополнительныйПараметр;//Дополнительный параметр
		public V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС ФорматЗапроса;//Формат запроса
	}
}