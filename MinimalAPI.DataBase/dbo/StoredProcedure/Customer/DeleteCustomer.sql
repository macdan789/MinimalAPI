CREATE PROCEDURE [dbo].[DeleteCustomer]
	@CustomerID INT
AS
BEGIN
	DELETE FROM [dbo].[Customer] WHERE CustomerID = @CustomerID;
END
