using Business.Services;
using System;
using System.Linq;

namespace Business.Helper
{
    public static class NufusHesaplamalariHelper
    {
        public readonly static NufusService nufusService = new NufusService();

        public static int KadinSayisi
        {
            get
            {
                var resNufus = nufusService.GetAll();

                return resNufus.Where(n => n.Cinsiyet == "KADIN").ToList().Count;
            }
        }

        public static int ErkekSayisi
        {
            get
            {
                var resNufus = nufusService.GetAll();

                return resNufus.Where(n => n.Cinsiyet == "ERKEK").ToList().Count;
            }
        }

        public static int ToplamSayi
        {
            get
            {
                return KadinSayisi + ErkekSayisi;
            }
        }

        public static double KadinOrani
        {
            get
            {
                return Math.Round(((double)KadinSayisi / (double)ToplamSayi) * 100, 2);
            }
        }

        public static double ErkekOrani
        {
            get
            {
                return Math.Round(((double)ErkekSayisi / (double)ToplamSayi) * 100, 2);
            }
        }
    }
}
