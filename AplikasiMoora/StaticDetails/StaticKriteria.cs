using System;
using System.Collections.Generic;
using AplikasiMoora.Models;
using Java.Util;

namespace AplikasiMoora.StaticDetails
{
    public static class StaticKriteria
    {
        public static int Id { get; set; }
        public static string nama { get; set; }
        public static double bobot { get; set; }

        public static List<tb_kriteria> listStaticKriteria = new List<tb_kriteria>();
    }
}
