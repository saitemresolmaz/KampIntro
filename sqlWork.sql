 --select
 select * from Customers

 select ContactName Adi, CompanyName SirketAdi ,City Sehir from Customers  --alias

 select * from Customers where City='Berlin'

 --case insensitive (büyük-küçük harf duyarsız)
 SeLect * from Products where CategoryID =1 or CategoryID =3

  select * from Products where CategoryID =1 and UnitPrice<>18 --<>18 dersek "eşit değil" demek

 select * from Products order by ProductName  --order by sıralama

 select * from Products order by CategoryID, ProductName  --önce categoryID'ye göre sıralar. Aynı kategorileri de kendi içerisinde sıralar.

 select * from Products order by UnitPrice asc --ascending (artan demek)

 select * from Products where categoryID =1 order by UnitPrice desc --descending (düşen :))

 select count(*) from Products where CategoryID =7 --Kayıt sayısı

 --Hangi kategoride kaç farklı ürünümüz var
select CategoryID,count(*) from Products 
group by CategoryID 


 --UnitPrice'ı 20den fazla olan ürünler arasından categorisi 10dan küçük olanların sayısı
select CategoryID,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10 -- having where şartı gibidir. kümelenmiş datada group by ile kullanılır.


--inner join sadece iki tabloda da eşleşenleri getirir.
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID =Categories.CategoryID --on koşulunda demektir.
where Products.UnitPrice>10

--DTO Data Transformation Object

--[Order Details] boşluk olduğu için köşeli paranteze aldı tablo ismi olarak alsın diye.
--left join solda olup sağda olmayanları da getirir. right join mantık olarak tam tersidir.
select * from Products p left join [Order Details] od
on p.ProductID =od.ProductID


select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID where o.CustomerID is null

select * from orders

--2den fazla tabloyu join etmek
select * from Products p inner join [Order Details] od
on p.ProductID =od.ProductID
inner join Orders o
on o.OrderID = od.OrderID