using Inicio_Y_Portal.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Y_Portal.Formularios.Usuarios
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
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
            if (string.IsNullOrEmpty(txtbxClave.Text))
            {
                txtbxClave.BackColor = Color.Red;
                validar = false;
            }
            return validar;
        }
        private void LimpiarCampos()
        {
            txtbxNombre.Clear();
            txtbxClave.Clear();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario u = new Usuario(
                    txtbxNombre.Text,
                    Int32.Parse(txtbxClave.Text)
                    );
                ControladorUsuario.ListaUsuarios.Add(u);
                ControladorUsuario.cambios = true;
                LimpiarCampos();
                TerminarAlta frmTAP = new TerminarAlta();
                frmTAP.ShowDialog();
                if (!frmTAP.valor)
                {
                    Close();
                }
            }
        }

        private void txtbxClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
