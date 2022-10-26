using Microsoft.EntityFrameworkCore;

namespace MyMovieStore.Models
{
    public class MovieRepository: IMovieRepository
    {
        private readonly DefaultConnection _myMovieStoreDbContext;

        public MovieRepository(DefaultConnection myMovieStoreDbContext)
        {
            _myMovieStoreDbContext = myMovieStoreDbContext;
        }

        public IEnumerable<Movie> AllMovies
        {
            get { return _myMovieStoreDbContext.Movies.Include(c => c.Genre); }
        }

        public IEnumerable<Movie> MoviesOfTheWeek
        {
            get
            {
                return _myMovieStoreDbContext.Movies.Include(c => c.Genre).Where(p => p.IsMovieOfTheWeek);
            }
        }

        public Movie? GetMovieById(int movieId)
        {
            return _myMovieStoreDbContext.Movies.FirstOrDefault(c => c.MovieId == movieId);
        }

        public IEnumerable<Movie> SearchMovies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
