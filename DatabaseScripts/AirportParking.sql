SET IDENTITY_INSERT [dbo].[Customer] ON 
INSERT [dbo].[Customer] ([CustomerID], [Name], [Email], [Contact], [Address]) VALUES (1, N'jono', N'jono@yahoo.com', N'64498894949', N'new zealand')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Parking] ON 
INSERT [dbo].[Parking] ([ID], [customerID], [planID], [parkID]) VALUES (5, 11, 1, 21)
SET IDENTITY_INSERT [dbo].[Parking] OFF
SET IDENTITY_INSERT [dbo].[Payment] ON 
INSERT [dbo].[Payment] ([id], [Name], [Paymnt], [paymentDate]) VALUES (1, N'jono', 23, N'23/02/2021')
SET IDENTITY_INSERT [dbo].[Payment] OFF
