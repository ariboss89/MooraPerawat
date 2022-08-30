
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
using AplikasiMoora.StaticDetails;

namespace AplikasiMoora.Activities
{
    [Activity(Label = "ProsesActivity")]
    public class ProsesActivity : AppCompatActivity
    {
        ListView lvSpk;
        Button btnSpk;
        EditText edtSearch;
        ImageView imgAdd, imgArrow;
        SpkAdapter spkAdapter;
        List<tb_hasil> listHasil = new List<tb_hasil>();
        tb_hasil tbh = new tb_hasil();
        HasilService hsr = new HasilService();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Proses_Layout);

            lvSpk = FindViewById<ListView>(Resource.Id.lvSpk);
            btnSpk = FindViewById<Button>(Resource.Id.btnSpk);
            edtSearch = FindViewById<EditText>(Resource.Id.edtSearch);
            imgAdd = FindViewById<ImageView>(Resource.Id.imgAdd);

            listHasil = new List<tb_hasil>();
            listHasil = hsr.ShowDataHasil();

            btnSpk.Click += BtnSpk_Click;
            imgAdd.Click += ImgAdd_Click;

            TampilHasil();

            lvSpk.ItemClick += LvSpk_ItemClick;

            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);
            imgArrow.Click += ImgArrow_Click;

            edtSearch.TextChanged += EdtSearch_TextChanged;
        }

        private void EdtSearch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            var data = listHasil.Where(x => x.nama.Contains(edtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            spkAdapter= new SpkAdapter(this, data);
            lvSpk.Adapter = spkAdapter;
        }

        public override void OnBackPressed()
        {

        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }

        private void ImgAdd_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProsesAdd_Activity));
            StartActivity(intent);
        }

        private void LvSpk_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var data = spkAdapter[e.Position];

            StaticHasil.Id = data.Id;
            StaticHasil.nama = data.nama;
            StaticHasil.kriteria = data.kriteria;
            StaticHasil.nilai = data.nilai;

            Intent intent = new Intent(this, typeof(ProsesUpdate_Activity));
            StartActivity(intent);
        }

        private void BtnSpk_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SpkActivity));
            StartActivity(intent);
        }

        void TampilHasil()
        {
            spkAdapter = new SpkAdapter(this, listHasil);
            lvSpk.Adapter = spkAdapter;
        }
    }
}
