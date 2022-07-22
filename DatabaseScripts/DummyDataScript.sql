
INSERT INTO Users(FirstName,LastName, EMail, Password)
VALUES ('John', 'Ironside', 'johns@email.com','Password'),
('Hannah', 'Ironside', 'Hannah@email.com','Password'),
('John', 'Smith', 'john@email.com','Password'),
('Ian', 'Hancock', 'Ians@email.com','Password'),
('Nick', 'Patel', 'Nicks@email.cm','Password');

INSERT INTO Contacts(UserID,FirstName,LastName, EMail, PhoneNumber)
VALUES (1,null, null, null,'07708756565'),
(1,'Hannah', 'Ironside', 'Hannah@email.com','07708756501'),
(1,'John', 'Smith', 'john@email.com','07708756502'),
(1,'Ian', 'Hancock', null,'07708756503'),
(1,'Nick', null, 'Nicks@email.com',null);
