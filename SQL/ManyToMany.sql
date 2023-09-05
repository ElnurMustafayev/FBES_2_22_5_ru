-- вывести имена юзеров, находящихся в группе "STEP IT"

create table Users(
	[Id] int primary key identity,
	[Name] nvarchar(100) not null,
)

insert into Users([Name])
values('Elnur'), ('Aykhan'), ('Bob')

create table Groups(
	[Id] int primary key identity,
	[Name] nvarchar(100) not null,
)

insert into Groups([Name])
values('Step IT'), ('Football'), ('Kapital bank')

create table UsersGroups(
	[UserId] int foreign key references Users([Id]) on delete cascade,
	[GroupId] int foreign key references Groups([Id]) on delete cascade,
)

insert into UsersGroups([UserId], [GroupId])
values
(1,1),(1,2),(1,3),
(2,1),(2,2),
(3,3)



select g.Name, u.Name
from UsersGroups ug
join Users u on u.Id = ug.UserId
join Groups g on g.Id = ug.GroupId
where ug.GroupId = 1