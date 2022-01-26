CREATE DATABASE SISTEMADEVENTAS;
GO
USE SISTEMADEVENTAS;
GO
CREATE TABLE Productos(
	ID int identity(1,1) Primary key,
	NombreDelProducto varchar (50),
	MarcaDelProducto varchar (50),
	Distribuidor varchar (100),
	Existencias int ,
	Precio money,
	Descripcion text 
)
GO
INSERT INTO Productos(NombreDelProducto,MarcaDelProducto,Distribuidor,Existencias,Precio,Descripcion)
VALUES ('Papas Sabritas','Sabritas','Coca Cola',10,12.00,'Papas Sabritas naturales');
INSERT INTO Productos VALUES ('Fanta','Coca Cola','Coca Cola',5,15.00,'Refresco sabor naranja');
INSERT INTO Productos VALUES ('Cacahuates Japoneses','La Rosa','La Rosa',50,7.00,'Cacahuates japoneses de la rosa');
INSERT INTO Productos VALUES ('Doritos','Sabritas','CocaCola',10,15.00,'Doritos sabor nacho');
GO