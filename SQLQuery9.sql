USE [test5]
GO
/****** Object:  StoredProcedure [dbo].[AddEmployeeAccount]    Script Date: 11/22/2024 12:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Cyrile Cortes>
-- Create date: <11/22/24>
-- Description:	<Employee Acc>
-- =============================================
ALTER PROCEDURE [dbo].[AddEmployeeAccount]
	-- Add the parameters for the stored procedure here
    @lastname VARCHAR(30),
    @firstname VARCHAR(30),
    @middlename VARCHAR(30),
    @DoB DATE,
    @gender VARCHAR(30),
    @position VARCHAR(30),
    @PhoneNum VARCHAR(30),
    @username VARCHAR(30),
    @password VARCHAR(30)
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	-- Insert into EmployeeDetail
    INSERT INTO EmployeeDetail (lastname, firstname, middlename, DoB, gender, position, [status])
    VALUES (@lastname, @firstname, @middlename, @DoB, @gender, @position, @PhoneNum);

    -- Capture the new EmployeeID
    DECLARE @newEmployeeID INT;
    SET @newEmployeeID = SCOPE_IDENTITY();

    -- Insert into Account table using the captured EmployeeID
    INSERT INTO Account (username, [password], employeeID)
    VALUES (@username, @password, @newEmployeeID);
END
