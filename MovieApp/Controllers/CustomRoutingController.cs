using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers;

public class CustomRoutingController : Controller
{
    
    public IActionResult Index()
    {
        ViewBag.Title = "Custom Routing Controller";
        return View();
    }
    
}