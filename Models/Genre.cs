namespace MyMovieStore.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; } = string.Empty;
        public string GenreDescription { get; set; } = string.Empty;
        public List<Movie>? Movies { get; set; } 
    }
}
