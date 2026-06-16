ALTER TABLE Customers
MODIFY name VARCHAR2(35);

ALTER TABLE Customers
MODIFY email VARCHAR2(50); -- Even though the lower standard is 63

ALTER TABLE Customers
MODIFY PhoneNo VARCHAR2(12);