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
        private string logo;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Logo { get => logo; set => logo = value; }

        public Cliente(string nombre, string direccion, int telefono, string correo, string logo)
        {
            Codigo = ControladorCliente.ultimoCodigo;
            ControladorCliente.ultimoCodigo++;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            Logo = logo;
        }
    }
}
