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
	///(Упр)
	///</summary>
	public partial class ОтчетОСоставеСмены:ДокументОбъект
	{
		public V82.СправочникиСсылка.Подразделения Подразделение;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.Смены Смена;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public DateTime ГраницаСмены;//Граница смены
	}
}