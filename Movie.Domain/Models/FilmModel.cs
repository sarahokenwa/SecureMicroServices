using System.ComponentModel.DataAnnotations;

namespace Movies.Domain.Models
{
    public class FilmModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string? Description { get; set; }
        [MaxLength(100)]    
        public string Genre { get; set; }
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.Now;
        public string Rating { get; set; }
        public string ImageUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Owner { get; set; }
    }
}
