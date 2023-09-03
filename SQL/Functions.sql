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



select *
from Products p
join Shop s on s.Id < len(p.Name)

select rand()
select day(getdate())

select isnull(p.Name, 'Unknown') 'Product Name'
from Products p

select COALESCE(p.Name, s.Name, 'Unknown') 'Product or Shop Name'
from Products p
full join Shop s on p.ShopId = s.Id


SELECT IIF(500<1000, 'YES', 'NO');

select p.Name, p.Price, iif(p.Price >= 100, 'expensive', 'cheap')
from Products p




select 
	p.Name, 
	case len(p.Name)
		when 0 then 'Empty'
		when 1 then 'Very short'
		when 2 then 'Very short'
		when 3 then 'Very short'
		when 4 then 'Very short'
		when 5 then 'Short'
		when 6 then 'Medium'
		when 7 then 'Long'
		when 8 then 'Very long'
		else 'OMG'
	end 'Name length'
from Products p