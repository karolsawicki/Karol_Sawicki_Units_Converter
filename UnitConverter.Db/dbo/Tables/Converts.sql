CREATE TABLE [dbo].[Converts]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [ConvertTime] DATETIME NULL, 
    [whatUnit] NVARCHAR(50) NULL, 
    [convertFrom] FLOAT NULL, 
    [convertTo] FLOAT NULL, 
    [result] FLOAT NULL
)
