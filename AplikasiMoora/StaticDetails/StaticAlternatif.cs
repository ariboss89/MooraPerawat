using System;
using System.Collections.Generic;
using AplikasiMoora.Models;
using Java.Util;

namespace AplikasiMoora.StaticDetails
{
    public static class StaticAlternatif
    {
        public static int Id { get; set; }
        public static string nama { get; set; }
        public static string alamat { get; set; }
        public static string kontak { get; set; }
        public static string jenis_kelamin { get; set; }

        public static List<tb_alternatif> listStaticAlternatif = new List<tb_alternatif>();
    }
}
