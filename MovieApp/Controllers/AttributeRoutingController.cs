using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers;

public class AttributeRoutingController : Controller
{
    [Route("customrouting/attributeRoute")]
    public IActionResult Index()
    {
        ViewBag.Title = "Attribute Routing Controller";
        return View();
    }
    
}