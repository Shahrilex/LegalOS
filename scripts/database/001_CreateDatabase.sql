-- AdvocateOS Database Setup Script
-- نسخه 1.0.0

USE master;
GO

IF EXISTS(SELECT * FROM sys.databases WHERE name = 'AdvocateOS')
BEGIN
    ALTER DATABASE AdvocateOS SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE AdvocateOS;
END
GO

CREATE DATABASE AdvocateOS;
GO

USE AdvocateOS;
GO

PRINT 'Database AdvocateOS created successfully!';
