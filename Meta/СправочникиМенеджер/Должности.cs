
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	///<summary>
	///(Упр)
	///</summary>
	public partial class Должности:СправочникМенеджер
	{

		public static СправочникиСсылка.Должности НайтиПоКоду(string Код)
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
					,_Fld2270 [Требования]
					,_Fld2271 [Обязанности]
					,_Fld2272 [Условия]
					,_Fld2273 [УдалитьНазваниеВакансииВСМИ]
					,_Fld2274RRef [АнкетаРезюмеКандидата]
					From _Reference91(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Должности();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Требования = Читалка.GetString(6);
							Ссылка.Обязанности = Читалка.GetString(7);
							Ссылка.Условия = Читалка.GetString(8);
							Ссылка.УдалитьНазваниеВакансииВСМИ = Читалка.GetString(9);
							//Ссылка.АнкетаРезюмеКандидата = new V82.СправочникиСсылка.ТиповыеАнкеты((byte[])Читалка.GetValue(10));
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

		public static СправочникиВыборка.Должности Выбрать()
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
					,_Fld2270 [Требования]
					,_Fld2271 [Обязанности]
					,_Fld2272 [Условия]
					,_Fld2273 [УдалитьНазваниеВакансииВСМИ]
					,_Fld2274RRef [АнкетаРезюмеКандидата]
							From _Reference91(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Должности();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Должности();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Требования = Читалка.GetString(6);
							Ссылка.Обязанности = Читалка.GetString(7);
							Ссылка.Условия = Читалка.GetString(8);
							Ссылка.УдалитьНазваниеВакансииВСМИ = Читалка.GetString(9);
							//Ссылка.АнкетаРезюмеКандидата = new V82.СправочникиСсылка.ТиповыеАнкеты((byte[])Читалка.GetValue(10));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.Должности СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.Должности();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Требования = "";
			Объект.Обязанности = "";
			Объект.Условия = "";
			Объект.УдалитьНазваниеВакансииВСМИ = "";
			Объект.АнкетаРезюмеКандидата = new V82.СправочникиСсылка.ТиповыеАнкеты();
			return Объект;
		}
	}
}