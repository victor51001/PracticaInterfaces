using Inicio_Y_Portal.Controladores;
using Inicio_Y_Portal.Formularios.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Y_Portal.Formularios.Usuarios
{
    public partial class ListadoUsuarios : Form
    {
        public ListadoUsuarios()
        {
            InitializeComponent();
        }
        private void CrearCheckBox(Usuario usuario, int posicion, int contadorNombre)
        {
            CheckBox chkUsuario = new CheckBox
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Location = new Point(35, posicion),
                Name = "chkUsuario" + contadorNombre,
                Size = new Size(580, 20),
                Tag = usuario,
                TabIndex = 1,
                Text = usuario.Id.ToString() + " " + usuario.Clave.ToString()
            };
            gpbxUsuarios.Controls.Add(chkUsuario);
        }

        private void MostrarUsuarios()
        {
            gpbxUsuarios.Controls.Clear();
            int posicion = 40, contador = 1;
            foreach (Usuario u in ControladorUsuario.ListaUsuarios)
            {
                CrearCheckBox(u, posicion, contador);
                posicion += 30;
                contador++;
            }
        }

        private void bttnImprimir_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gpbxUsuarios.Controls.Count > 0)
            {
                foreach (CheckBox control in gpbxUsuarios.Controls)
                {
                    if (control.Checked)
                    {
                        Usuario u = (Usuario)control.Tag;
                        foreach (Usuario us in ControladorUsuario.ListaUsuarios)
                        {
                            if (u.Equals(us))
                            {
                                gpbxUsuarios.Controls.Remove(control);
                                ControladorUsuario.ListaUsuarios.Remove(u);
                                break; 
                            }
                        }
                    }
                }
                MostrarUsuarios();
            }
        }

    }
}
