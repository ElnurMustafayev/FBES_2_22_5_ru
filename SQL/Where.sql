--select Name, IsMarried 
--from Users
--where 10 > 1


--select Name, IsMarried 
--from Users
----where 'qwerty' = 'qwerty'
--where 'qwerty1' <> 'qwerty'

-- Users.Where(u => u.Age > 30).Select(u => new {u.Age, u.IsMarried})

--select Name, IsMarried 
--from Users
--where Users.Age > 30



--select Name
--from Users
----where Users.Age is not null
----where Users.Age isnull
--where ((Users.Age is null) or (Users.Age >= 18)) and (Surname <> 'Marley')



-- Task:
-- Products
-- Name, Price, IsBestseller, IsActive
-- Add min 5 items
-- Достать названия всех активных бестселлеров, цена которых превышает 100

--select Name
--from Products
--where IsBestseller = 1 and IsActive = 1 and Price >= 100