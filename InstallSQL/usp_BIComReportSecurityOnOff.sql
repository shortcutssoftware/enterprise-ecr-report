CREATE PROCEDURE dbo.usp_BIComReportSecurityOnOff
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Details:		Returns 0 if security is turned off or 1 if its on
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

AS 
SET NOCOUNT ON

IF (SELECT Value FROM systemsettings s (NOLOCK) WHERE [ID] = 3) = 'Off'
BEGIN
	RETURN 0
END
ELSE BEGIN
	RETURN 1
END 