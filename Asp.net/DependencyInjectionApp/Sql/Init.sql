create database DependencyInjectionDb;

use DependencyInjectionDb;

create table Products (
    [Id] int primary key identity,
    [Name] nvarchar(50),
    [Price] float,
    [InStock] bit,
    [Discount] float,
)