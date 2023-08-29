-- CRUD (Create Read Update Delete)

--insert into Products
--values('Test', 10.5, 1, 1)

--insert into Products
--values('Test', 1, 1)





--insert into Products
--values	('One', 111, 0, 1),
--			('Two', 222, 0, 0),
--			('Three', 333, 1, 1)



--insert into Products ([Name], [IsBestseller], [Price], [IsActive])
--values ('Something', 1, 34.5, 1)


insert into People (Firstname, Lastname, Mail, Gender, Age, IsMarried) 
values (N'Ülvi', N'Əliyev😁', 'Test@gmail.com', 'Male', 40, 1);


select *
from People p
--where p.Firstname = N'Ülvi'
--where p.Mail = 'salam@gmail.com' or p.Mail = 'ok@gmail.com'
where p.Mail in ('salam@gmail.com', 'ok@gmail.com') or p.Firstname in (N'Ülvi')