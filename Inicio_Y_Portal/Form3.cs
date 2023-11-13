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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        int[] numeros = new int[20];

            private void Form3_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for(int i = 0; i<numeros.Length; i++)
            {
                numeros[i] = r.Next();
            }
        }

        private void bttnComprobar_Click(object sender, EventArgs e)
        {
            foreach (var i in numeros)
            {
                if (i==Int32.Parse(txtbNumeros.Text))
                {
                    MessageBox.Show("El numero introducido esta en el array.");
                } else
                {
                    MessageBox.Show("El numero introducido no esta en el array.");
                }
            }
        }
    }
}
