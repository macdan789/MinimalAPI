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
	('Bohdan', 'Marko', GETDATE(), 'markopollo789@gmail.com'),
	('Vasyl', 'Gyz', GETDATE(), 'vasylg@adorama.com'),
	('Yaroslav', 'Bratynskiy', GETDATE(), 'yaroslavb@adorama.com'),
	('Vitaliy', 'Hashchuk', GETDATE(), 'vitaliyh@adorama.com'),
	('Nazar', 'Pleskanka', GETDATE(), 'nazarp@adorama.com')
END