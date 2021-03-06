﻿Ext.require(['Данные.Обработки.НастройкаПараметровУчета'], function () 
{
	Ext.define('Обработки.НастройкаПараметровУчета.ФормаИстории',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:431px;height:292px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Форма',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'ТабличноеПоле',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:415px;height:227px;',
			height: 227,width: 415,
			columns:
			[
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
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ТабличноеПоле');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.НастройкаПараметровУчета.ФормаИсторииСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НастройкаПараметровУчета.ФормаИсторииСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:268px;width:431px;height:24px;',
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
					text:'Закрыть',
					handler: function () {this.up('window').close();},
				},
			]
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:431px;height:25px;',
			dock: 'top',
			items:
			[
				{
					text:'&Добавить',
				},
				'-',
				{
					text:'Удалить',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:37px;top:128px;width:145px;height:24px;',
			dock: 'top',
			items:
			[
				{
					text:'&Добавить',
				},
				{
					text:'Удалить',
				},
				{
					text:'Вывести список...',
				},
			]
		},
	]
	});
});