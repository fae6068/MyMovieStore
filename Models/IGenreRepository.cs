namespace MyMovieStore.Models
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> AllGenres { get; }
    }
}
