﻿Ext.require(['Данные.Справочники.ЛичныеКонтакты'], function () 
{
	Ext.define('Справочники.ЛичныеКонтакты.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:595px;height:387px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Личные контакты',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:505px;top:57px;width:40px;height:19px;text-align:center;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Код',
			width: 40,
			height: 19,
			style: 'position:absolute;left:547px;top:57px;width:40px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Представление:',
			style: 'position:absolute;left:8px;top:57px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Наименование',
			width: 400,
			height: 19,
			style: 'position:absolute;left:98px;top:57px;width:400px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:84px;width:579px;height:270px;',
			height: 270,width: 579,
			items:
			[
				{
					title:'Адреса и телефоны',
					items:
					[
		{
			id: 'КонтактнаяИнформация',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:24px;width:565px;height:220px;',
			height: 220,width: 565,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Тип',
					width:'100',
					dataIndex:'Тип',
					flex:1,
				},
				{
					text:'Вид',
					width:'172',
					dataIndex:'Вид',
					flex:1,
				},
				{
					text:'Представление',
					width:'243',
					dataIndex:'Представление',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'133',
					dataIndex:'Комментарий',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.ЛичныеКонтакты").data,
					fields: ['Картинка','Тип','Вид','Представление','Комментарий',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЛичныеКонтакты/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Тип',
					},
					{
						name:'Вид',
					},
					{
						name:'Представление',
					},
					{
						name:'Комментарий',
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
						var грид = Ext.getCmp('КонтактнаяИнформация');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ЛичныеКонтакты.ФормаЭлементаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ЛичныеКонтакты.ФормаЭлементаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Дополнительная информация',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:6px;width:565px;height:238px;',
			height: 238,width: 565,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textarea',
			hideLabel: true,
			disabled: false,
			name: 'Описание',
			style: 'position:absolute;left:0px;top:48px;width:565px;height:190px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаРождения',
			width: 80,
			height: 19,
			style: 'position:absolute;left:86px;top:0px;width:80px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Напоминать о дне рождения за:',
			style: 'position:absolute;left:186px;top:0px;width:184px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'КоличествоДнейДоНапоминания',
			style: 'position:absolute;left:376px;top:0px;width:40px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Прочее',
			style: 'position:absolute;left:0px;top:27px;width:565px;height:16px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Свойства',
					items:
					[
		{
			id: 'СвойстваИЗначения',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:24px;width:565px;height:220px;',
			height: 220,width: 565,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'ПометкаУдаления',
					flex:1,
				},
				{
					text:'Свойство',
					width:'146',
					dataIndex:'Свойство',
					flex:1,
				},
				{
					text:'Значение',
					width:'246',
					dataIndex:'Значение',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.ЛичныеКонтакты").data,
					fields: ['ПометкаУдаления','Свойство','Значение',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЛичныеКонтакты/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'ПометкаУдаления',
					},
					{
						name:'Свойство',
					},
					{
						name:'Значение',
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
						var грид = Ext.getCmp('СвойстваИЗначения');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ЛичныеКонтакты.ФормаЭлементаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ЛичныеКонтакты.ФормаЭлементаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Категории',
					items:
					[
		{
			id: 'Категории',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:24px;width:565px;height:220px;',
			height: 220,width: 565,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'ПометкаУдаления',
					flex:1,
				},
				{
					text:'',
					width:'21',
					dataIndex:'Принадлежность',
					flex:1,
				},
				{
					text:'Категория',
					width:'360',
					dataIndex:'Категория',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.ЛичныеКонтакты").data,
					fields: ['ПометкаУдаления','Принадлежность','Категория',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЛичныеКонтакты/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'ПометкаУдаления',
					},
					{
						name:'Принадлежность',
					},
					{
						name:'Категория',
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
						var грид = Ext.getCmp('Категории');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ЛичныеКонтакты.ФормаЭлементаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ЛичныеКонтакты.ФормаЭлементаСобытия");
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
			xtype: 'label',
			name: 'НадписьФИО',
			text: 'Фамилия И.О.:',
			style: 'position:absolute;left:8px;top:33px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Фамилия',
			width: 201,
			height: 19,
			style: 'position:absolute;left:98px;top:33px;width:201px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Имя',
			width: 139,
			height: 19,
			style: 'position:absolute;left:304px;top:33px;width:139px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Отчество',
			width: 139,
			height: 19,
			style: 'position:absolute;left:448px;top:33px;width:139px;height:19px;',
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:595px;height:25px;',
			dock: 'top',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Перейти',
					menu: [
				'-',
				{
					text:'Электронные письма',
				},
					]
				},
				'-',
				{
					text:'Написать письмо',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:362px;width:595px;height:25px;',
			dock: 'bottom',
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
	]
	});
});