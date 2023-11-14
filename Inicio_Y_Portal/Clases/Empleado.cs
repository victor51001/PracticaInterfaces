using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Inicio_Y_Portal
{
    public enum Puesto
    {
        Jefe,
        Analista,
        Asistente,
        Diseñador,
        Desarrollador
    }

    public class Empleado
    {
        
        public static int proximoId = 1200;
        private int id;
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        public Puesto puesto;
        private int telefono;
        private string correo;
        private DateTime fechaNacimiento;
        private int numeroSeguridadSocial;
        private string comentarios;

        public int Id { get => id; set => id = value; }
        public string DNI { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public Puesto Puesto { get => puesto; set => puesto = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int NumeroSeguridadSocial { get => numeroSeguridadSocial; set => numeroSeguridadSocial = value; }
        public string Comentarios { get => comentarios; set { 
                if (value.Length<1000)
                {
                    comentarios = "";
                } else
                {
                    comentarios = value;
                }
            } 
        }

        public Empleado(
            string dni, string nombre, string apellido1, 
            string apellido2, Puesto puesto, int telefono, 
            string correo, DateTime fechaNacimiento, 
            int numeroSeguridadSocial, string comentarios)
        {
            Id = proximoId;
            proximoId++;
            DNI = dni;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Puesto = puesto;
            Telefono = telefono;
            Correo = correo;
            FechaNacimiento = fechaNacimiento;
            NumeroSeguridadSocial = numeroSeguridadSocial;
            Comentarios = comentarios;
        }

        public Empleado() { }

        public Empleado(
            string dni, string nombre, 
            string apellido1, string apellido2, 
            Puesto puesto, DateTime fechaNacimiento, 
            int numeroSeguridadSocial)
        {
            DNI = dni;
            Id = proximoId;
            proximoId++;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Puesto = puesto;
            FechaNacimiento = fechaNacimiento;
            NumeroSeguridadSocial = numeroSeguridadSocial;
        }

        public Boolean EsJefe(Empleado e)
        {
            if (e.Puesto.Equals(Puesto.Jefe))
            {
                return true;
            }
            else
                return false;
        }

        public void CambiarComentarios(Empleado e, string comentarios)
        {
            e.Comentarios = comentarios;
        }

        public static string[] getPuestos()
        {
            return Enum.GetNames(typeof(Puesto));
        }
    }
}