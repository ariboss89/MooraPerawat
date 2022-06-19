using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using AplikasiMoora.Models;

namespace AplikasiMoora.Adapter
{
    public class PerankinganAdapter : BaseAdapter<tb_keputusan>
    {
        TextView txtNama, txtHasilAkhir, txtKet;

        public PerankinganAdapter(Activity activity, int listViewRow)
        {

        }

        public List<tb_keputusan> listSpk;
        private Context mContext;
        private Activity activity;



        public PerankinganAdapter(Context context, List<tb_keputusan> items)
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

        public override tb_keputusan this[int position]
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
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.PerankinganListView_Layout, null, false);
            }

            txtNama = row.FindViewById<TextView>(Resource.Id.txtNama);
            txtHasilAkhir = row.FindViewById<TextView>(Resource.Id.txtHasilAkhir);
            txtKet = row.FindViewById<TextView>(Resource.Id.txtKet);

            txtNama.Text = listSpk[position].nama;
            txtHasilAkhir.Text = listSpk[position].hasil_akhir.ToString();
            txtKet.Text = listSpk[position].ket;


            return row;
        }
    }
}
