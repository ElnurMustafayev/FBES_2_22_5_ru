drop table Comments
drop table Blogs

create table Blogs(
	[Id] int primary key identity,
	[Title] nvarchar(200) not null,
	[Content] nvarchar(200) null
)

create table Comments(
	[Id] int primary key identity,
	[Content] nvarchar(200) not null,
	[BlogId] int foreign key references Blogs([Id]) on delete cascade not null,
)

insert into Blogs([Title], [Content])
values('Title', 'Something')

insert into Comments([Content], [BlogId])
values('test', 1),('hahaha', 1),('loool', 1)

delete Blogs where Id = 1

-- необходимо вывести комментарии того блога, контент которого равен "Something"
select c.[Content], b.[Content]
from Comments c
join Blogs b on c.BlogId = b.Id and b.Content = 'Something'


select * from Comments