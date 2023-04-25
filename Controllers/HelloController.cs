using Microsoft.AspNetCore.Mvc;
namespace QuickMaster.Controllers;

public class HelloController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Greet()
    {
        ViewBag.Message = "Hello world again!";
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Error()
    {
        return View();
    }
}