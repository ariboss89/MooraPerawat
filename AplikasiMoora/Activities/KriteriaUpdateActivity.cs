
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
    [Activity(Label = "KriteriaUpdateActivity")]
    public class KriteriaUpdateActivity : AppCompatActivity
    {
        EditText edtId, edtNama, edtNilai;
        ImageView imgUpdate, imgArrow;
        Button btnDelete;
        KriteriaService ksr = new KriteriaService();
        tb_kriteria tbk = new tb_kriteria();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.KriteriaUpdate_Layout);

            edtId = FindViewById<EditText>(Resource.Id.edtId);
            edtNama = FindViewById<EditText>(Resource.Id.edtNama);
            edtNilai = FindViewById<EditText>(Resource.Id.edtNilai);
            imgUpdate = FindViewById<ImageView>(Resource.Id.imgUpdate);
            btnDelete = FindViewById<Button>(Resource.Id.btnDelete);

            edtId.Text = StaticKriteria.Id.ToString();
            edtNama.Text = StaticKriteria.nama;
            edtNilai.Text = StaticKriteria.bobot.ToString();

            imgUpdate.Click += ImgUpdate_Click;
            btnDelete.Click += BtnDelete_Click;

            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);
            imgArrow.Click += ImgArrow_Click;
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(KriteriaActivity));
            StartActivity(intent);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ksr.DeleteKriteria(StaticKriteria.Id);

                Intent intent = new Intent(this, typeof(KriteriaActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                StartActivity(intent);

            }
            catch (Exception x)
            {
                Toast.MakeText(this, "Data Kriteria Gagal di Hapus !!" + x.ToString(), ToastLength.Long).Show();

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
                else if (edtNilai.Text.Equals(""))
                {
                    Toast.MakeText(this, "Silahkan Di Isi !!", ToastLength.Long).Show();
                    edtNilai.RequestFocus();

                }
                else
                {
                    tbk = new tb_kriteria()
                    {
                        Id = StaticKriteria.Id,
                        nama = edtNama.Text,
                        bobot = Convert.ToDouble(edtNilai.Text)
                    };

                    ksr.UpdateKriteria(tbk);

                    Toast.MakeText(this, "Update Kriteria Berhasil !!", ToastLength.Long).Show();

                    Intent intent = new Intent(this, typeof(KriteriaActivity));
                    intent.SetFlags(ActivityFlags.NewTask);
                    StartActivity(intent);
                }
            }
            catch (Exception x)
            {
                Toast.MakeText(this, "Update Kriteria Gagal " + x.ToString(), ToastLength.Short).Show();
            }
        }

        public override void OnBackPressed()
        {

        }
    }
}
