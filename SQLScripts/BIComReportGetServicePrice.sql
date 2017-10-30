CREATE PROCEDURE usp_BIComReportGetServicePrice
@StaffID Int,
@ServiceID Int,
@BlockID Int,
@Cost Float OUTPUT,
@TaxDue Float OUTPUT
AS

--SQL for Saks Service Data

BEGIN



--SET @StaffID=195
--SET @ServiceID=481
--SET @ServiceID=301
--SET @BlockID=1


DECLARE @LevelID Int
DECLARE @TaxRate Float

SET @LevelID=
(SELECT TOP 1 "Level" FROM Employs WHERE idNumber=@StaffID)

--Get cost for that level
SET @Cost=
(SELECT TOP 1 Cost FROM ServLevl WHERE "Level"=@LevelID AND "Service ID"=@ServiceID AND Block=@BlockID)


IF @Cost is Null OR @Cost=0
--Then get default cost
BEGIN

  IF @BlockID=1 
  BEGIN
    SET @Cost=
    (SELECT TOP 1 "Cost 1" FROM Services WHERE idNumber=@ServiceID)
  END 

  IF @BlockID=2 
  BEGIN
    SET @Cost=
    (SELECT TOP 1 "Cost 2" FROM Services WHERE idNumber=@ServiceID)
  END 

  IF @BlockID=3 
  BEGIN
    SET @Cost=
    (SELECT TOP 1 "Cost 3" FROM Services WHERE idNumber=@ServiceID)
  END 

  IF @BlockID=4 
  BEGIN
    SET @Cost=
    (SELECT TOP 1 "Cost 4" FROM Services WHERE idNumber=@ServiceID)
  END 

  IF @BlockID=5 
  BEGIN
    SET @Cost=
    (SELECT TOP 1 "Cost 5" FROM Services WHERE idNumber=@ServiceID)
  END 

  IF @BlockID=6 
  BEGIN
    SET @Cost=
    (SELECT TOP 1 "Cost 6" FROM Services WHERE idNumber=@ServiceID)
  END 

END

SET @TaxRate =
(SELECT Top 1 "Rate 1" FROM Tax INNER JOIN Services ON Tax."id"=Services."Tax ID"
WHERE idNumber=@ServiceID)

IF @TaxRate is NOT Null
BEGIN
 SET @TaxDue=@TaxRate*@Cost
END

END

RETURN

GO