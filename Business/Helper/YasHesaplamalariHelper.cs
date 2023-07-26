using Business.Services;
using DataAcces;
using System;
using System.Linq;

namespace Business.Helper
{
    public static class YasHesaplamalariHelper
    {
        public readonly static NufusService nufusService = new NufusService();

        public static int YasHesap()
        {
            var resNufus = nufusService.GetAll();


            return resNufus.Count();

        }
    }
}
