using FronFinalLabBack.DAL;
using FronFinalLabBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronFinalLabBack.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Portfolio> portfolios = _context.Portfolios.Include(pi => pi.PortfolioImages).ToList();
            return View(portfolios);
        }

        public IActionResult PortfolioDetail(int? id)
        {
            Portfolio portfolio = _context.Portfolios.Include(pi => pi.PortfolioImages).FirstOrDefault(p=>p.Id == id);
            return View(portfolio);
        }
    }
}
