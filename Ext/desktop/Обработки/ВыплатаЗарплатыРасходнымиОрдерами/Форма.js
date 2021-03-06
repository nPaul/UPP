﻿Ext.require(['Данные.Обработки.ВыплатаЗарплатыРасходнымиОрдерами'], function () 
{
	Ext.define('Обработки.ВыплатаЗарплатыРасходнымиОрдерами.Форма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:600px;height:375px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Выплата зарплаты расходными ордерами',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:6px;width:72px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Организация.Представление',
			width: 192,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:80px;top:6px;width:192px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'НадписьПлатежнаяВедомость',
			text: 'Платежная ведомость:',
			style: 'position:absolute;left:280px;top:6px;width:118px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'ПлатежнаяВедомость.Представление',
			width: 192,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:400px;top:6px;width:192px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			id: 'ТабличноеПолеРКО',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:73px;width:584px;height:198px;',
			height: 198,width: 584,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'',
					width:'20',
					dataIndex:'Отметка',
					flex:1,
				},
				{
					text:'Сотрудник',
					width:'220',
					dataIndex:'ФизЛицо',
					flex:1,
				},
				{
					text:'Сумма',
					width:'80',
					dataIndex:'Сумма',
					flex:1,
				},
				{
					text:'Проведено по кассе документом',
					width:'220',
					dataIndex:'РКО',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ВыплатаЗарплатыРасходнымиОрдерами/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Отметка',
					},
					{
						name:'ФизЛицо',
					},
					{
						name:'Сумма',
					},
					{
						name:'РКО',
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
						var грид = Ext.getCmp('ТабличноеПолеРКО');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'fieldset',
			title: 'Выплаченные суммы',
			style: 'position:absolute;left:8px;top:33px;width:584px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаРКО',
			text: 'Проставить дату:',
			style: 'position:absolute;left:170px;top:299px;width:93px;height:19px;text-align:left;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаРКО',
			width: 120,
			height: 19,
			style: 'position:absolute;left:263px;top:299px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНомерПервогоРКО',
			text: 'Нумеровать с:',
			style: 'position:absolute;left:8px;top:299px;width:78px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НомерПервогоРКО',
			width: 80,
			height: 19,
			style: 'position:absolute;left:86px;top:299px;width:80px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Формирование расходных кассовых ордеров',
			style: 'position:absolute;left:8px;top:279px;width:584px;height:16px;',
		},
		{
			xtype: 'button',
			name: 'Создать',
			text: 'Создать документы',
			style: 'position:absolute;left:400px;top:323px;width:120px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			trigger3Cls: 'x-form-search-trigger',
			name: 'Касса.Представление',
			width: 297,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:86px;top:323px;width:297px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия'], function ()
					{
						var объект = Ext.create("Обработки.ВыплатаЗарплатыРасходнымиОрдерами.ФормаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Касса:',
			style: 'position:absolute;left:8px;top:323px;width:78px;height:19px;',
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:350px;width:600px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Провести документы',
				},
				'-',
				{
					text:'Закрыть',
					handler: function () {this.up('window').close();},
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:49px;width:584px;height:24px;',
			dock: 'top',
			items:
			[
				'-',
				{
					text:'Установить флаги',
				},
				{
					text:'Снять флаги',
				},
				{
					text:'Инвертировать',
				},
				'-',
				{
					text:'Обновить',
				},
			]
		},
	]
	});
});