using Microsoft.AspNetCore.Mvc;
using Movies.Client.ApiService;
using Movies.Client.Models;

namespace Movies.Client.Controllers
{
    public class FilmController : Controller
    {
        private readonly IFilmApiService _filmApiService;

        public FilmController(IFilmApiService filmApiService)
        {
            _filmApiService = filmApiService;
        }

        // GET: FilmModels
        public async Task<IActionResult> Index()
        {
            return View(await _filmApiService.GetFilms());
        }

        // GET: FilmModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            return View();
            //if (id == null || _context.FilmModel == null)
            //{
            //    return NotFound();
            //}

            //var filmModel = await _context.FilmModel
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (filmModel == null)
            //{
            //    return NotFound();
            //}

            //return View(filmModel);
        }

        // GET: FilmModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FilmModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Genre,CreatedOn,Rating,ImageUrl,ReleaseDate,Owner")] FilmModel filmModel)
        {

            return View();

            //if (ModelState.IsValid)
            //{
            //    _context.Add(filmModel);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(filmModel);
        }

        // GET: FilmModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();

            //if (id == null || _context.FilmModel == null)
            //{
            //    return NotFound();
            //}

            //var filmModel = await _context.FilmModel.FindAsync(id);
            //if (filmModel == null)
            //{
            //    return NotFound();
            //}
            //return View(filmModel);
        }

        // POST: FilmModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Genre,CreatedOn,Rating,ImageUrl,ReleaseDate,Owner")] FilmModel filmModel)
        {
            return View();

            //if (id != filmModel.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(filmModel);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!FilmModelExists(filmModel.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(filmModel);
        }

        // GET: FilmModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();

            //if (id == null || _context.FilmModel == null)
            //{
            //    return NotFound();
            //}

            //var filmModel = await _context.FilmModel
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (filmModel == null)
            //{
            //    return NotFound();
            //}

            //return View(filmModel);
        }

        // POST: FilmModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return View();

            //if (_context.FilmModel == null)
            //{
            //    return Problem("Entity set 'MoviesClientContext.FilmModel'  is null.");
            //}
            //var filmModel = await _context.FilmModel.FindAsync(id);
            //if (filmModel != null)
            //{
            //    _context.FilmModel.Remove(filmModel);
            //}

            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

        //private bool FilmModelExists(int id)
        //{
        //    return _filmApiService.DeleteFilm(int id);

        //    //return (_filmApiService.FilmModel?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
