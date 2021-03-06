﻿Ext.require(['Данные.Отчеты.РегламентированныйОтчетЕСН'], function () 
{
	Ext.define('Отчеты.РегламентированныйОтчетЕСН.ФормаОтчета2007Кв1',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:721px;height:491px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Декларация по ЕСН',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'label',
			name: '_ИндикаторВнешнегоОтчета',
			text: 'Внешний отчет',
			style: 'position:absolute;left:635px;top:6px;width:78px;height:15px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:124px;width:705px;height:310px;',
			height: 310,width: 705,
			items:
			[
				{
					title:'Титульный',
				},
				{
					title:'Раздел 1',
				},
				{
					title:'Раздел 2',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:260px;width:691px;height:24px;',
			height: 24,width: 691,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'combobox',
			style: 'position:absolute;left:0px;top:5px;width:232px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПолеВводаЗначениеКорректировкиРаздел2',
			style: 'position:absolute;left:237px;top:5px;width:117px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ПолеВводаКомментарийРаздел2',
			width: 333,
			height: 19,
			style: 'position:absolute;left:358px;top:5px;width:333px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Раздел 2.1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись33',
			text: 'Дополнительные строки:',
			style: 'position:absolute;left:393px;top:265px;width:136px;height:19px;text-align:left;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:260px;width:691px;height:24px;',
			height: 24,width: 691,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'combobox',
			style: 'position:absolute;left:0px;top:5px;width:232px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПолеВводаЗначениеКорректировкиРаздел21',
			style: 'position:absolute;left:237px;top:5px;width:117px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ПолеВводаКомментарийРаздел21',
			width: 333,
			height: 19,
			style: 'position:absolute;left:358px;top:5px;width:333px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Раздел 2.1 (продолжение)',
				},
				{
					title:'Раздел 3',
					items:
					[
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиРаздел3',
			text: 'Добавить',
			style: 'position:absolute;left:531px;top:265px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиРаздел3',
			text: 'Удалить',
			style: 'position:absolute;left:617px;top:265px;width:80px;height:19px;',
		},
					]
				},
				{
					title:'Раздел 3.1',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:74px;width:705px;height:50px;',
			height: 50,width: 705,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПолеВводаТочностьЕдиницыИзмерения',
			style: 'position:absolute;left:230px;top:0px;width:32px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ПолеВводаДатаСдачи',
			width: 80,
			height: 19,
			style: 'position:absolute;left:86px;top:24px;width:80px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:86px;top:0px;width:80px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Отключить авторасчет вычисляемых ячеек',
			style: 'position:absolute;left:171px;top:24px;width:247px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:428px;top:24px;width:116px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'НомерКорректировки',
			style: 'position:absolute;left:559px;top:24px;width:49px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Внешние данные',
			style: 'position:absolute;left:270px;top:0px;width:105px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:434px;width:705px;height:24px;',
			height: 24,width: 705,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:183px;top:5px;width:80px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 442,
			height: 19,
			style: 'position:absolute;left:263px;top:5px;width:442px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Статус.Представление',
			width: 119,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:47px;top:5px;width:119px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.РегламентированныйОтчетЕСН.ФормаОтчета2007Кв1События'], function ()
					{
						var объект = Ext.create("Отчеты.РегламентированныйОтчетЕСН.ФормаОтчета2007Кв1События");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.РегламентированныйОтчетЕСН.ФормаОтчета2007Кв1События'], function ()
					{
						var объект = Ext.create("Отчеты.РегламентированныйОтчетЕСН.ФормаОтчета2007Кв1События");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:705px;height:37px;',
			height: 37,width: 705,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:2px;top:0px;width:703px;height:35px;',
			height: 35,width: 703,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
					]
				},
			]
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
			style: 'position:absolute;left:0px;top:0px;width:721px;height:25px;',
			dock: 'top',
			items:
			[
				{
					text:'Заполнить',
				},
				'-',
				'-',
				'-',
				'-',
				{
					text:'Настройка...',
				},
				'-',
				{
					text:'Поиск',
				},
				'-',
				{
					text:'Обновить',
				},
				'-',
				{
					text:'Расширить поле бланка',
				},
				'-',
				{
					text:'Расшифровка',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:466px;width:721px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
			]
		},
	]
	});
});