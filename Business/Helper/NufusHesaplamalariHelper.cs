using Business.Services;
using System;
using System.Linq;

namespace Business.Helper
{
    public static class NufusHesaplamalariHelper
    {
        public readonly static NufusService nufusService = new NufusService();

        public static int KadinSayisi(string girisYetki = null)
        {
            var nufusData = girisYetki == "genel" ? nufusService.GetAll()
               : girisYetki != "genel" ? nufusService.GetAll(m => m.Seflik.Contains(girisYetki)).ToList()
               : null;

            return nufusData != null ? nufusData.Where(m => m.Cinsiyet == "KADIN").ToList().Count
                : 0;
        }

        public static int ErkekSayisi(string girisYetki = null)
        {
            var nufusData = girisYetki == "genel" ? nufusService.GetAll()
               : girisYetki != "genel" ? nufusService.GetAll(m => m.Seflik.Contains(girisYetki)).ToList()
               : null;

            return nufusData != null ? nufusData.Where(m => m.Cinsiyet == "ERKEK").ToList().Count
                : 0;
        }

        public static int ToplamSayi(string girisYetki = null)
        {
            return girisYetki != null ? KadinSayisi(girisYetki) + ErkekSayisi(girisYetki)
                : 0;
        }

        public static double KadinOrani(string girisYetki = null)
        {
            return girisYetki != null ? Math.Round(((double)KadinSayisi(girisYetki) / (double)ToplamSayi(girisYetki)) * 100, 2)
            : 0;
        }

        public static double ErkekOrani(string girisYetki = null)
        {
            return girisYetki != null ? Math.Round(((double)ErkekSayisi(girisYetki) / (double)ToplamSayi(girisYetki)) * 100, 2)
            : 0;
        }
    }
}
