﻿Ext.require(['Данные.Отчеты.СравнительныйАнализОстатковНаСчетахБюджетирования'], function () 
{
	Ext.define('Отчеты.СравнительныйАнализОстатковНаСчетахБюджетирования.ФормаНастройка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:490px;height:401px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: '',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:8px;width:474px;height:360px;',
			height: 360,width: 474,
			items:
			[
				{
					title:'Общие',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Раскрашивать измерения',
			style: 'position:absolute;left:286px;top:254px;width:160px;height:15px;',
		},
		{
			id: 'Показатели',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:214px;width:260px;height:120px;',
			height: 120,width: 260,
			columns:
			[
				{
					text:'№',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Показатель',
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
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СравнительныйАнализОстатковНаСчетахБюджетирования/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'НомерСтроки',
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
						var грид = Ext.getCmp('Показатели');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СравнительныйАнализОстатковНаСчетахБюджетирования.ФормаНастройкаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СравнительныйАнализОстатковНаСчетахБюджетирования.ФормаНастройкаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:190px;width:460px;height:24px;',
			items:
			[
				{
					text:'&Переместить вверх',
				},
				{
					text:'&Переместить вниз',
				},
				{
					text:'Установить все',
				},
				{
					text:'Снять все',
				},
			]
		},
		{
			xtype: 'fieldset',
			title: 'Сценарии для сравнения',
			style: 'position:absolute;left:6px;top:6px;width:460px;height:16px;',
		},
		{
			id: 'ТаблицаСценарии',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:46px;width:460px;height:120px;',
			height: 120,width: 460,
			columns:
			[
				{
					text:'№',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Вид данных',
					width:'100',
					dataIndex:'ВидДанных',
					flex:1,
				},
				{
					text:'Сценарий',
					width:'247',
					dataIndex:'Сценарий',
					flex:1,
				},
				{
					text:'Дата остатка',
					width:'80',
					dataIndex:'ДатаКон',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СравнительныйАнализОстатковНаСчетахБюджетирования/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'НомерСтроки',
					},
					{
						name:'ВидДанных',
					},
					{
						name:'Сценарий',
					},
					{
						name:'ДатаКон',
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
						var грид = Ext.getCmp('ТаблицаСценарии');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СравнительныйАнализОстатковНаСчетахБюджетирования.ФормаНастройкаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СравнительныйАнализОстатковНаСчетахБюджетирования.ФормаНастройкаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выводить отклонения, абс.',
			style: 'position:absolute;left:286px;top:214px;width:160px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выводить отклонения, %',
			style: 'position:absolute;left:286px;top:234px;width:148px;height:15px;',
		},
		{
			xtype: 'fieldset',
			title: 'Показатели для сравнения',
			style: 'position:absolute;left:6px;top:174px;width:460px;height:16px;',
		},
					]
				},
				{
					title:'Группировки',
					items:
					[
		{
			id: 'ИзмеренияСтроки',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:25px;width:460px;height:309px;',
			height: 309,width: 460,
			columns:
			[
				{
					text:'Поле',
					width:'100',
					dataIndex:'Поле',
					flex:1,
				},
				{
					text:'Тип',
					width:'40',
					dataIndex:'Тип',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СравнительныйАнализОстатковНаСчетахБюджетирования/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Поле',
					},
					{
						name:'Тип',
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
						var грид = Ext.getCmp('ИзмеренияСтроки');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СравнительныйАнализОстатковНаСчетахБюджетирования.ФормаНастройкаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СравнительныйАнализОстатковНаСчетахБюджетирования.ФормаНастройкаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Отбор',
					items:
					[
		{
			id: 'Отбор',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:24px;width:460px;height:310px;',
			height: 310,width: 460,
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
					width:'120',
					dataIndex:'Имя',
					flex:1,
				},
				{
					text:'Тип сравнения',
					width:'80',
					dataIndex:'ВидСравнения',
					flex:1,
				},
				{
					text:'Значение',
					width:'240',
					dataIndex:'Значение',
					flex:1,
				},
				{
					text:'С',
					width:'120',
					dataIndex:'ЗначениеС',
					flex:1,
				},
				{
					text:'По',
					width:'120',
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
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СравнительныйАнализОстатковНаСчетахБюджетирования/ВыбратьПоСсылке/100', timeout: 200},
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
						Ext.require(['Справочники.СравнительныйАнализОстатковНаСчетахБюджетирования.ФормаНастройкаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СравнительныйАнализОстатковНаСчетахБюджетирования.ФормаНастройкаСобытия");
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
			style: 'position:absolute;left:0px;top:376px;width:490px;height:25px;',
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
				'-',
				{
					text:'Справка',
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