using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Inicio_Y_Portal.Controladores
{
    public class ControladorProyecto
    {
        public static List<Proyecto> ListaProyectos = new List<Proyecto>();
        public static int ultimoCodigo = 1;
        public static bool cambios;
        public static void LeerProyectos()
        {
            try
            {
                if (File.Exists("proyecto.json"))
                {
                    string jsonString = File.ReadAllText("proyecto.json");
                    ListaProyectos = JsonSerializer.Deserialize<List<Proyecto>>(jsonString);
                }
            }
            catch (Exception) { }
        }

        public static void EscribirProyectos()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(ListaProyectos);
                File.WriteAllText("proyecto.json", jsonString);
            }
            catch (Exception) { }
        }
    }
}
