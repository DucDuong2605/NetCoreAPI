using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controller
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chào" + ps.Person + "=" + ps.Fullname + "=" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }

    }

}