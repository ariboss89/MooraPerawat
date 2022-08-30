
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
        EditText edtId,edtNama,edtKriteria;
        Spinner spinNilai;
        ImageView imgUpdate, imgArrow;
        HasilService hsr = new HasilService();
        tb_hasil tbh = new tb_hasil();
        AlternatifService asr = new AlternatifService();
        KriteriaService ksr = new KriteriaService();
        Button btnDelete;
        List<string> listNilai = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ProsesUpdate_Layout);

            edtId = FindViewById<EditText>(Resource.Id.edtId);
            edtNama = FindViewById<EditText>(Resource.Id.edtNama);
            edtKriteria = FindViewById<EditText>(Resource.Id.edtKriteria);
            //edtNilai = FindViewById<EditText>(Resource.Id.edtNilai);
            imgUpdate = FindViewById<ImageView>(Resource.Id.imgUpdate);
            btnDelete = FindViewById<Button>(Resource.Id.btnDelete);

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


            imgUpdate.Click += ImgUpdate_Click;

            edtId.Text = StaticHasil.Id.ToString();
            edtNama.Text = StaticHasil.nama;
            edtKriteria.Text = StaticHasil.kriteria.ToString();
            spinNilai.SelectedItem.ToString().Equals(StaticHasil.nilai.ToString());

            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);
            imgArrow.Click += ImgArrow_Click;
            btnDelete.Click += BtnDelete_Click;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                hsr.Deletehasil(StaticHasil.Id);

                Toast.MakeText(this, "Data Berhasil di Hapus !!", ToastLength.Long).Show();

                Intent intent = new Intent(this, typeof(ProsesActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                StartActivity(intent);

            }
            catch (Exception x)
            {
                Toast.MakeText(this, "Data Alternatif Gagal di Hapus !!" + x.ToString(), ToastLength.Long).Show();

                Intent intent = new Intent(this, typeof(AlternatifActivity));
                StartActivity(intent);
            }
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProsesActivity));
            StartActivity(intent);
        }

        public override void OnBackPressed()
        {

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
            else if (spinNilai.SelectedItem.ToString().Equals("PILIH"))
            {
                Toast.MakeText(this, "Silahkan Pilih Nilai !!", ToastLength.Long).Show();
                spinNilai.RequestFocus();

            }
            
            else
            {
                tbh = new tb_hasil()
                {
                    Id = StaticHasil.Id,
                    nama = edtNama.Text,
                    nilai = Convert.ToDouble(spinNilai.SelectedItem.ToString()),
                    kriteria = edtKriteria.Text,
                };

                hsr.UpdateHasil(tbh);

                Toast.MakeText(this, "Data Keputusan Berhasil di Update !!", ToastLength.Long).Show();

                Intent intent = new Intent(this, typeof(ProsesActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            }
        }
    }
}
