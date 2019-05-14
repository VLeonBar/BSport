using BSport.Funciones;
using BSport.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BSport.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerPartido : ContentPage
    {
        public Usuario Usuario { get; set; }
        public Partido Partido { get; set; }
        public VerPartido(Usuario usuario, Partido partido)
        {
            InitializeComponent();
            Usuario = usuario;
            Partido = partido;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Lugar.Text = Partido.Lugar;
            Precio.Text = Partido.Precio.ToString() + "€";
            Pista.Text = "Nº" + Partido.Pista.ToString();
            Fecha.Text = Partido.Fecha;
            HoraI.Text = Partido.HoraI;
            HoraF.Text = Partido.HoraF;
            Nivel.Text = Partido.Nivel;

            RestService restService = new RestService();
            string Url = "http://47.63.67.93:54321/api_bsport/select/jugadores_partido.php";

            Datos datos = await restService.Post<Datos>(Url, new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("Id_partido", Partido.Id_Partido.ToString()) });
            if (datos != null)
            {
                switch (datos.Codigo)
                {
                    case 1:

                        switch (Partido.NJugadores)
                        {
                            case 1:
                                J1.Text = datos.Usuarios[0].Nombre;
                                break;

                            case 2:
                                stackJ2.IsVisible = true;
                                J2.Text = datos.Usuarios[1].Nombre;
                                goto case 1;

                            case 3:
                                stackJ3.IsVisible = true;
                                J3.Text = datos.Usuarios[2].Nombre;
                                goto case 2;

                            case 4:
                                stackJ4.IsVisible = true;
                                J4.Text = datos.Usuarios[3].Nombre;
                                goto case 3;
                        }
                        break;
                    case 101:
                        Console.WriteLine("101");
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 102:
                        Console.WriteLine("102");
                        info.TextColor = Color.IndianRed;
                        info.Text += datos.Mensaje.ToString();
                        break;
                    case 103:
                        Console.WriteLine("103");
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 104:
                        Console.WriteLine("104");
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 105:
                        Console.WriteLine("105");
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                }
            }
        }

        //Se pulsa el botón para añadirse al partido
        private async void OnAnadirClicked(object sender, EventArgs e)
        {
            RestService restService = new RestService();
            string Url = "http://47.62.12.161:54321/api_bsport/insert/agrega_jugador_partido.php";

            Datos datos = await restService.Post<Datos>(Url, new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("Id_partido", Partido.Id_Partido.ToString()),
                new KeyValuePair<string, string>("Id_usuario", Usuario.Id_usuario.ToString()) });
            if (datos != null)
            {
                switch (datos.Codigo)
                {
                    case 1:
                        info.TextColor = Color.Blue;
                        info.Text = datos.Mensaje.ToString();
                        await Navigation.PopAsync();
                        break;
                    case 101:
                        Console.WriteLine("101");
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 102:
                        Console.WriteLine("102");
                        info.TextColor = Color.IndianRed;
                        info.Text += datos.Mensaje.ToString();
                        break;
                    case 103:
                        Console.WriteLine("103");
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 104:
                        Console.WriteLine("104");
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 105:
                        Console.WriteLine("105");
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 111:
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                }
            }
        }

        //Botón de vuelta atrás
        private async void OnAtrasClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}