
select * from Customers
select CompanyName,City from Customers

--91 tane ülke kaydı
select Country from Customers 

--21 farklı ülke
select distinct Country from Customers--distinct tekrar eden değerlerden sadece 1 tanesini getirir.

select * from Customers where country ='mexico';

select * from Products where ProductID =1;

select * from Products where UnitPrice <>10;  -- <> eşit değil 10 demek.

select * from Products where UnitPrice between 10 and 15; --10 ile 15 arasında

select * from Customers where Country like 's%n' -- ülke ismi s ile başlayan ve ne ile biten (Spain, Sweden)

select * from Customers where City in('berlin', 'madrid', 'Marseille') --coklu secimler için in kullandık. Şehri berlin,madrid,Marseille olanlar.

select * from Customers where country ='France' And City ='Paris'

select * from Customers where country ='France' or country ='Germany'

select * from Customers where not country ='Germany'

select * from Customers where country ='Germany' and (City ='Köln' or city ='Berlin')

select * from Customers where not country ='Germany' and not Country ='USA'

select * from Customers order by Country -- defaultt> asc (artan)

select * from Customers order by Country asc

select * from Customers order by Country desc --descending (düşen)

select * from Customers order by Country,City --önce ülkeye göre sıralar, ülkesi aynı olanları şehire göre sıralar.

--insert

select * from Categories

SET IDENTITY_INSERT Categories ON -- bu kod ile id eklemeyi açtık önce.

insert into Categories(CategoryID,CategoryName,Description,Picture) values (9,'myCategory','this is sample row','noPic')

--update
update Categories set Picture ='noPic' where CategoryID =9


--null durumu

select * from orders where ShipRegion is null --ShipRegion 'ı null olanları getirir.


select * from Categories where Description is not null

--delete
delete from Categories where Description is null

--table olusturmak ve sonra olusturulan bu tablonun tüm verilerini silmek.
create table myTable (id int, name varchar(50), surname varchar(50))

select * from myTable

insert into myTable(id,name,surname) values (2,'henry','onyekuru')

--tablonun içini boşalttık
delete from myTable


select * from orders

--ilk 10 sipariş
select top 10 * from orders


--yüzde şu kadarını getir.
select * from orders --830 kayıt

select top 10 percent * from orders --83 tane getirdi.

--min & max
select * from orders order by Freight desc

select min(Freight) from orders --min Freight =0.02 imiş. 

select max(Freight) from orders --max Freight =1007,64 imiş. 


--count() > sayısını verir.

select * from Customers  --91 kayıt var.

select COUNT(*) from Customers --91 yazar.

select count(distinct(country)) from Customers --21 farklı ülke varmış.


--avg() >average (ortalama) alır.

select * from Products

select avg(UnitPrice) from Products


--sum() > toplam yapar.
select sum(UnitsInStock) from Products --3119 tane stoklarda ürün varmış.

--like
select * from customers where Country like '%a' --son harfi a olan ülkeler


select * from customers where ContactName like '_r%' --2. karakteri r olan ContactName

select * from customers where ContactName like 'a__ %' --ismi a ile başlayan a'dan sonra herhangi 2 tane karakter +boşluk ve gerisi önemsiz


select * from customers where city like '_ondon' --ilk karakteri herhangi birşey olan ve ondon ile biten

select * from customers where city like 'L_n_on'

select * from customers where city like '[bsp]%' --b,s yada p ile başlayanlar

select * from customers where city like '[a-c]%' --city a ile c dahil  arasındakilerle başlayan

select * from customers where city not like '[bsp]%' --bsp ile başlamayanlar

--in

select * from customers where city in('Berlin','London','Helsinki')

select * from customers where country in (select Country from Suppliers ) --ülkesi tedarikçilerin ülkesinden olanlar

--between
select * from Products where UnitsInStock between 10 and 20 

select * from Products where UnitsInStock between 10 and 20 and SupplierID in(1)


/*bu sorguda order by ile alfabetik sıralama yapılır arasındakiler yazılır. Carnarvon Tigers 5. sırada. Diğeri 41. sırada.
--bu sorgu 37 satır getirir (41-5+1)*/
select * from Products where ProductName between 'Carnarvon Tigers' and 'Mozzarella di Giovanni' --5 ,41


--Alias (takma ad)
select ShipName siparisAdi, ShipAddress siparisAdres from Orders

select et.EmployeeID,t.TerritoryDescription from EmployeeTerritories et,Territories t where et.TerritoryID = t.TerritoryID


--inner join
--iki tablonun sadece keşisimini alır.
SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID

--left join
--sisteme kaydı olup sipariş (order) vermeyenler
select * from Customers left join Orders
on Customers.CustomerID = Orders.CustomerID where orders.CustomerID is null

--full join
--iki tabloyu birleştirir.
select * from Customers full join Orders
on Customers.CustomerID = Orders.CustomerID


--self join

select * from Customers c, Orders o
where c.CustomerID = o.CustomerID


--aynı şehirden olan customerslar
SELECT A.ContactName AS CustomerName1, B.ContactName AS CustomerName2, A.City
FROM Customers A, Customers B
WHERE A.CustomerID <> B.CustomerID
AND A.City = B.City
ORDER BY A.City;


select * from Customers


--union 
-- union burada iki tablodaki şehirleri distinct yaparak birleştiriyor.
SELECT City FROM Customers
UNION
SELECT City FROM Suppliers
ORDER BY City

--union all
SELECT City FROM Customers --91
UNION ALL
SELECT City FROM Suppliers --29
ORDER BY City

--toplam 120 kayıt (UNION ALL ile distinct yapmıyor)

SELECT City, Country FROM Customers
WHERE Country='Germany' --11
UNION
SELECT City, Country FROM Suppliers
WHERE Country='Germany' --3
ORDER BY City; --totalde 13 row


SELECT * FROM Customers
SELECT * FROM Suppliers

SELECT 'Customer' as type, ContactName, City, Country
FROM Customers --91
UNION
SELECT 'Supplier', ContactName, City, Country
FROM Suppliers --29
--total 120


--group by
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
ORDER BY COUNT(CustomerID) DESC;


select Shippers.CompanyName, count(Orders.ShipVia) as numberOfOrders from Orders left join Shippers

on Orders.ShipVia = Shippers.ShipperID group by Shippers.CompanyName


--having
SELECT COUNT(CustomerID) as countCustomer, Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 5  order by countCustomer


SELECT Employees.LastName, COUNT(Employees.LastName) as countOfOrders FROM Employees inner join Orders
on Orders.EmployeeID = Employees.EmployeeID
group by Employees.LastName having COUNT(Employees.LastName) > 100


--exists
--exist mevcut olmak demektir. select ile kullanılır. where şartında veri varsa yani 1 dönerse sorgu çalışır.
--aşağıda select sorgusunda 1 satır kayıt olduğundan 1 döner ve where şartı true oldugundan çalışır.
--insert myTable(id,name,surname) values (1,'emre','')

select CompanyName from Suppliers where exists(select * from myTable)


--any , all

--any herhangi birisi
SELECT ProductID,ProductName
FROM Products
WHERE ProductID = ANY (SELECT ProductID FROM [Order Details] WHERE Quantity = 10)

/*all > The ALL operator returns TRUE if all of the subquery values meet the condition.
tüm alt sorgu değerleri koşulu karşılıyorsa true döner */


--bu örnekte Quantity =52 olan 1 tane product var onun idsi =22
-- subquery koşulu sağladı all ile true döndü.
--fakat 1'den fazla product olanlar için koşul sağlanmaz. All false döner.
SELECT ProductName
FROM Products
WHERE ProductID = ALL (SELECT ProductID FROM [Order Details] WHERE Quantity = 52)


select count(ProductID) as countOfProduct,Quantity from [Order Details] group by Quantity


--- select into
/*Koşula göre yeni bir tablo oluşturur. Aşağıda Ülkesi Germany olan customerları CustomersGermany adında bir
tablo oluşturup içine kopyaladı. */

SELECT * INTO CustomersGermany
FROM Customers
WHERE Country = 'Germany';

select * from CustomersGermany --hepsinini ülkesi Germany.


--insert into select syntax
INSERT INTO Customers (CustomerID,CompanyName, City, Country)
SELECT SupplierID,CompanyName, City, Country FROM Suppliers
WHERE Country='Germany'


select * from customers 

SELECT * FROM Suppliers


--Sql Case
SELECT OrderID, Quantity,
CASE
    WHEN Quantity > 30 THEN 'The quantity is greater than 30'
    WHEN Quantity = 30 THEN 'The quantity is 30'
    ELSE 'The quantity is under 30'
END AS QuantityText
FROM [Order Details]

select * from [Order Details]


-- ISNULL()
--null olanları şu yap. aşağıda null olanlar ankara yapıldı.

select  CompanyName,isnull(Address,'Ankara')  from customers


--stored procedure
-- sql olarak yazılan kodu store procedure olarak kaydedip, cagirabiliriz.

--sorgumuzu SelectAllCustomers ismiyle kaydettik. Sonra exec ile cagirdik.

CREATE PROCEDURE SelectAllCustomers
AS
SELECT * FROM Customers
GO

exec SelectAllCustomers --calistirdik.


CREATE PROCEDURE SelectAllCustomers2 @City nvarchar(30)
AS
SELECT * FROM Customers WHERE City = @City
GO




EXEC SelectAllCustomers2 @City = 'London'


--Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.

select p.ProductName as UrunAdi,sum(od.UnitPrice*od.Quantity) as KazanılanToplamMiktar
from Orders o inner join [Order Details] od 
on o.OrderID = od.OrderID
inner join Products p
on p.ProductID = od.ProductID group by p.ProductName order by UrunAdi

