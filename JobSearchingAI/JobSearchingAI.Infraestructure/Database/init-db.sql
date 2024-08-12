BEGIN
    CREATE DATABASE JobSearchingDB;
END
GO

USE JobSearchingDB;
GO

BEGIN
    CREATE TABLE Companies (
        Id uniqueidentifier NOT NULL PRIMARY KEY,
        Name NVARCHAR(255) NOT NULL,
    );

    CREATE TABLE Jobs (
        Id uniqueidentifier NOT NULL PRIMARY KEY,
        Name NVARCHAR(255) NOT NULL,
        Description NVARCHAR(255) NOT NULL,
        CompanyId uniqueidentifier,
        FOREIGN KEY (CompanyId) REFERENCES Companies(Id)
    );

    CREATE TABLE Recommendations (
        Id uniqueidentifier NOT NULL PRIMARY KEY,
        Recommendation NVARCHAR(MAX),
        JobId uniqueidentifier UNIQUE,
        FOREIGN KEY (JobId) REFERENCES Jobs(Id)
    );
END
GO