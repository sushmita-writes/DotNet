using Microsoft.AspNetCore.Mvc;
using Lab11;

namespace Lab11.Controllers
{
    public class ServiceController : Controller  
    {
        public IService _Service;
        public ServiceController(IService service)  // Constructor injection
        {
            _Service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Information()
        {
            //CsitService s = new CsitService();
            //ViewBag.Information = s.Info();
            //return View();

            //BitService s = new BitService();
            //ViewBag.Information = s.Info();
            //return View();

            /*
                Above is tight coupling.
                When there are thousands of hard-coded lines of codes like,
                it is not feasible for developers to rewrite every lines to change CsitService to BitService.

                Below is loose coupling. 
                (Using Constructor injection, most widely used among 3: constructor, method, and view injections)
                Create an object of interface that the services inherits from.
                Create a constructor that assigns a particular service's object to that object.
                Add Service in Program.cs to determine which Service to use. (before builder.Build())
            */

            ViewBag.Information = _Service.Info();
            return View();
            
        }
    }
}
