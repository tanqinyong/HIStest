using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HIStest.Controllers

{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        // localhost:7245/HelloWorld/
        // Default method
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // localhost:7245/HelloWorld/Welcome/3?name=rick
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
        {
            // HTMLEncoder prevents XSS, do use this when displaying input back to user!
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
