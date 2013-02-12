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
	public partial class БюджетнаяОперация:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.СценарииПланирования Сценарий;
		public DateTime ПериодПланирования;//Период планирования
		public V82.СправочникиСсылка.СтатьиОборотовПоБюджетам СтатьяОборотов;//Статья оборотов
		public V82.СправочникиСсылка.КлассификаторЕдиницИзмерения ЕдиницаИзмерения;//Единица измерения
		public V82.СправочникиСсылка.Подразделения ЦФО;
		public V82.СправочникиСсылка.Проекты Проект;
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		public object Номенклатура;
		public decimal/*(15.3)*/ Количество;
		public decimal/*(15.2)*/ Цена;
		public decimal/*(15.2)*/ Сумма;
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		public decimal/*(10.4)*/ КурсДокумента;//Курс документа
		public decimal/*(10)*/ КратностьДокумента;//Кратность документа
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов Состояние;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
	}
}