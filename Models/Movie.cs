namespace MyMovieStore.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool InStock { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; } = default!;
        public bool IsMovieOfTheWeek { get; set; }  
    }
}
