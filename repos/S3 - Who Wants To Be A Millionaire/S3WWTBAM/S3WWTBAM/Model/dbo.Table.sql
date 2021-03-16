CREATE TABLE [dbo].[Questions]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	[QuestionNr] int not null,
	[CorrectAnswer] varchar(50) not null,
	[WrongAnswer1] varchar(50) not null,
	[WrongAnswer2] varchar(50) not null,
	[WrongAnswer3] varchar(50) not null,
	[Question] varchar(120) not null
)
