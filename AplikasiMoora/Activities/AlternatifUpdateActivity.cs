
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
using AplikasiMoora.StaticDetails;

namespace AplikasiMoora.Activities
{
    [Activity(Label = "AlternatifUpdateActivity")]
    public class AlternatifUpdateActivity : AppCompatActivity
    {
        EditText edtId, edtNama, edtAlamat, edtKontak;
        Spinner spinJenis;
        tb_alternatif tba = new tb_alternatif();
        List<string> listKelamin = new List<string>();
        AlternatifService asr = new AlternatifService();
        ImageView imgUpdate, imgArrow;
        Button btnDelete;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AlternatifUpdate_Layout);

            edtId = FindViewById<EditText>(Resource.Id.edtId);
            edtNama = FindViewById<EditText>(Resource.Id.edtNama);
            edtAlamat = FindViewById<EditText>(Resource.Id.edtAlamat);
            edtKontak = FindViewById<EditText>(Resource.Id.edtKontak);
            spinJenis = FindViewById<Spinner>(Resource.Id.spinJenisKelamin);
            imgUpdate = FindViewById<ImageView>(Resource.Id.imgUpdate);
            btnDelete = FindViewById<Button>(Resource.Id.btnDelete);

            listKelamin.Add("PILIH");
            listKelamin.Add("Laki-Laki");
            listKelamin.Add("Perempuan");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(Application.Context, Android.Resource.Layout.SimpleSpinnerDropDownItem, listKelamin);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinJenis.Adapter = adapter;

            imgUpdate.Click += ImgUpdate_Click;
            btnDelete.Click += BtnDelete_Click;

            edtId.Text = StaticAlternatif.Id.ToString();
            edtNama.Text = StaticAlternatif.nama;
            edtAlamat.Text = StaticAlternatif.alamat;
            edtKontak.Text = StaticAlternatif.kontak;
            spinJenis.SelectedItem.Equals(StaticAlternatif.jenis_kelamin);

            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);
            imgArrow.Click += ImgArrow_Click;
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AlternatifActivity));
            StartActivity(intent);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                asr.DeleteAlternatif(StaticAlternatif.Id);

                Toast.MakeText(this, "Data Alternatif Berhasil di Hapus !!", ToastLength.Long).Show();

                Intent intent = new Intent(this, typeof(AlternatifActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                StartActivity(intent);

            }
            catch (Exception x)
            {
                Toast.MakeText(this, "Data Alternatif Gagal di Hapus !!"+x.ToString(), ToastLength.Long).Show();

                Intent intent = new Intent(this, typeof(AlternatifActivity));
                StartActivity(intent);
            }
        }

        private void ImgUpdate_Click(object sender, EventArgs e)
        {
            try
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
                        Id = StaticAlternatif.Id,
                        nama = edtNama.Text,
                        alamat = edtAlamat.Text,
                        jenis_kelamin = spinJenis.SelectedItem.ToString(),
                        kontak = edtKontak.Text
                    };

                    asr.UpdateAlternatif(tba);

                    Toast.MakeText(this, "Update Berhasil !!", ToastLength.Long).Show();

                    Intent intent = new Intent(this, typeof(AlternatifActivity));
                    intent.SetFlags(ActivityFlags.NewTask);
                    StartActivity(intent);
                }
            }catch(Exception x)
            {
                Toast.MakeText(this, "Update Alternatif "+x.ToString(), ToastLength.Short).Show();
            }
        }

        public override void OnBackPressed()
        {

        }
    }
}
