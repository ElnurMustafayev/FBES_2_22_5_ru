create table Statuses(
	[Id] int primary key identity,
	[Name] nvarchar(100) not null,
)

insert into Statuses
values('Default'), ('Sold out'), ('Bestseller')



drop table Products
create table Products(
	[Id] int primary key identity,
	[Name] nvarchar(100) not null check(len([Name]) > 10) default('test'),
	[Price] money not null check([Price] >= 0),
	[Status] int foreign key references Statuses([Id]) default(1),
)








insert into Products([Name], [Price])
values('IPhone IPhone IPhone IPhone', -2000)
insert into Products([Name], [Price], [Status])
values('Iphone 13', 1200, 2)

insert into Products([Name], [Price])
values('Test', -123)

select * from Products

drop table Users
create table Users(
	[Id] int identity,
	[Name] nvarchar(30) constraint [DF_Users_Name_1] default('Unknown'),
	[Mail] nvarchar(30),
	[CountryId] int,

	constraint [PK_Users_Id_1] primary key([Id]),
	constraint [FK_Users_CountryId_1] foreign key([CountryId]) references Countries([Id]),
	constraint [CK_Users_Mail_1] check([Mail] like '%1@%'),
	constraint [CK_Users_Mail_2] check([Mail] like '%2@%'),
)

alter table Users
drop constraint [CK_Users_Mail_2]

alter table Users
add constraint [CK_Users_Mail_3] check([Mail] like '%3@%')

alter table Users
add constraint [Test] default('Unknown@gmail.com') for [Mail]