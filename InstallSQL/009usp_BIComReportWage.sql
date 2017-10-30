CREATE PROCEDURE dbo.usp_BIComReportWage

-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@StructureID 	INT,
@Value		BIT, --Not used on select
@Type		INT --0 Read, 1 Write, 2 Reset (make all wage + comm)

AS 
SET NOCOUNT ON

IF @Type = 1
BEGIN
	--IF there is no existing structure in the table to start with then setup a structure
	--Not the best way to do this but its to save an additional table at POS
	IF NOT EXISTS (SELECT Band1 FROM dbo.BIComReportBands  WHERE StructureID = @StructureID AND CommTypeID = 0)
	BEGIN
		INSERT INTO BIComReportBands (StructureID, CommTypeID, Band1, Comm1, Band2, Comm2, Band3, Comm3, Band4, Comm4, Band5, Comm5, Band6, Comm6, Band7, Comm7, Band8, Comm8, CommOrWage)
		VALUES (@StructureID, 0, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,@Value)
	END

	IF NOT EXISTS (SELECT Band1 FROM dbo.BIComReportBands  WHERE StructureID = @StructureID AND CommTypeID = 1)
	BEGIN
		INSERT INTO BIComReportBands (StructureID, CommTypeID, Band1, Comm1, Band2, Comm2, Band3, Comm3, Band4, Comm4, Band5, Comm5, Band6, Comm6, Band7, Comm7, Band8, Comm8, CommOrWage)
		VALUES (@StructureID, 1, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,@Value)
	END

	IF NOT EXISTS (SELECT Band1 FROM dbo.BIComReportBands  WHERE StructureID = @StructureID AND CommTypeID = 2)
	BEGIN
		INSERT INTO BIComReportBands (StructureID, CommTypeID, Band1, Comm1, Band2, Comm2, Band3, Comm3, Band4, Comm4, Band5, Comm5, Band6, Comm6, Band7, Comm7, Band8, Comm8, CommOrWage)
		VALUES (@StructureID, 2, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,@Value)
	END

	IF NOT EXISTS (SELECT Band1 FROM dbo.BIComReportBands  WHERE StructureID = @StructureID AND CommTypeID = 3)
	BEGIN
		INSERT INTO BIComReportBands (StructureID, CommTypeID, Band1, Comm1, Band2, Comm2, Band3, Comm3, Band4, Comm4, Band5, Comm5, Band6, Comm6, Band7, Comm7, Band8, Comm8, CommOrWage)
		VALUES (@StructureID, 3, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,@Value)
	END

	--Then Update
	UPDATE 	dbo.BIComReportBands
	SET	CommOrWage = @Value
	WHERE	StructureID = @StructureID
END
ELSE IF @Type = 0
BEGIN
	SELECT	DISTINCT [Commission Id], [Schedule Name], CAST(ISNULL(CommOrWage,0) ^ 1 AS BIT)  AS 'Wage + Comm', ISNULL(CommOrWage, 0)
	FROM	dbo.commission c (NOLOCK)
	left JOIN	dbo.BIComReportBands b (NOLOCK) ON b.StructureID = c.[Commission Id]
	ORDER BY 1, 2
END
ELSE IF @Type = 2
BEGIN
	UPDATE 	dbo.BIComReportBands
	SET	CommOrWage = 0
END