using RelearnNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Application
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
        Movie UpdateMovie(Movie movie);
        Movie DeleteMovie(Movie movie);
        Movie GetMovieById(Guid id);
    }
}
