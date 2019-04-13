using BSport.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSport.Funciones
{
    class Func
    {
        //Esta función recogerá los datos de la base de datos y rellenará los objetos pertinentes... Mejor una función que sirva para todos los casos o varias (???) Diría que varias.
        //O incluso sería mejor recoger los datos de los partidos en la clase partidos?¿?¿¿??¿ dudo.
        public object getDatos()
        {
            Partidos p = new Partidos()
            {
                IdPartido = 2,
                Lugar = "Indoor Padel",
                Fecha = "20/4/2019",
                Hora = "18:00-19:30",
                Nivel = "Intermedio",
                NJugadores = 2,
                MaxJugadores = 4,
                Precio = 2.5f,
                Imagen = "palapadel.png",
                Pista = 4
            };

            return p;
        }
    }
}
