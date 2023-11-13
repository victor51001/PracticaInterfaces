using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Inicio_Y_Portal.Controladores
{
    public class ControladorEmpleado
    {
        public static List<Empleado> ListaEmpleados = new List<Empleado>();
        public static void leerEmpleados()
        {
            try
            {
                string xml = File.ReadAllText("empleados.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(ListaEmpleados.GetType());
                    ListaEmpleados = (List<Empleado>)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex) {}
        }

        public static void escribirEmpleados()
        {
            try
            {
                using (var writer = new StreamWriter("usuarios.xml"))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(ListaEmpleados.GetType());
                    serializer.Serialize(writer, ListaEmpleados, namespaces);
                }
            }
            catch (Exception ex) {}
        }
    }
}
