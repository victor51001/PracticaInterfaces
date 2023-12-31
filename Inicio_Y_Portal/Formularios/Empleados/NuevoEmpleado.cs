﻿using Inicio_Y_Portal.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inicio_Y_Portal
{
    public partial class NuevoEmpleado : Form
    {
        public NuevoEmpleado()
        {
            InitializeComponent();
            cbxPuestos.DataSource = Enum.GetValues(typeof(Puesto));
        }

        private Boolean ValidarCampos()
        {
            Boolean validar = true;
            if (string.IsNullOrEmpty(txtbxDni.Text))
            {
                txtbxDni.BackColor = Color.Red;
                validar = false;
            }
            if (string.IsNullOrEmpty(txtbxNombre.Text))
            {
                txtbxNombre.BackColor = Color.Red;
                validar = false;
            }
            if (string.IsNullOrEmpty(txtbxApellido1.Text))
            {
                txtbxApellido1.BackColor = Color.Red;
                validar = false;
            }
            if (string.IsNullOrEmpty(txtbxApellido2.Text))
            {
                txtbxApellido2.BackColor = Color.Red;
                validar = false;
            }
            if (string.IsNullOrEmpty(cbxPuestos.Text))
            {
                cbxPuestos.BackColor = Color.Red;
                validar = false;
            }
            return validar;
        }
        private void LimpiarCampos()
        {
            txtbxDni.Clear();
            txtbxNombre.Clear();
            txtbxApellido1.Clear();
            txtbxApellido2.Clear();
            cbxPuestos.Text = "";
            nudTelefono.Value = 0;
            txtbxCorreo.Clear();
            dtpFechaNac.Value = DateTime.Now;
            nudNumSegSoc.Value = 100000000;
            txtbxComentarios.Clear();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Empleado em = new Empleado(
                    txtbxDni.Text.ToUpper(),
                    txtbxNombre.Text,
                    txtbxApellido1.Text,
                    txtbxApellido2.Text,
                    (Puesto)Enum.Parse(typeof(Puesto),cbxPuestos.Text),
                    dtpFechaNac.Value,
                    (int)nudNumSegSoc.Value
                    );
                if (nudTelefono.Value!=0)
                {
                    em.Telefono = (int)nudTelefono.Value;
                }
                if (!string.IsNullOrEmpty(txtbxCorreo.Text))
                {
                    em.Correo = txtbxCorreo.Text;
                }
                if(!string.IsNullOrEmpty(txtbxComentarios.Text))
                {
                    em.Comentarios = txtbxComentarios.Text;
                }
                ControladorEmpleado.ListaEmpleados.Add(em);
                ControladorEmpleado.cambios = true;
                LimpiarCampos();
                TerminarAlta frmTAP = new TerminarAlta();
                frmTAP.ShowDialog();
                if (!frmTAP.valor)
                {
                    Close();
                }
            }
        }

        private void numeros_Validating(object sender, CancelEventArgs e)
        {
                MessageBox.Show("Debes ingresar exactamente 9 dígitos numéricos.");
        }

        private void NuevoEmpleado_Load(object sender, EventArgs e)
        {
            nudTelefono.Controls[0].Visible = false;
            nudTelefono.Controls[1].Visible = false;
            nudNumSegSoc.Controls[0].Visible = false;
            nudNumSegSoc.Controls[1].Visible = false;
        }

        private void txtbxDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                    case Keys.P:
                    case Keys.X:
                        e.Handled = true;
                        txtbxDni.SelectionLength = 0;
                        break;
                }
            }
        }        
    }
}
