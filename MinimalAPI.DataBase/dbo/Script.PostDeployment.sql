--USE @DATABASE;

IF NOT EXISTS (SELECT 1 FROM [dbo].[Customer])
BEGIN
	INSERT INTO [dbo].[Customer] 
	(
		FirstName,
		LastName,
		CreatedAt,
		EmailAddress
	)
	VALUES
	('Bohdan', 'Marko', GETDATE(), 'testemail1@gmail.com'),
	('Vasyl', 'Gyz', GETDATE(), 'testemail2@gmail.com'),
	('Yaroslav', 'Bratynskiy', GETDATE(), 'testemail3@gmail.com'),
	('Vitaliy', 'Hashchuk', GETDATE(), 'testemail4@gmail.com'),
	('Nazar', 'Pleskanka', GETDATE(), 'testemail5@gmail.com')
END
