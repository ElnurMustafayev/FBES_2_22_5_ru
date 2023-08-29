-- Contacts

-- Name, nvarchar(50), not null
-- Phone, nvarchar(30), not null
-- CountryCode, int, null



create table Contacts(
	[Name] nvarchar(50) not null,
	[Phone] nvarchar(30) not null,
	[CountryCode] int null
)

insert into Contacts ([Phone], [Name])
values('+994 51 555-55-55', 'Ilham')

select * from Contacts