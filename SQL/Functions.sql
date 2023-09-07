select 100

print 10 + 123
print len('test')

declare @num int
set @num = 100
set @num += 10
print @num

select @num




create function SayHello()
returns int
as
begin
	return 10
end

alter function SayHello()
returns nvarchar(20)
as
begin
	return 'Hello World!'
end



select dbo.SayHello() 'test'
print dbo.SayHello()


select * from Countries

create function GetCountryById(@countryId int)
returns nvarchar(20)
as
begin
	return	(select top 1 c.NAME
			from Countries c
			where c.ID = @countryId)
end

alter function GetCountryById(@countryId int)
returns nvarchar(20)
as
begin
	declare @countryName nvarchar(20)

	set @countryName =	(select top 1 c.NAME
						from Countries c
						where c.ID = @countryId)

	return @countryName
end

alter function GetCountryById(@countryId int)
returns nvarchar(20)
as
begin
	declare @countryName nvarchar(20)

	select @countryName = c.NAME
	from Countries c
	where c.ID = @countryId

	return @countryName
end


select dbo.GetCountryById(u.Id)
from Users u



-- необходимо написать функцию MySum

-- select dbo.MySum('test', 123)	=> 127
-- select dbo.MySum('salam', 7)		=> 12
-- select dbo.MySum('q', -2)		=> -1


create function MySum(@str nvarchar(100), @num int)
returns int
as
begin
	return (len(@str) + @num)
end

select dbo.MySum('test', 123)
select dbo.MySum('salam', 7)
select dbo.MySum('q', -2)




create function MySum(@str nvarchar(100), @num int)
returns int
as
begin
	return (len(@str) + @num)
end

if 1 = 2
	print('if')
else if 1 = 3
	print('else if')
else
	select * from Users


declare @num int
set @num = 10
while @num >= 0
begin
	set @num = @num - 1
	print(@num)
end


alter function GetAdultUsers()
returns table
as
	return (select * from Users where Age >= 18)

select * from GetAdultUsers()