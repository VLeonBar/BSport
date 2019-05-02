using BSport.Funciones;
using BSport.ModeloParaVista;
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
    public partial class PartidosPadel : ContentPage
    {
        Partido p;
        public Usuario Usuario { get; set; }
        public PartidosPadel(Usuario usuario)
        {
            InitializeComponent();
            // TODO
            // Este constructor inicializa su array interno, es ahí dónde debo pretender hacer la petición de datos al servidor y rellenar el array mediante la base de datos. (??????)
            Usuario = usuario;
            perfil.Text = "Perfil : " + Usuario.Nombre + Usuario.Id_usuario;

        }
        public void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            p = (Partido)e.SelectedItem;
        }
        async public void OnVerClicked(object sender, EventArgs e)
        {
            if (p != null)
            {
                //await Navigation.PushAsync(new PadelPartido(p));
            }

        }
        async public void OnCrearPartidoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearPartido(Usuario));
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            RestService restService = new RestService();
            string Url = "http://192.168.0.10/api_bsport/select/muestra_partidos.php";

            Datos datos = await restService.Post<Datos>(Url);
            if (datos != null)
            {
                switch (datos.Codigo)
                {
                    case 1:
                        List<Partido> partidos = datos.Partidos;
                        foreach (Partido partido in partidos)
                        {
                            partido.Imagen = "palapadel.png";
                            partido.MaxJugadores = 4;
                        }
                        listaPartidos.ItemsSource = datos.Partidos;
                        break;
                    case 101:
                        Console.WriteLine("101");
                        //info.TextColor = Color.IndianRed;
                        //info.Text = datos.Mensaje.ToString();
                        break;
                    case 102:
                        Console.WriteLine("102");
                        //info.TextColor = Color.IndianRed;
                        //info.Text += datos.Mensaje.ToString();
                        break;
                    case 103:
                        Console.WriteLine("103");
                        //info.TextColor = Color.IndianRed;
                        //info.Text = datos.Mensaje.ToString();
                        break;
                    case 104:
                        Console.WriteLine("104");
                        //info.TextColor = Color.IndianRed;
                        //info.Text = datos.Mensaje.ToString();
                        break;
                    case 105:
                        Console.WriteLine("105");
                        //info.TextColor = Color.IndianRed;
                        //info.Text = datos.Mensaje.ToString();
                        break;
                }
            }
        }
    }
}