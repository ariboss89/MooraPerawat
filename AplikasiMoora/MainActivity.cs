using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using AplikasiMoora.Services;
using System.Threading.Tasks;
using Android.Widget;
using AplikasiMoora.Activities;
using Android.Content;
using AplikasiMoora.Helper;

namespace AplikasiMoora
{
    [Activity(Label = "SPK Moora", Icon = "@drawable/rs", Theme = "@style/AppTheme.NoActionBar", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        LinearLayout linAlternatif, linKriteria, linProses, linHistory, linSetting, linLogout;
        Context mContext = Application.Context;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.Main_Layout);

            linAlternatif = (LinearLayout)FindViewById(Resource.Id.linAlternatif);
            linKriteria = (LinearLayout)FindViewById(Resource.Id.linKriteria);
            linProses = (LinearLayout)FindViewById(Resource.Id.linProses);
            linHistory = (LinearLayout)FindViewById(Resource.Id.linHistory);
            linSetting = (LinearLayout)FindViewById(Resource.Id.linSetting);
            linLogout = (LinearLayout)FindViewById(Resource.Id.linLoout);

            linAlternatif.Click += LinAlternatif_Click;
            linKriteria.Click += LinKriteria_Click;
            linProses.Click += LinProses_Click;
            linHistory.Click += LinHistory_Click;
            linSetting.Click += LinSetting_Click;
            linLogout.Click += LinLogout_Click;

           // CheckRoles();

        }

        private void LinLogout_Click(object sender, EventArgs e)
        {
            AppPreferences app = new AppPreferences(mContext);
            app.deleteAccessKey();
            Intent intent = new Intent(this, typeof(LoginActivity));
            intent.PutExtra("Logout", "Logout");
            StartActivity(intent);
        }

        private void LinSetting_Click(object sender, EventArgs e)
        {
            AppPreferences app = new AppPreferences(mContext);

            string roles = app.getAccessKey("roles");

            if (roles.Equals("Admin"))
            {
                Toast.MakeText(this, "Anda Tidak Memiliki Akses", ToastLength.Long).Show();
            }
            else
            {
                Intent intent = new Intent(this, typeof(RegisterActivity));
                StartActivity(intent);
            }
        }

        private void LinHistory_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(HistoryActivity));
            StartActivity(intent);
        }

        private void LinProses_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProsesActivity));
            StartActivity(intent);
        }

        private void LinKriteria_Click(object sender, EventArgs e)
        {
            AppPreferences app = new AppPreferences(mContext);

            string roles = app.getAccessKey("roles");

            if (roles.Equals("Admin"))
            {
                Toast.MakeText(this, "Anda Tidak Memiliki Akses", ToastLength.Long).Show();
            }
            else
            {
                Intent intent = new Intent(this, typeof(KriteriaActivity));
                StartActivity(intent);
            }
        }

        private void LinAlternatif_Click(object sender, EventArgs e)
        {
            AppPreferences app = new AppPreferences(mContext);

            string roles = app.getAccessKey("roles");

            if (roles.Equals("Admin"))
            {
                Toast.MakeText(this, "Anda Tidak Memiliki Akses", ToastLength.Long).Show();
            }
            else
            {
                Intent intent = new Intent(this, typeof(AlternatifActivity));
                StartActivity(intent);
            }
        }

        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}

        private void CheckRoles()
        {
            AppPreferences app = new AppPreferences(mContext);

            string roles = app.getAccessKey("roles");

            if(roles.Equals("Superadmin"))
            {
                
            }
            else
            {
                Intent intent = new Intent(this, typeof(LoginActivity));
                StartActivity(intent);
                Toast.MakeText(this, "Silahkan Login Untuk Melanjutkan", ToastLength.Long).Show();
            }
        }

        public override void OnBackPressed()
        {

        }
    }
}
