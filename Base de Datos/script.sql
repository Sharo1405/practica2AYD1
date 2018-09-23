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

ALTER TABLE producto
    ADD CONSTRAINT producto_categoria_fk FOREIGN KEY ( categoria_cod_categoria )

        REFERENCES categoria ( cod_categoria ) ON DELETE CASCADE;

--Correr 22/09/18
create table carro(
	cod_carro INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	producto_cod_producto INT NOT NULL
);

ALTER TABLE carro
    ADD CONSTRAINT carro_producto_fk FOREIGN KEY ( producto_cod_producto )
    REFERENCES producto ( cod_producto ) ON DELETE CASCADE;

insert into carro(producto_cod_producto) VALUES
(1),(2),(3),(4),(5);