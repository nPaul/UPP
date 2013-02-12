﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class ДолжностиОрганизаций:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		public Guid Ссылка;
		public long Версия;
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления;
		public bool Предопределенный;
		public Guid Владелец;
		public bool ЭтоГруппа;
		public Guid Родитель;
		public string/*9*/ Код;
		public string/*100*/ Наименование;
		public V82.СправочникиСсылка.СпискиПрофессийДолжностейЛьготногоПенсионногоОбеспечения КодПозицииСписка;//Код позиции списка
		public V82.СправочникиСсылка.ОснованияВыслугиЛет ОснованиеВыслугиЛет;//Основание выслуги лет
		public bool АУП;//Административно-управленческий персонал
		public V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляВоинскогоУчета КатегорияВоинскогоУчета;//Категория воинского учета
		public string/*(6)*/ КодПоОКПДТР;//Код по ОКПДТР
		public V82.СправочникиСсылка.Должности Должность;//Должность кадрового плана
		///<summary>
		///(Регл)
		///</summary>
		public V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляСтатистическогоУчета КатегорияСтатистическогоУчета;//Категория статистического учета
		public bool ЯвляетсяДолжностьюЛетногоЭкипажа;//Является должностью летного экипажа
		public bool ЯвляетсяШахтерскойДолжностью;//Является шахтерской должностью
		public V82.Перечисления/*Ссылка*/.КатегорииДолжностейДляУчетаЗабронированныхС2011Года КатегорияУчетаЗабронированных;//Категория учета забронированных
		public bool ЯвляетсяФармацевтическойДолжностью;//Является фармацевтической должностью
		public void Записать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference92(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2276RRef
						,_Fld2277RRef
						,_Fld2278
						,_Fld2279RRef
						,_Fld2280
						,_Fld2281RRef
						,_Fld2282RRef
						,_Fld2283
						,_Fld2284
						,_Fld2285RRef
						,_Fld2286)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@КодПозицииСписка
						,@ОснованиеВыслугиЛет
						,@АУП
						,@КатегорияВоинскогоУчета
						,@КодПоОКПДТР
						,@Должность
						,@КатегорияСтатистическогоУчета
						,@ЯвляетсяДолжностьюЛетногоЭкипажа
						,@ЯвляетсяШахтерскойДолжностью
						,@КатегорияУчетаЗабронированных
						,@ЯвляетсяФармацевтическойДолжностью)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference92
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2276RRef	= @КодПозицииСписка
						,_Fld2277RRef	= @ОснованиеВыслугиЛет
						,_Fld2278	= @АУП
						,_Fld2279RRef	= @КатегорияВоинскогоУчета
						,_Fld2280	= @КодПоОКПДТР
						,_Fld2281RRef	= @Должность
						,_Fld2282RRef	= @КатегорияСтатистическогоУчета
						,_Fld2283	= @ЯвляетсяДолжностьюЛетногоЭкипажа
						,_Fld2284	= @ЯвляетсяШахтерскойДолжностью
						,_Fld2285RRef	= @КатегорияУчетаЗабронированных
						,_Fld2286	= @ЯвляетсяФармацевтическойДолжностью
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("КодПозицииСписка", КодПозицииСписка.Ссылка);
					Команда.Parameters.AddWithValue("ОснованиеВыслугиЛет", ОснованиеВыслугиЛет.Ссылка);
					Команда.Parameters.AddWithValue("АУП", АУП);
					Команда.Parameters.AddWithValue("КатегорияВоинскогоУчета", КатегорияВоинскогоУчета.Ключ());
					Команда.Parameters.AddWithValue("КодПоОКПДТР", КодПоОКПДТР);
					Команда.Parameters.AddWithValue("Должность", Должность.Ссылка);
					Команда.Parameters.AddWithValue("КатегорияСтатистическогоУчета", КатегорияСтатистическогоУчета.Ключ());
					Команда.Parameters.AddWithValue("ЯвляетсяДолжностьюЛетногоЭкипажа", ЯвляетсяДолжностьюЛетногоЭкипажа);
					Команда.Parameters.AddWithValue("ЯвляетсяШахтерскойДолжностью", ЯвляетсяШахтерскойДолжностью);
					Команда.Parameters.AddWithValue("КатегорияУчетаЗабронированных", КатегорияУчетаЗабронированных.Ключ());
					Команда.Parameters.AddWithValue("ЯвляетсяФармацевтическойДолжностью", ЯвляетсяФармацевтическойДолжностью);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Reference92
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}