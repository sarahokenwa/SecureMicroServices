using Movies.Client.Models;

namespace Movies.Client.ApiService
{
    public class FilmApiService : IFilmApiService
    {
        public Task<FilmModel> CreateFilm(FilmModel film)
        {
            throw new NotImplementedException();
        }

        public Task<FilmModel> DeleteFilm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FilmModel> GetFilm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FilmModel>> GetFilms()
        {
            throw new NotImplementedException();
        }

        public Task<FilmModel> UpdateFilm(FilmModel film)
        {
            throw new NotImplementedException();
        }
    }
}
