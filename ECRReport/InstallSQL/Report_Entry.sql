DECLARE @REPORTID INT
SELECT 	@REPORTID = MAX([ID NUMBER]) FROM REPORTS WHERE [ID NUMBER] BETWEEN 900 and 950

SET @REPORTID = @REPORTID + 1

DELETE FROM REPORTS WHERE [FILENAME] = 'ExtendedCommReport'

DECLARE @BaseReportId INT
SELECT @BaseReportId = [ID NUMBER] FROM REPORTS WHERE [FILENAME] = 'commission'

INSERT REPORTS([ID NUMBER], [NAME], [DEFAULT TYPE], GRAPHICAL, [DESCRIPTION], [FILENAME], [BITMAP], 
	REPORTCATEGORY, [TEMP TABLE FUNCTION], [INDUSTRY ID], CLIENTID, ACTIVE, SECURITYBASEREPORTID)
VALUES (@REPORTID, 'Commission/Wages Report - Extended', 0, 0, 'The extended commissions report based on the settings made within the external commissions application', 'ExtendedCommReport', NULL,
	3, NULL, 1, 0, 1, @BaseReportId)
	
EXEC usp_SetInitPOSLevelReportPermissions @REPORTID, @BaseReportId


	