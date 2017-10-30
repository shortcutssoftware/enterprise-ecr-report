CREATE FUNCTION [dbo].[fn_GetCommission] (  

@Take Float,
@Band1 Float,
@Comm1 Float,
@Band2 Float,
@Comm2 Float,
@Band3 Float,
@Comm3 Float,
@Band4 Float,
@Comm4 Float,
@Band5 Float,
@Comm5 Float,
@CommType Int)

 
-- CommType(s)
-- 1: Banding as Shortcuts - returns actual commission
-- 2: Target Based - returns actual commission
-- 3: Target Based - returns % commission (Saks requests etc)

RETURNS Float  AS  
BEGIN 

DECLARE @TotComm Float

SET @TotComm=0

--Shortcuts Banded Commission

IF @CommType=1
BEGIN
	IF @Take>@Band1
BEGIN

  IF @Take>@Band2 AND @Band2<>0
  BEGIN
    SET @TotComm=@TotComm+@Comm1*(@Band2-@Band1)
  END

  IF @Take<=@Band2 OR @Band2=0
  BEGIN
    SET @TotComm=@TotComm+@Comm1*(@Take-@Band1)
  END
END


IF @Take>@Band2 AND @Band2>0
BEGIN

  IF @Take>@Band3 AND @Band3<>0
  BEGIN
    SET @TotComm=@TotComm+@Comm2*(@Band3-@Band2)
  END

  IF @Take<=@Band3 OR @Band3=0
  BEGIN
    SET @TotComm=@TotComm+@Comm2*(@Take-@Band2)
  END
END
 

IF @Take>@Band3 AND @Band3>0
BEGIN

  IF @Take>@Band4 AND @Band4<>0
  BEGIN
    SET @TotComm=@TotComm+@Comm3*(@Band4-@Band3)
  END

  IF @Take<=@Band4 OR @Band4=0
  BEGIN
    SET @TotComm=@TotComm+@Comm3*(@Take-@Band3)
  END
END


IF @Take>@Band4 AND @Band4>0
BEGIN

  IF @Take>@Band5 AND @Band5<>0

  BEGIN
    SET @TotComm=@TotComm+@Comm4*(@Band5-@Band4)
  END

  IF @Take<=@Band5 OR @Band5=0
  BEGIN
    SET @TotComm=@TotComm+@Comm4*(@Take-@Band4)
  END
END


IF @Take>@Band5 AND @Band5>0
BEGIN
  SET @TotComm=@TotComm+@Comm5*(@Take-@Band5)
END
END
 

--Target Based Commission

IF @CommType=2 OR @CommType=3
BEGIN

IF @Take>@Band5 AND @Band5>0
BEGIN
  SET @TotComm=@Comm5
END

IF @Take>@Band4 AND @Band4>0 AND @TotComm=0
BEGIN
  SET @TotComm=@Comm4
END


IF @Take>@Band3 AND @Band3>0 AND @TotComm=0
BEGIN
  SET @TotComm=@Comm3
END


IF @Take>@Band2 AND @Band2>0 AND @TotComm=0
BEGIN
  SET @TotComm=@Comm2
END

IF @Take>@Band1 AND @Band1>0 AND @TotComm=0
BEGIN
  SET @TotComm=@Comm1
END

--Return Actual Commission rather than just percentage
IF @CommType=2
BEGIN
  SET @TotComm=@TotComm*@Take
END
END
RETURN @TotComm
END

 

