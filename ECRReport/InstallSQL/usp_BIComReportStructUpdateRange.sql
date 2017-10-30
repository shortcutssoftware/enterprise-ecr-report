CREATE PROCEDURE dbo.usp_BIComReportStructUpdateRange
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          	July 2007 - Restructure for version 2, using own table
-----------------------------------------------------------------------------------------------------------------------

@IDComm		INT,
@Type		INT,
@1f		FLOAT,
@2f		FLOAT,
@3f		FLOAT,
@4f		FLOAT,
@5f		FLOAT,
@6f		FLOAT,
@7f		FLOAT,
@8f		FLOAT,
@1c		FLOAT,
@2c		FLOAT,
@3c		FLOAT,
@4c		FLOAT,
@5c		FLOAT,
@6c		FLOAT,
@7c		FLOAT,
@8c		FLOAT

AS 
SET NOCOUNT ON


IF EXISTS (SELECT StructureID FROM dbo.BIComReportBands WHERE CommTypeID = @Type AND StructureID = @IDComm )
BEGIN
	UPDATE	dbo.BIComReportBands
	SET	Band1 = @1f, 
	Comm1 = @1c, 
	Band2 = @2f, 
	Comm2 = @2c,  
	Band3 = @3f, 
	Comm3 = @3c,  
	Band4 = @4f, 
	Comm4 = @4c,  
	Band5 = @5f, 
	Comm5 = @5c,  
	Band6 = @6f, 
	Comm6 = @6c,  
	Band7 = @7f, 
	Comm7 = @7c,  
	Band8 = @8f, 
	Comm8 = @8c
	WHERE	CommTypeID = @Type
	AND	StructureID = @IDComm
END
ELSE BEGIN
	--Note: for the wage just enter deault value
	INSERT INTO dbo.BIComReportBands (StructureID, CommTypeID, Band1, Comm1, Band2, Comm2, Band3, Comm3, Band4, Comm4, Band5, Comm5, Band6, Comm6, Band7, Comm7, Band8, Comm8, CommOrWage)
	VALUES (@IDComm, @Type, @1f, @1c, @2f, @2c, @3f, @3c, @4f, @4c, @5f, @5c, @6f, @6c, @7f, @7c, @8f, @8c, 0)
END
