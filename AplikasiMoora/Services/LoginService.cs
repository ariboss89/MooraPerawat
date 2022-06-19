using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Android.App;
using Android.Widget;
using AplikasiMoora.Models;
using Newtonsoft.Json;

namespace AplikasiMoora.Services
{
    public class LoginService
    {
        tb_login lgn = new tb_login();
        ApiService api = new ApiService();

        public async void SaveUsers(tb_login log)
        {
            try
            {
                HttpClient myClient = new HttpClient();
                string url = api.SaveUser();
                var uri = new Uri(url);
                myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;

                var json = JsonConvert.SerializeObject(log);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await myClient.PostAsync(uri, content);

                Toast.MakeText(Application.Context, "User Added", ToastLength.Long).Show();

            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Add User Failed !", ToastLength.Short).Show();
            }
        }
    }
}
