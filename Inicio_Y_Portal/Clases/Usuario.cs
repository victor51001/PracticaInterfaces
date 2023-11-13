using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio_Y_Portal
{
    [Serializable]
    public class Usuario
    {
        public string Id;
        public int Clave;

        public Usuario(string id, int clave)
        {
            Id = id;
            Clave = clave;
        }
    }
}
