﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class НастройкиРасчетаСебестоимости:СправочникМенеджер
	{
		
		public static СправочникиВыборка.НастройкиРасчетаСебестоимости Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Description [Наименование]
					,_Fld2824RRef [Организация]
					,_Fld2825RRef [НастройкаЗакрытияМесяца]
					,_Fld2826RRef [ВидОтраженияВУчете]
					,_Fld2827 [ФормироватьДокументыАвтоматически]
					,_Fld2828 [РегламентноеЗадание]
					,_Fld2829 [Задержка]
					,_Fld2830 [Комментарий]
							From _Reference155(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиРасчетаСебестоимости();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиРасчетаСебестоимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(5));
							//Ссылка.НастройкаЗакрытияМесяца = new V82.СправочникиСсылка.НастройкиЗакрытияМесяца((byte[])Читалка.GetValue(6));
							Ссылка.ВидОтраженияВУчете = V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.РегламентноеЗадание = Читалка.GetString(9);
							Ссылка.Задержка = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиРасчетаСебестоимости ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Description [Наименование]
					,_Fld2824RRef [Организация]
					,_Fld2825RRef [НастройкаЗакрытияМесяца]
					,_Fld2826RRef [ВидОтраженияВУчете]
					,_Fld2827 [ФормироватьДокументыАвтоматически]
					,_Fld2828 [РегламентноеЗадание]
					,_Fld2829 [Задержка]
					,_Fld2830 [Комментарий]
							From _Reference155(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиРасчетаСебестоимости();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиРасчетаСебестоимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(5));
							//Ссылка.НастройкаЗакрытияМесяца = new V82.СправочникиСсылка.НастройкиЗакрытияМесяца((byte[])Читалка.GetValue(6));
							Ссылка.ВидОтраженияВУчете = V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.РегламентноеЗадание = Читалка.GetString(9);
							Ссылка.Задержка = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиРасчетаСебестоимости ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Description [Наименование]
					,_Fld2824RRef [Организация]
					,_Fld2825RRef [НастройкаЗакрытияМесяца]
					,_Fld2826RRef [ВидОтраженияВУчете]
					,_Fld2827 [ФормироватьДокументыАвтоматически]
					,_Fld2828 [РегламентноеЗадание]
					,_Fld2829 [Задержка]
					,_Fld2830 [Комментарий]
							From _Reference155(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиРасчетаСебестоимости();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиРасчетаСебестоимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(5));
							//Ссылка.НастройкаЗакрытияМесяца = new V82.СправочникиСсылка.НастройкиЗакрытияМесяца((byte[])Читалка.GetValue(6));
							Ссылка.ВидОтраженияВУчете = V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.РегламентноеЗадание = Читалка.GetString(9);
							Ссылка.Задержка = Читалка.GetDecimal(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НастройкиРасчетаСебестоимости СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиРасчетаСебестоимости();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.РегламентноеЗадание = "";
			Объект.Комментарий = "";
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.НастройкаЗакрытияМесяца = new V82.СправочникиСсылка.НастройкиЗакрытияМесяца();
			Объект.ВидОтраженияВУчете = V82.Перечисления/*Ссылка*/.ВидыОтраженияВУчете.ПустаяСсылка;
			return Объект;
		}
	}
}