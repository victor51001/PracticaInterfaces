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
    public partial class CriteriosE : Form
    {
        public CriteriosE()
        {
            InitializeComponent();
        }
        private void chklstbxCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttnAceptar.Enabled = chklstbxCriterios.SelectedItems.Count > 0;
        }
        
        public string ValorDevuelto { get; set; }
        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            ValorDevuelto = chklstbxCriterios.SelectedItems[0].ToString();
            Close();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            ValorDevuelto = null;
            Close();
        }

        public int lastCheckedIndex = -1;
        private void chklstbxCriterios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index != lastCheckedIndex)
            {
                if (lastCheckedIndex != -1)
                {
                    chklstbxCriterios.SetItemCheckState(lastCheckedIndex, CheckState.Unchecked);
                }
                lastCheckedIndex = e.Index;
            }
        }
    }
}
