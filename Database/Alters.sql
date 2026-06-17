ALTER TABLE Customers
MODIFY name VARCHAR2(35);

ALTER TABLE Customers
MODIFY email VARCHAR2(50); -- Even though the lower standard is 63

ALTER TABLE Customers
ADD CONSTRAINT PhoneNo UNIQUE(PhoneNo);

ALTER TABLE Customers
ADD CONSTRAINT PASSWORD_HASH UNIQUE(PASSWORD_HASH);

RENAME Products TO Shoes;

-- Rename file to changes.sql OR document it later

CREATE TABLE CustomerStatus (
    statusID NUMBER(1) PRIMARY KEY,
    statusName VARCHAR2(10) UNIQUE
);

RENAME CustomerSatus TO CustomerStatus;

INSERT INTO CustomerStatus VALUES (1, 'ACTIVE');
INSERT INTO CustomerStatus VALUES (2, 'INACTIVE');
INSERT INTO CustomerStatus VALUES (3, 'DISABLED');

ALTER TABLE Customers
ADD statusID NUMBER(1);

ALTER TABLE Customers
ADD CONSTRAINT fk_CustomerStatus
FOREIGN KEY(statusID) REFERENCES CustomerStatus(statusID);

UPDATE Customers
SET statusID = 1
WHERE statusID IS NULL;

ALTER TABLE Customers
MODIFY statusID NOT NULL;

-- realised '+' numbers can be 13 characters long, I.E +353xxxxxxxxx
ALTER TABLE Customers
MODIFY PhoneNo VARCHAR2(13);

-- Decided to split name into forename and surname
ALTER TABLE Customers
RENAME COLUMN Name TO Forename;

ALTER TABLE Customers
ADD Surname VARCHAR2(35);

UPDATE Customers
SET Surname = 'test'
WHERE Surname IS NULL;

ALTER TABLE Customers
MODIFY Surname NOT NULL;

ALTER TABLE Customers
RENAME CONSTRAINT SYS_C007564 TO NN_Forename;

ALTER TABLE Customers
RENAME CONSTRAINT SYS_C007565 TO NN_Email;

ALTER TABLE Customers
RENAME CONSTRAINT SYS_C007652 TO NN_StatusID;

ALTER TABLE Customers
RENAME CONSTRAINT SYS_C007653 TO NN_Surname;

SELECT constraint_name, table_name
FROM user_constraints
WHERE constraint_name = 'SYS_C007563';

ALTER TABLE Customers
RENAME CONSTRAINT SYS_C007563 TO PK_Customers;