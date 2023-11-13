using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Inicio_Y_Portal.Controladores
{
    public class ControladorProyecto
    {
        public static List<Proyecto> ListaProyectos = new List<Proyecto>();
        public static void leerProyecto()
        {
            try
            {
                if (File.Exists("proyecto.json"))
                {
                    string jsonString = File.ReadAllText("proyecto.json");
                    ListaProyectos = JsonSerializer.Deserialize<List<Proyecto>>(jsonString);
                }
            }
            catch (Exception ex) {}
        }

        public static void escribirProyectos()
        {
            try
            {
                if (File.Exists("proyecto.json"))
                {
                    string jsonString = JsonSerializer.Serialize(ListaProyectos);
                    File.WriteAllText("proyecto.json", jsonString);
                }
            }
            catch (Exception ex) {}
        }
    }
}
