﻿Ext.require(['Данные.Отчеты.АнализСобытийИИсточниковИнформацииПокупателей'], function () 
{
	Ext.define('Отчеты.АнализСобытийИИсточниковИнформацииПокупателей.ФормаНастройкиДиаграммы',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:602px;height:301px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройка диаграммы ""Анализ событий и источников информации покупателей""',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'fieldset',
			title: 'Серии и точки диаграммы',
			style: 'position:absolute;left:8px;top:8px;width:340px;height:16px;',
		},
		{
			xtype: 'fieldset',
			title: 'Показатель диаграммы',
			style: 'position:absolute;left:354px;top:8px;width:240px;height:16px;',
		},
		{
			id: 'СерииИТочкиДиаграммы',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:28px;width:340px;height:240px;',
			height: 240,width: 340,
			columns:
			[
				{
					text:'Серии',
					width:'60',
					dataIndex:'ИспользованиеСерии',
					flex:1,
				},
				{
					text:'Точки',
					width:'60',
					dataIndex:'ИспользованиеТочки',
					flex:1,
				},
				{
					text:'Представление',
					width:'220',
					dataIndex:'Представление',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/АнализСобытийИИсточниковИнформацииПокупателей/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'ИспользованиеСерии',
					},
					{
						name:'ИспользованиеТочки',
					},
					{
						name:'Представление',
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
						var грид = Ext.getCmp('СерииИТочкиДиаграммы');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.АнализСобытийИИсточниковИнформацииПокупателей.ФормаНастройкиДиаграммыСобытия'], function ()
						{
							var obj = Ext.create("Справочники.АнализСобытийИИсточниковИнформацииПокупателей.ФормаНастройкиДиаграммыСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			id: 'ПоказателиДиаграммы',
			xtype: 'grid',
			style: 'position:absolute;left:354px;top:28px;width:240px;height:240px;',
			height: 240,width: 240,
			columns:
			[
				{
					text:'',
					width:'20',
					dataIndex:'Использование',
					flex:1,
				},
				{
					text:'Представление',
					width:'220',
					dataIndex:'Представление',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/АнализСобытийИИсточниковИнформацииПокупателей/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Использование',
					},
					{
						name:'Представление',
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
						var грид = Ext.getCmp('ПоказателиДиаграммы');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.АнализСобытийИИсточниковИнформацииПокупателей.ФормаНастройкиДиаграммыСобытия'], function ()
						{
							var obj = Ext.create("Справочники.АнализСобытийИИсточниковИнформацииПокупателей.ФормаНастройкиДиаграммыСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:276px;width:602px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'ОК',
				},
				'-',
				{
					text:'Закрыть',
					handler: function () {this.up('window').close();},
				},
			]
		},
	]
	});
});