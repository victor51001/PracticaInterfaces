using Inicio_Y_Portal.Formularios.Usuarios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Inicio_Y_Portal.Controladores
{
    public class ControladorUsuario
    {
        public static List<Usuario> ListaUsuarios;
        public static void leerUsuarios()
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("usuarios.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                ControladorUsuario.ListaUsuarios = (List<Usuario>)deserializer.Deserialize(OpenFileStream);
                OpenFileStream.Close();
            }
            catch (Exception e)
            { }
        }
        public static void escribirUsuarios()
        {
            try
            {
                Stream SaveFileStream = File.Create("usuarios.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, ListaUsuarios);
                SaveFileStream.Close();
            }
            catch (Exception e)
            { }
        }
    }
}
