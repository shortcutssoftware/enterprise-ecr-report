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