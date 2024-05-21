create database IdentityDB;

use IdentityDB;

create table Users (
    [Id] int primary key identity,
    [Name] nvarchar(100),
    [Email] nvarchar(100) unique not null,
    [Password] nvarchar(100) not null,
)

insert into Users([Name], [Email], [Password])
values('', '', '')