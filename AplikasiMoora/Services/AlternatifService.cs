using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Android.App;
using Android.Widget;
using AplikasiMoora.Models;
using Newtonsoft.Json;

namespace AplikasiMoora.Services
{
    public class AlternatifService
    {
        ApiService api = new ApiService();
        List<tb_alternatif> listAlternatif = new List<tb_alternatif>();
        HttpClient httpClient = new HttpClient();
        HttpResponseMessage response;
        tb_alternatif tba = new tb_alternatif();

        public List<tb_alternatif> ShowDataAlternatif()
        {
            listAlternatif = new List<tb_alternatif>();

            try
            {
                httpClient = new HttpClient();
                response = httpClient.GetAsync(api.GetAllAlternatif()).GetAwaiter().GetResult();
                string result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                listAlternatif = JsonConvert.DeserializeObject<List<tb_alternatif>>(result);

            }
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, ex.ToString(), ToastLength.Long).Show();
            }

            return listAlternatif;
        }

        public async void SaveAlternatif(tb_alternatif atr)
        {
            try
            {
                tba = new tb_alternatif();
                httpClient = new HttpClient();
                string url = api.SaveAlternatif();
                var uri = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(atr);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await httpClient.PostAsync(uri, content);
            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Save Alternatif Failed !", ToastLength.Short).Show();
            }
        }

        public async void UpdateAlternatif(tb_alternatif atr)
        {
            try
            {
                tba = new tb_alternatif();
                httpClient = new HttpClient();
                string url = api.UpdateAlternatif();
                var uri = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(atr);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await httpClient.PutAsync(uri, content);
            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Update Alternatif Failed !", ToastLength.Short).Show();
            }
        }

        public async void DeleteAlternatif(int Id)
        {
            try
            {
                HttpClient myClient = new HttpClient();
                string url = api.DeleteAlternatif(Id);
                var uri = new Uri(url);
                myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = await myClient.DeleteAsync(uri);

                Toast.MakeText(Application.Context, "Data Alternatif Deleted", ToastLength.Long).Show();

            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Delete Alternatif Failed !", ToastLength.Short).Show();
            }
        }
    }
}
