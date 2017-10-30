CREATE PROCEDURE dbo.usp_BIComReportLineSelect
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@CompID		INT

AS 
SET NOCOUNT ON

SELECT	[Name], IdNumber, Retail, Value
FROM	dbo.lines l
JOIN	dbo.BIComReportSettings r ON r.KeyName = 'line' + CAST(l.Retail AS VARCHAR(2))
WHERE	l.CompanyId = @CompID
AND	Retail >= 1
AND	Active = 1
ORDER BY [name]