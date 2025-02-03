select p.productid ,p.productname,p.price from products p inner join  favorites f on f.PId=P.ProductId where uid=9
delete from favorites where pid=1 and uid=9
ALTER TABLE Products ALTER COLUMN Price DECIMAL(10,2);
Select * from Users where username="n" and password='{password'