CREATE PROCEDURE dbo.usp_BIComReportServiceUpdate

-----------------------------------------------------------------------------------------------------------------------
--Department	Business Intelligence (UK )
--Created By:	Daniel Foster
--Application:	Commissions Report
--		Uses one sp to either update or select the service costs
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@Select	 	INT, --1 = Select, 0 = Update, 3 = all levels
@ID		INT, --void if @select = 1, 
@Value		FLOAT, --void if @select = 1
@LevID	INT


AS 
SET NOCOUNT ON

IF @Select = 1
BEGIN

	CREATE TABLE #tt1
	(IdNumber	INT,
	Service		VARCHAR(100), --POS-113278 SRijhwani 03/04/2015. Support services name upto 100 characters long
	Cost		FLOAT,
	LevID		INT
	)

	INSERT INTO #tt1
	SELECT 	s.IdNumber, Service, 0, @LevID
	FROM 	services s
	WHERE	Active = 1

	UPDATE	#tt1
	SET		Cost = ISNULL(b.cost, 0)
	FROM	BIComReportServiceCost b
	WHERE	b.IdNumber = #tt1.idnumber
	AND		b.LevID = @LevID

	SELECT * FROM #tt1
	DROP TABLE #tt1

END

ELSE IF @Select = 0
BEGIN

	IF EXISTS (SELECT IdNumber FROM BIComReportServiceCost WHERE IdNumber = @ID AND LevID = @LevID)
	BEGIN
		UPDATE 	BIComReportServiceCost
		SET		Cost = @Value
		WHERE	IdNumber = @ID AND LevID = @LevID
	END
	ELSE BEGIN
		INSERT INTO BIComReportServiceCost(IdNumber, cost, LevID)
		VALUES	(@ID, @Value, @LevID)
	END
END
ELSE IF @Select = 3
BEGIN
	(SELECT 0 AS [Level], 'NO LEVEL/DEFAULT' AS [Name])
	
	UNION

	(SELECT	[Level], Name
	FROM	[level])
END