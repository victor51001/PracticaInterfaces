using Inicio_Y_Portal.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Inicio_Y_Portal
{
    public partial class ListadoProyectos : Form
    {

        public ListadoProyectos()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnImprimir_Click(object sender, EventArgs e)
        {
            mostrarProyectos();
        }

        private void cargarProyectos()
        {
            ControladorProyecto.ListaProyectos.Add(new Proyecto("WEB 1.0 PARA TÉCNICAS REUNIDAS", DateTime.Parse("30/12/2031"), 50000, 11));
            ControladorProyecto.ListaProyectos.Add(new Proyecto("APLICACIÓN CONTABLE PARA TÉCNICAS REUNIDAS", DateTime.Parse("12/01/2025"), 4000, 11));
            ControladorProyecto.ListaProyectos.Add(new Proyecto("WEB 1.0 PARA AXA", DateTime.Parse("04/05/2028"), 30000, 21));
            ControladorProyecto.ListaProyectos.Add(new Proyecto("WEB 3.0 PARA SANTANDER", DateTime.Parse("08/11/2029"), 22000, 52));
            ControladorProyecto.ListaProyectos.Add(new Proyecto("APLICACIÓN MÓVIL SELENIUM", DateTime.Parse("28/09/2035"), 98000, 06));
        }
        private void crearCheckBox(Proyecto proyecto, int posicion, int contadorNombre)
        {
            CheckBox chkProyecto = new CheckBox();
            chkProyecto.AutoSize = true;
            chkProyecto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            chkProyecto.Location = new Point(75, posicion);
            chkProyecto.Name = "chkProyecto" + contadorNombre;
            chkProyecto.Size = new Size(291, 20);
            chkProyecto.TabIndex = 1;
            chkProyecto.Text = proyecto.Descripción;
            gpbxProyectos.Controls.Add(chkProyecto);
        }

        private void mostrarProyectos()
        {
            gpbxProyectos.Controls.Clear();
            int posicion = 40, contador = 1;
            foreach (Proyecto p in ControladorProyecto.ListaProyectos)
            {
                crearCheckBox(p, posicion, contador);
                posicion += 30;
                contador++;
            }
        }

        private void FrmProyectos_Load(object sender, EventArgs e)
        {
            cargarProyectos();
        }
        int CriterioCodigo(Proyecto p1, Proyecto p2)
        {
            if (p1.Codigo == p2.Codigo)
                return 0;
            else if (p1.Codigo > p2.Codigo)
                return 1;
            else
                return -1;
        }
        int CriterioDescripción(Proyecto p1, Proyecto p2)
        {
            return p1.Descripción.CompareTo(p2.Descripción);
        }
        int CriterioFechaInicio(Proyecto p1, Proyecto p2)
        {
            return p1.FechaInicio.CompareTo(p2.FechaInicio);
        }
        int CriterioFechaFin(Proyecto p1, Proyecto p2)
        {
            return p1.FechaFin.CompareTo(p2.FechaFin);
        }
        int CriterioEstado(Proyecto p1, Proyecto p2)
        {
            return p1.Descripción.CompareTo(p2.Descripción);
        }
        int CriterioPresupuestoInicial(Proyecto p1, Proyecto p2)
        {
            if (p1.PresupuestoInicial == p2.PresupuestoInicial)
                return 0;
            else if (p1.PresupuestoInicial > p2.PresupuestoInicial)
                return 1;
            else
                return -1;
        }
        int CriterioPresupuestoActual(Proyecto p1, Proyecto p2)
        {
            if (p1.PresupuestoActual == p2.PresupuestoActual)
                return 0;
            else if (p1.PresupuestoActual > p2.PresupuestoActual)
                return 1;
            else
                return -1;
        }
        int CriterioCambios(Proyecto p1, Proyecto p2)
        {
            if (p1.Cambios == p2.Cambios)
                return 0;
            else if (p1.Cambios > p2.Cambios)
                return 1;
            else
                return -1;
        }
        int CriterioCodigoCliente(Proyecto p1, Proyecto p2)
        {
            if (p1.CodigoCliente == p2.CodigoCliente)
                return 0;
            else if (p1.CodigoCliente > p2.CodigoCliente)
                return 1;
            else
                return -1;
        }
        private void bttnOrdenar_Click(object sender, EventArgs e)
        {
            CriteriosP frm = new CriteriosP();
            frm.ShowDialog();
            string valor;
            if ((valor=frm.ValorDevuelto)!=null)
            {
                switch (valor)
                {
                    case "Codigo":
                        ControladorProyecto.ListaProyectos.Sort(CriterioCodigo);
                        break;
                    case "Descripción":
                        ControladorProyecto.ListaProyectos.Sort(CriterioDescripción);
                        break;
                    case "Fecha Inicio":
                        ControladorProyecto.ListaProyectos.Sort(CriterioFechaInicio);
                        break;
                    case "Fecha Fin":
                        ControladorProyecto.ListaProyectos.Sort(CriterioFechaFin);
                        break;
                    case "Estado":
                        ControladorProyecto.ListaProyectos.Sort(CriterioEstado);
                        break;
                    case "Presupuesto Inicial":
                        ControladorProyecto.ListaProyectos.Sort(CriterioPresupuestoInicial);
                        break;
                    case "Presupuesto Actual":
                        ControladorProyecto.ListaProyectos.Sort(CriterioPresupuestoActual);
                        break;
                    case "Cambios":
                        ControladorProyecto.ListaProyectos.Sort(CriterioCambios);
                        break;
                    case "Codigo Cliente":
                        ControladorProyecto.ListaProyectos.Sort(CriterioCodigoCliente);
                        break;
                }

                mostrarProyectos();
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (gpbxProyectos.Controls.Count > 0)
            {
                foreach (CheckBox control in gpbxProyectos.Controls)
                {
                    if (control.Checked)
                    {
                        Proyecto p = null;
                        string descripcion = control.Text;
                        foreach (Proyecto pr in ControladorProyecto.ListaProyectos)
                        {
                            if (pr.Descripción.Equals(descripcion))
                            {
                                p = pr;
                            }
                        }
                        gpbxProyectos.Controls.Remove(control);
                        ControladorProyecto.ListaProyectos.Remove(p);
                    }
                }
                mostrarProyectos();
            }
        }

        private void gpbxProyectos_Enter(object sender, EventArgs e)
        {

        }
    }
}
