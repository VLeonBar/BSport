using System;
using System.Collections.Generic;
using System.Text;

namespace BSport.Modelos
{
    public class Usuario
    {
        public string Id_user { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public object Token { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Borrado { get; set; }
    }


    public class Datos
    {
        public int Codigo { get; set; }
        public Usuario Usuario { get; set; }
        public string Mensaje { get; set; }
    }
}
