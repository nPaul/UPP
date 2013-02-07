
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
	public partial class ГрафикиРаботы:СправочникМенеджер
	{


		public static СправочникиВыборка.ГрафикиРаботы Выбрать()
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
					,_Fld2043RRef [ВидГрафика]
					,_Fld2044 [СуммированныйУчетРабочегоВремени]
					,_Fld2045RRef [ПервыйВыходной]
					,_Fld2046RRef [ВторойВыходной]
					,_Fld2047 [ДатаОтсчета]
					,_Fld2048 [ДлительностьРабочейНедели]
					,_Fld2049 [СокращенноеРабочееВремя]
					,_Fld2050RRef [ГрафикПолногоРабочегоВремени]
					,_Fld2051 [НачалоДневныхЧасов]
					,_Fld2052 [НачалоВечернихЧасов]
					,_Fld2053 [НачалоНочныхЧасов]
					,_Fld2054 [СокращеннаяРабочаяНеделя]
					,_Fld2055 [НеполныйРабочийДень]
					,_Fld2056 [УчитыватьПраздники]
					,_Fld2057 [УчитыватьВечерниеЧасы]
					,_Fld2058 [УчитыватьНочныеЧасы]
					,_Fld2059RRef [ШаблонЗаполнения]
					,_Fld2060 [УдалитьВыходныеПоСкользящемуГрафику]
							From _Reference72(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ГрафикиРаботы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ГрафикиРаботы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ВидГрафика = V82.Перечисления/*Ссылка*/.ВидыРабочихГрафиков.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.СуммированныйУчетРабочегоВремени = ((byte[])Читалка.GetValue(6))[0]==1?true:false;
							Ссылка.ПервыйВыходной = V82.Перечисления/*Ссылка*/.ДниНедели.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.ВторойВыходной = V82.Перечисления/*Ссылка*/.ДниНедели.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ДатаОтсчета = Читалка.GetDateTime(9);
							Ссылка.ДлительностьРабочейНедели = Читалка.GetDecimal(10);
							Ссылка.СокращенноеРабочееВремя = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							//Ссылка.ГрафикПолногоРабочегоВремени = new V82.СправочникиСсылка.ГрафикиРаботы((byte[])Читалка.GetValue(12));
							Ссылка.НачалоДневныхЧасов = Читалка.GetDateTime(13);
							Ссылка.НачалоВечернихЧасов = Читалка.GetDateTime(14);
							Ссылка.НачалоНочныхЧасов = Читалка.GetDateTime(15);
							Ссылка.СокращеннаяРабочаяНеделя = ((byte[])Читалка.GetValue(16))[0]==1?true:false;
							Ссылка.НеполныйРабочийДень = ((byte[])Читалка.GetValue(17))[0]==1?true:false;
							Ссылка.УчитыватьПраздники = ((byte[])Читалка.GetValue(18))[0]==1?true:false;
							Ссылка.УчитыватьВечерниеЧасы = ((byte[])Читалка.GetValue(19))[0]==1?true:false;
							Ссылка.УчитыватьНочныеЧасы = ((byte[])Читалка.GetValue(20))[0]==1?true:false;
							Ссылка.ШаблонЗаполнения = V82.Перечисления/*Ссылка*/.ШаблонЗаполненияГрафикаРаботы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							Ссылка.УдалитьВыходныеПоСкользящемуГрафику = ((byte[])Читалка.GetValue(22))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ГрафикиРаботы СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ГрафикиРаботы();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.ВидГрафика = V82.Перечисления/*Ссылка*/.ВидыРабочихГрафиков.ПустаяСсылка;
			Объект.ПервыйВыходной = V82.Перечисления/*Ссылка*/.ДниНедели.ПустаяСсылка;
			Объект.ВторойВыходной = V82.Перечисления/*Ссылка*/.ДниНедели.ПустаяСсылка;
			Объект.ГрафикПолногоРабочегоВремени = new V82.СправочникиСсылка.ГрафикиРаботы();
			Объект.ШаблонЗаполнения = V82.Перечисления/*Ссылка*/.ШаблонЗаполненияГрафикаРаботы.ПустаяСсылка;
			return Объект;
		}
	}
}