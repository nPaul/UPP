﻿Ext.require(['Данные.Справочники.СотрудникиОрганизаций'], function () 
{
	Ext.define('Справочники.СотрудникиОрганизаций.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:1000px;height:580px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Сотрудники',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:276px;top:159px;width:716px;height:249px;',
			height: 249,width: 716,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:25px;width:716px;height:150px;',
			height: 150,width: 716,
			columns:
			[
				{
					text:'Сотрудники',
					width:'100',
					dataIndex:'Группа',
					flex:1,
				},
				{
					text:'Наименование',
					width:'142',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Код (Таб. №)',
					width:'71',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Организация',
					width:'126',
					dataIndex:'ОбособленноеПодразделение.Представление',
					flex:1,
				},
				{
					text:'Подразделение',
					width:'123',
					dataIndex:'Подразделение',
					flex:1,
				},
				{
					text:'Должность',
					width:'120',
					dataIndex:'Должность.Представление',
					flex:1,
				},
				{
					text:'Вид договора',
					width:'140',
					dataIndex:'Состояние',
					flex:1,
				},
				{
					text:'Принят',
					width:'60',
					dataIndex:'ДатаПриема',
					flex:1,
				},
				{
					text:'Уволен',
					width:'60',
					dataIndex:'ДатаУвольнения',
					flex:1,
				},
				{
					text:'Аванс',
					width:'60',
					dataIndex:'Аванс',
					flex:1,
				},
				{
					text:'Номер лицевого счета',
					width:'120',
					dataIndex:'НомерЛицевогоСчета',
					flex:1,
				},
				{
					text:'Банк',
					width:'100',
					dataIndex:'Банк',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.СотрудникиОрганизаций").data,
					fields: ['Группа','Наименование','Код','ОбособленноеПодразделение.Представление','Подразделение','Должность.Представление','Состояние','ДатаПриема','ДатаУвольнения','Аванс','НомерЛицевогоСчета','Банк',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СотрудникиОрганизаций/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Группа',
					},
					{
						name:'Наименование',
					},
					{
						name:'Код',
					},
					{
						name:'ОбособленноеПодразделение',
					},
					{
						name:'Подразделение',
					},
					{
						name:'Должность',
					},
					{
						name:'Состояние',
					},
					{
						name:'ДатаПриема',
					},
					{
						name:'ДатаУвольнения',
					},
					{
						name:'Аванс',
					},
					{
						name:'НомерЛицевогоСчета',
					},
					{
						name:'Банк',
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
						Ext.require(['Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:74px;top:0px;width:216px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:28px;width:175px;height:24px;',
			items:
			[
				{
					text:'Наименованию',
				},
				{
					text:'Подразделению',
				},
				{
					text:'Должности',
				},
				{
					text:'Дате приема',
				},
				{
					text:'Таб. номеру',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:0px;top:0px;width:70px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:180px;width:716px;height:67px;',
			height: 67,width: 716,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаОстаткаОтпусков',
			width: 80,
			height: 19,
			style: 'position:absolute;left:636px;top:0px;width:80px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:262px;height:539px;',
			height: 539,width: 262,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:24px;width:262px;height:515px;',
			height: 515,width: 262,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'По группам',
					items:
					[
		{
			id: 'СправочникДерево',
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:0px;width:262px;height:515px;',
			height: 515,width: 262,
			columns:
			[
				{
					text:'Наименование',
					width:'100',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.СотрудникиОрганизаций").data,
					fields: ['Наименование',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СотрудникиОрганизаций/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Наименование',
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
						var грид = Ext.getCmp('СправочникДерево');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:20px;top:113px;width:182px;height:24px;',
			items:
			[
				{
					text:'Выбрать группу',
				},
				'-',
				{
					text:'',
				},
				{
					text:'',
				},
				{
					text:'Изменить',
				},
				{
					text:'Установить пометку удаления',
				},
				{
					text:'',
				},
				{
					text:'Обновить',
				},
			]
		},
					]
				},
				{
					title:'По подразделениям',
					items:
					[
		{
			id: 'ПодразделенияОрганизаций',
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:0px;width:262px;height:515px;',
			height: 515,width: 262,
			columns:
			[
				{
					text:'Организация',
					width:'137',
					dataIndex:'Организация.Представление',
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
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.СотрудникиОрганизаций").data,
					fields: ['Организация.Представление','Наименование','Код',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СотрудникиОрганизаций/ВыбратьПоСсылке/100', timeout: 200},
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
						Ext.require(['Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:33px;top:166px;width:203px;height:24px;',
			items:
			[
				{
					text:'&Добавить',
				},
				{
					text:'',
				},
				{
					text:'Изменить',
				},
				{
					text:'Установить пометку удаления',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Обновить',
				},
			]
		},
					]
				},
				{
					title:'По виду договора',
					items:
					[
		{
			id: 'ВидыДоговоров',
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:0px;width:262px;height:515px;',
			height: 515,width: 262,
			columns:
			[
				{
					text:'Наименование',
					width:'100',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Вид договора',
					width:'100',
					dataIndex:'ВидДоговора.Представление',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.СотрудникиОрганизаций").data,
					fields: ['Наименование','ВидДоговора.Представление',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СотрудникиОрганизаций/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Наименование',
					},
					{
						name:'ВидДоговора',
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
						var грид = Ext.getCmp('ВидыДоговоров');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия");
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
			xtype: 'combobox',
			style: 'position:absolute;left:0px;top:0px;width:262px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:276px;top:414px;width:716px;height:158px;',
			height: 158,width: 716,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Форма медицинского страхования',
					items:
					[
		{
			id: 'МедицинскиеСтраховыеПолисы',
			xtype: 'grid',
			style: 'position:absolute;left:1px;top:50px;width:715px;height:108px;',
			height: 108,width: 715,
			columns:
			[
				{
					text:'Серия',
					width:'80',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Номер',
					width:'80',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Выдан',
					width:'80',
					dataIndex:'ДатаВыдачиПолиса',
					flex:1,
				},
				{
					text:'До',
					width:'80',
					dataIndex:'ДатаОкончанияПолиса',
					flex:1,
				},
				{
					text:'Вид страхования',
					width:'100',
					dataIndex:'ВидСтрахования',
					flex:1,
				},
				{
					text:'Программа страхования',
					width:'130',
					dataIndex:'ПрограммаСтрахования',
					flex:1,
				},
				{
					text:'Родственник',
					width:'120',
					dataIndex:'Родственник',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.СотрудникиОрганизаций").data,
					fields: ['Код','Наименование','ДатаВыдачиПолиса','ДатаОкончанияПолиса','ВидСтрахования','ПрограммаСтрахования','Родственник',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СотрудникиОрганизаций/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Код',
					},
					{
						name:'Наименование',
					},
					{
						name:'ДатаВыдачиПолиса',
					},
					{
						name:'ДатаОкончанияПолиса',
					},
					{
						name:'ВидСтрахования',
					},
					{
						name:'ПрограммаСтрахования',
					},
					{
						name:'Родственник',
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
						var грид = Ext.getCmp('МедицинскиеСтраховыеПолисы');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Форма остатков отпусков',
					items:
					[
		{
			id: 'ОстаткиОтпусковТекущегоСотрудника',
			xtype: 'grid',
			style: 'position:absolute;left:1px;top:81px;width:715px;height:77px;',
			height: 77,width: 715,
			columns:
			[
				{
					text:'Вид ежегодного отпуска',
					width:'100',
					dataIndex:'ВидЕжегодногоОтпуска',
					flex:1,
				},
				{
					text:'Год работы',
					width:'100',
					dataIndex:'ГодРаботы',
					flex:1,
				},
				{
					text:'С',
					width:'80',
					dataIndex:'ДатаНачалаРабочегоГода',
					flex:1,
				},
				{
					text:'По',
					width:'80',
					dataIndex:'ДатаОкончанияРабочегоГода',
					flex:1,
				},
				{
					text:'Количество дней',
					width:'70',
					dataIndex:'Количество',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.СотрудникиОрганизаций").data,
					fields: ['ВидЕжегодногоОтпуска','ГодРаботы','ДатаНачалаРабочегоГода','ДатаОкончанияРабочегоГода','Количество',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СотрудникиОрганизаций/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'ВидЕжегодногоОтпуска',
					},
					{
						name:'ГодРаботы',
					},
					{
						name:'ДатаНачалаРабочегоГода',
					},
					{
						name:'ДатаОкончанияРабочегоГода',
					},
					{
						name:'Количество',
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
						var грид = Ext.getCmp('ОстаткиОтпусковТекущегоСотрудника');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СотрудникиОрганизаций.ФормаСпискаСобытия");
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
			xtype: 'tabpanel',
			style: 'position:absolute;left:276px;top:33px;width:716px;height:126px;',
			height: 126,width: 716,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:1000px;height:25px;',
			dock: 'top',
			items:
			[
				{
					text:'Данные сотрудника',
				},
			]
		},
	]
	});
});