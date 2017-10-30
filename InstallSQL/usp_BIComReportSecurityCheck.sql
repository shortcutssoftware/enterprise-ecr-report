CREATE PROCEDURE dbo.usp_BIComReportSecurityCheck
-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      	Commissions Report
--Details:		Returns 0 if they DO NOT have access else returns the users id
--Updates:          
-----------------------------------------------------------------------------------------------------------------------

@Pin	VARCHAR(4)

AS 
SET NOCOUNT ON

IF EXISTS (
	SELECT 	DISTINCT SecurityId
	FROM	dbo.employs e (NOLOCK)
	JOIN	dbo.SecurityAccess s (NOLOCK) ON s.ItemId = e.SecurityLevel
	WHERE	e.[password] = @Pin
	AND	SecurityId = 1018 --'Employee Setup' security option taken from dbo.SecurityDescriptor
	AND	active = 1
	)
BEGIN
	SELECT	0 --No permiss
END
ELSE
BEGIN
	--have permiss
	SELECT 	DISTINCT idnumber
	FROM	dbo.employs e (NOLOCK)
	WHERE	e.[password] = @Pin
	AND	active = 1
END