SELECT top 1 Product_name
 FROM Product
   INNER JOIN Orders
     ON Product.Product_ID = orders.Product_Id
 GROUP BY Product_name
 ORDER BY sum(Orders.Quantity) desc ;


select Product_name
from Product
where Product. Product_ID=( select Product_ID
                            from orders
                            where datepart(MONTH,orders.Order_date) !=(select top 1 
                                        datepart(MONTH,product_never_bought_for_month.specific_month) 
										from product_never_bought_for_month  )
										)

 select Customer_name
 from Customer
 where datepart(YEAR,GETDATE())-datepart(YEAR,Customer.last_purchase_date)>=1



SELECT top 1 Customer_name
 FROM Customer
   INNER JOIN Orders
     ON Customer.Customer_name = orders.Customer_ID
 GROUP BY Customer_name
 ORDER BY sum(Orders.Total_price) desc;



SELECT TOP 1 Department
 FROM Product INNER JOIN orders
     on Product.Product_ID = orders.Product_Id
 GROUP BY Department
 ORDER BY sum(Orders.Quantity * Orders.Total_Price) DESC ;



select * ,count(orders.Customer_ID) FROM Product INNER JOIN orders
     on Product.Product_ID = orders.Product_Id
group by orders.Product_ID 
