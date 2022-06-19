using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Android.App;
using Android.Widget;
using AplikasiMoora.Models;
using Newtonsoft.Json;

namespace AplikasiMoora.Services
{
    public class ConfigService
    {
        ApiService api = new ApiService();
        HttpClient httpClient = new HttpClient();
        HttpResponseMessage response;
        tb_config tbc = new tb_config();

        public async void UpdateConfigValue(tb_config con)
        {
            try
            {
                httpClient = new HttpClient();
                string url = api.UpdateConfigValue();
                var uri = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(con);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await httpClient.PostAsync(uri, content);
            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Update Id Keputusan Failed !", ToastLength.Short).Show();
            }
        }

    }
}
