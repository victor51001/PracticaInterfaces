using Inicio_Y_Portal.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Y_Portal
{
    public partial class FrmRegistro : Form
    {
        
        int vueltas = 0;
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }


        private void cargarUsuarios()
        {
            ControladorUsuario.ListaUsuarios.Add(new Usuario("root", 1234));
            ControladorUsuario.ListaUsuarios.Add(new Usuario("Juan", 4321));
            ControladorUsuario.ListaUsuarios.Add(new Usuario("jaime", 4444));
            ControladorUsuario.ListaUsuarios.Add(new Usuario("jose", 1111));
            ControladorUsuario.ListaUsuarios.Add(new Usuario("javier", 2222));
            ControladorUsuario.ListaUsuarios.Add(new Usuario("jorge", 3333));
        }
        private Boolean validaUsuario(String id, int clave)
        {
            int posicion = ControladorUsuario.ListaUsuarios.FindIndex(x => x.Id == id.ToLower());
            if (posicion != -1 && ControladorUsuario.ListaUsuarios[posicion].Clave == clave)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            Boolean ok = validaUsuario(txtbUsuario.Text, Int32.Parse(txtbClave.Text));
            vueltas++;
            if (ok)
            {
                txtbUsuario.Clear();
                txtbClave.Clear();
                Principal Frm2 = new Principal();
                vueltas = 0;
                Frm2.ShowDialog();
                Close();
            } else  
            {
                MessageBox.Show("Usuario o clave incorrectos"); 
                txtbUsuario.Clear();
                txtbClave.Clear();
            }    
            if (vueltas==3)
            {
                Application.Exit();
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
