
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
	///(Общ)
	///</summary>
	public partial class БанковскиеСчета:СправочникМенеджер
	{

		public static СправочникиСсылка.БанковскиеСчета НайтиПоКоду(string Код)
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
					,_Fld1854 [НомерСчета]
					,_Fld1855RRef [Банк]
					,_Fld1856RRef [БанкДляРасчетов]
					,_Fld1857 [ТекстКорреспондента]
					,_Fld1858 [ТекстНазначения]
					,_Fld1859 [ВидСчета]
					,_Fld1860RRef [ВалютаДенежныхСредств]
					,_Fld1861 [НомерИДатаРазрешения]
					,_Fld1862 [ДатаОткрытия]
					,_Fld1863 [ДатаЗакрытия]
					,_Fld1864 [МесяцПрописью]
					,_Fld1865 [СуммаБезКопеек]
					From _Reference36(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.БанковскиеСчета();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НомерСчета = Читалка.GetString(6);
							//Ссылка.Банк = new V82.СправочникиСсылка.Банки((byte[])Читалка.GetValue(7));
							//Ссылка.БанкДляРасчетов = new V82.СправочникиСсылка.Банки((byte[])Читалка.GetValue(8));
							Ссылка.ТекстКорреспондента = Читалка.GetString(9);
							Ссылка.ТекстНазначения = Читалка.GetString(10);
							Ссылка.ВидСчета = Читалка.GetString(11);
							//Ссылка.ВалютаДенежныхСредств = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(12));
							Ссылка.НомерИДатаРазрешения = Читалка.GetString(13);
							Ссылка.ДатаОткрытия = Читалка.GetDateTime(14);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(15);
							Ссылка.МесяцПрописью = ((byte[])Читалка.GetValue(16))[0]==1?true:false;
							Ссылка.СуммаБезКопеек = ((byte[])Читалка.GetValue(17))[0]==1?true:false;
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

		public static СправочникиВыборка.БанковскиеСчета Выбрать()
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
					,_Fld1854 [НомерСчета]
					,_Fld1855RRef [Банк]
					,_Fld1856RRef [БанкДляРасчетов]
					,_Fld1857 [ТекстКорреспондента]
					,_Fld1858 [ТекстНазначения]
					,_Fld1859 [ВидСчета]
					,_Fld1860RRef [ВалютаДенежныхСредств]
					,_Fld1861 [НомерИДатаРазрешения]
					,_Fld1862 [ДатаОткрытия]
					,_Fld1863 [ДатаЗакрытия]
					,_Fld1864 [МесяцПрописью]
					,_Fld1865 [СуммаБезКопеек]
							From _Reference36(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.БанковскиеСчета();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.БанковскиеСчета();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НомерСчета = Читалка.GetString(6);
							//Ссылка.Банк = new V82.СправочникиСсылка.Банки((byte[])Читалка.GetValue(7));
							//Ссылка.БанкДляРасчетов = new V82.СправочникиСсылка.Банки((byte[])Читалка.GetValue(8));
							Ссылка.ТекстКорреспондента = Читалка.GetString(9);
							Ссылка.ТекстНазначения = Читалка.GetString(10);
							Ссылка.ВидСчета = Читалка.GetString(11);
							//Ссылка.ВалютаДенежныхСредств = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(12));
							Ссылка.НомерИДатаРазрешения = Читалка.GetString(13);
							Ссылка.ДатаОткрытия = Читалка.GetDateTime(14);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(15);
							Ссылка.МесяцПрописью = ((byte[])Читалка.GetValue(16))[0]==1?true:false;
							Ссылка.СуммаБезКопеек = ((byte[])Читалка.GetValue(17))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.БанковскиеСчета СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.БанковскиеСчета();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.НомерСчета = "";
			Объект.ТекстКорреспондента = "";
			Объект.ТекстНазначения = "";
			Объект.ВидСчета = "";
			Объект.НомерИДатаРазрешения = "";
			Объект.Банк = new V82.СправочникиСсылка.Банки();
			Объект.БанкДляРасчетов = new V82.СправочникиСсылка.Банки();
			Объект.ВалютаДенежныхСредств = new V82.СправочникиСсылка.Валюты();
			return Объект;
		}
	}
}