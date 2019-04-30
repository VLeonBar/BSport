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
    public partial class CrearPartido : ContentPage
    {
        public Usuario Usuario { get; set; }
        private string Url;
        public CrearPartido(Usuario usuario)
        {
            InitializeComponent();
            stackStepper.BindingContext = stepperJugadores;
            Usuario = usuario;
        }

        private void StepperJugadores_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            /*En el caso de dejar a empresas crear partidos vacíos para que la gente se una, se dejaría crear un partido vacío, 
            por el momento sólo se podrán crear partidos con 1 jugador mínimo.*/

            switch (e.NewValue)
            {
                case 1:
                    stackJ2.IsVisible = true;
                    stackJ3.IsVisible = true;
                    break;

                case 2:
                    stackJ2.IsVisible = true;
                    stackJ3.IsVisible = false;
                    break;

                case 3:
                    stackJ2.IsVisible = false;
                    stackJ3.IsVisible = false;
                    break;

                    //case 4:
                    //    stackJ1.IsVisible = false;
                    //    stackJ2.IsVisible = false;
                    //    stackJ3.IsVisible = false;
                    //    break;
            }
        }
        private async void OnCancelarClicked(object sender, EventArgs e)
        {

        }
        private async void OnCrearClicked(object sender, EventArgs e)
        {
            try
            {

                Url = "http://10.0.2.2/api_bsport/insert/crea_partido.php";
                var datosPost = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("Id_usuario", Usuario.Id_usuario),
                    new KeyValuePair<string, string>("Lugar", Lugar.Text),
                    new KeyValuePair<string, string>("Fecha", Fecha.Date.ToString()),
                    new KeyValuePair<string, string>("HoraI", HoraI.Time.ToString()),
                    new KeyValuePair<string, string>("HoraF", HoraF.Time.ToString()),
                    new KeyValuePair<string, string>("Nivel", NivelPicker.SelectedItem.ToString()),
                    new KeyValuePair<string, string>("Pista", Pista.Text),
                    new KeyValuePair<string, string>("Precio", Precio.Text)
                };
                Console.WriteLine(HoraI.ToString());
                Console.WriteLine(Fecha.ToString());
                RestService restService = new RestService();
                Datos datos = await restService.Post<Datos>(Url, datosPost);
                if (datos != null)
                {
                    switch (datos.Codigo)
                    {
                        case 1:
                            await Navigation.PushAsync(new PartidosPadel(Usuario));
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
            catch (Newtonsoft.Json.JsonReaderException ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
                throw;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
                throw;
            }
        }
    }
}