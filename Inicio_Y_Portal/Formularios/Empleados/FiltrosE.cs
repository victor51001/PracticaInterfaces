using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace Inicio_Y_Portal
{
    public partial class FiltrosE : Form
    {
        public FiltrosE()
        {
            InitializeComponent();
        }
        public string ValorPuesto { get; set; }
        public string ValorComparacion { get; set; }
        public DateTime? ValorFecha { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ValorPuesto = null;
            ValorComparacion = null;
            ValorFecha = null;
            Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            bool puestos = chklstbxPuestos.CheckedItems.Count > 0;
            RadioButton rb = groupBoxCheck();
            bool fecha = (rb != null);
            if (puestos || fecha)
            {
                if (puestos)
                {
                    ValorPuesto = chklstbxPuestos.SelectedItem.ToString();
                }
                if (fecha)
                {
                    ValorComparacion = rb.Text;
                    ValorFecha = dtpFechaNacim.Value;
                }
                Close();
            }
        }
        public RadioButton groupBoxCheck()
        {
            RadioButton rb = null;
            foreach (RadioButton rbt in gpbComparar.Controls.OfType<RadioButton>())
            {
                if (rbt.Checked)
                {
                    rb = rbt; 
                    break;
                }
            }
            return rb;
        }

        public int lastCheckedIndex = -1;
        private void chklstbxPuestos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index != lastCheckedIndex)
            {
                if (lastCheckedIndex != -1)
                {
                    chklstbxPuestos.SetItemCheckState(lastCheckedIndex, CheckState.Unchecked);
                }
                lastCheckedIndex = e.Index;
            }
        }
    }
}
