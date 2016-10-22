USE FriendFinder
--REVIEW TK:
--@@IDENTITY, returns the last identity value generated for ANY TABLE. This may cause trouble, use SCOPE_INDENTITY() instead.

GO
CREATE PROCEDURE spAddParticipant
    @pName NVARCHAR(30), 
    @pSurname NVARCHAR(30), 
    @pGender NVARCHAR(1),
	@pDateOfBirth DATE, 
    @pRegion NVARCHAR(40),
	@pCity NVARCHAR(40),
	@pEducation NVARCHAR(40) = NULL,
	@pFavoriteMusicGenre NVARCHAR(30) = NULL,
	@pFavoriteMovieGenre NVARCHAR(30) = NULL,
	@pViewsOnSmoking INT,
	@pViewsOnAlcohol INT,
	@pPoliticalViews NVARCHAR(30) = NULL,
	@pPhotoLink NVARCHAR(100) = NULL,
	@pEmailAddress NVARCHAR(50),
	@pPassword NVARCHAR(200),
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON

	DECLARE @countOfEmails INT;

	SET @countOfEmails = (SELECT TOP 1 COUNT(id)
						FROM dbo.Participant
						WHERE EmailAddress = @pEmailAddress);
	
	IF @countOfEmails > 0
	BEGIN
		SET @responseMessage = 'This email exists';
		return;
	END
	
----REVIEW TK: BEGIN TRY/CATCH WON'T REVERT PREVIOUS ACTIONS! Use transactions!!!
    BEGIN TRY
		DECLARE @PersonID int;
		DECLARE @TerritoryID int;
		DECLARE @QuestionaryID int;

		EXEC spGetTerritoryID @Region = @pRegion, @City = @pCity, @Id = @TerritoryID OUTPUT;
		EXEC spAddPerson @Name = @pName, @Surname = @pSurname, @Gender = @pGender, @DateOfBirth = @pDateOfBirth, @Id = @PersonID OUTPUT;
		EXEC spAddQuestionary @Education = @pEducation, @FavoriteMusicGenre = @pFavoriteMusicGenre, 
		@FavoriteMovieGenre = @pFavoriteMovieGenre, @ViewsOnSmoking = @pViewsOnSmoking, 
		@ViewsOnAlcohol = @pViewsOnAlcohol, @PoliticalViews = @pPoliticalViews, 
		@Id = @QuestionaryID OUTPUT;

        INSERT INTO dbo.Participant (PersonID, TerritoryID, QuestionaryID, PhotoLink, EmailAddress, PasswordHash)
        VALUES(@PersonID, @TerritoryID, @QuestionaryID, @pPhotoLink, @pEmailAddress, HASHBYTES('SHA2_512', @pPassword))

        SET @responseMessage='Success'

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH

END

GO 
CREATE PROCEDURE spGetTerritoryID
	@Region NVARCHAR(40),
	@City NVARCHAR(40),
	@Id INT OUTPUT
AS
BEGIN
	SET @Id = (SELECT TOP 1 Id 
	FROM dbo.Territory
	WHERE (Region = @Region) AND (City = @City));

	IF @Id IS NULL
	BEGIN
		EXEC spAddTerritory	@newRegion = @Region, @newCity = @City, @newId = @Id OUTPUT;
	END
END

--REVIEW TK: Calling spAddTerritory by it self might insert duplicates in your table.
--Consider making UNIQUE constraint on Territory table.
--Or merge spGetTerritoryID and spAddTerritory into one procedure.
--Choice depends on your 'design'.
GO
CREATE PROCEDURE spAddTerritory
	@newRegion NVARCHAR(40),
	@newCity NVARCHAR(40),
	@newId INT OUTPUT
AS
BEGIN
	INSERT INTO dbo.Territory
	VALUES(@newRegion, @newCity);

	SET @newId = (SELECT TOP 1 Id 
	FROM dbo.Territory
	WHERE (Region = @newRegion) AND (City = @newCity)); 
END

GO 
CREATE PROCEDURE spAddPerson
	@Name NVARCHAR(30), 
    @Surname NVARCHAR(30), 
	@Gender NVARCHAR(1), 
	@DateOfBirth DATE,
	@Id INT OUTPUT
AS
BEGIN
	INSERT INTO dbo.Person (Name, Surname, DateOfBirth, Gender)
	VALUES(@Name, @Surname, @DateOfBirth, @Gender);

	SET @Id = @@IDENTITY;
END

GO
CREATE PROCEDURE spAddQuestionary
	@Education NVARCHAR(40) = NULL,
	@FavoriteMusicGenre NVARCHAR(30) = NULL,
	@FavoriteMovieGenre NVARCHAR(30) = NULL,
	@ViewsOnSmoking INT,
	@ViewsOnAlcohol INT,
	@PoliticalViews NVARCHAR(30) = NULL,
	@Id INT OUTPUT
AS
BEGIN
	INSERT INTO dbo.Questionary
	VALUES(@Education,
		   @FavoriteMusicGenre,
		   @FavoriteMovieGenre,
		   @ViewsOnSmoking,
		   @ViewsOnAlcohol,
		   @PoliticalViews);

	SET @Id = @@IDENTITY;
END


--REVIEW TK: Use reference CASCADE DELETE in tables.
--Or at least transaction.
GO
CREATE PROCEDURE spRemoveParticipant
	@ParticipantID int
AS
BEGIN
	DELETE FROM dbo.Participant
	WHERE Id = @ParticipantID;

	DELETE FROM dbo.Questionary
	WHERE Id = @ParticipantID;

	DELETE FROM dbo.Person
	WHERE Id = @ParticipantID;
END

GO 
CREATE PROCEDURE spGetAllInfoAboutParticipant
	@ParticipantID int
AS
BEGIN
	SELECT *
	FROM dbo.Participant part
	INNER JOIN dbo.Person pers
	ON (part.PersonID = pers.Id)
	INNER JOIN dbo.Territory terr
	ON (part.TerritoryID = terr.Id)
	INNER JOIN dbo.Questionary ques
	ON (part.QuestionaryID = ques.ID)
	WHERE @ParticipantID = part.Id;
END

GO
CREATE PROCEDURE dbo.spLogin
	@pEmailAddress NVARCHAR(50),
	@pPassword NVARCHAR(200),
    @responseMessage NVARCHAR(250)='' OUTPUT
AS
BEGIN

    SET NOCOUNT ON

    DECLARE @userID INT

    IF EXISTS (SELECT TOP 1 Id FROM dbo.Participant WHERE EmailAddress=@pEmailAddress)
    BEGIN
        SET @userID=(SELECT Id FROM dbo.Participant WHERE EmailAddress=@pEmailAddress AND PasswordHash=HASHBYTES('SHA2_512', @pPassword))

       IF(@userID IS NULL)
           SET @responseMessage='Incorrect password'
       ELSE 
           SET @responseMessage='User successfully logged in'
		   EXEC spGetAllInfoAboutParticipant @ParticipantID = @userID;
    END
    ELSE
       SET @responseMessage='Invalid login'
END


GO
CREATE PROCEDURE spUpdatePerson
	@pId int,
	@pName NVARCHAR(30), 
    @pSurname NVARCHAR(30), 
    @pGender NVARCHAR(1),
	@pDateOfBirth DATE
AS
BEGIN
	UPDATE dbo.Person
	SET Name = @pName, Surname = @pSurname, Gender = @pGender, DateOfBirth = @pDateOfBirth
	WHERE Id = @pId;
END

GO
CREATE PROCEDURE spUpdateTerritory
	@ParticipantID int,
	@pRegion NVARCHAR(40),
	@pCity NVARCHAR(40)
AS
BEGIN
	DECLARE @TerrID int;
	EXEC spGetTerritoryID @Region = @pRegion, @City = @pCity, @Id = @TerrID OUTPUT;
	UPDATE dbo.Participant
	SET TerritoryID = @TerrID
	WHERE Id = @ParticipantID;
END

GO
CREATE PROCEDURE spUpdateQuestionary
	@ParticipantID int,
	@pEducation NVARCHAR(40) = NULL,
	@pFavoriteMusicGenre NVARCHAR(30) = NULL,
	@pFavoriteMovieGenre NVARCHAR(30) = NULL,
	@pViewsOnSmoking INT,
	@pViewsOnAlcohol INT,
	@pPoliticalViews NVARCHAR(30) = NULL
AS
BEGIN
	UPDATE dbo.Questionary
	SET Education = @pEducation,
		FavoriteMusicGenre = @pFavoriteMusicGenre,
		FavoriteMovieGenre = @pFavoriteMovieGenre,
		ViewsOnSmoking = @pViewsOnSmoking,
		ViewsOnAlcohol = @pViewsOnAlcohol,
		PoliticalViews = @pPoliticalViews
	WHERE Id = @ParticipantID;
END

GO
CREATE PROCEDURE spUpdateEmailAddress
	@Id int,
	@pEmailAddress NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Participant
	SET EmailAddress = @pEmailAddress
	WHERE Id = @Id;
END

GO
CREATE PROCEDURE spUpdatePhotoLink
	@Id int,
	@pPhotoLink NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.Participant
	SET PhotoLink = @pPhotoLink
	WHERE Id = @Id;
END

GO
CREATE PROCEDURE spGetTheMostAppropriate
	@ParticipantID INT,
	@Quantity INT
AS
BEGIN

	SELECT TOP(@Quantity) Id
	FROM dbo.Participant
	WHERE Id <> @ParticipantID
	ORDER BY dbo.fnFindDifferenceRate(@ParticipantID, Id);
END

GO
CREATE FUNCTION fnFindDifferenceRate (@myId INT, @othersId INT)
RETURNS INT
AS
BEGIN
	DECLARE @rate INT;
    SET @rate = (SELECT (COUNT(DISTINCT Education) + COUNT(DISTINCT FavoriteMovieGenre) +
	COUNT(DISTINCT FavoriteMusicGenre) + COUNT(DISTINCT ViewsOnSmoking) +
	COUNT(DISTINCT ViewsOnAlcohol) + COUNT(DISTINCT PoliticalViews) - 6)
	FROM ((SELECT * FROM dbo.Questionary WHERE Id = @myID)
	UNION
	(SELECT * FROM dbo.Questionary WHERE Id = @othersID)) AS u);
	RETURN @rate;
END
GO

CREATE PROCEDURE spGetRandomId
	@myID INT
AS
BEGIN
	SELECT TOP 1 Id 
	FROM dbo.Participant 
	WHERE Id <> @myID
	ORDER BY newid();
END