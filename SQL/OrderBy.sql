select *
from Users u
--order by u.Age asc
order by u.Age desc


select top 1 *
from Users u
order by u.Age desc

select top 1 *
from Users u
where u.Age = (select max(Age) from Users)

select c.NAME, count(*)
from Users u
join Countries c on c.ID = u.CountryId
where u.Age >= 30
group by c.NAME
having count(*) <= 8
order by count(*) desc

select *
from Users u
order by u.Age desc, u.Name asc