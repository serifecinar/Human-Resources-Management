using Business.Services;
using System;
using System.Collections.Generic;

namespace Business.Helper
{
    public static class YasHesaplamalariHelper
    {
        public static List<int> YasHesap()
        {
            var nufusService = new NufusService();

            int suankiYil = DateTime.Now.Year;

            var nufusData = nufusService.GetAll();

            List<int> yaslar = new List<int>();

            foreach (var item in nufusData)
            {
                int personelYasi = item.DogumTarihi.Value.Year;

                yaslar.Add(suankiYil - personelYasi);               
            }

            return yaslar;
        }

        // Frekans değerlerini hesaplamak için yardımcı fonksiyon
        public static Dictionary<int, int> YasCalculateFrequencies(List<int> data)
        {
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            foreach (int value in data)
            {
                if (frequencies.ContainsKey(value))
                    frequencies[value]++;
                else
                    frequencies[value] = 1;
            }
            return frequencies;
        }
    }
}
