using Inicio_Y_Portal.Clases;
using Inicio_Y_Portal.Controladores;
using System;

namespace Inicio_Y_Portal
{
    public enum Estado
    {
        Pendiente,
        EnProceso,
        Completado,
        Cancelado
    }

    public class Proyecto
    {
        private int codigo;
        private string descripción;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Estado estado;
        private int presupuestoInicial;
        private int presupuestoActual;
        private int cambios;
        private Cliente cliente;
        private int codigoCliente;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripción { get => descripción; set => descripción = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public int PresupuestoInicial { get => presupuestoInicial; set => presupuestoInicial = value; }
        public int PresupuestoActual { get => presupuestoActual; set => presupuestoActual = value; }
        public int Cambios { get => cambios; set => cambios = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }

        public Proyecto(
            string descripción,
            DateTime fechaFin,
            int presupuestoInicial, Cliente client
            )
        {
            Codigo = ControladorProyecto.ultimoCodigo;
            ControladorProyecto.ultimoCodigo++;
            Descripción = descripción;
            FechaInicio = DateTime.Now;
            FechaFin = fechaFin;
            Estado = Estado.Pendiente;
            PresupuestoInicial = presupuestoInicial;
            PresupuestoActual = presupuestoInicial;
            Cambios = 0;
            Cliente = client;
            CodigoCliente = client.Codigo;
        }     
    }
}