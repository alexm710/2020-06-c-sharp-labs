use DogDB

Create Table Dogs (
	DogsId INT NOT NULL IDENTITY PRIMARY KEY,
	DogName nvarchar(50),
	DogBreed nvarchar(50),
	DogAge int,
	DogSize nvarchar(50)
)

CREATE TABLE Owners (
	OwnerId INT NOT NULL IDENTITY PRIMARY KEY,
	OwnerName nvarchar (50),
	OwnerAge int,
	DogsId int FOREIGN KEY REFERENCES Dogs(DogsId)
	)

	DROP table Owner

INSERT INTO Dogs values('Mavro', 'Schipperke', 17, 'Small')

INSERT INTO Owners values ('Alex', 24, 1)

SELECT * FROM Dogs
SELECT * FROM Owners