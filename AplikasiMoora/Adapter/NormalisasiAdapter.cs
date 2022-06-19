using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using AplikasiMoora.Models;

namespace AplikasiMoora.Adapter
{
    public class NormalisasiAdapter : BaseAdapter<normalisasi>
    {
        TextView txtNama, txtKriteria, txtNormalisasi;

        public NormalisasiAdapter(Activity activity, int listViewRow)
        {

        }

        public List<normalisasi> listNormalisasi;
        private Context mContext;
        private Activity activity;



        public NormalisasiAdapter(Context context, List<normalisasi> items)
        {
            listNormalisasi = items;
            mContext = context;
        }

        public override int Count
        {
            get
            {
                try
                {
                    return listNormalisasi.Count;
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "Can't connect to server !", ToastLength.Long).Show();

                    return 0;
                }
            }
        }

        public override normalisasi this[int position]
        {
            get
            {
                return listNormalisasi[position];
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
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.NormalisasiListView_Layout, null, false);
            }

            txtNama = row.FindViewById<TextView>(Resource.Id.txtNama);
            txtKriteria = row.FindViewById<TextView>(Resource.Id.txtKriteria);
            txtNormalisasi = row.FindViewById<TextView>(Resource.Id.txtNormalisasi);

            txtNama.Text = listNormalisasi[position].nama;
            txtKriteria.Text = listNormalisasi[position].kriteria;
            txtNormalisasi.Text = listNormalisasi[position].norm.ToString();


            return row;
        }
    }
}
