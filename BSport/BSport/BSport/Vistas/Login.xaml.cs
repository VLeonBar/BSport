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
        private readonly HttpClient client = new HttpClient();
        string Url = null;
        public Login()
        {
            InitializeComponent();
        }
        public async void OnEntrarClicked(object sender, EventArgs args)
        {
            try
            {

                //https://stackoverflow.com/questions/51539792/how-to-congifure-visual-studio-2017-android-emulator-to-work-on-localhost
                if (Device.RuntimePlatform == Device.Android)
                    Url = "http://10.0.2.2/api_bsport/select/login_user.php";
                else if (Device.RuntimePlatform == Device.iOS)
                    Url = "http://localhost/api_bsport/select/login_user.php";

                //Usuario u = new Usuario { Nombre = "lucas12", Contraseña = "patata" };
                var postData = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("login", "lucas12"),
                    new KeyValuePair<string, string>("pass", "patata")
                };
                //HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, Url);
                //req.Content = new FormUrlEncodedContent(postData);

                HttpClient client = new HttpClient();
                var response = await client.PostAsync(Url, new FormUrlEncodedContent(postData));

                var content = await response.Content.ReadAsStringAsync();
                name.Text = content;
            }
            catch (System.Net.WebException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }

            //await Navigation.PushAsync(new Menu());
        }
        public async void OnRegistroClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}