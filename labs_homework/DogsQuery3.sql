use dogDB

Create Table Dogs (
	DogsId INT NOT NULL IDENTITY PRIMARY KEY,
	DogName nvarchar(50),
	DogBreed nvarchar(50),
	DogAge int,
	DogSize nvarchar(50),
	OwnerId int FOREIGN KEY REFERENCES Owners(OwnerId)
)

CREATE TABLE Owners (
	OwnerId INT NOT NULL IDENTITY PRIMARY KEY,
	OwnerName nvarchar (50),
	OwnerAge int,
	)

	DROP TABLE Dogs 
	DROP TABLE OWNERS

select * from dogs
select * from owners
INSERT INTO Dogs values('Mavro', 'Schipperke', 17, 'Small', 1)
INSERT INTO Dogs values('Lil Timmy', 'Labrador', 17, 'Big', 1)
INSERT INTO Dogs values('Shelly', 'Shiba', 17, 'Big', 2)
INSERT INTO Dogs values('Eevie', 'Huskie', 17, 'Big', 3)
INSERT INTO Dogs values('Lola', 'Highland Terrier', 17, 'Medium', 4)
INSERT INTO Dogs values('Lola', 'Yorkshire Terrier', 17, 'Medium', 5)

INSERT INTO Owners values ('Alex', 24)
INSERT INTO Owners values ('Alex', 24)
INSERT INTO Owners values ('Daniel', 24)
INSERT INTO Owners values ('Chen', 24)
INSERT INTO Owners values ('Leo', 24)
INSERT INTO Owners values ('Jemma', 24)



