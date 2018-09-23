USE master;

DROP DATABASE IF EXISTS p2;

CREATE DATABASE p2;

USE p2;

CREATE TABLE producto(
	cod_producto INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(200),
	cantidad INT,
	detalles VARCHAR(200),
	precio_venta INT,
	imagen VARBINARY(MAX),
	categoria_cod_categoria INT NOT NULL,
);

CREATE TABLE categoria(
	cod_categoria INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(200),
	descripcion VARCHAR(200)
);

create table Factura(
	cod_factura int not null identity(1,1) primary key,
	Nombre varchar(50) not null,
	Apellido varchar(50) not null,
	DPI int not null,
	zona_entrega varchar(200) not null,
	fecha date not null,
);
create table detalle_factura(
	detalle_cod_factura int not null,
	producto_cod_producto int not null
	primary key(detalle_cod_factura,producto_cod_producto),
	CONSTRAINT  fk_detalle_cod_factura FOREIGN KEY (detalle_cod_factura) REFERENCES Factura (cod_factura),
	CONSTRAINT  fk_producto_cod_producto FOREIGN KEY (producto_cod_producto) REFERENCES producto (cod_producto)
)

ALTER TABLE producto
    ADD CONSTRAINT producto_categoria_fk FOREIGN KEY ( categoria_cod_categoria )
<<<<<<< HEAD
        REFERENCES categoria ( cod_categoria ) ON DELETE CASCADE;
=======

        REFERENCES categoria ( cod_categoria ) ON DELETE CASCADE;
>>>>>>> c11c0c0370abc1765d3a1dac0b43b31dc35d5dc9
