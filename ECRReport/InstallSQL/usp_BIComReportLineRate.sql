CREATE PROCEDURE dbo.usp_BIComReportLineRate

-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@BandID	VARCHAR(50),
@Comm	FLOAT,
@Type	INT --0 Read All, 1 Just one band, 2 Write

AS 
SET NOCOUNT ON

IF @Type = 0
BEGIN
	SELECT 	KeyName, Value
	FROM	dbo.BIComReportSettings 
	WHERE	KeyName IN ('Line1', 'Line2', 'Line3', 'Line4', 'Line5')

	UNION

	SELECT 	'Line99', 0 --so can reset back
	ORDER BY KeyName, Value
END
ELSE IF @Type = 1
BEGIN
	SELECT 	KeyName, Value
	FROM	dbo.BIComReportSettings 
	WHERE	KeyName = @BandID
	ORDER BY KeyName, Value
END
ELSE IF @Type = 2
BEGIN
	UPDATE	dbo.BIComReportSettings
	SET	Value = @Comm
	WHERE	KeyName = @BandID
END