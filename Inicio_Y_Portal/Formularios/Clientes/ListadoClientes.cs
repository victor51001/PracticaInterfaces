using Inicio_Y_Portal.Clases;
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

namespace Inicio_Y_Portal.Formularios.Clientes
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }
        
        private void CrearCheckBox(Cliente cliente, int posicion, int contadorNombre)
        {
            CheckBox chkCliente = new CheckBox
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Location = new Point(35, posicion),
                Name = "chkCliente" + contadorNombre,
                Size = new Size(580, 20),
                Tag = cliente,
                TabIndex = 1,
                Text = (cliente.Codigo.ToString() + " " + cliente.Nombre.ToString() + " " + cliente.Direccion.ToString() + " " + cliente.Telefono.ToString() + " " + cliente.Correo.ToString())
            };
            gpbxClientes.Controls.Add(chkCliente);
        }
        private void MostrarClientes()
        {
            gpbxClientes.Controls.Clear();
            int posicion = 40, contador = 1;
            foreach (Cliente c in ControladorCliente.ListaClientes)
            {
                CrearCheckBox(c, posicion, contador);
                posicion += 30;
                contador++;
            }
        }
        private void OrdenarClientes(string valor)
        {
            if (valor != null)
            {
                switch (valor)
                {
                    case "Codigo":
                        ControladorCliente.ListaClientes.Sort(CriterioCodigo);
                        break;
                    case "Nombre":
                        ControladorCliente.ListaClientes.Sort(CriterioNombre);
                        break;
                    case "Direccion":
                        ControladorCliente.ListaClientes.Sort(CriterioDireccion);
                        break;
                    case "Telefono":
                        ControladorCliente.ListaClientes.Sort(CriterioTelefono);
                        break;
                    case "Correo":
                        ControladorCliente.ListaClientes.Sort(CriterioCorreo);
                        break;
                }
            }
        }

        private int CriterioCodigo(Cliente c1, Cliente c2)
        {
            if (c1.Codigo == c2.Codigo)
                return 0;
            else if (c1.Codigo > c2.Codigo)
                return 1;
            else
                return -1;
        }

        private int CriterioNombre(Cliente c1, Cliente c2)
        {
            return c1.Nombre.CompareTo(c2.Nombre);
        }

        private int CriterioDireccion(Cliente c1, Cliente c2)
        {
            return c1.Direccion.CompareTo(c2.Direccion);
        }

        private int CriterioTelefono(Cliente c1, Cliente c2)
        {
            if (c1.Telefono.CompareTo(c2.Telefono) == 0)
                return 0;
            else if (c1.Telefono.CompareTo(c2.Telefono) > 0)
                return 1;
            else
                return -1;
        }

        private int CriterioCorreo(Cliente c1, Cliente c2)
        {
            return c1.Correo.CompareTo(c2.Correo);
        }
        private void bttnImprimir_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void bttnOrdenar_Click(object sender, EventArgs e)
        {
            CriteriosC frm = new CriteriosC();
            frm.ShowDialog();
            OrdenarClientes(frm.ValorDevuelto);
            MostrarClientes();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gpbxClientes.Controls.Count > 0)
            {
                foreach (CheckBox control in gpbxClientes.Controls)
                {
                    if (control.Checked)
                    {
                        Cliente c = (Cliente)control.Tag;
                        foreach (Cliente cl in ControladorCliente.ListaClientes)
                        {
                            if (c.Equals(cl))
                            {
                                gpbxClientes.Controls.Remove(control);
                                ControladorCliente.ListaClientes.Remove(c);
                            }
                        }
                    }
                }
                MostrarClientes();
            }
        }
    }
}
