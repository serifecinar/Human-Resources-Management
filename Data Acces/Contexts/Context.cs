using Data_Acces.Models;
using System.Data.Entity;

namespace DataAcces
{
    public class Context : DbContext
    {
        public DbSet<Log> Log { get; set; }
        public DbSet<Nufus> Nufus { get; set; }
        public DbSet<Tahsil> Tahsil { get; set; }
        public DbSet<Sertifika> Sertifika { get; set; }
        public DbSet<Nakil> Nakil { get; set; }
        public DbSet<Genel> Genel { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
    }
}
