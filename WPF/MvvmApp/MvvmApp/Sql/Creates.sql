create table ProductStatuses (
	[Id] int primary key identity,
	[Name] nvarchar(30) not null,
)

create table Products(
	[Id] uniqueidentifier PRIMARY KEY DEFAULT (NEWID()), 
	[Name] nvarchar(50) not null,
	[Price] money null,
	[Status] int foreign key references ProductStatuses([Id]) null,
)