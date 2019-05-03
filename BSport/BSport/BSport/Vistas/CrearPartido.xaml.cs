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
            Fecha.Date = DateTime.Today;
            HoraI.Time = new TimeSpan(0, 0, 0);
            HoraF.Time = new TimeSpan(0, 0, 0);
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
            await Navigation.PushAsync(new PartidosPadel(Usuario));
        }
        private bool validacadenas(List<string> campos)
        {
            foreach (string campo in campos)
            {
                if (campo.Trim() == "" || campo == null)
                {
                    return false;
                }
            }
            return true;
        }
        private async void OnCrearClicked(object sender, EventArgs e)
        {
            string fecha = String.Format("{0:yyyy/MM/dd}", Fecha.Date);
            RestService restService = new RestService();
            try
            {
                List<KeyValuePair<string, string>> datosPost = null;
                Url = "http://47.62.204.243:54321/api_bsport/insert/crea_partido.php";

                //Comprueba que los campos enviados no sean null ni estén vacíos
                if (validacadenas(new List<string>() { Lugar.Text, fecha, HoraI.Time.ToString(), HoraF.Time.ToString(), NivelPicker.SelectedItem.ToString(), Pista.Text, Precio.Text }))
                {
                    datosPost = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>("Id_usuario", Usuario.Id_usuario),
                        new KeyValuePair<string, string>("Lugar", Lugar.Text),
                        new KeyValuePair<string, string>("Fecha", fecha),
                        new KeyValuePair<string, string>("HoraI", HoraI.Time.ToString()),
                        new KeyValuePair<string, string>("HoraF", HoraF.Time.ToString()),
                        new KeyValuePair<string, string>("Nivel", NivelPicker.SelectedItem.ToString()),
                        new KeyValuePair<string, string>("Pista", Pista.Text),
                        new KeyValuePair<string, string>("Precio", Precio.Text)
                    };
                }
                else
                {
                    throw new FormatException();
                }
                if (datosPost != null)
                {
                    Datos datos = await restService.Post<Datos>(Url, datosPost);
                    if (datos != null)
                    {
                        switch (datos.Codigo)
                        {
                            case 1:
                                await Navigation.PopAsync();
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
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
        }
    }
}