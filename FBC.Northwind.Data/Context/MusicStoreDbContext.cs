using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBC.Northwind.Domain;

namespace FBC.Northwind.Data.Context
{
    public class MusicStoreDbContext : DbContext
    {
        public IDbSet<Album> Albums { get; set; }
        public IDbSet<Artist> Artists { get; set; }
        public IDbSet<Genre> Genres { get; set; }

        public MusicStoreDbContext()
            : base("name=DefaultConnection")
        {
        }

        public MusicStoreDbContext(string connectionString)
            : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //modelBuilder.Entity<Album>().ToTable("Albums");
            //modelBuilder.Configurations.Add(new AlbumConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}