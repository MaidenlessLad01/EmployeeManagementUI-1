USE [test5]
GO
/****** Object:  StoredProcedure [dbo].[ShowEmployeeNames]    Script Date: 12/10/2024 10:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Cyrile Cortes>
-- Create date: <11/23/24>
-- Description:	<Show Employee Names and Position>
-- =============================================
ALTER PROCEDURE [dbo].[ShowEmployeeNames]
	-- Add the parameters for the stored procedure here
	@employeeID int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select Firstname, Lastname, Middlename, Position   
	from EmployeeDetail
	Where  EmployeeID = @employeeID

		
END
