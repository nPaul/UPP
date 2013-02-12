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
	public partial class РеестрДСВ3:ДокументСсылка
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
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public V82.Перечисления/*Ссылка*/.ФорматФайлаПФР ФорматФайла;//Формат файла
		public string/*(40)*/ НомерПлатежногоПоручения;//Номер платежного поручения
		public DateTime ДатаПлатежногоПоручения;//Дата платежного поручения
		public DateTime ДатаИсполненияПлатежногоПоручения;//Дата исполнения платежного поручения
		public string/*(5)*/ НомерПачки;//Номер пачки
	}
}