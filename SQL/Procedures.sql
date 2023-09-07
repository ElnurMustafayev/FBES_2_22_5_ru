alter procedure TestProc
	@num int,
	@name nvarchar(30)
as
begin
	select @num, @name
	from Users
end

execute dbo.TestProc 123, 'Test'



alter proc ChangeCountry
	@CountryId int,
	@CountryNewName nvarchar(100)
as
begin
	update Countries 
	set NAME = @CountryNewName
	where ID = @CountryId

	--return 10
end

select * from Countries c where c.ID = 111

declare @result int
exec @result = ChangeCountry 111, 'Test'
print @result