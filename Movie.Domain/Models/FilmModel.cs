using System.ComponentModel.DataAnnotations;

namespace Movies.Domain.Models
{
    public class FilmModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(100)]    
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    }
}
