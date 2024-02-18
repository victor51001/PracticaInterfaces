using Inicio_Y_Portal.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio_Y_Portal.Clases
{
    public enum tipos
    {
        Pequeña,
        Mediana,
        Grande,
        Multinacional
    }

    public class Cliente
    {
        private int codigo;
        private string nombre;
        private string direccion;
        private string nomRep;
        private string correo;
        private string cif;
        private int telefono;
        private string pais;
        private tipos tipo;
        private int descuento;
        private string comentarios;
        private string sector;
        private List<DateTime> citas;
        private string logo;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string NomRep { get => nomRep; set => nomRep = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Cif { get => cif; set => cif = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Pais { get => pais; set => pais = value; }
        public tipos Tipo { get => tipo; set => tipo = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public string Sector { get => sector; set => sector = value; }
        public List<DateTime> Citas { get => citas; set => citas = value; }
        public string Logo { get => logo; set => logo = value; }

        public Cliente(string nombre, string direccion, int telefono, string correo, string logo, string nomRep)
        {
            Codigo = ControladorCliente.ultimoCodigo;
            ControladorCliente.ultimoCodigo++;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            Logo = logo;
            this.nomRep = nomRep;
        }
    }
}
