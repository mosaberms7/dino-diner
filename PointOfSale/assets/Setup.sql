USE johnkeller;
GO

DROP TABLE IF EXISTS Demo.InvoiceLine;
DROP TABLE IF EXISTS Demo.Invoice;
DROP TABLE IF EXISTS Demo.OrderLine;
DROP TABLE IF EXISTS Demo.[Order];
GO

CREATE TABLE Demo.[Order]
(
   OrderId INT NOT NULL PRIMARY KEY,
   OrderDate DATE NOT NULL,
   [Name] NVARCHAR(256) NOT NULL UNIQUE
);

CREATE TABLE Demo.OrderLine
(
   OrderLineId INT NOT NULL PRIMARY KEY,
   OrderId INT NOT NULL REFERENCES Demo.[Order](OrderId),
   LineNumber INT NOT NULL,
   Product NVARCHAR(32) NOT NULL,
   Quantity INT,

   UNIQUE(OrderId, LineNumber)
);

CREATE TABLE Demo.Invoice
(
   InvoiceId INT NOT NULL PRIMARY KEY,
   OrderId INT NOT NULL REFERENCES Demo.[Order](OrderId),
   InvoiceDate DATE NOT NULL
);

CREATE TABLE Demo.InvoiceLine
(
   InvoiceLineId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   InvoiceId INT NOT NULL REFERENCES Demo.Invoice(InvoiceId),
   OrderLineId INT NOT NULL REFERENCES Demo.OrderLine(OrderLineId),
   Quantity INT NOT NULL
);
GO

INSERT Demo.[Order](OrderId, OrderDate, [Name])
VALUES
   (10, '2018-10-01', N'Order 1'),
   (20, '2018-10-01', N'Order 2'),
   (30, '2018-10-01', N'Order 3');

INSERT Demo.OrderLine(OrderLineId, OrderId, LineNumber, Product, Quantity)
VALUES
   (101, 10, 1, N'Package of Cool Beans', 10),
   (102, 10, 2, N'Bean Roaster', 1),
   (201, 20, 1, N'Package of Cool Beans', 100),
   (202, 20, 2, N'Bean Roaster', 2),
   (301, 30, 1, N'Package of Cool Beans', 50),
   (302, 30, 2, N'100 ct. 12 oz cups', 2);

INSERT Demo.Invoice(InvoiceId, OrderId, InvoiceDate)
VALUES
   (11, 10, '2018-10-02'),
   (21, 20, '2018-10-03'),
   (22, 20, '2018-10-08'),
   (31, 30, '2018-10-05');

INSERT Demo.InvoiceLine(InvoiceId, OrderLineId, Quantity)
VALUES
   (11, 101, 10),
   (11, 102, 1),
   (21, 201, 75),
   (21, 202, 2),
   (21, 101, 25),
   (31, 301, 50),
   (31, 302, 2);
