using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio_Y_Portal
{
    public enum Estado
    {
        Pendiente,
        EnProceso,
        Completado,
        Cancelado
    }

    [Serializable]
    public class Proyecto
    {
        private int codigo;
        public static int ultimoCodigo = 1;
        private string descripción;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Estado estado;
        private int presupuestoInicial;
        private int presupuestoActual;
        private int cambios;
        private int codigoCliente;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripción { get => descripción; set => descripción = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public int PresupuestoInicial { get => presupuestoInicial; set => presupuestoInicial = value; }
        public int PresupuestoActual { get => presupuestoActual; set => presupuestoActual = value; }
        public int Cambios { get => cambios; set => cambios = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }

        public Proyecto(
            string descripción,
            DateTime fechaFin,
            int presupuestoInicial,
            int codigoCliente
            )
        {
            Codigo = ultimoCodigo++;
            Descripción = descripción;
            FechaInicio = DateTime.Now;
            FechaFin = fechaFin;
            Estado = Estado.Pendiente;
            PresupuestoInicial = presupuestoInicial;
            PresupuestoActual = presupuestoInicial;
            Cambios = 0;
            CodigoCliente = codigoCliente;
        }     
    }
}