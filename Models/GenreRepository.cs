namespace MyMovieStore.Models
{
    public class GenreRepository: IGenreRepository
    {
        private readonly DefaultConnection _myMovieStoreDbContext;

        public GenreRepository(DefaultConnection myMovieStoreDbContext)
        {
            _myMovieStoreDbContext = myMovieStoreDbContext;
        }

        public IEnumerable<Genre> AllGenres => _myMovieStoreDbContext.Genres.OrderBy(p => p.GenreName);
    }
}
