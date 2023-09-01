select * from Products p
select * from ProductStatuses ps

select count(*) 'All products'' count'
from Products p

select count(p.StatusId) 'All products'' count with status'
from Products p

select count(*) 'Bestsellers count'
from Products p
where p.StatusId = 1


select p.Name, len(p.Name)
from Products p


--select *
--from Products p
--where count(*) > 3

select count(*) as count
from Products p
where len(p.Name) >= 5

select abs(-p.Id), avg(p.Id), min(p.Id), max(p.Id)
from Products p