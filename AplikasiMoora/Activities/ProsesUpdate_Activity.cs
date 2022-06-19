
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
    [Activity(Label = "ProsesUpdate_Activity")]
    public class ProsesUpdate_Activity : AppCompatActivity
    {
        EditText edtId,edtNama,edtKriteria, edtNilai;
        ImageView imgUpdate;
        HasilService hsr = new HasilService();
        tb_hasil tbh = new tb_hasil();
        AlternatifService asr = new AlternatifService();
        KriteriaService ksr = new KriteriaService();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ProsesUpdate_Layout);

            edtId = FindViewById<EditText>(Resource.Id.edtId);
            edtNama = FindViewById<EditText>(Resource.Id.edtNama);
            edtKriteria = FindViewById<EditText>(Resource.Id.edtKriteria);
            edtNilai = FindViewById<EditText>(Resource.Id.edtNilai);
            imgUpdate = FindViewById<ImageView>(Resource.Id.imgUpdate);

            imgUpdate.Click += ImgUpdate_Click;

            edtId.Text = StaticHasil.Id.ToString();
            edtNama.Text = StaticHasil.nama;
            edtKriteria.Text = StaticHasil.kriteria.ToString();
            edtNilai.Text = StaticHasil.nilai.ToString();

        }

        private void ImgUpdate_Click(object sender, EventArgs e)
        {
            if (edtNama.Text.Equals(""))
            {
                Toast.MakeText(this, "Silahkan Di Isi !!", ToastLength.Long).Show();
                edtNama.RequestFocus();

            }else if (edtKriteria.Text.Equals(""))
            {
                Toast.MakeText(this, "Silahkan Di Isi !!", ToastLength.Long).Show();
                edtKriteria.RequestFocus();

            }
            else if (edtNilai.Text.Equals(""))
            {
                Toast.MakeText(this, "Silahkan Di Isi !!", ToastLength.Long).Show();
                edtNilai.RequestFocus();

            }
            
            else
            {
                tbh = new tb_hasil()
                {
                    Id = StaticHasil.Id,
                    nama = edtNama.Text,
                    nilai = Convert.ToDouble(edtNilai.Text),
                    kriteria = edtKriteria.Text,
                };

                hsr.UpdateHasil(tbh);

                Toast.MakeText(this, "Data Keputusan Berhasil di Update !!", ToastLength.Long).Show();

                Intent intent = new Intent(this, typeof(AlternatifActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            }
        }
    }
}
