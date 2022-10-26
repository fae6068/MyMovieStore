using Microsoft.AspNetCore.Mvc;
using MyMovieStore.Models;
using MyMovieStore.ViewModels;

namespace MyMovieStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public HomeController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }   

        public ViewResult Index()
        {
            var moviesOfTheWeek = _movieRepository.MoviesOfTheWeek;

            var homeViewModel = new HomeViewModel(moviesOfTheWeek);

            return View(homeViewModel);
        }
    }
}
