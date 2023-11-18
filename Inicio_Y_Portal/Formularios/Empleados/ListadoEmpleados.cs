using Inicio_Y_Portal.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CheckBox = System.Windows.Forms.CheckBox;
namespace Inicio_Y_Portal
{
    public partial class ListadoEmpleados : Form
    {
        public ListadoEmpleados()
        {
            InitializeComponent();
        }
        
        private void CrearCheckBox(Empleado empleado, int posicion, int contadorNombre)
        {
            CheckBox chkEmpleado = new CheckBox
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Location = new Point(35, posicion),
                Name = "chkProyecto" + contadorNombre,
                Size = new Size(580, 20),
                Tag = empleado,
                TabIndex = 1,
                Text = empleado.Id.ToString() + " " + empleado.DNI.ToString() + " " + empleado.Nombre.ToString() + " " + empleado.Apellido1 + " " + empleado.Apellido2.ToString() + " " + empleado.Puesto.ToString() + " " + empleado.Telefono.ToString()
            };
            gpbxEmpleados.Controls.Add(chkEmpleado);
        }
        private void MostrarEmpleados(List<Empleado> listaE)
        {
            gpbxEmpleados.Controls.Clear();
            int posicion = 40, contador = 1;
            foreach (Empleado e in listaE)
            {
                CrearCheckBox(e, posicion, contador);
                posicion += 30;
                contador++;
            }
        }
        private void OrdenarEmpleados(string valor)
        {
            if (valor != null)
            {
                switch (valor)
                {
                    case "Id":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioId);
                        break;
                    case "DNI":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioDNI);
                        break;
                    case "Nombre":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioNombre);
                        break;
                    case "Apellido1":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioApellido1);
                        break;
                    case "Apellido2":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioApellido2);
                        break;
                    case "Puesto":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioPuesto);
                        break;
                    case "Telefono":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioTelefono);
                        break;
                    case "Correo":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioCorreo);
                        break;
                    case "Fecha de nacimiento":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioFechaNac);
                        break;
                    case "Numero de la seguridad social":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioNumSegSoc);
                        break;
                    case "Comentarios":
                        ControladorEmpleado.ListaEmpleados.Sort(CriterioComentarios);
                        break;
                }
            }
        }

        private void FiltrarEmpleados(string valorPuesto, string valorComparacion, DateTime? valorFecha)
        {
            if (valorPuesto!=null)
            {
                foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                {
                    if (e.Puesto.Equals(valorPuesto))
                    {
                        ControladorEmpleado.listaVistaEmpleados.Add(e);
                    }
                }
                if (valorComparacion!=null)
                {
                    List<Empleado> listaAux = ControladorEmpleado.listaVistaEmpleados;
                    ControladorEmpleado.listaVistaEmpleados.Clear();
                    switch (valorComparacion)
                    {
                        case "Mayor a":
                            foreach (Empleado e in listaAux)
                            {
                                if (e.FechaNacimiento > valorFecha)
                                {
                                    ControladorEmpleado.listaVistaEmpleados.Add(e);
                                }
                            }
                            break;
                        case "Menor a":
                            foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                            {
                                if (e.FechaNacimiento < valorFecha)
                                {
                                    ControladorEmpleado.listaVistaEmpleados.Add(e);
                                }
                            }
                            break;
                        case "Igual a":
                            foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                            {
                                if (e.FechaNacimiento == valorFecha)
                                {
                                    ControladorEmpleado.listaVistaEmpleados.Add(e);
                                }
                            }
                            break;
                    }
                }
            } else if (valorComparacion!=null)
            {
                switch (valorComparacion)
                {
                    case "Mayor a":
                        foreach (Empleado e in  ControladorEmpleado.ListaEmpleados)
                        {
                            if (e.FechaNacimiento > valorFecha)
                            {
                                ControladorEmpleado.listaVistaEmpleados.Add(e);
                            }
                        }
                        break;
                    case "Menor a":
                        foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                        {
                            if (e.FechaNacimiento < valorFecha)
                            {
                                ControladorEmpleado.listaVistaEmpleados.Add(e);
                            }
                        }
                        break;
                    case "Igual a":
                        foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                        {
                            if (e.FechaNacimiento == valorFecha)
                            {
                                ControladorEmpleado.listaVistaEmpleados.Add(e);
                            }
                        }
                        break;
                }
            }
        }

        private void bttnImprimir_Click(object sender, EventArgs e)
        {
            MostrarEmpleados(ControladorEmpleado.ListaEmpleados);
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnOrdenar_Click(object sender, EventArgs e)
        {
            CriteriosE frm = new CriteriosE();
            frm.ShowDialog();
            OrdenarEmpleados(frm.ValorDevuelto);
            MostrarEmpleados(ControladorEmpleado.ListaEmpleados);
        }

        private void bttnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrosE frm = new FiltrosE();
            frm.ShowDialog();
            if (frm.ValorPuesto!=null || frm.ValorComparacion != null)
            {
                FiltrarEmpleados(frm.ValorPuesto, frm.ValorComparacion, frm.ValorFecha);
                MostrarEmpleados(ControladorEmpleado.listaVistaEmpleados);
            }
        }
        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (gpbxEmpleados.Controls.Count > 0)
            {
                foreach (CheckBox control in gpbxEmpleados.Controls)
                {
                    if (control.Checked)
                    {
                        Empleado em = (Empleado)control.Tag;
                        foreach (Empleado emp in ControladorEmpleado.ListaEmpleados)
                        {
                            if (em.Equals(emp))
                            {
                                gpbxEmpleados.Controls.Remove(control);
                                ControladorEmpleado.ListaEmpleados.Remove(em);
                            }
                        }
                    }
                }
                MostrarEmpleados(ControladorEmpleado.ListaEmpleados);
            }
        }

        private int CriterioId(Empleado e1, Empleado e2)
        {
            if (e1.Id == e1.Id)
                return 0;
            else if (e1.Id > e1.Id)
                return 1;
            else
                return -1;
        }
        private int CriterioDNI(Empleado e1, Empleado e2)
        {
            return e1.DNI.CompareTo(e2.DNI);
        }
        private int CriterioNombre(Empleado e1, Empleado e2)
        {
            return e1.Nombre.CompareTo(e2.Nombre);
        }
        private int CriterioApellido1(Empleado e1, Empleado e2)
        {
            return e1.Apellido1.CompareTo(e2.Apellido1);
        }
        private int CriterioApellido2(Empleado e1, Empleado e2)
        {
            return e1.Apellido2.CompareTo(e2.Apellido2);
        }
        private int CriterioPuesto(Empleado e1, Empleado e2)
        {
            return e1.Puesto.CompareTo(e2.Puesto);
        }
        private int CriterioTelefono(Empleado e1, Empleado e2)
        {
            if (e1.Telefono.CompareTo(e2.Telefono) == 0)
                return 0;
            else if (e1.Telefono.CompareTo(e2.Telefono) > 0)
                return 1;
            else
                return -1;
        }
        private int CriterioCorreo(Empleado e1, Empleado e2)
        {
            return e1.Correo.CompareTo(e2.Correo);
        }
        private int CriterioFechaNac(Empleado e1, Empleado e2)
        {
            return e1.FechaNacimiento.CompareTo(e2.FechaNacimiento);
        }
        private int CriterioNumSegSoc(Empleado e1, Empleado e2)
        {
            if (e1.NumeroSeguridadSocial.CompareTo(e2.NumeroSeguridadSocial) == 0)
                return 0;
            else if (e1.NumeroSeguridadSocial.CompareTo(e2.NumeroSeguridadSocial) > 0)
                return 1;
            else
                return -1;
        }
        private int CriterioComentarios(Empleado e1, Empleado e2)
        {
            return e1.Comentarios.CompareTo(e2.Comentarios);
        }        
    }
}