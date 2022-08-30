
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace AplikasiMoora.Activities
{
    [Activity(Label = "AlternatifAddActivity")]
    public class AlternatifAddActivity : AppCompatActivity
    {
        EditText edtNama, edtAlamat, edtKontak;
        Spinner spinJenis;
        tb_alternatif tba = new tb_alternatif();
        List<string> listKelamin = new List<string>();
        AlternatifService asr = new AlternatifService();
        ImageView imgSave, imgArrow;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AlternatifAdd_Layout);
            edtNama = FindViewById<EditText>(Resource.Id.edtNama);
            edtAlamat = FindViewById<EditText>(Resource.Id.edtAlamat);
            edtKontak = FindViewById<EditText>(Resource.Id.edtKontak);
            spinJenis = FindViewById<Spinner>(Resource.Id.spinJenisKelamin);
            imgSave = FindViewById<ImageView>(Resource.Id.imgSave);

            listKelamin.Add("PILIH");
            listKelamin.Add("Laki-Laki");
            listKelamin.Add("Perempuan");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(Application.Context, Android.Resource.Layout.SimpleSpinnerDropDownItem, listKelamin);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinJenis.Adapter = adapter;

            imgSave.Click += ImgSave_Click;

            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);
            imgArrow.Click += ImgArrow_Click;
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AlternatifActivity));
            StartActivity(intent);
        }

        private void ImgSave_Click(object sender, EventArgs e)
        {
            if (edtNama.Text.Equals(""))
            {
                Toast.MakeText(this, "Silahkan Di Isi !!", ToastLength.Long).Show();
                edtNama.RequestFocus();

            }
            else if (edtAlamat.Text.Equals(""))
            {
                Toast.MakeText(this, "Silahkan Di Isi !!", ToastLength.Long).Show();
                edtAlamat.RequestFocus();

            }
            else if (edtKontak.Text.Equals(""))
            {
                Toast.MakeText(this, "Silahkan Di Isi !!", ToastLength.Long).Show();
                edtKontak.RequestFocus();

            }
            else if (spinJenis.SelectedItem.ToString().Equals("PILIH"))
            {
                Toast.MakeText(this, "Silahkan Pilih Jenis Kelamin !!", ToastLength.Long).Show();
                spinJenis.RequestFocus();

            }
            else
            {
                tba = new tb_alternatif()
                {
                    nama = edtNama.Text,
                    alamat = edtAlamat.Text,
                    jenis_kelamin = spinJenis.SelectedItem.ToString(),
                    kontak = edtKontak.Text
                };

                asr.SaveAlternatif(tba);

                Toast.MakeText(this, "Data Berhasil diTambahkan !!", ToastLength.Long).Show();

                Intent intent = new Intent(this, typeof(AlternatifActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            }
        }

        public override void OnBackPressed()
        {

        }
    }
}
