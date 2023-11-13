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
        public List<Empleado> listaVistaEmpleados;
        private void cargarEmpleados()
        {
            ControladorEmpleado.ListaEmpleados.Add(new Empleado(
                "12345678Z",
                "Juan",
                "González",
                "López",
                Puesto.Jefe,
                619283746,
                "juan@empresaficticia.com",
                new DateTime(1985, 3, 15),
                523456890,
                "Buen empleado con mucha experiencia en gestión."
            ));
            ControladorEmpleado.ListaEmpleados.Add(new Empleado(
                "87654321X",
                "María",
                "Sánchez",
                "Martínez",
                Puesto.Asistente,
                654739821,
                "maria@empresaficticia.com",
                new DateTime(1990, 6, 20),
                234678901,
                "Dedicada y proactiva, siempre dispuesta a ayudar."
            ));
            ControladorEmpleado.ListaEmpleados.Add(new Empleado(
                "56789012B",
                "Carlos",
                "Rodríguez",
                "Fernández",
                Puesto.Analista,
                672548319,
                "carlos@empresaficticia.com",
                new DateTime(1982, 9, 10),
                345678901,
                "Experto en análisis de datos y estadísticas."
            ));
            ControladorEmpleado.ListaEmpleados.Add(new Empleado(
                "98765432M",
                "Luisa",
                "Pérez",
                "Ramírez",
                Puesto.Diseñador,
                687132954,
                "luisa@empresaficticia.com",
                new DateTime(1988, 12, 5),
                456789023,
                "Creativa y con un gran ojo para el diseño."
            ));
            ControladorEmpleado.ListaEmpleados.Add(new Empleado(
                "23456789D",
                "Pedro",
                "Gómez",
                "Fuentes",
                Puesto.Desarrollador,
                698574213,
                "pedro@empresaficticia.com",
                new DateTime(1995, 7, 25),
                568901234,
                "Programador talentoso con fuertes habilidades técnicas."
            ));
        }
        private void crearCheckBox(Empleado empleado, int posicion, int contadorNombre)
        {
            CheckBox chkEmpleado = new CheckBox();
            chkEmpleado.AutoSize = true;
            chkEmpleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            chkEmpleado.Location = new Point(35, posicion);
            chkEmpleado.Name = "chkProyecto" + contadorNombre;
            chkEmpleado.Size = new Size(580, 20);
            chkEmpleado.TabIndex = 1;
            chkEmpleado.Text = (empleado.Id.ToString() + " " + empleado.DNI.ToString() + " " + empleado.Nombre.ToString() + " " + empleado.Apellido1 + " " + empleado.Apellido2.ToString() + " " + empleado.Puesto.ToString() + " " + empleado.Telefono.ToString());
            gpbxEmpleados.Controls.Add(chkEmpleado);
        }
        private void mostrarEmpleados(List<Empleado> listaE)
        {
            gpbxEmpleados.Controls.Clear();
            int posicion = 40, contador = 1;
            foreach (Empleado e in listaE)
            {
                crearCheckBox(e, posicion, contador);
                posicion += 30;
                contador++;
            }
        }
        private void ordenarEmpleados(string valor)
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

        private void filtrarEmpleados(string valorPuesto, string valorComparacion, DateTime? valorFecha)
        {
            if (valorPuesto!=null)
            {
                foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                {
                    if (e.Puesto.Equals(valorPuesto))
                    {
                        listaVistaEmpleados.Add(e);
                    }
                }
                if (valorComparacion!=null)
                {
                    List<Empleado> listaAux = listaVistaEmpleados;
                    listaVistaEmpleados.Clear();
                    switch (valorComparacion)
                    {
                        case "Mayor a":
                            foreach (Empleado e in listaAux)
                            {
                                if (e.FechaNacimiento > valorFecha)
                                {
                                    listaVistaEmpleados.Add(e);
                                }
                            }
                            break;
                        case "Menor a":
                            foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                            {
                                if (e.FechaNacimiento < valorFecha)
                                {
                                    listaVistaEmpleados.Add(e);
                                }
                            }
                            break;
                        case "Igual a":
                            foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                            {
                                if (e.FechaNacimiento == valorFecha)
                                {
                                    listaVistaEmpleados.Add(e);
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
                                listaVistaEmpleados.Add(e);
                            }
                        }
                        break;
                    case "Menor a":
                        foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                        {
                            if (e.FechaNacimiento < valorFecha)
                            {
                                listaVistaEmpleados.Add(e);
                            }
                        }
                        break;
                    case "Igual a":
                        foreach (Empleado e in ControladorEmpleado.ListaEmpleados)
                        {
                            if (e.FechaNacimiento == valorFecha)
                            {
                                listaVistaEmpleados.Add(e);
                            }
                        }
                        break;
                }
            }
        }
        private void ListadoEmpleados_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
        }

        private void bttnImprimir_Click(object sender, EventArgs e)
        {
            mostrarEmpleados(ControladorEmpleado.ListaEmpleados);
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnOrdenar_Click(object sender, EventArgs e)
        {
            CriteriosE frm = new CriteriosE();
            frm.ShowDialog();
            ordenarEmpleados(frm.ValorDevuelto);
            mostrarEmpleados(listaVistaEmpleados);
        }

        private void bttnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrosE frm = new FiltrosE();
            frm.ShowDialog();
            if (frm.ValorPuesto!=null || frm.ValorComparacion != null)
            {
                filtrarEmpleados(frm.ValorPuesto, frm.ValorComparacion, frm.ValorFecha);
                mostrarEmpleados(listaVistaEmpleados);
            }
        }

        int CriterioId(Empleado e1, Empleado e2)
        {
            if (e1.Id == e1.Id)
                return 0;
            else if (e1.Id > e1.Id)
                return 1;
            else
                return -1;
        }
        int CriterioDNI(Empleado e1, Empleado e2)
        {
            return e1.DNI.CompareTo(e2.DNI);
        }
        int CriterioNombre(Empleado e1, Empleado e2)
        {
            return e1.Nombre.CompareTo(e2.Nombre);
        }
        int CriterioApellido1(Empleado e1, Empleado e2)
        {
            return e1.Apellido1.CompareTo(e2.Apellido1);
        }
        int CriterioApellido2(Empleado e1, Empleado e2)
        {
            return e1.Apellido2.CompareTo(e2.Apellido2);
        }
        int CriterioPuesto(Empleado e1, Empleado e2)
        {
            return e1.Puesto.CompareTo(e2.Puesto);
        }
        int CriterioTelefono(Empleado e1, Empleado e2)
        {
            if (e1.Telefono.CompareTo(e2.Telefono) == 0)
                return 0;
            else if (e1.Telefono.CompareTo(e2.Telefono) > 0)
                return 1;
            else
                return -1;
        }
        int CriterioCorreo(Empleado e1, Empleado e2)
        {
            return e1.Correo.CompareTo(e2.Correo);
        }
        int CriterioFechaNac(Empleado e1, Empleado e2)
        {
            return e1.FechaNacimiento.CompareTo(e2.FechaNacimiento);
        }
        int CriterioNumSegSoc(Empleado e1, Empleado e2)
        {
            if (e1.NumeroSeguridadSocial.CompareTo(e2.NumeroSeguridadSocial) == 0)
                return 0;
            else if (e1.NumeroSeguridadSocial.CompareTo(e2.NumeroSeguridadSocial) > 0)
                return 1;
            else
                return -1;
        }
        int CriterioComentarios(Empleado e1, Empleado e2)
        {
            return e1.Comentarios.CompareTo(e2.Comentarios);
        }
    }
}