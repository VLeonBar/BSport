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
            try
            {
                HttpClient client = new HttpClient();
                var respuesta = await client.PostAsync(Url, new FormUrlEncodedContent(datosPost));
                if (respuesta.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var contenido = await respuesta.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(contenido);
                }
            }
            catch
            {

            }
            return default(T);
        }
        async public Task<T> Post<T>(string Url)
        {
            try
            {
                HttpClient client = new HttpClient();
                var respuesta = await client.PostAsync(Url, null);
                if (respuesta.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var contenido = await respuesta.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(contenido);
                }
            }
            catch
            {

            }
            return default(T);
        }
        public RestService()
        {
        }
    }
}
