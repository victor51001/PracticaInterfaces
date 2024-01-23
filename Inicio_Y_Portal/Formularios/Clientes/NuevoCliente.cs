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

        private void tmTemporizador_Tick(object sender, EventArgs e)
        {
            prgsbrProgreso.PerformStep();
        }

        private void bttnArchivo_Click(object sender, EventArgs e)
        {
            if (pfdLogo.ShowDialog() == DialogResult.OK) {
                var imagen = pfdLogo.FileName;
                tmTemporizador.Start();
                txtbxLogo.Text = imagen;
                pctbxLogo.Image = Image.FromFile(imagen);
            }
        }
    }
}
