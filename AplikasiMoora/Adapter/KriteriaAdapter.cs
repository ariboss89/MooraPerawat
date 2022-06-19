using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using AplikasiMoora.Models;

namespace AplikasiMoora.Adapter
{
    public class KriteriaAdapter : BaseAdapter<tb_kriteria>
    {
        TextView txtId, txtNama, txtNilai;

        public KriteriaAdapter(Activity activity, int listViewRow)
        {

        }

        public List<tb_kriteria> listKriteria;
        private Context mContext;
        private Activity activity;



        public KriteriaAdapter(Context context, List<tb_kriteria> items)
        {
            listKriteria = items;
            mContext = context;
        }

        public override int Count
        {
            get
            {
                try
                {
                    return listKriteria.Count;
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "Can't connect to server !", ToastLength.Long).Show();

                    return 0;
                }
            }
        }

        public override tb_kriteria this[int position]
        {
            get
            {
                return listKriteria[position];
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
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.KriteriaListView_Layout, null, false);
            }

            txtId = row.FindViewById<TextView>(Resource.Id.txtId);
            txtNama = row.FindViewById<TextView>(Resource.Id.txtNama);
            txtNilai = row.FindViewById<TextView>(Resource.Id.txtNilai);

            txtId.Text = listKriteria[position].Id.ToString();
            txtNama.Text = listKriteria[position].nama;
            txtNilai.Text = listKriteria[position].bobot.ToString();
            return row;
        }
    }
}
