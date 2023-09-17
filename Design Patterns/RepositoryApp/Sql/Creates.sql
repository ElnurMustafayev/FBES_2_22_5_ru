create database TestDb

use TestDb

--select * from sysobjects

create table Users (
	[Id] int primary key identity,
	[Name] nvarchar(50) not null,
	[Age] int,
)

insert into Users(Name, Age) 
values('John', null)

-- select * from Users

-- if not exists (select * from sysobjects where name='cars' and xtype='U')
--     create table cars (
--         Name varchar(64) not null
--     )
-- go