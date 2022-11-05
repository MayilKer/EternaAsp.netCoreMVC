using FronFinalLabBack.DAL;
using FronFinalLabBack.Models;
using FronFinalLabBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronFinalLabBack.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {


            if(id == null)
            {
                BlogVM blogVM = new BlogVM
                {
                    Blogs = _context.Blogs.Include(c => c.Category).ToList(),
                    Categories = _context.Categories.Include(b => b.Blogs).ToList()
                };
                return View(blogVM);
            }
            else
            {
                BlogVM blogVM = new BlogVM
                {
                    Blogs = _context.Blogs.Include(c => c.Category).Where(b=>b.CategoryId == id).ToList(),
                    Categories = _context.Categories.Include(b => b.Blogs).ToList()
                };
                return View(blogVM);
            }
            
        }
    }
}
