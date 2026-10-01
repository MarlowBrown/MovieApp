using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers;

public class DefaultRoutingController : Controller
{

    public IActionResult Index()
    {
        ViewBag.Title = "Default Routing Controller";
        return View();
    }
    
}