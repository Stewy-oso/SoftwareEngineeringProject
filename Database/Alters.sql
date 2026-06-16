ALTER TABLE Customers
MODIFY name VARCHAR2(35);

ALTER TABLE Customers
MODIFY email VARCHAR2(50); -- Even though the lower standard is 63

ALTER TABLE Customers
MODIFY PhoneNo VARCHAR2(12);

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