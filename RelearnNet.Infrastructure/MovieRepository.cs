using RelearnNet.Application;
using RelearnNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Infrastructure
{
    public class MovieRepository :BaseRepository<Movie>,IMovieRepository
    {
        private RelearnNetDbContext _productDbContext;
        public MovieRepository(RelearnNetDbContext productDbContext):base(productDbContext)
        {
            _productDbContext = productDbContext;
        }


        //use the base class to create the movie
        public Movie CreateMovie(Movie movie)
        {
            base.Create(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return base.GetAll().ToList();
        }

        public Movie GetMovieById(Guid id)
        {
            return base.GetById(id);
            
        }

        public Movie UpdateMovie(Movie movie)
        {
            base.Update(movie);
            return movie;
        }

        public Movie DeleteMovie(Movie movie)
        {
            base.Delete(movie);
            return movie;
        }
    }
}
