using Microsoft.AspNetCore.Mvc;

namespace MvcMovies.Controllers;

public class HelloWorldController : Controller
{

    public string Index()
    {
        return "ez az alapértelmezett action";
    }

    public string Welcome()
    {
        return "ez pedig a Welcome action method...";
    }
}
