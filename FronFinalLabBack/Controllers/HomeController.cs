using FronFinalLabBack.DAL;
using FronFinalLabBack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronFinalLabBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<IndexSlider> indexSliders = _context.IndexSliders.ToList();
            return View(indexSliders);
        }
    }
}
