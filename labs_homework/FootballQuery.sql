use FootballDB

Create Table Player (
	PlayerId INT NOT NULL IDENTITY PRIMARY KEY,
	PlayerName nvarchar(50),
	PlayerPosition nvarchar(50),
	PlayerAge int,
	TeamName nvarchar(50) /* WILL REMOVE TEAMNAME (from players) AFTER V1 IS COMPLETE */
)

CREATE TABLE Team (
	TeamId INT NOT NULL IDENTITY PRIMARY KEY,
	TeamName nvarchar (50),
	TeamStadium nvarchar (50),
	TeamLocation nvarchar (50),
	PlayerId int FOREIGN KEY REFERENCES Player(PlayerId)
)


INSERT INTO Player values('Pierre-Emerick Aubameyang', 'Striker', 31, 'Arsenal')
INSERT INTO Player values('Alexandre Lacazette', 'Striker', 29, 'Arsenal')
INSERT INTO Player values('Bernd Leno', 'Goalkeeper', 28,  'Arsenal')
INSERT INTO Player values('Dani Ceballos', 'Attacking Midfielder', 24, 'Arsenal')
INSERT INTO Player values('Lucas Torreira', 'Defensive Midfielder', 24, 'Arsenal')
INSERT INTO Player values('Kieran Tierney', 'Left Back', 23, 'Arsenal')


INSERT INTO Team values ('Arsenal', 'The Emirates', 'London, Holloway', 1)
INSERT INTO Team values ('Arsenal', 'The Emirates', 'London, Holloway', 1)

SELECT * FROM Player
SELECT * FROM Team