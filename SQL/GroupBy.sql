select u.CountryId, max(id) --'test' --count(*) 'count'
from Users u
group by u.CountryId

select c.NAME, count(u.id) count
from Users u
join Countries c on u.CountryId = c.ID
--where u.id < 500
group by c.NAME
--having count(u.Id) >= 7
having (c.NAME like 'A%') and (count(u.Id) >= 5)




select u.Name, u.Age, 'test'
from Users u
group by u.Name, u.Age