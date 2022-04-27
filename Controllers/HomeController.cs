using ANDREYRK.Entities;
using ANDREYRK.Models;
using Microsoft.AspNetCore.Mvc;

namespace ANDREYRK.Controllers
{
    public class HomeController : Controller
    {
        private readonly BaseContext db;

        public HomeController(BaseContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            db.IpLogs.Add(new IpLog
            {
                Date = DateTime.Now,
                Address = HttpContext.Connection.RemoteIpAddress?.ToString(),
                Path = "/"
            });
            db.SaveChanges();

            return View();
        }

        [HttpGet("Log")]
        public IActionResult Log(string password)
        {
            if (password == "P8JYrzSXxE")
            {
                return View(new LogViewModel { data = db.IpLogs.ToList() });
            } else
            {
                return new NotFoundResult();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string error)
        {
            ViewData["Message"] = error;
            return View();
        }
    }
}