CREATE TABLE Appointments (
    AppointmentID   INT             IDENTITY(1,1) PRIMARY KEY,
    FirstName       NVARCHAR(50)    NOT NULL,
    LastName        NVARCHAR(50)    NOT NULL,
    Email           NVARCHAR(100)   NOT NULL,
    Gender          NVARCHAR(10)    NOT NULL,
    CellPhone       NVARCHAR(10)    NULL,
    MobilePhone     NVARCHAR(10)    NULL,
    Address         NVARCHAR(200)   NOT NULL,
    Town            NVARCHAR(100)   NOT NULL,
    Parish          NVARCHAR(50)    NOT NULL,
    IsNewPatient    NVARCHAR(3)     NOT NULL,
    AppointmentType NVARCHAR(100)   NOT NULL,
    AppointmentDate DATE            NOT NULL,
    AppointmentTime NVARCHAR(20)    NOT NULL,
    DoctorName      NVARCHAR(100)   NOT NULL,
    Notes           NVARCHAR(500)   NULL,
    CreatedAt       DATETIME        DEFAULT GETDATE()
)