using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Controllers;

public class HomeController : Controller
{
    private MovieContext context { get; set; }
    public HomeController(MovieContext ctx) {
        context = ctx;
    }
    
    public IActionResult Index()
    {
        var movies = context.Movies.Include(movie => movie.Genre).OrderBy(movie => movie.Name).ToList();
        return View(movies);
    }
}