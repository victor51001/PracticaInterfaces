﻿CREATE TABLE Cliente (
    Codigo INT PRIMARY KEY,
    Nombre NVARCHAR(255) NOT NULL,
    Direccion NVARCHAR(255) NOT NULL,
    NomRep NVARCHAR(255) NOT NULL,
    Correo NVARCHAR(255) NOT NULL,
    Cif NVARCHAR(255) NOT NULL,
    Telefono INT NOT NULL,
    Pais NVARCHAR(255) NOT NULL,
    Tipo NVARCHAR(50) NOT NULL,
    Descuento INT NOT NULL,
    Comentarios NVARCHAR(MAX),
    Sector NVARCHAR(255) NOT NULL,
    Logo NVARCHAR(255) NOT NULL
);