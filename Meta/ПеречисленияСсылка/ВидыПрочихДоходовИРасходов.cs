﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ВидыПрочихДоходовИРасходов
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		ВозмещениеУбытковКПолучениюУплате = 0,//Возмещение убытков к получению (уплате)
		ДолевоеУчастиеВИностранныхОрганизациях = 1,//Долевое участие в иностранных организациях
		ДолевоеУчастиеВРоссийскихОрганизациях = 2,//Долевое участие в российских организациях
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделок = 3,//Доходы (расходы) по операциям с финансовыми инструментами срочных сделок, не обращающимися на организованном рынке
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделокОР = 4,//Доходы (расходы) по операциям с финансовыми инструментами срочных сделок, обращающимися на организованном рынке
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСБезвозмезднымПолучениемИмущества = 5,//Доходы (расходы), связанные с безвозмездным получением имущества, работ, услуг или имущественных прав
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСЛиквидациейОсновныхСредств = 6,//Доходы (расходы), связанные с ликвидацией основных средств
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСоСдачейИмуществаВАренду = 7,//Доходы (расходы), связанные со сдачей имущества в аренду (субаренду)
		ДоходыРасходыСвязанныеСПереоценкойВнеоборотныхАктивов = 8,//Доходы (расходы), связанные с переоценкой внеоборотных активов
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСРеализациейИмущественныхПравКромеПраваТребования = 9,//Доходы (расходы), связанные с реализацией имущественных прав, кроме права требования
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСРеализациейИмущественныхПравПоОбъектамОбслуживающихПроизводств = 10,//Доходы (расходы), связанные с реализацией имущественных прав по объектам обслуживающих производств и хозяйств
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСРеализациейНематериальныхАктивов = 11,//Доходы (расходы), связанные с реализацией нематериальных активов
		ДоходыРасходыСвязанныеСРеализациейОбъектовСтроительства = 12,//Доходы (расходы) связанные с реализацией объектов строительства
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСРеализациейОсновныхСредств = 13,//Доходы (расходы), связанные с реализацией основных средств
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСРеализациейПраваТребованияДоНаступленияСрокаПлатежа = 14,//Доходы (расходы), связанные с реализацией права требования до наступления срока платежа
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСРеализациейПраваТребованияКакОказанияФинансовыхУслуг = 15,//Доходы (расходы), связанные с реализацией права требования как оказания финансовых услуг
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСРеализациейПраваТребованияПослеНаступленияСрокаПлатежа = 16,//Доходы (расходы), связанные с реализацией права требования после наступления срока платежа
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСРеализациейПрочегоИмущества = 17,//Доходы (расходы), связанные с реализацией прочего имущества
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСРеализациейЦенныхБумаг = 18,//Доходы (расходы), связанные с реализацией ценных бумаг
	///<summary>
	///(Общ)
	///</summary>
		ДоходыРасходыСвязанныеСУчастиемВДругихОрганизациях = 19,//Доходы (расходы), связанные с участием в других организациях
		ДоходыСвязанныеСВосстановлениемАмортизационнойПремии = 20,//Доходы, связанные с восстановлением амортизационной премии
	///<summary>
	///(Общ)
	///</summary>
		КурсовыеРазницы = 21,//Курсовые разницы
	///<summary>
	///Курсовые разницы по расчетам в у.е.
	///</summary>
		КурсовыеРазницыПоРасчетамВУЕ = 22,//Курсовые разницы по расчетам в у.е.
		НалогиИСборы = 23,//Налоги и сборы
	///<summary>
	///(Общ)
	///</summary>
		НДСПоСписаннойКредиторскойЗадолженности = 24,//НДС по списанной кредиторской задолженности
	///<summary>
	///(Общ)
	///</summary>
		ОтчисленияВОценочныеРезервы = 25,//Отчисления в оценочные резервы
	///<summary>
	///Премия, выплаченная покупателю
	///</summary>
		ПремияПокупателю = 26,//Премия, выплаченная покупателю
	///<summary>
	///(Общ)
	///</summary>
		ПрибыльУбытокПрошлыхЛет = 27,//Прибыль (убыток) прошлых лет
	///<summary>
	///(Общ)
	///</summary>
		ПроцентыКПолучениюУплате = 28,//Проценты к получению (уплате)
		ПроцентыНачисленныеПоСт269 = 29,//Проценты, начисленные в соответствии со статьей 269
		ПроцентыПоГосударственнымЦеннымБумагам = 30,//Проценты по государственным ценным бумагам
		ПроцентыПоГосударственнымЦеннымБумагамПоСтавке0 = 31,//Проценты по государственным ценным бумагам по ставке 0%
	///<summary>
	///(Общ)
	///</summary>
		ПрочиеВнереализационныеДоходыРасходы = 32,//Прочие внереализационные доходы (расходы)
		ПрочиеКосвенныеРасходы = 33,//Прочие косвенные расходы
	///<summary>
	///(Общ)
	///</summary>
		ПрочиеОперационныеДоходыРасходы = 34,//Прочие операционные доходы (расходы)
	///<summary>
	///(Общ)
	///</summary>
		РазницаМеждуПервоначальнойИНоминальнойСтоимостьюПоДолговымЦеннымБумагам = 35,//Разница между первоначальной и номинальной стоимостью по долговым ценным бумагам
	///<summary>
	///(Общ)
	///</summary>
		РасходыНаУслугиБанков = 36,//Расходы на услуги банков
	///<summary>
	///(Общ)
	///</summary>
		РасходыОтСниженияСтоимостиАктивов = 37,//Расходы от снижения стоимости активов
		РасходыПоПередачеТоваровБезвозмездноИДляСобственныхНужд = 38,//Расходы по передаче товаров (работ, услуг) безвозмездно и для собственных нужд
	///<summary>
	///(Общ)
	///</summary>
		СписаниеДебиторскойКредиторскойЗадолженности = 39,//Списание дебиторской (кредиторской) задолженности
	///<summary>
	///(Общ)
	///</summary>
		ШтрафыПениНеустойкиКПолучениюУплате = 40,//Штрафы, пени и неустойки к получению (уплате)
		ПрочиеУбыткиПриравненныеКВнереализационнымРасходам = 41,//Прочие убытки, приравненные к внереализационным расходам
		КорректировкаПрибылиДоРыночныхЦен = 42,//Корректировка прибыли до рыночных цен
	}
	public static partial class ВидыПрочихДоходовИРасходов_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозмещениеУбытковКПолучениюУплате = new Guid("81283684-f8b9-d2ca-426e-dfa8a9be7b76");//Возмещение убытков к получению (уплате)
		public static readonly Guid ДолевоеУчастиеВИностранныхОрганизациях = new Guid("eb3484a9-3f88-52d5-4517-74ff0db8348f");//Долевое участие в иностранных организациях
		public static readonly Guid ДолевоеУчастиеВРоссийскихОрганизациях = new Guid("a370ad82-855e-d9ec-4da9-1afc779f6049");//Долевое участие в российских организациях
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделок = new Guid("0ef42cb7-9dcd-2a11-4e28-869fec2785be");//Доходы (расходы) по операциям с финансовыми инструментами срочных сделок, не обращающимися на организованном рынке
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделокОР = new Guid("dad768a6-5b7f-9198-4326-bcbfe2e2017e");//Доходы (расходы) по операциям с финансовыми инструментами срочных сделок, обращающимися на организованном рынке
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСБезвозмезднымПолучениемИмущества = new Guid("bb2448b0-40a6-f9c9-452e-18bf9acb83b2");//Доходы (расходы), связанные с безвозмездным получением имущества, работ, услуг или имущественных прав
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСЛиквидациейОсновныхСредств = new Guid("9ac4ba8f-4a50-8f6f-4ccf-c432e7fa879f");//Доходы (расходы), связанные с ликвидацией основных средств
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСоСдачейИмуществаВАренду = new Guid("882962a0-f24f-c7d4-49e8-1e0ac4b0312f");//Доходы (расходы), связанные со сдачей имущества в аренду (субаренду)
		public static readonly Guid ДоходыРасходыСвязанныеСПереоценкойВнеоборотныхАктивов = new Guid("78caf4bb-5b1c-9e77-470a-88599777afda");//Доходы (расходы), связанные с переоценкой внеоборотных активов
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейИмущественныхПравКромеПраваТребования = new Guid("370161aa-bc6b-cc4d-439d-ee70cb23b217");//Доходы (расходы), связанные с реализацией имущественных прав, кроме права требования
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейИмущественныхПравПоОбъектамОбслуживающихПроизводств = new Guid("1307f0b2-6ff0-24cc-4ea1-bde3162ec753");//Доходы (расходы), связанные с реализацией имущественных прав по объектам обслуживающих производств и хозяйств
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейНематериальныхАктивов = new Guid("97b921bd-b844-1bfb-4409-f9264b693ccb");//Доходы (расходы), связанные с реализацией нематериальных активов
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейОбъектовСтроительства = new Guid("d2039089-3d67-5a65-4f50-b1f676b24273");//Доходы (расходы) связанные с реализацией объектов строительства
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейОсновныхСредств = new Guid("9f5a06b9-f328-82cc-4955-404a3fc7a250");//Доходы (расходы), связанные с реализацией основных средств
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейПраваТребованияДоНаступленияСрокаПлатежа = new Guid("d67904ae-2c53-0eb5-4a2a-e5394babd22d");//Доходы (расходы), связанные с реализацией права требования до наступления срока платежа
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейПраваТребованияКакОказанияФинансовыхУслуг = new Guid("49384689-285b-2144-428f-c8f78c8c7f3c");//Доходы (расходы), связанные с реализацией права требования как оказания финансовых услуг
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейПраваТребованияПослеНаступленияСрокаПлатежа = new Guid("2b8395a8-e526-53a0-4b03-74e6f98f7b0f");//Доходы (расходы), связанные с реализацией права требования после наступления срока платежа
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейПрочегоИмущества = new Guid("3e07b1a6-572f-5299-4ec4-0b60df6bb4f8");//Доходы (расходы), связанные с реализацией прочего имущества
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСРеализациейЦенныхБумаг = new Guid("91569e9b-6e82-ef9e-4660-a93178c85696");//Доходы (расходы), связанные с реализацией ценных бумаг
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ДоходыРасходыСвязанныеСУчастиемВДругихОрганизациях = new Guid("d41bd995-fe18-f8d4-4fe1-2bcc46211360");//Доходы (расходы), связанные с участием в других организациях
		public static readonly Guid ДоходыСвязанныеСВосстановлениемАмортизационнойПремии = new Guid("496d0797-4edf-3002-42ee-2ba443af2abb");//Доходы, связанные с восстановлением амортизационной премии
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid КурсовыеРазницы = new Guid("dfc17991-c94d-041c-40f3-d24c958f55e2");//Курсовые разницы
		///<summary>
		///Курсовые разницы по расчетам в у.е.
		///</summary>
		public static readonly Guid КурсовыеРазницыПоРасчетамВУЕ = new Guid("40129ea3-7d3c-5301-421b-2c9b060a9c87");//Курсовые разницы по расчетам в у.е.
		public static readonly Guid НалогиИСборы = new Guid("6763cea8-a472-7b47-4afc-2b40645d7eff");//Налоги и сборы
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid НДСПоСписаннойКредиторскойЗадолженности = new Guid("9ac7a688-fe0f-3054-4199-843924865ae5");//НДС по списанной кредиторской задолженности
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ОтчисленияВОценочныеРезервы = new Guid("623e7484-e27d-e8b7-4fd6-605d2bd4a1e1");//Отчисления в оценочные резервы
		///<summary>
		///Премия, выплаченная покупателю
		///</summary>
		public static readonly Guid ПремияПокупателю = new Guid("17f2799e-f428-52c5-40fa-f8223a22f525");//Премия, выплаченная покупателю
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПрибыльУбытокПрошлыхЛет = new Guid("488072b4-ec12-bae4-41b3-dd332cd790fd");//Прибыль (убыток) прошлых лет
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПроцентыКПолучениюУплате = new Guid("09bd60a7-bac7-fa5e-4ddb-20b5bafb8c81");//Проценты к получению (уплате)
		public static readonly Guid ПроцентыНачисленныеПоСт269 = new Guid("fac5c2a9-302a-2138-47e1-24d1bc92d7e8");//Проценты, начисленные в соответствии со статьей 269
		public static readonly Guid ПроцентыПоГосударственнымЦеннымБумагам = new Guid("ffe8e39a-704b-f380-4626-75ed0db087aa");//Проценты по государственным ценным бумагам
		public static readonly Guid ПроцентыПоГосударственнымЦеннымБумагамПоСтавке0 = new Guid("e39a57a7-9e3d-9325-4aec-f5f0e4ade1b5");//Проценты по государственным ценным бумагам по ставке 0%
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПрочиеВнереализационныеДоходыРасходы = new Guid("3b1f7f84-ae4c-ff72-4673-a2f73882e26e");//Прочие внереализационные доходы (расходы)
		public static readonly Guid ПрочиеКосвенныеРасходы = new Guid("6eacde8e-d5a7-9d35-4e56-1f3905aa1fc9");//Прочие косвенные расходы
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПрочиеОперационныеДоходыРасходы = new Guid("d3afcdb9-015b-3681-4dfa-136859708e9a");//Прочие операционные доходы (расходы)
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid РазницаМеждуПервоначальнойИНоминальнойСтоимостьюПоДолговымЦеннымБумагам = new Guid("55754b9a-a7ac-d6d6-4d48-65b4cc3c4160");//Разница между первоначальной и номинальной стоимостью по долговым ценным бумагам
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid РасходыНаУслугиБанков = new Guid("6fd847a0-776e-671c-4108-f3b7e189b77d");//Расходы на услуги банков
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid РасходыОтСниженияСтоимостиАктивов = new Guid("05429f91-37c9-06b5-46a2-de4301110a7b");//Расходы от снижения стоимости активов
		public static readonly Guid РасходыПоПередачеТоваровБезвозмездноИДляСобственныхНужд = new Guid("8e179b8b-a155-f9a2-4a73-9045c46dc42c");//Расходы по передаче товаров (работ, услуг) безвозмездно и для собственных нужд
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеДебиторскойКредиторскойЗадолженности = new Guid("77813d86-dcd7-9019-404d-3361de21295d");//Списание дебиторской (кредиторской) задолженности
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ШтрафыПениНеустойкиКПолучениюУплате = new Guid("505f01a2-04c0-b734-4f19-8d133d8ff0eb");//Штрафы, пени и неустойки к получению (уплате)
		public static readonly Guid ПрочиеУбыткиПриравненныеКВнереализационнымРасходам = new Guid("44ed10a8-86c2-9dea-435f-9e3c10fc1677");//Прочие убытки, приравненные к внереализационным расходам
		public static readonly Guid КорректировкаПрибылиДоРыночныхЦен = new Guid("fdfbbb9c-b622-b380-409b-acc5796bf0cb");//Корректировка прибыли до рыночных цен
		public static ВидыПрочихДоходовИРасходов Получить(this ВидыПрочихДоходовИРасходов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыПрочихДоходовИРасходов Получить(this ВидыПрочихДоходовИРасходов Значение, Guid Ссылка)
		{
			if(Ссылка == ВозмещениеУбытковКПолучениюУплате)
			{
				return ВидыПрочихДоходовИРасходов.ВозмещениеУбытковКПолучениюУплате;
			}
			else if(Ссылка == ДолевоеУчастиеВИностранныхОрганизациях)
			{
				return ВидыПрочихДоходовИРасходов.ДолевоеУчастиеВИностранныхОрганизациях;
			}
			else if(Ссылка == ДолевоеУчастиеВРоссийскихОрганизациях)
			{
				return ВидыПрочихДоходовИРасходов.ДолевоеУчастиеВРоссийскихОрганизациях;
			}
			else if(Ссылка == ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделок)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделок;
			}
			else if(Ссылка == ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделокОР)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделокОР;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСБезвозмезднымПолучениемИмущества)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСБезвозмезднымПолучениемИмущества;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСЛиквидациейОсновныхСредств)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСЛиквидациейОсновныхСредств;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСоСдачейИмуществаВАренду)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСоСдачейИмуществаВАренду;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСПереоценкойВнеоборотныхАктивов)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСПереоценкойВнеоборотныхАктивов;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейИмущественныхПравКромеПраваТребования)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейИмущественныхПравКромеПраваТребования;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейИмущественныхПравПоОбъектамОбслуживающихПроизводств)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейИмущественныхПравПоОбъектамОбслуживающихПроизводств;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейНематериальныхАктивов)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейНематериальныхАктивов;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейОбъектовСтроительства)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейОбъектовСтроительства;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейОсновныхСредств)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейОсновныхСредств;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейПраваТребованияДоНаступленияСрокаПлатежа)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейПраваТребованияДоНаступленияСрокаПлатежа;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейПраваТребованияКакОказанияФинансовыхУслуг)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейПраваТребованияКакОказанияФинансовыхУслуг;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейПраваТребованияПослеНаступленияСрокаПлатежа)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейПраваТребованияПослеНаступленияСрокаПлатежа;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейПрочегоИмущества)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейПрочегоИмущества;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСРеализациейЦенныхБумаг)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейЦенныхБумаг;
			}
			else if(Ссылка == ДоходыРасходыСвязанныеСУчастиемВДругихОрганизациях)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСУчастиемВДругихОрганизациях;
			}
			else if(Ссылка == ДоходыСвязанныеСВосстановлениемАмортизационнойПремии)
			{
				return ВидыПрочихДоходовИРасходов.ДоходыСвязанныеСВосстановлениемАмортизационнойПремии;
			}
			else if(Ссылка == КурсовыеРазницы)
			{
				return ВидыПрочихДоходовИРасходов.КурсовыеРазницы;
			}
			else if(Ссылка == КурсовыеРазницыПоРасчетамВУЕ)
			{
				return ВидыПрочихДоходовИРасходов.КурсовыеРазницыПоРасчетамВУЕ;
			}
			else if(Ссылка == НалогиИСборы)
			{
				return ВидыПрочихДоходовИРасходов.НалогиИСборы;
			}
			else if(Ссылка == НДСПоСписаннойКредиторскойЗадолженности)
			{
				return ВидыПрочихДоходовИРасходов.НДСПоСписаннойКредиторскойЗадолженности;
			}
			else if(Ссылка == ОтчисленияВОценочныеРезервы)
			{
				return ВидыПрочихДоходовИРасходов.ОтчисленияВОценочныеРезервы;
			}
			else if(Ссылка == ПремияПокупателю)
			{
				return ВидыПрочихДоходовИРасходов.ПремияПокупателю;
			}
			else if(Ссылка == ПрибыльУбытокПрошлыхЛет)
			{
				return ВидыПрочихДоходовИРасходов.ПрибыльУбытокПрошлыхЛет;
			}
			else if(Ссылка == ПроцентыКПолучениюУплате)
			{
				return ВидыПрочихДоходовИРасходов.ПроцентыКПолучениюУплате;
			}
			else if(Ссылка == ПроцентыНачисленныеПоСт269)
			{
				return ВидыПрочихДоходовИРасходов.ПроцентыНачисленныеПоСт269;
			}
			else if(Ссылка == ПроцентыПоГосударственнымЦеннымБумагам)
			{
				return ВидыПрочихДоходовИРасходов.ПроцентыПоГосударственнымЦеннымБумагам;
			}
			else if(Ссылка == ПроцентыПоГосударственнымЦеннымБумагамПоСтавке0)
			{
				return ВидыПрочихДоходовИРасходов.ПроцентыПоГосударственнымЦеннымБумагамПоСтавке0;
			}
			else if(Ссылка == ПрочиеВнереализационныеДоходыРасходы)
			{
				return ВидыПрочихДоходовИРасходов.ПрочиеВнереализационныеДоходыРасходы;
			}
			else if(Ссылка == ПрочиеКосвенныеРасходы)
			{
				return ВидыПрочихДоходовИРасходов.ПрочиеКосвенныеРасходы;
			}
			else if(Ссылка == ПрочиеОперационныеДоходыРасходы)
			{
				return ВидыПрочихДоходовИРасходов.ПрочиеОперационныеДоходыРасходы;
			}
			else if(Ссылка == РазницаМеждуПервоначальнойИНоминальнойСтоимостьюПоДолговымЦеннымБумагам)
			{
				return ВидыПрочихДоходовИРасходов.РазницаМеждуПервоначальнойИНоминальнойСтоимостьюПоДолговымЦеннымБумагам;
			}
			else if(Ссылка == РасходыНаУслугиБанков)
			{
				return ВидыПрочихДоходовИРасходов.РасходыНаУслугиБанков;
			}
			else if(Ссылка == РасходыОтСниженияСтоимостиАктивов)
			{
				return ВидыПрочихДоходовИРасходов.РасходыОтСниженияСтоимостиАктивов;
			}
			else if(Ссылка == РасходыПоПередачеТоваровБезвозмездноИДляСобственныхНужд)
			{
				return ВидыПрочихДоходовИРасходов.РасходыПоПередачеТоваровБезвозмездноИДляСобственныхНужд;
			}
			else if(Ссылка == СписаниеДебиторскойКредиторскойЗадолженности)
			{
				return ВидыПрочихДоходовИРасходов.СписаниеДебиторскойКредиторскойЗадолженности;
			}
			else if(Ссылка == ШтрафыПениНеустойкиКПолучениюУплате)
			{
				return ВидыПрочихДоходовИРасходов.ШтрафыПениНеустойкиКПолучениюУплате;
			}
			else if(Ссылка == ПрочиеУбыткиПриравненныеКВнереализационнымРасходам)
			{
				return ВидыПрочихДоходовИРасходов.ПрочиеУбыткиПриравненныеКВнереализационнымРасходам;
			}
			else if(Ссылка == КорректировкаПрибылиДоРыночныхЦен)
			{
				return ВидыПрочихДоходовИРасходов.КорректировкаПрибылиДоРыночныхЦен;
			}
			return ВидыПрочихДоходовИРасходов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыПрочихДоходовИРасходов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыПрочихДоходовИРасходов Значение)
		{
			switch (Значение)
			{
				case ВидыПрочихДоходовИРасходов.ВозмещениеУбытковКПолучениюУплате: return ВозмещениеУбытковКПолучениюУплате;
				case ВидыПрочихДоходовИРасходов.ДолевоеУчастиеВИностранныхОрганизациях: return ДолевоеУчастиеВИностранныхОрганизациях;
				case ВидыПрочихДоходовИРасходов.ДолевоеУчастиеВРоссийскихОрганизациях: return ДолевоеУчастиеВРоссийскихОрганизациях;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделок: return ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделок;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделокОР: return ДоходыРасходыПоОперациямСФинансовымиИнструментамиСрочныхСделокОР;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСБезвозмезднымПолучениемИмущества: return ДоходыРасходыСвязанныеСБезвозмезднымПолучениемИмущества;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСЛиквидациейОсновныхСредств: return ДоходыРасходыСвязанныеСЛиквидациейОсновныхСредств;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСоСдачейИмуществаВАренду: return ДоходыРасходыСвязанныеСоСдачейИмуществаВАренду;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСПереоценкойВнеоборотныхАктивов: return ДоходыРасходыСвязанныеСПереоценкойВнеоборотныхАктивов;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейИмущественныхПравКромеПраваТребования: return ДоходыРасходыСвязанныеСРеализациейИмущественныхПравКромеПраваТребования;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейИмущественныхПравПоОбъектамОбслуживающихПроизводств: return ДоходыРасходыСвязанныеСРеализациейИмущественныхПравПоОбъектамОбслуживающихПроизводств;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейНематериальныхАктивов: return ДоходыРасходыСвязанныеСРеализациейНематериальныхАктивов;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейОбъектовСтроительства: return ДоходыРасходыСвязанныеСРеализациейОбъектовСтроительства;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейОсновныхСредств: return ДоходыРасходыСвязанныеСРеализациейОсновныхСредств;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейПраваТребованияДоНаступленияСрокаПлатежа: return ДоходыРасходыСвязанныеСРеализациейПраваТребованияДоНаступленияСрокаПлатежа;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейПраваТребованияКакОказанияФинансовыхУслуг: return ДоходыРасходыСвязанныеСРеализациейПраваТребованияКакОказанияФинансовыхУслуг;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейПраваТребованияПослеНаступленияСрокаПлатежа: return ДоходыРасходыСвязанныеСРеализациейПраваТребованияПослеНаступленияСрокаПлатежа;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейПрочегоИмущества: return ДоходыРасходыСвязанныеСРеализациейПрочегоИмущества;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСРеализациейЦенныхБумаг: return ДоходыРасходыСвязанныеСРеализациейЦенныхБумаг;
				case ВидыПрочихДоходовИРасходов.ДоходыРасходыСвязанныеСУчастиемВДругихОрганизациях: return ДоходыРасходыСвязанныеСУчастиемВДругихОрганизациях;
				case ВидыПрочихДоходовИРасходов.ДоходыСвязанныеСВосстановлениемАмортизационнойПремии: return ДоходыСвязанныеСВосстановлениемАмортизационнойПремии;
				case ВидыПрочихДоходовИРасходов.КурсовыеРазницы: return КурсовыеРазницы;
				case ВидыПрочихДоходовИРасходов.КурсовыеРазницыПоРасчетамВУЕ: return КурсовыеРазницыПоРасчетамВУЕ;
				case ВидыПрочихДоходовИРасходов.НалогиИСборы: return НалогиИСборы;
				case ВидыПрочихДоходовИРасходов.НДСПоСписаннойКредиторскойЗадолженности: return НДСПоСписаннойКредиторскойЗадолженности;
				case ВидыПрочихДоходовИРасходов.ОтчисленияВОценочныеРезервы: return ОтчисленияВОценочныеРезервы;
				case ВидыПрочихДоходовИРасходов.ПремияПокупателю: return ПремияПокупателю;
				case ВидыПрочихДоходовИРасходов.ПрибыльУбытокПрошлыхЛет: return ПрибыльУбытокПрошлыхЛет;
				case ВидыПрочихДоходовИРасходов.ПроцентыКПолучениюУплате: return ПроцентыКПолучениюУплате;
				case ВидыПрочихДоходовИРасходов.ПроцентыНачисленныеПоСт269: return ПроцентыНачисленныеПоСт269;
				case ВидыПрочихДоходовИРасходов.ПроцентыПоГосударственнымЦеннымБумагам: return ПроцентыПоГосударственнымЦеннымБумагам;
				case ВидыПрочихДоходовИРасходов.ПроцентыПоГосударственнымЦеннымБумагамПоСтавке0: return ПроцентыПоГосударственнымЦеннымБумагамПоСтавке0;
				case ВидыПрочихДоходовИРасходов.ПрочиеВнереализационныеДоходыРасходы: return ПрочиеВнереализационныеДоходыРасходы;
				case ВидыПрочихДоходовИРасходов.ПрочиеКосвенныеРасходы: return ПрочиеКосвенныеРасходы;
				case ВидыПрочихДоходовИРасходов.ПрочиеОперационныеДоходыРасходы: return ПрочиеОперационныеДоходыРасходы;
				case ВидыПрочихДоходовИРасходов.РазницаМеждуПервоначальнойИНоминальнойСтоимостьюПоДолговымЦеннымБумагам: return РазницаМеждуПервоначальнойИНоминальнойСтоимостьюПоДолговымЦеннымБумагам;
				case ВидыПрочихДоходовИРасходов.РасходыНаУслугиБанков: return РасходыНаУслугиБанков;
				case ВидыПрочихДоходовИРасходов.РасходыОтСниженияСтоимостиАктивов: return РасходыОтСниженияСтоимостиАктивов;
				case ВидыПрочихДоходовИРасходов.РасходыПоПередачеТоваровБезвозмездноИДляСобственныхНужд: return РасходыПоПередачеТоваровБезвозмездноИДляСобственныхНужд;
				case ВидыПрочихДоходовИРасходов.СписаниеДебиторскойКредиторскойЗадолженности: return СписаниеДебиторскойКредиторскойЗадолженности;
				case ВидыПрочихДоходовИРасходов.ШтрафыПениНеустойкиКПолучениюУплате: return ШтрафыПениНеустойкиКПолучениюУплате;
				case ВидыПрочихДоходовИРасходов.ПрочиеУбыткиПриравненныеКВнереализационнымРасходам: return ПрочиеУбыткиПриравненныеКВнереализационнымРасходам;
				case ВидыПрочихДоходовИРасходов.КорректировкаПрибылиДоРыночныхЦен: return КорректировкаПрибылиДоРыночныхЦен;
			}
			return Guid.Empty;
		}
	}
}