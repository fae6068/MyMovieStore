using Microsoft.AspNetCore.Mvc;
using MyMovieStore.Models;
using MyMovieStore.ViewModels;

namespace MyMovieStore.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IGenreRepository _genreRepository;

        public MovieController(IMovieRepository movieRepository, IGenreRepository genreRepository)
        {
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;
        }

        public IActionResult List()
        {
            MovieListViewModel movieListViewModel = new MovieListViewModel(_movieRepository.AllMovies, "Movies");

            return View(movieListViewModel);
        }

        public IActionResult Details(int id)
        {
            var movie = _movieRepository.GetMovieById(id);
            if(movie == null)
                return NotFound();

            return View(movie);
        }
    }
}
