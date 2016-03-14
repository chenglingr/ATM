if exists (select * from sysobjects where id = OBJECT_ID('[cardinfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [cardinfo]

CREATE TABLE [cardinfo] (
[cardID] [varchar]  (19) NOT NULL,
[curType] [varchar]  (20) NULL DEFAULT (N'RMB'),
[savingType] [varchar]  (20) NOT NULL,
[openDate] [datetime]  NULL DEFAULT (getdate()),
[openMoney] [float]  NOT NULL DEFAULT (0),
[balance] [float]  NOT NULL DEFAULT (0),
[pass] [varchar]  (6) NULL DEFAULT (888888),
[IsReportLoss] [bit]  NULL DEFAULT (0),
[customerID] [int]  NOT NULL)

ALTER TABLE [cardinfo] WITH NOCHECK ADD  CONSTRAINT [PK_cardinfo] PRIMARY KEY  NONCLUSTERED ( [cardID] )
INSERT [cardinfo] ([cardID],[curType],[savingType],[openDate],[openMoney],[balance],[pass],[IsReportLoss],[customerID]) VALUES ( N'1010 3576 1212 1134',N'RMB',N'定期',N'2016/3/13 18:02:32',1,1,N'888888',0,2)
INSERT [cardinfo] ([cardID],[curType],[savingType],[openDate],[openMoney],[balance],[pass],[IsReportLoss],[customerID]) VALUES ( N'1010 3576 1234 5678',N'RMB',N'活期',N'2016/3/13 18:01:32',1000,1000,N'888888',0,1)
if exists (select * from sysobjects where id = OBJECT_ID('[transInfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [transInfo]

CREATE TABLE [transInfo] (
[transDate] [datetime]  NOT NULL DEFAULT (getdate()),
[cardID] [varchar]  (19) NOT NULL,
[transType] [nchar]  (10) NOT NULL,
[transMoney] [float]  NOT NULL,
[remark] [varchar]  (100) NULL)

ALTER TABLE [transInfo] WITH NOCHECK ADD  CONSTRAINT [PK_transInfo] PRIMARY KEY  NONCLUSTERED ( [transDate] )
if exists (select * from sysobjects where id = OBJECT_ID('[userInfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [userInfo]

CREATE TABLE [userInfo] (
[customerID] [int]  IDENTITY (1, 1)  NOT NULL,
[customerName] [varchar]  (20) NOT NULL,
[pID] [varchar]  (18) NOT NULL,
[telephone] [varchar]  (13) NOT NULL,
[address] [varchar]  (100) NULL)

ALTER TABLE [userInfo] WITH NOCHECK ADD  CONSTRAINT [PK_userInfo] PRIMARY KEY  NONCLUSTERED ( [customerID] )
SET IDENTITY_INSERT [userInfo] ON

INSERT [userInfo] ([customerID],[customerName],[pID],[telephone],[address]) VALUES ( 1,N'张三',N'123456789012345',N'010-67898978',N'北京海淀')
INSERT [userInfo] ([customerID],[customerName],[pID],[telephone]) VALUES ( 2,N'李四',N'321245678912345678',N'0478-44443333')

SET IDENTITY_INSERT [userInfo] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[cardinfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [cardinfo]

CREATE TABLE [cardinfo] (
[cardID] [varchar]  (19) NOT NULL,
[curType] [varchar]  (20) NULL DEFAULT (N'RMB'),
[savingType] [varchar]  (20) NOT NULL,
[openDate] [datetime]  NULL DEFAULT (getdate()),
[openMoney] [float]  NOT NULL DEFAULT (0),
[balance] [float]  NOT NULL DEFAULT (0),
[pass] [varchar]  (6) NULL DEFAULT (888888),
[IsReportLoss] [bit]  NULL DEFAULT (0),
[customerID] [int]  NOT NULL)

ALTER TABLE [cardinfo] WITH NOCHECK ADD  CONSTRAINT [PK_cardinfo] PRIMARY KEY  NONCLUSTERED ( [cardID] )
INSERT [cardinfo] ([cardID],[curType],[savingType],[openDate],[openMoney],[balance],[pass],[IsReportLoss],[customerID]) VALUES ( N'1010 3576 1212 1134',N'RMB',N'定期',N'2016/3/13 18:02:32',1,1,N'888888',0,2)
INSERT [cardinfo] ([cardID],[curType],[savingType],[openDate],[openMoney],[balance],[pass],[IsReportLoss],[customerID]) VALUES ( N'1010 3576 1234 5678',N'RMB',N'活期',N'2016/3/13 18:01:32',1000,1000,N'888888',0,1)
if exists (select * from sysobjects where id = OBJECT_ID('[transInfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [transInfo]

CREATE TABLE [transInfo] (
[transDate] [datetime]  NOT NULL DEFAULT (getdate()),
[cardID] [varchar]  (19) NOT NULL,
[transType] [nchar]  (10) NOT NULL,
[transMoney] [float]  NOT NULL,
[remark] [varchar]  (100) NULL)

ALTER TABLE [transInfo] WITH NOCHECK ADD  CONSTRAINT [PK_transInfo] PRIMARY KEY  NONCLUSTERED ( [transDate] )
if exists (select * from sysobjects where id = OBJECT_ID('[userInfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [userInfo]

CREATE TABLE [userInfo] (
[customerID] [int]  IDENTITY (1, 1)  NOT NULL,
[customerName] [varchar]  (20) NOT NULL,
[pID] [varchar]  (18) NOT NULL,
[telephone] [varchar]  (13) NOT NULL,
[address] [varchar]  (100) NULL)

ALTER TABLE [userInfo] WITH NOCHECK ADD  CONSTRAINT [PK_userInfo] PRIMARY KEY  NONCLUSTERED ( [customerID] )
SET IDENTITY_INSERT [userInfo] ON

INSERT [userInfo] ([customerID],[customerName],[pID],[telephone],[address]) VALUES ( 1,N'张三',N'123456789012345',N'010-67898978',N'北京海淀')
INSERT [userInfo] ([customerID],[customerName],[pID],[telephone]) VALUES ( 2,N'李四',N'321245678912345678',N'0478-44443333')

SET IDENTITY_INSERT [userInfo] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[userInfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [userInfo]

CREATE TABLE [userInfo] (
[customerID] [int]  IDENTITY (1, 1)  NOT NULL,
[customerName] [varchar]  (20) NOT NULL,
[pID] [varchar]  (18) NOT NULL,
[telephone] [varchar]  (13) NOT NULL,
[address] [varchar]  (100) NULL)

ALTER TABLE [userInfo] WITH NOCHECK ADD  CONSTRAINT [PK_userInfo] PRIMARY KEY  NONCLUSTERED ( [customerID] )
SET IDENTITY_INSERT [userInfo] ON

INSERT [userInfo] ([customerID],[customerName],[pID],[telephone],[address]) VALUES ( 1,N'张三',N'123456789012345',N'010-67898978',N'北京海淀')
INSERT [userInfo] ([customerID],[customerName],[pID],[telephone]) VALUES ( 2,N'李四',N'321245678912345678',N'0478-44443333')

SET IDENTITY_INSERT [userInfo] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[cardinfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [cardinfo]

CREATE TABLE [cardinfo] (
[cardID] [varchar]  (19) NOT NULL,
[curType] [varchar]  (20) NULL DEFAULT (N'RMB'),
[savingType] [varchar]  (20) NOT NULL,
[openDate] [datetime]  NULL DEFAULT (getdate()),
[openMoney] [float]  NOT NULL DEFAULT (0),
[balance] [float]  NOT NULL DEFAULT (0),
[pass] [varchar]  (6) NULL DEFAULT (888888),
[IsReportLoss] [bit]  NULL DEFAULT (0),
[customerID] [int]  NOT NULL)

ALTER TABLE [cardinfo] WITH NOCHECK ADD  CONSTRAINT [PK_cardinfo] PRIMARY KEY  NONCLUSTERED ( [cardID] )
INSERT [cardinfo] ([cardID],[curType],[savingType],[openDate],[openMoney],[balance],[pass],[IsReportLoss],[customerID]) VALUES ( N'1010 3576 1212 1134',N'RMB',N'定期',N'2016/3/13 18:02:32',1,1,N'888888',0,2)
INSERT [cardinfo] ([cardID],[curType],[savingType],[openDate],[openMoney],[balance],[pass],[IsReportLoss],[customerID]) VALUES ( N'1010 3576 1234 5678',N'RMB',N'活期',N'2016/3/13 18:01:32',1000,1000,N'888888',0,1)
if exists (select * from sysobjects where id = OBJECT_ID('[transInfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [transInfo]

CREATE TABLE [transInfo] (
[transDate] [datetime]  NOT NULL DEFAULT (getdate()),
[cardID] [varchar]  (19) NOT NULL,
[transType] [nchar]  (10) NOT NULL,
[transMoney] [float]  NOT NULL,
[remark] [varchar]  (100) NULL)

ALTER TABLE [transInfo] WITH NOCHECK ADD  CONSTRAINT [PK_transInfo] PRIMARY KEY  NONCLUSTERED ( [transDate] )
