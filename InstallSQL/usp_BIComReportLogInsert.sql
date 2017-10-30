CREATE PROCEDURE dbo.usp_BIComReportLogInsert
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@Msg		VARCHAR(100),
@EmpID		INT

AS 
SET NOCOUNT ON

DECLARE @LogID INT
SELECT @LogID = max(logid)+ 1 FROM logtable

INSERT INTO logtable(LogID, [DateTime], LogType, [Description], TerminalID, EmployeeID)
SELECT	@LogID, GETDATE(), 256, @Msg, 1, @EmpID