-- Library Management System Database Schema
-- Created for comprehensive library operations including books, users, lending, reservations, and returns

-- Create Database
CREATE DATABASE LibraryManagementSystem;
USE LibraryManagementSystem;

-- =============================================
-- CORE TABLES
-- =============================================

-- Books Table
CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    BookNumber NVARCHAR(10) NOT NULL UNIQUE,
    Title NVARCHAR(500) NOT NULL,
    Author NVARCHAR(300) NOT NULL,
    Publisher NVARCHAR(200),
    ISBN NVARCHAR(20),
    PublicationYear INT,
    Pages INT,
    Price DECIMAL(10,2),
    Description NVARCHAR(1000),
    Classification NVARCHAR(50),
    CreatedDate DATETIME2 DEFAULT GETDATE(),
    UpdatedDate DATETIME2 DEFAULT GETDATE()
);

-- Book Copies Table
CREATE TABLE BookCopies (
    CopyID INT PRIMARY KEY IDENTITY(1,1),
    BookID INT NOT NULL,
    AccessionNumber NVARCHAR(15) NOT NULL UNIQUE,
    CopyNumber INT NOT NULL,
    CopyType NVARCHAR(20) NOT NULL CHECK (CopyType IN ('Borrowable', 'Reference Only')),
    Location NVARCHAR(100),
    Condition NVARCHAR(20) NOT NULL CHECK (Condition IN ('Excellent', 'Good', 'Fair', 'Poor')),
    Status NVARCHAR(20) NOT NULL DEFAULT 'Available' CHECK (Status IN ('Available', 'Borrowed', 'Reserved', 'Damaged', 'Lost')),
    CreatedDate DATETIME2 DEFAULT GETDATE(),
    UpdatedDate DATETIME2 DEFAULT GETDATE(),
    FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

-- Users/Members Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    UserNumber NVARCHAR(10) NOT NULL UNIQUE,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    FullName AS (FirstName + ' ' + LastName) PERSISTED,
    Gender NVARCHAR(10) NOT NULL CHECK (Gender IN ('Male', 'Female', 'Other')),
    DateOfBirth DATE NOT NULL,
    NationalID NVARCHAR(20) NOT NULL UNIQUE,
    PhoneNumber NVARCHAR(15),
    Email NVARCHAR(100),
    Occupation NVARCHAR(100),
    EmergencyContact NVARCHAR(15),
    MembershipType NVARCHAR(30) NOT NULL CHECK (MembershipType IN ('Borrowing Member', 'Registered Member')),
    MembershipFee DECIMAL(8,2) NOT NULL DEFAULT 500.00,
    RegistrationDate DATE NOT NULL DEFAULT GETDATE(),
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME2 DEFAULT GETDATE(),
    UpdatedDate DATETIME2 DEFAULT GETDATE()
);

-- User Addresses Table
CREATE TABLE UserAddresses (
    AddressID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    AddressLine1 NVARCHAR(200) NOT NULL,
    AddressLine2 NVARCHAR(200),
    City NVARCHAR(100) NOT NULL,
    District NVARCHAR(50) NOT NULL,
    PostalCode NVARCHAR(10),
    CreatedDate DATETIME2 DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- =============================================
-- TRANSACTION TABLES
-- =============================================

-- Book Loans Table
CREATE TABLE BookLoans (
    LoanID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    CopyID INT NOT NULL,
    LoanDate DATE NOT NULL DEFAULT GETDATE(),
    DueDate DATE NOT NULL,
    ReturnDate DATE NULL,
    DaysOverdue AS (CASE WHEN ReturnDate IS NULL AND GETDATE() > DueDate 
                         THEN DATEDIFF(DAY, DueDate, GETDATE()) 
                         WHEN ReturnDate IS NOT NULL AND ReturnDate > DueDate 
                         THEN DATEDIFF(DAY, DueDate, ReturnDate)
                         ELSE 0 END) PERSISTED,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Active' CHECK (Status IN ('Active', 'Returned', 'Overdue', 'Lost')),
    Fine DECIMAL(8,2) DEFAULT 0.00,
    Notes NVARCHAR(500),
    CreatedDate DATETIME2 DEFAULT GETDATE(),
    UpdatedDate DATETIME2 DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (CopyID) REFERENCES BookCopies(CopyID)
);

-- Book Reservations Table
CREATE TABLE BookReservations (
    ReservationID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    BookID INT NOT NULL,
    ReservationDate DATE NOT NULL DEFAULT GETDATE(),
    ExpiryDate DATE NOT NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Active' CHECK (Status IN ('Active', 'Fulfilled', 'Expired', 'Cancelled')),
    NotificationSent BIT DEFAULT 0,
    Notes NVARCHAR(500),
    CreatedDate DATETIME2 DEFAULT GETDATE(),
    UpdatedDate DATETIME2 DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (BookID) REFERENCES Books(BookID)
);



-- =============================================
-- INDEXES FOR PERFORMANCE
-- =============================================

-- Books Table Indexes
CREATE INDEX IX_Books_Title ON Books(Title);
CREATE INDEX IX_Books_Author ON Books(Author);
CREATE INDEX IX_Books_ISBN ON Books(ISBN);
CREATE INDEX IX_Books_Classification ON Books(Classification);

-- BookCopies Table Indexes
CREATE INDEX IX_BookCopies_BookID ON BookCopies(BookID);
CREATE INDEX IX_BookCopies_Status ON BookCopies(Status);
CREATE INDEX IX_BookCopies_AccessionNumber ON BookCopies(AccessionNumber);

-- Users Table Indexes
CREATE INDEX IX_Users_FullName ON Users(FullName);
CREATE INDEX IX_Users_NationalID ON Users(NationalID);
CREATE INDEX IX_Users_MembershipType ON Users(MembershipType);
CREATE INDEX IX_Users_IsActive ON Users(IsActive);

-- BookLoans Table Indexes
CREATE INDEX IX_BookLoans_UserID ON BookLoans(UserID);
CREATE INDEX IX_BookLoans_CopyID ON BookLoans(CopyID);
CREATE INDEX IX_BookLoans_Status ON BookLoans(Status);
CREATE INDEX IX_BookLoans_DueDate ON BookLoans(DueDate);
CREATE INDEX IX_BookLoans_LoanDate ON BookLoans(LoanDate);

-- BookReservations Table Indexes
CREATE INDEX IX_BookReservations_UserID ON BookReservations(UserID);
CREATE INDEX IX_BookReservations_BookID ON BookReservations(BookID);
CREATE INDEX IX_BookReservations_Status ON BookReservations(Status);
CREATE INDEX IX_BookReservations_ReservationDate ON BookReservations(ReservationDate);

-- =============================================
-- INITIAL DATA
-- =============================================

-- =============================================
-- VIEWS FOR COMMON QUERIES
-- =============================================

-- Available Books View
CREATE VIEW vw_AvailableBooks AS
SELECT 
    b.BookID,
    b.BookNumber,
    b.Title,
    b.Author,
    b.Publisher,
    b.Classification,
    COUNT(bc.CopyID) as TotalCopies,
    SUM(CASE WHEN bc.Status = 'Available' THEN 1 ELSE 0 END) as AvailableCopies,
    SUM(CASE WHEN bc.Status = 'Borrowed' THEN 1 ELSE 0 END) as BorrowedCopies,
    SUM(CASE WHEN bc.Status = 'Reserved' THEN 1 ELSE 0 END) as ReservedCopies
FROM Books b
LEFT JOIN BookCopies bc ON b.BookID = bc.BookID
GROUP BY b.BookID, b.BookNumber, b.Title, b.Author, b.Publisher, b.Classification;

-- Active Loans View
CREATE VIEW vw_ActiveLoans AS
SELECT 
    bl.LoanID,
    u.UserNumber,
    u.FullName as BorrowerName,
    b.Title,
    b.Author,
    bc.AccessionNumber,
    bl.LoanDate,
    bl.DueDate,
    bl.DaysOverdue,
    bl.Status,
    bl.Fine
FROM BookLoans bl
INNER JOIN Users u ON bl.UserID = u.UserID
INNER JOIN BookCopies bc ON bl.CopyID = bc.CopyID
INNER JOIN Books b ON bc.BookID = b.BookID
WHERE bl.Status IN ('Active', 'Overdue');

-- Overdue Books View
CREATE VIEW vw_OverdueBooks AS
SELECT 
    bl.LoanID,
    u.UserNumber,
    u.FullName as BorrowerName,
    u.PhoneNumber,
    u.Email,
    b.Title,
    bc.AccessionNumber,
    bl.LoanDate,
    bl.DueDate,
    bl.DaysOverdue,
    bl.Fine
FROM BookLoans bl
INNER JOIN Users u ON bl.UserID = u.UserID
INNER JOIN BookCopies bc ON bl.CopyID = bc.CopyID
INNER JOIN Books b ON bc.BookID = b.BookID
WHERE bl.Status = 'Overdue' OR (bl.Status = 'Active' AND GETDATE() > bl.DueDate);

-- Active Reservations View
CREATE VIEW vw_ActiveReservations AS
SELECT 
    br.ReservationID,
    u.UserNumber,
    u.FullName as MemberName,
    u.PhoneNumber,
    b.Title,
    b.Author,
    br.ReservationDate,
    br.ExpiryDate,
    br.Status
FROM BookReservations br
INNER JOIN Users u ON br.UserID = u.UserID
INNER JOIN Books b ON br.BookID = b.BookID
WHERE br.Status = 'Active';

-- =============================================
-- STORED PROCEDURES
-- =============================================

-- Procedure to Issue a Book
CREATE PROCEDURE sp_IssueBook
    @UserID INT,
    @AccessionNumber NVARCHAR(15),
    @LoanPeriodDays INT = 14
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @CopyID INT;
    DECLARE @DueDate DATE = DATEADD(DAY, @LoanPeriodDays, GETDATE());
    
    -- Get Copy ID and check availability
    SELECT @CopyID = CopyID 
    FROM BookCopies 
    WHERE AccessionNumber = @AccessionNumber AND Status = 'Available';
    
    IF @CopyID IS NULL
    BEGIN
        RAISERROR('Book copy not available for lending', 16, 1);
        RETURN;
    END
    
    BEGIN TRANSACTION;
    
    -- Insert loan record
    INSERT INTO BookLoans (UserID, CopyID, LoanDate, DueDate)
    VALUES (@UserID, @CopyID, GETDATE(), @DueDate);
    
    -- Update copy status
    UPDATE BookCopies 
    SET Status = 'Borrowed', UpdatedDate = GETDATE()
    WHERE CopyID = @CopyID;
    
    COMMIT TRANSACTION;
    
    SELECT 'Book issued successfully' as Message;
END;

-- Procedure to Return a Book
CREATE PROCEDURE sp_ReturnBook
    @AccessionNumber NVARCHAR(15),
    @Fine DECIMAL(8,2) = 0.00
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @LoanID INT;
    DECLARE @CopyID INT;
    
    -- Get active loan for this copy
    SELECT @LoanID = bl.LoanID, @CopyID = bl.CopyID
    FROM BookLoans bl
    INNER JOIN BookCopies bc ON bl.CopyID = bc.CopyID
    WHERE bc.AccessionNumber = @AccessionNumber AND bl.Status IN ('Active', 'Overdue');
    
    IF @LoanID IS NULL
    BEGIN
        RAISERROR('No active loan found for this book', 16, 1);
        RETURN;
    END
    
    BEGIN TRANSACTION;
    
    -- Update loan record
    UPDATE BookLoans 
    SET ReturnDate = GETDATE(), 
        Status = 'Returned',
        Fine = @Fine,
        UpdatedDate = GETDATE()
    WHERE LoanID = @LoanID;
    
    -- Update copy status
    UPDATE BookCopies 
    SET Status = 'Available', UpdatedDate = GETDATE()
    WHERE CopyID = @CopyID;
    
    COMMIT TRANSACTION;
    
    SELECT 'Book returned successfully' as Message;
END;

-- =============================================
-- TRIGGERS
-- =============================================

-- Trigger to update book copy status when loan status changes
CREATE TRIGGER tr_BookLoans_StatusUpdate
ON BookLoans
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Update copy status based on loan status
    UPDATE bc
    SET Status = CASE 
        WHEN i.Status = 'Returned' THEN 'Available'
        WHEN i.Status IN ('Active', 'Overdue') THEN 'Borrowed'
        ELSE bc.Status
    END,
    UpdatedDate = GETDATE()
    FROM BookCopies bc
    INNER JOIN inserted i ON bc.CopyID = i.CopyID
    INNER JOIN deleted d ON i.LoanID = d.LoanID
    WHERE i.Status != d.Status;
END;

-- Trigger to automatically mark loans as overdue
CREATE TRIGGER tr_BookLoans_OverdueCheck
ON BookLoans
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE BookLoans
    SET Status = 'Overdue'
    WHERE LoanID IN (SELECT LoanID FROM inserted)
    AND Status = 'Active'
    AND GETDATE() > DueDate;
END;

PRINT 'Library Management System database schema created successfully!';