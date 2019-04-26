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
                //Para hacer pruebas en el servidor local desde el emulador necesitas poner esa dirección ip de lo contrario estás intentado acceder a la dirección del propio emulador. (O eso he entendido).
                //En cambio cuando quiero acceder desde el móvil necesito una dirección IP real o local.
                if (Device.RuntimePlatform == Device.Android)
                    Url = "http://10.0.2.2/api_bsport/select/login_user.php";
                else if (Device.RuntimePlatform == Device.iOS)
                    Url = "http://localhost/api_bsport/select/login_user.php";

                var postData = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("login", "lucas12"),
                    new KeyValuePair<string, string>("pass", "patata")
                };
                HttpClient client = new HttpClient();
                var response = await client.PostAsync(Url, new FormUrlEncodedContent(postData));
                var content = await response.Content.ReadAsStringAsync();

                Usuario user = JsonConvert.DeserializeObject<Usuario>(content);
                //string login = user.login;
                //name.Text = login;
                Console.WriteLine(content);
            }
            catch (System.Net.WebException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }

        }
        public async void OnRegistroClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}