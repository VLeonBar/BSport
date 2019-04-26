using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;


namespace BSport.Modelos
{
    class Usuario
    {
        public string Id_user { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public object Token { get; set; }
        public string Email { get; set; }
        public string Borrado { get; set; }
    }
}

