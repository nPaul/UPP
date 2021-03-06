﻿Ext.require(['Данные.Обработки.НастройкаПараметровУчета'], function () 
{
	Ext.define('Обработки.НастройкаПараметровУчета.НастройкаПараметровУчета',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:704px;height:547px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройка учета зарплаты и управления персоналом',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:7px;top:8px;width:689px;height:506px;',
			height: 506,width: 689,
			items:
			[
				{
					title:'Алгоритмы расчетов',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьАлгоритмыРасчета',
			text: 'Алгоритмы расчетов',
			style: 'position:absolute;left:10px;top:8px;width:273px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПорядокПересчетаМесячнойСтавкиВЧасовую',
			text: 'При пересчёте месячного оклада в часовую ставку использовать:',
			style: 'position:absolute;left:10px;top:175px;width:342px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьПорядокРасчетаЧасовойСтавки',
			text: 'Пересчет месячного оклада в часовую ставку применяется для расчета оплаты сверхурочных часов.\r\nЧасовая ставка будет рассчитана путем деления оклада на количество рабочих часов в месяце по графику работы сотрудника.',
			style: 'position:absolute;left:42px;top:277px;width:438px;height:76px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьУдержаниеЗаОтпускУменьшаетНалоги',
			text: 'Удержание за неотработанный отпуск при увольнении:',
			style: 'position:absolute;left:10px;top:52px;width:287px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьУдержаниеЗаОтпускУменьшаетНалогиИнформация',
			text: 'Удержание за неотработанный отпуск при увольнении будет регистрироваться как сторно начисление',
			style: 'position:absolute;left:42px;top:125px;width:438px;height:32px;text-align:left;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Месячную норму по производственному календарю',
			style: 'position:absolute;left:26px;top:247px;width:281px;height:19px;',
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'Не уменьшает налоги и взносы (НДФЛ, страховые взносы и пр.)',
			style: 'position:absolute;left:26px;top:76px;width:357px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Уменьшает налоги и взносы',
			style: 'position:absolute;left:26px;top:100px;width:281px;height:19px;',
		},
			]
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'Месячную норму времени по графику сотрудника',
			style: 'position:absolute;left:26px;top:199px;width:281px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Среднее за год количество часов в месяце',
			style: 'position:absolute;left:26px;top:223px;width:281px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'по центрам ответственности',
			style: 'position:absolute;left:42px;top:348px;width:179px;height:19px;',
		},
			]
		},
					]
				},
				{
					title:'Кадровый учет',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСтавкиЕСН5',
			text: 'Кадровый учет',
			style: 'position:absolute;left:10px;top:8px;width:180px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация3',
			text: 'Организация:',
			style: 'position:absolute;left:10px;top:52px;width:75px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация3.Представление',
			width: 415,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:91px;top:52px;width:415px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'checkbox',
			boxLabel: 'количество ставок',
			style: 'position:absolute;left:42px;top:103px;width:354px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Единый нумератор кадровых документов',
			style: 'position:absolute;left:26px;top:208px;width:240px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Показывать табельные номера в документах',
			style: 'position:absolute;left:26px;top:257px;width:256px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПроверкаШтатногоРасписания',
			text: 'Проверяются свободные штатные единицы при регистрации кадровых изменений сотрудников.',
			style: 'position:absolute;left:58px;top:122px;width:438px;height:28px;',
		},
		{
			xtype: 'label',
			name: 'НадписьЕдиныйНумераторКадровыхДокументов',
			text: 'Единый нумератор используется для документов:\r\n"Прием на работу", "Кадровое перемещение", "Увольнение".',
			style: 'position:absolute;left:42px;top:228px;width:438px;height:28px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПоказыватьТабельныеНомераВДокументах',
			text: 'При выборе этой настройки в формах документов\r\nбудет показываться колонка с табельным номером сотрудников.',
			style: 'position:absolute;left:42px;top:277px;width:438px;height:29px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Проставлять автоматически дату ознакомления в кадровых приказах',
			style: 'position:absolute;left:26px;top:307px;width:387px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПроставлятьАвтоматическиДатуОзнакомленияВКадровыхПриказах',
			text: 'При выборе этой настройки в печатных формах документов\r\nбудет проставляться дата ознакомления сотрудника с приказом.',
			style: 'position:absolute;left:42px;top:327px;width:438px;height:28px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПорядокСписанияФактическихОтпусков',
			text: 'Остатки отпусков будут уменьшаться при регистрации фактических отпусков',
			style: 'position:absolute;left:26px;top:412px;width:424px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Округлять дни компенсации отпуска при увольнении',
			style: 'position:absolute;left:26px;top:356px;width:293px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ПодсказкаОкруглятьДниОтпускаПриКомпенсации',
			text: 'При выборе этой настройки результат расчета количества дней компенсации отпуска при увольнении сотрудника будет округляться до целых дней.',
			style: 'position:absolute;left:42px;top:376px;width:404px;height:28px;',
		},
		{
			xtype: 'fieldset',
			title: '',
			style: 'position:absolute;left:26px;top:408px;width:460px;height:3px;',
		},
		{
			xtype: 'fieldset',
			title: '',
			style: 'position:absolute;left:26px;top:203px;width:460px;height:3px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКонтрольРазмераСтавок',
			text: 'Проверяется соответствие назначаемых начислений размерам минимальной и максимальной ставок.',
			style: 'position:absolute;left:58px;top:171px;width:422px;height:28px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'размеры ставок',
			style: 'position:absolute;left:42px;top:152px;width:354px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьГруппаКонтролироватьШтатноеРасписание',
			text: 'Контролировать по штатному расписанию при кадровых изменениях:',
			style: 'position:absolute;left:26px;top:82px;width:422px;height:19px;',
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'Кадровыми приказами',
			style: 'position:absolute;left:42px;top:430px;width:158px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Расчетными документами',
			style: 'position:absolute;left:42px;top:449px;width:158px;height:19px;',
		},
			]
		},
					]
				},
				{
					title:'Расчет зарплаты',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Расчет зарплаты по ответственным',
			style: 'position:absolute;left:25px;top:193px;width:206px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'При начислении НДФЛ принимать исчисленный налог к учету как удержанный',
			style: 'position:absolute;left:25px;top:145px;width:430px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Контролировать пересечение периодов начислений, регистрирующих норму времени',
			style: 'position:absolute;left:25px;top:77px;width:476px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСписокРасчетчиковЗарплаты',
			text: 'Показать список ответственных ...',
			style: 'position:absolute;left:284px;top:193px;width:191px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтавкиЕСН4',
			text: 'Расчет зарплаты',
			style: 'position:absolute;left:10px;top:8px;width:180px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация2',
			text: 'Организация:',
			style: 'position:absolute;left:10px;top:52px;width:75px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация2.Представление',
			width: 415,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:91px;top:52px;width:415px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'Надпись12',
			text: 'При проведении документов будет проверяться пересечение периодов начислений, для которых установлен вид времени «Начисление за работу полную смену в пределах нормы времени» или «Неотработанные полные смены, а также командировки»',
			style: 'position:absolute;left:35px;top:98px;width:466px;height:42px;text-align:left;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Используются начисления в валюте',
			style: 'position:absolute;left:25px;top:169px;width:215px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПроцентДоплатыЗаРаботуВНочноеВремя',
			text: 'за работу в ночное время, %:',
			style: 'position:absolute;left:40px;top:383px;width:154px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПроцентДоплатыЗаРаботуВНочноеВремя',
			style: 'position:absolute;left:200px;top:383px;width:49px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПроцентДоплатыЗаРаботуВНочноеВремя1',
			text: 'за работу в вечернее время, %:',
			style: 'position:absolute;left:282px;top:383px;width:164px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПроцентДоплатыЗаРаботуВВечернееВремя',
			style: 'position:absolute;left:457px;top:383px;width:49px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись82',
			text: 'Процент доплаты',
			style: 'position:absolute;left:30px;top:365px;width:225px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'Надпись88',
			text: 'Почтовый сбор',
			style: 'position:absolute;left:30px;top:407px;width:235px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'Надпись89',
			text: 'Тариф почтового сбора:',
			style: 'position:absolute;left:40px;top:427px;width:132px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'ТарифПочтовогоСбора.Представление',
			width: 327,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:179px;top:427px;width:327px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'checkbox',
			boxLabel: 'При расчете больничных не учитывать праздники, приходящиеся на период отпуска',
			style: 'position:absolute;left:25px;top:217px;width:454px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись90',
			text: 'При выборе этой настройки при расчете пособий по временной нетрудоспособности, по беременности и родам, по уходу за ребенком в расчетный период не будут включаться праздничные дни, приходящиеся на период ежегодных отпусков.',
			style: 'position:absolute;left:35px;top:234px;width:466px;height:41px;text-align:left;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'При расчете среднего не уменьшать премии, начисленные пропорционально отр. времени',
			style: 'position:absolute;left:25px;top:280px;width:480px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись96',
			text: 'При выборе этой настройки при расчете среднего заработка для отпуска и командировок премии, начисленные пропорционально отработанному времени, будут учитываться в полных суммах независимо от соотношения их базового периода и расчетного периода среднего заработка',
			style: 'position:absolute;left:35px;top:297px;width:466px;height:53px;text-align:left;',
		},
					]
				},
				{
					title:'Выплата зарплаты',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьВыплатаЗарплаты',
			text: 'Выплата зарплаты',
			style: 'position:absolute;left:10px;top:8px;width:201px;height:25px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Учитывать невыходы',
			style: 'position:absolute;left:42px;top:210px;width:132px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаРасчетаПлановогоАванса',
			text: 'Расчетная дата планового аванса:',
			style: 'position:absolute;left:42px;top:342px;width:178px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ДатаРасчетаПлановогоАванса',
			style: 'position:absolute;left:222px;top:342px;width:55px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация6',
			text: 'Организация:',
			style: 'position:absolute;left:10px;top:52px;width:75px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация6.Представление',
			width: 415,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:91px;top:52px;width:415px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'Надпись83',
			text: 'В список получателей планового аванса не будут включаться сотрудники, которые с начала месяца по расчетную дату планового аванса не имеют отработанных дней по причинам:\r\n- отпуск (очередной, учебный, за свой счет, без оплаты, по беременности и родам,      по уходу за ребенком)\r\n- невыходы по не выясненной причине, прогул\r\n- болезнь, карантин, долечивание и т.д.\r\n- исполнение государственных или др. общественных обязанностей',
			style: 'position:absolute;left:62px;top:228px;width:444px;height:111px;text-align:left;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Взаиморасчеты по зарплате ведутся в разрезе месяцев ее начисления',
			style: 'position:absolute;left:26px;top:90px;width:389px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Упрощенный учет взаиморасчетов',
			style: 'position:absolute;left:26px;top:119px;width:389px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьУпрощенныйУчетВзаиморасчетов',
			text: 'Заработная плата будет считаться выплаченной при проведении документов «Зарплата к выплате организаций», без создания платежных документов',
			style: 'position:absolute;left:42px;top:143px;width:438px;height:40px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьПлановыйАванс',
			text: 'Плановый аванс',
			style: 'position:absolute;left:26px;top:191px;width:225px;height:16px;',
		},
					]
				},
				{
					title:'Бухучет зарплаты',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьБухучетЗарплаты',
			text: 'Бухучет зарплаты',
			style: 'position:absolute;left:10px;top:8px;width:180px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация8',
			text: 'Организация:',
			style: 'position:absolute;left:10px;top:52px;width:75px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация8.Представление',
			width: 415,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:91px;top:52px;width:415px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПериодРБП',
			style: 'position:absolute;left:123px;top:263px;width:60px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалаДействия10',
			text: 'Применяется с:',
			style: 'position:absolute;left:41px;top:263px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьОкончанияДействияРБП',
			text: 'НадписьОкончанияДействияРБП',
			style: 'position:absolute;left:188px;top:263px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИсторияРБП',
			text: 'История изменения ...',
			style: 'position:absolute;left:381px;top:263px;width:114px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись91',
			text: 'Порядок учета расходов на переходящие отпуска с 2011 года',
			style: 'position:absolute;left:26px;top:95px;width:389px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПорядокУчетаОтпусковРБП',
			text: 'В бухгалтерском и налоговом учете расходы признаются в месяце начисления отпускных',
			style: 'position:absolute;left:58px;top:183px;width:428px;height:73px;',
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'в месяце начисления',
			style: 'position:absolute;left:42px;top:119px;width:391px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'БУ в месяце начисления, НУ в месяце, на который приходится отпуск',
			style: 'position:absolute;left:42px;top:139px;width:391px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'в месяце, на который приходится отпуск',
			style: 'position:absolute;left:42px;top:159px;width:391px;height:19px;',
		},
			]
		},
					]
				},
				{
					title:'Оценочные обязательства',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьБухучетЗарплаты1',
			text: 'Оценочные обязательства и резервы',
			style: 'position:absolute;left:10px;top:8px;width:390px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'Надпись92',
			text: 'Оценочные обязательства и резервы',
			style: 'position:absolute;left:30px;top:79px;width:389px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Формировать оценочные обязательства в бухгалтерском учете',
			style: 'position:absolute;left:46px;top:100px;width:354px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Формировать резервы в налоговом учете по налогу на прибыль',
			style: 'position:absolute;left:46px;top:121px;width:362px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись93',
			text: 'Базой для расчета оценочных обязательств и резервов являются',
			style: 'position:absolute;left:46px;top:231px;width:438px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: ' Суммы начислений по оплате труда и исчисленные страховые взносы',
			style: 'position:absolute;left:62px;top:252px;width:382px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: ' Суммы начислений по оплате труда',
			style: 'position:absolute;left:62px;top:272px;width:207px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтатьяОООтпуск',
			text: 'Оценочное обязательство по ежегодным отпускам:',
			style: 'position:absolute;left:46px;top:143px;width:267px;height:15px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'ОценочноеОбязательствоДляОтпуска.Представление',
			width: 460,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:46px;top:158px;width:460px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация10',
			text: 'Организация:',
			style: 'position:absolute;left:10px;top:52px;width:75px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация9.Представление',
			width: 415,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:91px;top:52px;width:415px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПериодОО',
			style: 'position:absolute;left:112px;top:300px;width:60px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалаДействия11',
			text: 'Применяется с:',
			style: 'position:absolute;left:30px;top:300px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьОкончанияДействияОО',
			text: 'НадписьОкончанияДействияОО',
			style: 'position:absolute;left:177px;top:300px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИсторияОО',
			text: 'История изменения ...',
			style: 'position:absolute;left:370px;top:300px;width:114px;height:19px;',
		},
		{
			id: 'ТаблицаРезервов',
			xtype: 'grid',
			style: 'position:absolute;left:10px;top:380px;width:496px;height:118px;',
			height: 118,width: 496,
			columns:
			[
				{
					text:'Оценочное обязательство, резерв',
					width:'169',
					dataIndex:'Резерв',
					flex:1,
				},
				{
					text:'Размер отчислений, %',
					width:'120',
					dataIndex:'Размер',
					flex:1,
				},
				{
					text:'Расчетная база',
					width:'140',
					dataIndex:'РасчетнаяБаза',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/НастройкаПараметровУчета/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Резерв',
					},
					{
						name:'Размер',
					},
					{
						name:'РасчетнаяБаза',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ТаблицаРезервов');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'label',
			name: 'НадписьГод',
			text: 'год',
			style: 'position:absolute;left:473px;top:337px;width:22px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ГодРазмерыОО',
			style: 'position:absolute;left:402px;top:337px;width:62px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись94',
			text: 'Если оценочное обязательство выбрано, отпуска отражаются в учете по дебету\r\nсчета 96 и этому оценочному обязательству, иначе отпуска отражаются в учете\r\nтак как задано в виде расчета.',
			style: 'position:absolute;left:64px;top:179px;width:442px;height:43px;',
		},
		{
			xtype: 'label',
			name: 'Надпись95',
			text: 'Оценочные обязательства и резервы, размеры отчислений на:',
			style: 'position:absolute;left:10px;top:337px;width:381px;height:19px;',
		},
					]
				},
				{
					title:'Страховые взносы',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСтавкиЕСН9',
			text: 'Страховые взносы в ПФР, ФОМС и ФСС',
			style: 'position:absolute;left:10px;top:6px;width:396px;height:25px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПериодПредельнаяВеличинаБазыСтраховыхВзносов',
			style: 'position:absolute;left:109px;top:284px;width:90px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалаДействия7',
			text: 'Применяется с:',
			style: 'position:absolute;left:26px;top:284px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьОкончанияДействияПредельнаяВеличинаБазыСтраховыхВзносов',
			text: 'НадписьОкончанияДействияПредельнаяВеличинаБазыСтраховыхВзносов',
			style: 'position:absolute;left:205px;top:284px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИсторияПредельнаяВеличинаБазыСтраховыхВзносов',
			text: 'История изменения ...',
			style: 'position:absolute;left:367px;top:284px;width:114px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПредельнаяВеличинаБазыСтраховыхВзносов',
			text: 'Предельная величина базы страховых взносов',
			style: 'position:absolute;left:10px;top:238px;width:246px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПредельнаяВеличинаБазыСтраховыхВзносов',
			style: 'position:absolute;left:109px;top:260px;width:90px;height:19px;',
		},
		{
			id: 'ТарифСтраховыхВзносов',
			xtype: 'grid',
			style: 'position:absolute;left:10px;top:82px;width:496px;height:155px;',
			height: 155,width: 496,
			columns:
			[
				{
					text:'Действует с:',
					width:'100',
					dataIndex:'Период',
					flex:1,
				},
				{
					text:'ПФР (всего)',
					width:'64',
					dataIndex:'ПФР',
					flex:1,
				},
				{
					text:'ПФР (накопительная часть)',
					width:'115',
					dataIndex:'ПФРНакопительная',
					flex:1,
				},
				{
					text:'ФСС',
					width:'61',
					dataIndex:'ФСС',
					flex:1,
				},
				{
					text:'ФФОМС',
					width:'80',
					dataIndex:'ФФОМС',
					flex:1,
				},
				{
					text:'ТФОМС',
					width:'80',
					dataIndex:'ТФОМС',
					flex:1,
				},
				{
					text:'Вид тарифа',
					width:'100',
					dataIndex:'ВидТарифа',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/НастройкаПараметровУчета/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Период',
					},
					{
						name:'ПФР',
					},
					{
						name:'ПФРНакопительная',
					},
					{
						name:'ФСС',
					},
					{
						name:'ФФОМС',
					},
					{
						name:'ТФОМС',
					},
					{
						name:'ВидТарифа',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ТарифСтраховыхВзносов');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'label',
			name: 'НадписьТарифСтраховыхВзносов',
			text: 'Тариф страховых взносов:',
			style: 'position:absolute;left:10px;top:34px;width:138px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ВидТарифаСтраховыхВзносов',
			width: 496,
			height: 19,
			style: 'position:absolute;left:10px;top:58px;width:496px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалаДействия8',
			text: 'Размер: ',
			style: 'position:absolute;left:26px;top:260px;width:82px;height:19px;text-align:left;',
		},
		{
			id: 'СтавкиФССНС',
			xtype: 'grid',
			style: 'position:absolute;left:10px;top:394px;width:496px;height:104px;',
			height: 104,width: 496,
			columns:
			[
				{
					text:'Организация (обособленное подразделение)',
					width:'250',
					dataIndex:'Организация',
					flex:1,
				},
				{
					text:'Действует с:',
					width:'100',
					dataIndex:'Период',
					flex:1,
				},
				{
					text:'Ставка',
					width:'100',
					dataIndex:'Ставка',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/НастройкаПараметровУчета/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Организация',
					},
					{
						name:'Период',
					},
					{
						name:'Ставка',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('СтавкиФССНС');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:326px;top:405px;width:133px;height:24px;',
			items:
			[
				{
					text:'&Добавить',
				},
				{
					text:'&Удалить',
				},
				{
					text:'Вывести список...',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:10px;top:371px;width:496px;height:24px;',
			items:
			[
				{
					text:'&Добавить',
				},
				'-',
				{
					text:'&Удалить',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьСтавкиВзносовФСС_НС',
			text: 'Ставка взносов в ФСС НС и ПЗ',
			style: 'position:absolute;left:10px;top:328px;width:246px;height:15px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация4',
			text: 'Организация:',
			style: 'position:absolute;left:26px;top:347px;width:75px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Организация4.Представление',
			width: 402,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:104px;top:347px;width:402px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
					]
				},
				{
					title:'Расчет страховых взносов',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Используется труд членов летных экипажей',
			style: 'position:absolute;left:30px;top:48px;width:259px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Используется труд занятых на горных работах по добыче угля и сланца',
			style: 'position:absolute;left:30px;top:127px;width:397px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Используется труд работающих в студенческом отряде',
			style: 'position:absolute;left:30px;top:352px;width:352px;height:17px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Используется труд членов экипажей морских судов',
			style: 'position:absolute;left:30px;top:205px;width:307px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДополнительныеВозможности',
			text: 'Расчет страховых взносов',
			style: 'position:absolute;left:10px;top:8px;width:391px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИспользуетсяТрудЧленовЛетныхЭкипажей',
			text: 'При включении этой настройки будет доступен расчет взносов на финансирование доплат к пенсии членам летных экипажей воздушных судов. Должности сотрудников, с оплаты труда которых взимаются взносы, должны быть отмечены флажком «Входит в список должностей летных экипажей, работа в которых дает право на доплату к пенсии».',
			style: 'position:absolute;left:39px;top:69px;width:467px;height:53px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИспользуетсяТрудШахтеров',
			text: 'При включении этой настройки будет доступен расчет взносов на выплату доплаты к пенсии работникам организаций угольной промышленности. Должности сотрудников, с оплаты труда которых взимаются взносы, должны быть отмечены флажком «Дает право на доплату к пенсии в угольной промышленности».',
			style: 'position:absolute;left:39px;top:148px;width:467px;height:52px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИспользуетсяТрудЧленовЭкипажейМорскихСудов',
			text: 'При включении этой настройки расчет страховых взносов с выплат и иных вознаграждений членам экипажей судов, зарегистрированных в Российском международном реестре судов, будет производиться по пониженному тарифу.',
			style: 'position:absolute;left:39px;top:226px;width:467px;height:40px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИспользуетсяТрудФармацевтов',
			text: 'При включении этой настройки расчет страховых взносов с выплат и иных вознаграждений фармацевтам аптечных организаций будет производиться по пониженному тарифу. Должности сотрудников, относящиеся к фармацевтам, должны быть отмечены флажком «Является фармацевтической должностью».',
			style: 'position:absolute;left:39px;top:290px;width:467px;height:57px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИспользуетсяТрудРаботающихВСтудотряде',
			text: 'При включении этой настройки не будут начисляться страховые взносы в ПФР с выплат в пользу обучающихся в образовательных учреждениях среднего профессионального, высшего профессионального образования по очной форме обучения за деятельность, осуществляемую в студенческом отряде.',
			style: 'position:absolute;left:39px;top:371px;width:467px;height:55px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Используется труд фармацевтов',
			style: 'position:absolute;left:30px;top:271px;width:321px;height:17px;',
		},
					]
				},
				{
					title:'НДФЛ',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьРасчетНДФЛ',
			text: 'Расчет НДФЛ',
			style: 'position:absolute;left:10px;top:8px;width:180px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация5',
			text: 'Организация:',
			style: 'position:absolute;left:10px;top:52px;width:75px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация5.Представление',
			width: 415,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:91px;top:52px;width:415px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПериодНДФЛ',
			style: 'position:absolute;left:109px;top:231px;width:60px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалаДействия5',
			text: 'Применяется с:',
			style: 'position:absolute;left:26px;top:231px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьОкончанияДействияНДФЛ',
			text: 'НадписьОкончанияДействияНДФЛ',
			style: 'position:absolute;left:173px;top:231px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИсторияНДФЛ',
			text: 'История изменения ...',
			style: 'position:absolute;left:366px;top:231px;width:114px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись15',
			text: 'Стандартные вычеты применяются',
			style: 'position:absolute;left:10px;top:90px;width:262px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПорядокУчетаСтандартныхВычетов',
			text: 'Стандартные вычеты применяются в пределах месячного дохода налогоплательщика – в этом случае вычеты, на которые имеет право налогоплательщик (сотрудник) в каждом месяце налогового периода, применяются к налоговой базе, исчисленной за этот месяц (вариант соответствует положениям письма Минфина РФ от 7 октября 2004 г. №03-05-01-04/41).',
			style: 'position:absolute;left:46px;top:148px;width:460px;height:73px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНастроитьВычетыПоНДФЛ',
			text: 'Настроить вычеты по НДФЛ',
			style: 'position:absolute;left:26px;top:294px;width:194px;height:15px;',
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'нарастающим итогом в течение налогового периода',
			style: 'position:absolute;left:26px;top:108px;width:298px;height:15px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'в пределах месячного дохода налогоплательщика',
			style: 'position:absolute;left:26px;top:128px;width:298px;height:15px;',
		},
			]
		},
					]
				},
				{
					title:'Гос. пособия',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСтавкиЕСН7',
			text: 'Государственные пособия',
			style: 'position:absolute;left:10px;top:8px;width:470px;height:25px;',
		},
		{
			id: 'СписокГосударственныеПособия',
			xtype: 'grid',
			style: 'position:absolute;left:10px;top:148px;width:496px;height:160px;',
			height: 160,width: 496,
			columns:
			[
				{
					text:'Вид пособия',
					width:'250',
					dataIndex:'ВидПособия',
					flex:1,
				},
				{
					text:'Размер',
					width:'90',
					dataIndex:'Размер',
					flex:1,
				},
				{
					text:'Применяется с',
					width:'100',
					dataIndex:'Период',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/НастройкаПараметровУчета/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'ВидПособия',
					},
					{
						name:'Размер',
					},
					{
						name:'Период',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('СписокГосударственныеПособия');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'label',
			name: 'НадписьПрочиеПособияФСС',
			text: 'Размеры государственных пособий',
			style: 'position:absolute;left:10px;top:129px;width:470px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОткрытьИндексацию',
			text: 'Индексировать пособия на детей...',
			style: 'position:absolute;left:10px;top:330px;width:190px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация9',
			text: 'Организация:',
			style: 'position:absolute;left:10px;top:52px;width:75px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'ОбособленноеПодразделение.Представление',
			width: 415,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:91px;top:52px;width:415px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаПередачиФССВыплатыПособий',
			width: 100,
			height: 19,
			style: 'position:absolute;left:208px;top:76px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаПередачиФССВыплатыПособий',
			text: 'Выплата пособий передана в ФСС с:',
			style: 'position:absolute;left:10px;top:76px;width:196px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:10px;top:362px;width:496px;height:105px;',
			height: 105,width: 496,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьМинимальнаяОплатаТрудаРФ1',
			text: 'По временной нетрудоспособности:',
			style: 'position:absolute;left:16px;top:27px;width:186px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПособиеПоВременнойНетрудоспособности',
			style: 'position:absolute;left:204px;top:27px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьМинимальнаяОплатаТрудаРФ2',
			text: 'По беременности и родам:',
			style: 'position:absolute;left:16px;top:52px;width:186px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПособиеПоБеременности',
			style: 'position:absolute;left:204px;top:52px;width:100px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаРазмеровОграниченияПособий',
			width: 80,
			height: 19,
			style: 'position:absolute;left:105px;top:74px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОкончанияДействияОграниченияПособий',
			text: 'НадписьОкончанияДействияОграниченияПособий',
			style: 'position:absolute;left:190px;top:74px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИсторияМаксимальныеРазмерыПособий',
			text: 'История изменения ...',
			style: 'position:absolute;left:362px;top:74px;width:114px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалаДействия2',
			text: 'Применяются с:',
			style: 'position:absolute;left:16px;top:74px;width:85px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'Надпись14',
			text: 'Максимальные размеры пособий (до 2010 года)',
			style: 'position:absolute;left:6px;top:6px;width:298px;height:16px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Прочие ставки',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСтавкаРефинансированияЦБ',
			text: 'Размер, %:',
			style: 'position:absolute;left:26px;top:73px;width:58px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СтавкаРефинансированияЦБ',
			style: 'position:absolute;left:110px;top:74px;width:80px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'СтавкаРефинансированияЦБДата',
			width: 80,
			height: 19,
			style: 'position:absolute;left:110px;top:98px;width:80px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'МинимальнаяОплатаТрудаРФ',
			style: 'position:absolute;left:110px;top:157px;width:80px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'МинимальнаяОплатаТрудаРФДата',
			width: 80,
			height: 19,
			style: 'position:absolute;left:110px;top:181px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтавкиЕСН1',
			text: 'Прочие ставки',
			style: 'position:absolute;left:10px;top:8px;width:180px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОкончанияДействияСтавкиРефинансирования',
			text: 'НадписьОкончанияДействияСтавкиРефинансирования',
			style: 'position:absolute;left:197px;top:98px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИсторияСтавкаРефинансированияЦБ',
			text: 'История изменения ...',
			style: 'position:absolute;left:366px;top:98px;width:114px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалаДействия3',
			text: 'Применяется с:',
			style: 'position:absolute;left:26px;top:98px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтавкаРефинансированияЦБ1',
			text: 'Размер: ',
			style: 'position:absolute;left:26px;top:157px;width:58px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьОкончанияДействияМРОТ',
			text: 'НадписьОкончанияДействияМРОТ',
			style: 'position:absolute;left:197px;top:181px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИсторияМРОТ',
			text: 'История изменения ...',
			style: 'position:absolute;left:366px;top:181px;width:114px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалаДействия4',
			text: 'Применяется с:',
			style: 'position:absolute;left:26px;top:181px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Минимальный размер оплаты труда',
			style: 'position:absolute;left:10px;top:136px;width:281px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'Надпись13',
			text: 'Ставка рефинансирования ЦБ РФ',
			style: 'position:absolute;left:10px;top:52px;width:281px;height:16px;',
		},
					]
				},
				{
					title:'Расчет ЕСН',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСтавкиЕСН2',
			text: 'Расчет ЕСН (применялся до 2010 года)',
			style: 'position:absolute;left:10px;top:8px;width:407px;height:25px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:10px;top:52px;width:75px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация.Представление',
			width: 419,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:87px;top:52px;width:419px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'НадписьИсторияЛьготаЕСН',
			text: 'История изменения ...',
			style: 'position:absolute;left:366px;top:133px;width:114px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'организация имеет право на льготу',
			style: 'position:absolute;left:26px;top:108px;width:206px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНачалаДействия6',
			text: 'Применяется с:',
			style: 'position:absolute;left:26px;top:133px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьОкончанияДействияЛьготаЕСН',
			text: 'НадписьОкончанияДействияЛьготаЕСН',
			style: 'position:absolute;left:234px;top:133px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ПериодЛьготаЕСН',
			width: 120,
			height: 19,
			style: 'position:absolute;left:109px;top:133px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтавкиЕСН8',
			text: 'Перейти к ставкам ЕСН ...',
			style: 'position:absolute;left:10px;top:165px;width:277px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись84',
			text: 'Льгота по ЕСН для организаций инвалидов',
			style: 'position:absolute;left:10px;top:87px;width:470px;height:19px;',
		},
					]
				},
				{
					title:'Управленческий учет',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьНастройкиУпрУчета',
			text: 'Управленческий учет зарплаты и персонала',
			style: 'position:absolute;left:10px;top:8px;width:470px;height:25px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'по структуре юридических лиц',
			style: 'position:absolute;left:42px;top:327px;width:179px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись81',
			text: 'Набор персонала ведется:',
			style: 'position:absolute;left:26px;top:306px;width:146px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьМетодПланированияУчетаЗатратНаПерсонал',
			text: 'Планирование и учет затрат:',
			style: 'position:absolute;left:26px;top:43px;width:162px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'МетодПланированияУчетаЗатратНаПерсонал.Представление',
			width: 316,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:190px;top:43px;width:316px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.НастройкаПараметровУчета.НастройкаПараметровУчетаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Расчет зарплаты по ответственным',
			style: 'position:absolute;left:26px;top:248px;width:206px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСписокРасчетчиковЗарплатыУпр',
			text: 'Показать список ответственных ...',
			style: 'position:absolute;left:289px;top:248px;width:191px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Показывать табельные номера в документах',
			style: 'position:absolute;left:26px;top:134px;width:256px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПоказыватьТабельныеНомераВДокументах1',
			text: 'При выборе этой настройки в формах документов\r\nбудет показываться колонка с табельным номером сотрудников.',
			style: 'position:absolute;left:42px;top:155px;width:438px;height:30px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Поддерживать несколько схем мотивации',
			style: 'position:absolute;left:26px;top:78px;width:256px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКоличествоДнейОтпускаВГод',
			text: 'Количество рабочих дней отпуска в год:',
			style: 'position:absolute;left:26px;top:277px;width:247px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'КоличествоДнейОтпускаВГод',
			style: 'position:absolute;left:278px;top:277px;width:43px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПоказыватьТабельныеНомераВДокументах2',
			text: 'При выборе этой настройки будет доступно начисление зарплаты по временной схеме мотивации.',
			style: 'position:absolute;left:42px;top:99px;width:438px;height:30px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Упрощенный учет взаиморасчетов',
			style: 'position:absolute;left:26px;top:193px;width:389px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьУпрощенныйУчетВзаиморасчетов1',
			text: 'Заработная плата будет считаться выплаченной при проведении документов «Зарплата к выплате», без создания платежных документов',
			style: 'position:absolute;left:42px;top:214px;width:438px;height:29px;text-align:left;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:522px;width:421px;height:25px;',
			height: 25,width: 421,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Показывать устаревшие параметры учета',
			style: 'position:absolute;left:6px;top:3px;width:283px;height:15px;',
		},
					]
				},
			]
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:387px;top:522px;width:317px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Применить',
				},
				'-',
				{
					text:'Закрыть',
					handler: function () {this.up('window').close();},
				},
				'-',
				{
					text:'Действие1',
				},
			]
		},
	]
	});
});