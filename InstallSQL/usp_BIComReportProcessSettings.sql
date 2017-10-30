CREATE PROCEDURE dbo.usp_BIComReportProcessSettings

-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@Key	 	VARCHAR(50),
@Value		INT, --Not used on select
@Type		INT --0 Read, 1 Write

AS 
SET NOCOUNT ON

IF @Type = 1
BEGIN
	UPDATE	dbo.BIComReportSettings
	SET	Value = @Value
	WHERE	KeyName = @Key
END
ELSE BEGIN
	SELECT	Value
	FROM	dbo.BIComReportSettings r (NOLOCK)
	WHERE	KeyName = @Key
END