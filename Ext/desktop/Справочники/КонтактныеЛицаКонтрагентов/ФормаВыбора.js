﻿Ext.require(['Данные.Справочники.КонтактныеЛицаКонтрагентов'], function () 
{
	Ext.define('Справочники.КонтактныеЛицаКонтрагентов.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:496px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочник Контактные лица контрагентов',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:480px;height:280px;',
			height: 280,width: 480,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Код',
					width:'40',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Наименование',
					width:'120',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Контрагент',
					width:'120',
					dataIndex:'Владелец',
					flex:1,
				},
				{
					text:'Должность',
					width:'120',
					dataIndex:'Должность',
					flex:1,
				},
				{
					text:'Роль',
					width:'120',
					dataIndex:'РольКонтактногоЛица.Представление',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'120',
					dataIndex:'Комментарий',
					flex:1,
				},
				{
					text:'Контактное лицо',
					width:'120',
					dataIndex:'КонтактноеЛицо.Представление',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.КонтактныеЛицаКонтрагентов").data,
					fields: ['Картинка','Код','Наименование','Владелец','Должность','РольКонтактногоЛица.Представление','Комментарий','КонтактноеЛицо.Представление',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/КонтактныеЛицаКонтрагентов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Код',
					},
					{
						name:'Наименование',
					},
					{
						name:'Владелец',
					},
					{
						name:'Должность',
					},
					{
						name:'РольКонтактногоЛица',
					},
					{
						name:'Комментарий',
					},
					{
						name:'КонтактноеЛицо',
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
						var грид = Ext.getCmp('СправочникСписок');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.КонтактныеЛицаКонтрагентов.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.КонтактныеЛицаКонтрагентов.ФормаВыбораСобытия");
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
			style: 'position:absolute;left:0px;top:0px;width:496px;height:25px;',
			dock: 'top',
			items:
			[
				{
					text:'Выбрать',
				},
				'-',
			]
		},
	]
	});
});