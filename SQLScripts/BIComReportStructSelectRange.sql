CREATE PROCEDURE dbo.BIComReportStructSelectRange
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@IDComm		INT

AS 
SET NOCOUNT ON

SELECT	CAST([Range 1 from] as int), CAST([Range 1 to] as int), [Service 1 commission], [Retail 1 commission],
	[Sundry 1 commission], CAST([Range 2 from] as int), CAST([Range 2 to] as int), [Service 2 commission], [Retail 2 commission], 
	[Sundry 2 commission], CAST([Range 3 from] as int), CAST([Range 3 to] as int), [Service 3 commission], [Retail 3 commission], [Sundry 3 commission], 
	CAST([Range 4 from]as int), CAST([Range 4 to]as int), [Service 4 commission], [Retail 4 commission], [Sundry 4 commission], CAST([Range 5 from]as int),
	CAST([Range 5 to]as int), [Service 5 commission], [Retail 5 commission], [Sundry 5 commission]
FROM	dbo.commission
WHERE	[Commission Id] = @IDComm