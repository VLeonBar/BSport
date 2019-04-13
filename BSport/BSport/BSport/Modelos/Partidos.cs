using BSport.Funciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSport.Modelos
{
    class Partidos
    {
        private Func f;
        private int idPartido;

        public int IdPartido
        {
            get { return idPartido; }
            set { idPartido = value; }
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
        private string hora;

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
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

        const int MAXJUGADORES = 4;
        public List<Partidos> getPartidos()
        {
            f = new Func();
            List<Partidos> partidos = new List<Partidos>()
            {
                //Cargar aquí los datos de la base de datos y rellenar el objeto... (???????????)
                (Partidos)f.getDatos(),
                new Partidos(){
                    IdPartido=1,Lugar="Barreiro",Fecha="20/4/2019",Hora="18:00-19:30",Nivel="Intermedio",NJugadores=2,MaxJugadores=MAXJUGADORES,Precio=2.5f,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    IdPartido=1,Lugar="Navia",Fecha="20/4/2019",Hora="18:00-19:30",Nivel="Intermedio",NJugadores=2,MaxJugadores=MAXJUGADORES,Precio=2.5f,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    IdPartido=1,Lugar="IPadel",Fecha="20/4/2019",Hora="18:00-19:30",Nivel="Intermedio",NJugadores=2,MaxJugadores=MAXJUGADORES,Precio=2.5f,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    IdPartido=1,Lugar="Navia",Fecha="20/4/2019",Hora="18:00-19:30",Nivel="Intermedio",NJugadores=2,MaxJugadores=MAXJUGADORES,Precio=2.5f,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    IdPartido=1,Lugar="IPadel",Fecha="20/4/2019",Hora="18:00-19:30",Nivel="Intermedio",NJugadores=2,MaxJugadores=MAXJUGADORES,Precio=2.5f,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    IdPartido=1,Lugar="Navia",Fecha="20/4/2019",Hora="18:00-19:30",Nivel="Intermedio",NJugadores=2,MaxJugadores=MAXJUGADORES,Precio=2.5f,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    IdPartido=1,Lugar="IPadel",Fecha="20/4/2019",Hora="18:00-19:30",Nivel="Intermedio",NJugadores=2,MaxJugadores=MAXJUGADORES,Precio=2.5f,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    IdPartido=1,Lugar="Navia",Fecha="20/4/2019",Hora="18:00-19:30",Nivel="Intermedio",NJugadores=2,MaxJugadores=MAXJUGADORES,Precio=2.5f,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    IdPartido=1,Lugar="IPadel",Fecha="20/4/2019",Hora="18:00-19:30",Nivel="Intermedio",NJugadores=2,MaxJugadores=MAXJUGADORES,Precio=2.5f,Imagen="palapadel.png",Pista=4
                }
            };
            return partidos;
        }
    }
}
