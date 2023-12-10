using Microsoft.AspNetCore.Mvc;
using Sql_Servis.DAL;
using Sql_Servis.Models;
using System.Diagnostics;

namespace Sql_Servis.Controllers
{
    public class HomeController : Controller
    { 
        readonly ProductDbContext _context;
        public HomeController(ProductDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {

            List<Service> service = _context.Services.ToList();
            return View(service);
        }

        public IActionResult Details(int Id)
        {
            if( Id== 0)
            {
                return BadRequest();
            }
            Service service = _context.Services.FirstOrDefault(s => s.Id == Id)!;
            if(service == null)
            {
                return NotFound();
            }
            return View(service);
        }

        
    }
}