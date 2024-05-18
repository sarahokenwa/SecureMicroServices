using Microsoft.EntityFrameworkCore;
using Movies.Client.Models;

namespace Movies.Client.Data
{
    public class DataEntities : DbContext
    {
        public DataEntities (DbContextOptions<DataEntities> options)
            : base(options)
        {
        }

        public DbSet<FilmModel> Films { get; set; } = default!;
    }
}
