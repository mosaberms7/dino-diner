SELECT IL.InvoiceLineId, I.InvoiceId, O.OrderId, OL.Product, OL.Quantity, IL.Quantity AS InvoicedQuantity
FROM Demo.Invoice I
   INNER JOIN Demo.InvoiceLine IL ON IL.InvoiceId = I.InvoiceId
   INNER JOIN Demo.OrderLine OL ON OL.OrderLineId = IL.OrderLineId
   INNER JOIN Demo.[Order] O ON O.OrderId = OL.OrderId
WHERE I.InvoiceDate = '2018-10-03'
ORDER BY IL.InvoiceLineId ASC;

SELECT IL.InvoiceLineId, I.InvoiceId, O.OrderId, OL.Product, OL.Quantity, IL.Quantity AS InvoicedQuantity
FROM Demo.Invoice I
   INNER JOIN Demo.InvoiceLine IL ON IL.InvoiceId = I.InvoiceId
   INNER JOIN Demo.OrderLine OL ON OL.OrderLineId = IL.OrderLineId
   INNER JOIN Demo.[Order] O ON O.OrderId = I.OrderId
WHERE I.InvoiceDate = '2018-10-03'
ORDER BY IL.InvoiceLineId ASC;
