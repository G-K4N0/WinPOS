create database papeleriadb;

use papeleriadb;

CREATE TABLE categorias(
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    categoria VARCHAR(50)
)ENGINE=InnoDB;

CREATE TABLE roles (
    id INT AUTO_INCREMENT PRIMARY KEY,
    rol VARCHAR(30)
) ENGINE=InnoDB;

create table proveedores(
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30) NOT NULL,
    telefono VARCHAR(10),
    correo VARCHAR(40)
)ENGINE=InnoDB;

create table cliente(
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30) NOT NULL,
    telefono VARCHAR(10),
    deuda DECIMAL(10,2)
)ENGINE=InnoDB;

create table productos (
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    codigo VARCHAR(40),
    nombre VARCHAR(100),
    precioUnitario DECIMAL(10,2) NOT NULL,
    precioMayoreo DECIMAL(10,2) NOT NULL,
    precioTemporada DECIMAL(10,2) NOT NULL,
    stock INT NOT NULL,
    idCategoria INT NOT NULL,
    FOREIGN KEY (idCategoria) REFERENCES categorias(id)
) ENGINE=InnoDB;

create table personas(
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    usuario VARCHAR(30) NOT NULL,
    passwd VARCHAR(100) NOT NULL,
    idRol INT NOT NULL,
    FOREIGN KEY (idRol) REFERENCES roles(id)
)ENGINE=InnoDB;


create table ventas(
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    idCliente INT,
    idPersona INT NOT NULL,
    fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES cliente(id),
    FOREIGN KEY (idPersona) REFERENCES personas(id)
) ENGINE=InnoDB;

create table detalleVentas(
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    idVenta INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (idVenta) REFERENCES ventas(id),
    FOREIGN KEY (idProducto) REFERENCES productos(id)
) ENGINE=InnoDB;

create table compras(
    id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    idProducto INT NOT NULL,
    idProveedor INT NOT NULL,
    idPersonas INT NOT NULL,
    cantidad INT NOT NULL,
    precioTotal DECIMAL(10,2),
    FOREIGN KEY (idProducto) REFERENCES productos(id),
    FOREIGN KEY (idProveedor) REFERENCES proveedores(id),
    FOREIGN KEY (idPersonas) REFERENCES personas(id)
)ENGINE=InnoDB;


CREATE TABLE roles (
    id INT AUTO_INCREMENT PRIMARY KEY,
    rol VARCHAR(30)
) ENGINE=InnoDB;

#Agregado de roles
insert into roles (rol) values ('admin')
insert into roles (rol) values ('vendedor')

#Agregado del primer usuario
insert into personas (nombre,usuario,passwd,idRol) values ('Kano','admin','talento',1);

