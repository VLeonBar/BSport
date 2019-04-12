using System;
using System.Collections.Generic;
using System.Text;

namespace BSport.Modelos
{
    class Usuario
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public Usuario()
        {
            Nombre = "";
            Contraseña = "";
        }
        public Usuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;
        }

    }
}
