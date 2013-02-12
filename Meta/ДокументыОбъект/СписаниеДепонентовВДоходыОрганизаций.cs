﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class СписаниеДепонентовВДоходыОрганизаций:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public object СчетДоходовБУ;//Счет учета доходов в БУ
		public object Субконто1;//Субконто номер 1
		public object Субконто2;//Субконто номер 2
		public object Субконто3;//Субконто номер 3
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		public object СчетДоходовНУ;//Счет учета доходов в НУ
		public object СубконтоНУ1;//Субконто нал. учета номер 1
		public object СубконтоНУ2;//Субконто нал. учета номер 2
		public object СубконтоНУ3;//Субконто нал. учета номер 3
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
	}
}