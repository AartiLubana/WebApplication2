using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication2.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string name, int id )
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        }
    }
}
