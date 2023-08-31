create table Users(
	Id uniqueidentifier primary key DEFAULT NEWID(),
	Firstname nvarchar(30) not null,
	Lastname nvarchar(30) not null,
	BirthDate datetime2 null,
)

drop table Users

insert into Users(Firstname, Lastname, BirthDate)
values	('Yaver', 'Usta', '1980-03-17'),
		('Ann', 'Brown', '2012-03-17'),
		('Bob', 'Marley', '2020-12-15')

select * from Users



--drop table Users

--create table Users(
--	Id int primary key identity(1,1),
--	Firstname nvarchar(30) not null,
--	Lastname nvarchar(30) not null,
--	BirthDate datetime2 null,
--)

--insert into Users(Firstname, Lastname, BirthDate)
--values	('Yaver', 'Usta', '1980-03-17'),
--		('Ann', 'Brown', '2012-03-17'),
--		('Bob', 'Marley', '2020-12-15')

--select * from Users

--delete from Users
--where Id = 5









--create table Users(
--	Id int primary key,
--	Firstname nvarchar(30) not null,
--	Lastname nvarchar(30) not null,
--	BirthDate datetime2 null,
--)

--insert into Users(Id, Firstname, Lastname, BirthDate)
--values(3, 'Yaver', 'Usta', '1980-03-17')
--values(2, 'Ann', 'Brown', '2012-03-17')
--values(1, 'Bob', 'Marley', '2020-12-15')

--select * from Users

