﻿Ext.require(['Данные.Отчеты.ВзаиморасчетыСКомиссионерами'], function () 
{
	Ext.define('Отчеты.ВзаиморасчетыСКомиссионерами.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:365px;height:239px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Группировки отчета',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'button',
			name: 'УстановитьВсе',
			text: '',
			style: 'position:absolute;left:333px;top:8px;width:24px;height:24px;',
		},
		{
			xtype: 'button',
			name: 'СнятьВсе',
			text: '',
			style: 'position:absolute;left:333px;top:37px;width:24px;height:24px;',
		},
		{
			id: 'Дерево',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:8px;width:320px;height:196px;',
			height: 196,width: 320,
			columns:
			[
				{
					text:'Представление поля',
					width:'209',
					dataIndex:'ПредставлениеПоля',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ВзаиморасчетыСКомиссионерами/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'ПредставлениеПоля',
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
						var грид = Ext.getCmp('Дерево');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ВзаиморасчетыСКомиссионерами.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ВзаиморасчетыСКомиссионерами.ФормаВыбораСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'button',
			name: 'ОК',
			text: 'ОК',
			style: 'position:absolute;left:168px;top:213px;width:76px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'Отмена',
			text: 'Отмена',
			style: 'position:absolute;left:253px;top:213px;width:75px;height:19px;',
		},
		],
	}],
	dockedItems:
	[
	]
	});
});