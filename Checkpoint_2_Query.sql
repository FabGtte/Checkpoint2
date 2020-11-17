CREATE DATABASE CheckpointBravo
GO

USE CheckpointBravo

CREATE TABLE Exam (
	id INT PRIMARY KEY IDENTITY(1,1),
	examName VARCHAR(50) NOT NULL,
	grade INT NOT NULL,
);

CREATE TABLE Student (
	StudentId INT PRIMARY KEY IDENTITY(1,1),
	firstname VARCHAR(50) NOT NULL,
	lastname VARCHAR(50) NOT NULL,
	FK_Exam INT FOREIGN KEY REFERENCES Exam(id)
);

CREATE TABLE Promo (
	id INT PRIMARY KEY IDENTITY(1,1),
	PromoYear INT NOT NULL,
	ProgLanguage VARCHAR(50) NOT NULL,
	FK_Student INT FOREIGN KEY REFERENCES Student(StudentId)
);

INSERT INTO Exam(examName, grade)
	VALUES 
	('Year Average', 16),
	('Year Average', 8),
	('Year Average', 12),
	('Year Average', 15),
	('Year Average', 12),
	('Year Average', 17),
	('Year Average', 7),
	('Year Average', 9),
	('Year Average', 15),
	('Year Average', 14);

INSERT INTO Student(firstname, lastname, FK_Exam)
	VALUES
	('Abraham', 'Lincoln', 1), 
	('François', 'Hollande', 2),
	('Jacques', 'Chiraque', 3),
	('Mahatma', 'Ghandi', 4),
	('Theodore', 'Roosevelt', 5),
	('Napoleon', 'Bonaparte', 6),
	('Marcus', 'Aurelius', 7),
	('Abraham', 'Lincoln', 8),
	('Charles', 'De Gaulle', 9),
	('Antoine', 'De Saint Exupery', 10);

INSERT INTO Promo(PromoYear, ProgLanguage, FK_Student)
	VALUES 
	(2018, 'CSharp', 1), (2018, 'JavaScript', 2),
	(2018, 'CSharp', 3), (2018, 'JavaScript', 4),
	(2018, 'CSharp', 5), (2018, 'JavaScript', 6),
	(2018, 'CSharp', 7), (2018, 'JavaScript', 8),
	(2018, 'CSharp', 9), (2018, 'JavaScript', 10);


