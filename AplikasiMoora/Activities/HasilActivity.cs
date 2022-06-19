
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AplikasiMoora.Adapter;
using AplikasiMoora.Models;
using AplikasiMoora.Services;
using AplikasiMoora.StaticDetails;
using Newtonsoft.Json;

namespace AplikasiMoora.Activities
{
    [Activity(Label = "HasilActivity")]
    public class HasilActivity : AppCompatActivity
    {
        ListView lvPerankingan;
        Button btnSimpan;
        PerankinganAdapter perankinganAdapter;
        List<tb_keputusan> listKeputusan = new List<tb_keputusan>();
        FormulaService fsr = new FormulaService();
        ApiService api = new ApiService();
        HasilService hsh = new HasilService();
        ConfigService csh = new ConfigService();
        tb_config tbc = new tb_config();
        tb_keputusan tbk = new tb_keputusan();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Hasil_Layout);

            lvPerankingan = FindViewById<ListView>(Resource.Id.lvPerankingan);
            btnSimpan = FindViewById<Button>(Resource.Id.btnSimpan);

            btnSimpan.Click += BtnSimpan_Click;

            TampilPerankingan();
            IdKeputusan();
        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            listKeputusan = fsr.HasilKeterangan();

            foreach (var item in listKeputusan)
            {
                tbk = new tb_keputusan()
                {
                    idkeputusan = StaticKeputusan.idkeputusan,
                    nama = item.nama,
                    hasil_akhir = item.hasil_akhir,
                    ket = item.ket,
                    tanggal = item.tanggal

                };

                try
                {
                    hsh.SaveKeputusan(tbk);
                    
                    Intent intent = new Intent(Application.Context, typeof(MainActivity));
                    StartActivity(intent);

                }
                catch(Exception)
                {
                    Toast.MakeText(this, "Data Keputusan Gagal diTambahkan", ToastLength.Long).Show();
                }
            }

            string idPenjualan = StaticKeputusan.idkeputusan;

            var subIdPenjualan = idPenjualan.Substring(12);

            int id = Convert.ToInt32(subIdPenjualan);

            tbc = new tb_config()
            {
                config_key = "keputusan",
                config_value = id
            };

            csh.UpdateConfigValue(tbc);

        }

        private async void IdKeputusan()
        {
            string id = "";
            try
            {
                HttpClient myClient = new HttpClient();
                string url = api.IdKeputusan();
                var uri = new Uri(url);
                myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;

                var json = JsonConvert.SerializeObject(tbc);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await myClient.PostAsync(uri, content);

                var mesg = response.Content.ReadAsStringAsync();

                var msge = mesg.Result.ToString();

                var idPenjualan = JsonConvert.DeserializeObject(msge);

                StaticKeputusan.idkeputusan = idPenjualan.ToString();

            }
            catch (Exception x)
            {
                Toast.MakeText(Application.Context, x.ToString(), ToastLength.Short).Show();
            }
        }

        void TampilPerankingan()
        {
            listKeputusan = fsr.HasilKeterangan();
            perankinganAdapter = new PerankinganAdapter(this, listKeputusan);
            lvPerankingan.Adapter = perankinganAdapter;
        }
    }
}
