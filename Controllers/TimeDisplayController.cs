using Microsoft.AspNetCore.Mvc;
using System;

namespace TimeDisplay.Controllers
{
    public class TimeDisplayController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.CurrentTime = CurrentTime.ToString("dddd, dd MMMM yyyy");
            return View();
        }
    }
}