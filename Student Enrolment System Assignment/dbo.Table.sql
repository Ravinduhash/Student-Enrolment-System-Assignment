CREATE TABLE [dbo].[Table]
(
    [Registration Number] INT NOT NULL, 
    [Student Name] VARCHAR(50) NOT NULL, 
    [Date of Birth] DATETIME NOT NULL, 
    [Gender] CHAR(1) NOT NULL, 
    [Contact Number] VARCHAR(10) NOT NULL, 
    [Course enrolled in] VARCHAR(20) NOT NULL, 
    PRIMARY KEY ([Registration Number])
)
