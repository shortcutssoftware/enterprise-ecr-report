CREATE PROCEDURE dbo.usp_BIComReportStructSelect
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

AS 
SET NOCOUNT ON


SELECT 	[Commission Id],  [Schedule Name]
FROM	dbo.commission