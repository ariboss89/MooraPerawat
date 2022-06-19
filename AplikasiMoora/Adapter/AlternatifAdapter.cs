using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using AplikasiMoora.Models;

namespace AplikasiMoora.Adapter
{
    public class AlternatifAdapter : BaseAdapter<tb_alternatif>
    {
        TextView txtId, txtNama, txtAlamat, txtKontak, txtJenisKelamin;

        public AlternatifAdapter(Activity activity, int listViewRow)
        {

        }

        public List<tb_alternatif> listAlternatif;
        private Context mContext;
        private Activity activity;



        public AlternatifAdapter(Context context, List<tb_alternatif> items)
        {
            listAlternatif = items;
            mContext = context;
        }

        public override int Count
        {
            get
            {
                try
                {
                    return listAlternatif.Count;
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "Can't connect to server !", ToastLength.Long).Show();

                    return 0;
                }
            }
        }

        public override tb_alternatif this[int position]
        {
            get
            {
                return listAlternatif[position];
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
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.AlternatifListView_Layout, null, false);
            }

            txtId = row.FindViewById<TextView>(Resource.Id.txtId);
            txtNama = row.FindViewById<TextView>(Resource.Id.txtNama);
            txtAlamat = row.FindViewById<TextView>(Resource.Id.txtAlamat);
            txtKontak = row.FindViewById<TextView>(Resource.Id.txtKontak);
            txtJenisKelamin = row.FindViewById<TextView>(Resource.Id.txtJenisKelamin);

            txtId.Text = listAlternatif[position].Id.ToString();
            txtNama.Text = listAlternatif[position].nama;
            txtAlamat.Text = listAlternatif[position].alamat;
            txtKontak.Text = listAlternatif[position].kontak;
            txtJenisKelamin.Text = listAlternatif[position].jenis_kelamin;

            return row;
        }
    }
}
