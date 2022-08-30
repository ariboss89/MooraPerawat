
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
    [Activity(Label = "KriteriaActivity")]
    public class KriteriaActivity : AppCompatActivity
    {
        ListView lvKriteria;
        EditText edtSearch;
        KriteriaService ksr = new KriteriaService();
        List<tb_kriteria> listKriteria = new List<tb_kriteria>();
        KriteriaAdapter krtAdapter;
        ImageView imgAdd, imgArrow;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Kriteria_Layout);

            lvKriteria = FindViewById<ListView>(Resource.Id.lvKriteria);
            edtSearch = FindViewById<EditText>(Resource.Id.edtSearch);
            imgAdd = FindViewById<ImageView>(Resource.Id.imgAdd);

            listKriteria = new List<tb_kriteria>();
            listKriteria = ksr.ShowDataKriteria();

            Tampil();

            edtSearch.TextChanged += EdtSearch_TextChanged;
            lvKriteria.ItemClick += LvKriteria_ItemClick;
            imgAdd.Click += ImgAdd_Click;

            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);
            imgArrow.Click += ImgArrow_Click;
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }

        private void ImgAdd_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(KriteriaAddActivity));
            StartActivity(intent);
        }

        private void LvKriteria_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var data = krtAdapter[e.Position];
            StaticKriteria.Id = data.Id;
            StaticKriteria.nama = data.nama;
            StaticKriteria.bobot = data.bobot;

            Intent intent = new Intent(this, typeof(KriteriaUpdateActivity));
            StartActivity(intent);
        }

        private void EdtSearch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            var data = listKriteria.Where(x => x.nama.Contains(edtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            krtAdapter = new KriteriaAdapter(this, data);
            lvKriteria.Adapter = krtAdapter;
        }

        void Tampil()
        {
            krtAdapter = new KriteriaAdapter(this, listKriteria);
            lvKriteria.Adapter = krtAdapter;
        }

        public override void OnBackPressed()
        {

        }
    }
}
