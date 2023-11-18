using Inicio_Y_Portal.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace Inicio_Y_Portal.Controladores
{
    public class ControladorCliente
    {
        public static List<Cliente> ListaClientes = new List<Cliente>();
        public static int ultimoCodigo = 1;
        public static bool cambios;
        public static void LeerCliente()
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
            catch (Exception) { }
        }

        public static void EscribirCliente()
        {
            try
            {
                var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
                string yamlString = serializer.Serialize(ListaClientes);
                File.WriteAllText("cliente.yml", yamlString);
            }
            catch (Exception) { }
        }
    }
}
