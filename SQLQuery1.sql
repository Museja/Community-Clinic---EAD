CREATE TABLE Users (
    UserID      INT             IDENTITY(1,1) PRIMARY KEY,
    FirstName   NVARCHAR(50)    NOT NULL,
    LastName    NVARCHAR(50)    NOT NULL,
    Email       NVARCHAR(100)   NOT NULL,
    Gender      NVARCHAR(10)    NOT NULL,
    DateOfBirth DATE            NOT NULL,
    CellPhone   NVARCHAR(10)    NULL,
    MobilePhone NVARCHAR(10)    NULL,
    Address     NVARCHAR(200)   NOT NULL,
    Town        NVARCHAR(100)   NOT NULL,
    Parish      NVARCHAR(50)    NOT NULL,
    CreatedAt   DATETIME        DEFAULT GETDATE()
)