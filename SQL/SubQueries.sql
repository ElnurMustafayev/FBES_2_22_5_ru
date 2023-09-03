select *from Users

select max(Age) from Users

select u.Name, u.Age
from Users u
where u.Age < (select max(len(Name)) from Users)


select u.Name, u.Age
from Users u
--where Age < (select top 1 len(Name) from Users u)


select u.Name, u.Age
from Users u
--where Age < (select top 1 len(Name) from Users u)
join (select id, Age from Users u) joinedUsers on joinedUsers.id = u.id

select u.Name, (select max(Name) from Users u)
from Users u





select top 3 Id
from Users u
where u.Name = (select max(Name) from Users)




select Name
from Users u
where u.CountryId = (select min(ID)
					from Countries c
					where c.ISO = (select max(ISO) from Countries))




-- Products (Id, Name, Count, ShopId)
-- Shops (Id, Name)

-- Ќеобходимо вывести названи€ тех магазинов, в которых максимальное число товаров

select s.Name
from Shops s
where s.Id in	(select distinct p.ShopId
				from Products p
				where p.Count = (select max(p.Count) from Products p))


