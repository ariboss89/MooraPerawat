﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AplikasiMoora.Helper;
using AplikasiMoora.Models;
using AplikasiMoora.Services;
using Newtonsoft.Json;

namespace AplikasiMoora.Activities
{
    [Activity(Label = "SPK Moora", Icon = "@drawable/rs", MainLauncher =true)]
    public class LoginActivity : AppCompatActivity
    {
        EditText edtUsername, edtPassword, edtIp;
        Button btnLogin;

        HttpClient myClient = new HttpClient();
        HttpResponseMessage response;
        ApiService api = new ApiService();
        Context mContext = Android.App.Application.Context;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.Login_Layout);

            edtIp = FindViewById<EditText>(Resource.Id.edtIp);
            edtUsername = (EditText)FindViewById(Resource.Id.edtUsername);
            edtPassword = (EditText)FindViewById(Resource.Id.edtPassword);
            btnLogin = (Button)FindViewById(Resource.Id.btnLogin);

            CheckRoles();

            btnLogin.Click += BtnLogin_Click;
        }

        public override void OnBackPressed()
        {

        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if (edtIp.Text.Equals(""))
            {
                Toast.MakeText(this, "Silahkan Input Ip Address !!", ToastLength.Long).Show();
                edtIp.RequestFocus();
            }
            else if (edtUsername.Text.Equals(""))
            {
                Toast.MakeText(this, "Silahkan Input Username !!", ToastLength.Long).Show();
                edtUsername.RequestFocus();
            }
            else if (edtPassword.Text.Equals(""))
            {
                Toast.MakeText(this, "Silahkan Input Password !!", ToastLength.Long).Show();
                edtPassword.RequestFocus();
            }
            else
            {
                AppPreferences ap = new AppPreferences(mContext);

                var ipAddress = edtIp.Text;

                ap.saveIP(ipAddress);

                var urlLogin = api.UserLogin();
                var uriLogin = new Uri(urlLogin);
                myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                tb_login log = new tb_login()
                {
                    username = edtUsername.Text.Trim(),
                    password = edtPassword.Text.Trim()
                };

                try
                {

                    var jsonLogin = JsonConvert.SerializeObject(log);
                    var contentLogin = new StringContent(jsonLogin, System.Text.Encoding.UTF8, "application/json");
                    response = await myClient.PostAsync(uriLogin, contentLogin);

                    var message = response.Content.ReadAsStringAsync();

                    var msg = message.Result.ToString();

                    if (msg.Contains("Success"))
                    {

                        await Task.Delay(1000);


                        urlLogin = api.GetUserRoles(log.username);

                        uriLogin = new Uri(urlLogin);

                        myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        contentLogin = null;

                        response = await myClient.PostAsync(uriLogin, contentLogin);

                        var mesg = response.Content.ReadAsStringAsync();

                        var msge = mesg.Result.ToString();

                        var roles = JsonConvert.DeserializeObject(msge);

                        ap.saveAccessKey(log.username, log.password, roles.ToString());

                        Intent intent = new Intent(this, typeof(MainActivity));
                        StartActivity(intent);

                    }
                }
                catch (Exception x)
                {
                    Toast.MakeText(this, x.ToString(), ToastLength.Short).Show();
                }
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        void CheckRoles()
        {
            AppPreferences app = new AppPreferences(mContext);

            if (app.getAccessKey("users") != "")
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            }
        }
    }
}
