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
    public partial class Registro : ContentPage
    {
        private string passValida;
        private string Url;
        private Datos datos;
        public Registro()
        {
            InitializeComponent();
            Url = "http://47.62.12.161:54321/api_bsport/insert/registro_usuario.php";
        }
        public async void OnRegistroClicked(object sender, EventArgs args)
        {
            RestService restService = new RestService();
            info.Text = "";
            try
            {
                if (pass.Text == repPass.Text)
                {
                    passValida = pass.Text;
                }
                else
                {
                    throw new FormatException();
                }
                var datosPost = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("Login", accNom.Text),
                    new KeyValuePair<string, string>("Pass", passValida),
                    new KeyValuePair<string, string>("Nombre", usuNom.Text),
                    new KeyValuePair<string, string>("Email", mail.Text)
                };
                datos = await restService.Post<Datos>(Url, datosPost);
            }
            catch (FormatException)
            {
                info.TextColor = Color.IndianRed;
                info.Text = "Las contraseñas deben coincidir.";
            }
            if (datos != null)
            {
                switch (datos.Codigo)
                {
                    case 1:
                        info.TextColor = Color.CadetBlue;
                        info.Text = datos.Mensaje.ToString();
                        await Navigation.PopAsync();
                        break;
                    case 101:
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 102:
                        info.TextColor = Color.IndianRed;
                        info.Text += datos.Mensaje.ToString();
                        break;
                    case 103:
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 104:
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;
                    case 105:
                        info.TextColor = Color.IndianRed;
                        info.Text = datos.Mensaje.ToString();
                        break;

                }
            }
        }
    }
}