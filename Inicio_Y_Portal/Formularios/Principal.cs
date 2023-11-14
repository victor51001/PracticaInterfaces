using Inicio_Y_Portal.Controladores;
using Inicio_Y_Portal.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Y_Portal
{
    public partial class Principal : Form
    {
        public static List<string> cambios;
        private Confirmacion frmconfirm;

        private ListadoProyectos frmListaP;
        private NuevoProyecto frmNuevoProyecto;

        private ListadoEmpleados frmListaE;
        private NuevoEmpleado frmNuevoEmpleado;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmListaP.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNuevoProyecto.ShowDialog();
        }

        private void listadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListaE.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNuevoEmpleado.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmconfirm.ShowDialog();
            if (frmconfirm.ok)
            {
                while (cambios.Count > 0)
                {
                    switch (cambios[0])
                    {
                        case "Empleado":
                            ControladorEmpleado.escribirEmpleados();
                            cambios.RemoveAt(0);
                            break;
                        case "Proyecto":
                            ControladorProyecto.escribirProyectos();
                            cambios.RemoveAt(0);
                            break;
                        case "Usuario":
                            ControladorUsuario.escribirUsuarios();
                            cambios.RemoveAt(0);
                            break;
                            /*case "Cliente":
                                ControladorCliente.escribirCliente();
                                gestiones.RemoveAt(0);
                                break;*/
                            //Falta acabar esta parte, acabar usuarios, confirmacion, clientes todo.
                    }
                }
            }
        }
    }
}
