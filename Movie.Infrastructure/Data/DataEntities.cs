using Microsoft.EntityFrameworkCore;
using Movies.Domain.Entities;

namespace Movies.Infrastructure.Data
{
    public class DataEntities : DbContext
    {
        public DataEntities()
        {

        }
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(

                    new Film
                    {
                        Id = 1,
                        Genre = "Drama",
                        Name = "The Shawshank Redemption",
                        Rating = "9.3",
                        ImageUrl = "images/src",
                        ReleaseDate = new DateTime(1994, 5, 5),
                        Owner = "alice"
                    },
                    new Film
                    {
                        Id = 2,
                        Genre = "Crime",
                        Name = "The Godfather",
                        Rating = "9.2",
                        ImageUrl = "images/src",
                        ReleaseDate = new DateTime(1972, 5, 5),
                        Owner = "alice"
                    },
                    new Film
                    {
                        Id = 3,
                        Genre = "Action",
                        Name = "The Dark Knight",
                        Rating = "9.1",
                        ImageUrl = "images/src",
                        ReleaseDate = new DateTime(2008, 5, 5),
                        Owner = "bob"
                    },
                    new Film
                    {
                        Id = 4,
                        Genre = "Crime",
                        Name = "12 Angry Men",
                        Rating = "8.9",
                        ImageUrl = "images/src",
                        ReleaseDate = new DateTime(1957, 5, 5),
                        Owner = "bob"
                    },
                    new Film
                    {
                        Id = 5,
                        Genre = "Biography",
                        Name = "Schindler's List",
                        Rating = "8.9",
                        ImageUrl = "images/src",
                        ReleaseDate = new DateTime(1993, 5, 5),
                        Owner = "alice"
                    },
                    new Film
                    {
                        Id = 6,
                        Genre = "Drama",
                        Name = "Pulp Fiction",
                        Rating = "8.9",
                        ImageUrl = "images/src",
                        ReleaseDate = new DateTime(1994, 5, 5),
                        Owner = "alice"
                    },
                    new Film
                    {
                        Id = 7,
                        Genre = "Drama",
                        Name = "Fight Club",
                        Rating = "8.8",
                        ImageUrl = "images/src",
                        ReleaseDate = new DateTime(1999, 5, 5),
                        Owner = "bob"
                    },
                    new Film
                    {
                        Id = 8,
                        Genre = "Romance",
                        Name = "Forrest Gump",
                        Rating = "8.8",
                        ImageUrl = "images/src",
                        ReleaseDate = new DateTime(1994, 5, 5),
                        Owner = "bob"
                    });
        }
    }
}
