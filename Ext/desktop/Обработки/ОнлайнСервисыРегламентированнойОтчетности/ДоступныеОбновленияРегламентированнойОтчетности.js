﻿Ext.require(['Данные.Обработки.ОнлайнСервисыРегламентированнойОтчетности'], function () 
{
	Ext.define('Обработки.ОнлайнСервисыРегламентированнойОтчетности.ДоступныеОбновленияРегламентированнойОтчетности',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:439px;height:537px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Информация об обновлениях',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:512px;width:439px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
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
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:109px;width:423px;height:395px;',
			height: 395,width: 423,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:62px;width:423px;height:333px;',
			height: 333,width: 423,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'',
					items:
					[
		{
			id: 'ДеревоОтчетов',
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:0px;width:423px;height:333px;',
			height: 333,width: 423,
			columns:
			[
				{
					text:'Отчет',
					width:'170',
					dataIndex:'Отчет',
					flex:1,
				},
				{
					text:'Это группа',
					width:'100',
					dataIndex:'ЭтоГруппа',
					flex:1,
				},
				{
					text:'',
					width:'100',
					dataIndex:'ВнешнийОтчетВерсия',
					flex:1,
				},
				{
					text:'Источник отчета',
					width:'100',
					dataIndex:'ИсточникОтчета',
					flex:1,
				},
				{
					text:'URL',
					width:'100',
					dataIndex:'URL',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОнлайнСервисыРегламентированнойОтчетности/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Отчет',
					},
					{
						name:'ЭтоГруппа',
					},
					{
						name:'ВнешнийОтчетВерсия',
					},
					{
						name:'ИсточникОтчета',
					},
					{
						name:'URL',
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
						var грид = Ext.getCmp('ДеревоОтчетов');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ОнлайнСервисыРегламентированнойОтчетности.ДоступныеОбновленияРегламентированнойОтчетностиСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ОнлайнСервисыРегламентированнойОтчетности.ДоступныеОбновленияРегламентированнойОтчетностиСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Доступные для загрузки дополнения отсутствуют.',
			style: 'position:absolute;left:0px;top:0px;width:423px;height:333px;text-align:center;',
		},
					]
				},
			]
		},
		{
			xtype: 'fieldset',
			title: 'Дополнения для текущей версии конфигурации',
			style: 'position:absolute;left:0px;top:15px;width:423px;height:16px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:38px;width:423px;height:24px;',
			height: 24,width: 423,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьОткрытьWebСтраницу',
			text: 'Открыть Web-страницу текущей версии',
			style: 'position:absolute;left:0px;top:0px;width:423px;height:15px;text-align:left;',
		},
					]
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'button',
			name: 'КнопкаПерейтиКФормеОбновленияКонфигурации',
			text: 'Перейти к обновлению ...',
			style: 'position:absolute;left:8px;top:83px;width:423px;height:26px;',
		},
		{
			xtype: 'fieldset',
			title: 'Обновление конфигурации',
			style: 'position:absolute;left:8px;top:12px;width:423px;height:16px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:58px;width:423px;height:25px;',
			height: 25,width: 423,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьОткрытьДополнительнуюИнформацию',
			text: 'Показать отличия от текущей версии',
			style: 'position:absolute;left:0px;top:0px;width:423px;height:17px;text-align:left;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:423px;height:18px;',
			height: 18,width: 423,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьОбновлениеДоступно',
			text: 'Доступно обновление до версии:',
			style: 'position:absolute;left:0px;top:1px;width:175px;height:17px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОбновлениеДоступно1',
			text: 'Вы используете последнюю версию конфигурации. Обновление не требуется.',
			style: 'position:absolute;left:0px;top:1px;width:423px;height:17px;',
		},
					]
				},
				{
					title:'Обновление не требуется',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьПоследняяВерсия',
			text: 'НадписьПоследняяВерсия',
			style: 'position:absolute;left:178px;top:1px;width:245px;height:17px;text-align:left;',
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