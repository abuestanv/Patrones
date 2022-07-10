
CREATE DATABASE DB_PATRONES;

CREATE TABLE USERS (
    UserId int identity,
	UserCode nvarchar(50) not null unique,
	UserName nvarchar(200) not null,
	email nvarchar(200) not null,
	[password] nvarchar(100)
	primary key (UserId)
)

insert into USERS (UserCode, UserName, email, [password]) values 
	('abuestan', 'Andres Buestan', 'abuestan@gmail.com', '12345678')
	
insert into USERS (UserCode, UserName, email, [password]) values 
	('cmoreno', 'Cristian Moreno', 'more22286@gmail.com', '12345678')


SELECT * FROM USERS