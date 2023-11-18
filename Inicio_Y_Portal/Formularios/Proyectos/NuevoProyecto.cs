using Inicio_Y_Portal.Clases;
using Inicio_Y_Portal.Controladores;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inicio_Y_Portal
{
    public partial class NuevoProyecto : Form
    {
        public NuevoProyecto()
        {
            InitializeComponent();
            cmbxCliente.DataSource = ControladorCliente.ListaClientes;
            cmbxCliente.DisplayMember = "Id";
        }        
        
        private Boolean ValidarCampos()
        {
            Boolean validar = true;
            if (string.IsNullOrEmpty(txtbxDescripcion.Text))
            {
                txtbxDescripcion.BackColor = Color.Red;
                validar = false;
            }
            if (nudPresupuesto.Value == 0)
            {
                nudPresupuesto.BackColor = Color.Red;
                validar = false;
            }
            if (string.IsNullOrEmpty(cmbxCliente.Text))
            {
                cmbxCliente.BackColor = Color.Red;
                validar = false;
            }
            return validar;
        }

        private void LimpiarCampos()
        {
            txtbxDescripcion.Clear();
            dtpFechaFin.Value = DateTime.Now;
            nudPresupuesto.Value = 0;
            cmbxCliente.Text = "";
        }


        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Proyecto p = new Proyecto(
                    txtbxDescripcion.Text.ToUpper(),
                    dtpFechaFin.Value,
                    (int)nudPresupuesto.Value, 
                    (Cliente)cmbxCliente.SelectedItem
                    );
                ControladorProyecto.ListaProyectos.Add(p);
                ControladorProyecto.cambios = true;
                LimpiarCampos();
                TerminarAlta frmTAP = new TerminarAlta();
                frmTAP.ShowDialog();
                if (!frmTAP.valor)
                {
                    Close();
                }
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoProyecto_Load(object sender, EventArgs e)
        {
            nudPresupuesto.Controls[0].Visible = false;
            nudPresupuesto.Controls[1].Visible = false;
        }
    }
}
