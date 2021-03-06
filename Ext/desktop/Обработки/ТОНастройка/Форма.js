﻿Ext.require(['Данные.Обработки.ТОНастройка'], function () 
{
	Ext.define('Обработки.ТОНастройка.Форма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:866px;height:519px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Подключение и настройка торгового оборудования',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:88px;width:850px;height:398px;',
			height: 398,width: 850,
			items:
			[
				{
					title:'Сканеры штрихкода',
					items:
					[
		{
			id: 'СканерыШтрихКода',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'571',
					dataIndex:'Модель',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
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
						var грид = Ext.getCmp('СканерыШтрихКода');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Фискальные регистраторы',
					items:
					[
		{
			id: 'ФискальныеРегистраторы',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'345',
					dataIndex:'Модель',
					flex:1,
				},
				{
					text:'Касса ККМ',
					width:'225',
					dataIndex:'КассаККМ',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
					},
					{
						name:'КассаККМ',
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
						var грид = Ext.getCmp('ФискальныеРегистраторы');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Терминалы сбора данных',
					items:
					[
		{
			id: 'ТерминалыСбораДанных',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'571',
					dataIndex:'Модель',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
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
						var грид = Ext.getCmp('ТерминалыСбораДанных');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Дисплеи покупателя',
					items:
					[
		{
			id: 'ДисплеиПокупателя',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'346',
					dataIndex:'Модель',
					flex:1,
				},
				{
					text:'Касса ККМ',
					width:'225',
					dataIndex:'КассаККМ',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
					},
					{
						name:'КассаККМ',
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
						var грид = Ext.getCmp('ДисплеиПокупателя');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Считыватели магнитных карт',
					items:
					[
		{
			id: 'СчитывателиМагнитныхКарт',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'571',
					dataIndex:'Модель',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
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
						var грид = Ext.getCmp('СчитывателиМагнитныхКарт');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Электронные весы',
					items:
					[
		{
			id: 'ЭлектронныеВесы',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'571',
					dataIndex:'Модель',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
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
						var грид = Ext.getCmp('ЭлектронныеВесы');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Весы с печатью этикеток',
					items:
					[
		{
			id: 'ВесыСПечатьюЭтикеток',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'571',
					dataIndex:'Модель',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
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
						var грид = Ext.getCmp('ВесыСПечатьюЭтикеток');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'ККМ в режиме Offline',
					items:
					[
		{
			id: 'ККМOffline',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'346',
					dataIndex:'Модель',
					flex:1,
				},
				{
					text:'Касса ККМ',
					width:'225',
					dataIndex:'КассаККМ',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
					},
					{
						name:'КассаККМ',
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
						var грид = Ext.getCmp('ККМOffline');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'ККМ в режиме Online',
					items:
					[
		{
			id: 'ККМOnline',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'346',
					dataIndex:'Модель',
					flex:1,
				},
				{
					text:'Касса ККМ',
					width:'225',
					dataIndex:'КассаККМ',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
					},
					{
						name:'КассаККМ',
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
						var грид = Ext.getCmp('ККМOnline');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Эквайринговые системы',
					items:
					[
		{
			id: 'ЭквайринговыеСистемы',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'571',
					dataIndex:'Модель',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
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
						var грид = Ext.getCmp('ЭквайринговыеСистемы');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Считыватели RFID меток',
					items:
					[
		{
			id: 'СчитывателиRFIDМеток',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:612px;height:359px;',
			height: 359,width: 612,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Подключено',
					flex:1,
				},
				{
					text:'Модель',
					width:'571',
					dataIndex:'Модель',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ТОНастройка/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Подключено',
					},
					{
						name:'Модель',
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
						var грид = Ext.getCmp('СчитывателиRFIDМеток');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ТОНастройка.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ТОНастройка.ФормаСобытия");
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
			name: 'НадписьПодключениеИНастройкаТорговогоОборудования',
			text: 'Подключение и настройка торгового оборудования',
			style: 'position:absolute;left:8px;top:6px;width:850px;height:26px;text-align:center;',
		},
		{
			xtype: 'label',
			name: 'ДляКомпьютера',
			text: 'для компьютера ""',
			style: 'position:absolute;left:8px;top:32px;width:850px;height:19px;text-align:center;',
		},
		{
			xtype: 'button',
			name: 'ПомощникПодключения',
			text: 'Помощник подключения',
			style: 'position:absolute;left:8px;top:57px;width:154px;height:25px;',
		},
		{
			xtype: 'button',
			name: 'ОбработкиОбслуживания',
			text: 'Обработки обслуживания',
			style: 'position:absolute;left:167px;top:57px;width:153px;height:25px;',
		},
		{
			xtype: 'button',
			name: 'Справка',
			text: 'Справка',
			style: 'position:absolute;left:778px;top:57px;width:80px;height:25px;',
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:494px;width:866px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Проверить все подключенное оборудование',
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