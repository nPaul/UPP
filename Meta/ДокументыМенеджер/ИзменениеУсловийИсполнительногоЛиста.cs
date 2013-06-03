﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.ДокументыСсылка;
using V82.Документы;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Документы//Менеджер
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class ИзменениеУсловийИсполнительногоЛиста:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ИзменениеУсловийИсполнительногоЛиста НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld8051RRef [Физлицо]
					,_Fld8052RRef [Организация]
					,_Fld8053RRef [ИсполнительныйЛист]
					,_Fld8054RRef [Действие]
					,_Fld8055 [ДатаИзменения]
					,_Fld8056 [ДатаОкончания]
					,_Fld8057RRef [СпособРасчетаУдержания]
					,_Fld8058 [Размер]
					,_Fld8059 [Предел]
					,_Fld8060RRef [ПрожиточныйМинимум]
					,_Fld8061 [ПроцентПочтовогоСбора]
					,_Fld8062RRef [Тариф]
					,_Fld8063RRef [СпособПеречисленияПоИсполнительномуЛисту]
					,_Fld8064RRef [ТарифБанкаНаДенежныеПереводы]
					,_Fld8065 [ПочтовыйСборРассчитыватьПроцентом]
					,_Fld8066RRef [Ответственный]
					,_Fld8067 [Комментарий]
					From _Document400(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийИсполнительногоЛиста();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ИсполнительныйЛист = V82.ДокументыСсылка.ИсполнительныйЛист.ВзятьИзКэша((byte[])Читалка.GetValue(5));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ДатаИзменения = Читалка.GetDateTime(7);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(8);
							Ссылка.СпособРасчетаУдержания = V82.Перечисления/*Ссылка*/.СпособыРасчетаУдержанийПоИЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.Размер = Читалка.GetDecimal(10);
							Ссылка.Предел = Читалка.GetDecimal(11);
							Ссылка.ПроцентПочтовогоСбора = Читалка.GetDecimal(13);
							Ссылка.СпособПеречисленияПоИсполнительномуЛисту = V82.Перечисления/*Ссылка*/.СпособыПеречисленийПоИсполнительномуЛисту.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ПочтовыйСборРассчитыватьПроцентом = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(19);
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
		
		public static ДокументыСсылка.ИзменениеУсловийИсполнительногоЛиста НайтиПоНомеру(string Номер)
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
					,_Fld8051RRef [Физлицо]
					,_Fld8052RRef [Организация]
					,_Fld8053RRef [ИсполнительныйЛист]
					,_Fld8054RRef [Действие]
					,_Fld8055 [ДатаИзменения]
					,_Fld8056 [ДатаОкончания]
					,_Fld8057RRef [СпособРасчетаУдержания]
					,_Fld8058 [Размер]
					,_Fld8059 [Предел]
					,_Fld8060RRef [ПрожиточныйМинимум]
					,_Fld8061 [ПроцентПочтовогоСбора]
					,_Fld8062RRef [Тариф]
					,_Fld8063RRef [СпособПеречисленияПоИсполнительномуЛисту]
					,_Fld8064RRef [ТарифБанкаНаДенежныеПереводы]
					,_Fld8065 [ПочтовыйСборРассчитыватьПроцентом]
					,_Fld8066RRef [Ответственный]
					,_Fld8067 [Комментарий]
					From _Document400(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийИсполнительногоЛиста();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ИсполнительныйЛист = V82.ДокументыСсылка.ИсполнительныйЛист.ВзятьИзКэша((byte[])Читалка.GetValue(5));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ДатаИзменения = Читалка.GetDateTime(7);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(8);
							Ссылка.СпособРасчетаУдержания = V82.Перечисления/*Ссылка*/.СпособыРасчетаУдержанийПоИЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.Размер = Читалка.GetDecimal(10);
							Ссылка.Предел = Читалка.GetDecimal(11);
							Ссылка.ПроцентПочтовогоСбора = Читалка.GetDecimal(13);
							Ссылка.СпособПеречисленияПоИсполнительномуЛисту = V82.Перечисления/*Ссылка*/.СпособыПеречисленийПоИсполнительномуЛисту.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ПочтовыйСборРассчитыватьПроцентом = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(19);
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
		
		public static ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста Выбрать()
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
					,_Fld8051RRef [Физлицо]
					,_Fld8052RRef [Организация]
					,_Fld8053RRef [ИсполнительныйЛист]
					,_Fld8054RRef [Действие]
					,_Fld8055 [ДатаИзменения]
					,_Fld8056 [ДатаОкончания]
					,_Fld8057RRef [СпособРасчетаУдержания]
					,_Fld8058 [Размер]
					,_Fld8059 [Предел]
					,_Fld8060RRef [ПрожиточныйМинимум]
					,_Fld8061 [ПроцентПочтовогоСбора]
					,_Fld8062RRef [Тариф]
					,_Fld8063RRef [СпособПеречисленияПоИсполнительномуЛисту]
					,_Fld8064RRef [ТарифБанкаНаДенежныеПереводы]
					,_Fld8065 [ПочтовыйСборРассчитыватьПроцентом]
					,_Fld8066RRef [Ответственный]
					,_Fld8067 [Комментарий]
					From _Document400(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийИсполнительногоЛиста();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ИсполнительныйЛист = V82.ДокументыСсылка.ИсполнительныйЛист.ВзятьИзКэша((byte[])Читалка.GetValue(5));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ДатаИзменения = Читалка.GetDateTime(7);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(8);
							Ссылка.СпособРасчетаУдержания = V82.Перечисления/*Ссылка*/.СпособыРасчетаУдержанийПоИЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.Размер = Читалка.GetDecimal(10);
							Ссылка.Предел = Читалка.GetDecimal(11);
							Ссылка.ПроцентПочтовогоСбора = Читалка.GetDecimal(13);
							Ссылка.СпособПеречисленияПоИсполнительномуЛисту = V82.Перечисления/*Ссылка*/.СпособыПеречисленийПоИсполнительномуЛисту.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ПочтовыйСборРассчитыватьПроцентом = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld8051RRef [Физлицо]
					,_Fld8052RRef [Организация]
					,_Fld8053RRef [ИсполнительныйЛист]
					,_Fld8054RRef [Действие]
					,_Fld8055 [ДатаИзменения]
					,_Fld8056 [ДатаОкончания]
					,_Fld8057RRef [СпособРасчетаУдержания]
					,_Fld8058 [Размер]
					,_Fld8059 [Предел]
					,_Fld8060RRef [ПрожиточныйМинимум]
					,_Fld8061 [ПроцентПочтовогоСбора]
					,_Fld8062RRef [Тариф]
					,_Fld8063RRef [СпособПеречисленияПоИсполнительномуЛисту]
					,_Fld8064RRef [ТарифБанкаНаДенежныеПереводы]
					,_Fld8065 [ПочтовыйСборРассчитыватьПроцентом]
					,_Fld8066RRef [Ответственный]
					,_Fld8067 [Комментарий]
					From _Document400(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийИсполнительногоЛиста();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ИсполнительныйЛист = V82.ДокументыСсылка.ИсполнительныйЛист.ВзятьИзКэша((byte[])Читалка.GetValue(5));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ДатаИзменения = Читалка.GetDateTime(7);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(8);
							Ссылка.СпособРасчетаУдержания = V82.Перечисления/*Ссылка*/.СпособыРасчетаУдержанийПоИЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.Размер = Читалка.GetDecimal(10);
							Ссылка.Предел = Читалка.GetDecimal(11);
							Ссылка.ПроцентПочтовогоСбора = Читалка.GetDecimal(13);
							Ссылка.СпособПеречисленияПоИсполнительномуЛисту = V82.Перечисления/*Ссылка*/.СпособыПеречисленийПоИсполнительномуЛисту.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ПочтовыйСборРассчитыватьПроцентом = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста ВыбратьПоНомеру(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld8051RRef [Физлицо]
					,_Fld8052RRef [Организация]
					,_Fld8053RRef [ИсполнительныйЛист]
					,_Fld8054RRef [Действие]
					,_Fld8055 [ДатаИзменения]
					,_Fld8056 [ДатаОкончания]
					,_Fld8057RRef [СпособРасчетаУдержания]
					,_Fld8058 [Размер]
					,_Fld8059 [Предел]
					,_Fld8060RRef [ПрожиточныйМинимум]
					,_Fld8061 [ПроцентПочтовогоСбора]
					,_Fld8062RRef [Тариф]
					,_Fld8063RRef [СпособПеречисленияПоИсполнительномуЛисту]
					,_Fld8064RRef [ТарифБанкаНаДенежныеПереводы]
					,_Fld8065 [ПочтовыйСборРассчитыватьПроцентом]
					,_Fld8066RRef [Ответственный]
					,_Fld8067 [Комментарий]
					From _Document400(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийИсполнительногоЛиста();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ИсполнительныйЛист = V82.ДокументыСсылка.ИсполнительныйЛист.ВзятьИзКэша((byte[])Читалка.GetValue(5));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ДатаИзменения = Читалка.GetDateTime(7);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(8);
							Ссылка.СпособРасчетаУдержания = V82.Перечисления/*Ссылка*/.СпособыРасчетаУдержанийПоИЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.Размер = Читалка.GetDecimal(10);
							Ссылка.Предел = Читалка.GetDecimal(11);
							Ссылка.ПроцентПочтовогоСбора = Читалка.GetDecimal(13);
							Ссылка.СпособПеречисленияПоИсполнительномуЛисту = V82.Перечисления/*Ссылка*/.СпособыПеречисленийПоИсполнительномуЛисту.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ПочтовыйСборРассчитыватьПроцентом = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld8051RRef [Физлицо]
					,_Fld8052RRef [Организация]
					,_Fld8053RRef [ИсполнительныйЛист]
					,_Fld8054RRef [Действие]
					,_Fld8055 [ДатаИзменения]
					,_Fld8056 [ДатаОкончания]
					,_Fld8057RRef [СпособРасчетаУдержания]
					,_Fld8058 [Размер]
					,_Fld8059 [Предел]
					,_Fld8060RRef [ПрожиточныйМинимум]
					,_Fld8061 [ПроцентПочтовогоСбора]
					,_Fld8062RRef [Тариф]
					,_Fld8063RRef [СпособПеречисленияПоИсполнительномуЛисту]
					,_Fld8064RRef [ТарифБанкаНаДенежныеПереводы]
					,_Fld8065 [ПочтовыйСборРассчитыватьПроцентом]
					,_Fld8066RRef [Ответственный]
					,_Fld8067 [Комментарий]
					From _Document400(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийИсполнительногоЛиста();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ИсполнительныйЛист = V82.ДокументыСсылка.ИсполнительныйЛист.ВзятьИзКэша((byte[])Читалка.GetValue(5));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ДатаИзменения = Читалка.GetDateTime(7);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(8);
							Ссылка.СпособРасчетаУдержания = V82.Перечисления/*Ссылка*/.СпособыРасчетаУдержанийПоИЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.Размер = Читалка.GetDecimal(10);
							Ссылка.Предел = Читалка.GetDecimal(11);
							Ссылка.ПроцентПочтовогоСбора = Читалка.GetDecimal(13);
							Ссылка.СпособПеречисленияПоИсполнительномуЛисту = V82.Перечисления/*Ссылка*/.СпособыПеречисленийПоИсполнительномуЛисту.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ПочтовыйСборРассчитыватьПроцентом = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld8051RRef [Физлицо]
					,_Fld8052RRef [Организация]
					,_Fld8053RRef [ИсполнительныйЛист]
					,_Fld8054RRef [Действие]
					,_Fld8055 [ДатаИзменения]
					,_Fld8056 [ДатаОкончания]
					,_Fld8057RRef [СпособРасчетаУдержания]
					,_Fld8058 [Размер]
					,_Fld8059 [Предел]
					,_Fld8060RRef [ПрожиточныйМинимум]
					,_Fld8061 [ПроцентПочтовогоСбора]
					,_Fld8062RRef [Тариф]
					,_Fld8063RRef [СпособПеречисленияПоИсполнительномуЛисту]
					,_Fld8064RRef [ТарифБанкаНаДенежныеПереводы]
					,_Fld8065 [ПочтовыйСборРассчитыватьПроцентом]
					,_Fld8066RRef [Ответственный]
					,_Fld8067 [Комментарий]
					From _Document400(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ИзменениеУсловийИсполнительногоЛиста();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ИзменениеУсловийИсполнительногоЛиста();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ИсполнительныйЛист = V82.ДокументыСсылка.ИсполнительныйЛист.ВзятьИзКэша((byte[])Читалка.GetValue(5));
							Ссылка.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ДатаИзменения = Читалка.GetDateTime(7);
							Ссылка.ДатаОкончания = Читалка.GetDateTime(8);
							Ссылка.СпособРасчетаУдержания = V82.Перечисления/*Ссылка*/.СпособыРасчетаУдержанийПоИЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.Размер = Читалка.GetDecimal(10);
							Ссылка.Предел = Читалка.GetDecimal(11);
							Ссылка.ПроцентПочтовогоСбора = Читалка.GetDecimal(13);
							Ссылка.СпособПеречисленияПоИсполнительномуЛисту = V82.Перечисления/*Ссылка*/.СпособыПеречисленийПоИсполнительномуЛисту.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							Ссылка.ПочтовыйСборРассчитыватьПроцентом = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ИзменениеУсловийИсполнительногоЛиста СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ИзменениеУсловийИсполнительногоЛиста();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ИсполнительныйЛист = new V82.ДокументыСсылка.ИсполнительныйЛист();
			Объект.Действие = V82.Перечисления/*Ссылка*/.ВидыДействияСНачислением.ПустаяСсылка;
			Объект.СпособРасчетаУдержания = V82.Перечисления/*Ссылка*/.СпособыРасчетаУдержанийПоИЛ.ПустаяСсылка;
			Объект.СпособПеречисленияПоИсполнительномуЛисту = V82.Перечисления/*Ссылка*/.СпособыПеречисленийПоИсполнительномуЛисту.ПустаяСсылка;
			return Объект;
		}
	}
}