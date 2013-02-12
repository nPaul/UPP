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
	public partial class Событие:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public string/*(300)*/ АдресЭлектроннойПочты;//Адрес электронной почты
		public V82.Перечисления/*Ссылка*/.Важность Важность;
		public V82.Перечисления/*Ссылка*/.ВидыОбъектовСобытия ВидОбъекта;//Вид объекта
		public V82.Перечисления/*Ссылка*/.ВидыСобытий ВидСобытия;//Вид события
		public DateTime ВремяНапоминания;//Время напоминания
		public V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей ИсточникИнформацииПриОбращении;//Источник информации при обращении
		public string/*(0)*/ Комментарий;
		public object КонтактноеЛицо;//Контактное лицо
		public object Контрагент;
		public bool НапомнитьОСобытии;//Напомнить о событии
		public DateTime НачалоСобытия;//Начало события
		public DateTime ОкончаниеСобытия;//Окончание события
		public string/*(200)*/ ОписаниеСобытия;//Описание события
		public object Основание;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.Помещения Помещение;
		public V82.СправочникиСсылка.Проекты Проект;
		public string/*(0)*/ СодержаниеСобытия;//Содержание события
		public V82.Перечисления/*Ссылка*/.СостоянияСобытий СостояниеСобытия;//Состояние события
		public V82.СправочникиСсылка.Территории Территория;
		public V82.Перечисления/*Ссылка*/.ВходящееИсходящееСобытие ТипСобытия;//Тип события
		public V82.СправочникиСсылка.ГруппыСобытий ГруппаСобытия;//Группа события
		public bool ЕстьВложения;//Есть вложения
		public V82.СправочникиСсылка.КонтактныеЛица КонтактноеЛицоБезКонтрагента;//Контактное лицо
		public decimal/*(10)*/ ИнтервалНапоминания;//Интервал напоминания
		public string/*(50)*/ ПредметКонтакта;//Предмет
		public V82.СправочникиСсылка.ЗаявкиКандидатов ЗаявкаКандидата;//Заявка кандидата
	}
}