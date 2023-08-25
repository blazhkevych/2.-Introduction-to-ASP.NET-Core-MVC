using Microsoft.AspNetCore.Mvc;
using Top_10_films.Models;

namespace Top_10_films.Controllers;

public class MovieController : Controller
{
    MovieContext _context;

    public MovieController(MovieContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        IEnumerable<Movie> movies = await Task.Run(() => _context.Movies);
        ViewBag.Movies = movies;
        ViewBag.Title = "Top 10 Films";

        return View("Index");
    }
}