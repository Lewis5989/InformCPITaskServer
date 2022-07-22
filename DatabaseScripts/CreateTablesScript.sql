
CREATE TABLE Users
(  
    ID int IDENTITY(1,1) PRIMARY KEY ,
	UserName nvarchar(100) NOT NULL,  
    EMail nvarchar(50) NOT NULL,
	Password nvarchar(50) NOT NULL,
);
CREATE TABLE Contacts
(  
	ID int IDENTITY(1,1) PRIMARY KEY,
    UserID int NOT NULL FOREIGN KEY References Users(ID),
	ContactName nvarchar(100), 
    EMail nvarchar(50),
    PhoneNumber nvarchar(50),
);

