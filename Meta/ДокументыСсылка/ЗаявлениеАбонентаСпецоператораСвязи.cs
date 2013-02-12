﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class ЗаявлениеАбонентаСпецоператораСвязи:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public string/*(32)*/ ИдентификаторДокументооборота;//Идентификатор документооборота
		public V82.Перечисления/*Ссылка*/.ТипыЗаявленияАбонентаСпецоператораСвязи ТипЗаявления;//Тип заявления
		public V82.Перечисления/*Ссылка*/.СтатусыЗаявленияАбонентаСпецоператораСвязи Статус;
		public V82.СправочникиСсылка.УчетныеЗаписиДокументооборота УчетнаяЗапись;//Учетная запись
		public object ТипОрганизации;//Тип организации
		public string/*(12)*/ ИНН;
		public string/*(9)*/ КПП;
		public string/*(255)*/ ПолноеНаименование;//Полное наименование
		public string/*(255)*/ КраткоеНаименование;//Краткое наименование
		public bool ПризнакУполномоченногоПредставителя;//Признак уполномоченного представителя
		public bool ПризнакКрупнейшегоНалогоплательщика;//Признак крупнейшего налогоплательщика
		public bool ПризнакОбособленногоПодразделения;//Признак обособленного подразделения
		public string/*(240)*/ АдресЮридический;//Адрес юридический
		public string/*(240)*/ АдресФактический;//Адрес фактический
		public string/*(14)*/ РегНомерПФР;//Рег номер ПФР
		public string/*(10)*/ РегНомерФСС;//Рег номер ФСС
		public string/*(20)*/ ТелефонОсновной;//Телефон основной
		public string/*(20)*/ ТелефонДополнительный;//Телефон дополнительный
		public string/*(100)*/ ЭлектроннаяПочта;//Электронная почта
		public string/*(60)*/ ВладелецЭЦПФамилия;//Владелец ЭЦПФамилия
		public string/*(60)*/ ВладелецЭЦПИмя;//Владелец ЭЦПИмя
		public string/*(60)*/ ВладелецЭЦПОтчество;//Владелец ЭЦПОтчество
		public string/*(100)*/ ВладелецЭЦПДолжность;//Владелец ЭЦПДолжность
		public string/*(100)*/ ВладелецЭЦППодразделение;//Владелец ЭЦППодразделение
		public V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность ВладелецЭЦПВидДокумента;//Владелец ЭЦПВид документа
		public string/*(25)*/ ВладелецЭЦПНомерДокумента;//Владелец ЭЦПНомер документа
		public string/*(25)*/ ВладелецЭЦПСерияДокумента;//Владелец ЭЦПСерия документа
		public DateTime ВладелецЭЦПДатаВыдачиДокумента;//Владелец ЭЦПДата выдачи документа
		public string/*(255)*/ ВладелецЭЦПКемВыданДокумент;//Владелец ЭЦПКем выдан документ
		public V82.Перечисления/*Ссылка*/.ТипыВладельцевЭЦП ВладелецЭЦПТип;//Владелец ЭЦПТип
		public V82.Перечисления/*Ссылка*/.ТипыКриптоПровайдеров ТипКриптопровайдера;//Тип криптопровайдера
		public string/*(255)*/ ПутьКонтейнерЗакрытогоКлюча;//Путь контейнер закрытого ключа
		public string/*(0)*/ Комментарий;
		public string/*(0)*/ СтатусКомментарий;//Статус комментарий
		public V82.Перечисления/*Ссылка*/.СпецоператорыСвязи СпецоператорСвязи;//Спецоператор связи
		public V82.СправочникиСсылка.Организации Организация;
		public DateTime ДатаОтправкиЗаявления;//Дата отправки заявления
		public DateTime ДатаПолученияОтвета;//Дата получения ответа
		public DateTime ДатаСозданияУчетнойЗаписи;//Дата создания учетной записи
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(10)*/ ДополнительныйКодФСС;//Дополнительный код ФСС
		public string/*(0)*/ НомерОсновнойПоставки1с;//Номер основной поставки1с
	}
}