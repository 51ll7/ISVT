use UchetVT;
create table General 
(
	ID int primary key NOT NULL IDENTITY(1,1),
	Room nvarchar(40) NOT NULL,
	Quantity int NOT NULL
);
create table Computers
(
	ID int primary key NOT NULL IDENTITY(1,1),
	IDRoom int NOT NULL,
	[Description] nvarchar(40) NOT NULL,
	Price money NOT NULL,
	ReceivingDate datetime
);
create table Components
(
	ID int primary key NOT NULL IDENTITY(1,1),
	IDComputers int NOT NULL,
	[Description] nvarchar(40) NOT NULL,
	Price money NOT NULL
)