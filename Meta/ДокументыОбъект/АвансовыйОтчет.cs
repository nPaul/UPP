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
	public partial class АвансовыйОтчет:ДокументОбъект
	{
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10.4)*/ КурсДокумента;//Курс документа
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10)*/ КратностьДокумента;//Кратность документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Общ)
		///</summary>
		public object СкладОрдер;//Склад ордер
		///<summary>
		///(Общ)
		///</summary>
		public bool СуммаВключаетНДС;//Сумма включает НДС
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен;//Тип цен
		///<summary>
		///(Общ)
		///</summary>
		public bool УчитыватьНДС;//Учитывать НДС
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ФизическиеЛица ФизЛицо;//Подотчетное лицо
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ) Вид поступления: на склад или по ордеру
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров ВидПоступления;//Вид поступления
		///<summary>
		///(Регл)
		///</summary>
		public bool НДСВключенВСтоимость;//НДС включен в стоимость
		///<summary>
		///Назначение аванса
		///</summary>
		public string/*(100)*/ НазначениеАванса;//Назначение аванса
		public object Проект;
		public string/*(5)*/ КоличествоДокументов;//Количество документов
		public string/*(5)*/ КоличествоЛистов;//Количество листов
	}
}