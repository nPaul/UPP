﻿
using System;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	///<summary>
	///Каталоги на диске для хранения файлов
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ТомаХраненияФайлов:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("b9857000-21cf-4445-bd07-3fbcb0816986");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012000.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public bool Предопределенный {get;set;}
		public string/*9*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*150*/ Наименование {get;set;}
		///<summary>
		///Описание тома
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///Максимальный размер файлов на томе, в Мб
		///</summary>
		public decimal/*(10)*/ МаксимальныйРазмер {get;set;}//Максимальный размер
		///<summary>
		///Полный путь в Linux
		///</summary>
		public string/*(0)*/ ПолныйПутьLinux {get;set;}//Полный путь linux
		///<summary>
		///Полный путь в UNC формате
		///</summary>
		public string/*(0)*/ ПолныйПутьWindows {get;set;}//Полный путь windows
		///<summary>
		///Определяет порядок заполнения томов - начинаем с наименьшего
		///</summary>
		public decimal/*(3)*/ ПорядокЗаполнения {get;set;}//Порядок заполнения
		
		public ТомаХраненияФайлов()
		{
		}
		
		public ТомаХраненияФайлов(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public ТомаХраненияФайлов(byte[] УникальныйИдентификатор,int Глубина)
		{
			if (Глубина>3)
			{
				return;
			}
			if (new Guid(УникальныйИдентификатор) == Guid.Empty)
			{
				return;
			}
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
					,_Fld23818 [Комментарий]
					,_Fld23819 [МаксимальныйРазмер]
					,_Fld23820 [ПолныйПутьLinux]
					,_Fld23821 [ПолныйПутьWindows]
					,_Fld23822 [ПорядокЗаполнения]
					From _Reference23131(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор  ";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Код = Читалка.GetString(4);
							Наименование = Читалка.GetString(5);
								Комментарий = Читалка.GetString(6);
								МаксимальныйРазмер = Читалка.GetDecimal(7);
								ПолныйПутьLinux = Читалка.GetString(8);
								ПолныйПутьWindows = Читалка.GetString(9);
								ПорядокЗаполнения = Читалка.GetDecimal(10);
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.СправочникиОбъект.ТомаХраненияФайлов  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ТомаХраненияФайлов();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.Комментарий = Комментарий;
			Объект.МаксимальныйРазмер = МаксимальныйРазмер;
			Объект.ПолныйПутьLinux = ПолныйПутьLinux;
			Объект.ПолныйПутьWindows = ПолныйПутьWindows;
			Объект.ПорядокЗаполнения = ПорядокЗаполнения;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.ТомаХраненияФайлов ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.ТомаХраненияФайлов)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.ТомаХраненияФайлов(УникальныйИдентификатор);
			Кэш.Add(УИ, Ссылка);
			return Ссылка;
		}
		
		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}