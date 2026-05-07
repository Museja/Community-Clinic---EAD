ALTER TABLE [dbo].[Users]
ADD FirstName    NVARCHAR(50)  NULL,
    LastName     NVARCHAR(50)  NULL,
    Gender       NVARCHAR(10)  NULL,
    DateOfBirth  DATE          NULL,
    CellPhone    NVARCHAR(10)  NULL,
    MobilePhone  NVARCHAR(10)  NULL,
    Address      NVARCHAR(200) NULL,
    Town         NVARCHAR(100) NULL,
    Parish       NVARCHAR(50)  NULL,
    CreatedAt    DATETIME      DEFAULT GETDATE();