CREATE PROCEDURE [dbo].[UpdateCustomer]
	@CustomerID INT,
	@FirstName NVARCHAR(30),
	@LastName NVARCHAR(30),
	@EmailAdrress NVARCHAR(50)
AS
BEGIN
	UPDATE [dbo].[Customer]
	SET
		FirstName = @FirstName,
		LastName = @LastName,
		CreatedAt = GETDATE(),
		EmailAddress = @EmailAdrress
	WHERE
		CustomerID = @CustomerID;
END