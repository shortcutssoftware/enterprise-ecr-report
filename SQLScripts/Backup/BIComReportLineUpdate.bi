CREATE PROCEDURE dbo.BIComReportLineUpdate
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@IdNumber	INT,
@Value		INT

AS 
SET NOCOUNT ON

IF @Value <> 0 --just a check!
BEGIN
	UPDATE	dbo.lines
	SET	Retail = @Value
	WHERE 	IdNumber = @IdNumber
	RETURN	1
END