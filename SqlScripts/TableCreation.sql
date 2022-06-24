CREATE TABLE BaoFilling (
    Id int NOT NULL PRIMARY KEY,
	[Name] varchar(100) NOT NULL
);

CREATE TABLE Bao (
	Id int NOT NULL PRIMARY KEY,
	BaoFillingId int NOT NULL FOREIGN KEY REFERENCES BaoFilling,
	[Name] varchar(100) NOT NULL,
	IsGlutenFree bit NOT NULL,
	IsVegan bit NOT NULL
);
