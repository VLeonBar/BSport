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
        }
    }
}
