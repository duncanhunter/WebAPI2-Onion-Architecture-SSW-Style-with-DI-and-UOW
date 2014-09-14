using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBC.Northwind.Data.Context;
using FBC.Northwind.Domain;
using FBC.Northwind.RepositoryInterfaces;

namespace FBC.Northwind.Data.Repositories
{
    public class ArtistRepository : RepositoryBase<Artist>, IArtistRepository
    {
        public ArtistRepository(IDbContextFactory contextFactory) : base(contextFactory)
        {
        }
    }

    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        public GenreRepository(IDbContextFactory contextFactory) : base(contextFactory)
        {
        }
    }

    public class AlbumRepository : RepositoryBase<Album>, IAlbumRepository
    {
        public AlbumRepository(IDbContextFactory contextFactory) : base(contextFactory)
        {
        }

        public IEnumerable<Album> GetLatestReleases(int count)
        {
            List<Album> latestReleases = Get()
                .OrderByDescending(a => a.CreatedDateTime)
                .Take(count)
                .ToList();
            return latestReleases;
        }
    }
}