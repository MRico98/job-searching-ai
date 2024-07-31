BEGIN
    CREATE DATABASE JobSearchingDB;
END
GO

USE JobSearchingDB;
GO

BEGIN
    CREATE TABLE Companies (
        Id INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(255) NOT NULL,
        Location NVARCHAR(255) NOT NULL
    );

    CREATE TABLE Jobs (
        Id INT PRIMARY KEY,
        Name NVARCHAR(255) NOT NULL,
        SubrogatedId INT NOT NULL,
        Description NVARCHAR(MAX),
        CompanyId INT,
        FOREIGN KEY (CompanyId) REFERENCES Companies(Id)
    );

    CREATE TABLE Recommendations (
        Id INT PRIMARY KEY IDENTITY(1,1),
        JobId INT UNIQUE,
        Recommendation NVARCHAR(MAX),
        FOREIGN KEY (JobId) REFERENCES Jobs(Id)
    );
END
GO