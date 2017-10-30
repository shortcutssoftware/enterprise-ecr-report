CREATE PROCEDURE dbo.BIComReportReadKeyInt

-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@Key	 	VARCHAR(100)

AS 
SET NOCOUNT ON

DECLARE @Temp AS INTEGER
EXECUTE master..xp_regread 'HKEY_LOCAL_MACHINE', 'Software\ShortCuts\BI\ReportComm', @Key, @Temp OUTPUT   
RETURN 	@Temp