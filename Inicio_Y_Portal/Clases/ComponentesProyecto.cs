using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio_Y_Portal.Clases
{
    public class ComponentesProyecto
    {
        private string codigoProyecto;
        private string idEmpleado;
        private string puesto;
        private float porcentajeDedicacion;
        private double extras;

        public ComponentesProyecto(string codigoProyecto, string idEmpleado, string puesto, float porcentajeDedicacion, double extras)
        {
            this.codigoProyecto = codigoProyecto;
            this.idEmpleado = idEmpleado;
            this.puesto = puesto;
            this.porcentajeDedicacion = porcentajeDedicacion;
            this.extras = extras;
        }

        public ComponentesProyecto()
        {
        }

        public string CodigoProyecto { get => codigoProyecto; set => codigoProyecto = value; }
        public string IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public float PorcentajeDedicacion { get => porcentajeDedicacion; set => porcentajeDedicacion = value; }
        public double Extras { get => extras; set => extras = value; }

        public void modificarPorcentajeDedicacion(float porcentaje)
        {
            this.porcentajeDedicacion = porcentaje;
        }

        public Boolean esJefe()
        {
            return this.puesto == "Jefe";
        }
    }
}
