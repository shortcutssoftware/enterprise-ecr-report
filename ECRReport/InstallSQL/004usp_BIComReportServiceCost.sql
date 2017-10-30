-----------------------------------------------------------------------------------------------------------------------
--Department	Business Intelligence (UK )
--Created By:	Daniel Foster
--Application:	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------


IF NOT EXISTS (SELECT [name] FROM sysobjects WHERE [name] = 'BIComReportServiceCost' AND type = 'U')
BEGIN
	CREATE TABLE dbo.BIComReportServiceCost 
	(IdNumber	INT, 
	Cost		FLOAT,
	[LevID]	INT)
END
ELSE IF NOT EXISTS (SELECT	*
					FROM	information_schema.COLUMNS
					WHERE	COLUMN_NAME = 'LevID' 
					AND		TABLE_NAME = 'BIComReportServiceCost'
					AND		TABLE_SCHEMA = 'dbo')
BEGIN
		ALTER TABLE dbo.BIComReportServiceCost
		ADD LevID INT DEFAULT 0
END
