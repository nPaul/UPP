﻿Ext.require(['Данные.Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет'], function () 
{
	Ext.define('Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.Форма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:674px;height:451px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Инвентарная книга ОС (бухгалтерский учет)',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Организация:',
			style: 'position:absolute;left:344px;top:33px;width:70px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'Период с:',
			style: 'position:absolute;left:8px;top:34px;width:50px;height:19px;text-align:right;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'НачалоПериода',
			width: 80,
			height: 19,
			style: 'position:absolute;left:63px;top:34px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'по:',
			style: 'position:absolute;left:148px;top:34px;width:15px;height:19px;text-align:right;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'КонецПериода',
			width: 80,
			height: 19,
			style: 'position:absolute;left:168px;top:34px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаВыбораПериода',
			text: '...',
			style: 'position:absolute;left:253px;top:34px;width:19px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:134px;width:658px;height:309px;',
			height: 309,width: 658,
			items:
			[
				{
					title:'Страницы',
				},
				{
					title:'Обложка',
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Подразделение:',
			style: 'position:absolute;left:14px;top:82px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Подразделение.Представление',
			width: 220,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:110px;top:82px;width:220px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'МОЛ:',
			style: 'position:absolute;left:14px;top:107px;width:28px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'МОЛ.Представление',
			width: 220,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:110px;top:107px;width:220px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Ответственный:',
			style: 'position:absolute;left:351px;top:82px;width:85px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Ответственный.Представление',
			width: 220,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:446px;top:82px;width:220px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'fieldset',
			title: 'Отбор:',
			style: 'position:absolute;left:8px;top:61px;width:322px;height:16px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Организация.Представление',
			width: 220,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:446px;top:33px;width:220px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ИнвентарнаяКнигаОСБухгалтерскийУчет.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'fieldset',
			title: 'Дополнительно:',
			style: 'position:absolute;left:344px;top:61px;width:322px;height:16px;',
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:674px;height:25px;',
			dock: 'top',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
				{
					text:'Сформировать',
				},
				'-',
					]
				},
				'-',
				{
					text:'Сформировать',
				},
				'-',
				{
					text:'Сохранить значения...',
				},
				{
					text:'Восстановить значения...',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
	]
	});
});