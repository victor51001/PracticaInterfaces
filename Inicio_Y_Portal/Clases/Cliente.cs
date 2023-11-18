using Inicio_Y_Portal.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio_Y_Portal.Clases
{
    public class Cliente
    {
        private int codigo;
        private string nombre;
        private string direccion;
        private int telefono;
        private string correo;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }

        public Cliente(string nombre, string direccion, int telefono, string correo)
        {
            Codigo = ControladorCliente.ultimoCodigo;
            ControladorCliente.ultimoCodigo++;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
        }
    }
}
