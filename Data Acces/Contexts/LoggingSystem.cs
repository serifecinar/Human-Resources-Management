using Data_Acces.Models;
using DataAcces;
using System.Data.Entity;

namespace Data_Acces
{
    public class LoggingSystem : DbContext
    {
        public DbSet<Nufus> Nufus { get; set; }
        public DbSet<Tahsil> Tahsil { get; set; }
        public DbSet<Sertifika> Sertifika { get; set; }
        public DbSet<Nakil> Nakil { get; set; }
        public DbSet<Genel> Genel { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }

        //public DbSet<Performans> Performans { get; set; }
    }
}
