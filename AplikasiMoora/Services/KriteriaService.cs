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
    public class KriteriaService
    {
        ApiService api = new ApiService();
        List<tb_kriteria> listKriteria = new List<tb_kriteria>();
        HttpClient httpClient = new HttpClient();
        HttpResponseMessage response;
        tb_kriteria tbk = new tb_kriteria();

        public List<tb_kriteria> ShowDataKriteria()
        {
            listKriteria = new List<tb_kriteria>();

            try
            {
                httpClient = new HttpClient();
                response = httpClient.GetAsync(api.GetAllKriteria()).GetAwaiter().GetResult();
                string result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                listKriteria = JsonConvert.DeserializeObject<List<tb_kriteria>>(result);

            }
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, ex.ToString(), ToastLength.Long).Show();
            }

            return listKriteria;
        }

        public async void SaveKriteria(tb_kriteria ktr)
        {
            try
            {
                tbk = new tb_kriteria();
                httpClient = new HttpClient();
                string url = api.SaveKriteria();
                var uri = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(ktr);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await httpClient.PostAsync(uri, content);
            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Save Kriteria Failed !", ToastLength.Short).Show();
            }
        }

        public async void UpdateKriteria(tb_kriteria ktr)
        {
            try
            {
                httpClient = new HttpClient();
                string url = api.UpdateKriteria();
                var uri = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(ktr);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await httpClient.PutAsync(uri, content);

            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Update Kriteria Failed !", ToastLength.Short).Show();
            }
        }

        public async void DeleteKriteria(int Id)
        {
            try
            {
                HttpClient myClient = new HttpClient();
                string url = api.DeleteKriteria(Id);
                var uri = new Uri(url);
                myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = await myClient.DeleteAsync(uri);

                Toast.MakeText(Application.Context, "Data Kriteria Deleted", ToastLength.Long).Show();

            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Delete Failed !", ToastLength.Short).Show();
            }
        }

    }
}
