using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBC.Northwind.Data.Context;
using FBC.Northwind.Domain;

namespace FBC.Northwind.Data.EntityConfig
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using FBC.Northwind.Data.Context;
    using FBC.Northwind.Domain;
    using FBC.Northwind.Domain.Data;

    namespace Northwind.MusicStore.Data.EntityConfig
    {
        /// <summary>
        /// This is where you can add additional configuration for your database tables.
        /// This is preferable to having database configuration leak all over your Domain Entities.
        /// </summary>
        internal class AlbumConfiguration : EntityTypeConfiguration<Album>
        {
            public AlbumConfiguration()
            {
                ToTable("Albums");
                //HasKey(t => t.AlbumID);
                //Property(t => t.DateTimeCreated).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
                //HasRequired(t => t.User).WithMany(t => t.UserDetails).HasForeignKey(d => d.UserId);
            }
        }

        public class MusicStoreDbInitializer : DropCreateDatabaseIfModelChanges<MusicStoreDbContext>
            //CreateDatabaseIfNotExists, DropCreateDatabaseIfModelChanges, AlwaysRecreateDatabase
        {
            protected override void Seed(MusicStoreDbContext context)
            {
                var genres = GenreObjectMother.Build();

                genres.ForEach(genre => context.Genres.Add(genre));

                var artists = ArtistObjectMother.Build();

                var albums = AlbumObjectMother.Build(genres, artists);

                albums.ForEach(a => context.Albums.Add(a));
            }

        }
    }
}