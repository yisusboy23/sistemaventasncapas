CREATE TABLE Persona (
    id INT PRIMARY KEY IDENTITY NOT NULL,
    nombre VARCHAR(50)NOT NULL,
    apellidos VARCHAR(50)NOT NULL,
    telefono VARCHAR(15) NULL,
    ci VARCHAR(15)NOT NULL,
    correo VARCHAR(100)NULL,
    estado VARCHAR(20)NOT NULL
);
CREATE TABLE Usuario (
    idUsuario INT PRIMARY KEY IDENTITY NOT NULL,
    idPersona INT FOREIGN KEY REFERENCES Persona(id)NOT NULL,
    nombreUsuario VARCHAR(50)NOT NULL,
    contraseña VARCHAR(100)NOT NULL,
    fechaRegistro DATE NOT NULL
)
CREATE TABLE Rol (
    idRol INT PRIMARY KEY NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    estado VARCHAR(20) NOT NULL
);

CREATE TABLE UsuarioRol (
    idUsuarioRol INT PRIMARY KEY IDENTITY NOT NULL,
    idUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario) NOT NULL,
    idRol INT FOREIGN KEY REFERENCES Rol(idRol) NOT NULL,
    fechaAsignada DATE NOT NULL,
    estado VARCHAR(20) NOT NULL
);

CREATE TABLE Cliente (
    idCliente INT PRIMARY KEY IDENTITY NOT NULL,
    idPersona INT FOREIGN KEY REFERENCES Persona(id) NOT NULL,
    tipoCliente VARCHAR(50) NOT NULL,
    codigoCliente VARCHAR(50)NOT NULL,
    estado VARCHAR(20)NOT NULL
);
CREATE TABLE Venta (
    idVenta INT PRIMARY KEY IDENTITY NOT NULL,
    idCliente INT FOREIGN KEY REFERENCES Cliente(idCliente) NOT NULL,
    idVendedor INT FOREIGN KEY REFERENCES Usuario(idUsuario)NOT NULL, 
    fecha DATE NOT NULL,
    total DECIMAL(10, 2)NOT NULL,
    estado VARCHAR(20)NOT NULL,
    idUsuarioResponsable INT FOREIGN KEY REFERENCES Usuario(idUsuario)NOT NULL
);
CREATE TABLE TipoProd (
    idProd INT PRIMARY KEY NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    estado VARCHAR(20) NOT NULL
);
CREATE TABLE Marca (
    idMarca INT PRIMARY KEY NOT NULL,
    nombre VARCHAR(50)NOT NULL,
    estado VARCHAR(20)NOT NULL
);
CREATE TABLE Producto (
    idProducto INT PRIMARY KEY IDENTITY NOT NULL,
    idTipoProducto INT FOREIGN KEY REFERENCES TipoProd(idProd)NOT NULL,
    idMarca INT FOREIGN KEY REFERENCES Marca(idMarca)NOT NULL,
    nombre VARCHAR(100)NOT NULL,
    codigoBarra VARCHAR(50)NOT NULL,
    unidad VARCHAR(20)NOT NULL,
    descripcion VARCHAR(MAX)NULL,
    estado VARCHAR(20)NOT NULL
);
CREATE TABLE Proveedor (
    idProveedor INT PRIMARY KEY NOT NULL,
    nombre VARCHAR(100)NOT NULL,
    telefono VARCHAR(15)NULL,
    direccion VARCHAR(255)NULL,
    estado VARCHAR(20)NOT NULL
);
CREATE TABLE Provee (
    idProvee INT PRIMARY KEY IDENTITY NOT NULL,
    idProducto INT FOREIGN KEY REFERENCES Producto(idProducto)NOT NULL,
    idProveedor INT FOREIGN KEY REFERENCES Proveedor(idProveedor)NOT NULL,
    fecha DATE NOT NULL,
    precio DECIMAL(10, 2)NOT NULL
);
CREATE TABLE Ingreso (
    idIngreso INT PRIMARY KEY IDENTITY NOT NULL,
    idProveedor INT FOREIGN KEY REFERENCES Proveedor(idProveedor)NOT NULL,
    fechaIngreso DATE NOT NULL,
    total DECIMAL(10, 2)NOT NULL,
    estado VARCHAR(20)NOT NULL
);
CREATE TABLE DetalleIngreso (
    idDetalleIngreso INT PRIMARY KEY IDENTITY NOT NULL,
    idProducto INT FOREIGN KEY REFERENCES Producto(idProducto)NOT NULL,
    idIngreso INT FOREIGN KEY REFERENCES Ingreso(idIngreso)NOT NULL,
    fechaVencimiento DATE NOT NULL,
    cantidad INT NOT NULL,
    precioCosto DECIMAL(10, 2)NOT NULL,
    precioVenta DECIMAL(10, 2)NOT NULL,
    subtotal DECIMAL(10, 2)NOT NULL,
    estado VARCHAR(20)NOT NULL
);
CREATE TABLE DetalleVenta (
    idDetalleVenta INT PRIMARY KEY IDENTITY NOT NULL,
    idVenta INT FOREIGN KEY REFERENCES Venta(idVenta)NOT NULL,
    idProducto INT FOREIGN KEY REFERENCES Producto(idProducto)NOT NULL,
    cantidad INT NOT NULL,
    precioVenta DECIMAL(10, 2)NOT NULL,
    subtotal DECIMAL(10, 2)NOT NULL,
    estado VARCHAR(20)NOT NULL
);