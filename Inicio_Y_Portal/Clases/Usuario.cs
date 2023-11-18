using System;

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
