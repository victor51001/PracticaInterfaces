using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Y_Portal.Formularios.Clientes
{
    public partial class CriteriosC : Form
    {
        public CriteriosC()
        {
            InitializeComponent();
        }

        public string ValorDevuelto { get; set; }
        private void CriteriosC_Load(object sender, EventArgs e)
        {

        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            ValorDevuelto = chklstbxClientes.SelectedItems[0].ToString();
            Close();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            ValorDevuelto = null;
            Close();
        }

        private int lastCheckedIndex = -1;
        private void chklstbxClientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index != lastCheckedIndex)
            {
                if (lastCheckedIndex != -1)
                {
                    chklstbxClientes.SetItemCheckState(lastCheckedIndex, CheckState.Unchecked);
                }
                lastCheckedIndex = e.Index;
            }
        }

        private void chklstbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttnAceptar.Enabled = chklstbxClientes.SelectedItems.Count > 0;
        }
    }
}
