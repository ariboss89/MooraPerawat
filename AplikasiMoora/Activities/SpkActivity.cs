
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
using AplikasiMoora.Adapter;
using AplikasiMoora.Models;
using AplikasiMoora.Services;

namespace AplikasiMoora.Activities
{
    [Activity(Label = "SpkActivity", MainLauncher =true)]
    public class SpkActivity : AppCompatActivity
    {
        ListView lvNormalisasi, lvOptimasi;
        Button btnHasil;
        SpkAdapter spkAdapter;
        NormalisasiAdapter normalisasiAdapter;
        OptimasiAdapter optimasiAdapter;

        List<tb_hasil> listHasil = new List<tb_hasil>();
        List<normalisasi> listNormalisasi = new List<normalisasi>();
        List<optimasi> listOptimasi = new List<optimasi>();
        FormulaService fsr = new FormulaService();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SPK_Layout);
            lvNormalisasi = FindViewById<ListView>(Resource.Id.lvNormalisasi);
            lvOptimasi = FindViewById<ListView>(Resource.Id.lvOptimasi);
            
            btnHasil = FindViewById<Button>(Resource.Id.btnHasil);

            btnHasil.Click += BtnHasil_Click;

            TampilNormalisasi();
            TampilOptimasi();
        }

        private void BtnHasil_Click(object sender, EventArgs e)
        {
            btnHasil.Enabled = false;

            Intent intent = new Intent(this, typeof(HasilActivity));
            StartActivity(intent);
        }

        void TampilNormalisasi()
        {
            listNormalisasi = fsr.HitungNormalisasi();
            normalisasiAdapter = new NormalisasiAdapter(this, listNormalisasi);
            lvNormalisasi.Adapter = normalisasiAdapter;
        }

        void TampilOptimasi()
        {
            listOptimasi = fsr.HitungOptimasi();
            optimasiAdapter = new OptimasiAdapter(this, listOptimasi);
            lvOptimasi.Adapter = optimasiAdapter;
        }

       
    }
}
