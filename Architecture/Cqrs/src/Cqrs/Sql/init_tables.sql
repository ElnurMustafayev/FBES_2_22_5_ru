if not exists (select * from sysobjects where name='Wallets' and xtype='U')
begin
    create table Wallets (
        [Id] int primary key identity(1,1),
        [Balance] float not null,
        [Currency] varchar(10) not null,
        [Rate] float not null
    )
end