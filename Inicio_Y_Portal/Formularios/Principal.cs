using Inicio_Y_Portal.Clases;
using Inicio_Y_Portal.Controladores;
using Inicio_Y_Portal.Formularios;
using Inicio_Y_Portal.Formularios.Clientes;
using Inicio_Y_Portal.Formularios.Usuarios;
using System;
using System.Windows.Forms;

namespace Inicio_Y_Portal
{
    public partial class Principal : Form
    {
        private bool[] cambios = {
            ControladorCliente.cambios, 
            ControladorEmpleado.cambios, 
            ControladorProyecto.cambios,
            ControladorUsuario.cambios
        };
        private Confirmacion frmconfirm = new Confirmacion();

        private ListadoProyectos frmListaP = new ListadoProyectos();
        private NuevoProyecto frmNuevoProyecto = new NuevoProyecto();

        private ListadoEmpleados frmListaE = new ListadoEmpleados();
        private NuevoEmpleado frmNuevoEmpleado = new NuevoEmpleado();

        private ListadoClientes frmListaC = new ListadoClientes();
        private NuevoCliente frmNuevoCliente = new NuevoCliente();

        private ListadoUsuarios frmListaU = new ListadoUsuarios();
        private NuevoUsuario frmNuevoUsuario = new NuevoUsuario();

        public Principal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ControladorCliente.LeerCliente();
            ControladorEmpleado.LeerEmpleados();
            ControladorProyecto.LeerProyectos();
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

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario.ShowDialog();
        }

        private void listadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListaU.ShowDialog();
        }

        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoCliente.ShowDialog();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaC.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmconfirm.ShowDialog();
            if (frmconfirm.ok)
            {
                for (int i = 0; i < cambios.Length; i++)
                {
                    if (cambios[i])
                    {
                        switch (i)
                        {
                            case 0:
                                ControladorCliente.EscribirCliente();
                                break;
                            case 1:
                                ControladorEmpleado.EscribirEmpleados();
                                break;
                            case 2:
                                ControladorProyecto.EscribirProyectos();
                                break;
                            case 3:
                                ControladorUsuario.EscribirUsuarios();
                                break;
                        }
                        cambios[i] = false;
                    }
                }
            }
        }
    }
}
