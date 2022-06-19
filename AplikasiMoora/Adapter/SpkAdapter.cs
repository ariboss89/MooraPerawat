using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using AplikasiMoora.Models;

namespace AplikasiMoora.Adapter
{
    public class SpkAdapter : BaseAdapter<tb_hasil>
    {
        TextView txtNama, txtKriteria, txtNilai;

        public SpkAdapter(Activity activity, int listViewRow)
        {

        }

        public List<tb_hasil> listSpk;
        private Context mContext;
        private Activity activity;



        public SpkAdapter(Context context, List<tb_hasil> items)
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

        public override tb_hasil this[int position]
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
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.SPKListView_Layout, null, false);
            }

            txtNama = row.FindViewById<TextView>(Resource.Id.txtNama);
            txtKriteria = row.FindViewById<TextView>(Resource.Id.txtKriteria);
            txtNilai = row.FindViewById<TextView>(Resource.Id.txtNilai);

            txtNama.Text = listSpk[position].nama;
            txtKriteria.Text = listSpk[position].kriteria;
            txtNilai.Text = listSpk[position].nilai.ToString();


            return row;
        }
    }
}
