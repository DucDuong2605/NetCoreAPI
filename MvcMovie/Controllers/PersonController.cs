using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MvcMovie.Controller;
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
