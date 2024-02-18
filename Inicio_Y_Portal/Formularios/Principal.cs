using Inicio_Y_Portal.Clases;
using Inicio_Y_Portal.Controladores;
using Inicio_Y_Portal.Formularios;
using Inicio_Y_Portal.Formularios.Clientes;
using Inicio_Y_Portal.Formularios.Usuarios;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inicio_Y_Portal
{
    public partial class Principal : Form
    {
        private bool[] cambios = {
            ControladorCliente.cambios,
            ControladorEmpleado.cambios,
            ControladorProyecto.cambios,
            ControladorUsuario.cambios
        };
        private Confirmacion frmconfirm = new Confirmacion();

        private ListadoProyectos frmListaP = new ListadoProyectos();
        private NuevoProyecto frmNuevoProyecto = new NuevoProyecto();

        private ListadoEmpleados frmListaE = new ListadoEmpleados();
        private NuevoEmpleado frmNuevoEmpleado = new NuevoEmpleado();

        private ListadoClientes frmListaC = new ListadoClientes();
        private NuevoCliente frmNuevoCliente = new NuevoCliente();

        private ListadoUsuarios frmListaU = new ListadoUsuarios();
        private NuevoUsuario frmNuevoUsuario = new NuevoUsuario();

        public Principal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ControladorCliente.LeerCliente();
            ControladorEmpleado.LeerEmpleados();
            ControladorProyecto.LeerProyectos();
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

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario.ShowDialog();
        }

        private void listadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListaU.ShowDialog();
        }

        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaC.ShowDialog();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoCliente.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmconfirm.ShowDialog();
            if (frmconfirm.ok)
            {
                for (int i = 0; i < cambios.Length; i++)
                {
                    if (cambios[i])
                    {
                        switch (i)
                        {
                            case 0:
                                ControladorCliente.EscribirCliente();
                                break;
                            case 1:
                                ControladorEmpleado.EscribirEmpleados();
                                break;
                            case 2:
                                ControladorProyecto.EscribirProyectos();
                                break;
                            case 3:
                                ControladorUsuario.EscribirUsuarios();
                                break;
                        }
                        cambios[i] = false;
                    }
                }
            }
        }
        private void CargarDatosEnComboBox()
        {
            string connectionString = "tu-cadena-conexión";
            string query = "SELECT CodigoProyecto FROM Proyectos";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar cada campo al ComboBox
                                //comboBoxProyecto.Items.Add(reader["CodigoProyecto"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        private string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            // A diferencia de la anterior version, forzamos a que coja la ruta relativa con el Path.GetFullPath
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\baseDatosGestiona.mdf"));
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;
        }/*
    private void insertarProyecto()
    {
        // Cadena de conexión a la base de datos
        // Ver método construirCadenaConexión más arriba
        string connectionString = construirCadenaConexión();
        // Query de inserción
        string query = "INSERT INTO Proyectos (Descripcion, FechaInicio, FechaFin,Estado,PresupuestoInicial, PresupuestoActual, Cambios, CodigoCliente) VALUES(@Descripcion,@FechaInicio, @FechaFin, @Estado, @PresupuestoInicial, @PresupuestoActual, @Cambios,@CodigoCliente)";
        // Valores para los parámetros
        string descripcion = textBoxDescripcion.Text;
        string fechaInicio = Convert.ToString(dateTimePicker1.Value);
        string fechaFin = Convert.ToString(dateTimePicker2.Value);
        string estado = Convert.ToString(comboBox1.ValueMember);
        double presupuestoInicial = Convert.ToDouble(textBoxPresupuestoInicial.Text);
        double presupuestoFinal = Convert.ToDouble(textBoxPresupuestoActual.Text);
        string cambios = Convert.ToString(comboBox2.ValueMember);
        string codigoCliente = textBoxCliente.Text;
        // Crear la conexión
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Abrir la conexión
            connection.Open();
            // Crear un objeto SqlCommand con la consulta y la conexión
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@FechaFin", fechaFin);
                command.Parameters.AddWithValue("@Estado", estado);
                command.Parameters.AddWithValue("@PresupuestoInicial", presupuestoInicial);
                command.Parameters.AddWithValue("@PresupuestoActual",
                presupuestoFinal);
                command.Parameters.AddWithValue("@Cambios", cambios);
                command.Parameters.AddWithValue("@CodigoCliente", codigoCliente);
                try
                {
                    // Ejecutar la consulta de inserción
                    int registrosAfectados = command.ExecuteNonQuery();
                    MessageBox.Show($"Se insertó correctamente el registro. Registrosafectados: {registrosAfectados}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                }
            }
        }
    }*/
        private void CargarDatosEnDataGridView()
        {
            string connectionString = "cadenaconexion"; // Reemplaza con tu cadena de conexión
                                                        // En este caso, solo realiza un select del campo CódigoProyecto y nombreProyecto
                                                        // Sería necesario adaptarlo si queremos todos los campos de un proyecto.
            string query = "SELECT CodigoProyecto, NombreProyecto FROM Proyectos";
            //dataGridView1.Columns.Clear();
            //dataGridView1.Columns.Add("Codigo Proyecto", "Codigo Proyecto");
            //dataGridView1.Columns.Add("Nombre Proyecto", "Nombre Proyecto");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar una nueva fila al DataGridView con el código y el nombre del proyecto
                                //dataGridView1.Rows.Add(reader["CodigoProyecto"].ToString(), reader["NombreProyecto"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }
    }
}
