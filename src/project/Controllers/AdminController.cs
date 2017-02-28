using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using project.Models;
using System.IO;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;

namespace project.Controllers
{
    public class AdminController : Controller
    {
        private readonly ProductContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public AdminController(ProductContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            if (id == null) { ViewBag.CategoryId = 0; } else { ViewBag.CategoryId = id; };
            var categoryContext = _context.Categories.Include(p => p.Products);
            var productContext = _context.Products.Include(p => p.Photos);
            return View(await productContext.ToListAsync());
        }
    }
}