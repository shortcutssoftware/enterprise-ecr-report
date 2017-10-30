-----------------------------------------------------------------------------------------------------------------------
--Department	Business Intelligence (UK )
--Created By:	Daniel Foster
--Application:	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------


--Dont drop if already there as want to save existing settings
IF NOT EXISTS (SELECT [name] FROM sysobjects WHERE [name] = 'BIComReportBands' AND type = 'U')
BEGIN

	CREATE TABLE dbo.BIComReportBands 
	(StructureID	INT, 
	CommTypeID	INT, --1 Service, 2 Retail (money), 3 Retail (quant), 4 Sundry
	Band1	FLOAT,		
	Comm1	FLOAT,
	Band2	FLOAT,		
	Comm2	FLOAT,
	Band3	FLOAT,		
	Comm3	FLOAT,
	Band4	FLOAT,		
	Comm4	FLOAT,
	Band5	FLOAT,		
	Comm5	FLOAT,
	Band6	FLOAT,		
	Comm6	FLOAT,
	Band7	FLOAT,		
	Comm7	FLOAT,
	Band8	FLOAT,		
	Comm8	FLOAT,
	CommOrWage	BIT
	)
		
	--By Default this adds an entry for all comm structures
	INSERT INTO BIComReportBands (StructureID, CommTypeID, Band1, Comm1, Band2, Comm2, Band3, Comm3, Band4, Comm4, Band5, Comm5, Band6, Comm6, Band7, Comm7, Band8, Comm8, CommOrWage)
	SELECT	[Commission Id], 1, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0, 0
	FROM	Commission

	INSERT INTO BIComReportBands (StructureID, CommTypeID, Band1, Comm1, Band2, Comm2, Band3, Comm3, Band4, Comm4, Band5, Comm5, Band6, Comm6, Band7, Comm7, Band8, Comm8, CommOrWage)
	SELECT	[Commission Id], 2, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0, 0
	FROM	Commission

	INSERT INTO BIComReportBands (StructureID, CommTypeID, Band1, Comm1, Band2, Comm2, Band3, Comm3, Band4, Comm4, Band5, Comm5, Band6, Comm6, Band7, Comm7, Band8, Comm8, CommOrWage)
	SELECT	[Commission Id], 3, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0, 0
	FROM	Commission
	
END