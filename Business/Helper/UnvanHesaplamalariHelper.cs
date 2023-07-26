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

        public static int UnvanHesaplama(string unvan)
        {
                var resNufus = genelService.GetAll();
                return resNufus.Where(n => n.Unvani == unvan).ToList().Count;
        }
    }
}
