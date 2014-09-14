using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBC.Northwind.Domain;

namespace FBC.Northwind.RepositoryInterfaces
{
    public interface IAlbumRepository : IRepository<Album>
    {
        IEnumerable<Album> GetLatestReleases(int count);
    }

}
