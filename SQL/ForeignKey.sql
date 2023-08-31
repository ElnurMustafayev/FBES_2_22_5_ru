create table Countries(
	[Code] int primary key,
	[Name] nvarchar(30) not null,
)

insert into Countries([Code], [Name])
values(994, 'Azerbaijan')

--delete from Countries
--where [Code] = 994



create table Users(
	[Id] int primary key identity,
	[Name] nvarchar(30) not null,
	[Surname] nvarchar(30) null,
	[CountryCode] int foreign key references Countries([Code])
)

insert into Users([Name], [Surname])
values('Test', 'Test')

insert into Users([Name], [Surname], [CountryCode])
values('Elnur', 'Mustafayev', 994)

select * from Users