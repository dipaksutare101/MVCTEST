 CREATE TABLE [Users](
Userid int NOT NULL,
FirstName Nvarchar(50) Not NULL,
LastName Nvarchar(50) Not NULL,
Email Nvarchar(50) Not NULL,
DateofBirth datetime NULL,
Password Nvarchar(Max) Not NULL,
IsEmailVarified bit null,
ActivationCode uniqueidentifier NULL

)

