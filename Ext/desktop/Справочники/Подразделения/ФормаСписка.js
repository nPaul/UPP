﻿Ext.require(['Данные.Справочники.Подразделения'], function () 
{
	Ext.define('Справочники.Подразделения.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:858px;height:580px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Структура предприятия',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'Подразделения',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:82px;width:410px;height:490px;',
			height: 490,width: 410,
			columns:
			[
				{
					text:'Наименование',
					width:'181',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Код',
					width:'76',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Подразделения юридических лиц',
					width:'206',
					dataIndex:'ПодразделенияОрганизаций',
					flex:1,
				},
				{
					text:'Порядок',
					width:'100',
					dataIndex:'Порядок',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.Подразделения").data,
					fields: ['Наименование','Код','ПодразделенияОрганизаций','Порядок',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Подразделения/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Наименование',
					},
					{
						name:'Код',
					},
					{
						name:'ПодразделенияОрганизаций',
					},
					{
						name:'Порядок',
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
						var грид = Ext.getCmp('Подразделения');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.Подразделения.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.Подразделения.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'label',
			name: 'НадписьСтруктураПредприятия',
			text: ' Структура Предприятия',
			style: 'position:absolute;left:8px;top:33px;width:410px;height:20px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтруктураПодразделенийОрганизаций',
			text: ' Подразделения организаций (юридических лиц)',
			style: 'position:absolute;left:433px;top:33px;width:417px;height:20px;',
		},
		{
			id: 'ПодразделенияОрганизаций',
			xtype: 'grid',
			style: 'position:absolute;left:433px;top:82px;width:417px;height:490px;',
			height: 490,width: 417,
			columns:
			[
				{
					text:'Организация',
					width:'137',
					dataIndex:'Организация',
					flex:1,
				},
				{
					text:'Наименование',
					width:'195',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Код',
					width:'65',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Подразделения',
					width:'135',
					dataIndex:'Подразделения',
					flex:1,
				},
				{
					text:'Несколько подразделений',
					width:'100',
					dataIndex:'НесколькоПодразделений',
					flex:1,
				},
				{
					text:'Порядок',
					width:'49',
					dataIndex:'Порядок',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.Подразделения").data,
					fields: ['Организация','Наименование','Код','Подразделения','НесколькоПодразделений','Порядок',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Подразделения/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Организация',
					},
					{
						name:'Наименование',
					},
					{
						name:'Код',
					},
					{
						name:'Подразделения',
					},
					{
						name:'НесколькоПодразделений',
					},
					{
						name:'Порядок',
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
						var грид = Ext.getCmp('ПодразделенияОрганизаций');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.Подразделения.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.Подразделения.ФормаСпискаСобытия");
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
			style: 'position:absolute;left:0px;top:0px;width:858px;height:25px;',
			dock: 'top',
			items:
			[
				{
					text:'Закрыть',
					handler: function () {this.up('window').close();},
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:433px;top:58px;width:322px;height:24px;',
			dock: 'top',
			items:
			[
				{
					text:'Упорядочить по: Код',
				},
				{
					text:'Упорядочить по: Наименование',
				},
				{
					text:'Упорядочить по: Порядок',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:58px;width:410px;height:24px;',
			dock: 'top',
			items:
			[
				'-',
				{
					text:'Изменить',
				},
				{
					text:'',
				},
				'-',
				'-',
				{
					text:'',
				},
				{
					text:'',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:755px;top:58px;width:95px;height:24px;',
			dock: 'top',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Организации...',
				},
			]
		},
	]
	});
});