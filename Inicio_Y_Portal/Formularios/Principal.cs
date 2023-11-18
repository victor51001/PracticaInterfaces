using Inicio_Y_Portal.Clases;
using Inicio_Y_Portal.Controladores;
using Inicio_Y_Portal.Formularios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inicio_Y_Portal
{
    public partial class Principal : Form
    {
        public static List<string> cambios;
        private Confirmacion frmconfirm = new Confirmacion();

        private ListadoProyectos frmListaP = new ListadoProyectos();
        private NuevoProyecto frmNuevoProyecto = new NuevoProyecto();

        private ListadoEmpleados frmListaE = new ListadoEmpleados();
        private NuevoEmpleado frmNuevoEmpleado = new NuevoEmpleado();

        public Principal()
        {
            InitializeComponent();
        }
        private void cargarClientes()
        {
            ControladorCliente.ListaClientes.Add(new Cliente(
                "John Doe",
                "123 Main Street",
                "555-1234",
                "john.doe@email.com"
            ));
            ControladorCliente.ListaClientes.Add(new Cliente(
                "Jane Smith",
                "456 Oak Avenue",
                "555-5678",
                "jane.smith@email.com"
            ));
            ControladorCliente.ListaClientes.Add(new Cliente(
                "Tech Solutions Inc.",
                "789 Center Plaza",
                "555-9012",
                "info@techsolutions.com"
            ));
            ControladorCliente.ListaClientes.Add(new Cliente(
                "Alice Johnson",
                "567 Pedestrian Lane",
                "555-3456",
                "alice.johnson@email.com"
            ));
            ControladorCliente.ListaClientes.Add(new Cliente(
                "Creative Designs Co.",
                "543 Main Street",
                "555-7890",
                "info@creativedesigns.com"
            ));
        }
        private void cargarProyectos()
        {
            ControladorProyecto.ListaProyectos.Add(new Proyecto(
                "WEB 1.0 PARA TÉCNICAS REUNIDAS", 
                DateTime.Parse("30/12/2031"), 
                50000, 
                ControladorCliente.ListaClientes[0]
                ));
            ControladorProyecto.ListaProyectos.Add(new Proyecto(
                "APLICACIÓN CONTABLE PARA TÉCNICAS REUNIDAS", 
                DateTime.Parse("12/01/2025"), 
                4000, 
                ControladorCliente.ListaClientes[1]
                ));
            ControladorProyecto.ListaProyectos.Add(new Proyecto(
                "WEB 1.0 PARA AXA", 
                DateTime.Parse("04/05/2028"), 
                30000, 
                ControladorCliente.ListaClientes[2]
                ));
            ControladorProyecto.ListaProyectos.Add(new Proyecto(
                "WEB 3.0 PARA SANTANDER", 
                DateTime.Parse("08/11/2029"), 
                22000, 
                ControladorCliente.ListaClientes[3]
                ));
            ControladorProyecto.ListaProyectos.Add(new Proyecto(
                "APLICACIÓN MÓVIL SELENIUM", 
                DateTime.Parse("28/09/2035"), 
                98000, 
                ControladorCliente.ListaClientes[4]
                ));
        }
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
        private void Form2_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarProyectos();
            cargarEmpleados();
        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmListaP.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNuevoProyecto.ShowDialog();
        }

        private void listadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListaE.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNuevoEmpleado.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmconfirm.ShowDialog();
            if (frmconfirm.ok)
            {
                while (cambios.Count > 0)
                {
                    switch (cambios[0])
                    {
                        case "Empleado":
                            ControladorEmpleado.EscribirEmpleados();
                            cambios.RemoveAt(0);
                            break;
                        case "Proyecto":
                            ControladorProyecto.EscribirProyectos();
                            cambios.RemoveAt(0);
                            break;
                        case "Usuario":
                            ControladorUsuario.EscribirUsuarios();
                            cambios.RemoveAt(0);
                            break;
                        case "Cliente":
                            ControladorCliente.EscribirCliente();
                            cambios.RemoveAt(0);
                            break;
                            //Falta acabar esta parte, acabar usuarios, confirmacion, clientes todo.
                    }
                }
            }
        }
    }
}
