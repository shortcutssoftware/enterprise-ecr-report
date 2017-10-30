CREATE PROCEDURE dbo.BIComReportLineSelect
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@CompID		INT

AS 
SET NOCOUNT ON

SELECT	[Name], IdNumber, Retail
FROM	dbo.lines l
WHERE	l.CompanyId = @CompID
AND	Retail >= 1
AND	Active = 1
ORDER BY [name]