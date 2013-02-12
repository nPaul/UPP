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
	public partial class ИсполнительныйЛист:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.ФизическиеЛица Физлицо;
		public V82.СправочникиСсылка.Организации Организация;
		public string/*(30)*/ ВидИсполнительногоДокумента;//Вид исполнительного документа
		public string/*(0)*/ РеквизитыИсполнительногоДокумента;//Реквизиты исполнительного документа
		public V82.СправочникиСсылка.Контрагенты Получатель;
		public DateTime ДатаНачала;//Дата начала
		public DateTime ДатаОкончания;//Дата окончания
		public V82.Перечисления/*Ссылка*/.СпособыРасчетаУдержанийПоИЛ СпособРасчетаУдержания;//Способ расчета удержания
		public decimal/*(10.2)*/ Размер;
		public decimal/*(10.2)*/ Предел;
		public V82.СправочникиСсылка.ПрожиточныеМинимумы ПрожиточныйМинимум;//Прожиточный минимум
		public DateTime ДатаДействия;//Дата действия
		public decimal/*(5.2)*/ ПроцентПочтовогоСбора;//Процент почтового сбора
		public V82.СправочникиСсылка.ТарифыПочтовогоСбора Тариф;
		public V82.Перечисления/*Ссылка*/.СпособыПеречисленийПоИсполнительномуЛисту СпособПеречисленияПоИсполнительномуЛисту;//Способ перечисления по исполнительному листу
		public V82.СправочникиСсылка.ТарифыБанковНаДенежныеПереводы ТарифБанкаНаДенежныеПереводы;//Тариф банка на денежные переводы
		public bool ПочтовыйСборРассчитыватьПроцентом;//Почтовый сбор рассчитывать процентом
		public bool ДанныеПрошлойВерсии;//Перенесен из 7.7
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///1 - процентом, 2 - фиксированной суммой
		///</summary>
		public decimal/*(1)*/ УдалитьСпособРасчетаИЛ;//Удалить способ расчета ИЛ
		///<summary>
		///0 - процентом, 1 - не начислять, 2 - по шкале
		///</summary>
		public decimal/*(1)*/ УдалитьСпособРасчетаПС;//Способ расчета почтового сбора
		public bool УдалитьУчитыватьБольничныеЛисты;//Удалить учитывать больничные листы
	}
}