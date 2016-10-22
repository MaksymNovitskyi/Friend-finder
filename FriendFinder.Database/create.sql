CREATE DATABASE FriendFinder
--REVIEW TK: 'Id' is considered as bad practice.(unmarked)
USE FriendFinder

GO
CREATE TABLE Person
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(30) NOT NULL,
	Surname NVARCHAR(30) NOT NULL,
	DateOfBirth DATE NOT NULL,
	Gender NVARCHAR(1) NOT NULL
);
GO
CREATE TABLE Territory
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Region NVARCHAR(40) NOT NULL,
	City NVARCHAR(40) NOT NULL
);
GO
CREATE TABLE Questionary
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Education NVARCHAR(40) NULL,
	FavoriteMusicGenre NVARCHAR(30) NULL,
	FavoriteMovieGenre NVARCHAR(30) NULL,
	ViewsOnSmoking INT NOT NULL,
	ViewsOnAlcohol INT NOT NULL,
	PoliticalViews NVARCHAR(30) NULL
);
GO
CREATE TABLE Participant
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,	
----REVIEW TK: It looks like PersonID should be UNIQUE, but it depends on your 'design'.
	PersonID INT NOT NULL FOREIGN KEY REFERENCES Person(Id),
	TerritoryID INT NOT NULL FOREIGN KEY REFERENCES Territory(Id),
	QuestionaryID INT NOT NULL FOREIGN KEY REFERENCES Questionary(Id),	
----REVIEW TK: Please name your KEYs and be more consistant with Id/ID!
	PhotoLink NVARCHAR(400) NULL,
	EmailAddress NVARCHAR(50) NOT NULL,
	PasswordHash NVARCHAR(200) NOT NULL  
);
GO