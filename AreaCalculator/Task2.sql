SELECT P.ProductName, C.CategoryName
FROM Products P
         LEFT JOIN ProductCategory PC ON P.ProductID = PC.ProductID
         LEFT JOIN Categories C ON C.CategoryID = PC.CategoryID;