CREATE PROCEDURE dbo.usp_BIComReportWriteKeyInt

-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@Key	 	VARCHAR(100),
@Value		INT

AS 
SET NOCOUNT ON

EXECUTE master..xp_regwrite 'HKEY_LOCAL_MACHINE', 'Software\ShortCuts\BI\ReportComm', @Key, 'REG_DWORD', @Value