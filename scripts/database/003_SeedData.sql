-- Seed Initial Data
USE AdvocateOS;
GO

-- Insert Default Roles
INSERT INTO Roles (Name, DisplayName, Permissions) VALUES
(N'Admin', N'مدیر سیستم', N'["*"]'),
(N'Lawyer', N'وکیل', N'["cases:*", "clients:*", "documents:read"]'),
(N'Secretary', N'منشی', N'["cases:read", "clients:read"]');
GO

-- Insert Default Admin User
-- Password: Admin@123 (Hashed with BCrypt)
INSERT INTO Users (Username, PasswordHash, FullName, Email, RoleId) VALUES
(N'admin', N'$2a$11$XxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXx', N'مدیر سیستم', N'admin@advocateos.com', 1);
GO

PRINT 'Seed data inserted successfully!';
