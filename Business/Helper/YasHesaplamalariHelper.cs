using Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Helper
{
    public static class YasHesaplamalariHelper
    {
        public static List<int?> YasHesap(string girisYetki = null)
        {
            var nufusService = new NufusService();

            int suankiYil = DateTime.Now.Year;

            var nufusData = girisYetki == "genel" ? nufusService.GetAll()
                : girisYetki != "genel" ? nufusService.GetAll(m => m.Seflik.Contains(girisYetki)).ToList()
                : null;

            List<int?> yaslar = new List<int?>();

            foreach (var item in nufusData)
            {
                int? personelYasi = item.DogumTarihi?.Year;

                yaslar.Add(suankiYil - personelYasi);               
            }

            return yaslar;
        }

        // Frekans değerlerini hesaplamak için yardımcı fonksiyon
        public static Dictionary<int?, int?> YasCalculateFrequencies(List<int?> data)
        {
            Dictionary<int?, int?> frequencies = new Dictionary<int?, int?>();
            foreach (int? value in data)
            {
                if (value != null && frequencies.ContainsKey(value))
                    frequencies[value]++;
                else if (value == null)
                    continue;
                else
                    frequencies[value] = 1;
            }
            return frequencies;
        }
    }
}
