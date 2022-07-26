
INSERT INTO Users(UserName, EMail, Password)
VALUES ('John Ironside', 'johns@email.com','Password'),
('Hannah Ironside', 'Hannah@email.com','Password'),
('John Smith', 'john@email.com','Password'),
('Ian Hancock', 'Ians@email.com','Password'),
('Nic Patel', 'Nicks@email.cm','Password');

INSERT INTO Contacts(UserID,ContactName, EMail, PhoneNumber)
VALUES ( null, null,'07708756565'),
(1,'Hannah Ironside', 'Hannah@email.com','07708756501'),
(1,'John Smith', 'john@email.com','07708756502'),
(1,'Ian Hancock', null,'07708756503'),
(1,'Nick','Nicks@email.com',null);
