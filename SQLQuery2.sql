Drop TABLE STORE_INVENTORY, OrderItem, Orders, Member, STORES, Products;


CREATE TABLE Products(
	ID int Primary Key NOT NULL IDENTITY,
	ProductName NVARCHAR(255) NOT NULL,
	ProductPrice MONEY NOT NULL,
	ProductDescription TEXT, 
);


CREATE TABLE STORES(
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	StoreName NVARCHAR(255) NOT NULL,
	StoreLocationAddress TEXT NOT NULL,
	StoreLocationCity TEXT NOT NULL,
	StoreLocationState TEXT NOT NULL,
	StoreLocationCountry TEXT NOT NULL,
	StoreLocationZip NVARCHAR(10) NOT NULL,
	StorePhoneNumber NVARCHAR(10) NOT NULL,

);


CREATE TABLE STORE_INVENTORY(
	
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	ProductID INT FOREIGN KEY REFERENCES Products(ID),
	StoreID INT FOREIGN KEY REFERENCES STORES(ID),
	ProductQuantity INT NOT NULL

);


Create Table Member(
	ID INT Primary Key NOT NULL IDENTITY,
	FirstName NVARCHAR(255) NOT NULL,
	LastName NVARCHAR(255) NOT NULL,
	Role NVARCHAR(255) NOT NULL,
	Email NVARCHAR(255) NOT NULL UNIQUE,
	CustomerLocationAddress TEXT NOT NULL,
	CustomerLocationCity TEXT NOT NULL,
	CustomerLocationState TEXT NOT NULL,
	CustomerLocationCountry TEXT NOT NULL,
	CustomerLocationZip NVARCHAR(5) NOT NULL,
	password NVARCHAR(255) NOT NULL, 
);



CREATE TABLE Orders(

	ID INT PRIMARY KEY NOT NULL IDENTITY,
	CustomerID INT FOREIGN KEY REFERENCES Member(ID),
	DatePlaced DATETIME NOT NULL,
	StoreID INT FOREIGN KEY REFERENCES STORES(ID)


);

CREATE TABLE OrderItem(

	ID INT PRIMARY KEY NOT NULL IDENTITY,
	ORDERID INT FOREIGN KEY REFERENCES Orders(ID),
	PRODUCTID INT FOREIGN KEY REFERENCES Products(ID),
	Quantity INT NOT NULL

);



INSERT INTO STORES(StoreName, StoreLocationAddress, StoreLocationCity, StoreLocationState, StoreLocationCountry, StoreLocationZip, StorePhoneNumber) 
VALUES ('DamionBuy', '100 main avenue', 'Greensboro', 'North Carolina','United States' ,'27410', '2525555555'),
('DamionBuy', '111 main avenue', 'Roanoke Rapids', 'North Carolina','United States' , '27870', '2525555556'),
('DamionBuy', '111 main avenue', 'New York', 'New York','United States', '10003' , '2525555557');


INSERT INTO Products(ProductName, ProductPrice, ProductDescription)
VALUES ('Damionwatch', '150.00', 'Smart Watch'),
('Deenova Laptop Series 1', '999.99', 'Laptop with i9 processor and RTX SUPER GPU'),
('Alienware m15 R3', '1800.00', 'Alienware Laptop with GeForce 2070 SUPER, 512 GB SSD'),
('Apple Iphone X', '999.99', 'Apple cell Phone'),
('Alienware Aurora R11 Desktop', '1500.99', 'Alienware Desktop with RTX 2070 SUPER GPU');


INSERT INTO STORE_INVENTORY(ProductID, StoreID, ProductQuantity) 
VALUES ((select ID from Products where ProductName = 'Damionwatch'), (select ID from STORES where StorePhoneNumber='2525555555'), 1),
((select ID from Products where ProductName = 'Deenova Laptop Series 1'), (select ID from STORES where StorePhoneNumber='2525555555'), 2),
((select ID from Products where ProductName = 'Alienware m15 R3'), (select ID from STORES where StorePhoneNumber='2525555555'), 200),
((select ID from Products where ProductName = 'Apple Iphone X'), (select ID from STORES where StorePhoneNumber='2525555555'), 300),
((select ID from Products where ProductName = 'Alienware Aurora R11 Desktop'), (select ID from STORES where StorePhoneNumber='2525555555'), 20),

((select ID from Products where ProductName = 'Alienware Aurora R11 Desktop'), (select ID from STORES where StorePhoneNumber='2525555556'), 20),
((select ID from Products where ProductName = 'Deenova Laptop Series 1'), (select ID from STORES where StorePhoneNumber='2525555556'), 2),
((select ID from Products where ProductName = 'Alienware m15 R3'), (select ID from STORES where StorePhoneNumber='2525555556'), 200),
((select ID from Products where ProductName = 'Apple Iphone X'), (select ID from STORES where StorePhoneNumber='2525555556'), 300),
((select ID from Products where ProductName = 'Damionwatch'), (select ID from STORES where StorePhoneNumber='2525555556'), 1),


((select ID from Products where ProductName = 'Alienware Aurora R11 Desktop'), (select ID from STORES where StorePhoneNumber='2525555557'), 20),
((select ID from Products where ProductName = 'Deenova Laptop Series 1'), (select ID from STORES where StorePhoneNumber='2525555557'), 2),
((select ID from Products where ProductName = 'Alienware m15 R3'), (select ID from STORES where StorePhoneNumber='2525555557'), 200),
((select ID from Products where ProductName = 'Apple Iphone X'), (select ID from STORES where StorePhoneNumber='2525555557'), 300),
((select ID from Products where ProductName = 'Damionwatch'), (select ID from STORES where StorePhoneNumber='2525555557'), 1);


select SI.*, S.StorePhoneNumber,S.StoreLocationAddress, S.StoreLocationCity,S.StoreLocationState,S.StoreLocationCountry, S.StoreLocationZip, P.ProductName, P.ProductPrice, P.ProductDescription from STORE_INVENTORY as SI LEFT JOIN Products  as P on SI.ProductID = P.ID LEFT JOIN Stores  as S on SI.StoreID = S.ID;

-- select * from STORES; gets everything from the store coloumn 

--SELECT StoreID, SUM(ProductQuantity) from STORES INNER JOIN STORE_INVENTORY on STORES.ID = STORE_INVENTORY.StoreID INNER JOIN Products ON STORE_INVENTORY.ProductID = ProductID GROUP BY StoreID;

 --select * from Member
 --where Email ='damion.silver@revature.com';


 --select Email from Member
 --where email = 'damion.silver@revature.com';

 INSERT INTO Member(FirstName,LastName,Role,Email,CustomerLocationAddress,CustomerLocationCity,CustomerLocationState,CustomerLocationCountry,CustomerLocationZip,Password)
 VALUES('DAMION','SILVER','ADMIN','damion.silver@gmail.com','12312 Main Blvd', 'Greensboro', 'North Carolina','United States', '27870','password');
  select * from Member;

  select * from Stores;

  select * from Products;


  select * from Orders;