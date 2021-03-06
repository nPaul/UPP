﻿Ext.require(['Данные.Обработки.РедактированиеКонтактнойИнформации'], function () 
{
	Ext.define('Обработки.РедактированиеКонтактнойИнформации.ФормаЗаписи',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:330px;height:245px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Другое',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'label',
			name: 'Надпись16',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:193px;width:94px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 220,
			height: 19,
			style: 'position:absolute;left:102px;top:193px;width:220px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:330px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:220px;width:330px;height:25px;',
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
			xtype: 'label',
			name: 'НадписьНачения',
			text: 'Значение:',
			style: 'position:absolute;left:14px;top:105px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textarea',
			hideLabel: true,
			disabled: false,
			name: 'Представление',
			style: 'position:absolute;left:102px;top:105px;width:220px;height:80px;',
		},
		{
			xtype: 'fieldset',
			title: 'Значение',
			style: 'position:absolute;left:8px;top:85px;width:314px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОбъект',
			text: 'Объект:',
			style: 'position:absolute;left:8px;top:33px;width:94px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись18',
			text: 'Вид прочего:',
			style: 'position:absolute;left:8px;top:61px;width:94px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Вид',
			width: 220,
			height: 19,
			style: 'position:absolute;left:102px;top:61px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Объект',
			width: 220,
			height: 19,
			style: 'position:absolute;left:102px;top:33px;width:220px;height:19px;',
		},
		],
	}],
	dockedItems:
	[
	]
	});
});