using System;
using Android.App;
using AplikasiMoora.Helper;

namespace AplikasiMoora.Services
{
    public class ApiService
    {
        AppPreferences app = new AppPreferences(Application.Context);

        public string ApiUrl()
        {
            string apiUrl = $"http://{app.getAccessKey("ip")}/api/";

            //string apiUrl = "http://10.211.55.3/api/";

            return apiUrl;
        }

        //kriteria
        public string GetAllKriteria()
        {
            return $"{ApiUrl()}kriteria/GetAllKriteria";
        }

        public string SaveKriteria()
        {
            return $"{ApiUrl()}kriteria/SaveKriteria";
        }

        public string UpdateKriteria()
        {
            return $"{ApiUrl()}kriteria/UpdateKriteria";
        }

        public string DeleteKriteria(int Id)
        {
            return $"{ApiUrl()}kriteria/DeleteKriteria?Id=" + Id;
        }

        //Alternatif
        public string GetAllAlternatif()
        {
            return $"{ApiUrl()}Alternatif/GetAllAlternatif";
        }

        public string SaveAlternatif()
        {
            return $"{ApiUrl()}Alternatif/SaveAlternatif";
        }

        public string UpdateAlternatif()
        {
            return $"{ApiUrl()}Alternatif/UpdateAlternatif";
        }

        public string DeleteAlternatif(int Id)
        {
            return $"{ApiUrl()}Alternatif/DeleteAlternatif?Id=" + Id;
        }

        //Hasil
        public string GetAllHasil()
        {
            string a = $"{ApiUrl()}Hasil/GetAllHasil";

            return a;
        }

        public string GetAllKeputusan()
        {
            string a = $"{ApiUrl()}Hasil/GetAllKeputusan";

            return a;
        }

        public string SaveHasil()
        {
            return $"{ApiUrl()}Hasil/SaveHasil";
        }

        public string SaveKeputusan()
        {
            return $"{ApiUrl()}Hasil/SaveKeputusan";
        }

        public string UpdateHasil()
        {
            return $"{ApiUrl()}Hasil/UpdateHasil";
        }

        public string UpdateKet()
        {
            return $"{ApiUrl()}Hasil/UpdateKet";
        }

        public string CheckAlternatif(string nama, string kriteria)
        {
            return $"{ApiUrl()}Hasil/CheckAlternatif?nama={nama}&kriteria={kriteria}";
        }

        //login
        public string UserLogin()
        {
            return $"{ApiUrl()}Login/UserLogin";
        }

        public string SaveUser()
        {
            return $"{ApiUrl()}Login/SaveUser";
        }

        public string UpdateUser()
        {
            return $"{ApiUrl()}login/UpdateUser";
        }

        public string DeleteUser(string username)
        {
            return $"{ApiUrl()}login/DeleteUser?username=" + username;
        }

        public string GetUserRoles(string username)
        {
            return $"{ApiUrl()}login/GetUserRoles?username=" + username;
        }

        public string GetAllDataUsers(string username)
        {
            return $"{ApiUrl()}login/GetAllDataUser?username=" + username;
        }

        public string CheckUsername(string username)
        {
            return $"{ApiUrl()}login/CheckUsername?username=" + username;
        }

        //config
        public string IdKeputusan()
        {
            return $"{ApiUrl()}config/IdKeputusan";
        }

        public string UpdateConfigValue()
        {
            return $"{ApiUrl()}config/UpdateConfigValue";
        }

    }
}
