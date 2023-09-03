create database TestDb;

use TestDb;

create table Countries(
	[Code] int primary key,
	[Name] nvarchar(30) not null,
	[Capital] nvarchar(30) null,
)

insert into Countries([Code], [Name], [Capital])
values	(994, 'Azerbaijan', 'Baku'),
		(7, 'Russia', 'Moscow'),
		(380, 'Ukraine', 'Kiev')

create table Users(
	[Id] int primary key identity,
	[Name] nvarchar(30) not null,
	[Surname] nvarchar(30) null,
	[CountryCode] int foreign key references Countries([Code])
)

insert into Users([Name], [Surname], [CountryCode])
values	('Ilham', 'Test', 380),
		('Ilham', 'Aliyev', 994),
		('Elnur', 'Mustafayev', 994),
		('Pavel', 'Durov', 7),
		('Bob', 'Marley', NULL)


select Users.[Name], Users.[Surname] --, Countries.[Name], Countries.[Capital]
from Users
join Countries on Users.CountryCode = Countries.Code

select u.[Name], u.[Surname], c.[Capital]
from Users u
join Countries c on u.CountryCode = c.Code

select *
from Users u
join Countries c on u.Name = c.Capital --u.CountryCode = c.Code


create table Contacts(
	[Name] nvarchar(50) not null,
	[Phone] nvarchar(30) not null,
	[CountryCode] int null
)

select *
from Users u
join Contacts cnt on u.Name = cnt.Name
join Countries ctr on cnt.Name = ctr.Name







-- Products (FK to ProductStatuses)
-- ProductStatuses (Bestseller, Sold out, Default)

-- необходимо вывести на экран названия продуктов и название их соответствующего статуса



create table ProductStatuses(
	[Id] int primary key identity,
	[Name] nvarchar(50) not null unique,
)

insert into ProductStatuses([Name])
values('Bestseller'),('Sold out'),('Default')


create table Products(
	[Id] int primary key identity,
	[Name] nvarchar(50) not null,
	[StatusId] int foreign key references ProductStatuses([Id])
)

insert into Products([Name], [StatusId])
values	('Harry Potter book', 1),
		('Car', null), 
		('Iphone', 1), 
		('Tv', 3), 
		('PC', 2)


select p.Name, ps.Name
from Products p
join ProductStatuses ps on p.StatusId = ps.Id

select p.Name, ps.Name
from ProductStatuses ps
join Products p on p.StatusId = ps.Id


select p.Name, ps.Name
from Products p
join ProductStatuses ps on p.StatusId = ps.Id
where 'test' in (p.Name, ps.Name) --ps.Name like N'best%er' --ps.Name like N'%s%' --ps.Name like N'sold%'


select p.[Name], ps.[Name]
from Products p
join ProductStatuses ps on p.StatusId = ps.Id

select *
from Products p
full join ProductStatuses ps on p.StatusId = ps.Id










create table Shop(
	[Id] int primary key identity,
	[Name] nvarchar(20)
)

create table Products(
	[Id] int primary key identity,
	[Name] nvarchar(20),
	[ShopId] int foreign key references Shop([Id])
)

insert into Shop([Name])
values('Maxi.az'),('Kontakt Home'),('ISpace')

insert into Products([Name], [ShopId])
values('Bob', null), ('Iphone', 3),('Tv', 2),('PC', 2)

select *
from Products p
--inner join Shop s on p.ShopId = s.Id
--full join Shop s on p.ShopId = s.Id
--left join Shop s on p.ShopId = s.Id
right join Shop s on p.ShopId = s.Id