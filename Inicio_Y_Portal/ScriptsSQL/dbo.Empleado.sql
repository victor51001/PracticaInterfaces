CREATE TABLE Empleado (
    Id INT PRIMARY KEY,
    DNI NVARCHAR(20) NOT NULL,
    Nombre NVARCHAR(255) NOT NULL,
    Apellido1 NVARCHAR(255) NOT NULL,
    Apellido2 NVARCHAR(255) NOT NULL,
    Puesto NVARCHAR(50) NOT NULL,
    Telefono INT NOT NULL,
    Correo NVARCHAR(255) NOT NULL,
    FechaNacimiento DATETIME NOT NULL,
    NumeroSeguridadSocial INT NOT NULL,
    Comentarios NVARCHAR(1000)
);
