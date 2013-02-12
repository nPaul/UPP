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
	///Восстановление сумм НДС ранее принятых к вычету, право на применение вычета по которым впоследствии исчезло
	///</summary>
	public partial class ВосстановлениеНДС:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public DateTime НачалоПериода;//Начало периода
		public DateTime КонецПериода;//Конец периода
		public bool ОтразитьВКнигеПродаж;//Отразить в книге продаж
	}
}