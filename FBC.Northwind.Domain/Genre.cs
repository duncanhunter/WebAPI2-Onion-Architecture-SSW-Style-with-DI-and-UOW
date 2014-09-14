using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FBC.Northwind.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}
