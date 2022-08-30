
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
    [Activity(Label = "HistoryActivity")]
    public class HistoryActivity : AppCompatActivity
    {
        Spinner spinId;
        ListView lvHistory;
        ImageView imgArrow;
        List<tb_keputusan> listKeputusan = new List<tb_keputusan>();
        tb_keputusan tbk = new tb_keputusan();
        HasilService hsh = new HasilService();
        List<string> listId = new List<string>();
        PerankinganAdapter perankinganAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.HistoryLayout);

            spinId = FindViewById<Spinner>(Resource.Id.spinId);
            lvHistory = FindViewById<ListView>(Resource.Id.lvHistory);
            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);

            listKeputusan = hsh.ShowDataKeputusan();

            var DistinctItems = listKeputusan.GroupBy(x => x.idkeputusan).Select(y => y.First());

            foreach (var item in DistinctItems)
            {
                listId.Add(item.idkeputusan);
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(Application.Context, Android.Resource.Layout.SimpleSpinnerDropDownItem, listId);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinId.Adapter = adapter;

            spinId.ItemSelected += SpinId_ItemSelected;

            imgArrow.Click += ImgArrow_Click;
        }

        public override void OnBackPressed()
        {

        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        private void SpinId_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            string id = spinId.SelectedItem.ToString();

            Tampil(id);
        }

        private void Tampil(string idKeputusan)
        {
            listKeputusan = hsh.ShowDataKeputusan().Where(x=> x.idkeputusan == idKeputusan).ToList();
            perankinganAdapter = new PerankinganAdapter(this, listKeputusan);
            lvHistory.Adapter = perankinganAdapter;
        }


    }
}
