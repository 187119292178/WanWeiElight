CREATE TABLE [dbo].[Sys_Item] (
  [Id] varchar(20) NOT NULL PRIMARY KEY,
  [EnCode] varchar(50) NULL,
  [ParentId] varchar(20) NULL,
  [Name] varchar(50) NULL,
  [Layer] int  NULL,
  [SortCode] int  NULL,
  [IsTree] char(1) NULL,
  [DeleteMark] char(1) NULL,
  [IsEnabled] char(1) NULL,
  [Remark] varchar(500)  NULL,
  [CreateUser] varchar(50) NULL,
  [CreateTime] datetime  NULL,
  [ModifyUser] varchar(50) NULL,
  [ModifyTime] datetime  NULL
)
GO 

ALTER TABLE [dbo].[Sys_Item] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'编码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'EnCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'名称',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'Name'
GO

EXEC sp_addextendedproperty
'MS_Description', N'层次',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'Layer'
GO

EXEC sp_addextendedproperty
'MS_Description', N'排序码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'SortCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否树形菜单',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'IsTree'
GO

EXEC sp_addextendedproperty
'MS_Description', N'删除标记',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'DeleteMark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否启用',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'IsEnabled'
GO

EXEC sp_addextendedproperty
'MS_Description', N'备注',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'Remark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'CreateUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'ModifyUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Item',
'COLUMN', N'ModifyTime'
GO



INSERT INTO [dbo].[Sys_Item] ([Id], [EnCode], [ParentId], [Name], [Layer], [SortCode], [IsTree], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918438326272', N'all_items', N'0', N'数据字典', N'0', N'0', NULL, N'0', N'1', NULL, N'admin', N'2017-05-13 19:14:25.013', N'admin', N'2017-05-13 19:14:25.013')
GO
INSERT INTO [dbo].[Sys_Item] ([Id], [EnCode], [ParentId], [Name], [Layer], [SortCode], [IsTree], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918484463616', N'role_type', N'305206918438326272', N'角色类型', N'1', N'1', NULL, N'0', N'1', NULL, N'admin', N'2017-05-13 19:14:25.013', N'admin', N'2017-05-13 19:14:25.013')
GO
INSERT INTO [dbo].[Sys_Item] ([Id], [EnCode], [ParentId], [Name], [Layer], [SortCode], [IsTree], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918669012992', N'org_type', N'305206918438326272', N'机构类型', N'1', N'2', NULL, N'0', N'1', NULL, N'admin', N'2017-05-13 19:14:25.013', N'admin', N'2017-05-13 19:14:25.013')
GO
INSERT INTO [dbo].[Sys_Item] ([Id], [EnCode], [ParentId], [Name], [Layer], [SortCode], [IsTree], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918899699712', N'xueli', N'305206918438326272', N'学历', N'1', N'3', NULL, N'0', N'1', NULL, N'admin', N'2017-05-13 19:14:25.013', N'admin', N'2017-05-13 19:14:25.013')
GO
INSERT INTO [dbo].[Sys_Item] ([Id], [EnCode], [ParentId], [Name], [Layer], [SortCode], [IsTree], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919314935808', N'hunyin', N'305206918438326272', N'婚姻', N'1', N'4', NULL, N'0', N'1', NULL, N'admin', N'2017-05-13 19:14:25.013', N'admin', N'2017-05-13 19:14:25.013')
GO


CREATE TABLE [dbo].[Sys_ItemsDetail] (
  [Id] varchar(20)   NOT NULL PRIMARY KEY,
  [ItemId] varchar(20)   NULL,
  [EnCode] varchar(50)   NULL,
  [Name] varchar(50)   NULL,
  [IsDefault] char(1)   NULL,
  [SortCode] int  NULL,
  [DeleteMark] char(1)   NULL,
  [IsEnabled] char(1)   NULL,
  [CreateUser] varchar(50)   NULL,
  [CreateTime] datetime  NULL,
  [ModifyUser] varchar(50)   NULL,
  [ModifyTime] datetime  NULL
)
GO

 



ALTER TABLE [dbo].[Sys_ItemsDetail] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'父级',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'ItemId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'编码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'EnCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'选项名称',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'Name'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否默认',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'IsDefault'
GO

EXEC sp_addextendedproperty
'MS_Description', N'排序码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'SortCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'删除标记',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'DeleteMark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否启用',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'IsEnabled'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'CreateUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'ModifyUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_ItemsDetail',
'COLUMN', N'ModifyTime'
GO


INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918530600960', N'305206918484463616', N'role-business', N'业务角色', N'1', N'2', N'0', N'1', N'admin', N'2017-07-12 11:00:47.137', N'admin', N'2017-07-12 11:00:47.137')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918576738304', N'305206918484463616', N'role-system', N'系统角色', N'0', N'1', N'0', N'1', N'admin', N'2017-07-12 11:00:47.137', N'admin', N'2017-07-12 11:00:47.137')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918622875648', N'305206918484463616', N'role-other', N'其他角色', N'0', N'3', N'0', N'1', N'admin', N'2017-07-12 11:00:47.137', N'admin', N'2017-07-12 11:00:47.137')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918715150336', N'305206918669012992', N'org-team', N'小组', N'0', N'4', N'0', N'1', N'admin', N'2017-07-12 11:00:47.137', N'admin', N'2017-07-12 11:00:47.137')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918761287680', N'305206918669012992', N'org-child-dept', N'子部门', N'0', N'3', N'0', N'1', N'admin', N'2017-07-12 11:00:40.667', N'admin', N'2017-07-12 11:00:40.667')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918807425024', N'305206918669012992', N'org-company', N'公司', N'1', N'1', N'0', N'1', N'admin', N'2017-07-12 11:00:47.137', N'admin', N'2017-07-12 11:00:47.137')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918853562368', N'305206918669012992', N'org-department', N'部门', N'0', N'2', N'0', N'1', N'admin', N'2017-07-12 11:00:47.137', N'admin', N'2017-07-12 11:00:47.137')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918945837056', N'305206918899699712', N'shuoshi', N'硕士', N'0', N'7', N'0', N'1', N'admin', N'2017-04-29 16:49:54.183', N'admin', N'2017-04-29 16:49:54.183')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206918991974400', N'305206918899699712', N'xiaoxue', N'小学及以下', N'0', N'1', N'0', N'1', N'admin', N'2017-04-29 16:44:34.410', N'admin', N'2017-04-29 16:50:15.873')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919038111744', N'305206918899699712', N'benke', N'本科', N'1', N'5', N'0', N'1', N'admin', N'2017-04-29 16:46:24.133', N'admin', N'2017-04-29 16:50:25.883')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919084249088', N'305206918899699712', N'chuzhong', N'初中', N'0', N'2', N'0', N'1', N'admin', N'2017-04-29 16:44:56.470', N'admin', N'2017-04-29 16:44:56.470')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919130386432', N'305206918899699712', N'dazhuan', N'大专', N'0', N'4', N'0', N'1', N'admin', N'2017-04-29 16:45:27.437', N'admin', N'2017-04-29 16:45:27.437')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919176523776', N'305206918899699712', N'yanjiusheng', N'研究生', N'0', N'6', N'0', N'1', N'admin', N'2017-04-29 16:46:45.813', N'admin', N'2017-04-29 16:46:45.813')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919222661120', N'305206918899699712', N'gaozhong', N'高中', N'0', N'3', N'0', N'1', N'admin', N'2017-04-29 16:45:06.660', N'admin', N'2017-04-29 16:45:06.660')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919268798464', N'305206918899699712', N'boshi', N'博士', N'0', N'8', N'0', N'1', N'admin', N'2017-04-29 16:50:10.027', N'admin', N'2017-09-11 15:32:23.733')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919361073152', N'305206919314935808', N'weihun', N'未婚', N'0', N'1', N'0', N'1', N'admin', N'2017-09-11 15:32:42.320', N'admin', N'2017-09-11 15:32:42.320')
GO

INSERT INTO [dbo].[Sys_ItemsDetail] ([Id], [ItemId], [EnCode], [Name], [IsDefault], [SortCode], [DeleteMark], [IsEnabled], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919407210496', N'305206919314935808', N'yihun', N'已婚', N'0', N'2', N'0', N'1', N'admin', N'2017-09-11 15:32:51.403', N'admin', N'2017-09-11 15:32:51.403')
GO



CREATE TABLE [dbo].[Sys_Log] (
  [Id] bigint NOT NULL PRIMARY KEY,
  [Type] varchar(50)  NULL,
  [ThreadId] int NULL, 
  [Message] varchar(5000) NULL,
  [CreateTime] datetime NULL
)
GO
  


CREATE TABLE [dbo].[Sys_Organize] (
  [Id] varchar(20)   NOT NULL PRIMARY KEY,
  [ParentId] varchar(20)   NULL,
  [Layer] int  NULL,
  [EnCode] varchar(50)   NULL,
  [FullName] varchar(50)   NULL,
  [Type] int  NULL,
  [ManagerId] varchar(50)   NULL,
  [TelePhone] varchar(50)   NULL,
  [WeChat] varchar(50)   NULL,
  [Fax] varchar(50)   NULL,
  [Email] varchar(50)   NULL,
  [Address] varchar(50)   NULL,
  [SortCode] int  NULL,
  [DeleteMark] char(1)   NULL,
  [IsEnabled] char(1)   NULL,
  [Remark] varchar(500)   NULL,
  [CreateUser] varchar(50)   NULL,
  [CreateTime] datetime  NULL,
  [ModifyUser] varchar(50)   NULL,
  [ModifyTime] datetime  NULL
)
GO

ALTER TABLE [dbo].[Sys_Organize] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'父级',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'ParentId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'层次',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'Layer'
GO

EXEC sp_addextendedproperty
'MS_Description', N'编码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'EnCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'全称',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'FullName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'分类',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'Type'
GO

EXEC sp_addextendedproperty
'MS_Description', N'负责人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'ManagerId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'固话',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'TelePhone'
GO

EXEC sp_addextendedproperty
'MS_Description', N'微信',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'WeChat'
GO

EXEC sp_addextendedproperty
'MS_Description', N'传真',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'Fax'
GO

EXEC sp_addextendedproperty
'MS_Description', N'邮箱',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'Email'
GO

EXEC sp_addextendedproperty
'MS_Description', N'地址',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'Address'
GO

EXEC sp_addextendedproperty
'MS_Description', N'排序码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'SortCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'删除标记',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'DeleteMark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否启用',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'IsEnabled'
GO

EXEC sp_addextendedproperty
'MS_Description', N'备注',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'Remark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'CreateUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'ModifyUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Organize',
'COLUMN', N'ModifyTime'
GO


-- ----------------------------
-- Records of Sys_Organize
-- ----------------------------
INSERT INTO [dbo].[Sys_Organize] ([Id], [ParentId], [Layer], [EnCode], [FullName], [Type], [ManagerId], [TelePhone], [WeChat], [Fax], [Email], [Address], [SortCode], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919453347840', N'0', NULL, N'company', N'xx', N'0', N'aa', NULL, NULL, NULL, N'aa@qq.com', NULL, N'10', N'0', N'1', NULL, N'admin', N'2018-04-04 11:44:34.283', N'admin', N'2018-04-04 11:42:33.857')
GO

INSERT INTO [dbo].[Sys_Organize] ([Id], [ParentId], [Layer], [EnCode], [FullName], [Type], [ManagerId], [TelePhone], [WeChat], [Fax], [Email], [Address], [SortCode], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919499485184', N'305206919453347840', NULL, N'market', N'市场部', N'1', NULL, NULL, NULL, NULL, NULL, NULL, N'20', N'0', N'1', NULL, N'admin', N'2018-04-04 11:44:34.283', N'admin', N'2018-04-04 11:44:34.283')
GO

INSERT INTO [dbo].[Sys_Organize] ([Id], [ParentId], [Layer], [EnCode], [FullName], [Type], [ManagerId], [TelePhone], [WeChat], [Fax], [Email], [Address], [SortCode], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919545622528', N'305206919453347840', NULL, N'product', N'产品事业部', N'1', NULL, NULL, NULL, NULL, NULL, NULL, N'30', N'0', N'1', NULL, N'admin', N'2018-04-04 11:44:34.283', N'admin', N'2018-04-04 11:44:11.957')
GO

INSERT INTO [dbo].[Sys_Organize] ([Id], [ParentId], [Layer], [EnCode], [FullName], [Type], [ManagerId], [TelePhone], [WeChat], [Fax], [Email], [Address], [SortCode], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919591759872', N'305206919453347840', NULL, N'administration', N'行政人事部', N'1', NULL, NULL, NULL, NULL, NULL, NULL, N'40', N'0', N'1', NULL, N'admin', N'2018-04-04 11:44:34.283', N'admin', N'2018-04-04 11:44:43.333')
GO

INSERT INTO [dbo].[Sys_Organize] ([Id], [ParentId], [Layer], [EnCode], [FullName], [Type], [ManagerId], [TelePhone], [WeChat], [Fax], [Email], [Address], [SortCode], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919637897216', N'305206919453347840', NULL, N'financial', N'财务部', N'1', NULL, NULL, NULL, NULL, NULL, NULL, N'50', N'0', N'1', NULL, N'admin', N'2018-04-04 11:44:34.283', N'admin', N'2018-04-04 11:44:46.800')
GO

INSERT INTO [dbo].[Sys_Organize] ([Id], [ParentId], [Layer], [EnCode], [FullName], [Type], [ManagerId], [TelePhone], [WeChat], [Fax], [Email], [Address], [SortCode], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919684034560', N'305206919453347840', NULL, N'afterSale', N'售后部', N'1', NULL, NULL, NULL, NULL, NULL, NULL, N'70', N'0', N'1', NULL, N'admin', N'2018-04-04 11:44:34.283', N'admin', N'2018-04-04 11:44:39.983')
GO

INSERT INTO [dbo].[Sys_Organize] ([Id], [ParentId], [Layer], [EnCode], [FullName], [Type], [ManagerId], [TelePhone], [WeChat], [Fax], [Email], [Address], [SortCode], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206919730171904', N'305206919453347840', NULL, N'project', N'项目部', N'1', NULL, NULL, NULL, NULL, NULL, NULL, N'80', N'0', N'1', NULL, N'admin', N'2018-04-04 11:44:34.283', N'admin', N'2018-04-04 11:44:50.257')
GO

INSERT INTO [dbo].[Sys_Organize] ([Id], [ParentId], [Layer], [EnCode], [FullName], [Type], [ManagerId], [TelePhone], [WeChat], [Fax], [Email], [Address], [SortCode], [DeleteMark], [IsEnabled], [Remark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305215866176409600', N'305206919453347840', NULL, N'development', N'研发部', N'1', N'周某', N'18800000000', N'admin', N'0512-65000000', N'admin@qq.com', N'苏州某街道', N'90', N'0', N'1', NULL, N'admin', N'2022-04-22 13:38:53.137', N'admin', N'2022-04-22 13:38:53.137')
GO

CREATE TABLE [dbo].[Sys_Permission] (
  [Id] varchar(20)   NOT NULL PRIMARY KEY,
  [ParentId] varchar(20)   NULL,
  [Layer] int  NULL,
  [EnCode] varchar(50)   NULL,
  [Name] varchar(50)   NULL,
  [JsEvent] varchar(50)   NULL,
  [Icon] varchar(50)   NULL,
  [SymbolIndex] int  NULL,
  [Url] varchar(300)   NULL,
  [Remark] varchar(500)   NULL,
  [Type] int  NULL,
  [SortCode] int  NULL,
  [IsPublic] char(1)  DEFAULT ((0)) NULL,
  [IsEnable] char(1)  DEFAULT ((1)) NULL,
  [IsEdit] char(1)  DEFAULT ((1)) NULL,
  [DeleteMark] char(1)  DEFAULT ((0)) NULL,
  [CreateUser] varchar(50)   NULL,
  [CreateTime] datetime  NULL,
  [ModifyUser] varchar(50)   NULL,
  [ModifyTime] datetime  NULL
)
GO

ALTER TABLE [dbo].[Sys_Permission] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'父级',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'ParentId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'层次',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'Layer'
GO

EXEC sp_addextendedproperty
'MS_Description', N'名称',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'Name'
GO

EXEC sp_addextendedproperty
'MS_Description', N'事件',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'JsEvent'
GO

EXEC sp_addextendedproperty
'MS_Description', N'图标',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'Icon'
GO

EXEC sp_addextendedproperty
'MS_Description', N'链接',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'Url'
GO

EXEC sp_addextendedproperty
'MS_Description', N'备注',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'Remark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'模块类型：2-主菜单 0-子菜单 1-按钮',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'Type'
GO

EXEC sp_addextendedproperty
'MS_Description', N'排序码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'SortCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否公开',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'IsPublic'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否可用',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'IsEnable'
GO

EXEC sp_addextendedproperty
'MS_Description', N'允许编辑',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'IsEdit'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'CreateUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'ModifyUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Permission',
'COLUMN', N'ModifyTime'
GO



INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895470317568', N'0', N'0', N'sys-manager', N'系统管理', NULL, N'fa fa-cubes', N'61875', NULL, NULL, N'2', N'10000', N'0', N'1', N'1', N'0', N'admin', NULL, N'admin', NULL)
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895512260608', N'305206895470317568', N'1', N'sys-user', N'系统用户', NULL, N'fa fa-user', N'61447', N'/system/user/index', NULL, N'0', N'10100', N'0', N'1', N'1', N'0', N'admin', NULL, N'admin', N'2017-09-14 13:51:29.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895554203648', N'305206895512260608', N'2', N'user-add', N'新增用户', N'btn_add()', N'fa fa-plus-square-o', N'61846', N'/system/user/form', NULL, N'1', N'10101', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:14:58.000', N'admin', N'2017-03-28 16:14:58.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895600340992', N'305206895512260608', N'2', N'user-edit', N'修改用户', N'btn_edit()', N'fa fa-edit', N'61508', N'/system/user/edit', NULL, N'1', N'10102', N'0', N'1', N'1', N'0', N'admin', N'2017-04-14 17:21:44.000', N'admin', N'2017-06-05 10:48:08.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895646478336', N'305206895512260608', N'2', N'user-delete', N'删除用户', N'btn_delete()', N'fa fa-trash-o', N'61460', N'/system/user/delete', NULL, N'1', N'10103', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:18:25.000', N'admin', N'2017-03-28 16:18:25.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895692615680', N'305206895512260608', N'2', N'user-detail', N'查看用户', N'btn_detail()', N'fa fa-eye', N'61550', N'/system/user/detail', NULL, N'1', N'10104', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:20:18.000', N'admin', N'2017-03-28 16:20:18.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895692615681', N'305206895512260608', N'2', N'reset_password', N'重置密码', N'btn_reset()', N'fa fa-unlock-alt', N'61758', N'/system/user/reset', NULL, N'1', N'10105', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:20:18.000', N'admin', N'2022-05-23 09:31:57.874')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895734558720', N'305206895470317568', N'1', N'sys-permission', N'权限管理', NULL, N'fa fa-suitcase', N'61682', N'/system/permission/index', NULL, N'0', N'10200', N'0', N'1', N'1', N'0', N'admin', NULL, N'admin', N'2017-03-28 16:58:51.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895780696064', N'305206895734558720', N'2', N'per-add', N'新增权限', N'btn_add()', N'fa fa-plus-square-o', N'61846', N'/system/permission/form', NULL, N'1', N'10201', N'0', N'1', N'1', N'0', N'admin', N'2017-02-13 14:28:22.000', N'admin', NULL)
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895822639104', N'305206895734558720', N'2', N'per-edit', N'修改权限', N'btn_edit()', N'fa fa-edit', N'61508', N'/system/permission/form', NULL, N'1', N'10202', N'0', N'1', N'1', N'0', N'admin', N'2017-02-20 09:47:19.000', N'admin', NULL)
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895864582144', N'305206895734558720', N'2', N'per-delete', N'删除权限', N'btn_delete()', N'fa fa-trash-o', N'61460', N'/system/permission/delete', NULL, N'1', N'10203', N'0', N'1', N'1', N'0', N'admin', N'2017-02-20 09:51:19.000', N'admin', NULL)
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895910719488', N'305206895734558720', N'2', N'per-detail', N'查看权限', N'btn_detail()', N'fa fa-eye', N'61550', N'/system/permission/detail', NULL, N'1', N'10204', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:22:06.000', N'admin', N'2017-03-28 16:22:06.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895956856832', N'305206895470317568', N'1', N'sys-role', N'角色管理', NULL, N'fa fa-users', N'61632', N'/system/role/index', NULL, N'0', N'10300', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:27:50.000', N'admin', N'2017-09-14 13:52:18.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896002994176', N'305206895956856832', N'2', N'role-add', N'新增角色', N'btn_add()', N'fa fa-plus-square-o', N'61846', N'/system/role/form', NULL, N'1', N'10301', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:30:21.000', N'admin', N'2017-03-28 16:30:21.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896049131520', N'305206895956856832', N'2', N'role-edit', N'修改角色', N'btn_edit()', N'fa fa-edit', N'61508', N'/system/role/form', NULL, N'1', N'10302', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:31:11.000', N'admin', N'2017-03-28 16:31:11.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896095268864', N'305206895956856832', N'2', N'role-delete', N'删除角色', N'btn_delete()', N'fa fa-trash-o', N'61460', N'/system/role/delete', NULL, N'1', N'10303', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:32:44.000', N'admin', N'2017-03-28 16:32:44.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896141406208', N'305206895956856832', N'2', N'role-detail', N'查看角色', N'btn_detail()', N'fa fa-eye', N'61550', N'/system/role/detail', NULL, N'1', N'10304', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:34:05.000', N'admin', N'2017-03-28 16:34:05.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896183349248', N'305206895956856832', N'2', N'role-authorize', N'角色授权', N'btn_authorize()', N'fa fa-hand-pointer-o', N'62042', N'/system/roleAuthorize/index', NULL, N'1', N'10305', N'0', N'1', N'1', N'0', N'admin', N'2017-03-28 16:36:43.000', N'admin', N'2017-03-28 16:36:43.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896229486592', N'305206895470317568', N'1', N'sys-organize', N'组织机构', NULL, N'fa fa-building', N'61869', N'/system/organize/index', NULL, N'0', N'10400', N'0', N'1', N'1', N'0', N'admin', N'2017-04-02 09:31:01.000', N'admin', N'2017-09-14 13:56:08.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896275623936', N'305206896229486592', N'2', N'org-add', N'新增机构', N'btn_add()', N'fa fa-plus-square-o', N'61846', N'/system/organize/form', NULL, N'1', N'10401', N'0', N'1', N'1', N'0', N'admin', N'2017-04-02 09:37:48.000', N'admin', N'2017-04-02 09:37:48.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896321761280', N'305206896229486592', N'2', N'org-edit', N'修改机构', N'btn_edit()', N'fa fa-edit', N'61508', N'/system/organize/form', NULL, N'1', N'10402', N'0', N'1', N'1', N'0', N'admin', N'2017-04-02 09:38:32.000', N'admin', N'2017-04-02 09:38:32.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896367898624', N'305206896229486592', N'2', N'org-delete', N'删除机构', N'btn_delete()', N'fa fa-trash-o', N'61460', N'/system/organize/delete', NULL, N'1', N'10403', N'0', N'1', N'1', N'0', N'admin', N'2017-04-02 09:45:56.000', N'admin', N'2017-04-02 09:45:56.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896414035968', N'305206896229486592', N'2', N'org-detail', N'查看机构', N'btn_detail()', N'fa fa-eye', N'61550', N'/system/organize/detail', NULL, N'1', N'10404', N'0', N'1', N'1', N'0', N'admin', N'2017-04-02 09:47:18.000', N'admin', N'2017-04-02 09:47:18.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896460173312', N'305206895470317568', N'1', N'lay-item', N'数据字典', NULL, N'fa fa-sitemap', N'61672', N'/system/itemsDetail/index', NULL, N'0', N'10500', N'0', N'1', N'1', N'0', N'admin', N'2017-04-03 15:33:03.000', N'admin', N'2017-04-03 15:33:03.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896506310656', N'305206896460173312', N'2', N'item-manage', N'字典管理', N'btn_manage()', N'fa fa-folder-open-o', N'61717', N'/system/item/index', NULL, N'1', N'10501', N'0', N'1', N'1', N'0', N'admin', N'2017-04-03 21:30:55.000', N'admin', N'2017-04-04 10:48:53.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896552448000', N'305206896460173312', N'2', N'item-add', N'新增选项', N'btn_add()', N'fa fa-plus-square-o', N'61846', N'/system/itemsDetail/form', NULL, N'1', N'10502', N'0', N'1', N'1', N'0', N'admin', N'2017-04-04 19:46:18.000', N'admin', N'2017-04-04 19:46:51.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896598585344', N'305206896460173312', N'2', N'item-edit', N'修改选项', N'btn_edit()', N'fa fa-edit', N'61508', N'/system/itemsDetail/form', NULL, N'0', N'10503', N'0', N'1', N'1', N'0', N'admin', N'2017-04-04 20:05:36.000', N'admin', N'2017-04-04 20:05:36.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896644722688', N'305206896460173312', N'2', N'item-delete', N'删除选项', N'btn_delete()', N'fa fa-trash-o', N'61460', N'/system/itemsDetail/delete', NULL, N'1', N'10504', N'0', N'1', N'1', N'0', N'admin', N'2017-04-04 20:06:35.000', N'admin', N'2017-04-04 20:17:29.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896690860032', N'305206896460173312', N'2', N'item-detail', N'查看选项', N'btn_detail()', N'fa fa-eye', N'61550', N'/system/itemsDetail/detail', NULL, N'1', N'10505', N'0', N'1', N'1', N'0', N'admin', N'2017-04-04 20:16:02.000', N'admin', N'2017-04-04 20:18:14.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896825077760', N'0', N'0', N'sys-test', N'系统测试', NULL, N'fa fa-desktop', N'61704', NULL, NULL, N'2', N'20000', N'0', N'1', N'1', N'0', N'admin', NULL, N'admin', NULL)
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896871215104', N'305206896825077760', N'1', N'code-generator', N'代码生成', NULL, N'fa fa-diamond', N'61977', N'/base/codeGenerator/index', NULL, N'0', N'20100', N'0', N'1', N'1', N'0', N'admin', NULL, N'admin', N'2022-04-19 16:57:12.847')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896913158144', N'305206896825077760', N'1', N'Test-manage', N'打印测试', NULL, N'fa fa-print', N'61888', N'/base/printTest/index', NULL, N'0', N'20200', N'0', N'1', N'0', N'0', N'admin', N'2018-12-05 16:49:46.000', N'admin', N'2022-04-18 16:04:23.040')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206896959295488', N'305206896825077760', N'1', N'ueditor-test', N'富文本编辑', NULL, N'fa fa-newspaper-o', N'61930', N'/ueditor.html', NULL, N'0', N'20300', N'0', N'1', N'0', N'0', N'admin', N'2018-12-05 16:49:46.000', N'admin', N'2022-04-21 10:48:48.063')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206897005432832', N'305206896825077760', N'1', N'video-test', N'视频流测试', NULL, N'fa fa-video-camera', N'61501', N'/video.html', NULL, N'0', N'20400', N'0', N'1', N'0', N'0', N'admin', N'2018-12-05 16:49:46.000', N'admin', N'2022-04-21 10:48:48.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206940735246336', N'0', N'0', N'log-manager', N'日志管理', NULL, N'fa fa-floppy-o', N'61639', NULL, NULL, N'2', N'70000', N'0', N'1', N'1', N'0', N'admin', NULL, N'admin', NULL)
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206940781383680', N'305206940735246336', N'1', N'log-operate', N'操作日志', NULL, N'fa fa-hand-o-down', N'61607', N'/system/log/operateIndex', NULL, N'0', N'70100', N'0', N'1', N'1', N'0', N'admin', NULL, N'admin', N'2022-02-16 09:31:07.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206940827521024', N'305206940781383680', N'2', N'operate_log_delete', N'删除日志', N'btn_delete()', N'fa fa-trash-o', N'61460', N'/system/log/delete', NULL, N'1', N'70101', N'0', N'1', N'0', N'0', N'admin', N'2022-03-25 10:18:55.000', N'admin', N'2022-03-25 10:18:55.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206940873658368', N'305206940781383680', N'2', N'operate_log_export', N'导出日志', N'btn_export()', N'fa fa-download', N'61465', N'/system/log/export', NULL, N'1', N'70102', N'0', N'1', N'1', N'0', N'admin', N'2022-04-02 13:31:26.000', N'admin', N'2022-04-02 13:31:26.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206940919795712', N'305206940735246336', N'1', N'log-running', N'运行日志', NULL, N'fa fa-gears', N'61573', N'/system/log/runningIndex', NULL, N'0', N'70200', N'0', N'1', N'1', N'0', N'admin', NULL, N'admin', N'2022-02-16 09:31:07.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206940965933056', N'305206940919795712', N'2', N'running_log_delete', N'删除日志', N'btn_delete()', N'fa fa-trash-o', N'61460', N'/system/log/delete', NULL, N'1', N'70201', N'0', N'1', N'0', N'0', N'admin', N'2022-03-25 10:18:55.000', N'admin', N'2022-03-25 10:18:55.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206941012070400', N'305206940919795712', N'2', N'running_log_export', N'导出日志', N'btn_export()', N'fa fa-download', N'61465', N'/system/log/export', NULL, N'1', N'70202', N'0', N'1', N'1', N'0', N'admin', N'2022-04-02 13:31:26.000', N'admin', N'2022-04-02 13:31:26.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206941058207744', N'305206940735246336', N'1', N'log-error', N'错误日志', NULL, N'fa fa-remove', N'61453', N'/system/log/errorIndex', NULL, N'0', N'70300', N'0', N'1', N'1', N'0', N'admin', NULL, N'admin', N'2022-02-16 09:31:07.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206941104345088', N'305206941058207744', N'2', N'error_log_delete', N'删除日志', N'btn_delete()', N'fa fa-trash-o', N'61460', N'/system/log/delete', NULL, N'1', N'70301', N'0', N'1', N'0', N'0', N'admin', N'2022-03-25 10:18:55.000', N'admin', N'2022-03-25 10:18:55.000')
GO

INSERT INTO [dbo].[Sys_Permission] ([Id], [ParentId], [Layer], [EnCode], [Name], [JsEvent], [Icon], [SymbolIndex], [Url], [Remark], [Type], [SortCode], [IsPublic], [IsEnable], [IsEdit], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206941150482432', N'305206941058207744', N'2', N'error_log_export', N'导出日志', N'btn_export()', N'fa fa-download', N'61465', N'/system/log/export', NULL, N'1', N'70302', N'0', N'1', N'1', N'0', N'admin', N'2022-04-02 13:31:26.000', N'admin', N'2022-04-02 13:31:26.000')
GO






 
 



CREATE TABLE [dbo].[Sys_Role] (
  [Id] varchar(20)   NOT NULL PRIMARY KEY,
  [OrganizeId] varchar(20)   NULL,
  [EnCode] varchar(50)   NULL,
  [Type] int  NULL,
  [Name] varchar(50)   NULL,
  [AllowEdit] char(1)   NULL,
  [DeleteMark] char(1)   NULL,
  [IsEnabled] char(1)   NULL,
  [Remark] varchar(500)   NULL,
  [SortCode] int  NULL,
  [CreateUser] varchar(50)   NULL,
  [CreateTime] datetime  NULL,
  [ModifyUser] varchar(50)   NULL,
  [ModifyTime] datetime  NULL
)
GO

ALTER TABLE [dbo].[Sys_Role] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'组织ID',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'OrganizeId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'编号',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'EnCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'分类：1-角色2-岗位',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'Type'
GO

EXEC sp_addextendedproperty
'MS_Description', N'名称',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'Name'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否可编辑',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'AllowEdit'
GO

EXEC sp_addextendedproperty
'MS_Description', N'删除标记',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'DeleteMark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否启用',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'IsEnabled'
GO

EXEC sp_addextendedproperty
'MS_Description', N'备注',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'Remark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'排序码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'SortCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'CreateUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'ModifyUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'ModifyTime'
GO


-- ----------------------------
-- Records of Sys_Role
-- ----------------------------
INSERT INTO [dbo].[Sys_Role] ([Id], [OrganizeId], [EnCode], [Type], [Name], [AllowEdit], [DeleteMark], [IsEnabled], [Remark], [SortCode], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895419985920', N'305215866176409600', N'administrators', N'0', N'超级管理员', N'1', N'0', N'1', NULL, N'1', N'admin', N'2017-06-05 17:33:13.370', N'admin', N'2022-04-22 13:39:08.810')
GO

INSERT INTO [dbo].[Sys_Role] ([Id], [OrganizeId], [EnCode], [Type], [Name], [AllowEdit], [DeleteMark], [IsEnabled], [Remark], [SortCode], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206925950324736', N'305206919730171904', N'implement', N'1', N'实施人员', N'1', N'0', N'0', NULL, N'5', N'admin', N'2017-06-05 17:33:13.370', N'admin', N'2022-04-22 13:39:43.763')
GO

INSERT INTO [dbo].[Sys_Role] ([Id], [OrganizeId], [EnCode], [Type], [Name], [AllowEdit], [DeleteMark], [IsEnabled], [Remark], [SortCode], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206925992267776', N'305215866176409600', N'developer', N'0', N'系统开发人员', N'0', N'0', N'1', NULL, N'3', N'admin', N'2017-06-05 17:33:13.370', N'admin', N'2022-04-22 13:39:37.337')
GO

CREATE TABLE [dbo].[Sys_RoleAuthorize] (
  [Id] varchar(20)   NOT NULL PRIMARY KEY,
  [RoleId] varchar(20)   NULL,
  [ModuleId] varchar(20)   NULL,
  [CreateUser] varchar(50)   NULL,
  [CreateTime] datetime  NULL
)
GO

ALTER TABLE [dbo].[Sys_RoleAuthorize] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'Sys_RoleAuthorize',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'角色ID',
'SCHEMA', N'dbo',
'TABLE', N'Sys_RoleAuthorize',
'COLUMN', N'RoleId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'模块ID',
'SCHEMA', N'dbo',
'TABLE', N'Sys_RoleAuthorize',
'COLUMN', N'ModuleId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_RoleAuthorize',
'COLUMN', N'CreateUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_RoleAuthorize',
'COLUMN', N'CreateTime'
GO


-- ----------------------------
-- Records of Sys_RoleAuthorize
-- ----------------------------
INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897047375872', N'305206895419985920', N'305206895512260608', N'admin', N'2017-04-04 21:10:58.337')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897093513216', N'305206895419985920', N'305206895554203648', N'admin', N'2017-03-28 16:47:59.850')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897139650560', N'305206895419985920', N'305206895600340992', N'admin', N'2017-03-28 16:47:59.803')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897185787904', N'305206895419985920', N'305206895646478336', N'admin', N'2017-03-28 16:47:59.727')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897231925248', N'305206895419985920', N'305206895692615680', N'admin', N'2017-04-02 09:48:32.997')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897278062592', N'305206895419985920', N'305206895734558720', N'admin', N'2017-04-02 09:48:33.027')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897320005632', N'305206895419985920', N'305206895780696064', N'admin', N'2017-04-04 21:10:58.320')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897366142976', N'305206895419985920', N'305206895822639104', N'admin', N'2017-04-02 09:48:32.977')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897416474624', N'305206895419985920', N'305206895864582144', N'admin', N'2017-04-04 21:10:58.293')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897458417664', N'305206895419985920', N'305206895910719488', N'admin', N'2017-04-19 13:22:54.643')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897504555008', N'305206895419985920', N'305206895956856832', N'admin', N'2017-04-03 15:34:35.697')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897550692352', N'305206895419985920', N'305206896002994176', N'admin', N'2017-04-14 17:28:14.800')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897592635392', N'305206895419985920', N'305206896049131520', N'admin', N'2017-04-02 09:48:33.013')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897634578432', N'305206895419985920', N'305206896095268864', N'admin', N'2017-03-15 13:40:27.933')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897680715776', N'305206895419985920', N'305206896141406208', N'admin', N'2017-03-28 16:47:59.787')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897726853120', N'305206895419985920', N'305206896183349248', N'admin', N'2022-04-22 10:31:56.943')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305206897802350592', N'305206895419985920', N'305206895470317568', N'admin', N'2022-04-22 10:31:56.943')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518677884928', N'305206895419985920', N'305206896229486592', N'admin', N'2022-04-22 13:17:38.190')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518686273536', N'305206895419985920', N'305206896275623936', N'admin', N'2022-04-22 13:17:38.193')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518686273537', N'305206895419985920', N'305206896321761280', N'admin', N'2022-04-22 13:17:38.193')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518690467840', N'305206895419985920', N'305206896367898624', N'admin', N'2022-04-22 13:17:38.193')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518690467841', N'305206895419985920', N'305206896414035968', N'admin', N'2022-04-22 13:17:38.193')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518690467842', N'305206895419985920', N'305206896460173312', N'admin', N'2022-04-22 13:17:38.193')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518690467843', N'305206895419985920', N'305206896506310656', N'admin', N'2022-04-22 13:17:38.193')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518694662144', N'305206895419985920', N'305206896552448000', N'admin', N'2022-04-22 13:17:38.193')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518694662145', N'305206895419985920', N'305206896598585344', N'admin', N'2022-04-22 13:17:38.193')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518698856448', N'305206895419985920', N'305206896644722688', N'admin', N'2022-04-22 13:17:38.197')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518698856449', N'305206895419985920', N'305206896690860032', N'admin', N'2022-04-22 13:17:38.197')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518698856450', N'305206895419985920', N'305206896736997376', N'admin', N'2022-04-22 13:17:38.197')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518698856451', N'305206895419985920', N'305206896778940416', N'admin', N'2022-04-22 13:17:38.197')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518703050752', N'305206895419985920', N'305206896825077760', N'admin', N'2022-04-22 13:17:38.197')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518703050753', N'305206895419985920', N'305206896871215104', N'admin', N'2022-04-22 13:17:38.197')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518703050754', N'305206895419985920', N'305206896913158144', N'admin', N'2022-04-22 13:17:38.197')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518703050755', N'305206895419985920', N'305206896959295488', N'admin', N'2022-04-22 13:17:38.197')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305210518707245056', N'305206895419985920', N'305206897005432832', N'admin', N'2022-04-22 13:17:38.197')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117813678080', N'305206925992267776', N'305206895470317568', N'admin', N'2022-04-22 13:39:53.130')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117822066688', N'305206925992267776', N'305206895512260608', N'admin', N'2022-04-22 13:39:53.130')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117826260992', N'305206925992267776', N'305206895554203648', N'admin', N'2022-04-22 13:39:53.130')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117826260993', N'305206925992267776', N'305206895600340992', N'admin', N'2022-04-22 13:39:53.130')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117826260994', N'305206925992267776', N'305206895646478336', N'admin', N'2022-04-22 13:39:53.130')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117826260995', N'305206925992267776', N'305206895692615680', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117830455296', N'305206925992267776', N'305206895734558720', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117830455297', N'305206925992267776', N'305206895780696064', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117830455298', N'305206925992267776', N'305206895822639104', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117830455299', N'305206925992267776', N'305206895864582144', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117834649600', N'305206925992267776', N'305206895910719488', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117834649601', N'305206925992267776', N'305206895956856832', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117834649602', N'305206925992267776', N'305206896002994176', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117838843904', N'305206925992267776', N'305206896049131520', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117838843905', N'305206925992267776', N'305206896095268864', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117838843906', N'305206925992267776', N'305206896141406208', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117838843907', N'305206925992267776', N'305206896183349248', N'admin', N'2022-04-22 13:39:53.133')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117843038208', N'305206925992267776', N'305206896229486592', N'admin', N'2022-04-22 13:39:53.137')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117843038209', N'305206925992267776', N'305206896275623936', N'admin', N'2022-04-22 13:39:53.137')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117847232512', N'305206925992267776', N'305206896321761280', N'admin', N'2022-04-22 13:39:53.137')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117847232513', N'305206925992267776', N'305206896367898624', N'admin', N'2022-04-22 13:39:53.137')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117847232514', N'305206925992267776', N'305206896414035968', N'admin', N'2022-04-22 13:39:53.137')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117851426816', N'305206925992267776', N'305206896460173312', N'admin', N'2022-04-22 13:39:53.137')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117851426817', N'305206925992267776', N'305206896506310656', N'admin', N'2022-04-22 13:39:53.137')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117851426818', N'305206925992267776', N'305206896552448000', N'admin', N'2022-04-22 13:39:53.137')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117855621120', N'305206925992267776', N'305206896598585344', N'admin', N'2022-04-22 13:39:53.137')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117855621121', N'305206925992267776', N'305206896644722688', N'admin', N'2022-04-22 13:39:53.140')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117855621122', N'305206925992267776', N'305206896690860032', N'admin', N'2022-04-22 13:39:53.140')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117855621123', N'305206925992267776', N'305206896736997376', N'admin', N'2022-04-22 13:39:53.140')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117859815424', N'305206925992267776', N'305206896778940416', N'admin', N'2022-04-22 13:39:53.140')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117859815425', N'305206925992267776', N'305206896825077760', N'admin', N'2022-04-22 13:39:53.140')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117859815426', N'305206925992267776', N'305206896871215104', N'admin', N'2022-04-22 13:39:53.140')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117859815427', N'305206925992267776', N'305206896913158144', N'admin', N'2022-04-22 13:39:53.140')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117864009728', N'305206925992267776', N'305206896959295488', N'admin', N'2022-04-22 13:39:53.140')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216117864009729', N'305206925992267776', N'305206897005432832', N'admin', N'2022-04-22 13:39:53.140')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184826073088', N'305206925950324736', N'305206895470317568', N'admin', N'2022-04-22 13:40:09.107')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184830267392', N'305206925950324736', N'305206895512260608', N'admin', N'2022-04-22 13:40:09.107')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184834461696', N'305206925950324736', N'305206895554203648', N'admin', N'2022-04-22 13:40:09.107')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184834461697', N'305206925950324736', N'305206895600340992', N'admin', N'2022-04-22 13:40:09.107')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184834461698', N'305206925950324736', N'305206895646478336', N'admin', N'2022-04-22 13:40:09.107')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184838656000', N'305206925950324736', N'305206895692615680', N'admin', N'2022-04-22 13:40:09.107')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184838656001', N'305206925950324736', N'305206896229486592', N'admin', N'2022-04-22 13:40:09.110')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184838656002', N'305206925950324736', N'305206896275623936', N'admin', N'2022-04-22 13:40:09.110')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184842850304', N'305206925950324736', N'305206896321761280', N'admin', N'2022-04-22 13:40:09.110')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184842850305', N'305206925950324736', N'305206896367898624', N'admin', N'2022-04-22 13:40:09.110')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184842850306', N'305206925950324736', N'305206896414035968', N'admin', N'2022-04-22 13:40:09.110')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184842850307', N'305206925950324736', N'305206896460173312', N'admin', N'2022-04-22 13:40:09.110')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184847044608', N'305206925950324736', N'305206896506310656', N'admin', N'2022-04-22 13:40:09.110')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184847044609', N'305206925950324736', N'305206896552448000', N'admin', N'2022-04-22 13:40:09.110')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184855433216', N'305206925950324736', N'305206896598585344', N'admin', N'2022-04-22 13:40:09.113')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184855433217', N'305206925950324736', N'305206896644722688', N'admin', N'2022-04-22 13:40:09.113')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184855433218', N'305206925950324736', N'305206896690860032', N'admin', N'2022-04-22 13:40:09.113')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184859627520', N'305206925950324736', N'305206896736997376', N'admin', N'2022-04-22 13:40:09.113')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216184859627521', N'305206925950324736', N'305206896778940416', N'admin', N'2022-04-22 13:40:09.113')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216202131771392', N'305206925950324736', N'305206896825077760', N'admin', N'2022-04-22 13:40:13.230')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216202131771393', N'305206925950324736', N'305206896871215104', N'admin', N'2022-04-22 13:40:13.230')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216202131771394', N'305206925950324736', N'305206896913158144', N'admin', N'2022-04-22 13:40:13.233')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216202135965696', N'305206925950324736', N'305206896959295488', N'admin', N'2022-04-22 13:40:13.233')
GO

INSERT INTO [dbo].[Sys_RoleAuthorize] ([Id], [RoleId], [ModuleId], [CreateUser], [CreateTime]) VALUES (N'305216202135965697', N'305206925950324736', N'305206897005432832', N'admin', N'2022-04-22 13:40:13.233')
GO

 

CREATE TABLE [dbo].[Sys_User] (
  [Id] varchar(20) NOT NULL PRIMARY KEY,
  [Account] varchar(50)   NULL,
  [RealName] varchar(50)   NULL,
  [NickName] varchar(50)   NULL,
  [Avatar] varchar(200)   NULL,
  [Gender] char(1)   NULL,
  [Birthday] datetime  NULL,
  [MobilePhone] varchar(20)   NULL,
  [Email] varchar(50)   NULL,
  [Signature] varchar(500)   NULL,
  [Address] varchar(500)   NULL,
  [CompanyId] varchar(50)   NULL,
  [DepartmentId] varchar(50)   NULL,
  [IsEnabled] char(1)   NULL,
  [SortCode] int  NULL,
  [DeleteMark] char(1)   NULL,
  [CreateUser] varchar(50)   NULL,
  [CreateTime] datetime  NULL,
  [ModifyUser] varchar(50)   NULL,
  [ModifyTime] datetime  NULL
)
GO

ALTER TABLE [dbo].[Sys_User] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'账户',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Account'
GO

EXEC sp_addextendedproperty
'MS_Description', N'真实姓名',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'RealName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'昵称',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'NickName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'头像',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Avatar'
GO

EXEC sp_addextendedproperty
'MS_Description', N'性别',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Gender'
GO

EXEC sp_addextendedproperty
'MS_Description', N'生日',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Birthday'
GO

EXEC sp_addextendedproperty
'MS_Description', N'手机',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'MobilePhone'
GO

EXEC sp_addextendedproperty
'MS_Description', N'邮箱',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Email'
GO

EXEC sp_addextendedproperty
'MS_Description', N'签名',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Signature'
GO

EXEC sp_addextendedproperty
'MS_Description', N'地址',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Address'
GO

EXEC sp_addextendedproperty
'MS_Description', N'领导ID',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'CompanyId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'组织ID',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'DepartmentId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否启用',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'IsEnabled'
GO

EXEC sp_addextendedproperty
'MS_Description', N'排序码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'SortCode'
GO

EXEC sp_addextendedproperty
'MS_Description', N'删除标记',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'DeleteMark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'CreateUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改人',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'ModifyUser'
GO

EXEC sp_addextendedproperty
'MS_Description', N'修改时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'ModifyTime'
GO


INSERT INTO [dbo].[Sys_User] ([Id], [Account], [RealName], [NickName], [Avatar], [Gender], [Birthday], [MobilePhone], [Email], [Signature], [Address], [CompanyId], [DepartmentId], [IsEnabled], [SortCode], [DeleteMark], [CreateUser], [CreateTime], [ModifyUser], [ModifyTime]) VALUES (N'305206895285768192', N'admin', N'周某人', N'周某人', N'/Uploads/Avatar/c1e9d6a1-83d5-485a-b1dd-5118394c2c1f.png', N'1', N'1991-07-22 00:00:00.000', N'18800000000', N'656000000@qq.com', N'狗咬人，人还会去咬狗吗？', N'苏州某条不出名的街道', NULL, N'305215866176409600', N'1', N'1', N'0', N'admin', N'2017-03-22 10:58:43.107', N'admin', N'2022-04-22 13:42:28.073')
GO


CREATE TABLE [dbo].[Sys_UserLogOn] (
  [Id] varchar(20)   NOT NULL PRIMARY KEY,
  [UserId] varchar(20)   NULL,
  [Password] varchar(50)   NULL,
  [SecretKey] varchar(50)   NULL,
  [PrevVisitTime] datetime  NULL,
  [LastVisitTime] datetime  NULL,
  [ChangePwdTime] datetime  NULL,
  [LoginCount] int DEFAULT ((0)) NOT NULL,
  [AllowMultiUserOnline] char(1)   NULL,
  [IsOnLine] char(1)   NULL,
  [Question] varchar(100)   NULL,
  [AnswerQuestion] varchar(200)   NULL,
  [CheckIPAddress] char(1)   NULL,
  [Language] varchar(50)   NULL,
  [Theme] varchar(50)   NULL
)
GO

INSERT INTO [dbo].[Sys_UserLogOn] ([Id], [UserId], [Password], [SecretKey], [PrevVisitTime], [LastVisitTime], [ChangePwdTime], [LoginCount], [AllowMultiUserOnline], [IsOnLine], [Question], [AnswerQuestion], [CheckIPAddress], [Language], [Theme]) VALUES (N'305206895331905536', N'305206895285768192', N'620fbd6bcbd32cb90dcab73d37706c15', N'juhgtdjc', N'2022-04-22 13:36:03.600', N'2022-04-22 13:36:03.600', N'2017-09-14 13:34:09.783', N'1198', N'1', N'1', N'lovecoding?', N'no', N'1', NULL, NULL)
GO



CREATE TABLE [dbo].[Sys_UserRoleRelation] (
  [Id] varchar(20)   NOT NULL PRIMARY KEY,
  [UserId] varchar(20)   NULL,
  [RoleId] varchar(20)   NULL,
  [CreateUser] varchar(50)   NULL,
  [CreateTime] datetime  NULL
)
GO
 
INSERT INTO [dbo].[Sys_UserRoleRelation] ([Id], [UserId], [RoleId], [CreateUser], [CreateTime]) VALUES (N'305216767716888576', N'305206895285768192', N'305206895419985920', N'admin', N'2022-04-22 13:42:28.077')
GO

