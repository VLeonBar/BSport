using BSport.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSport.ModeloParaVista
{
    class PartidosParaPadel
    {
        public List<Partidos> Partidos { get; set; }
        public PartidosParaPadel()
        {
            Partidos = new Partidos().getPartidos();
        }
    }
}
