--------------------------------------------------------------------------------
-- DROPS
--------------------------------------------------------------------------------
DROP TABLE SALES_ITEMS CASCADE CONSTRAINTS;
DROP TABLE SALES CASCADE CONSTRAINTS;
DROP TABLE SHOES CASCADE CONSTRAINTS;
DROP TABLE CUSTOMERS CASCADE CONSTRAINTS;
DROP TABLE CUSTOMERSTATUS CASCADE CONSTRAINTS;

DROP SEQUENCE SALES_ITEMS_SEQ;
DROP SEQUENCE SALES_SEQ;
DROP SEQUENCE PRODUCT_SEQ;
DROP SEQUENCE CUSTOMER_SEQ;

--------------------------------------------------------------------------------
-- Sequences
--------------------------------------------------------------------------------

CREATE SEQUENCE CUSTOMER_SEQ START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE PRODUCT_SEQ  START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE SALES_SEQ    START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE SALES_ITEMS_SEQ START WITH 1 INCREMENT BY 1;


--------------------------------------------------------------------------------
-- Tables
--------------------------------------------------------------------------------
CREATE TABLE CustomerStatus (
    statusID NUMBER(1) PRIMARY KEY,
    statusName VARCHAR2(10) UNIQUE
);

CREATE TABLE CUSTOMERS (
    CUSTOMERID NUMBER PRIMARY KEY,
    FIRSTNAME VARCHAR2(35) NOT NULL,
    SURNAME VARCHAR2(35) NOT NULL,
    EMAIL VARCHAR2(50) NOT NULL UNIQUE,
    PHONENO VARCHAR2(13) UNIQUE,
    ADDRESS VARCHAR2(150),
    PASSWORD_HASH VARCHAR2(256) UNIQUE,
    STATUSID NUMBER NOT NULL,
    
    CONSTRAINT fk_CustomerStatus
    FOREIGN KEY(statusID) 
    REFERENCES CustomerStatus(statusID)
);

CREATE TABLE SHOES (
    PRODUCTID NUMBER(4) PRIMARY KEY,
    NAME VARCHAR2(20),
    COLOUR VARCHAR2(10),
    MANUFACTURER VARCHAR2(20),
    QTY NUMBER(5),
    PRICE NUMBER(5,2),
    TYPE VARCHAR(10) NOT NULL
);

CREATE TABLE SALES (
    SALEID NUMBER PRIMARY KEY,
    SALES_DATE DATE NOT NULL,
    TOTAL NUMBER(10,2) NOT NULL,
    CUSTOMERID NUMBER NOT NULL,

    CONSTRAINT FK_SALES_CUSTOMER
    FOREIGN KEY (CUSTOMERID)
    REFERENCES CUSTOMERS(CUSTOMERID)
);

CREATE TABLE SALES_ITEMS (
    SALEITEMID NUMBER PRIMARY KEY,
    QUANTITY NUMBER NOT NULL,
    PRODUCTID NUMBER NOT NULL,
    SALEID NUMBER NOT NULL,

    CONSTRAINT FK_SALES_ITEMS_SALE
    FOREIGN KEY (SALEID)
    REFERENCES SALES(SALEID),

    CONSTRAINT FK_SALES_ITEMS_SHOES
    FOREIGN KEY (PRODUCTID)
    REFERENCES SHOES(PRODUCTID)
);

--------------------------------------------------------------------------------
-- Inserts
--------------------------------------------------------------------------------
INSERT INTO CustomerStatus VALUES (1, 'ACTIVE');
INSERT INTO CustomerStatus VALUES (2, 'INACTIVE');
INSERT INTO CustomerStatus VALUES (3, 'DISABLED');

--------------------------------------------------------------------------------

INSERT INTO Customers VALUES (CUSTOMER_SEQ.NEXTVAL, 'John', 'Murphy', 'john.murphy@email.com', '0851234567', '12 Oak Drive, Carlow', 'hash_john_123abc', 1);

INSERT INTO Customers VALUES (CUSTOMER_SEQ.NEXTVAL, 'Sarah', 'O''Brien', 'sarah.obrien@email.com', '0872345678', '45 River View, Kilkenny', 'hash_sarah_456def', 1);

INSERT INTO Customers VALUES (CUSTOMER_SEQ.NEXTVAL, 'Michael', 'Kelly', 'michael.kelly@email.com', '0863456789', '7 Main Street, Waterford', 'hash_michael_789ghi', 2);

INSERT INTO Customers VALUES (CUSTOMER_SEQ.NEXTVAL, 'Emma', 'Byrne', 'emma.byrne@email.com', '0834567890', '19 Green Park, Dublin', 'hash_emma_321jkl', 1);

INSERT INTO Customers VALUES (CUSTOMER_SEQ.NEXTVAL, 'David', 'Walsh', 'david.walsh@email.com', '0895678901', '88 Harbour Road, Cork', 'hash_david_654mno', 3);

--------------------------------------------------------------------------------

INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'Air Max 90', 'White', 'Nike', 25, 139.99, 'Trainer');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'Air Force 1', 'Black', 'Nike', 30, 119.99, 'Casual');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'UltraBoost', 'Grey', 'Adidas', 18, 159.99, 'Runner');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'Gazelle', 'Blue', 'Adidas', 22, 99.99, 'Casual');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'Chuck 70', 'Red', 'Converse', 15, 94.99, 'Casual');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'Run Star', 'White', 'Converse', 12, 109.99, 'Trainer');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'Suede XL', 'Green', 'Puma', 20, 109.99, 'Casual');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'RS-X', 'Black', 'Puma', 16, 129.99, 'Trainer');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, '574 Core', 'Navy', 'New Balance', 28, 104.99, 'Runner');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, '530', 'Silver', 'New Balance', 19, 114.99, 'Runner');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'Classic', 'White', 'Reebok', 24, 89.99, 'Trainer');
INSERT INTO Shoes VALUES (PRODUCT_SEQ.NEXTVAL, 'Club C', 'Cream', 'Reebok', 21, 99.99, 'Casual');

--------------------------------------------------------------------------------

INSERT INTO SALES VALUES (SALES_SEQ.NEXTVAL, TO_DATE('2026-06-01','YYYY-MM-DD'), 259.98, 1);

INSERT INTO SALES VALUES (SALES_SEQ.NEXTVAL, TO_DATE('2026-06-03','YYYY-MM-DD'), 159.99, 2);

INSERT INTO SALES VALUES (SALES_SEQ.NEXTVAL, TO_DATE('2026-06-05','YYYY-MM-DD'), 229.98, 4);

INSERT INTO SALES VALUES (SALES_SEQ.NEXTVAL, TO_DATE('2026-06-07','YYYY-MM-DD'), 89.99, 3);

INSERT INTO SALES VALUES (SALES_SEQ.NEXTVAL, TO_DATE('2026-06-10','YYYY-MM-DD'), 329.97, 5);

--------------------------------------------------------------------------------

INSERT INTO SALES_ITEMS VALUES (SALES_ITEMS_SEQ.NEXTVAL, 1, 1, 1);

INSERT INTO SALES_ITEMS VALUES (SALES_ITEMS_SEQ.NEXTVAL, 1, 3, 1);

INSERT INTO SALES_ITEMS VALUES (SALES_ITEMS_SEQ.NEXTVAL, 1, 3, 2);

INSERT INTO SALES_ITEMS VALUES (SALES_ITEMS_SEQ.NEXTVAL, 1, 5, 3);

INSERT INTO SALES_ITEMS VALUES (SALES_ITEMS_SEQ.NEXTVAL, 2, 11, 3);

INSERT INTO SALES_ITEMS VALUES (SALES_ITEMS_SEQ.NEXTVAL, 1, 12, 4);

INSERT INTO SALES_ITEMS VALUES (SALES_ITEMS_SEQ.NEXTVAL, 3, 4, 5);

INSERT INTO SALES_ITEMS VALUES (SALES_ITEMS_SEQ.NEXTVAL, 1, 7, 5);