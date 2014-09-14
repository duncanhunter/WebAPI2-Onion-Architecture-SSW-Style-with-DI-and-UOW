using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FBC.Northwind.Domain;
using FBC.Northwind.RepositoryInterfaces;

namespace FBC.Northwind.WebUI.Controllers
{
    public class GenreController : ApiController
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IUnitOfWork _unitOfWork;

        public GenreController(IGenreRepository genreRepository, IUnitOfWork unitOfWork)
        {
            _genreRepository = genreRepository;
            _unitOfWork = unitOfWork;
        }


        public List<Genre> Get()
        {
            return _genreRepository.Get().ToList();
        }

        [HttpPost]
        public void Post(Genre genre)
        {
            //TODO: validation
            _genreRepository.Add(genre);
            _unitOfWork.SaveChanges();
        }

    }
}

