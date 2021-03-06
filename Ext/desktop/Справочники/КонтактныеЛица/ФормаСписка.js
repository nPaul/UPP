﻿Ext.require(['Данные.Справочники.КонтактныеЛица'], function () 
{
	Ext.define('Справочники.КонтактныеЛица.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:396px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Контактные лица',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:380px;height:280px;',
			height: 280,width: 380,
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
					text:'ФИО',
					width:'220',
					dataIndex:'ФИО',
					flex:1,
				},
				{
					text:'Дата рождения',
					width:'80',
					dataIndex:'ДатаРождения',
					flex:1,
				},
				{
					text:'Имя',
					width:'113',
					dataIndex:'Имя',
					flex:1,
				},
				{
					text:'Количество дней до напоминания',
					width:'80',
					dataIndex:'КоличествоДнейДоНапоминания',
					flex:1,
				},
				{
					text:'Напоминать о дне рождения',
					width:'20',
					dataIndex:'НапоминатьОДнеРождения',
					flex:1,
				},
				{
					text:'Описание',
					width:'120',
					dataIndex:'Описание',
					flex:1,
				},
				{
					text:'Отчество',
					width:'120',
					dataIndex:'Отчество',
					flex:1,
				},
				{
					text:'Пол',
					width:'80',
					dataIndex:'Пол.Представление',
					flex:1,
				},
				{
					text:'Фамилия',
					width:'120',
					dataIndex:'Фамилия',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.КонтактныеЛица").data,
					fields: ['Картинка','Код','ФИО','ДатаРождения','Имя','КоличествоДнейДоНапоминания','НапоминатьОДнеРождения','Описание','Отчество','Пол.Представление','Фамилия',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/КонтактныеЛица/ВыбратьПоСсылке/100', timeout: 200},
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
						name:'ФИО',
					},
					{
						name:'ДатаРождения',
					},
					{
						name:'Имя',
					},
					{
						name:'КоличествоДнейДоНапоминания',
					},
					{
						name:'НапоминатьОДнеРождения',
					},
					{
						name:'Описание',
					},
					{
						name:'Отчество',
					},
					{
						name:'Пол',
					},
					{
						name:'Фамилия',
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
						Ext.require(['Справочники.КонтактныеЛица.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.КонтактныеЛица.ФормаСпискаСобытия");
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
			style: 'position:absolute;left:0px;top:0px;width:396px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
	]
	});
});