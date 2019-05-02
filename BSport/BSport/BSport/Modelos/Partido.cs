using BSport.Funciones;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BSport.Modelos
{
    public class Partido
    {

        private int id_partido;

        public int Id_Partido
        {
            get { return id_partido; }
            set { id_partido = value; }
        }

        private string lugar;

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string horaI;

        public string HoraI
        {
            get { return horaI; }
            set { horaI = value; }
        }

        private string horaF;

        public string HoraF
        {
            get { return horaF; }
            set { horaF = value; }
        }
        private string nivel;

        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        private int nJugadores;

        public int NJugadores
        {
            get { return nJugadores; }
            set { nJugadores = value; }
        }
        private int maxJugadores;

        public int MaxJugadores
        {
            get { return maxJugadores; }
            set { maxJugadores = value; }
        }
        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string imagen;

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        private int pista;

        public int Pista
        {
            get { return pista; }
            set { pista = value; }
        }
        private List<KeyValuePair<int, string>> jugadores;

        public List<KeyValuePair<int, string>> Jugadores
        {
            get { return jugadores; }
            set { jugadores = value; }
        }
    }
}
