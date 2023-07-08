using Microsoft.AspNetCore.Mvc;
using RelearnNet.Application;
using RelearnNet.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RelearnNet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _service;

        public MoviesController(IMovieService service )
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var movies = _service.GetAllMovies();
            return Ok(movies);
        }
        [HttpPost]
        public ActionResult<Movie> Post(Movie movie)
        {   
            
            var createdMovie = _service.CreateMovie(movie);
            return Ok(createdMovie);
        }

        [HttpPut]
        public ActionResult<Movie> Put(Movie movie)
        {
            var updatedMovie = _service.UpdateMovie(movie);
            return Ok(updatedMovie);
        }
        [HttpDelete]
        public ActionResult<Movie> Delete(Movie movie)
        {
            var deletedMovie = _service.DeleteMovie(movie);
            return Ok(deletedMovie);
        }
    }
}
