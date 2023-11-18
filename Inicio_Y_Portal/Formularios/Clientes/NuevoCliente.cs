using Inicio_Y_Portal.Clases;
using Inicio_Y_Portal.Controladores;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inicio_Y_Portal.Formularios.Clientes
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private Boolean ValidarCampos()
        {
            Boolean validar = true;
            if (string.IsNullOrEmpty(txtbxNombre.Text))
            {
                txtbxNombre.BackColor = Color.Red;
                validar = false;
            }
            if (string.IsNullOrEmpty(txtbxDireccion.Text))
            {
                txtbxDireccion.BackColor = Color.Red;
                validar = false;
            }
            if (nudTelefono.Value == 0)
            {
                nudTelefono.BackColor = Color.Red;
                validar = false;
            }
            if (string.IsNullOrEmpty(txtbxCorreo.Text))
            {
                txtbxCorreo.BackColor = Color.Red;
                validar = false;
            }
            return validar;
        }
        private void LimpiarCampos()
        {
            txtbxNombre.Clear();
            txtbxDireccion.Clear();
            nudTelefono.Value = 0;
            txtbxCorreo.Clear();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Cliente c = new Cliente(
                    txtbxNombre.Text,
                    txtbxDireccion.Text,
                    (int)nudTelefono.Value,
                    txtbxCorreo.Text
                    );
                ControladorCliente.ListaClientes.Add(c);
                ControladorCliente.cambios = true;
                LimpiarCampos();
                TerminarAlta frmTAP = new TerminarAlta();
                frmTAP.ShowDialog();
                if (!frmTAP.valor)
                {
                    Close();
                }
            }
        }
        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            nudTelefono.Controls[0].Visible = false;
            nudTelefono.Controls[1].Visible = false;
        }
    }
}
