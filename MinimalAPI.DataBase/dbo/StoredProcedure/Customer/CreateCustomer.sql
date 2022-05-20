CREATE PROCEDURE [dbo].[CreateCustomer]
	@FirstName NVARCHAR(30),
	@LastName NVARCHAR(30),
	@EmailAdrress NVARCHAR(50)
AS
BEGIN
	INSERT INTO [dbo].[Customer](FirstName, LastName, CreatedAt, EmailAddress)
	VALUES
	(@FirstName, @LastName, GETDATE(), @EmailAdrress);
END
