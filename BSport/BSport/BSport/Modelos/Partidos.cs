using System;
using System.Collections.Generic;
using System.Text;

namespace BSport.Modelos
{
    class Partidos
    {
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
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private DateTime hora;

        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        private string liga;

        public string Liga
        {
            get { return liga; }
            set { liga = value; }
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
        private int puntMedia;

        public int PuntMedia
        {
            get { return puntMedia; }
            set { puntMedia = value; }
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


        public List<Partidos> getPartidos()
        {
            List<Partidos> partidos = new List<Partidos>()
            {
                new Partidos(){
                    Lugar="Barreiro",Fecha=DateTime.Today,Hora=DateTime.Now,Liga="Platino",NJugadores=2,MaxJugadores=4,Precio=2.5f,PuntMedia=1634,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    Lugar="Navia",Fecha=DateTime.Today,Hora=DateTime.Now,Liga="Platino",NJugadores=2,MaxJugadores=4,Precio=2.5f,PuntMedia=1634,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    Lugar="Air Padel",Fecha=DateTime.Today,Hora=DateTime.Now,Liga="Platino",NJugadores=2,MaxJugadores=4,Precio=2.5f,PuntMedia=1634,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    Lugar="Indoor Padel",Fecha=DateTime.Today,Hora=DateTime.Now,Liga="Platino",NJugadores=2,MaxJugadores=4,Precio=2.5f,PuntMedia=1634,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    Lugar="Navia",Fecha=DateTime.Today,Hora=DateTime.Now,Liga="Platino",NJugadores=2,MaxJugadores=4,Precio=2.5f,PuntMedia=1634,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    Lugar="Navia",Fecha=DateTime.Today,Hora=DateTime.Now,Liga="Platino",NJugadores=2,MaxJugadores=4,Precio=2.5f,PuntMedia=1634,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    Lugar="Navia",Fecha=DateTime.Today,Hora=DateTime.Now,Liga="Platino",NJugadores=2,MaxJugadores=4,Precio=2.5f,PuntMedia=1634,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    Lugar="Navia",Fecha=DateTime.Today,Hora=DateTime.Now,Liga="Platino",NJugadores=2,MaxJugadores=4,Precio=2.5f,PuntMedia=1634,Imagen="palapadel.png",Pista=4
                },new Partidos(){
                    Lugar="Navia",Fecha=DateTime.Today,Hora=DateTime.Now,Liga="Platino",NJugadores=2,MaxJugadores=4,Precio=2.5f,PuntMedia=1634,Imagen="palapadel.png",Pista=4
                }
            };
            return partidos;
        }


    }
}
