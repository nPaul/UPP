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
	public partial class ВычетыНДФЛ:СправочникОбъект
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
		public string/*7*/ Код;
		public string/*150*/ Наименование;
		public string/*(3)*/ КодДляОтчетности2007;//Код для отчетности 2007 г.
		public string/*(3)*/ КодДляОтчетности2008;//Код для отчетности 2008 г.
		public string/*(3)*/ КодДляОтчетности2009;//Код для отчетности 2009 г.
		public string/*(0)*/ Наименование2007;//Наименование 2007 г.
		public string/*(0)*/ Наименование2008;//Наименование 2008 г.
		public string/*(3)*/ КодДляОтчетности2010;//Код для отчетности 2010 г.
		public bool НеПредоставляетсяНерезидентам;//Не предоставляется нерезидентам
		public bool НеОтражаетсяВОтчетности2010;//Не отражается в отчетности-2010
		public V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ ГруппаВычета;//Группа вычета
		public string/*(0)*/ Наименование2010;//Наименование 2010 г.
		public string/*(3)*/ КодДляОтчетности2011;//Код для отчетности 2011 г.
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
						Insert Into _Reference70(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2017
						,_Fld2018
						,_Fld2019
						,_Fld2020
						,_Fld2021
						,_Fld2022
						,_Fld2023
						,_Fld2024
						,_Fld2025RRef
						,_Fld2026
						,_Fld2027)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@КодДляОтчетности2007
						,@КодДляОтчетности2008
						,@КодДляОтчетности2009
						,@Наименование2007
						,@Наименование2008
						,@КодДляОтчетности2010
						,@НеПредоставляетсяНерезидентам
						,@НеОтражаетсяВОтчетности2010
						,@ГруппаВычета
						,@Наименование2010
						,@КодДляОтчетности2011)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference70
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2017	= @КодДляОтчетности2007
						,_Fld2018	= @КодДляОтчетности2008
						,_Fld2019	= @КодДляОтчетности2009
						,_Fld2020	= @Наименование2007
						,_Fld2021	= @Наименование2008
						,_Fld2022	= @КодДляОтчетности2010
						,_Fld2023	= @НеПредоставляетсяНерезидентам
						,_Fld2024	= @НеОтражаетсяВОтчетности2010
						,_Fld2025RRef	= @ГруппаВычета
						,_Fld2026	= @Наименование2010
						,_Fld2027	= @КодДляОтчетности2011
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("КодДляОтчетности2007", КодДляОтчетности2007);
					Команда.Parameters.AddWithValue("КодДляОтчетности2008", КодДляОтчетности2008);
					Команда.Parameters.AddWithValue("КодДляОтчетности2009", КодДляОтчетности2009);
					Команда.Parameters.AddWithValue("Наименование2007", Наименование2007);
					Команда.Parameters.AddWithValue("Наименование2008", Наименование2008);
					Команда.Parameters.AddWithValue("КодДляОтчетности2010", КодДляОтчетности2010);
					Команда.Parameters.AddWithValue("НеПредоставляетсяНерезидентам", НеПредоставляетсяНерезидентам);
					Команда.Parameters.AddWithValue("НеОтражаетсяВОтчетности2010", НеОтражаетсяВОтчетности2010);
					Команда.Parameters.AddWithValue("ГруппаВычета", ГруппаВычета.Ключ());
					Команда.Parameters.AddWithValue("Наименование2010", Наименование2010);
					Команда.Parameters.AddWithValue("КодДляОтчетности2011", КодДляОтчетности2011);
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
					Команда.CommandText = @"Delete _Reference70
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}