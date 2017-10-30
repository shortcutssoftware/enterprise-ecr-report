-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------


--Dont drop if already there as want to save existing settings
IF NOT EXISTS (SELECT [name] FROM sysobjects WHERE [name] = 'BIComReportSettings' AND type = 'U')
BEGIN

	CREATE TABLE dbo.BIComReportSettings 
	(KeyName	VARCHAR(50), 
	Value		FLOAT)

	EXEC usp_BIComReportSetDefault 1
END