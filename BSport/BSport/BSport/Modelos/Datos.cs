using System;
using System.Collections.Generic;
using BSport.Funciones;
using System.Text;

namespace BSport.Modelos
{
    public class Datos
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public List<Partido> Partidos { get; set; }
        public Usuario Usuario { get; set; }
    }
}
