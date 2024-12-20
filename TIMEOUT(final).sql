USE [test5]
GO
/****** Object:  StoredProcedure [dbo].[TimeOut]    Script Date: 12/10/2024 10:40:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[TimeOut]
    @EmployeeID int,
	@SelectedDate DateTime
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TimeIn DateTime;
    DECLARE @TimeOut DateTime;
    DECLARE @TotalHours decimal(5,2);
    DECLARE @ExistingTimeOut DateTime;

    -- Check if there's already a TimeOut record for the employee today
    SELECT @ExistingTimeOut = TimeOut
    FROM Attendance
    WHERE EmployeeID = @EmployeeID 
        AND [Date] = CAST(@SelectedDate AS DATE)
        AND TimeOut IS NOT NULL;

    -- If there's already a TimeOut record, throw an error
    IF @ExistingTimeOut IS NOT NULL
    BEGIN
        -- Throw an error message that can be captured in C#
        THROW 50001, 'Employee has already timed out today.', 1;
    END

    -- Get the TimeIn record for today (if it exists)
    SELECT @TimeIn = TimeIn
    FROM Attendance
    WHERE EmployeeID = @EmployeeID 
        AND [Date] = CAST(@SelectedDate AS DATE) 
        AND TimeOut IS NULL;

    -- If no TimeIn record found for today, throw an error
    IF @TimeIn IS NULL
    BEGIN
        -- Throw an error message that can be captured in C#
        THROW 50002, 'No Time In record found for today.', 1;
    END

    -- Set the current time as the TimeOut
    SET @TimeOut = @SelectedDate;

    -- Calculate the total hours worked (TimeOut - TimeIn)
    SET @TotalHours = DATEDIFF(MINUTE, @TimeIn, @TimeOut) / 60.0;

    -- Update the attendance record with TimeOut and TotalHours
    UPDATE Attendance
    SET TimeOut = @TimeOut, TotalHours = @TotalHours
    WHERE EmployeeID = @EmployeeID 
        AND [Date] = CAST(@SelectedDate AS DATE) 
        AND TimeOut IS NULL;

    PRINT 'TimeOut successful.';
END


