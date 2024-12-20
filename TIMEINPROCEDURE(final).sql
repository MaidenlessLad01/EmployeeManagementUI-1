USE [test5]
GO
/****** Object:  StoredProcedure [dbo].[TimeIn]    Script Date: 12/10/2024 10:40:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[TimeIn]
    @EmployeeID int,
    @SelectedDate DateTime
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ExistingTimeIn DateTime;

    -- Check if the employee already has a TimeIn record for the selected date
    SELECT @ExistingTimeIn = TimeIn
    FROM Attendance
    WHERE EmployeeID = @EmployeeID 
        AND [Date] = CAST(@SelectedDate AS DATE)
        AND TimeIn IS NOT NULL;

    -- If there's already a TimeIn record for the selected date, throw an error
    IF @ExistingTimeIn IS NOT NULL
    BEGIN
        -- Throw an error message that can be captured in C#
        THROW 50000, 'Employee has already time-in today.', 1;
    END

    -- If no TimeIn record exists, proceed with the time-in process
    DECLARE @TimeIn DateTime = @SelectedDate;

    -- Insert a new record with the current time as TimeIn
    INSERT INTO Attendance (EmployeeID, TimeIn, [Date])
    VALUES (@EmployeeID, @TimeIn, CAST(@SelectedDate AS DATE));

    PRINT 'TimeIn successful.';
END
