using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Inicio_Y_Portal.Controladores
{
    public class ControladorUsuario
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>();
        public static void LeerUsuarios()
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("usuarios.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                ControladorUsuario.ListaUsuarios = (List<Usuario>)deserializer.Deserialize(OpenFileStream);
                OpenFileStream.Close();
            }
            catch (Exception)
            { }
        }
        public static void EscribirUsuarios()
        {
            try
            {
                Stream SaveFileStream = File.Create("usuarios.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, ListaUsuarios);
                SaveFileStream.Close();
            }
            catch (Exception)
            { }
        }
    }
}
