using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HelloWorldController : Controller
    {

        public string Index()
        {
            return "This is my default project...";
        }

        public string Welcome()
        {
            return "This is the welcome action method...";
        }
    }
}
