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

        private void bttnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                rchtxtbxComentarios.SelectionColor = selectedColor;
            }
        }

        private void bttnFuente_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog.Font;
                rchtxtbxComentarios.SelectionFont = selectedFont;
            }
        }

        private void bttnExportar_Click(object sender, EventArgs e)
        {
            var rutaAArchivo = string.Empty;
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rchtxtbxComentarios.SaveFile(saveFileDialog1.FileName);
                        MessageBox.Show("Datos exportados");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Datos NO exportados");
                    }
                }
            }

        }
    }
}
