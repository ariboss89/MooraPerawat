using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Android.App;
using Android.Content;
using Android.Widget;
using AplikasiMoora.Models;
using Newtonsoft.Json;

namespace AplikasiMoora.Services
{
    public class HasilService
    {
        ApiService api = new ApiService();
        List<tb_hasil> listHasil = new List<tb_hasil>();
        HttpClient httpClient = new HttpClient();
        HttpResponseMessage response;
        tb_hasil tbh = new tb_hasil();
        List<tb_keputusan> listKeputusan = new List<tb_keputusan>();

        public List<tb_hasil> ShowDataHasil()
        {
            listHasil = new List<tb_hasil>();

            try
            {
                httpClient = new HttpClient();
                response = httpClient.GetAsync(api.GetAllHasil()).GetAwaiter().GetResult();
                string result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                listHasil = JsonConvert.DeserializeObject<List<tb_hasil>>(result);

            }
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, ex.ToString(), ToastLength.Long).Show();
            }

            return listHasil;
        }

        public List<tb_keputusan> ShowDataKeputusan()
        {
            listKeputusan = new List<tb_keputusan>();

            try
            {
                httpClient = new HttpClient();
                response = httpClient.GetAsync(api.GetAllKeputusan()).GetAwaiter().GetResult();
                string result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                listKeputusan = JsonConvert.DeserializeObject<List<tb_keputusan>>(result);

            }
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, ex.ToString(), ToastLength.Long).Show();
            }

            return listKeputusan;
        }

        public async void SaveHasil(tb_hasil hsl)
        {
            try
            {
                httpClient = new HttpClient();
                string url = api.SaveHasil();
                var uri = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(hsl);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await httpClient.PostAsync(uri, content);
            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Save Hasil Failed !", ToastLength.Short).Show();
            }
        }

        public async void SaveKeputusan(tb_keputusan kep)
        {
            try
            {
                httpClient = new HttpClient();
                string url = api.SaveKeputusan();
                var uri = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(kep);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await httpClient.PostAsync(uri, content);

                Toast.MakeText(Application.Context, "Keputusan Berhasil di Simpan", ToastLength.Long).Show();

            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Save Keputusan Failed !", ToastLength.Short).Show();
            }
        }

        public async void UpdateHasil(tb_hasil hsl)
        {
            try
            {
                httpClient = new HttpClient();
                string url = api.UpdateHasil();
                var uri = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(hsl);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await httpClient.PutAsync(uri, content);
            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Update Hasil Failed !", ToastLength.Short).Show();
            }
        }

        //public async void UpdateKet(tb_hasil hsl)
        //{
        //    try
        //    {
        //        httpClient = new HttpClient();
        //        string url = api.UpdateKet();
        //        var uri = new Uri(url);
        //        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        var json = JsonConvert.SerializeObject(hsl);
        //        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        //        response = await httpClient.PutAsync(uri, content);
        //    }
        //    catch (Exception)
        //    {
        //        Toast.MakeText(Application.Context, "Update Keterangan Failed !", ToastLength.Short).Show();
        //    }
        //}

        public async void Deletehasil(int Id)
        {
            try
            {
                HttpClient myClient = new HttpClient();
                string url = api.DeleteHasil(Id);
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
