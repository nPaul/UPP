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
	///(Регл)
	///</summary>
	public partial class ОпределениеФинансовыхРезультатов:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public DateTime ПериодРегистрации;//Период регистрации
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		public bool ОпределениеФинансовогоРезультатаОтПродаж;//Определение финансового результата от продаж
		public bool ОпределениеСальдоПрочихДоходовИРасходов;//Определение сальдо прочих доходов и расходов
		public bool РасчетРезервовПоСомнительнымДолгам;//Расчет резервов по сомнительным долгам
		public bool СписаниеУбытковПрошлыхЛет;//Списание убытков прошлых лет (НУ)
		public bool ВключениеАмортизационнойПремииВРасходы;//Включение амортизационной премии в расходы
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(0)*/ Комментарий;
	}
}