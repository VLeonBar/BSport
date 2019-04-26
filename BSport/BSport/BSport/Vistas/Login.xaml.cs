using BSport.Funciones;
using BSport.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BSport.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private RestService restService = new RestService();
        private string Url;
        public Login()
        {
            InitializeComponent();
            Url = "http://192.168.0.11/api_bsport/select/login_usuario.php";
        }
        public async void OnEntrarClicked(object sender, EventArgs args)
        {
            info.Text = "";
            var datosPost = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("Login", login.Text),
                    new KeyValuePair<string, string>("Pass", pass.Text)
                };

            Datos datos = await restService.Post<Datos>(Url, datosPost);

            switch (datos.Codigo)
            {
                case 1:
                    info.TextColor = Color.CadetBlue;
                    info.Text = "Credenciales correctas...";
                    Usuario usuario = datos.Usuario;
                    await Navigation.PushAsync(new Menu(usuario));
                    break;
                case 101:
                    info.TextColor = Color.IndianRed;
                    info.Text = datos.Mensaje;
                    break;
                case 102:
                    info.TextColor = Color.IndianRed;
                    info.Text = datos.Mensaje;
                    break;
                case 103:
                    info.TextColor = Color.IndianRed;
                    info.Text = datos.Mensaje;
                    break;

            }
        }
        public async void OnRegistroClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}