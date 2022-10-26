using MyMovieStore.Models;

namespace MyMovieStore.ViewModels
{
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movies { get; }
        public string? CurrentGenre { get; }

        public MovieListViewModel(IEnumerable<Movie> movies, string? currentGenre)
        {
            Movies = movies;
            CurrentGenre = currentGenre;
        }
    }
}
