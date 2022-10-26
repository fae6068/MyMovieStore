using MyMovieStore.Models;

namespace MyMovieStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Movie> MoviesOfTheWeek { get; }

        public HomeViewModel(IEnumerable<Movie> moviesOfTheWeek)
        {
            MoviesOfTheWeek = moviesOfTheWeek;
        }
    }
}
