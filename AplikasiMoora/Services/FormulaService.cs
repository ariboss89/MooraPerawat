using System;
using System.Collections.Generic;
using System.Linq;
using AplikasiMoora.Models;
using Java.Util;

namespace AplikasiMoora.Services
{
    public class FormulaService
    {
        HasilService hsr = new HasilService();
        List<tb_hasil> listHasil = new List<tb_hasil>();
        List<normalisasi> listNormalisasi = new List<normalisasi>();
        List<optimasi> listOptimasi = new List<optimasi>();
        KriteriaService ksr = new KriteriaService();
        List<tb_kriteria> listKriteria = new List<tb_kriteria>();
        List<tb_alternatif> listAlternatif = new List<tb_alternatif>();
        tb_hasil tbh = new tb_hasil();

        public List<tb_hasil> DataHasil()
        {
            listHasil = new List<tb_hasil>();

            listHasil = hsr.ShowDataHasil();

            return listHasil;
        }

        public List<normalisasi> HitungNormalisasi()
        {
            listHasil = new List<tb_hasil>();
            listHasil = hsr.ShowDataHasil();
            List<double> listKuadrat = new List<double>();
            listNormalisasi = new List<normalisasi>();
            listAlternatif = new List<tb_alternatif>();
            listKriteria = ksr.ShowDataKriteria();

            double hslKuadrat = 0.0;
            double hslNormalisasi = 0.0;

            foreach(var item in listKriteria)
            {
                string nama = item.nama;

                var count = listHasil.Where(x => x.kriteria == nama).ToList();

                foreach(var name in count)
                {
                    hslKuadrat += Math.Pow(name.nilai, 2);
                    
                }

                var kuadrat = Math.Sqrt(hslKuadrat);

                foreach(var itm in count)
                {
                   var normx = itm.nilai / kuadrat;

                    normalisasi norm = new normalisasi()
                    {
                        nama = itm.nama,
                        kriteria = itm.kriteria,
                        nilai = itm.nilai,
                        norm = normx
                    };

                    listNormalisasi.Add(norm);

                    hslKuadrat = 0.0;

                };

            }

            return listNormalisasi;
        }

        public List<optimasi> HitungOptimasi()
        {
            listKriteria = new List<tb_kriteria>();
            listNormalisasi = new List<normalisasi>();
            listNormalisasi = HitungNormalisasi();
            listKriteria = ksr.ShowDataKriteria();
            
            List<double> listMultiple = new List<double>();
            listOptimasi = new List<optimasi>();
            optimasi opt = new optimasi();

            double hslMultiple = 0.0;
            double hslOptimasi = 0.0;

            for(int a = 0; a < listKriteria.Count; a++)
            {
                string namaKriteria = listKriteria[a].nama;
                double nilaiKriteria = listKriteria[a].bobot;

                var data = listNormalisasi.Where(x => x.kriteria == namaKriteria).ToList();

                for(int b = 0; b < data.Count; b++)
                {
                    hslMultiple = nilaiKriteria * data[b].norm;

                    opt = new optimasi()
                    {
                        nama = listNormalisasi[b].nama,
                        normalisasi = listNormalisasi[b].norm,
                        kriteria = listKriteria[a].nama,
                        opt = hslMultiple
                    };

                    listOptimasi.Add(opt);
                }
            }

            return listOptimasi;
        }

        public List<tb_keputusan> HasilKeputusan()
        {
            tb_keputusan tbk = new tb_keputusan();
            List<tb_keputusan> listFinal = new List<tb_keputusan>();

            var dataOptimasi = HitungOptimasi();

            var distinct = dataOptimasi.GroupBy(x => x.nama).Select(y=>y.First()).ToList();

            var aaa = distinct.Count();

            foreach (var item in distinct)
            {
                var nama = item.nama;

                var count = dataOptimasi.Where(x => x.nama == nama);

                double nilaiAkhir = 0.0;

                foreach(var itm in count)
                {
                    nilaiAkhir += itm.opt;

                }

                tbk = new tb_keputusan()
                {
                    nama = nama,
                    hasil_akhir = nilaiAkhir
                };
                

                listFinal.Add(tbk);
            }

            return listFinal;

        }

        public List<tb_keputusan> HasilKeterangan()
        {
            tb_keputusan tbk = new tb_keputusan();
            List<tb_keputusan> listKeputusan = new List<tb_keputusan>();
            List<tb_keputusan> listHasil = new List<tb_keputusan>();

            listKeputusan = HasilKeputusan();

            var orderBy = listKeputusan.OrderByDescending(x => x.hasil_akhir).ToList();

            string ket = "";

            
            for (int a = 0; a < orderBy.Count; a++)
            {
                ket = $"Peringkat {a + 1}";

                tbk = new tb_keputusan()
                {
                    nama = orderBy[a].nama,
                    hasil_akhir = orderBy[a].hasil_akhir,
                    ket = ket
                };

                listHasil.Add(tbk);
            }

            return listHasil;

        }
    }
}
