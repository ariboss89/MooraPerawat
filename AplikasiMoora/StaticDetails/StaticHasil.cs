using System;
using System.Collections.Generic;
using AplikasiMoora.Models;
using Java.Util;

namespace AplikasiMoora.StaticDetails
{
    public static class StaticHasil
    {
        public static int Id { get; set; }
        public static string nama { get; set; }
        public static string kriteria { get; set; }
        public static double nilai { get; set; }

        public static List<tb_hasil> listStaticHasil = new List<tb_hasil>();
    }
}
