CREATE PROCEDURE dbo.usp_BIComReportStructSelectRange
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          July 07 - Version 2 update to custom table
-----------------------------------------------------------------------------------------------------------------------

@IDComm		INT,
@Type		INT

AS 
SET NOCOUNT ON

IF EXISTS (SELECT Band1 FROM dbo.BIComReportBands WHERE CommTypeID = @Type AND StructureID = @IDComm)
BEGIN

	SELECT	Band1, Comm1, Band2, Comm2, Band3, Comm3, Band4, Comm4, Band5, Comm5, Band6, Comm6, Band7, Comm7, Band8, Comm8, CommOrWage
	FROM	dbo.BIComReportBands 
	WHERE	CommTypeID = @Type
	AND	StructureID = @IDComm

	RETURN 0
END
ELSE BEGIN
	RETURN 1
END

