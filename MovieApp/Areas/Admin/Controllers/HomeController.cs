using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{

    public IActionResult Index()
    {
        ViewBag.Title = "Admin";
        return View();
    }
    
}