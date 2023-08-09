SELECT p.Name, c.Name
FROM ProductsToCategories as pc RIGHT JOIN Product as p ON pc.ProductId=p.Id
                                LEFT JOIN Category as c ON pc.CategoryId=c.Id