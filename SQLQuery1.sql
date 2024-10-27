--Select Insert Update Delete
--SElect: Bir tabloda istenen sütunlarý getirmemizi saðlayan SQL sourcedýr
--select * from TblCategory

--select ProductName,ProductPrice from TableProduct
-- where if gibi çalýþýr
--select * from TableProduct where ProductName='Sütlaç'
-- Sütlaça ait bütün verileri getirir

select * from TableProduct where ProductPrice<80 and ProductStatus=1

