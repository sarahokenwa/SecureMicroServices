using Microsoft.EntityFrameworkCore;
using Movies.Domain.Entities;

namespace Movies.Infrastructure.Data
{
    public class DataEntities : DbContext
    {
        public DataEntities (DbContextOptions<DataEntities> options)
            : base(options)
        {
        }
        
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Server=DUCHESS;Database=DuchessMovies;Integrated Security=True;MultipleActiveResultSets=true;";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }




    }

}
