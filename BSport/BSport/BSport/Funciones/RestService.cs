using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BSport.Funciones
{
    class RestService
    {
        async public Task<T> Post<T>(string Url, List<KeyValuePair<string, string>> datosPost)
        {

            HttpClient client = new HttpClient();
            var respuesta = await client.PostAsync(Url, new FormUrlEncodedContent(datosPost));
            var contenido = await respuesta.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(contenido);
        }
        async public Task<T> Post<T>(string Url)
        {

            HttpClient client = new HttpClient();
            var respuesta = await client.PostAsync(Url, null);
            var contenido = await respuesta.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(contenido);
        }
        public RestService()
        {
            //https://stackoverflow.com/questions/51539792/how-to-congifure-visual-studio-2017-android-emulator-to-work-on-localhost
            //Para hacer pruebas en el servidor local desde el emulador necesitas poner esa dirección ip de lo contrario estás intentado acceder a la dirección del propio emulador. (O eso he entendido).
            //En cambio cuando quiero acceder desde el móvil necesito una dirección IP real o local.
            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    //Emulador Android
            //    //Url = "http://10.0.2.2/api_bsport/select/login_usuario.php";
            //    //Móvil Android
            //    Url = "http://192.168.0.11/api_bsport/select/login_usuario.php";
            //}
            //else if (Device.RuntimePlatform == Device.iOS)
            //    Url = "http://localhost/api_bsport/select/login_user.php";
        }
    }
}
