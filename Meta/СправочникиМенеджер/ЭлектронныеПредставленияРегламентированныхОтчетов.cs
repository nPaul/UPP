
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class ЭлектронныеПредставленияРегламентированныхОтчетов:СправочникМенеджер
	{

		public static СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов НайтиПоКоду(string Код)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4337RRef [Организация]
					,_Fld4338_TYPE [Получатель_Тип],_Fld4338_RRRef [Получатель],_Fld4338_RTRef [Получатель_Вид]
					,_Fld4339_TYPE [ВидОтчета_Тип],_Fld4339_RRRef [ВидОтчета],_Fld4339_RTRef [ВидОтчета_Вид]
					,_Fld4340 [ДатаНачала]
					,_Fld4341 [ДатаОкончания]
					,_Fld4343 [Комментарий]
					,_Fld4344RRef [Периодичность]
					,_Fld4345 [ДатаИмпорта]
					,_Fld4346RRef [ТипПолучателя]
					From _Reference295(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(6));
							Ссылка.ДатаНачала = Читалка.GetDateTime(13);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(14);
							Ссылка.Комментарий = Читалка.GetString(15);
							Ссылка.Периодичность = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
							Ссылка.ДатаИмпорта = Читалка.GetDateTime(17);
							Ссылка.ТипПолучателя = V82.Перечисления/*Ссылка*/.ТипыКонтролирующихОрганов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}

		public static СправочникиВыборка.ЭлектронныеПредставленияРегламентированныхОтчетов Выбрать()
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4337RRef [Организация]
					,_Fld4338_TYPE [Получатель_Тип],_Fld4338_RRRef [Получатель],_Fld4338_RTRef [Получатель_Вид]
					,_Fld4339_TYPE [ВидОтчета_Тип],_Fld4339_RRRef [ВидОтчета],_Fld4339_RTRef [ВидОтчета_Вид]
					,_Fld4340 [ДатаНачала]
					,_Fld4341 [ДатаОкончания]
					,_Fld4343 [Комментарий]
					,_Fld4344RRef [Периодичность]
					,_Fld4345 [ДатаИмпорта]
					,_Fld4346RRef [ТипПолучателя]
							From _Reference295(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЭлектронныеПредставленияРегламентированныхОтчетов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(6));
							Ссылка.ДатаНачала = Читалка.GetDateTime(13);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(14);
							Ссылка.Комментарий = Читалка.GetString(15);
							Ссылка.Периодичность = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
							Ссылка.ДатаИмпорта = Читалка.GetDateTime(17);
							Ссылка.ТипПолучателя = V82.Перечисления/*Ссылка*/.ТипыКонтролирующихОрганов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(18));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ЭлектронныеПредставленияРегламентированныхОтчетов СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ЭлектронныеПредставленияРегламентированныхОтчетов();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Комментарий = "";
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.Периодичность = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			Объект.ТипПолучателя = V82.Перечисления/*Ссылка*/.ТипыКонтролирующихОрганов.ПустаяСсылка;
			return Объект;
		}
	}
}