using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Encodings.Web;

namespace MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        //https://localhost:5001/HelloWorld.
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default project...";
        }

        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the welcome action method...";
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //Run the app and browse to: https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4. Replace {PORT} with your port number.


        public string SystemTextEncodingWeb(string name, int numTimes =1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is : {numTimes}");
        }
    }
}
