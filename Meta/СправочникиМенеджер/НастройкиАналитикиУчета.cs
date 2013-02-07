
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class НастройкиАналитикиУчета:СправочникМенеджер
	{

		public static СправочникиСсылка.НастройкиАналитикиУчета НайтиПоКоду(string Код)
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
					,_Fld2641 [УправленческийУчет]
					,_Fld2642 [РегламентированныйУчет]
					,_Fld2643_TYPE [ЗначениеПоУмолчанию_Тип],_Fld2643_RRRef [ЗначениеПоУмолчанию],_Fld2643_RTRef [ЗначениеПоУмолчанию_Вид]
					,_Fld2644 [ТолькоПросмотр]
					,_Fld2645 [ТолькоПросмотрРегл]
					From _Reference148(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиАналитикиУчета();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.УправленческийУчет = ((byte[])Читалка.GetValue(6))[0]==1?true:false;
							Ссылка.РегламентированныйУчет = ((byte[])Читалка.GetValue(7))[0]==1?true:false;
							Ссылка.ТолькоПросмотр = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.ТолькоПросмотрРегл = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
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

		public static СправочникиВыборка.НастройкиАналитикиУчета Выбрать()
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
					,_Fld2641 [УправленческийУчет]
					,_Fld2642 [РегламентированныйУчет]
					,_Fld2643_TYPE [ЗначениеПоУмолчанию_Тип],_Fld2643_RRRef [ЗначениеПоУмолчанию],_Fld2643_RTRef [ЗначениеПоУмолчанию_Вид]
					,_Fld2644 [ТолькоПросмотр]
					,_Fld2645 [ТолькоПросмотрРегл]
							From _Reference148(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиАналитикиУчета();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиАналитикиУчета();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.УправленческийУчет = ((byte[])Читалка.GetValue(6))[0]==1?true:false;
							Ссылка.РегламентированныйУчет = ((byte[])Читалка.GetValue(7))[0]==1?true:false;
							Ссылка.ТолькоПросмотр = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.ТолькоПросмотрРегл = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.НастройкиАналитикиУчета СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиАналитикиУчета();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			return Объект;
		}
	}
}