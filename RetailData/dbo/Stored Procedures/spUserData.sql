CREATE PROCEDURE [dbo].[spUserData]
	@Id nvarchar(128)
AS
BEGIN
	SET nocount ON;

	SELECT Id, FirstName, LastName, EmailAddress, CreateDate
	FROM [dbo].[User]
	WHERE Id = @Id;
END
