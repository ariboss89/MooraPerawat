
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
    [Activity(Label = "AlternatifActivity")]
    public class AlternatifActivity : AppCompatActivity
    {
        ListView lvAlternatif;
        EditText edtSearch;
        AlternatifService asr = new AlternatifService();
        List<tb_alternatif> listAlternatif = new List<tb_alternatif>();
        AlternatifAdapter altAdapter;
        ImageView imgAdd, imgArrow;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Alternatif_Layout);

            // Create your application here

            lvAlternatif = FindViewById<ListView>(Resource.Id.lvAlternatif);
            edtSearch = FindViewById<EditText>(Resource.Id.edtSearch);
            imgAdd = FindViewById<ImageView>(Resource.Id.imgAdd);
            

            edtSearch.TextChanged += EdtSearch_TextChanged;

            lvAlternatif.ItemClick += LvAlternatif_ItemClick;

            imgAdd.Click += ImgAdd_Click;
            
            listAlternatif = new List<tb_alternatif>();
            listAlternatif = asr.ShowDataAlternatif();

            Tampil();

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
            Intent intent = new Intent(this, typeof(AlternatifAddActivity));
            StartActivity(intent);
        }

        private void LvAlternatif_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var data = altAdapter[e.Position];
            StaticAlternatif.Id = data.Id;
            StaticAlternatif.nama = data.nama;
            StaticAlternatif.kontak = data.kontak;
            StaticAlternatif.alamat = data.alamat;
            StaticAlternatif.jenis_kelamin = data.jenis_kelamin;

            Intent intent = new Intent(this, typeof(AlternatifUpdateActivity));
            StartActivity(intent);
        }

        private void EdtSearch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            var data = listAlternatif.Where(x => x.nama.Contains(edtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            altAdapter = new AlternatifAdapter(this, data);
            lvAlternatif.Adapter = altAdapter;
        }

        void Tampil()
        {
            altAdapter = new AlternatifAdapter(this, listAlternatif);
            lvAlternatif.Adapter = altAdapter;
        }

        public override void OnBackPressed()
        {
        }
    }
}
