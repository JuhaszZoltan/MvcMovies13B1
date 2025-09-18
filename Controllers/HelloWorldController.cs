using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers;

public class HelloWorldController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    //GET: /HelloWorld/Welcome
    //https://localchost:{port}//HelloWorld/Welcome?name={keresztneved}&number={korod}
    public IActionResult Welcome(string name, int age = 18)
    {
        ViewData["WelcomeMessage"] = "Hello " + name + "!";
        ViewData["Age"] = age;
        return View();
    }
}
