select u.CountryId, max(id) --'test' --count(*) 'count'
from Users u
group by u.CountryId

select c.NAME, max(u.id) count
from Users u
join Countries c on u.CountryId = c.ID
where u.id < 500
group by c.NAME
having count(u.Id) > 5