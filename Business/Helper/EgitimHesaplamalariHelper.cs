﻿using Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper
{
    public static class EgitimHesaplamalariHelper
    {
        public static List<string> EgitimHesap()
        {
            var tahsilService = new TahsilService();
            var tahsilData = tahsilService.GetAll();

            List<string> egitimler = new List<string>();

            foreach (var item in tahsilData)
            {
                string egitim = item.TahsilAdi1;
                egitimler.Add(egitim);
            }

            return egitimler;
        }

        public static Dictionary<string, int> EgitimCalculateFrequencies(List<string> data)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();
            foreach (string value in data)
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
