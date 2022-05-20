CREATE PROCEDURE [dbo].[GetCustomer]
	@CustomerID INT
AS
BEGIN
	SELECT 
		CustomerID,
		FirstName,
		LastName,
		CreatedAt,
		EmailAddress
	FROM [dbo].[Customer]
	WHERE CustomerID = @CustomerID;
END
