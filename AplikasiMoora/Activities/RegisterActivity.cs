
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AplikasiMoora.Models;
using AplikasiMoora.Services;
using Newtonsoft.Json;

namespace AplikasiMoora.Activities
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : AppCompatActivity
    {
        EditText edtUsername, edtPassword;
        Button btnRegister;
        tb_login log = new tb_login();
        LoginService lsr = new LoginService();
        HttpClient httpClient;
        HttpResponseMessage response;
        ApiService api = new ApiService();
        ImageView imgArrow;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RegisterLayout);

            edtUsername = (EditText)FindViewById(Resource.Id.edtUsername);
            edtPassword = (EditText)FindViewById(Resource.Id.edtPassword);
            btnRegister = (Button)FindViewById(Resource.Id.btnRegister);
            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);

            btnRegister.Click += BtnRegister_Click;
            imgArrow.Click += ImgArrow_Click;
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(LoginActivity));
            StartActivity(intent);
        }

        public override void OnBackPressed()
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            
            if (edtUsername.Text.Equals(""))
            {
                Toast.MakeText(this, "Data can't be empty", ToastLength.Long).Show();
                edtUsername.RequestFocus();
            }
            else if (edtPassword.Text.Equals(""))
            {
                Toast.MakeText(this, "Data can't be empty", ToastLength.Long).Show();
                edtPassword.RequestFocus();
            }
            
            else
            {
                CheckUsername(edtUsername.Text);


            }
        }

        public async void CheckUsername(string username)
        {
            string message = "";
            try
            {
                HttpClient myClient = new HttpClient();
                string url = api.CheckUsername(username);
                var uri = new Uri(url);
                myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;

                var json = JsonConvert.SerializeObject(log);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                response = await myClient.PostAsync(uri, content);

                var mesg = response.Content.ReadAsStringAsync();

                var msge = mesg.Result.ToString();

                if (!msge.Contains("doesnt"))
                {
                    message = "Username Exist";
                }

                if (message != ("Username Exist"))
                {
                    message = "";

                    try
                    {
                        

                            log = new tb_login()
                            {
                                
                                password = edtPassword.Text,
                                role = "Admin",
                                username = edtUsername.Text

                            };

                            lsr.SaveUsers(log);

                        Intent intent = new Intent(this, typeof(LoginActivity));
                        StartActivity(intent);

                    }
                    catch (Exception x)
                    {
                        Toast.MakeText(Application.Context, x.ToString(), ToastLength.Short).Show();
                    }

                }
                else
                {
                    Toast.MakeText(Application.Context, "Username Exist, Please Change", ToastLength.Short).Show();
                    edtUsername.RequestFocus();
                }


            }
            catch (Exception x)
            {
                Toast.MakeText(Application.Context, x.ToString(), ToastLength.Short).Show();
            }
        }
    }
}
