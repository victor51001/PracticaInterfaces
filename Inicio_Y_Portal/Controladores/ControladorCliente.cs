using Inicio_Y_Portal.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace Inicio_Y_Portal.Controladores
{
    public class ControladorCliente
    {
        public static List<Cliente> ListaClientes = new List<Cliente>();
        public static void leerProyecto()
        {
            try
            {
                if (File.Exists("cliente.yml"))
                {
                    string yamlString = File.ReadAllText("cliente.yml");
                    var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();
                    ListaClientes = deserializer.Deserialize<List<Cliente>>(yamlString);
                }
            }
            catch (Exception ex) { }
        }

        public static void escribirProyectos()
        {
            try
            {
                if (File.Exists("cliente.yml"))
                {
                    var serializer = new SerializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();
                    string yamlString = serializer.Serialize(ListaClientes);
                    File.WriteAllText("cliente.yml", yamlString);
                }
            }
            catch (Exception ex) { }
        }
    }
}
