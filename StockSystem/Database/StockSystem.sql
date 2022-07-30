-- Dropping tables, triggers vb.
DROP TABLE productInfo;
DROP TABLE productPrice;
DROP TABLE company;
DROP TABLE companyProduct;
DROP TABLE stockProduct;
DROP TABLE stockCompany;

DROP SEQUENCE pid_seq;

DROP VIEW companyProduct_view;
DROP VIEW stockTracking_view;

DROP TRIGGER stockEntryDate_trigger_stockCompany;
DROP TRIGGER updateStock_stockProduct_trigger;
DROP TRIGGER updatePrice_productPrice_trigger;
DROP TRIGGER pid_seq_trigger;
DROP TRIGGER insertDateTime_trigger;
DROP TRIGGER updateDateTime_trigger;
DROP TRIGGER insertDateTime_trigger_productPrice;
DROP TRIGGER updateDateTime_trigger_productPrice;
DROP TRIGGER insertDateTime_trigger_company;
DROP TRIGGER updateDateTime_trigger_company;
DROP TRIGGER insertDateTime_trigger_companyProduct;
DROP TRIGGER updateDateTime_trigger_companyProduct;
DROP TRIGGER insertDateTime_trigger_stockCompany; 
DROP TRIGGER updateDateTime_trigger_stockCompany;
DROP TRIGGER insertDateTime_trigger_stockProduct; 
DROP TRIGGER updateDateTime_trigger_stockProduct;


INSERT INTO productInfo(pname,barcode,sim,pic,price,stock) VALUES('Chocolate', 12345, '453123468', '', 6.99, 10);
INSERT INTO productPrice(pid,price) VALUES(1,12.2);

/* getting data */
SELECT * FROM productInfo;
SELECT * FROM productPrice;
SELECT * FROM company;
SELECT * FROM companyProduct;
SELECT * FROM stockCompany;
SELECT * FROM stockProduct;
SELECT * FROM stockTracking_view;

SELECT * FROM stockTracking_view WHERE stockEntryDate BETWEEN TO_DATE('23/7/2022', 'DD/MM/YYYY') AND TO_DATE('26/7/2022', 'DD/MM/YYYY');


CREATE VIEW companyProduct_view AS
    SELECT P.pid,P.pname,C.cid,C.cname,CP.insertDateTime,CP.updateDateTime
    FROM companyProduct CP
    INNER JOIN productInfo P ON CP.pid = P.pid
    INNER JOIN company C ON CP.cid = C.cid;

CREATE VIEW stockTracking_view AS
    SELECT C.cname,P.pname,P.price,SP.quantity,P.stock,SC.status,SC.stockEntryDate,SC.irsaliyeDate,SC.irsaliyeNo
    FROM productInfo P, company C, stockCompany SC, stockProduct SP, companyProduct CP
    WHERE C.cid = SC.cid AND P.pid = SP.pid AND P.pid = CP.pid AND C.cid = CP.cid;

CREATE TABLE productInfo(
    pid NUMBER(38) Primary Key,
    pname VARCHAR2(100),
    barcode VARCHAR2(100),
    sim NUMBER(38),
    pic VARCHAR2(200),
    price NUMBER(5,2),
    stock NUMBER(38) DEFAULT 0,
    insertDateTime DATE,
    updateDateTime DATE
);

CREATE TABLE productPrice (
    pid NUMBER(38),
    priceValidityDate Date,
    price NUMBER(5,2),
    creationDate Date,
    insertDateTime DATE,
    updateDateTime DATE,
    PRIMARY KEY(pid,priceValidityDate),
    FOREIGN KEY(pid) REFERENCES productInfo(pid)
    ON DELETE CASCADE
);

CREATE TABLE company(
    cid NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1) Primary Key,
    cname VARCHAR(100),
    insertDateTime DATE,
    updateDateTime DATE
);

CREATE TABLE companyProduct(
    cid NUMBER(38),
    pid NUMBER(38),
    insertDateTime DATE,
    updateDateTime DATE,
    PRIMARY KEY(cid,pid),
    FOREIGN KEY(cid) REFERENCES company(cid)
    ON DELETE CASCADE,
    FOREIGN KEY(pid) REFERENCES productInfo(pid)
    ON DELETE CASCADE
);

CREATE TABLE stockProduct(
    sid NUMBER(38),
    pid NUMBER(38),
    quantity NUMBER(38),
    price NUMBER(8,2),
    total NUMBER(8,2),
    insertDateTime DATE,
    updateDateTime DATE,
    PRIMARY KEY(sid,pid),
    FOREIGN KEY(pid) REFERENCES productInfo(pid),
    FOREIGN KEY(sid) REFERENCES stockCompany(sid)
);

CREATE TABLE stockCompany(
    sid NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1) PRIMARY KEY,
    cid NUMBER(38),
    tip NUMBER(38),
    status VARCHAR(100),
    stockEntryDate DATE,
    irsaliyeDate DATE,
    irsaliyeNo NUMBER(38),
    insertDateTime DATE,
    updateDateTime DATE,
    FOREIGN KEY(cid) REFERENCES company(cid)
);

CREATE SEQUENCE pid_seq;

-- for incrementing pid
CREATE TRIGGER pid_seq_trigger
   BEFORE INSERT 
   ON productInfo 
   FOR EACH ROW 
BEGIN

  SELECT pid_seq.nextval
  INTO :new.pid
  FROM dual;

END pid_seq_trigger;

CREATE OR REPLACE TRIGGER stockEntryDate_trigger_stockCompany
BEFORE INSERT OR UPDATE
ON stockCompany
FOR EACH ROW
BEGIN
 :NEW.stockEntryDate := SYSDATE;
END;

-- for updating price in productInfo
CREATE TRIGGER updatePrice_productPrice_trigger
AFTER UPDATE 
ON productPrice 
FOR EACH ROW
BEGIN
    UPDATE productInfo SET price = :NEW.price WHERE pid = :NEW.pid;
END updatePrice_productPrice_trigger;

-- for updating stock in productInfo when stockProduct is inserted
CREATE TRIGGER updateStock_stockProduct_trigger
AFTER INSERT OR UPDATE
ON stockProduct 
FOR EACH ROW
BEGIN
    UPDATE productInfo SET stock = stock + :NEW.quantity WHERE pid = :NEW.pid;
END updateStock_stockProduct_trigger;

-- for insertDateTime ON productInfo
CREATE TRIGGER insertDateTime_trigger 
BEFORE INSERT 
ON productInfo 
FOR EACH ROW
BEGIN
 :NEW.insertDateTime := SYSDATE;
END insertDateTime_trigger;

-- for updateDateTime ON productInfo
CREATE OR REPLACE TRIGGER updateDateTime_trigger 
BEFORE INSERT OR UPDATE
ON productInfo 
FOR EACH ROW
BEGIN
 :NEW.updateDateTime := SYSDATE;
END;


--for insertDateTime ON productPrice
CREATE OR REPLACE TRIGGER insertDateTime_trigger_productPrice  
BEFORE INSERT 
ON productPrice
FOR EACH ROW
BEGIN
 :NEW.insertDateTime := SYSDATE;
END;

-- for updateDateTime ON productPrice
CREATE OR REPLACE TRIGGER updateDateTime_trigger_productPrice 
BEFORE INSERT OR UPDATE
ON productPrice
FOR EACH ROW
BEGIN
 :NEW.updateDateTime := SYSDATE;
END;

-- for insertDateTime ON company
CREATE OR REPLACE TRIGGER insertDateTime_trigger_company  
BEFORE INSERT 
ON company
FOR EACH ROW
BEGIN
 :NEW.insertDateTime := SYSDATE;
END;

-- for updateDateTime ON company
CREATE OR REPLACE TRIGGER updateDateTime_trigger_company
BEFORE INSERT OR UPDATE
ON company
FOR EACH ROW
BEGIN
 :NEW.updateDateTime := SYSDATE;
END;

-- for insertDateTime ON companyProduct
CREATE OR REPLACE TRIGGER insertDateTime_trigger_companyProduct  
BEFORE INSERT 
ON companyProduct
FOR EACH ROW
BEGIN
 :NEW.insertDateTime := SYSDATE;
END;

-- for updateDateTime ON companyProduct
CREATE OR REPLACE TRIGGER updateDateTime_trigger_companyProduct
BEFORE INSERT OR UPDATE
ON companyProduct
FOR EACH ROW
BEGIN
 :NEW.updateDateTime := SYSDATE;
END;

-- for insertDateTime ON stockProduct
CREATE OR REPLACE TRIGGER insertDateTime_trigger_stockProduct  
BEFORE INSERT 
ON stockProduct
FOR EACH ROW
BEGIN
 :NEW.insertDateTime := SYSDATE;
END;

-- for updateDateTime ON stockProduct
CREATE OR REPLACE TRIGGER updateDateTime_trigger_stockProduct
BEFORE INSERT OR UPDATE
ON stockProduct
FOR EACH ROW
BEGIN
 :NEW.updateDateTime := SYSDATE;
END;

-- for insertDateTime ON stockCompany
CREATE OR REPLACE TRIGGER insertDateTime_trigger_stockCompany  
BEFORE INSERT 
ON stockCompany
FOR EACH ROW
BEGIN
 :NEW.insertDateTime := SYSDATE;
END;

-- for updateDateTime ON stockCompany
CREATE OR REPLACE TRIGGER updateDateTime_trigger_stockCompany
BEFORE INSERT OR UPDATE
ON stockCompany
FOR EACH ROW
BEGIN
 :NEW.updateDateTime := SYSDATE;
END;