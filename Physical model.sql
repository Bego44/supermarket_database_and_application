CREATE TABLE Admin
(
  Admin_ID int identity(1,1) NOT NULL,
  Admin_name VARCHAR(50) NOT NULL,
  PRIMARY KEY (Admin_ID)
);

CREATE TABLE Customer
(
  Customer_ID int identity(1,1) NOT NULL,
  Customer_name VARCHAR(50) NOT NULL,
  last_purchase_date DATE NOT NULL,
  Total_purchase FLOAT NOT NULL,
  num_orders INT NOT NULL,
  PRIMARY KEY (Customer_ID)
);

CREATE TABLE Product
(
  Product_ID VARCHAR(20) NOT NULL,
  Product_name VARCHAR(20) NOT NULL,
  Price FLOAT NOT NULL,
  Department VARCHAR(20) NOT NULL,
  Quantity INT NOT NULL,
  Expiration_date DATE NOT NULL,
  PRIMARY KEY (Product_ID)
);

CREATE TABLE Account
(
  username VARCHAR(20) NOT NULL,
  password VARCHAR(20) NOT NULL,
  Customer_ID int,
  Admin_ID int,
  FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID),
  FOREIGN KEY (Admin_ID) REFERENCES Admin(Admin_ID)
);

CREATE TABLE Orders
(
  Order_date DATE NOT NULL,
  Order_ID VARCHAR(20) NOT NULL,
  Total_price FLOAT NOT NULL,
  Quantity INT NOT NULL,
  Customer_ID int   NOT NULL,
  Product_ID VARCHAR(20) NOT NULL,
  PRIMARY KEY (Order_ID),
  FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID),
  FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID)
);
create table product_never_bought_for_month(
specific_month date,
);