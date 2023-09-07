begin transaction
	begin try
		-- 1
		insert into Users(Name)
		values('Kate')

		-- 2
		delete from Users
		where Id = 8

		commit transaction

		-- 3
		insert into Countries(NAME, ISO)
		values('NAME', '78')

		-- 4
		delete from Users
		where Id = 2

		commit transaction
	end try
	begin catch
		print @@TRANCOUNT

		IF @@TRANCOUNT > 0
			rollback transaction
	end catch

select * from Countries
select * from UsersGroups