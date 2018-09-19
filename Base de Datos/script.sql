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