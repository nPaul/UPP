﻿Ext.require(['Данные.Обработки.ЗагрузкаДанныхИзТабличногоДокумента'], function () 
{
	Ext.define('Обработки.ЗагрузкаДанныхИзТабличногоДокумента.ФормаРедактированияСобытий',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:718px;height:292px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Форма редактирования выражения',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'textarea',
			hideLabel: true,
			disabled: false,
			name: 'НадписьТекстВыражения',
			style: 'position:absolute;left:8px;top:8px;width:702px;height:105px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:111px;width:702px;height:148px;',
			height: 148,width: 702,
			items:
			[
				{
					title:'Перед записью объекта',
				},
				{
					title:'При записи объекта',
				},
				{
					title:'После добавления строки',
				},
			]
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:267px;width:718px;height:25px;',
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
					text:'Отмена',
				},
			]
		},
	]
	});
});