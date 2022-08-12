-- Dropping tables, triggers vb.
DROP TABLE productInfo;
DROP TABLE productPrice;
DROP TABLE company;
DROP TABLE companyProduct;
DROP TABLE stockProduct;
DROP TABLE stockCompany;
DROP TABLE soldProduct;

DROP SEQUENCE pid_seq;

DROP VIEW companyProduct_view;
DROP VIEW stockTracking_view;
DROP VIEW selectedCompanyProduct_view;

DROP TRIGGER deleteStock_stockProduct_trigger;
DROP TRIGGER stockProduct_view;
DROP TRIGGER stockCompany_view;
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
DROP TRIGGER addProductPrice_productInfo_trigger;


INSERT INTO productInfo(pname,barcode,sim,pic,price,stock) VALUES('Chocolate', 12345, '453123468', '', 6.99, 10);
INSERT INTO productPrice(pid,price) VALUES(1,12.2);

/* getting data */
SELECT * FROM productInfo;
SELECT * FROM productPrice;
SELECT * FROM company;
SELECT * FROM companyProduct;
SELECT * FROM stockCompany;
SELECT * FROM stockProduct;
SELECT * FROM selectedCompanyProduct_view;
SELECT * FROM stockTracking_view;
SELECT * FROM soldProduct;

SELECT * FROM stockTracking_view WHERE stockEntryDate BETWEEN TO_DATE('7/13/2022','MM/DD/YYYY') AND TO_DATE('8/13/2022','MM/DD/YYYY');

SELECT P.pid,P.pname,P.barcode,P.sim,P.pic,P.price AS FirstPrice,
(SELECT PP.price
FROM productPrice PP
WHERE PP.pid = P.pid AND PP.priceValidityDate = (SELECT MAX (PP_2.priceValidityDate)
                                                FROM productPrice PP_2 
                                                where PP_2.priceValidityDate <= sysdate AND PP.pid = PP_2.pid)) 
                                                AS ValidPrice,P.stock,P.insertDateTime,P.updateDateTime
FROM productInfo P, productPrice PP
WHERE P.pid = PP.pid AND PP.priceValidityDate = (SELECT MAX (PP_2.priceValidityDate)
                                                FROM productPrice PP_2 
                                                where PP_2.priceValidityDate <= sysdate AND PP.pid = PP_2.pid);

SELECT P.pid,P.pname,P.barcode,P.sim,P.pic,P.price AS FirstPrice, PP.price AS ValidPrice,P.stock,P.insertDateTime,P.updateDateTime
FROM productInfo P, productPrice PP
WHERE P.pid = PP.pid;

SELECT * FROM stockTracking_view WHERE stockEntryDate BETWEEN TO_DATE('23/7/2022', 'DD/MM/YYYY') AND TO_DATE('26/7/2022', 'DD/MM/YYYY');


CREATE VIEW companyProduct_view AS
    SELECT P.pid,P.pname,C.cid,C.cname,CP.insertDateTime,CP.updateDateTime
    FROM companyProduct CP
    INNER JOIN productInfo P ON CP.pid = P.pid
    INNER JOIN company C ON CP.cid = C.cid;

CREATE VIEW stockTracking_view AS
    SELECT SC.sid,SC.cid,C.cname,SC.tip,SC.status,SC.stockEntryDate,SC.irsaliyeDate,SC.irsaliyeNo,SC.updateDateTime
    FROM stockCompany SC
    INNER JOIN company C ON SC.cid = C.cid;
    
CREATE VIEW stockCompany_view AS
    SELECT SC.sid,SC.cid,C.cname,SC.tip,SC.status,SC.stockEntryDate,SC.irsaliyeDate,SC.irsaliyeNo,SC.updateDateTime
    FROM stockCompany SC
    INNER JOIN company C ON SC.cid = C.cid;
    
CREATE VIEW stockProduct_view AS
    SELECT SP.sid,SP.pid,P.pname,SP.price,SP.quantity,SP.total,SP.insertDateTime,SP.updateDateTime
    FROM stockProduct SP
    INNER JOIN productInfo P ON SP.pid = P.pid;
    
CREATE VIEW selectedCompanyProduct_view AS
    SELECT P.pid,P.pname,P.price,P.stock,CP.cid
    FROM companyProduct CP
    INNER JOIN productInfo P ON CP.pid = P.pid;

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

CREATE TABLE soldProduct(
    spid NUMBER GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1) Primary Key,
    price NUMBER(5,2),
    quantity NUMBER(38),
    barcode VARCHAR(100),
    cashRegister_No NUMBER(38),
    irsaliyeDate DATE
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

-- for adidng price in productInfo
CREATE TRIGGER addProductPrice_productInfo_trigger
AFTER Insert 
ON productInfo 
FOR EACH ROW
BEGIN
    INSERT INTO productPrice(pid,priceValidityDate,price) VALUES(:NEW.pid,SYSDATE,:NEW.price);
END  addProductPrice_productInfo_trigger;

-- for updating stock in productInfo when stockProduct is inserted
CREATE TRIGGER updateStock_stockProduct_trigger
AFTER INSERT OR UPDATE
ON stockProduct 
FOR EACH ROW
BEGIN
    UPDATE productInfo SET stock = stock + :NEW.quantity WHERE pid = :NEW.pid;
END updateStock_stockProduct_trigger;

-- for updating stock in productInfo when stockProduct is deleting
CREATE TRIGGER deleteStock_stockProduct_trigger
AFTER DELETE
ON stockProduct 
FOR EACH ROW
BEGIN
    UPDATE productInfo SET stock = stock - :old.quantity WHERE pid = :old.pid;
END deleteStock_stockProduct_trigger;

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