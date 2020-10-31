CREATE PROC spCheckLogin(@STAFF_USERNAME VARCHAR(100), @STAFF_PASSWORD VARCHAR(30))
AS
	BEGIN
		SELECT staff_id, staff_username, staff_password, staff_fullname, staff_citizen_identification, staff_sex, staff_phone, staff_address, staff_birthday, staff_role, staff_status
        FROM staff 
        WHERE staff_username = @STAFF_USERNAME 
              AND staff_password = @STAFF_PASSWORD AND staff_status = 'TRUE'
	END
GO

DROP PROC spCheckLogin

EXEC spCheckLogin @STAFF_USERNAME = 'hieulm', @STAFF_PASSWORD = '123456'