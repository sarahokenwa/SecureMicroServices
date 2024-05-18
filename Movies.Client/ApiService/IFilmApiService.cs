using Movies.Client.Models;

namespace Movies.Client.ApiService
{
    public interface IFilmApiService
    {
       Task<FilmModel> CreateFilm(FilmModel film);
       Task <IEnumerable<FilmModel>>GetFilms();
       Task <FilmModel>GetFilm(int id);
       
       Task<FilmModel> UpdateFilm(FilmModel film);
       Task<FilmModel> DeleteFilm(int id);
    }
}
