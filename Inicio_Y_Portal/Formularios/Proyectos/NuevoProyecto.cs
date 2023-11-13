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

namespace Inicio_Y_Portal
{
    public partial class NuevoProyecto : Form
    {
        public NuevoProyecto()
        {
            InitializeComponent();
        }
        
        private Boolean validarCampos()
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
            if (nudCodigoCliente.Value == 0)
            {
                nudCodigoCliente.BackColor = Color.Red;
                validar = false;
            }
            return validar;
        }

        private void limpiarCampos()
        {
            txtbxDescripcion.Clear();
            dtpFechaFin.Value = DateTime.Now;
            nudPresupuesto.Value = 0;
            nudCodigoCliente.Value = 0;
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Proyecto p = new Proyecto(
                    txtbxDescripcion.Text.ToUpper(),
                    dtpFechaFin.Value,
                    (int)nudPresupuesto.Value,
                    (int)nudCodigoCliente.Value
                    );
                ControladorProyecto.ListaProyectos.Add(p);
                limpiarCampos();
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
    }
}
