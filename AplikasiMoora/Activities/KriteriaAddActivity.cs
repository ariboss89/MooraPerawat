
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
    [Activity(Label = "KriteriaAddActivity")]
    public class KriteriaAddActivity : AppCompatActivity
    {
        EditText edtNama, edtNilai;
        ImageView imgSave;
        KriteriaService ksr = new KriteriaService();
        tb_kriteria tbk = new tb_kriteria();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.KriteriaAdd_Layout);

            edtNama = FindViewById<EditText>(Resource.Id.edtNama);
            edtNilai = FindViewById<EditText>(Resource.Id.edtNilai);
            imgSave = FindViewById<ImageView>(Resource.Id.imgSave);

            imgSave.Click += ImgSave_Click; ;
        }

        private void ImgSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (edtNama.Text.Equals(""))
                {
                    Toast.MakeText(this, "Silahkan Di Isi !!", ToastLength.Long).Show();
                    edtNama.RequestFocus();

                }
                else if (edtNilai.Text.Equals(""))
                {
                    Toast.MakeText(this, "Silahkan Di Isi !!", ToastLength.Long).Show();
                    edtNilai.RequestFocus();

                }
                else
                {
                    tbk = new tb_kriteria()
                    {
                        nama = edtNama.Text,
                        bobot = Convert.ToDouble(edtNilai.Text)
                    };

                    ksr.SaveKriteria(tbk);

                    Toast.MakeText(this, "Kriteria Berhasil di Tambahkan !!", ToastLength.Long).Show();

                    Intent intent = new Intent(this, typeof(KriteriaActivity));
                    intent.SetFlags(ActivityFlags.NewTask);
                    StartActivity(intent);
                }
            }
            catch (Exception x)
            {
                Toast.MakeText(this, "Kriteria Gagal di Tambahkan" + x.ToString(), ToastLength.Short).Show();
            }
        }

    }
}
