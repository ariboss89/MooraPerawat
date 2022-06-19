using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using AplikasiMoora.Models;

namespace AplikasiMoora.Adapter
{
    public class OptimasiAdapter : BaseAdapter<optimasi>
    {
        TextView txtNama, txtKriteria, txtOptimasi;

        public OptimasiAdapter(Activity activity, int listViewRow)
        {

        }

        public List<optimasi> listSpk;
        private Context mContext;
        private Activity activity;



        public OptimasiAdapter(Context context, List<optimasi> items)
        {
            listSpk = items;
            mContext = context;
        }

        public override int Count
        {
            get
            {
                try
                {
                    return listSpk.Count;
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "Can't connect to server !", ToastLength.Long).Show();

                    return 0;
                }
            }
        }

        public override optimasi this[int position]
        {
            get
            {
                return listSpk[position];
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.OptimasiListView_Layout, null, false);
            }

            txtNama = row.FindViewById<TextView>(Resource.Id.txtNama);
            txtKriteria = row.FindViewById<TextView>(Resource.Id.txtKriteria);
            txtOptimasi = row.FindViewById<TextView>(Resource.Id.txtOptimasi);

            txtNama.Text = listSpk[position].nama;
            txtKriteria.Text = listSpk[position].kriteria;
            txtOptimasi.Text = listSpk[position].opt.ToString();


            return row;
        }
    }
}
