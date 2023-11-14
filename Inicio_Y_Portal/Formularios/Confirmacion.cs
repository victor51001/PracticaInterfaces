using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Y_Portal.Formularios
{
    public partial class Confirmacion : Form
    {
        public Confirmacion()
        {
            InitializeComponent();
        }
        public bool ok { get; set; }
        private void btnSi_Click(object sender, EventArgs e)
        {
            ok = true;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            ok = false;
            Close();
        }
    }
}
