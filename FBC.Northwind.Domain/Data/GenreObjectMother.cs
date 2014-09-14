using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBC.Northwind.Domain.Data
{
    public class GenreObjectMother
    {
        public static List<Genre> Build()
        {
            var genres = new List<Genre>
            {
                new Genre {Name = "Rock"},
                new Genre {Name = "Jazz"},
                new Genre {Name = "Metal"},
                new Genre {Name = "Alternative"},
                new Genre {Name = "Disco"},
                new Genre {Name = "Blues"},
                new Genre {Name = "Latin"},
                new Genre {Name = "Reggae"},
                new Genre {Name = "Pop"},
                new Genre {Name = "Classical"}
            };
            return genres;
        }

    }
}
