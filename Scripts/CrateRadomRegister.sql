--Generate ramdom registers
DECLARE @CONT AS INT;
SET @CONT = 0;
WHILE ( SELECT COUNT(Id) FROM CustomerTable) <= 100
BEGIN  
    INSERT INTO CustomerTable(Name, PhoneNumber, Email, Notes, State) 
	VALUES ('UserNumber' + CAST(@CONT AS VARCHAR),
	(SELECT RIGHT('12345678'+cast(cast(99999999*rand(checksum(newid())) AS BIGINT) AS VARCHAR(8)),8)),
	'UserNumberEmail' +  CAST(@CONT AS VARCHAR), 'Hi i`m a customer', 1);
	SET @CONT += 1;
END