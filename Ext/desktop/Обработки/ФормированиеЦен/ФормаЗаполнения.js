﻿Ext.require(['Данные.Обработки.ФормированиеЦен'], function () 
{
	Ext.define('Обработки.ФормированиеЦен.ФормаЗаполнения',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:676px;height:338px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Обработка  Формирование цен',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:8px;width:660px;height:276px;',
			height: 276,width: 660,
			items:
			[
				{
					title:'Отбор',
					items:
					[
		{
			id: 'Отбор',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:646px;height:220px;',
			height: 220,width: 646,
			columns:
			[
				{
					text:'',
					width:'20',
					dataIndex:'Использование',
					flex:1,
				},
				{
					text:'Поле',
					width:'100',
					dataIndex:'Имя',
					flex:1,
				},
				{
					text:'Тип сравнения',
					width:'60',
					dataIndex:'ВидСравнения',
					flex:1,
				},
				{
					text:'Значение',
					width:'221',
					dataIndex:'Значение',
					flex:1,
				},
				{
					text:'С',
					width:'221',
					dataIndex:'ЗначениеС',
					flex:1,
				},
				{
					text:'По',
					width:'221',
					dataIndex:'ЗначениеПо',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ФормированиеЦен/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Использование',
					},
					{
						name:'Имя',
					},
					{
						name:'ВидСравнения',
					},
					{
						name:'Значение',
					},
					{
						name:'ЗначениеС',
					},
					{
						name:'ЗначениеПо',
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
						var грид = Ext.getCmp('Отбор');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ФормированиеЦен.ФормаЗаполненияСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ФормированиеЦен.ФормаЗаполненияСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:313px;width:676px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Выполнить',
				},
				'-',
				{
					text:'Закрыть',
					handler: function () {this.up('window').close();},
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:284px;width:660px;height:21px;',
			height: 21,width: 660,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Включать товары, для которых цены не установлены',
			style: 'position:absolute;left:0px;top:6px;width:321px;height:15px;',
		},
					]
				},
			]
		},
		],
	}],
	dockedItems:
	[
	]
	});
});