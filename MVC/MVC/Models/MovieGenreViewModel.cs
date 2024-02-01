using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Generes { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
