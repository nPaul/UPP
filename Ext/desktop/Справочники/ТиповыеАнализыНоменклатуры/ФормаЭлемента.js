﻿Ext.require(['Данные.Справочники.ТиповыеАнализыНоменклатуры'], function () 
{
	Ext.define('Справочники.ТиповыеАнализыНоменклатуры.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:480px;height:309px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Типовые анализы номенклатуры',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:389px;top:57px;width:23px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Код',
			width: 55,
			height: 19,
			style: 'position:absolute;left:417px;top:57px;width:55px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:57px;width:80px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Наименование',
			width: 296,
			height: 19,
			style: 'position:absolute;left:88px;top:57px;width:296px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРодитель',
			text: 'Родитель:',
			style: 'position:absolute;left:8px;top:33px;width:80px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			trigger3Cls: 'x-form-search-trigger',
			name: 'Родитель.Представление',
			width: 384,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:88px;top:33px;width:384px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Справочники.ТиповыеАнализыНоменклатуры.ФормаЭлементаСобытия'], function ()
					{
						var объект = Ext.create("Справочники.ТиповыеАнализыНоменклатуры.ФормаЭлементаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Справочники.ТиповыеАнализыНоменклатуры.ФормаЭлементаСобытия'], function ()
					{
						var объект = Ext.create("Справочники.ТиповыеАнализыНоменклатуры.ФормаЭлементаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			id: 'ПоказателиАнализа',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:132px;width:464px;height:144px;',
			height: 144,width: 464,
			columns:
			[
				{
					text:'N',
					width:'43',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Показатель анализа',
					width:'414',
					dataIndex:'ПоказательАнализа',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.ТиповыеАнализыНоменклатуры").data,
					fields: ['НомерСтроки','ПоказательАнализа',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТиповыеАнализыНоменклатуры/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'НомерСтроки',
					},
					{
						name:'ПоказательАнализа',
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
						var грид = Ext.getCmp('ПоказателиАнализа');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТиповыеАнализыНоменклатуры.ФормаЭлементаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТиповыеАнализыНоменклатуры.ФормаЭлементаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'fieldset',
			title: 'Показатели анализа',
			style: 'position:absolute;left:8px;top:89px;width:464px;height:17px;',
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:480px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:284px;width:480px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'OK',
				},
				'-',
				{
					text:'Записать',
				},
				'-',
				{
					text:'Закрыть',
					handler: function () {this.up('window').close();},
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:107px;width:464px;height:24px;',
			dock: 'top',
			items:
			[
			]
		},
	]
	});
});