CREATE PROCEDURE dbo.usp_BIComReportSetDefault

-----------------------------------------------------------------------------------------------------------------------
--Department		Business Intelligence (UK )
--Created By:      	Daniel Foster
--Application:      Commissions Report
--Updates:         
-----------------------------------------------------------------------------------------------------------------------

@Install	INT  --If 1 then INSTALL else UPDATE

AS 
SET NOCOUNT ON

IF @Install = 1 
BEGIN
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('BillFee', '0')

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('BillFeePerOrMon', 1)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Count', 1)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('FX', 1)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Logged', 0)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('PaySeriesFull', 0)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Period', 0)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Ref', 1)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Retail', 2)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('ServiceCost', 1)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Split', 100)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Sundry', 1)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Tax', 1)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('TipFee', 0)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Type', 1)

	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Wage', 1)
	
	--0 No, 1 Yes
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('StockCost', 0)
	
	--0 Exclude Tips, 1 - Include Tips and pay, 2 - Include Tips and do not pay
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Tips', 0)
	
	--Retail Type - 0 is money, 1 is units
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('RetailType', 0)
	
	--Line Rates
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Line1', 0)
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Line2', 0)
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Line3', 0)
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Line4', 0)
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('Line5', 0)
	INSERT INTO BIComReportSettings(KeyName, Value) --So can handle 0 (ie set empty)
	VALUES('Line99', 0)
	
	--Cost per service type - 0 is money, 1 is % (added 06/04/10)
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('SerCostType', 0)
	
	--Apply cost to which block - 1 is first only, 0 to all (added 06/04/10)
	INSERT INTO BIComReportSettings(KeyName, Value)
	VALUES('SerCostBlock', 0)

	
END

ELSE BEGIN

	--Default Values
	UPDATE 	BIComReportSettings
	SET	Value = '0'
	WHERE	KeyName = 'BillFee'

	UPDATE 	BIComReportSettings
	SET	Value = '1'
	WHERE	KeyName = 'BillFeePerOrMon'

	UPDATE 	BIComReportSettings
	SET	Value = '1'
	WHERE	KeyName = 'Count'

	UPDATE 	BIComReportSettings
	SET	Value = '1'
	WHERE	KeyName = 'FX'

	UPDATE 	BIComReportSettings
	SET	Value = '0'
	WHERE	KeyName = 'Logged'

	UPDATE 	BIComReportSettings
	SET	Value = '0'
	WHERE	KeyName = 'PaySeriesFull'

	UPDATE 	BIComReportSettings
	SET	Value = '0'
	WHERE	KeyName = 'Period'

	UPDATE 	BIComReportSettings
	SET	Value = '1'
	WHERE	KeyName = 'Ref'

	UPDATE 	BIComReportSettings
	SET	Value = '2'
	WHERE	KeyName = 'Retail'

	UPDATE 	BIComReportSettings
	SET	Value = '1'
	WHERE	KeyName = 'ServiceCost'

	UPDATE 	BIComReportSettings
	SET	Value = '100'
	WHERE	KeyName = 'Split'

	UPDATE 	BIComReportSettings
	SET	Value = '1'
	WHERE	KeyName = 'Sundry'

	UPDATE 	BIComReportSettings
	SET	Value = '1'
	WHERE	KeyName = 'Tax'

	UPDATE 	BIComReportSettings
	SET	Value = '0'
	WHERE	KeyName = 'TipFee'

	UPDATE 	BIComReportSettings
	SET	Value = '1'
	WHERE	KeyName = 'Type'

	UPDATE 	BIComReportSettings
	SET	Value = '1'
	WHERE	KeyName = 'Wage'

	UPDATE 	BIComReportSettings
	SET	Value = '0'
	WHERE	KeyName = 'StockCost'
	
	--0 Exclude Tips, 1 - Include Tips and pay, 2 - Include Tips and do not pay
	UPDATE 	BIComReportSettings
	SET	Value = '0'
	WHERE	KeyName = 'Tips'
	
	--Retail Type - 0 is money, 1 is units
	UPDATE 	BIComReportSettings
	SET	Value = '0'
	WHERE	KeyName = 'RetailType'
		
	--Cost per service type - 0 is money, 1 is % (added 06/04/10)
	UPDATE 	BIComReportSettings
	SET		Value = '0'
	WHERE	KeyName = 'SerCostType'
	
	--Apply cost to which block - 1 is first only, 0 to all (added 06/04/10)
	UPDATE 	BIComReportSettings
	SET		Value = '0'
	WHERE	KeyName = 'SerCostBlock'


END