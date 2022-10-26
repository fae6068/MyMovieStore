using System.IO.Pipelines;

namespace MyMovieStore.Models
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> AllMovies { get; }
        IEnumerable<Movie> MoviesOfTheWeek { get; }
        Movie? GetMovieById(int movieId);
        IEnumerable<Movie> SearchMovies(string searchQuery);
    }
}
