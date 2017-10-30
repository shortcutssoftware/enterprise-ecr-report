CREATE PROCEDURE dbo.usp_BIComReportCompSelect
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

AS 
SET NOCOUNT ON

SELECT	[Name], IdNumber
FROM	dbo.companys
WHERE	Retail >= 1
AND	Active = 1
ORDER BY [name]