CREATE TABLE Proyecto (
    Codigo INT PRIMARY KEY,
    Descripcion NVARCHAR(255) NOT NULL,
    FechaInicio DATETIME NOT NULL,
    FechaFin DATETIME NOT NULL,
    Estado NVARCHAR(50) NOT NULL,
    PresupuestoInicial INT NOT NULL,
    PresupuestoActual INT NOT NULL,
    Cambios INT NOT NULL,
    CodigoCliente INT NOT NULL
);
