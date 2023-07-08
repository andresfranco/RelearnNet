using RelearnNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Application
{
    public class MovieService : IMovieService
    {
        private IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
           _movieRepository.CreateMovie(movie);
            return movie;
        }

        public Movie DeleteMovie(Movie movie)
        {
            _movieRepository.DeleteMovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        public Movie GetMovieById(Guid id)
        {
            return _movieRepository.GetMovieById(id);
        }

        public Movie UpdateMovie(Movie movie)
        {
            _movieRepository.UpdateMovie(movie);
            return movie;
        }
    }
}
