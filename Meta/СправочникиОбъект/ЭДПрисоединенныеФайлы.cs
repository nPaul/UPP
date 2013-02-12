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
	public partial class ЭДПрисоединенныеФайлы:СправочникОбъект
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
		public string/*150*/ Наименование;
		///<summary>
		///Автор - пользователь, добавивший файл
		///</summary>
		public V82.СправочникиСсылка.Пользователи Автор;
		public V82.Перечисления/*Ссылка*/.ВидыЭД ВидЭД;//Вид ЭД
		public object ВладелецФайла;//Владелец файла
		public DateTime ДатаДокументаОтправителя;//Дата документа отправителя
		public DateTime ДатаИзмененияСтатусаЭД;//Дата изменения статуса ЭД
		public DateTime ДатаМодификацииУниверсальная;//Дата модификации универсальная
		///<summary>
		///Дата добавления файла в базу
		///</summary>
		public DateTime ДатаСоздания;//Дата создания
		public DateTime ДатаФормированияЭДОтправителем;//Дата формирования ЭД отправителем
		public bool Загружен;
		public bool Зашифрован;
		///<summary>
		///Пользователь, изменивший файл
		///</summary>
		public V82.СправочникиСсылка.Пользователи Изменил;
		///<summary>
		///Индекс иконки, соответствующей расширению файла, для показа в списке
		///</summary>
		public decimal/*(10)*/ ИндексКартинки;//Индекс картинки
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		public V82.Перечисления/*Ссылка*/.НаправленияЭД НаправлениеЭД;//Направление ЭД
		public decimal/*(3)*/ НомерВерсииЭД;//Номер версии ЭД
		public string/*(30)*/ НомерДокументаОтправителя;//Номер документа отправителя
		public string/*(150)*/ НомерЭД;//Номер ЭД
		///<summary>
		///Описание файла
		///</summary>
		public string/*(0)*/ Описание;
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(50)*/ ОтправительЭД;//Отправитель ЭД
		public bool ПодписанЭЦП;//Подписан ЭЦП
		public string/*(50)*/ ПолучательЭД;//Получатель ЭД
		public string/*(0)*/ ПричинаОтклонения;//Причина отклонения
		///<summary>
		///Дополнительный путь к файлу на диске (в случае, если "Тип хранения файла" - на диске)
		///</summary>
		public string/*(0)*/ ПутьКФайлу;//Путь к файлу
		///<summary>
		///Размер файла
		///</summary>
		public decimal/*(10)*/ Размер;
		///<summary>
		///Расширение файла версии
		///</summary>
		public string/*(10)*/ Расширение;
		///<summary>
		///Пользователь, занявший файл для редактирования
		///</summary>
		public V82.СправочникиСсылка.Пользователи Редактирует;
		public V82.СправочникиСсылка.СоглашенияОбИспользованииЭД СоглашениеЭД;//Соглашение ЭД
		///<summary>
		///Статус извлечения текста - для фонового задания извлечения текста
		///</summary>
		public V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов СтатусИзвлеченияТекста;//Статус извлечения текста
		public V82.Перечисления/*Ссылка*/.СтатусыЭД СтатусЭД;//Статус ЭД
		///<summary>
		///Текст, извлеченный из файла - для полнотекстового поиска
		///</summary>
		public ХранилищеЗначения ТекстХранилище;//Текст
		///<summary>
		///Где хранятся файлы - в базе как ХранилищеЗначения или в каталоге на диске
		///</summary>
		public V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов ТипХраненияФайла;//Тип хранения файла
		public V82.Перечисления/*Ссылка*/.ТипыЭлементовВерсииЭД ТипЭлементаВерсииЭД;//Тип элемента версии ЭД
		///<summary>
		///Ссылка на том (в случае, если "Тип хранения файла" - на диске)
		///</summary>
		public V82.СправочникиСсылка.ТомаХраненияФайлов Том;
		public string/*(36)*/ УникальныйИД;//Уникальный ИД
		///<summary>
		///Служебное поле для обмена файлами в РИБ
		///</summary>
		public ХранилищеЗначения ФайлХранилище;//Файл хранилище
		public V82.СправочникиСсылка.ЭДПрисоединенныеФайлы ЭлектронныйДокументВладелец;//Электронный документ владелец
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
						Insert Into _Reference294(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Description
						,_Fld4272RRef
						,_Fld4273RRef
						,_Fld4275
						,_Fld4276
						,_Fld4277
						,_Fld4278
						,_Fld4279
						,_Fld4280
						,_Fld4281
						,_Fld4282RRef
						,_Fld4283
						,_Fld4284RRef
						,_Fld4285RRef
						,_Fld4286
						,_Fld4287
						,_Fld4288
						,_Fld4289
						,_Fld4290RRef
						,_Fld4291RRef
						,_Fld4292
						,_Fld4293
						,_Fld4294
						,_Fld4295
						,_Fld4296
						,_Fld4297
						,_Fld4298
						,_Fld4299RRef
						,_Fld4300RRef
						,_Fld4301RRef
						,_Fld4302RRef
						,_Fld4303
						,_Fld4304RRef
						,_Fld4305RRef
						,_Fld4306RRef
						,_Fld4307
						,_Fld4308
						,_Fld4309RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Наименование
						,@Автор
						,@ВидЭД
						,@ДатаДокументаОтправителя
						,@ДатаИзмененияСтатусаЭД
						,@ДатаМодификацииУниверсальная
						,@ДатаСоздания
						,@ДатаФормированияЭДОтправителем
						,@Загружен
						,@Зашифрован
						,@Изменил
						,@ИндексКартинки
						,@Контрагент
						,@НаправлениеЭД
						,@НомерВерсииЭД
						,@НомерДокументаОтправителя
						,@НомерЭД
						,@Описание
						,@Организация
						,@Ответственный
						,@ОтправительЭД
						,@ПодписанЭЦП
						,@ПолучательЭД
						,@ПричинаОтклонения
						,@ПутьКФайлу
						,@Размер
						,@Расширение
						,@Редактирует
						,@СоглашениеЭД
						,@СтатусИзвлеченияТекста
						,@СтатусЭД
						,@ТекстХранилище
						,@ТипХраненияФайла
						,@ТипЭлементаВерсииЭД
						,@Том
						,@УникальныйИД
						,@ФайлХранилище
						,@ЭлектронныйДокументВладелец)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference294
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Description	= @Наименование
						,_Fld4272RRef	= @Автор
						,_Fld4273RRef	= @ВидЭД
						,_Fld4275	= @ДатаДокументаОтправителя
						,_Fld4276	= @ДатаИзмененияСтатусаЭД
						,_Fld4277	= @ДатаМодификацииУниверсальная
						,_Fld4278	= @ДатаСоздания
						,_Fld4279	= @ДатаФормированияЭДОтправителем
						,_Fld4280	= @Загружен
						,_Fld4281	= @Зашифрован
						,_Fld4282RRef	= @Изменил
						,_Fld4283	= @ИндексКартинки
						,_Fld4284RRef	= @Контрагент
						,_Fld4285RRef	= @НаправлениеЭД
						,_Fld4286	= @НомерВерсииЭД
						,_Fld4287	= @НомерДокументаОтправителя
						,_Fld4288	= @НомерЭД
						,_Fld4289	= @Описание
						,_Fld4290RRef	= @Организация
						,_Fld4291RRef	= @Ответственный
						,_Fld4292	= @ОтправительЭД
						,_Fld4293	= @ПодписанЭЦП
						,_Fld4294	= @ПолучательЭД
						,_Fld4295	= @ПричинаОтклонения
						,_Fld4296	= @ПутьКФайлу
						,_Fld4297	= @Размер
						,_Fld4298	= @Расширение
						,_Fld4299RRef	= @Редактирует
						,_Fld4300RRef	= @СоглашениеЭД
						,_Fld4301RRef	= @СтатусИзвлеченияТекста
						,_Fld4302RRef	= @СтатусЭД
						,_Fld4303	= @ТекстХранилище
						,_Fld4304RRef	= @ТипХраненияФайла
						,_Fld4305RRef	= @ТипЭлементаВерсииЭД
						,_Fld4306RRef	= @Том
						,_Fld4307	= @УникальныйИД
						,_Fld4308	= @ФайлХранилище
						,_Fld4309RRef	= @ЭлектронныйДокументВладелец
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Автор", Автор.Ссылка);
					Команда.Parameters.AddWithValue("ВидЭД", ВидЭД.Ключ());
					Команда.Parameters.AddWithValue("ДатаДокументаОтправителя", ДатаДокументаОтправителя);
					Команда.Parameters.AddWithValue("ДатаИзмененияСтатусаЭД", ДатаИзмененияСтатусаЭД);
					Команда.Parameters.AddWithValue("ДатаМодификацииУниверсальная", ДатаМодификацииУниверсальная);
					Команда.Parameters.AddWithValue("ДатаСоздания", ДатаСоздания);
					Команда.Parameters.AddWithValue("ДатаФормированияЭДОтправителем", ДатаФормированияЭДОтправителем);
					Команда.Parameters.AddWithValue("Загружен", Загружен);
					Команда.Parameters.AddWithValue("Зашифрован", Зашифрован);
					Команда.Parameters.AddWithValue("Изменил", Изменил.Ссылка);
					Команда.Parameters.AddWithValue("ИндексКартинки", ИндексКартинки);
					Команда.Parameters.AddWithValue("Контрагент", Контрагент.Ссылка);
					Команда.Parameters.AddWithValue("НаправлениеЭД", НаправлениеЭД.Ключ());
					Команда.Parameters.AddWithValue("НомерВерсииЭД", НомерВерсииЭД);
					Команда.Parameters.AddWithValue("НомерДокументаОтправителя", НомерДокументаОтправителя);
					Команда.Parameters.AddWithValue("НомерЭД", НомерЭД);
					Команда.Parameters.AddWithValue("Описание", Описание);
					Команда.Parameters.AddWithValue("Организация", Организация.Ссылка);
					Команда.Parameters.AddWithValue("Ответственный", Ответственный.Ссылка);
					Команда.Parameters.AddWithValue("ОтправительЭД", ОтправительЭД);
					Команда.Parameters.AddWithValue("ПодписанЭЦП", ПодписанЭЦП);
					Команда.Parameters.AddWithValue("ПолучательЭД", ПолучательЭД);
					Команда.Parameters.AddWithValue("ПричинаОтклонения", ПричинаОтклонения);
					Команда.Parameters.AddWithValue("ПутьКФайлу", ПутьКФайлу);
					Команда.Parameters.AddWithValue("Размер", Размер);
					Команда.Parameters.AddWithValue("Расширение", Расширение);
					Команда.Parameters.AddWithValue("Редактирует", Редактирует.Ссылка);
					Команда.Parameters.AddWithValue("СоглашениеЭД", СоглашениеЭД.Ссылка);
					Команда.Parameters.AddWithValue("СтатусИзвлеченияТекста", СтатусИзвлеченияТекста.Ключ());
					Команда.Parameters.AddWithValue("СтатусЭД", СтатусЭД.Ключ());
					Команда.Parameters.AddWithValue("ТекстХранилище",new byte[0]);
					Команда.Parameters.AddWithValue("ТипХраненияФайла", ТипХраненияФайла.Ключ());
					Команда.Parameters.AddWithValue("ТипЭлементаВерсииЭД", ТипЭлементаВерсииЭД.Ключ());
					Команда.Parameters.AddWithValue("Том", Том.Ссылка);
					Команда.Parameters.AddWithValue("УникальныйИД", УникальныйИД);
					Команда.Parameters.AddWithValue("ФайлХранилище",new byte[0]);
					Команда.Parameters.AddWithValue("ЭлектронныйДокументВладелец", ЭлектронныйДокументВладелец.Ссылка);
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
					Команда.CommandText = @"Delete _Reference294
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}