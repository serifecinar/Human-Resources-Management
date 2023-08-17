using Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper
{
    public static class UnvanHesaplamalariHelper
    {
        public readonly static GenelService genelService = new GenelService();

        public static int UnvanHesaplama(string unvan, string girisYetki = null)
        {

            var genelData = girisYetki == "genel" ? genelService.GetAll()
               : girisYetki != "genel" ? genelService.GetAll(m => m.Seflik.Contains(girisYetki)).ToList()
               : null;
            return genelData != null ? genelData.Where(n => n.Unvani == unvan).ToList().Count
               : 0;
        }
    }
}
