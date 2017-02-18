SELECT
	Batch.BatchID, 
	Batch.Opened_User,
	Batch.Opened_Time,
	COUNT(WireMain.WireID) AS "Number of Wires", 
	SUM(CAST(MandatoryFields.WireAmount AS float)) AS "Total Wire Amt",
	Batch.OFAC_Verified
FROM Batch
	INNER JOIN WireMain
		ON Batch.BatchID = WireMain.FK_BatchID
	INNER JOIN MandatoryFields
		ON WireMain.WireID = MandatoryFields.FK_WireID
GROUP BY Batch.BatchID, Batch.Opened_User, Batch.Opened_Time, Batch.OFAC_Verified