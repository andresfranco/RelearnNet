using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelearnNet.Domain;

namespace RelearnNet.Application
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);

        Movie UpdateMovie(Movie movie);

        Movie DeleteMovie(Movie movie);

        Movie GetMovieById(Guid id);
    }
}
