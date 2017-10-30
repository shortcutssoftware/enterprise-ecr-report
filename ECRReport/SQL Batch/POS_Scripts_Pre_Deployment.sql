DECLARE @REPORTID INT
SELECT 	@REPORTID = MAX([ID NUMBER]) FROM REPORTS WHERE [ID NUMBER] BETWEEN 900 and 950

SET @REPORTID = @REPORTID + 1

DELETE FROM REPORTS WHERE [FILENAME] = 'ExtendedCommReport'

INSERT REPORTS([ID NUMBER], [NAME], [DEFAULT TYPE], GRAPHICAL, [DESCRIPTION], [FILENAME], [BITMAP], 
	REPORTCATEGORY, [TEMP TABLE FUNCTION], [INDUSTRY ID], CLIENTID, ACTIVE)
VALUES (@REPORTID, 'Extended Commissions Report', 0, 0, 'Extended commissions report based on the settings made within the commissions application', 'ExtendedCommReport', NULL,
	3, NULL, 1, 0, 1)
GO

CREATE PROCEDURE dbo.BIComReportWriteKeyInt

-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@Key	 	VARCHAR(100),
@Value		INT

AS 
SET NOCOUNT ON

EXECUTE master..xp_regwrite 'HKEY_LOCAL_MACHINE', 'Software\ShortCuts\BI\ReportComm', @Key, 'REG_DWORD', @Value
GO



CREATE PROCEDURE dbo.BIComReportReadKeyInt

-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@Key	 	VARCHAR(100)

AS 
SET NOCOUNT ON

DECLARE @Temp AS INTEGER
EXECUTE master..xp_regread 'HKEY_LOCAL_MACHINE', 'Software\ShortCuts\BI\ReportComm', @Key, @Temp OUTPUT   
RETURN 	@Temp
GO


----------------------
------ADD KEYS -------
----------------------

BIComReportWriteKeyInt 'Tax', 1 
GO
BIComReportWriteKeyInt 'Period', 1 
GO
BIComReportWriteKeyInt 'Type', 1 
Go
BIComReportWriteKeyInt 'Sundry', 1
Go
BIComReportWriteKeyInt 'Ref', 1
Go
BIComReportWriteKeyInt 'Retail', 1
Go
BIComReportWriteKeyInt 'ServiceCost', 1
Go
BIComReportWriteKeyInt 'BillFee', 0
Go
BIComReportWriteKeyInt 'Wage', 1
Go
BIComReportWriteKeyInt 'TipFee', 0
Go
BIComReportWriteKeyInt 'Split', 100
Go
BIComReportWriteKeyInt 'Logged', 1
Go
BIComReportWriteKeyInt 'Count', 1
Go


CREATE PROCEDURE dbo.BIComReportCompSelect
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
GO


CREATE PROCEDURE dbo.BIComReportLineSelect
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@CompID		INT

AS 
SET NOCOUNT ON

SELECT	[Name], IdNumber, Retail
FROM	dbo.lines l
WHERE	l.CompanyId = @CompID
AND	Retail >= 1
AND	Active = 1
ORDER BY [name]
GO

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
GO


CREATE PROCEDURE dbo.BIComReportStructSelect
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
GO


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
GO

CREATE PROCEDURE dbo.BIComReportStructUpdateRange
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@IDComm		INT,
@1f		INT,
@2f		INT,
@3f		INT,
@4f		INT,
@5f		INT,
@1sc		FLOAT,
@2sc		FLOAT,
@3sc		FLOAT,
@4sc		FLOAT,
@5sc		FLOAT,
@1rc		FLOAT,
@2rc		FLOAT,
@3rc		FLOAT,
@4rc		FLOAT,
@5rc		FLOAT,
@1t		INT,
@2t		INT,
@3t		INT,
@4t		INT,
@5t		INT,
@1suc		FLOAT,
@2suc		FLOAT,
@3suc		FLOAT,
@4suc		FLOAT,
@5suc		FLOAT

AS 
SET NOCOUNT ON

UPDATE	dbo.commission
SET	[Range 1 from] = @1f,
	[Range 2 from] = @2f,
	[Range 3 from] = @3f,
	[Range 4 from] = @4f,
	[Range 5 from] = @5f,
	[Service 1 commission] = @1sc,
	[Service 2 commission] = @2sc,
	[Service 3 commission] = @3sc,
	[Service 4 commission] = @4sc,
	[Service 5 commission] = @5sc,
	[Retail 1 commission] = @1rc,
	[Retail 2 commission] = @2rc,
	[Retail 3 commission] = @3rc,
	[Retail 4 commission] = @4rc,
	[Retail 5 commission] = @5rc,
	[Range 1 to] = @1t,
	[Range 2 to] = @2t,
	[Range 3 to] = @3t,
	[Range 4 to] = @4t,
	[Range 5 to] = @5t,
	[Sundry 1 commission] = @1suc,
	[Sundry 2 commission] = @2suc,
	[Sundry 3 commission] = @3suc,
	[Sundry 4 commission] = @4suc,
	[Sundry 5 commission] = @5suc
WHERE	[Commission Id] = @IDComm
GO