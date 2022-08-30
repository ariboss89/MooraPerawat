
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
using AplikasiMoora.Models;
using AplikasiMoora.Services;
using Newtonsoft.Json;

namespace AplikasiMoora.Activities
{
    [Activity(Label = "ProsesAdd_Activity")]
    public class ProsesAdd_Activity : AppCompatActivity
    {
        //EditText edtNilai;
        Spinner spinKriteria, spinNama, spinNilai;
        ImageView imgSave, imgArrow;
        HasilService hsr = new HasilService();
        tb_hasil tbh = new tb_hasil();
        AlternatifService asr = new AlternatifService();
        KriteriaService ksr = new KriteriaService();
        List<tb_kriteria> listKriteria = new List<tb_kriteria>();
        List<tb_alternatif> listAlternatif = new List<tb_alternatif>();
        List<string> listKrit = new List<string>();
        List<string> listAlt = new List<string>();
        ApiService api = new ApiService();
        List<string> listNilai = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ProsesAdd_Layout);

            //edtNilai = FindViewById<EditText>(Resource.Id.edtNilai);
            spinKriteria = FindViewById<Spinner>(Resource.Id.spinKriteria);
            spinNama = FindViewById<Spinner>(Resource.Id.spinNama);
            imgSave = FindViewById<ImageView>(Resource.Id.imgSave);
            spinNilai = FindViewById<Spinner>(Resource.Id.spinNilai);

            string arrNilai = "PILIH,1,2,3,4,5,6,7,8,9,10";

            var aa = arrNilai.Split(",");

            foreach (var a in aa)
            {
                listNilai.Add(a);
            }

            ArrayAdapter<string> adapterNilai = new ArrayAdapter<string>(Application.Context, Android.Resource.Layout.SimpleSpinnerDropDownItem, listNilai);
            adapterNilai.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinNilai.Adapter = adapterNilai;

            imgSave.Click += ImgSave_Click;

            listKriteria = new List<tb_kriteria>();
            listKriteria = ksr.ShowDataKriteria();

            listAlternatif = new List<tb_alternatif>();
            listAlternatif = asr.ShowDataAlternatif();

            listAlt.Add("PILIH");
            listKrit.Add("PILIH");

            foreach(var item in listKriteria)
            {
                listKrit.Add(item.nama);
            }

            foreach(var item in listAlternatif)
            {
                listAlt.Add(item.nama);
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(Application.Context, Android.Resource.Layout.SimpleSpinnerDropDownItem, listKrit);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinKriteria.Adapter = adapter;

            ArrayAdapter<string> adapterAlt = new ArrayAdapter<string>(Application.Context, Android.Resource.Layout.SimpleSpinnerDropDownItem, listAlt);
            adapterAlt.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinNama.Adapter = adapterAlt;

            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);
            imgArrow.Click += ImgArrow_Click;
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProsesActivity));
            StartActivity(intent);
        }

        public override void OnBackPressed()
        {

        }

        private void ImgSave_Click(object sender, EventArgs e)
        {
            if (spinNama.SelectedItem.ToString().Equals("PILIH"))
            {
                Toast.MakeText(this, "Silahkan Pilih Alternatif !!", ToastLength.Long).Show();
                spinNama.RequestFocus();

            }
            else if (spinNilai.SelectedItem.ToString().Equals("PILIH"))
            {
                Toast.MakeText(this, "Silahkan Pilih Nilai !!", ToastLength.Long).Show();
                spinNilai.RequestFocus();

            }
            else if (spinKriteria.SelectedItem.ToString().Equals("PILIH"))
            {
                Toast.MakeText(this, "Silahkan Pilih Jenis Kelamin !!", ToastLength.Long).Show();
                spinKriteria.RequestFocus();

            }
            else
            {
                CheckAlternatif(spinNama.SelectedItem.ToString(), spinKriteria.SelectedItem.ToString());
            }
        }

        public async void CheckAlternatif(string nama, string kriteria)
        {
            string message = "";
            try
            {
                HttpClient myClient = new HttpClient();
                string url = api.CheckAlternatif(nama, kriteria);
                var uri = new Uri(url);
                myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;

                var json = JsonConvert.SerializeObject(tbh);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await myClient.PostAsync(uri, content);

                var mesg = response.Content.ReadAsStringAsync();

                var msge = mesg.Result.ToString();

                if (!msge.Contains("doesnt"))
                {
                    message = "Data Exist";

                    Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
                }

                if (message != ("Data Exist"))
                {
                    message = "";

                    try
                    {
                        tbh = new tb_hasil()
                        {
                            nama = spinNama.SelectedItem.ToString(),
                            nilai = Convert.ToDouble(spinNilai.SelectedItem.ToString()),
                            kriteria = spinKriteria.SelectedItem.ToString(),
                        };

                        hsr.SaveHasil(tbh);

                        Toast.MakeText(this, "Data Keputusan Berhasil diTambahkan !!", ToastLength.Long).Show();

                        Intent intent = new Intent(this, typeof(ProsesActivity));
                        intent.SetFlags(ActivityFlags.NewTask);
                        StartActivity(intent);

                    }
                    catch (Exception x)
                    {
                        Toast.MakeText(Application.Context, x.ToString(), ToastLength.Short).Show();
                    }

                }
                else
                {
                    Toast.MakeText(Application.Context, "Data Exist, Please Change", ToastLength.Short).Show();
                    
                }


            }
            catch (Exception x)
            {
                Toast.MakeText(Application.Context, x.ToString(), ToastLength.Short).Show();
            }
        }
    }
}
