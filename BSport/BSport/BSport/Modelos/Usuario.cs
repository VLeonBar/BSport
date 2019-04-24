using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;


namespace BSport.Modelos
{
    internal class Usuario : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string nombre;

        [JsonProperty("login")]
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }
        private string contraseña;

        [JsonProperty("pass")]
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        private int idUsuario;

        [JsonProperty("id_user")]
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
    }
}
